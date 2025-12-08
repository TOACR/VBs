Imports System.Data.SqlClient

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
    End Sub
    Private Sub TxtMontoAdelanto_KeyPress(sender As Object, e As EventArgs) Handles TxtMontoAdelanto.KeyPress
        Set_solo_numeros(e)
    End Sub
    Private Sub CargarFuncionarios()
        Dim dt = Db.GetTable("SELECT FuncionarioId, Nombre FROM Funcionario WHERE Activo=1 ORDER BY Nombre", Nothing)
        CboFuncionario.DisplayMember = "Nombre"
        CboFuncionario.ValueMember = "FuncionarioId"
        CboFuncionario.DataSource = dt
    End Sub
    Public Sub CargarConsumibles()
        Dim dt = Db.GetTable("
        SELECT ConsumibleId, Nombre, Precio
        FROM Consumible
        WHERE Activo = 1
        ORDER BY Nombre", Nothing)
        CboConsumible.DisplayMember = "Nombre"
        CboConsumible.ValueMember = "ConsumibleId"
        CboConsumible.DataSource = dt

    End Sub
    Private Sub CboFuncionario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboFuncionario.SelectedIndexChanged
        If CboFuncionario.SelectedIndex < 0 Then Exit Sub
        RefrescarMovs()
    End Sub
    Private Sub CboConsumible_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboConsumible.SelectedIndexChanged
        If CboConsumible.SelectedIndex >= 0 Then
            Dim dt = CType(CboConsumible.DataSource, DataTable)
            Dim row = dt.Rows(CboConsumible.SelectedIndex)
            TxtPrecio.Text = CDec(row("Precio")).ToString("N2")
        End If
    End Sub
    Private Sub BtnAgregarConsumo_Click(sender As Object, e As EventArgs) Handles BtnAgregarConsumo.Click

        If CboFuncionario.SelectedIndex < 0 OrElse CboConsumible.SelectedIndex < 0 Then
            MessageBox.Show("Seleccione funcionario y consumible.")
            Exit Sub
        End If

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

        ' 💾 1) Query para insertar y devolver el ID recién creado
        Dim q As String = "
        INSERT INTO Consumo (FuncionarioId, ConsumibleId, Cantidad, PrecioUnitario)
        VALUES (@f,@c,@cant,@precio);

        SELECT SCOPE_IDENTITY();
    "

        ' 📌 2) Parámetros del insert
        Dim p As New List(Of SqlParameter) From {
        New SqlParameter("@f", funcId),
        New SqlParameter("@c", consId),
        New SqlParameter("@cant", cant),
        New SqlParameter("@precio", precio)
    }

        ' 🔍 3) Ejecutamos y obtenemos el ID nuevo
        Dim nuevoId As Integer = CInt(Db.ExecScalar(q, p))

        ' 📝 4) Registrar en bitácora
        RegistrarBitacora(
        accion:="INSERT",
        tabla:="Consumo",
        llave:=nuevoId.ToString(),
        descripcion:=$"Se registró consumo. FuncionarioId={funcId}, ConsumibleId={consId}, Cantidad={cant}, PrecioUnitario={precio}"
    )

        ' 🔄 5) Refrescar tabla
        RefrescarMovs()

        MessageBox.Show("Consumo registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub BtnRegistrarAdelanto_Click(sender As Object, e As EventArgs) Handles BtnRegistrarAdelanto.Click
        If CboFuncionario.SelectedIndex < 0 Then
            MessageBox.Show("Seleccione funcionario.")
            Exit Sub
        End If
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
        RefrescarMovs()
        TxtMontoAdelanto.Clear()
    End Sub
    Private Sub BtnLiquidar_Click(sender As Object, e As EventArgs) Handles BtnLiquidar.Click
        ' Pedir credenciales de ADMIN
        Using frmLogin As New FormLogin("ADMIN", True)  ' rolForzado = "ADMIN", soloValidar = True
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
        Dim desde As Date = DtpDesde.Value.Date
        Dim hasta As Date = DtpHasta.Value.Date
        If desde > hasta Then
            MessageBox.Show("Rango de fechas inválido.")
            Exit Sub
        End If

        Using cn = Db.GetConnection(), cmd As New SqlCommand("sp_LiquidarQuincena", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@FuncionarioId", CInt(CboFuncionario.SelectedValue))
            cmd.Parameters.AddWithValue("@Desde", desde)
            cmd.Parameters.AddWithValue("@Hasta", hasta)
            cn.Open()
            Dim dt As New DataTable()
            Using da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
            If dt.Rows.Count > 0 Then
                Dim total As Decimal = CDec(dt.Rows(0)("TotalADescontar"))
                MessageBox.Show("Liquidación creada. Total a descontar: " & total.ToString("C2"))
            Else
                MessageBox.Show("No hay movimientos para liquidar.")
            End If
        End Using
        RefrescarMovs()
    End Sub
    Public Sub RefrescarMovs()
        Dim funcId As Integer = If(CboFuncionario.SelectedIndex >= 0, CInt(CboFuncionario.SelectedValue), -1)
        Dim p As New List(Of SqlParameter)

        Dim q As String = "
        SELECT 
            'Consumo' AS Tipo,
            c.Fecha,
            co.Nombre AS Detalle,
            c.Cantidad,
            c.PrecioUnitario,
            c.MontoTotal,
            CASE 
                WHEN c.Liquidado = 1 THEN 'Liquidado'
                ELSE 'Pendiente'
            END AS Estado
        FROM Consumo c
        INNER JOIN Consumible co ON co.ConsumibleId = c.ConsumibleId
        WHERE (@f = -1 OR c.FuncionarioId = @f)

        UNION ALL

        SELECT 
            'Adelanto' AS Tipo,
            a.Fecha,
            'Adelanto' AS Detalle,
            NULL AS Cantidad,
            NULL AS PrecioUnitario,
            a.Monto AS MontoTotal,
            CASE 
                WHEN a.Liquidado = 1 THEN 'Liquidado'
                ELSE 'Pendiente'
            END AS Estado
        FROM Adelanto a
        WHERE (@f = -1 OR a.FuncionarioId = @f)

        ORDER BY Fecha DESC"

        p.Add(New SqlParameter("@f", funcId))
        DgvMovs.DataSource = Db.GetTable(q, p)
    End Sub
    Private Sub DgvMovs_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvMovs.CellFormatting
        ' Asegúrate de que el nombre de la columna sea exactamente "Estado"
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
    Private Sub BtnGestionar_Click(sender As Object, e As EventArgs) Handles BtnGestionar.Click
        ' Pedir credenciales de ADMIN
        Using frmLogin As New FormLogin("ADMIN", True)  ' rolForzado = "ADMIN", soloValidar = True
            Dim r = frmLogin.ShowDialog(Me)

            If r <> DialogResult.OK OrElse Not frmLogin.LoginOK Then
                MessageBox.Show("Acceso denegado. Debe autenticarse como ADMIN.", "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End Using

        ' Si llegó aquí, el ADMIN se autenticó correctamente
        Dim f As New Form7_GestionConsumibles()
        f.ShowDialog(Me)   ' o f.Show() si quieres que sea no modal
    End Sub

End Class
