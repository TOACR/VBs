Imports System.Data.SqlClient

Public Class FormBitacora
    Private Sub FormBitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Consulta de bitácora"
        EstiloProfesionalDataGrid(DgvBitacora)

        ' Rango de fechas por defecto: hoy y hace 7 días
        DtpHasta.Value = Date.Today
        DtpDesde.Value = Date.Today.AddDays(-7)

        ' Llenar combo de acciones
        CboAccion.Items.Clear()
        CboAccion.Items.Add("")          ' Todas
        CboAccion.Items.Add("INSERT")
        CboAccion.Items.Add("UPDATE")
        CboAccion.Items.Add("DELETE")
        CboAccion.Items.Add("LOGIN")
        CboAccion.Items.Add("LOGOUT")
        CboAccion.SelectedIndex = 0

        ' 🔹 Llenar combo de usuarios desde Bitacora (distinct)
        CargarUsuarios()
    End Sub

    ' Cargar usuarios únicos desde la tabla Bitacora
    Private Sub CargarUsuarios()
        Dim dt As DataTable = Db.GetTable(" SELECT DISTINCT Usuario FROM Bitacora
            WHERE Usuario IS NOT NULL AND LTRIM(RTRIM(Usuario)) <> '' ORDER BY Usuario", Nothing)

        ' Insertar opción "Todos"
        Dim row = dt.NewRow()
        row("Usuario") = ""
        dt.Rows.InsertAt(row, 0)

        CboUsuario.DisplayMember = "Usuario"
        CboUsuario.ValueMember = "Usuario"
        CboUsuario.DataSource = dt
        CboUsuario.SelectedIndex = 0
    End Sub

    ' Buscar en la bitácora según filtros
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim desde As Date = DtpDesde.Value.Date
        Dim hasta As Date = DtpHasta.Value.Date.AddDays(1).AddTicks(-1) ' hasta fin del día

        Dim q As String = " SELECT Fecha, Usuario, Accion, Tabla, Descripcion
            FROM Bitacora WHERE Fecha BETWEEN @d AND @h"

        Dim p As New List(Of SqlParameter) From {
            New SqlParameter("@d", desde),
            New SqlParameter("@h", hasta)}

        ' Filtro por usuario
        Dim usuarioSel As String = ""
        If CboUsuario.SelectedIndex >= 0 AndAlso CboUsuario.SelectedValue IsNot Nothing Then
            usuarioSel = CboUsuario.SelectedValue.ToString().Trim()
        End If

        If usuarioSel <> "" Then
            q &= " AND Usuario = @u"
            p.Add(New SqlParameter("@u", usuarioSel))
        End If

        ' Filtro por acción (opcional)
        If CboAccion.Text.Trim() <> "" Then
            q &= " AND Accion = @a"
            p.Add(New SqlParameter("@a", CboAccion.Text.Trim()))
        End If

        q &= " ORDER BY Fecha DESC"

        Dim dt = Db.GetTable(q, p)
        DgvBitacora.DataSource = dt
    End Sub

    ' Cerrar el formulario
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
End Class


