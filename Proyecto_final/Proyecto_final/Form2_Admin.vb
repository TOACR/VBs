Imports System.Data.SqlClient

Public Class Form2_Admin
    Private Sub Form2_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Registro"
        CargarFuncionarios()
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
        set_solo_letras(e)
    End Sub
    Private Sub Txtprimer_apellido_KeyPress(sender As Object, e As EventArgs) Handles Txtprimer_apellido.KeyPress
        set_solo_letras(e)
    End Sub
    Private Sub Txtsegundo_apellido_KeyPress(sender As Object, e As EventArgs) Handles Txtsegundo_apellido.KeyPress
        set_solo_letras(e)
    End Sub
    Private Sub CargarFuncionarios()
        DgvFuncionarios.DataSource = Db.GetTable("
            SELECT FuncionarioId, Tipo_Identificacion, Numero_Identificacion, Nombre, Primer_Apellido, Segundo_Apellido, Fecha_Nacimiento, Activo FROM Funcionario ORDER BY Nombre", Nothing)
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            ' Validaciones básicas
            If String.IsNullOrWhiteSpace(Msk_id.Text) OrElse String.IsNullOrWhiteSpace(TxtNombre.Text) Then
                MessageBox.Show("Número de identificación y Nombre son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                    MessageBox.Show("Empleado agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            CargarFuncionarios()
            Limpiar()

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If lblFuncionarioId.Text = "" Then
            MessageBox.Show("Seleccione un empleado.")
            Exit Sub
        End If
        If MessageBox.Show("¿Eliminar empleado?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Db.ExecNonQuery("DELETE FROM Funcionario WHERE FuncionarioId=@id",
                New List(Of SqlParameter) From {New SqlParameter("@id", CInt(lblFuncionarioId.Text))})
            CargarFuncionarios()
            Limpiar()
        End If
    End Sub
    Private Sub DgvFuncionarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvFuncionarios.CellClick
        If e.RowIndex >= 0 Then
            Dim r = DgvFuncionarios.Rows(e.RowIndex)
            lblFuncionarioId.Text = CStr(r.Cells("FuncionarioId").Value)
            Cmb_tipoid.SelectedIndex = CInt(r.Cells("Tipo_Identificacion").Value) - 1
            Msk_id.Text = CStr(r.Cells("Numero_Identificacion").Value)
            TxtNombre.Text = CStr(r.Cells("Nombre").Value)
            Txtprimer_apellido.Text = CStr(r.Cells("Primer_Apellido").Value)
            Txtsegundo_apellido.Text = CStr(r.Cells("Segundo_Apellido").Value)
            ChkActivo.Checked = CBool(r.Cells("Activo").Value)
        End If
    End Sub
    Private Sub Limpiar()
        lblFuncionarioId.Text = ""
        Cmb_tipoid.SelectedIndex = -1
        Msk_id.Clear()
        TxtNombre.Clear()
        Txtprimer_apellido.Clear()
        Txtsegundo_apellido.Clear()
        ChkActivo.Checked = True
    End Sub
    Private Sub BtnRefrescar_Click(sender As Object, e As EventArgs) Handles BtnRefrescar.Click
        CargarFuncionarios()
        Limpiar()
    End Sub
    Private Sub Btnregresar_Click(sender As Object, e As EventArgs) Handles Btnregresar.Click
        If Me.Owner IsNot Nothing Then Me.Owner.Show()
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub
End Class
