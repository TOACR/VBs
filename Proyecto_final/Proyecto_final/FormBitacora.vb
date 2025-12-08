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
        CboAccion.Items.Add("")          ' Todos
        CboAccion.Items.Add("INSERT")
        CboAccion.Items.Add("UPDATE")
        CboAccion.Items.Add("DELETE")
        CboAccion.Items.Add("LOGIN")
        CboAccion.Items.Add("LOGOUT")
        CboAccion.SelectedIndex = 0
    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim desde As Date = DtpDesde.Value.Date
        Dim hasta As Date = DtpHasta.Value.Date.AddDays(1).AddTicks(-1) ' hasta fin del día

        Dim q As String = "
            SELECT 
                BitacoraId,
                Fecha,
                Usuario,
                Rol,
                Accion,
                Tabla,
                Llave,
                Descripcion
            FROM Bitacora
            WHERE Fecha BETWEEN @d AND @h
        "

        Dim p As New List(Of SqlParameter) From {
            New SqlParameter("@d", desde),
            New SqlParameter("@h", hasta)
        }

        ' Filtro por usuario (opcional)
        If TxtUsuario.Text.Trim() <> "" Then
            q &= " AND Usuario LIKE @u"
            p.Add(New SqlParameter("@u", "%" & TxtUsuario.Text.Trim() & "%"))
        End If

        ' Filtro por tabla (opcional)
        If TxtTabla.Text.Trim() <> "" Then
            q &= " AND Tabla LIKE @t"
            p.Add(New SqlParameter("@t", "%" & TxtTabla.Text.Trim() & "%"))
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
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
End Class

