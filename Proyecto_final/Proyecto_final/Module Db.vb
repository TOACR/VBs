Imports System.Data.SqlClient
Imports System.Configuration

Module Db
    Public ReadOnly Property CnxString As String
        Get
            Return ConfigurationManager.ConnectionStrings("BD_Consumos").ConnectionString
        End Get
    End Property

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(CnxString)
    End Function

    Public Function ExecScalar(query As String, params As List(Of SqlParameter)) As Object
        Using cn = GetConnection(), cmd As New SqlCommand(query, cn)
            If params IsNot Nothing Then cmd.Parameters.AddRange(params.ToArray())
            cn.Open()
            Return cmd.ExecuteScalar()
        End Using
    End Function

    Public Function ExecNonQuery(query As String, params As List(Of SqlParameter)) As Integer
        Using cn = GetConnection(), cmd As New SqlCommand(query, cn)
            If params IsNot Nothing Then cmd.Parameters.AddRange(params.ToArray())
            cn.Open()
            Return cmd.ExecuteNonQuery()
        End Using
    End Function

    Public Function GetTable(query As String, params As List(Of SqlParameter)) As DataTable
        Using cn = GetConnection(), cmd As New SqlCommand(query, cn)
            If params IsNot Nothing Then cmd.Parameters.AddRange(params.ToArray())
            Using da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)
                Return dt
            End Using
        End Using
    End Function
End Module



