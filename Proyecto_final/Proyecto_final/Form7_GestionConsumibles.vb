Imports System.Data.SqlClient
Public Class Form7_GestionConsumibles
    Private _editando As Boolean = False
    Private _idEditando As Integer = -1
    Private Sub FormGestionConsumibles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Gestión de Consumibles"
        ' Si tienes este método ya definido, úsalo
        EstiloProfesionalDataGrid(DgvConsumibles)
        CargarConsumiblesGrid()
    End Sub

    Private Sub CargarConsumiblesGrid()
        Dim dt = Db.GetTable("SELECT ConsumibleId, Nombre, Precio FROM Consumible ORDER BY Nombre", Nothing)
        DgvConsumibles.DataSource = dt
        ' Opcional: ajustar columnas
        If DgvConsumibles.Columns.Count > 0 Then
            DgvConsumibles.Columns("ConsumibleId").HeaderText = "ID"
            DgvConsumibles.Columns("Nombre").HeaderText = "Nombre"
            DgvConsumibles.Columns("Precio").HeaderText = "Precio"
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim nombre As String = TxtNombre.Text.Trim()
        Dim precio As Decimal
        If nombre = "" Then
            MessageBox.Show("Debe ingresar un nombre.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If Not Decimal.TryParse(TxtPrecio.Text, precio) OrElse precio < 0D Then
            MessageBox.Show("Debe ingresar un precio válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        ' --- MODO EDICIÓN ---
        If _editando AndAlso _idEditando > 0 Then

            Db.ExecNonQuery("
            UPDATE Consumible
            SET Nombre = @n, Precio = @p
            WHERE ConsumibleId = @id",
            New List(Of SqlParameter) From {
                New SqlParameter("@n", nombre),
                New SqlParameter("@p", precio),
                New SqlParameter("@id", _idEditando)
            })

            MessageBox.Show("Consumible editado correctamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' --- MODO AGREGAR ---
            Db.ExecNonQuery("
            INSERT INTO Consumible (Nombre, Precio)
            VALUES (@n, @p)",
            New List(Of SqlParameter) From {
                New SqlParameter("@n", nombre),
                New SqlParameter("@p", precio)
            })

            MessageBox.Show("Consumible agregado correctamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        CargarConsumiblesGrid()
        LimpiarFormulario()
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        LimpiarFormulario()
    End Sub
    Private Sub LimpiarFormulario()
        TxtNombre.Clear()
        TxtPrecio.Clear()

        _editando = False
        _idEditando = -1

        BtnGuardar.Text = "AGREGAR"
        BtnCancelar.Visible = False

        TxtNombre.Focus()
    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If DgvConsumibles.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un consumible en la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim id As Integer = CInt(DgvConsumibles.CurrentRow.Cells("ConsumibleId").Value)
        Dim nombre As String = CStr(DgvConsumibles.CurrentRow.Cells("Nombre").Value)

        Dim r = MessageBox.Show($"¿Seguro que desea eliminar el consumible '{nombre}' (ID {id})?",
                                "Confirmar eliminación",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning)

        If r <> DialogResult.Yes Then Exit Sub

        Db.ExecNonQuery("
            DELETE FROM Consumible
            WHERE ConsumibleId = @id",
            New List(Of SqlParameter) From {
                New SqlParameter("@id", id)
            })

        MessageBox.Show("Consumible eliminado correctamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Refrescar grilla
        CargarConsumiblesGrid()
    End Sub
    Private Sub DgvConsumibles_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvConsumibles.CellClick
        If e.RowIndex >= 0 Then

            _editando = True
            _idEditando = CInt(DgvConsumibles.CurrentRow.Cells("ConsumibleId").Value)

            TxtNombre.Text = CStr(DgvConsumibles.CurrentRow.Cells("Nombre").Value)
            TxtPrecio.Text = CDec(DgvConsumibles.CurrentRow.Cells("Precio").Value).ToString("N2")

            BtnGuardar.Text = "EDITAR"
            BtnCancelar.Visible = True
        End If
    End Sub
    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub
End Class
