Imports System.Data.SqlClient

Public Class Form4_Consultas
    Private Sub Form4_Consultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Consultas"
        Dim dt = Db.GetTable("SELECT FuncionarioId, Nombre FROM Funcionario WHERE Activo=1 ORDER BY Nombre", Nothing)
        EstiloProfesionalDataGrid(DgvResultado)
        CboFuncionario.DisplayMember = "Nombre"
        CboFuncionario.ValueMember = "FuncionarioId"
        CboFuncionario.DataSource = dt
        Me.AcceptButton = BtnBuscar
        DtpDesde.Value = New Date(Now.Year, Now.Month, 1)
        DtpHasta.Value = Date.Today
        CboRangoRapido.DropDownStyle = ComboBoxStyle.DropDownList
        CboRangoRapido.Items.Clear()
        CboRangoRapido.Items.Add("1 mes")
        CboRangoRapido.Items.Add("3 meses")
        CboRangoRapido.Items.Add("6 meses")
        CboRangoRapido.Items.Add("12 meses")
        CboRangoRapido.SelectedIndex = 0
        LimpiarControles(Me)
    End Sub

    ' Mostrar movimientos según el rango de fechas seleccionado
    Private Sub BtnMostrarMovs_Click(sender As Object, e As EventArgs) Handles BtnMostrarMovs.Click
            Dim funcId As Integer = If(CboFuncionario.SelectedIndex >= 0, CInt(CboFuncionario.SelectedValue), -1)

            Dim desde As Date = DtpDesde.Value.Date
            Dim hasta As Date = DtpHasta.Value.Date

            If desde > hasta Then
                MessageBox.Show("Rango de fechas inválido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

        ' Query para obtener funcionario, consumos y adelantos
        Dim q As String = "SELECT *FROM (SELECT f.Nombre AS Funcionario,'Consumo' AS Tipo, c.Fecha, co.Nombre AS Detalle, c.Cantidad,
        c.PrecioUnitario, c.MontoTotal, CASE WHEN c.Liquidado = 1 THEN 'Liquidado' ELSE 'Pendiente' END AS Estado
        FROM Consumo c INNER JOIN Consumible co ON co.ConsumibleId = c.ConsumibleId INNER JOIN Funcionario f ON f.FuncionarioId = c.FuncionarioId
        WHERE (@f = -1 OR c.FuncionarioId = @f)
        AND CAST(c.Fecha AS date) BETWEEN @d AND @h

        UNION ALL

        SELECT f.Nombre AS Funcionario, 'Adelanto' AS Tipo, a.Fecha, 'Adelanto' AS Detalle, NULL AS Cantidad, NULL AS PrecioUnitario, a.Monto AS MontoTotal,
        CASE WHEN a.Liquidado = 1 THEN 'Liquidado' ELSE 'Pendiente' END AS Estado
        FROM Adelanto a INNER JOIN Funcionario f ON f.FuncionarioId = a.FuncionarioId
        WHERE (@f = -1 OR a.FuncionarioId = @f)
        AND CAST(a.Fecha AS date) BETWEEN @d AND @h) X
        ORDER BY Fecha DESC;"

        Dim p As New List(Of SqlClient.SqlParameter) From {
            New SqlClient.SqlParameter("@f", funcId),
            New SqlClient.SqlParameter("@d", desde),
            New SqlClient.SqlParameter("@h", hasta)}

        ' Mostrar resultados en DgvResultado
        DgvResultado.DataSource = Db.GetTable(q, p)
        End Sub

        ' Mostrar los movimientos de los últimos 30 días (opcional)
        Private Sub BtnUltimoMes_Click(sender As Object, e As EventArgs) Handles BtnUltimoMes.Click
            DtpHasta.Value = Date.Today
            DtpDesde.Value = Date.Today.AddMonths(-1)
            BtnMostrarMovs.PerformClick() ' Llamar al botón para mostrar movimientos
        End Sub

    ' Aplicar rangos rápidos (1 mes, 3 meses, 6 meses, 1 año)
    Private Sub BtnAplicarRango_Click(sender As Object, e As EventArgs) Handles BtnAplicarRango.Click
        Dim meses As Integer = 0

        Select Case CboRangoRapido.Text
            Case "1 mes" : meses = 1
            Case "3 meses" : meses = 3
            Case "6 meses" : meses = 6
            Case "12 meses" : meses = 12
            Case Else
                MessageBox.Show("Seleccione un rango.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
        End Select

        DtpHasta.Value = Date.Today
        DtpDesde.Value = Date.Today.AddMonths(-meses)
        BtnMostrarMovs.PerformClick() ' Llamar al botón para mostrar movimientos
    End Sub

    ' Buscar movimientos del funcionario en el rango de fechas
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim funcId = CInt(CboFuncionario.SelectedValue)
        Dim desde = DtpDesde.Value.Date
        Dim hasta = DtpHasta.Value.Date

        Dim q As String = "SELECT * FROM (SELECT f.Nombre AS Funcionario, 'Consumo' AS Tipo, c.Fecha, co.Nombre AS Detalle, c.Cantidad, 
        c.PrecioUnitario, c.MontoTotal,
        CASE WHEN ISNULL(c.Liquidado,0) = 1 THEN 'Liquidado' ELSE 'Pendiente' END AS Estado
        FROM Consumo c INNER JOIN Consumible co ON co.ConsumibleId = c.ConsumibleId INNER JOIN Funcionario f ON f.FuncionarioId = c.FuncionarioId
        WHERE (@f = -1 OR c.FuncionarioId = @f)
        AND c.Fecha >= @d AND c.Fecha < DATEADD(DAY, 1, @h)

        UNION ALL

        SELECT f.Nombre AS Funcionario, 'Adelanto' AS Tipo, a.Fecha, 'Adelanto' AS Detalle, NULL AS Cantidad, NULL AS PrecioUnitario, a.Monto AS MontoTotal,
        CASE WHEN ISNULL(a.Liquidado,0) = 1 THEN 'Liquidado' ELSE 'Pendiente' END AS Estado
        FROM Adelanto a INNER JOIN Funcionario f ON f.FuncionarioId = a.FuncionarioId
        WHERE (@f = -1 OR a.FuncionarioId = @f) AND a.Fecha >= @d AND a.Fecha < DATEADD(DAY, 1, @h)) X
        ORDER BY Fecha DESC;"

        Dim p As New List(Of SqlParameter) From {
        New SqlParameter("@f", funcId),
        New SqlParameter("@d", desde.Date),
        New SqlParameter("@h", hasta.Date)}

        Dim dt = Db.GetTable(q, p)
        DgvResultado.DataSource = dt

        ' Totales individuales:
        Dim totalConsumos = Db.ExecScalar("
        SELECT COALESCE(SUM(MontoTotal),0) FROM Consumo 
        WHERE FuncionarioId=@f AND CAST(Fecha AS DATE) BETWEEN @d AND @h",
        p)

        Dim totalAdelantos = Db.ExecScalar("
        SELECT COALESCE(SUM(Monto),0) FROM Adelanto 
        WHERE FuncionarioId=@f AND CAST(Fecha AS DATE) BETWEEN @d AND @h",
        p)

        ' Mostrar totales individuales
        LblTotalConsumibles.Text = "Consumos: " & CDec(totalConsumos).ToString("C2")
        LblTotalAdelantos.Text = "Adelantos: " & CDec(totalAdelantos).ToString("C2")

        ' Total general = consumos + adelantos
        Dim totalGeneral As Decimal = CDec(totalConsumos) + CDec(totalAdelantos)
        LblTotalConsumos.Text = "Total General: " & totalGeneral.ToString("C2")
    End Sub

    ' Formatear celdas según el estado (Liquidado/Pendiente)
    Private Sub DgvResultado_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvResultado.CellFormatting
        If DgvResultado.Columns.Contains("Funcionario") Then
            DgvResultado.Columns("Funcionario").DisplayIndex = 0
            DgvResultado.Columns("Funcionario").HeaderText = "Funcionario"
        End If

        ' Detectar columna Estado
        If DgvResultado.Columns(e.ColumnIndex).Name = "Estado" Then
            If e.Value IsNot Nothing Then
                Dim texto = e.Value.ToString()

                ' 🔥 Limpiar estilo previo que esté sobrescribiendo
                e.CellStyle.ForeColor = Color.Black
                e.CellStyle.BackColor = Color.White
                e.CellStyle.ApplyStyle(New DataGridViewCellStyle()) ' Limpia todo estilo heredado

                ' 🔥 Aplicar color corrector SIEMPRE
                If texto = "Liquidado" Then
                    e.CellStyle.ForeColor = Color.Green
                    e.CellStyle.Font = New Font(e.CellStyle.Font, FontStyle.Bold)

                ElseIf texto = "Pendiente" Then
                    e.CellStyle.ForeColor = Color.Red
                    e.CellStyle.Font = New Font(e.CellStyle.Font, FontStyle.Bold)
                End If

                e.FormattingApplied = True   ' Obligamos a usar nuestro estilo
            End If
        End If
    End Sub

    ' Regresar al formulario principal
    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class
