Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Module Db

    Public Function GetConnection() As SqlConnection
        Dim cs = ConfigurationManager.ConnectionStrings("BD_Consumos").ConnectionString
        Return New SqlConnection(cs)
    End Function

    ' Clona los parámetros para que cada SqlCommand reciba instancias propias
    Public Function CloneParams(params As IEnumerable(Of SqlParameter)) As SqlParameter()
        If params Is Nothing Then Return Array.Empty(Of SqlParameter)()

        Dim list As New List(Of SqlParameter)
        For Each p In params
            Dim c As New SqlParameter()

            ' Copia de metadatos relevantes
            c.ParameterName = p.ParameterName

            ' Si no definiste SqlDbType en el original, evita copiarlo
            ' Solo copia si fue seteado (por seguridad lo copiamos; SQL Server lo tolera)
            c.SqlDbType = p.SqlDbType
            c.Size = p.Size
            c.Precision = p.Precision
            c.Scale = p.Scale

            c.Direction = p.Direction
            c.IsNullable = p.IsNullable

            ' Valor (manejo de Nothing -> DBNull)
            c.Value = If(p.Value, DBNull.Value)

            list.Add(c)
        Next
        Return list.ToArray()
    End Function

    Public Function GetTable(query As String, params As List(Of SqlParameter)) As DataTable
        Using cn = GetConnection(),
              cmd As New SqlCommand(query, cn),
              da As New SqlDataAdapter(cmd)

            Dim cloned = CloneParams(params)
            If cloned.Length > 0 Then cmd.Parameters.AddRange(cloned)

            Dim dt As New DataTable()
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function ExecScalar(query As String, params As List(Of SqlParameter)) As Object
        Using cn = GetConnection(), cmd As New SqlCommand(query, cn)
            Dim cloned = CloneParams(params)
            If cloned.Length > 0 Then cmd.Parameters.AddRange(cloned)
            cn.Open()
            Return cmd.ExecuteScalar()
        End Using
    End Function

    Public Function ExecNonQuery(query As String, params As List(Of SqlParameter)) As Integer
        Using cn = GetConnection(), cmd As New SqlCommand(query, cn)
            Dim cloned = CloneParams(params)
            If cloned.Length > 0 Then cmd.Parameters.AddRange(cloned)
            cn.Open()
            Return cmd.ExecuteNonQuery()
        End Using
    End Function

End Module




