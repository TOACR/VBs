Imports System.Drawing.Text

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbCategoria.Items.Clear()
        CmbCategoria.Items.AddRange(New Object() {"RESIDENCIAL", "COMERCIAL", "INDUSTRIAL"})
    End Sub
    Private Sub TxtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtID.KeyPress
        set_solo_numeros(e)
    End Sub
    Private Sub TxtConsumo_KeyPress(sender As Object, e As EventArgs) Handles TxtConsumo.KeyPress
        set_solo_numeros(e)
    End Sub
    Private Sub TxtID_Validating(sender As Object, e As EventArgs) Handles TxtID.Validating
        If TxtID.Text.Length = 0 Then
            MsgBox("El campo ID no puede estar vacío", MsgBoxStyle.Exclamation, "Validación")
            TxtID.Focus()
        End If
    End Sub
    Private Sub TxtConsumo_Validating(sender As Object, e As EventArgs) Handles TxtConsumo.Validating
        If TxtConsumo.Text.Length = 0 Then
            MsgBox("El campo Consumo no puede estar vacío", MsgBoxStyle.Exclamation, "Validación")
            TxtConsumo.Focus()
        End If

    End Sub
    Private Sub CmbCategoria_Validating(sender As Object, e As EventArgs) Handles CmbCategoria.Validating
        If CmbCategoria.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una categoría", MsgBoxStyle.Exclamation, "Validación")
            CmbCategoria.Focus()
        End If
    End Sub
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim idCliente As String = TxtID.Text
        Dim consumo As Double = Val(TxtConsumo.Text)
        Dim categoria As String = CmbCategoria.SelectedItem.ToString()
        Dim total As Double = 0
        Dim tarifa_base As Double = 0
        Dim cargo_fijo As Double = 2500
        Dim mensaje As String = ""

        Select Case categoria
            Case "RESIDENCIAL"
                tarifa_base = 150
                total = cargo_fijo + (tarifa_base * consumo)
                If consumo > 500 Then
                    total += total * 0.05  'Recargo del 5%
                End If
            Case "COMERCIAL"
                tarifa_base = 200
                total = cargo_fijo + (tarifa_base * consumo)
                If consumo < 300 Then
                    total -= total * 0.01  'Descuento del 1%
                End If
            Case "INDUSTRIAL"
                tarifa_base = 250
                total = cargo_fijo + (tarifa_base * consumo)
                If consumo > 1000 Then
                    total += total * 0.08 ' recargo del 8%
                End If
        End Select

        mensaje = "ID Cliente: " & idCliente & vbCrLf &
                  "Categoría: " & categoria & vbCrLf &
                  "Consumo: " & consumo & " Kw" & vbCrLf &
                  "Tarifa Base: ₡" & tarifa_base & vbCrLf &
                  "Cargo Fijo: ₡" & cargo_fijo & vbCrLf

        TxtResultado.Text = mensaje
        TxtPago.Text = "₡ " & total.ToString("N2")
    End Sub
End Class
