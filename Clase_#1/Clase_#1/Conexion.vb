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
    Dim contprovincia As Integer = 1
    Dim contcanton As Integer = 1
    Dim contdistrito As Integer = 1
    Dim idprovincia As String
    Dim idcanton As String
    Dim iddistrito As String



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
    Public Function Filtra_padron(numeroident As String, nombre As String, priAp As String, segAp As String) As DataTable

        Dim dt As New DataTable

        Dim sql As String =
        "SELECT * 
         FROM PADRON
         WHERE 
           (@numeroident = '' OR IDENTIFICACION LIKE '%' + @numeroident + '%')    
           AND (@nombre = '' OR NOMBRE LIKE '%' + @nombre + '%')
           AND (@priAp = '' OR APELLIDO1 LIKE '%' + @priAp + '%')
           AND (@segAp = '' OR APELLIDO2  LIKE '%' + @segAp + '%')    
           ORDER BY     IDENTIFICACION, NOMBRE, APELLIDO1, APELLIDO2"

        Using cmd As New SqlCommand(sql, conexion)
            cmd.Parameters.AddWithValue("@numeroident", numeroident)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@priAp", priAp)
            cmd.Parameters.AddWithValue("@segAp", segAp)

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
    Public Sub CargarArchivo(ByVal ruta As String)
        Using myreader As New FileIO.TextFieldParser(ruta)
            myreader.SetDelimiters(",")
            Dim currentrow As String()
            While Not myreader.EndOfData
                Try
                    currentrow = myreader.ReadFields()
                    insertar_datos(currentrow(0), currentrow(1), currentrow(2), currentrow(3))
                Catch ex As Exception
                    MessageBox.Show("Error:" + ex.ToString)
                End Try
            End While
        End Using
    End Sub
    Public Sub insertar_datos(ByVal id As String, ByVal provincia As String, ByVal canton As String, ByVal distrito As String)
        Dim a, b, c As Integer
        '101001
        a = Mid(id, 1, 1) 'a es 1
        b = Mid(id, 2, 2) 'b es 01
        c = Mid(id, 4, 3) 'c es 001
        contprovincia = a
        consultar("SELECT * FROM PROVINCIA WHERE DESCRIPCION = '" + provincia + "'", "PROVINCIA")
        If ds.Tables("PROVINCIA").Rows.Count = 0 Then
            inserta_datos("INSERT INTO PROVINCIA VALUES (" + contprovincia.ToString() + ", '" + provincia + "')")
            idprovincia = a
        Else
            idprovincia = ds.Tables("PROVINCIA").Rows(0).Item(0).ToString
        End If
        consultar("SELECT * FROM CANTON WHERE CODIGO_PROVINCIA = '" + idprovincia.ToString() + "' AND DESCRIPCION_CANTON = '" + canton + "'", "CANTON")
        If ds.Tables("CANTON").Rows.Count = 0 Then
            contcanton = b
            inserta_datos("INSERT INTO CANTON VALUES (" + idprovincia + ", '" + contcanton.ToString() + "','" + canton + "')")
            idcanton = b
        Else
            idcanton = ds.Tables("CANTON").Rows(0).Item("CODIGO_CANTON").ToString()
        End If
        consultar("SELECT * FROM DISTRITO WHERE CODIGO_PROVINCIA = '" + idprovincia.ToString() + "' AND CODIGO_CANTON = '" + idcanton.ToString() + "' AND CODIGO_DISTRITO = '" + c.ToString() + "'", "DISTRITO")
        If ds.Tables("DISTRITO").Rows.Count = 0 Then
            contdistrito = c
            inserta_datos("INSERT INTO DISTRITO VALUES (" + idprovincia + ", '" + idcanton + "','" + contdistrito.ToString() + "', '" + distrito + "')")
            iddistrito = c
        Else
            iddistrito = ds.Tables("DISTRITO").Rows(0).Item("CODIGO_DISTRITO").ToString()
        End If


    End Sub

End Class
