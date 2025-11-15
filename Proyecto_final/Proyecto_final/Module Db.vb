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
            ' Copia de metadatos relevantes
            ' Solo copia si fue seteado (por seguridad lo copiamos; SQL Server lo tolera)
            ' Valor (manejo de Nothing -> DBNull)
            Dim c As New SqlParameter With {
                .ParameterName = p.ParameterName,
                .SqlDbType = p.SqlDbType,
                .Size = p.Size,
                .Precision = p.Precision,
                .Scale = p.Scale,
                .Direction = p.Direction,
                .IsNullable = p.IsNullable,
                .Value = If(p.Value, DBNull.Value)
            }

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

Public Module ModGlobales

    Public Sub LimpiarControles(form As Form)
        ' 🔹 Recorre todos los controles dentro del formulario recibido
        For Each ctrl As Control In form.Controls
            LimpiarControl(ctrl)
        Next
    End Sub

    Private Sub LimpiarControl(ctrl As Control)
        ' 🔹 Limpia los controles básicos según su tipo
        Select Case True
            Case TypeOf ctrl Is TextBox
                CType(ctrl, TextBox).Clear()
            Case TypeOf ctrl Is MaskedTextBox
                CType(ctrl, MaskedTextBox).Clear()
            Case TypeOf ctrl Is ComboBox
                CType(ctrl, ComboBox).SelectedIndex = -1
            Case TypeOf ctrl Is DataGridView
                CType(ctrl, DataGridView).DataSource = Nothing
            Case TypeOf ctrl Is CheckBox
                CType(ctrl, CheckBox).Checked = True
            Case TypeOf ctrl Is NumericUpDown
                CType(ctrl, NumericUpDown).Value = 1
        End Select

        ' 🔹 Limpieza recursiva si hay paneles, groupbox, etc.
        For Each child As Control In ctrl.Controls
            LimpiarControl(child)
        Next
    End Sub

End Module







