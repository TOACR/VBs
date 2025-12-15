Imports System.Data.SqlClient
Public Class Form5_Eliminar

    ' Guarda el ID del funcionario seleccionado en el DataGrid
    Private _funcionarioIdSeleccionado As Integer? = Nothing
    Private Sub Form_Eliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Eliminar Funcionario"
        EstiloProfesionalDataGrid(DgvFuncionarios)
        CargarFuncionarios(True)
    End Sub

    ' Cargar funcionarios en el DataGridView
    Private Sub CargarFuncionarios(Optional activos As Boolean = True)
        Dim q As String
        If activos Then
            q = "SELECT * FROM Funcionario WHERE Activo = 1 ORDER BY Nombre"
        Else
            q = "SELECT * FROM Funcionario WHERE Activo = 0 ORDER BY Nombre"
        End If
        Dim dt = Db.GetTable(q, Nothing)
        DgvFuncionarios.DataSource = dt
    End Sub

    ' Seleccionar funcionario al hacer clic en el DataGridView
    Private Sub DgvFuncionarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvFuncionarios.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim r = DgvFuncionarios.Rows(e.RowIndex)

        If r.IsNewRow Then Exit Sub

        ' Validar que haya ID
        If r.Cells("FuncionarioId").Value Is Nothing OrElse
       IsDBNull(r.Cells("FuncionarioId").Value) Then

            _funcionarioIdSeleccionado = Nothing
            lblFuncionarioId.Text = ""
            Msk_id.Text = ""
            Exit Sub
        End If

        ' Guardar ID internamente (para eliminar)
        _funcionarioIdSeleccionado = CInt(r.Cells("FuncionarioId").Value)

        ' Mostrar NOMBRE COMPLETO en el label (no el ID)
        Dim nombre As String = If(IsDBNull(r.Cells("Nombre").Value), "", CStr(r.Cells("Nombre").Value))
        Dim ape1 As String = If(IsDBNull(r.Cells("Primer_Apellido").Value), "", CStr(r.Cells("Primer_Apellido").Value))
        Dim ape2 As String = If(IsDBNull(r.Cells("Segundo_Apellido").Value), "", CStr(r.Cells("Segundo_Apellido").Value))

        lblFuncionarioId.Text = $"{nombre} {ape1} {ape2}".Trim()

        ' Número de identificación opcional
        If Not IsDBNull(r.Cells("Numero_Identificacion").Value) Then
            Msk_id.Text = CStr(r.Cells("Numero_Identificacion").Value)
        Else
            Msk_id.Text = ""
        End If
    End Sub

    ' Eliminar funcionario seleccionado
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ' Validar que haya un funcionario seleccionado
        If Not _funcionarioIdSeleccionado.HasValue Then
            MessageBox.Show("Debe seleccionar un funcionario primero.", "Eliminar",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim id As Integer = _funcionarioIdSeleccionado.Value
        Dim nombreCompleto As String = lblFuncionarioId.Text

        ' Confirmar con el usuario
        Dim r = MessageBox.Show(
        $"¿Seguro que desea ELIMINAR POR COMPLETO al funcionario:{Environment.NewLine}{Environment.NewLine}" &
        $"{nombreCompleto}{Environment.NewLine}{Environment.NewLine}" &
        "Se eliminarán también todos los registros relacionados a adelantos, consumibles y liquidación.",
        "Confirmar eliminación",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning)

        If r = DialogResult.No Then Exit Sub
        Try
            ' Llamar al procedimiento almacenado que elimina todo
            Db.ExecNonQuery(
            "EXEC spEliminarFuncionarioCompleto @FuncionarioId",
            New List(Of SqlClient.SqlParameter) From {
                New SqlClient.SqlParameter("@FuncionarioId", id)})

            ' Registrar en bitácora la edición
            RegistrarBitacora(
            accion:="DELETE",
            tabla:="ELIMINAR FUNCIONARIO",
            llave:=UsuarioActual,
            descripcion:=$"Se eliminó el funcionario. Numero_Identificacion='" & Msk_id.Text & "', Nombre='" & nombreCompleto & "'")
            MessageBox.Show("Funcionario eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Limpiar selección y recargar el DataGrid
            _funcionarioIdSeleccionado = Nothing
            lblFuncionarioId.Text = ""
            Msk_id.Text = ""

            CargarFuncionarios(True)               ' vuelve a cargar solo activos

        Catch ex As Exception
            MessageBox.Show("Error al eliminar funcionario: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Regresar al formulario anterior
    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub
End Class