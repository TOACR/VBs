Imports System.Data.SqlClient

Public Class Form2_Admin
    Private _viendoInactivos As Boolean = False
    Private Sub Form2_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Registro"
        _viendoInactivos = False
        LblEstadoLista.Text = "MOSTRANDO FUNCIONARIOS ACTIVOS"
        LblEstadoLista.ForeColor = Color.Green ' 🟢 Color para activos
        EstiloProfesionalDataGrid(DgvFuncionarios)
        CargarFuncionarios(True)
    End Sub
    Private Sub Cmb_tipoid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_tipoid.SelectedIndexChanged
        Msk_id.Text = ""
        If Cmb_tipoid.Text = "CEDULA NACIONAL" Then
            ntipoid = 1
            Msk_id.Mask = "9-9999-9999"
            SendKeys.Send("{tab}")
        ElseIf Cmb_tipoid.Text = "DIMEX" Then
            ntipoid = 2
            Msk_id.Mask = "999999999999"
            SendKeys.Send("{tab}")
        ElseIf Cmb_tipoid.Text = "PASAPORTE" Then
            ntipoid = 3
            Msk_id.Mask = "AAAAAAAAAAAAAAAAAAAAAAAA"
            SendKeys.Send("{tab}")
        End If
    End Sub
    Private Sub TxtNombre_KeyPress(sender As Object, e As EventArgs) Handles TxtNombre.KeyPress
        Set_solo_letras(e)
    End Sub
    Private Sub Txtprimer_apellido_KeyPress(sender As Object, e As EventArgs) Handles Txtprimer_apellido.KeyPress
        Set_solo_letras(e)
    End Sub
    Private Sub Txtsegundo_apellido_KeyPress(sender As Object, e As EventArgs) Handles Txtsegundo_apellido.KeyPress
        Set_solo_letras(e)
    End Sub
    Private Sub CargarFuncionarios(Optional activos As Boolean = True)

        Dim q As String

        If activos Then
            q = "SELECT * FROM Funcionario WHERE Activo = 1 ORDER BY Nombre"
        Else
            q = "SELECT * FROM Funcionario WHERE Activo = 0 ORDER BY Nombre"
        End If
        BtnActivar.Enabled = _viendoInactivos

        Dim dt = Db.GetTable(q, Nothing)
        DgvFuncionarios.DataSource = dt

    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            ' Validaciones básicas
            If String.IsNullOrWhiteSpace(Msk_id.Text) OrElse String.IsNullOrWhiteSpace(TxtNombre.Text) OrElse String.IsNullOrWhiteSpace(Txtprimer_apellido.Text) Then
                MessageBox.Show("Número de identificación, nombre y primer apellido son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Normalizaciones/lecturas
            Dim vTipoId As String = ntipoid
            Dim vNumId As String = Msk_id.Text.Trim()
            Dim vNombre As String = TxtNombre.Text.Trim()
            Dim vPriAp As String = Txtprimer_apellido.Text.Trim()
            Dim vSegAp As String = Txtsegundo_apellido.Text.Trim()
            Dim vFechaNac As Date = Dtp_fecha_nacimiento.Value.Date
            Dim vActivo As Integer = If(ChkActivo.Checked, 1, 0)

            ' 🔎 Validar existencia según modo (insert/update)
            If String.IsNullOrWhiteSpace(lblFuncionarioId.Text) Then
                ' ===== INSERT =====
                Dim qExiste As String = "SELECT COUNT(*) FROM Funcionario WHERE Tipo_Identificacion=@tid AND Numero_Identificacion=@numid;"
                Dim pExiste As New List(Of SqlParameter) From {
                New SqlParameter("@tid", vTipoId),
                New SqlParameter("@numid", vNumId)
            }
                Dim existe As Integer = CInt(Db.ExecScalar(qExiste, pExiste))
                If existe > 0 Then
                    MessageBox.Show("Ya existe un funcionario con ese tipo y número de identificación.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                ' Insertar
                Dim qIns As String = "
                INSERT INTO Funcionario
                (Tipo_Identificacion, Numero_Identificacion, Nombre, Primer_Apellido, Segundo_Apellido, Fecha_Nacimiento, Activo)
                VALUES (@tid, @numid, @nom, @priap, @segap, @fecnam, @act);"
                Dim pIns As New List(Of SqlParameter) From {
                New SqlParameter("@tid", vTipoId),
                New SqlParameter("@numid", vNumId),
                New SqlParameter("@nom", vNombre),
                New SqlParameter("@priap", vPriAp),
                New SqlParameter("@segap", vSegAp),
                New SqlParameter("@fecnam", vFechaNac),
                New SqlParameter("@act", vActivo)
            }
                Dim filas As Integer = Db.ExecNonQuery(qIns, pIns)
                If filas > 0 Then
                    MessageBox.Show("Funcionario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                ' ===== UPDATE =====
                Dim vId As Integer = CInt(lblFuncionarioId.Text)

                ' Validar que no exista OTRO registro con la misma identificación
                Dim qExisteUpd As String = "
                SELECT COUNT(*) FROM Funcionario
                WHERE Tipo_Identificacion=@tid AND Numero_Identificacion=@numid AND FuncionarioId<>@id;"
                Dim pExisteUpd As New List(Of SqlParameter) From {
                New SqlParameter("@tid", vTipoId),
                New SqlParameter("@numid", vNumId),
                New SqlParameter("@id", vId)
            }

                Dim existeOtro As Integer = CInt(Db.ExecScalar(qExisteUpd, pExisteUpd))
                If existeOtro > 0 Then
                    MessageBox.Show("Ya existe otro funcionario con ese tipo y número de identificación.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                ' Actualizar
                Dim qUpd As String = "
                UPDATE Funcionario
                SET Tipo_Identificacion=@tid,
                    Numero_Identificacion=@numid,
                    Nombre=@nom,
                    Primer_Apellido=@priap,
                    Segundo_Apellido=@segap,
                    Fecha_Nacimiento=@fecnam,
                    Activo=@act
                WHERE FuncionarioId=@id;"
                Dim pUpd As New List(Of SqlParameter) From {
                New SqlParameter("@tid", vTipoId),
                New SqlParameter("@numid", vNumId),
                New SqlParameter("@nom", vNombre),
                New SqlParameter("@priap", vPriAp),
                New SqlParameter("@segap", vSegAp),
                New SqlParameter("@fecnam", vFechaNac),
                New SqlParameter("@act", vActivo),
                New SqlParameter("@id", vId)
            }
                Dim filas As Integer = Db.ExecNonQuery(qUpd, pUpd)
                If filas > 0 Then
                    MessageBox.Show("Funcionario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

            ' Refrescar grilla y limpiar formulario
            LimpiarControles(Me)
            CargarFuncionarios()
        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        LblEstadoLista.Text = "MOSTRANDO FUNCIONARIOS ACTIVOS"
        LblEstadoLista.ForeColor = Color.Green ' 🟢 Color para activos
    End Sub

    Private Sub BtnDesactivar_Click(sender As Object, e As EventArgs) Handles BtnDesactivar.Click
        If lblFuncionarioId.Text = "" Then
            MessageBox.Show("Debe seleccionar un funcionario primero.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim id As Integer = CInt(lblFuncionarioId.Text)
        Dim r = MessageBox.Show("¿Seguro que desea marcar como INACTIVO a este funcionario?",
                            "Confirmar eliminación",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question)
        If r = DialogResult.No Then Exit Sub
        Try
            Db.ExecNonQuery("UPDATE Funcionario SET Activo = 0 WHERE FuncionarioId = @id",
                            New List(Of SqlParameter) From {
                            New SqlParameter("@id", id)})

            MessageBox.Show("Funcionario marcado como inactivo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

            _viendoInactivos = False          ' volvemos a vista de activos
            LimpiarControles(Me)              ' limpia controles si ya la tienes
            CargarFuncionarios()              ' recarga la grilla
            LblEstadoLista.Text = "MOSTRANDO FUNCIONARIOS ACTIVOS"
        Catch ex As Exception
            MessageBox.Show("Error al marcar inactivo: " & ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub DgvFuncionarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvFuncionarios.CellClick
        ' Ignorar clicks en encabezados o filas inválidas
        If e.RowIndex < 0 Then Exit Sub

        Dim r = DgvFuncionarios.Rows(e.RowIndex)

        ' 🔹 Si es una fila nueva (vacía), no hacemos nada
        If r.IsNewRow Then Exit Sub

        ' 🔹 Si no hay ID, tampoco hacemos nada
        If r.Cells("FuncionarioId").Value Is Nothing OrElse
       IsDBNull(r.Cells("FuncionarioId").Value) Then
            Exit Sub
        End If

        lblFuncionarioId.Text = CStr(r.Cells("FuncionarioId").Value)

        ' Cuida también los demás campos por si vienen nulos de la BD:
        Cmb_tipoid.SelectedIndex = CInt(If(IsDBNull(r.Cells("Tipo_Identificacion").Value), 1, r.Cells("Tipo_Identificacion").Value)) - 1
        Msk_id.Text = If(IsDBNull(r.Cells("Numero_Identificacion").Value), "", CStr(r.Cells("Numero_Identificacion").Value))
        TxtNombre.Text = If(IsDBNull(r.Cells("Nombre").Value), "", CStr(r.Cells("Nombre").Value))
        Txtprimer_apellido.Text = If(IsDBNull(r.Cells("Primer_Apellido").Value), "", CStr(r.Cells("Primer_Apellido").Value))
        Txtsegundo_apellido.Text = If(IsDBNull(r.Cells("Segundo_Apellido").Value), "", CStr(r.Cells("Segundo_Apellido").Value))
        ChkActivo.Checked = If(IsDBNull(r.Cells("Activo").Value), False, CBool(r.Cells("Activo").Value))
    End Sub
    Private Sub BtnVerInactivos_Click(sender As Object, e As EventArgs) Handles BtnVerInactivos.Click

        _viendoInactivos = Not _viendoInactivos   ' 🔄 Alternar estado

        If _viendoInactivos Then
            ' 🔹 Cargar INACTIVOS
            CargarFuncionarios(False)
            BtnVerInactivos.Text = "VER ACTIVOS"

            LblEstadoLista.Text = "MOSTRANDO FUNCIONARIOS INACTIVOS"
            LblEstadoLista.ForeColor = Color.Red   ' 🔴 Color para inactivos

        Else
            ' 🔹 Cargar ACTIVOS
            CargarFuncionarios(True)
            BtnVerInactivos.Text = "VER INACTIVOS"

            LblEstadoLista.Text = "MOSTRANDO FUNCIONARIOS ACTIVOS"
            LblEstadoLista.ForeColor = Color.Green ' 🟢 Color para activos
        End If

    End Sub
    Private Sub BtnActivar_Click(sender As Object, e As EventArgs) Handles BtnActivar.Click
        If DgvFuncionarios.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar un funcionario.", "Activar",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim id As Integer = CInt(DgvFuncionarios.CurrentRow.Cells("FuncionarioId").Value)

        Try
            Db.ExecNonQuery("
            UPDATE Funcionario
            SET Activo = 1
            WHERE FuncionarioId = @id",
            New List(Of SqlParameter) From {
                New SqlParameter("@id", id)
            })

            MessageBox.Show("Funcionario activado correctamente.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Después de activar, volvemos a ver activos
            _viendoInactivos = False
            BtnVerInactivos.Text = "VER INACTIVOS"
            LimpiarControles(Me) ' si tienes una rutina que limpia los controles
            CargarFuncionarios()
            LblEstadoLista.Text = "MOSTRANDO FUNCIONARIOS ACTIVOS"
        Catch ex As Exception
            MessageBox.Show("Error al activar funcionario: " & ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Form5_Eliminar.Show()
        Me.Hide()
    End Sub
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        LimpiarControles(Me)
        CargarFuncionarios()
        LblEstadoLista.Text = "MOSTRANDO FUNCIONARIOS ACTIVOS"
        LblEstadoLista.ForeColor = Color.Green ' 🟢 Color para activos
    End Sub
    Private Sub Btnregresar_Click(sender As Object, e As EventArgs) Handles Btnregresar.Click
        If Me.Owner IsNot Nothing Then Me.Owner.Show()
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        Dim f As New Form6_Usuarios()
        f.ShowDialog()
    End Sub

End Class
