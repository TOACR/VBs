Imports System.Data.SqlClient
Module Auditoria
    ' Registra una acción en la bitácora
    Public Sub RegistrarBitacora(accion As String,
                                 tabla As String,
                                 llave As String,
                                 descripcion As String)

        Dim q As String = "
            INSERT INTO Bitacora(Usuario, Rol, Accion, Tabla, Llave, Descripcion)
            VALUES(@u, @r, @a, @t, @l, @d);"

        Dim p As New List(Of SqlParameter) From {
            New SqlParameter("@u", UsuarioActual),   ' nombre de usuario logueado
            New SqlParameter("@r", RolActual),       ' ADMIN / CONSUMIBLES
            New SqlParameter("@a", accion),
            New SqlParameter("@t", tabla),
            New SqlParameter("@l", llave),
            New SqlParameter("@d", descripcion)}

        Db.ExecNonQuery(q, p)
    End Sub
End Module

