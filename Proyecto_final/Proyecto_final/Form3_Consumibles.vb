Imports System.Data.SqlClient
Imports System.Threading

Public Class Form3_Consumibles
    Public Sub Form3_Consumibles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Consumibles"
        EstiloProfesionalDataGrid(DgvMovs)
        CargarFuncionarios()
        CargarConsumibles()
        DtpDesde.Value = New Date(Now.Year, Now.Month, If(Now.Day <= 15, 1, 16))
        DtpHasta.Value = New Date(Now.Year, Now.Month, If(Now.Day <= 15, 15, Date.DaysInMonth(Now.Year, Now.Month)))
        LimpiarControles(Me)
        NumCantidad.Value = 0
        ' Cargar rangos rápidos (una sola vez)
        CboRangoRapido.DropDownStyle = ComboBoxStyle.DropDownList
        CboRangoRapido.Items.Clear()
        CboRangoRapido.Items.Add("1 mes")
        CboRangoRapido.Items.Add("3 meses")
        CboRangoRapido.Items.Add("6 meses")
        CboRangoRapido.Items.Add("12 meses")
        CboRangoRapido.SelectedIndex = 0

    End Sub

    ' Solo permitir números en TxtMontoAdelanto
    Private Sub TxtMontoAdelanto_KeyPress(sender As Object, e As EventArgs) Handles TxtMontoAdelanto.KeyPress
        Set_solo_numeros(e)
    End Sub

    ' Cargar funcionarios activos en el combo
    Private Sub CargarFuncionarios()
        Dim dt = Db.GetTable("SELECT FuncionarioId, Nombre FROM Funcionario WHERE Activo=1 ORDER BY Nombre", Nothing)
        CboFuncionario.DisplayMember = "Nombre"
        CboFuncionario.ValueMember = "FuncionarioId"
        CboFuncionario.DataSource = dt
    End Sub

    ' Cargar consumibles activos en el combo
    Public Sub CargarConsumibles()
        Dim dt = Db.GetTable("SELECT ConsumibleId, Nombre, Precio FROM Consumible WHERE Activo = 1 ORDER BY Nombre", Nothing)
        CboConsumible.DisplayMember = "Nombre"
        CboConsumible.ValueMember = "ConsumibleId"
        CboConsumible.DataSource = dt
    End Sub

    ' Refrescar movimientos al cambiar funcionario
    Private Sub CboFuncionario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboFuncionario.SelectedIndexChanged
        If CboFuncionario.SelectedIndex < 0 Then Exit Sub
        RefrescarMovs()
    End Sub

    ' Actualizar precio al cambiar consumible
    Private Sub CboConsumible_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboConsumible.SelectedIndexChanged
        If CboConsumible.SelectedIndex >= 0 Then
            Dim dt = CType(CboConsumible.DataSource, DataTable)
            Dim row = dt.Rows(CboConsumible.SelectedIndex)
            TxtPrecio.Text = CDec(row("Precio")).ToString("N2")
        End If
    End Sub

    ' Agregar consumo
    Private Sub BtnAgregarConsumo_Click(sender As Object, e As EventArgs) Handles BtnAgregarConsumo.Click

        If CboFuncionario.SelectedIndex < 0 OrElse CboConsumible.SelectedIndex < 0 Then
            MessageBox.Show("Seleccione funcionario y consumible.")
            Exit Sub
        End If

        Dim funcName As String = CboFuncionario.Text
        Dim funcId = CInt(CboFuncionario.SelectedValue)
        Dim consId = CInt(CboConsumible.SelectedValue)

        Dim precio As Decimal
        If Not Decimal.TryParse(TxtPrecio.Text, precio) Then
            MessageBox.Show("Precio inválido.")
            Exit Sub
        End If

        Dim cant = CInt(NumCantidad.Value)
        If cant <= 0 Then
            MessageBox.Show("Cantidad debe ser mayor a 0.")
            Exit Sub
        End If

        ' Query para insertar y devolver el ID recién creado
        Dim q As String = "
        INSERT INTO Consumo (FuncionarioId, ConsumibleId, Cantidad, PrecioUnitario)
        VALUES (@f,@c,@cant,@precio); SELECT SCOPE_IDENTITY();"

        ' Parámetros del insert
        Dim p As New List(Of SqlParameter) From {
        New SqlParameter("@f", funcId),
        New SqlParameter("@c", consId),
        New SqlParameter("@cant", cant),
        New SqlParameter("@precio", precio)}

        ' Ejecutamos y obtenemos el ID nuevo
        Dim nuevoId As Integer = CInt(Db.ExecScalar(q, p))

        ' Registrar en bitácora
        RegistrarBitacora(
        accion:="INSERT",
        tabla:="CONSUMO",
        llave:=UsuarioActual,
        descripcion:=$"Se registró consumo. FuncionarioId={funcId}, Funcionario='{funcName}', ConsumibleId={consId}, Cantidad={cant}, PrecioUnitario={precio}")

        ' Refrescar tabla
        RefrescarMovs()
        MessageBox.Show("Consumo registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Registrar adelanto
    Private Sub BtnRegistrarAdelanto_Click(sender As Object, e As EventArgs) Handles BtnRegistrarAdelanto.Click
        If CboFuncionario.SelectedIndex < 0 Then
            MessageBox.Show("Seleccione funcionario.")
            Exit Sub
        End If
        Dim funcName As String = CboFuncionario.Text
        Dim funcId = CInt(CboFuncionario.SelectedValue)
        Dim monto As Decimal
        If Not Decimal.TryParse(TxtMontoAdelanto.Text, monto) OrElse monto <= 0D Then
            MessageBox.Show("Monto de adelanto inválido.")
            Exit Sub
        End If
        Db.ExecNonQuery("
            INSERT INTO Adelanto (FuncionarioId, Monto)
            VALUES (@f,@m)",
            New List(Of SqlParameter) From {
                New SqlParameter("@f", CInt(CboFuncionario.SelectedValue)),
                New SqlParameter("@m", monto)
            })
        ' Registrar en bitácora
        RegistrarBitacora(
        accion:="INSERT",
        tabla:="ADELANTO",
        llave:=UsuarioActual,
        descripcion:=$"Se registró un adelanto. FuncionarioId={funcId}, Funcionario='{funcName}', Monto={monto}")
        RefrescarMovs()
        MessageBox.Show("Adelanto registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        TxtMontoAdelanto.Clear()
    End Sub

    ' Obtener detalle de la liquidación para el ticket
    Private Function ObtenerDetalleLiquidacion(funcId As Integer, desde As Date, hasta As Date) As DataTable
        Dim q As String = "
        SELECT 'Consumo' AS Tipo, CAST(c.Fecha AS date) AS Fecha, co.Nombre AS Detalle, c.Cantidad, c.PrecioUnitario, c.MontoTotal AS Monto
        FROM Consumo c INNER JOIN Consumible co ON co.ConsumibleId = c.ConsumibleId
        WHERE c.FuncionarioId = @f AND CAST(c.Fecha AS date) BETWEEN @d AND @h

        UNION ALL

        SELECT 'Adelanto' AS Tipo, CAST(a.Fecha AS date) AS Fecha, 'Adelanto' AS Detalle, NULL AS Cantidad, NULL AS PrecioUnitario, a.Monto AS Monto
        FROM Adelanto a
        WHERE a.FuncionarioId = @f
          AND CAST(a.Fecha AS date) BETWEEN @d AND @h
        ORDER BY Fecha ASC, Tipo ASC, Detalle ASC;"

        Dim p As New List(Of SqlClient.SqlParameter) From {
        New SqlClient.SqlParameter("@f", funcId),
        New SqlClient.SqlParameter("@d", desde),
        New SqlClient.SqlParameter("@h", hasta)}

        Return Db.GetTable(q, p)
    End Function

    ' Construir el texto del ticket de liquidación
    Private Function ConstruirTicket(funcNombre As String, funcId As Integer, desde As Date, hasta As Date,
                                     detalle As DataTable, total As Decimal) As String
        Dim sb As New System.Text.StringBuilder()

        ' Ancho recomendado (ajusta si tu impresora es 58mm)
        Dim w As Integer = 42

        Dim Linea As String = New String("-"c, w)

        sb.AppendLine(Centrar("RECIBO DE LIQUIDACIÓN", w))
        sb.AppendLine(Linea)
        sb.AppendLine("Funcionario: " & funcNombre)
        sb.AppendLine("ID: " & funcId.ToString())
        sb.AppendLine("Rango: " & desde.ToString("dd/MM/yyyy") & " - " & hasta.ToString("dd/MM/yyyy"))
        sb.AppendLine("Fecha: " & Date.Now.ToString("dd/MM/yyyy HH:mm"))
        sb.AppendLine(Linea)
        sb.AppendLine(Ajustar("DETALLE", w - 12) & AjustarDerecha("MONTO", 12))
        sb.AppendLine(Linea)

        For Each r As DataRow In detalle.Rows
            Dim tipo As String = r("Tipo").ToString()
            Dim det As String = r("Detalle").ToString()
            Dim monto As Decimal = CDec(r("Monto"))

            ' Para consumos, opcional: agregar "Cant x Precio" en el detalle
            If tipo = "Consumo" AndAlso Not IsDBNull(r("Cantidad")) AndAlso Not IsDBNull(r("PrecioUnitario")) Then
                Dim cant As Integer = CInt(r("Cantidad"))
                Dim pu As Decimal = CDec(r("PrecioUnitario"))
                det = $"{det} ({cant}x{pu.ToString("N2")})"
            End If

            ' Acotar largo para que no rompa el ticket
            det = Limitar(det, w - 12)

            sb.AppendLine(Ajustar(det, w - 12) & AjustarDerecha(monto.ToString("N2"), 12))
        Next

        sb.AppendLine(Linea)
        sb.AppendLine(Ajustar("TOTAL A DESCONTAR:", w - 12) & AjustarDerecha(total.ToString("N2"), 12))
        sb.AppendLine(Linea)
        sb.AppendLine(Centrar("Gracias", w))
        sb.AppendLine(vbCrLf & vbCrLf) ' espacio para corte

        Return sb.ToString()
    End Function

    ' Ajustar texto a la izquierda
    Private Function Ajustar(t As String, n As Integer) As String
        If t Is Nothing Then t = ""
        If t.Length > n Then Return t.Substring(0, n)
        Return t.PadRight(n)
    End Function

    ' Ajustar texto a la derecha
    Private Function AjustarDerecha(t As String, n As Integer) As String
        If t Is Nothing Then t = ""
        If t.Length > n Then Return t.Substring(0, n)
        Return t.PadLeft(n)
    End Function

    ' Centrar texto
    Private Function Centrar(t As String, w As Integer) As String
        If t Is Nothing Then t = ""
        If t.Length >= w Then Return t.Substring(0, w)
        Dim left = (w - t.Length) \ 2
        Return New String(" "c, left) & t
    End Function

    ' Limitar texto y agregar "…" si es necesario
    Private Function Limitar(t As String, maxLen As Integer) As String
        If t Is Nothing Then Return ""
        If t.Length <= maxLen Then Return t
        Return t.Substring(0, Math.Max(0, maxLen - 1)) & "…"
    End Function
    Private _ticketTexto As String = ""

    ' Imprimir ticket en impresora
    Private Sub ImprimirTicket(ticket As String)
        _ticketTexto = ticket
        Dim pd As New Printing.PrintDocument()
        ' Opcional: escoger impresora (si no, usa la predeterminada)
        ' pd.PrinterSettings.PrinterName = "Nombre de tu impresora térmica"
        AddHandler pd.PrintPage, AddressOf Pd_PrintPage
        ' Imprimir directo:
        pd.Print()
    End Sub

    ' Evento para imprimir la página
    Private Sub Pd_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        Using f As New Font("Consolas", 9) ' monoespaciada (clave para alinear)
            Dim marginLeft As Single = 5
            Dim marginTop As Single = 5
            e.Graphics.DrawString(_ticketTexto, f, Brushes.Black, marginLeft, marginTop)
        End Using

        e.HasMorePages = False
    End Sub

    ' Liquidar quincena
    Private Sub BtnLiquidar_Click(sender As Object, e As EventArgs) Handles BtnLiquidar.Click
        ' Pedir credenciales de ADMIN
        Using frmLogin As New FormLogin("ADMIN", True)
            Dim r = frmLogin.ShowDialog(Me)
            If r <> DialogResult.OK OrElse Not frmLogin.LoginOK Then
                MessageBox.Show("Acceso denegado. Debe autenticarse como ADMIN.", "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End Using

        If CboFuncionario.SelectedIndex < 0 Then
            MessageBox.Show("Seleccione funcionario.")
            Exit Sub
        End If

        Dim funcId As Integer = CInt(CboFuncionario.SelectedValue)
        Dim funcNombre As String = CboFuncionario.Text

        Dim desde As Date = DtpDesde.Value.Date
        Dim hasta As Date = DtpHasta.Value.Date
        If desde > hasta Then
            MessageBox.Show("Rango de fechas inválido.")
            Exit Sub
        End If

        Dim total As Decimal = 0D

        Using cn = Db.GetConnection(), cmd As New SqlCommand("sp_LiquidarQuincena", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@FuncionarioId", funcId)
            cmd.Parameters.AddWithValue("@Desde", desde)
            cmd.Parameters.AddWithValue("@Hasta", hasta)

            cn.Open()
            Dim dt As New DataTable()
            Using da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No hay movimientos para liquidar.")
                Exit Sub
            End If
            total = CDec(dt.Rows(0)("TotalADescontar"))
        End Using

        ' Obtener detalle para el ticket
        Dim detalle As DataTable = ObtenerDetalleLiquidacion(funcId, desde, hasta)

        ' Construir ticket
        Dim ticket As String = ConstruirTicket(funcNombre, funcId, desde, hasta, detalle, total)

        ImprimirTicket(ticket)

        RegistrarBitacora(
        accion:="UPDATE",
        tabla:="LIQUIDACIÓN",
        llave:=UsuarioActual,
        descripcion:=$"Se registró una liquidación. FuncionarioId={funcId}, Funcionario='{funcNombre}', Monto={total}")

        MessageBox.Show("Liquidación creada e impresa. Total a descontar: " & total.ToString("C2"),
                    "Liquidación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        RefrescarMovs()
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

        ' Query para obtener consumos y adelantos
        Dim q As String = " SELECT 'Consumo' AS Tipo, c.Fecha, co.Nombre AS Detalle, c.Cantidad, c.PrecioUnitario, c.MontoTotal,
                CASE WHEN c.Liquidado = 1 THEN 'Liquidado' ELSE 'Pendiente' END AS Estado
            FROM Consumo c INNER JOIN Consumible co ON co.ConsumibleId = c.ConsumibleId WHERE (@f = -1 OR c.FuncionarioId = @f)
              AND CAST(c.Fecha AS date) BETWEEN @d AND @h

            UNION ALL

            SELECT 'Adelanto' AS Tipo, a.Fecha, 'Adelanto' AS Detalle, NULL AS Cantidad, NULL AS PrecioUnitario, a.Monto AS MontoTotal,
                CASE WHEN a.Liquidado = 1 THEN 'Liquidado' ELSE 'Pendiente' END AS Estado
            FROM Adelanto a
            WHERE (@f = -1 OR a.FuncionarioId = @f)
              AND CAST(a.Fecha AS date) BETWEEN @d AND @h

            ORDER BY Fecha DESC;"

        Dim p As New List(Of SqlClient.SqlParameter) From {
            New SqlClient.SqlParameter("@f", funcId),
            New SqlClient.SqlParameter("@d", desde),
            New SqlClient.SqlParameter("@h", hasta)}

        ' Mostrar resultados en DgvMovs
        DgvMovs.DataSource = Db.GetTable(q, p)
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

    ' Formatear celdas del DataGridView según el estado
    Private Sub DgvMovs_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvMovs.CellFormatting
        If DgvMovs.Columns(e.ColumnIndex).Name = "Estado" Then
            If e.Value IsNot Nothing Then
                Dim texto = e.Value.ToString()

                ' Limpiar estilo previo
                e.CellStyle.ForeColor = Color.Black
                e.CellStyle.BackColor = Color.White
                e.CellStyle.ApplyStyle(New DataGridViewCellStyle())

                ' Aplicar colores según el valor
                If texto = "Liquidado" Then
                    e.CellStyle.ForeColor = Color.Green
                    e.CellStyle.Font = New Font(e.CellStyle.Font, FontStyle.Bold)
                ElseIf texto = "Pendiente" Then
                    e.CellStyle.ForeColor = Color.Red
                    e.CellStyle.Font = New Font(e.CellStyle.Font, FontStyle.Bold)
                End If

                e.FormattingApplied = True
            End If
        End If
    End Sub

    ' Refrescar movimientos del funcionario seleccionado
    Public Sub RefrescarMovs()
        Dim funcId As Integer = If(CboFuncionario.SelectedIndex >= 0, CInt(CboFuncionario.SelectedValue), -1)
        Dim p As New List(Of SqlParameter)

        Dim q As String = "
        SELECT 
            'Consumo' AS Tipo, c.Fecha, co.Nombre AS Detalle, c.Cantidad, c.PrecioUnitario, c.MontoTotal, 
            CASE 
                WHEN c.Liquidado = 1 THEN 'Liquidado'
                ELSE 'Pendiente'
            END AS Estado
        FROM Consumo c INNER JOIN Consumible co ON co.ConsumibleId = c.ConsumibleId WHERE (@f = -1 OR c.FuncionarioId = @f) UNION ALL
        
        SELECT 'Adelanto' AS Tipo, a.Fecha, 'Adelanto' AS Detalle, NULL AS Cantidad, NULL AS PrecioUnitario, a.Monto AS MontoTotal,
            CASE 
                WHEN a.Liquidado = 1 THEN 'Liquidado'
                ELSE 'Pendiente'
            END AS Estado
        FROM Adelanto a WHERE (@f = -1 OR a.FuncionarioId = @f) ORDER BY Fecha DESC"

        p.Add(New SqlParameter("@f", funcId))
        DgvMovs.DataSource = Db.GetTable(q, p)
    End Sub

    ' Abrir formulario de gestión de consumibles
    Private Sub BtnGestionar_Click(sender As Object, e As EventArgs) Handles BtnGestionar.Click
        ' Pedir credenciales de ADMIN
        Using frmLogin As New FormLogin("ADMIN", True)  ' rolForzado = "ADMIN", soloValidar = True
            Dim r = frmLogin.ShowDialog(Me)

            If r <> DialogResult.OK OrElse Not frmLogin.LoginOK Then
                MessageBox.Show("Acceso denegado. Debe autenticarse como ADMIN.", "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End Using

        ' El ADMIN se autenticó correctamente
        Dim f As New Form7_GestionConsumibles()
        f.ShowDialog(Me)   ' o f.Show() si quieres que sea no modal
    End Sub

    ' Regresar al formulario de login y registra en bitácora
    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        RegistrarBitacora(
        accion:="LOGOUT",
        tabla:="SEGURIDAD",
        llave:=UsuarioActual,
        descripcion:="Cierre de sesión.")
        ' Limpiar variables globales
        UsuarioActual = ""
        RolActual = ""
        Form1.Show()
        Me.Close()
    End Sub
End Class
