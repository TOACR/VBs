Imports System.Data.SqlClient

Public Class Form6_Usuarios
    Private Sub Form6_Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Administración de Usuarios"
        EstiloProfesionalDataGrid(DgvUsuarios)

        ' Combo de roles: solo selección
        CmbRol.DropDownStyle = ComboBoxStyle.DropDownList
        CmbRol.Items.Clear()
        CmbRol.Items.Add("ADMIN")
        CmbRol.Items.Add("CONSUMIBLES")

        ' Opcional: dejar sin selección inicial
        CmbRol.SelectedIndex = -1

        CargarUsuarios()
        Limpiar()
    End Sub

    Private Sub CargarUsuarios()
        Dim q As String = "
            SELECT Id, UserName, Rol
            FROM Usuarios
            ORDER BY UserName;
        "
        Dim dt = Db.GetTable(q, Nothing)
        DgvUsuarios.DataSource = dt

        ' Opcional: ajustar columnas
        If DgvUsuarios.Columns.Contains("Id") Then
            DgvUsuarios.Columns("Id").Visible = False
        End If
        DgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub Limpiar()
        LblUsuarioId.Text = ""
        TxtUserName.Clear()
        TxtPassword.Clear()
        TxtConfirmar.Clear()
        CmbRol.SelectedIndex = -1
        TxtUserName.Focus()
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Limpiar()
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim usuario = TxtUserName.Text.Trim()
        Dim rol As String = If(CmbRol.SelectedItem IsNot Nothing, CmbRol.SelectedItem.ToString(), "").Trim()
        Dim pwd = TxtPassword.Text
        Dim pwd2 = TxtConfirmar.Text

        ' Validaciones básicas
        If String.IsNullOrWhiteSpace(usuario) Then
            MessageBox.Show("Debe digitar el nombre de usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtUserName.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(rol) Then
            MessageBox.Show("Debe seleccionar un rol.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CmbRol.Focus()
            Exit Sub
        End If

        ' ¿Nuevo o edición?
        Dim esNuevo As Boolean = (LblUsuarioId.Text = "")

        ' Para NUEVO usuario: contraseña obligatoria
        If esNuevo Then
            If String.IsNullOrWhiteSpace(pwd) OrElse String.IsNullOrWhiteSpace(pwd2) Then
                MessageBox.Show("Debe digitar y confirmar la contraseña para un usuario nuevo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If

        ' Si se digitó contraseña, verificar que coincida
        Dim cambiarPassword As Boolean = Not String.IsNullOrWhiteSpace(pwd) OrElse Not String.IsNullOrWhiteSpace(pwd2)
        If cambiarPassword Then
            If pwd <> pwd2 Then
                MessageBox.Show("Las contraseñas no coinciden.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If

        Try
            If esNuevo Then
                ' Validar que no exista usuario con ese nombre
                Dim qExiste As String = "SELECT COUNT(*) FROM Usuarios WHERE UserName=@u;"
                Dim pExiste As New List(Of SqlParameter) From {
                    New SqlParameter("@u", usuario)
                }
                Dim existe As Integer = CInt(Db.ExecScalar(qExiste, pExiste))
                If existe > 0 Then
                    MessageBox.Show("Ya existe un usuario con ese nombre.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                ' Hash de contraseña usando tu módulo Security
                Dim hash As String = Security.HashPassword(pwd)

                Dim qIns As String = "
                    INSERT INTO Usuarios (UserName, Rol, PasswordHash)
                    VALUES (@u, @r, @p);
                "

                Dim pIns As New List(Of SqlParameter) From {
                    New SqlParameter("@u", usuario),
                    New SqlParameter("@r", rol),
                    New SqlParameter("@p", hash)
                }

                Db.ExecNonQuery(qIns, pIns)
                MessageBox.Show("Usuario creado correctamente.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                ' Edición
                Dim id As Integer = CInt(LblUsuarioId.Text)

                ' Validar nombre de usuario único (excluyendo el actual)
                Dim qExiste As String = "
                    SELECT COUNT(*) 
                    FROM Usuarios 
                    WHERE UserName=@u AND UsuarioId <> @id;
                "
                Dim pExiste As New List(Of SqlParameter) From {
                    New SqlParameter("@u", usuario),
                    New SqlParameter("@id", id)
                }
                Dim existe As Integer = CInt(Db.ExecScalar(qExiste, pExiste))
                If existe > 0 Then
                    MessageBox.Show("Ya existe otro usuario con ese nombre.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                ' Construir UPDATE
                Dim qUpd As String
                Dim pUpd As New List(Of SqlParameter) From {
                    New SqlParameter("@u", usuario),
                    New SqlParameter("@r", rol),
                    New SqlParameter("@id", id)
                }

                If cambiarPassword Then
                    Dim hash As String = Security.HashPassword(pwd)
                    qUpd = "
                        UPDATE Usuarios
                        SET UserName=@u, Rol=@r, PasswordHash=@p
                        WHERE Id=@id;
                    "
                    pUpd.Add(New SqlParameter("@p", hash))
                Else
                    qUpd = "
                        UPDATE Usuarios
                        SET UserName=@u, Rol=@r
                        WHERE Id=@id;
                    "
                End If

                Db.ExecNonQuery(qUpd, pUpd)
                MessageBox.Show("Usuario actualizado correctamente.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            CargarUsuarios()
            Limpiar()

        Catch ex As Exception
            MessageBox.Show("Error al guardar usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvUsuarios.CellClick
        If e.RowIndex >= 0 Then
            Dim r = DgvUsuarios.Rows(e.RowIndex)
            LblUsuarioId.Text = CStr(r.Cells("Id").Value)
            TxtUserName.Text = CStr(r.Cells("UserName").Value)
            CmbRol.SelectedItem = CStr(r.Cells("Rol").Value)

            ' No cargamos la contraseña (por seguridad)
            TxtPassword.Clear()
            TxtConfirmar.Clear()
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If LblUsuarioId.Text = "" Then
            MessageBox.Show("Debe seleccionar un usuario primero.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If MessageBox.Show("¿Desea eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Try
            Dim id As Integer = CInt(LblUsuarioId.Text)
            Dim qDel As String = "DELETE FROM Usuarios WHERE Id=@id;"
            Dim pDel As New List(Of SqlParameter) From {
                New SqlParameter("@id", id)
            }

            Db.ExecNonQuery(qDel, pDel)
            MessageBox.Show("Usuario eliminado.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CargarUsuarios()
            Limpiar()

        Catch ex As Exception
            MessageBox.Show("Error al eliminar usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

End Class