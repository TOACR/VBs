Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Categorías
        Cmb_categoria.Items.Clear()
        Cmb_categoria.Items.AddRange(New Object() {"OFICINISTA", "TECNICO", "PROFESIONAL"})

        ' Anualidades 0..30
        Cmb_anualidad.Items.Clear()
        For i As Integer = 0 To 30
            Cmb_anualidad.Items.Add(i.ToString())
        Next
        Cmb_anualidad.SelectedIndex = 0

        ' Máscara identificación
        Msk_id.Mask = "9-9999-9999"

        ' Marcar de solo lectura los de salida (evita edición manual)
        For Each tb In New TextBox() {Txtsalario_base, TxtDE, TxtAnualidades, TxtTarifaHE, TxtMontoHE, TxtCCSS, TxtAsociacion, TxtRenta, Txtsalario_bruto, Txtdeducciones, Txtsalario_neto}
            tb.ReadOnly = True
        Next
        ' Si se solicita mostras los tramos de la renta:
        ' For Each tb In New TextBox() {TxtRenta2, TxtRenta3, TxtRenta4}
        '     tb.ReadOnly = True
        ' Next
    End Sub

    ' ===== Botón Calcular =====
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        ' Validaciones mínimas
        If String.IsNullOrWhiteSpace(Cmb_categoria.Text) Then
            MsgBox("Seleccione una categoría.", MsgBoxStyle.Exclamation)
            Cmb_categoria.Focus()
            Exit Sub
        End If

        If Not Msk_id.MaskFull Then
            MsgBox("La identificación debe cumplir el formato 9-9999-9999.", MsgBoxStyle.Exclamation)
            Msk_id.Focus()
            Exit Sub
        End If

        If Val(Txtextra.Text) > 60 Then
            MsgBox("El máximo de horas extra es 60.", MsgBoxStyle.Exclamation)
            Txtextra.Focus()
            Txtextra.SelectAll()
            Exit Sub
        End If

        RecalcularTodo()
    End Sub

    ' ===== Núcleo de cálculo =====
    Private Sub RecalcularTodo()
        Dim salarioBase As Double = GetSalarioBase(Cmb_categoria.Text)
        If salarioBase = 0 Then
            LimpiarResultados()
            Exit Sub
        End If

        ' 55% dedicación exclusiva
        Dim dedicacionExclusiva As Double = salarioBase * 0.55

        ' Anualidades según categoría
        Dim cantAnualidades As Integer = 0
        Integer.TryParse(Cmb_anualidad.Text, cantAnualidades)
        Dim porcentajeAnualidad As Double = GetPorcentajeAnualidad(Cmb_categoria.Text)
        Dim montoAnualidades As Double = salarioBase * porcentajeAnualidad * cantAnualidades

        ' Bruto sin extras
        Dim salarioBrutoSinExtras As Double = salarioBase + dedicacionExclusiva + montoAnualidades

        ' Horas extra: (bruto sin extras / 160) * 1.5 * horas
        Dim horasExtra As Integer = 0
        Integer.TryParse(Txtextra.Text, horasExtra)
        Dim tarifaHoraExtra As Double = (salarioBrutoSinExtras / 160.0) * 1.5
        Dim montoHorasExtra As Double = tarifaHoraExtra * horasExtra

        ' Bruto total
        Dim salarioBruto As Double = salarioBrutoSinExtras + montoHorasExtra

        ' Deducciones sobre bruto
        Dim deduccionCCSS As Double = salarioBruto * 0.1033
        Dim deduccionSolidarista As Double = salarioBruto * 0.05

        ' Renta marginal (tramos) con desglose
        Dim r2 As Double, r3 As Double, r4 As Double
        Dim rentaTotal As Double = CalcularRentaMarginalConTramos(salarioBruto, r2, r3, r4)

        ' Total deducciones y neto
        Dim totalDeducciones As Double = deduccionCCSS + deduccionSolidarista + rentaTotal
        Dim salarioNeto As Double = salarioBruto - totalDeducciones

        ' Salidas (formato)
        TxtDE.Text = dedicacionExclusiva.ToString("N2")
        TxtAnualidades.Text = montoAnualidades.ToString("N2")
        TxtTarifaHE.Text = tarifaHoraExtra.ToString("N2")
        TxtMontoHE.Text = montoHorasExtra.ToString("N2")

        TxtCCSS.Text = deduccionCCSS.ToString("N2")
        TxtAsociacion.Text = deduccionSolidarista.ToString("N2")
        TxtRenta.Text = rentaTotal.ToString("N2")

        Txtsalario_bruto.Text = salarioBruto.ToString("N2")
        Txtdeducciones.Text = totalDeducciones.ToString("N2")
        Txtsalario_neto.Text = salarioNeto.ToString("N2")

        ' Si se requiere mostrar los tramos y hay que crear los Txtbox:
        ' TxtRenta2.Text = r2.ToString("N2")
        ' TxtRenta3.Text = r3.ToString("N2")
        ' TxtRenta4.Text = r4.ToString("N2")
    End Sub

    Private Function GetSalarioBase(categoria As String) As Double
        Select Case categoria
            Case "OFICINISTA" : Return 500000
            Case "TECNICO" : Return 850000
            Case "PROFESIONAL" : Return 1100000
            Case Else : Return 0
        End Select
    End Function

    Private Sub Cmb_categoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_categoria.SelectedIndexChanged
        Dim salarioBase As Double = 0

        Select Case Cmb_categoria.Text
            Case "OFICINISTA"
                salarioBase = 500000
            Case "TECNICO"
                salarioBase = 850000
            Case "PROFESIONAL"
                salarioBase = 1100000
        End Select

        ' Muestra el salario base en el TextBox correspondiente
        Txtsalario_base.Text = salarioBase.ToString("N2")
    End Sub


    Private Function GetPorcentajeAnualidad(categoria As String) As Double
        Select Case categoria
            Case "OFICINISTA" : Return 0.023   ' 2.3%
            Case "TECNICO" : Return 0.02    ' 2.0%
            Case "PROFESIONAL" : Return 0.015   ' 1.5%
            Case Else : Return 0
        End Select
    End Function

    Private Function CalcularRentaMarginalConTramos(bruto As Double, ByRef tramo2 As Double, ByRef tramo3 As Double, ByRef tramo4 As Double) As Double
        tramo2 = 0 : tramo3 = 0 : tramo4 = 0

        ' 2% sobre 750,001 – 1,000,000
        If bruto > 750001 AndAlso bruto <= 1000000 Then
            tramo2 = (bruto - 750000) * 0.02
        End If
        ' 3% sobre 1,000,001 – 2,000,000
        If bruto > 1000001 AndAlso bruto <= 2000000 Then
            tramo3 = (bruto - 1000000) * 0.03
        End If
        ' 4% sobre > 2,000,000
        If bruto > 2000001 Then
            tramo4 = (bruto - 2000000) * 0.04
        End If

        Return tramo2 + tramo3 + tramo4
    End Function

    ' ===== Validadores de entrada (opcional mantener) =====
    Private Sub Txtnombre_Keypress(sender As Object, e As EventArgs) Handles Txtnombre.KeyPress
        set_solo_letras(e)
    End Sub
    Private Sub Txtnombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Txtnombre.Validating
        ' Si el campo está vacío o solo contiene espacios o si se da TAB sin datos
        If String.IsNullOrWhiteSpace(Txtnombre.Text) Then
            MsgBox("Debe registrar el nombre.", MsgBoxStyle.Exclamation, "Campo obligatorio")
            e.Cancel = True      ' Evita que pierda el foco
            Txtnombre.Focus()    ' Regresa el cursor al mismo campo
        End If
    End Sub
    Private Sub Txtprimer_apellido_Keypress(sender As Object, e As EventArgs) Handles Txtprimer_apellido.KeyPress
        set_solo_letras(e)
    End Sub
    Private Sub Txtprimer_apellido_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Txtprimer_apellido.Validating
        ' Si el campo está vacío o solo contiene espacios o si se da TAB sin datos
        If String.IsNullOrWhiteSpace(Txtprimer_apellido.Text) Then
            MsgBox("Debe registrar el primer apellido.", MsgBoxStyle.Exclamation, "Campo obligatorio")
            e.Cancel = True      ' Evita que pierda el foco
            Txtnombre.Focus()    ' Regresa el cursor al mismo campo
        End If
    End Sub
    Private Sub Txtsegundo_apellido_Keypress(sender As Object, e As EventArgs) Handles Txtsegundo_apellido.KeyPress
        set_solo_letras(e)
    End Sub
    Private Sub Txtsegundo_apellido_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Txtsegundo_apellido.Validating
        ' Si el campo está vacío o solo contiene espacios o si se da TAB sin datos
        If String.IsNullOrWhiteSpace(Txtsegundo_apellido.Text) Then
            MsgBox("Debe registrar el segundo apellido.", MsgBoxStyle.Exclamation, "Campo obligatorio")
            e.Cancel = True      ' Evita que pierda el foco
            Txtnombre.Focus()    ' Regresa el cursor al mismo campo
        End If
    End Sub
    Private Sub Txtextra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtextra.KeyPress
        set_solo_numeros(e)
    End Sub
    Private Sub Txtextra_Lostfocus(sender As Object, e As EventArgs) Handles Txtextra.LostFocus
        If Val(Txtextra.Text) > "60" Then
            MsgBox("El máximo de horas extra es 60")
            Txtextra.Focus()
        End If
    End Sub
    Private Sub Txtsalario_bruto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtsalario_bruto.KeyPress
        e.Handled = True ' calculado
    End Sub
    Private Sub Txtdeducciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtdeducciones.KeyPress
        e.Handled = True ' calculado
    End Sub
    Private Sub Txtsalario_neto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtsalario_neto.KeyPress
        e.Handled = True ' calculado
    End Sub

    Private Sub LimpiarResultados()
        For Each tb In New TextBox() {TxtDE, TxtAnualidades, TxtTarifaHE, TxtMontoHE, TxtCCSS, TxtAsociacion, TxtRenta, Txtsalario_bruto, Txtdeducciones, Txtsalario_neto}
            tb.Text = ""
        Next
        ' Si se requiere limpiar los tramos:
        ' For Each tb In New TextBox() {TxtRenta2, TxtRenta3, TxtRenta4}
        '     tb.Text = ""
        ' Next
    End Sub

End Class

