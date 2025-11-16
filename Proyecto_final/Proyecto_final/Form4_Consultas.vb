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
        LimpiarControles(Me)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim fId = CInt(CboFuncionario.SelectedValue)
        Dim desde = DtpDesde.Value.Date
        Dim hasta = DtpHasta.Value.Date

        Dim q As String = "
    SELECT 'Consumo' AS Tipo, c.Fecha, co.Nombre AS Detalle, c.Cantidad, c.PrecioUnitario, c.MontoTotal
    FROM Consumo c
    INNER JOIN Consumible co ON co.ConsumibleId=c.ConsumibleId
    WHERE c.FuncionarioId=@f AND CAST(c.Fecha AS DATE) BETWEEN @d AND @h
    UNION ALL
    SELECT 'Adelanto' AS Tipo, a.Fecha, 'Adelanto' AS Detalle, NULL, NULL, a.Monto
    FROM Adelanto a
    WHERE a.FuncionarioId=@f AND CAST(a.Fecha AS DATE) BETWEEN @d AND @h
    ORDER BY Fecha DESC"

        Dim p = New List(Of SqlParameter) From {
        New SqlParameter("@f", fId),
        New SqlParameter("@d", desde),
        New SqlParameter("@h", hasta)
    }

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

        ' 🔹 Total general = consumos + adelantos
        Dim totalGeneral As Decimal = CDec(totalConsumos) + CDec(totalAdelantos)
        LblTotalConsumos.Text = "Total General: " & totalGeneral.ToString("C2")
    End Sub
    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class
