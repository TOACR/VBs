Imports System.Data.SqlClient
Imports System.Configuration

Public Class FormLogin
    Private ReadOnly _rolForzado As String ' Nothing si usas CmbRol
    Public Sub New(Optional rolForzado As String = Nothing)
        InitializeComponent()
        _rolForzado = rolForzado
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Ingreso"
        Me.AcceptButton = BtnEntrar
        If String.IsNullOrEmpty(_rolForzado) Then
            If CmbRol.Items.Count = 0 Then
                CmbRol.Items.Add("ADMIN")
                CmbRol.Items.Add("CONSUMIBLES")
            End If
            CmbRol.SelectedIndex = 0
            CmbRol.Enabled = True
        Else
            CmbRol.Items.Clear()
            CmbRol.Items.Add(_rolForzado)
            CmbRol.SelectedIndex = 0
            CmbRol.Enabled = False
        End If
    End Sub
    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click
        Dim usuario = TxtUsuario.Text.Trim()
        Dim clave = TxtPassword.Text
        Dim rol = CmbRol.SelectedItem?.ToString()

        If String.IsNullOrWhiteSpace(usuario) OrElse String.IsNullOrWhiteSpace(clave) OrElse String.IsNullOrWhiteSpace(rol) Then
            MessageBox.Show("Complete usuario y contraseña.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim cs = ConfigurationManager.ConnectionStrings("BD_Consumos").ConnectionString
            Using cn As New SqlConnection(cs)
                cn.Open()
                Dim cmd As New SqlCommand("
                    SELECT PasswordHash
                    FROM dbo.Usuarios
                    WHERE UserName = @u AND Rol = @r;", cn)
                cmd.Parameters.AddWithValue("@u", usuario)
                cmd.Parameters.AddWithValue("@r", rol)

                Dim stored As String = CStr(cmd.ExecuteScalar())

                If stored Is Nothing OrElse stored Is DBNull.Value Then
                    MessageBox.Show("Usuario no existe.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim ok As Boolean = Security.VerifyPassword(clave, stored)
                If Not ok Then
                    MessageBox.Show("Contraseña incorrecta.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End Using

            ' Éxito: abrir el form según rol
            If rol.Equals("ADMIN", StringComparison.OrdinalIgnoreCase) Then
                Dim f As New Form2_Admin()
                f.Show()
            Else
                Dim f As New Form3_Consumibles()
                f.Show()
            End If
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error de login: " & ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Form1.Show()
        Me.Close()

    End Sub

End Class
