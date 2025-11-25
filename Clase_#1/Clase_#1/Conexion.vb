Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography
Imports System.Text

Public Class Conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-HPG8TC6\SQLEXPRESS;Initial Catalog=II36DB03Q2025;Trusted_connection=Yes")
    Public comando As SqlCommand
    Public da As SqlDataAdapter
    Public ds As DataSet = New DataSet()
    Public builder As SqlCommandBuilder

    Public Sub conectar()
        Try
            conexion.Open()
            'MessageBox.Show("Conexion Exitosa")
        Catch ex As Exception
            MessageBox.Show("Error:" + ex.ToString)
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Function valida_id(ByVal vtipoid As String, ByVal vnumeroid As String) As DataTable
        Dim dt = New DataTable()
        consultar("SELECT * FROM CIUDADANO WHERE TIPO_IDENTIFICACION = " & vtipoid.ToString() & " AND NUMERO_IDENTIFICACION = '" & vnumeroid & "'", "CIUDADANO")
        If ds.Tables("CIUDADANO").Rows.Count > 0 Then
            f = 0
        Else
            f = 1
        End If
        da.Fill(dt)
        Return dt
    End Function

    Public Function ObtenerEstadosCiviles() As DataTable
        Dim dt As New DataTable()
        consultar("SELECT DESCRIPCION FROM ESTADO_CIVIL", "ESTADO_CIVIL")
        da.Fill(dt)
        Return dt
    End Function

    Public Function Busca_padron(ByVal vnumeroid As String) As DataTable
        Dim dt = New DataTable()
        consultar("SELECT * FROM PADRON WHERE IDENTIFICACION = '" & vnumeroid & "'", "PADRON")
        If ds.Tables("PADRON").Rows.Count > 0 Then
            f = 0
        Else
            f = 1
        End If
        da.Fill(dt)
        Return dt
    End Function
    Public Function Filtra_padron(nombre As String, priAp As String) As DataTable

        Dim dt As New DataTable

        Dim sql As String =
        "SELECT TOP 200 * 
         FROM PADRON
         WHERE (@nombre = '' OR NOMBRE LIKE '%' + @nombre + '%')
           AND (@priAp = '' OR APELLIDO1 LIKE '%' + @priAp + '%')
         ORDER BY NOMBRE, APELLIDO1"

        Using cmd As New SqlCommand(sql, conexion)   ' <-- usá tu conexión existente
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@priAp", priAp)

            Using da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        Return dt
    End Function



    Public Sub consultar(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        builder = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub
    Public Function inserta_datos(ByVal datos As String) As Boolean
        Try
            conexion.Open()
            comando = New SqlCommand(datos, conexion)
            comando.ExecuteNonQuery()
            f = 0
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al insertar datos: " & ex.ToString)
            f = 1
            Return False
        Finally
            conexion.Close()
        End Try
    End Function


End Class
