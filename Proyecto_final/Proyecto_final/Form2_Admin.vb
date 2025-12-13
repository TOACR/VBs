Imports System.Data.SqlClient

Public Class Form2_Admin
    Private _viendoInactivos As Boolean = False
    Dim conexion As Conexion = New Conexion()
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
    Private Sub Msk_id_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Msk_id.PreviewKeyDown
        ' Solo cuando es CÉDULA NACIONAL tratamos TAB como tecla de entrada
        If e.KeyCode = Keys.Tab AndAlso ntipoid = 1 Then
            e.IsInputKey = True
        End If
    End Sub
    Private Sub Msk_id_KeyDown(sender As Object, e As KeyEventArgs) Handles Msk_id.KeyDown
        ' Cuando utilicemos ENTER
        If e.KeyCode = Keys.Enter Then
            If ntipoid = 1 Then
                e.SuppressKeyPress = True
                e.Handled = True
                ValidarIdentificacionCedula()
            End If
            ' Si ntipoid <> 1, ENTER se comporta normal
        End If
        ' Cuando utilicemos TAB
        If e.KeyCode = Keys.Tab Then
            If ntipoid = 1 Then
                ' Solo para CÉDULA: que TAB valide y NO avance
                e.SuppressKeyPress = True
                e.Handled = True
                ValidarIdentificacionCedula()
            End If
            ' Si ntipoid <> 1 -> TAB mueve el foco normalmente
        End If
    End Sub
    Private Sub ValidarIdentificacionCedula()
        ' Solo aplica para CÉDULA NACIONAL
        If ntipoid <> 1 Then
            Exit Sub
        End If

        ' Validar que escogieron tipo y llenaron la máscara
        If Cmb_tipoid.Text = "" Or Not Msk_id.MaskFull Then
            MsgBox("Debe digitar el número de identificación para consultar en el Padrón",
               MsgBoxStyle.Exclamation,
               "Validación")
            Msk_id.Focus()
            Exit Sub
        End If
        Try
            Dim valorformateado As String = Msk_id.Text
            Dim valorsinformato As String = valorformateado.Replace("-", "")
            If valorsinformato.Trim() <> "" Then
                Dim dt = conexion.Busca_padron(valorsinformato)

                If f = 1 Then
                    MsgBox("El número de identificación " & valorsinformato & " no se encuentra registrado en el padrón.",
                       MsgBoxStyle.Critical,
                       "Validación")
                    Msk_id.Focus()
                    Exit Sub
                Else
                    TxtNombre.Text = Trim(dt.Rows(0)!nombre)
                    Txtprimer_apellido.Text = Trim(dt.Rows(0)!apellido1)
                    Txtsegundo_apellido.Text = Trim(dt.Rows(0)!apellido2)

                    ' Deshabilitar para que no se modifiquen los datos del padrón
                    TxtNombre.Enabled = False
                    Txtprimer_apellido.Enabled = False
                    Txtsegundo_apellido.Enabled = False
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error :" & ex.ToString(),
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
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
                    ' Registrar en bitácora la creación
                    RegistrarBitacora(
                    accion:="INSERT",
                    tabla:="CREACION FUNCIONARIO",
                    llave:=UsuarioActual,
                    descripcion:=$"Se creó el funcionario. Numero_Identificacion= {vNumId}, Nombre='{vNombre} {vPriAp} {vSegAp}'")
                    MessageBox.Show("Funcionario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LimpiarControles(Me)
                    TxtNombre.Enabled = True
                    Txtprimer_apellido.Enabled = True
                    Txtsegundo_apellido.Enabled = True
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
                New SqlParameter("@id", vId)}

                Dim existeOtro As Integer = CInt(Db.ExecScalar(qExisteUpd, pExisteUpd))
                If existeOtro > 0 Then
                    MessageBox.Show("Ya existe otro funcionario con ese tipo y número de identificación.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                ' Actualizar
                Dim qUpd As String = "
                UPDATE Funcionario SET Tipo_Identificacion=@tid, Numero_Identificacion=@numid, Nombre=@nom, Primer_Apellido=@priap,
                    Segundo_Apellido=@segap, Fecha_Nacimiento=@fecnam, Activo=@act WHERE FuncionarioId=@id;"

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
                    ' Registrar en bitácora la edición
                    RegistrarBitacora(
                    accion:="UPDATE",
                    tabla:="EDICION FUNCIONARIO",
                    llave:=UsuarioActual,
                    descripcion:=$"Se editó el funcionario. Numero_Identificacion= {vNumId}, Nombre='{vNombre}', 
                    Primer_Apellido='{vPriAp}', Segundo_Apellido='{vSegAp}'")
                    MessageBox.Show("Funcionario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LimpiarControles(Me)
                    TxtNombre.Enabled = True
                    Txtprimer_apellido.Enabled = True
                    Txtsegundo_apellido.Enabled = True
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
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        LimpiarControles(Me)
        CargarFuncionarios()
        TxtNombre.Enabled = True
        Txtprimer_apellido.Enabled = True
        Txtsegundo_apellido.Enabled = True
        LblEstadoLista.Text = "MOSTRANDO FUNCIONARIOS ACTIVOS"
        LblEstadoLista.ForeColor = Color.Green ' 🟢 Color para activos
    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ' Pedir credenciales de ADMIN
        Using frmLogin As New FormLogin("ADMIN", True)  ' rolForzado = "ADMIN", soloValidar = True
            Dim r = frmLogin.ShowDialog(Me)

            If r <> DialogResult.OK OrElse Not frmLogin.LoginOK Then
                MessageBox.Show("Acceso denegado. Debe autenticarse como ADMIN.", "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End Using
        Dim f As New Form5_Eliminar()
        f.ShowDialog()
    End Sub
    Private Sub BtnGestionar_Click(sender As Object, e As EventArgs) Handles BtnGestionar.Click
        ' Pedir credenciales de ADMIN
        Using frmLogin As New FormLogin("ADMIN", True)  ' rolForzado = "ADMIN", soloValidar = True
            Dim r = frmLogin.ShowDialog(Me)

            If r <> DialogResult.OK OrElse Not frmLogin.LoginOK Then
                MessageBox.Show("Acceso denegado. Debe autenticarse como ADMIN.", "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End Using

        ' Si llegó aquí, el ADMIN se autenticó correctamente
        Dim f As New Form7_GestionConsumibles()
        f.ShowDialog(Me)   ' o f.Show() si quieres que sea no modal
    End Sub
    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        ' Pedir credenciales de ADMIN
        Using frmLogin As New FormLogin("ADMIN", True)  ' rolForzado = "ADMIN", soloValidar = True
            Dim r = frmLogin.ShowDialog(Me)

            If r <> DialogResult.OK OrElse Not frmLogin.LoginOK Then
                MessageBox.Show("Acceso denegado. Debe autenticarse como ADMIN.", "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End Using
        Dim f As New Form6_Usuarios()
        f.ShowDialog()
    End Sub
    Private Sub BtnBitacora_Click(sender As Object, e As EventArgs) Handles BtnBitacora.Click
        ' Pedir credenciales de ADMIN
        Using frmLogin As New FormLogin("ADMIN", True)  ' rolForzado = "ADMIN", soloValidar = True
            Dim r = frmLogin.ShowDialog(Me)

            If r <> DialogResult.OK OrElse Not frmLogin.LoginOK Then
                MessageBox.Show("Acceso denegado. Debe autenticarse como ADMIN.", "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End Using
        Dim f As New FormBitacora()
        f.Show()
    End Sub
    Private Sub Btnregresar_Click(sender As Object, e As EventArgs) Handles Btnregresar.Click
        If Me.Owner IsNot Nothing Then Me.Owner.Show()
        RegistrarBitacora(
        accion:="LOGOUT",
        tabla:="SEGURIDAD",
        llave:=UsuarioActual,
        descripcion:="Cierre de sesión.")
        ' Limpiar variables globales
        UsuarioActual = ""
        RolActual = ""
        Form1.Show()
        Me.Close()
    End Sub
End Class
