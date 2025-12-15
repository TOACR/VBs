Imports System.Data.SqlClient
Public Class Form7_GestionConsumibles
    Private _editando As Boolean = False
    Private _idEditando As Integer = -1
    Private _mostrandoInactivos As Boolean = False
    Private Sub FormGestionConsumibles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Gestión de Consumibles"
        _mostrandoInactivos = False
        BtnReactivar.Enabled = False
        EstiloProfesionalDataGrid(DgvConsumibles)
        CargarConsumiblesGrid(False)
        LimpiarFormulario()
    End Sub

    ' Cargar consumibles en el DataGridView
    Private Sub CargarConsumiblesGrid(Optional mostrarInactivos As Boolean = False)
        Dim q As String

        If mostrarInactivos Then
            q = " SELECT ConsumibleId, Nombre, Precio, Activo FROM Consumible WHERE Activo = 0 ORDER BY Nombre"
        Else
            q = " SELECT ConsumibleId, Nombre, Precio, Activo FROM Consumible WHERE Activo = 1 ORDER BY Nombre"
        End If
        Dim dt = Db.GetTable(q, Nothing)
        DgvConsumibles.DataSource = dt
        ' Opcional: ajustar columnas
        If DgvConsumibles.Columns.Count > 0 Then
            DgvConsumibles.Columns("ConsumibleId").HeaderText = "ID"
            DgvConsumibles.Columns("Nombre").HeaderText = "Nombre"
            DgvConsumibles.Columns("Precio").HeaderText = "Precio"
        End If
    End Sub

    ' Guardar (Agregar o Editar) consumible
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

            Db.ExecNonQuery(" UPDATE Consumible SET Nombre = @n, Precio = @p WHERE ConsumibleId = @id",
            New List(Of SqlParameter) From {
                New SqlParameter("@n", nombre),
                New SqlParameter("@p", precio),
                New SqlParameter("@id", _idEditando)})

            ' Registrar en bitácora la edición
            RegistrarBitacora(
            accion:="UPDATE",
            tabla:="CONSUMIBLE",
            llave:=UsuarioActual,
            descripcion:=$"Se editó el consumible '{nombre}'")
            MessageBox.Show("Consumible editado correctamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' --- MODO AGREGAR ---
            Db.ExecNonQuery(" INSERT INTO Consumible (Nombre, Precio) VALUES (@n, @p)",
            New List(Of SqlParameter) From {
                New SqlParameter("@n", nombre),
                New SqlParameter("@p", precio)})
            ' Registrar en bitácora la edición
            RegistrarBitacora(
            accion:="INSERT",
            tabla:="CONSUMIBLE",
            llave:=UsuarioActual,
            descripcion:=$"Se agregó el consumible '{nombre}'")
            MessageBox.Show("Consumible agregado correctamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        CargarConsumiblesGrid()
        LimpiarFormulario()
    End Sub

    ' Eliminar (inactivar) consumible
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If DgvConsumibles.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un consumible en la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim id As Integer = CInt(DgvConsumibles.CurrentRow.Cells("ConsumibleId").Value)
        Dim nombre As String = CStr(DgvConsumibles.CurrentRow.Cells("Nombre").Value)

        Dim r = MessageBox.Show($"¿Seguro que desea inactivar el consumible '{nombre}'?" & Environment.NewLine &
                            "Ya no podrá ser utilizado en nuevos consumos.",
                            "Confirmar inactivación",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning)

        If r <> DialogResult.Yes Then Exit Sub

        Dim q As String = " UPDATE Consumible SET Activo = 0 WHERE ConsumibleId = @id"

        Dim p As New List(Of SqlParameter) From {
        New SqlParameter("@id", id)}
        Dim filasAfectadas As Integer = Db.ExecNonQuery(q, p)
        If filasAfectadas > 0 Then
            ' Registrar en bitácora la inactivación
            RegistrarBitacora(
            accion:="UPDATE",
            tabla:="CONSUMIBLE",
            llave:=UsuarioActual,
            descripcion:=$"Se inactivó el consumible '{nombre}'. Activo=0.")
            MessageBox.Show("Consumible inactivado correctamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarConsumiblesGrid()
        Else
            MessageBox.Show("No se pudo inactivar el consumible (no se encontró el registro).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Cargar datos del consumible seleccionado para editar
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

    ' Limpiar formulario
    Private Sub LimpiarFormulario()
        TxtNombre.Clear()
        TxtPrecio.Clear()

        _editando = False
        _idEditando = -1

        BtnGuardar.Text = "AGREGAR"
        BtnCancelar.Visible = False

        TxtNombre.Focus()
    End Sub

    ' Mostrar consumibles inactivos o activos
    Private Sub BtnVerInactivos_Click(sender As Object, e As EventArgs) Handles BtnVerInactivos.Click
        ' Alternar el estado
        _mostrandoInactivos = Not _mostrandoInactivos

        If _mostrandoInactivos Then
            BtnVerInactivos.Text = "VER ACTIVOS"
            BtnReactivar.Enabled = True
            CargarConsumiblesGrid(True)
        Else
            BtnVerInactivos.Text = "VER INACTIVOS"
            BtnReactivar.Enabled = False
            CargarConsumiblesGrid(False)
        End If
    End Sub

    ' Reactivar consumible inactivo
    Private Sub BtnReactivar_Click(sender As Object, e As EventArgs) Handles BtnReactivar.Click
        If Not _mostrandoInactivos Then
            MessageBox.Show("Para reactivar un consumible, primero debe visualizar los inactivos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If DgvConsumibles.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un consumible inactivo en la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim id As Integer = CInt(DgvConsumibles.CurrentRow.Cells("ConsumibleId").Value)
        Dim nombre As String = CStr(DgvConsumibles.CurrentRow.Cells("Nombre").Value)
        Dim r = MessageBox.Show($"¿Seguro que desea reactivar el consumible '{nombre}'?", "Confirmar reactivación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If r <> DialogResult.Yes Then Exit Sub
        Dim q As String = " UPDATE Consumible SET Activo = 1 WHERE ConsumibleId = @id"

        Dim p As New List(Of SqlParameter) From {
            New SqlParameter("@id", id)}
        Dim filas As Integer = Db.ExecNonQuery(q, p)
        If filas > 0 Then
            ' Bitácora: reactivación
            RegistrarBitacora(
                accion:="UPDATE",
                tabla:="CONSUMIBLE",
                llave:=UsuarioActual,
                descripcion:=$"Se reactivó el consumible '{nombre}'. Activo=1.")
            MessageBox.Show("Consumible reactivado correctamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarConsumiblesGrid(True)
        Else
            MessageBox.Show("No se pudo reactivar el consumible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Cancelar edición
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        LimpiarFormulario()
    End Sub

    ' Regresar al menú principal
    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub
End Class
