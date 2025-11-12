Imports System.Configuration
Imports System.Data.SqlClient

Public Class FormCrearUsuarioAdmin
        Private Sub BtnCrearAdmin_Click(sender As Object, e As EventArgs) Handles BtnCrearAdmin.Click
            Try
            Dim stored As String = Security.HashPassword("Admin123") ' CAMBIA LA CONTRASEÑA AQUÍ

            Using cn As New SqlConnection(ConfigurationManager.ConnectionStrings("BD_Consumos").ConnectionString)
                    cn.Open()
                Using cmd As New SqlCommand("INSERT INTO Usuarios(UserName, Rol, PasswordHash) VALUES (@u, @r, @p)", cn)
                    cmd.Parameters.AddWithValue("@u", "Admin")
                    cmd.Parameters.AddWithValue("@r", "ADMIN")
                    cmd.Parameters.AddWithValue("@p", stored) ' <-- ahora es String
                    cmd.ExecuteNonQuery()
                End Using

            End Using

                MessageBox.Show("Usuario admin creado correctamente.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Sub

    Private Sub FormCrearUsuarioAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
