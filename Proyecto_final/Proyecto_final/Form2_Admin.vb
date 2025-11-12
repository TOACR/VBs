Imports System.Data.SqlClient

Public Class Form2_Admin
    Private Sub Form2_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Registro"
        CargarFuncionarios()
    End Sub

    Private Sub CargarFuncionarios()
        DgvFuncionarios.DataSource = Db.GetTable("
            SELECT FuncionarioId, Tipo_Identificacion, Numero_Identificacion, Nombre, Primer_Apellido, Segundo_Apellido, Fecha_Nacimiento, Activo FROM Funcionario ORDER BY Nombre", Nothing)
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Msk_id.Text.Trim() = "" OrElse TxtNombre.Text.Trim() = "" Then
            MessageBox.Show("Cédula y Nombre son obligatorios.")
            Exit Sub
        End If

        If lblFuncionarioId.Text = "" Then
            ' Insert
            Db.ExecNonQuery("
                INSERT INTO Funcionario (Tipo_Identificacion, Numero_Identificacion, Nombre, Primer_Apellido, Segundo_Apellido, 
                                           Fecha_Nacimiento, Activo)
                VALUES (@tid, @numid, @nom, @priap, @segap, @fecnam, @act)",
                New List(Of SqlParameter) From {
                    New SqlParameter("@tid", ntipoid),
                    New SqlParameter("@numid", Msk_id.Text.Trim()),
                    New SqlParameter("@nom", TxtNombre.Text.Trim()),
                    New SqlParameter("@priap", Txtprimer_apellido.Text.Trim()),
                    New SqlParameter("@segap", Txtsegundo_apellido.Text.Trim()),
                    New SqlParameter("@fecnam", Dtp_fecha_nacimiento.Value),
                    New SqlParameter("@act", If(ChkActivo.Checked, 1, 0))
                })
        Else
            ' Update
            Db.ExecNonQuery("
                UPDATE Funcionario SET Tipo_Identificacion=@tid, Numero_Identificacion=@numid, Nombre=@nom, Primer_Apellido=@priap,
                                        Segundo_Apellido=@segap, Fecha_Nacimiento=@fecnam, Activo=@act
                WHERE FuncionarioId=@id",
                New List(Of SqlParameter) From {
                    New SqlParameter("@tid", ntipoid),
                    New SqlParameter("@numid", Msk_id.Text.Trim()),
                    New SqlParameter("@nom", TxtNombre.Text.Trim()),
                    New SqlParameter("@priap", Txtprimer_apellido.Text.Trim()),
                    New SqlParameter("@segap", Txtsegundo_apellido.Text.Trim()),
                    New SqlParameter("@fecnam", Dtp_fecha_nacimiento.Value),
                    New SqlParameter("@act", If(ChkActivo.Checked, 1, 0)),
                    New SqlParameter("@id", CInt(lblFuncionarioId.Text))
                })
        End If
        CargarFuncionarios()
        Limpiar()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If lblFuncionarioId.Text = "" Then
            MessageBox.Show("Seleccione un funcionario.")
            Exit Sub
        End If

        If MessageBox.Show("¿Eliminar funcionario?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
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
            Msk_id.Text = CStr(r.Cells("Numero_Identificación").Value)
            TxtNombre.Text = CStr(r.Cells("Nombre").Value)
            Txtprimer_apellido.Text = CStr(r.Cells("Primer Apellido").Value)
            Txtsegundo_apellido.Text = CStr(r.Cells("Segundo Apellido").Value)
            ChkActivo.Checked = CBool(r.Cells("Activo").Value)
        End If
    End Sub

    Private Sub Limpiar()
        lblFuncionarioId.Text = ""
        Msk_id.Clear()
        TxtNombre.Clear()
        ChkActivo.Checked = True
    End Sub

    Private Sub BtnRefrescar_Click(sender As Object, e As EventArgs) Handles BtnRefrescar.Click
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
End Class
