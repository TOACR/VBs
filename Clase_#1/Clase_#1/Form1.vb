Imports System.Data.SqlClient

Public Class Form1
    Dim conexion As Conexion = New Conexion()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'II36DB03Q2025DataSet2.CIUDADANO' Puede moverla o quitarla según sea necesario.
        Me.CIUDADANOTableAdapter.Fill(Me.II36DB03Q2025DataSet2.CIUDADANO)


        'MsgBox("Bienvenidos al curso de Progra II")

        '1-1056-0601 Nacional
        '123456789123 Dimex
        '9MXA1545KYUI56 Alfa 24

        Timer1.Interval = 1000
        Timer1.Start()
        conexion.conectar()
        CargarEstados()
        EstiloProfesionalDataGrid(Dgvpersona)

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Txt_fecha.Text = Now
    End Sub

    Private Sub Txtnombre_Keypress(sender As Object, e As EventArgs) Handles Txtnombre.KeyPress
        set_solo_letras(e)
    End Sub
    Private Sub Txtprimer_apellido_Keypress(sender As Object, e As EventArgs) Handles Txtprimer_apellido.KeyPress
        set_solo_letras(e)
    End Sub
    Private Sub Txtsegundo_apellido_Keypress(sender As Object, e As EventArgs) Handles Txtsegundo_apellido.KeyPress
        set_solo_letras(e)
    End Sub
    Private Sub Cmb_tipoid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_tipoid.SelectedIndexChanged
        Msk_id.Text = ""
        If Cmb_tipoid.Text = "CEDULA NACIONAL" Then
            ntipoid = 1
            Msk_id.Mask = "9-9999-9999"
            SendKeys.Send("{tab}")
        ElseIf Cmb_tipoid.Text = "DIMEX" Then
            ntipoid = 2
            Msk_id.Mask = " 999999999999"
            SendKeys.Send("{tab}")
        ElseIf Cmb_tipoid.Text = "PASAPORTE" Then
            ntipoid = 3
            Msk_id.Mask = "AAAAAAAAAAAAAAAAAAAAAAAA"
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub CmbEstadoCivil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEstadoCivil.SelectedIndexChanged
        If CmbEstadoCivil.Text = "SOLTERO" Then
            ntipoestado = 1
            SendKeys.Send("{tab}")
        ElseIf CmbEstadoCivil.Text = "CASADO" Then
            ntipoestado = 2
            SendKeys.Send("{tab}")
        ElseIf CmbEstadoCivil.Text = "DIVORCIADO" Then
            ntipoestado = 3
            SendKeys.Send("{tab}")
        ElseIf CmbEstadoCivil.Text = "VIUDO" Then
            ntipoestado = 4
            SendKeys.Send("{tab}")
        ElseIf CmbEstadoCivil.Text = "UNION LIBRE" Then
            ntipoestado = 5
            SendKeys.Send("{tab}")
        End If
    End Sub
    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        f = 0
        Dim vtipoid, vestadocivil As Integer
        vtipoid = 0
        vestadocivil = 0
        Dim vnumeroid, vnombre, vapellido1, vapellido2, vfechanacimiento, vcorreo, vdireccion, valorformateado, valorsinformato, vfecha, vusuario, vaccion, vidbitacora, strsql, strsqlbit As String
        vnumeroid = ""
        vnombre = ""
        vapellido1 = ""
        vapellido2 = ""
        vfechanacimiento = ""
        vcorreo = ""
        vdireccion = ""
        valorformateado = ""
        valorsinformato = ""
        vfecha = ""
        vusuario = ""
        vaccion = ""
        vidbitacora = ""
        strsql = ""
        strsqlbit = ""
        Try
            If validar_campos() = False Then
                MsgBox("Datos Incompletos, favor completar")
                Return
            Else
                If MessageBox.Show("¿Desea guardar el registro en la base de datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    'quitar guiones del numero de id
                    valorformateado = Msk_id.Text
                    valorsinformato = valorformateado.Replace("-", "")
                    vnumeroid = valorsinformato
                    vtipoid = ntipoid
                    vnombre = Txtnombre.Text
                    vapellido1 = Txtprimer_apellido.Text
                    vapellido2 = Txtsegundo_apellido.Text
                    vfechanacimiento = Dtp_fecha_nacimiento.Value.ToString("yyyy-MM-dd")
                    vcorreo = Txtcorreo.Text
                    vdireccion = Txtdireccion.Text
                    vestadocivil = ntipoestado
                    vidbitacora = vnumeroid
                    vfecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                    vusuario = "admin"
                    vaccion = "INSERTAR"
                    Dim dt = conexion.valida_id(vtipoid, vnumeroid)
                    If f = 0 Then 'ya existe
                        MsgBox("Registro existe en la base de datos, no puede insertarlo nuevamente " & Cmb_tipoid.Text & " y número de identificación " & vnumeroid & " ya se encuentra registrado en la base de datos.")
                        Return
                    Else
                        'Crear el sql insert
                        strsql = "INSERT CIUDADANO (TIPO_IDENTIFICACION, NUMERO_IDENTIFICACION, NOMBRE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, FECHA_NACIMIENTO, CORREO_ELECTRONICO, DIRECCION, CODIGO_CIVIL)"
                        strsql += vbCrLf + "VALUES ('" & vtipoid & "','" & vnumeroid & "','" & vnombre & "','" & vapellido1 & "','" & vapellido2 & "','" & vfechanacimiento & "','" & vcorreo & "','" & vdireccion & "','" & vestadocivil & "')"
                        strsqlbit = "INSERT BITACORA_CIUDADANO (ID_BITACORA, TIPO_IDENTIFICACION, NUMERO_IDENTIFICACION, FECHA_HORA, USUARIO, ACCION)"
                        strsqlbit += vbCrLf + "VALUES ('" & vidbitacora & "','" & vtipoid & "','" & vnumeroid & "','" & vfecha & "','" & vusuario & "','" & vaccion & "')"
                        MsgBox(strsql)
                        conexion.inserta_datos(strsql)
                        conexion.inserta_datos(strsqlbit)
                        If f = 0 Then
                            Dgvpersona.DataSource = Nothing
                            Dgvpersona.Rows.Clear()
                            Me.CIUDADANOTableAdapter.Fill(Me.II36DB03Q2025DataSet2.CIUDADANO)
                            Dgvpersona.DataSource = Me.II36DB03Q2025DataSet2.CIUDADANO
                            MessageBox.Show("Datos almacenados satisfactoriamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Else
                            MessageBox.Show("Error al insertar los datos", "Datos no guardados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString)
        End Try

    End Sub
    Private Function validar_campos() As Boolean
        If Cmb_tipoid.Text = "" Or Msk_id.MaskFull = False Or Txtnombre.Text = "" Or Txtprimer_apellido.Text = "" Or Txtcorreo.Text = "" Or Txtdireccion.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub Btnconsultar_Click(sender As Object, e As EventArgs) Handles Btnconsultar.Click
        Try
            If Cmb_tipoid.Text = "" Or Msk_id.MaskFull = False Then
                MsgBox("Debe seleccionar tipo de identificacion y digitar numero de identificacion para consultar")
                Return
            End If
            Dim vtipoid, videntificacion, valorformateado As String
            vtipoid = ""
            videntificacion = ""
            valorformateado = Msk_id.Text
            Dim valorsinformato As String = valorformateado.Replace("-", "")
            videntificacion = valorsinformato
            vtipoid = ntipoid
            If valorsinformato.Trim <> "" Then
                Dim dt = conexion.valida_id(vtipoid, videntificacion)
                If f = 1 Then
                    MsgBox("Registro no existe en la base de datos, no puede consultar " & Cmb_tipoid.Text & " y número de identificación " & videntificacion & " no se encuentra registrado en la base de datos.")
                    Msk_id.Focus()
                    Return
                Else
                    k = 1
                    Txtnombre.Text = Trim(dt.Rows(0)!nombre)
                    Txtprimer_apellido.Text = Trim(dt.Rows(0)!primer_apellido)
                    Txtsegundo_apellido.Text = Trim(dt.Rows(0)!segundo_apellido)
                    Dtp_fecha_nacimiento.Value = Trim(dt.Rows(0)!fecha_nacimiento)
                    Txtcorreo.Text = Trim(dt.Rows(0)!correo_electronico)
                    Txtdireccion.Text = Trim(dt.Rows(0)!direccion)
                    Txtnombre.Enabled = True
                    Txtprimer_apellido.Enabled = True
                    Txtsegundo_apellido.Enabled = True
                    Dgvpersona.DataSource = Nothing
                    Dgvpersona.Rows.Clear()
                    Me.CIUDADANOTableAdapter.Fill(Me.II36DB03Q2025DataSet2.CIUDADANO)
                    Dgvpersona.DataSource = Me.II36DB03Q2025DataSet2.CIUDADANO

                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Error :" + ex.ToString)
        End Try
    End Sub
    Private Sub Btnmodificar_Click(sender As Object, e As EventArgs) Handles Btnmodificar.Click
        Try
            If k = 0 Then
                MsgBox("Debe presionar el boton consultar antes de modificar")
                Return
            Else
                Dim vtipoid As Integer
                vtipoid = 0
                Dim vnumeroid, vnombre, vapellido1, vapellido2, vfechanacimiento, vcorreo, vdireccion,
                    valorformateado, valorsinformato, vfecha, vusuario, vaccion, vidbitacora, strsql, strsqlbit As String
                vnumeroid = ""
                vnombre = ""
                vapellido1 = ""
                vapellido2 = ""
                vfechanacimiento = ""
                vcorreo = ""
                vdireccion = ""
                valorformateado = ""
                valorsinformato = ""
                vfecha = ""
                vusuario = ""
                vaccion = ""
                vidbitacora = ""
                strsql = ""
                strsqlbit = ""
                If validar_campos() = True Then
                    If MessageBox.Show("¿Desea modificar el registro en la base de datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        valorformateado = Msk_id.Text
                        valorsinformato = valorformateado.Replace("-", "")
                        vnumeroid = valorsinformato
                        vtipoid = ntipoid
                        vnombre = Txtnombre.Text
                        vapellido1 = Txtprimer_apellido.Text
                        vapellido2 = Txtsegundo_apellido.Text
                        vfechanacimiento = Dtp_fecha_nacimiento.Value
                        vcorreo = Txtcorreo.Text
                        vdireccion = Txtdireccion.Text
                        'Crear el sql update
                        strsql = "UPDATE CIUDADANO SET NOMBRE = '" & vnombre & "', PRIMER_APELLIDO = '" & vapellido1 & "', 
                                  SEGUNDO_APELLIDO = '" & vapellido2 & "', FECHA_NACIMIENTO = '" & vfechanacimiento & "', 
                                  CORREO_ELECTRONICO = '" & vcorreo & "', DIRECCION = '" & vdireccion & "'WHERE TIPO_IDENTIFICACION = " & vtipoid.ToString() & "AND NUMERO_IDENTIFICACION = '" & vnumeroid & "'"
                        MsgBox(strsql)
                        conexion.inserta_datos(strsql)
                        If f = 0 Then
                            Dgvpersona.DataSource = Nothing
                            Dgvpersona.Rows.Clear()
                            Me.CIUDADANOTableAdapter.Fill(Me.II36DB03Q2025DataSet2.CIUDADANO)
                            Dgvpersona.DataSource = Me.II36DB03Q2025DataSet2.CIUDADANO
                            MessageBox.Show("Datos modificados satisfactoriamente", "Datos modificados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Else
                            MessageBox.Show("Error al modificar los datos", "Datos no modificados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Else
                    MsgBox("Datos Incompletos, favor completar")
                    Return
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString)
        End Try
    End Sub
    Private Sub Btneliminar_Click(sender As Object, e As EventArgs) Handles Btneliminar.Click
        Try
            If Cmb_tipoid.Text = "" Or Msk_id.MaskFull = False Then
                MsgBox("Debe realizar la consulta primero")
                Return
            End If
            Dim vtipoid, videntificacion, valorformateado As String
            vtipoid = ""
            videntificacion = ""
            valorformateado = Msk_id.Text
            Dim valorsinformato As String = valorformateado.Replace("-", "")
            videntificacion = valorsinformato
            vtipoid = ntipoid
            If valorsinformato.Trim <> "" Then
                Dim dt = conexion.valida_id(vtipoid, videntificacion)
                If f = 1 Then
                    MsgBox("Registro no existe en la base de datos, no puede consultar " & Cmb_tipoid.Text & " y número de identificación " & videntificacion & " no se encuentra registrado en la base de datos.")
                    Msk_id.Focus()
                    Return
                Else
                    k = 1
                    If validar_campos() = True Then
                        If MessageBox.Show("¿Desea eliminar el registro en la base de datos?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                            valorformateado = Msk_id.Text
                            valorsinformato = valorformateado.Replace("-", "")
                            videntificacion = valorsinformato
                            vtipoid = ntipoid
                            'Crear el sql delete
                            Dim strsql, strsqlbit As String
                            strsqlbit = "DELETE FROM BITACORA_CIUDADANO WHERE TIPO_IDENTIFICACION = " & vtipoid.ToString() & " AND NUMERO_IDENTIFICACION = '" & videntificacion & "'"
                            conexion.inserta_datos(strsqlbit)
                            MsgBox(strsqlbit)
                            strsql = "DELETE FROM CIUDADANO WHERE TIPO_IDENTIFICACION = " & vtipoid.ToString() & " AND NUMERO_IDENTIFICACION = '" & videntificacion & "'"
                            MsgBox(strsql)
                            conexion.inserta_datos(strsql)
                            If f = 0 Then
                                Dgvpersona.DataSource = Nothing
                                Dgvpersona.Rows.Clear()
                                Me.CIUDADANOTableAdapter.Fill(Me.II36DB03Q2025DataSet2.CIUDADANO)
                                Dgvpersona.DataSource = Me.II36DB03Q2025DataSet2.CIUDADANO
                                MessageBox.Show("Datos eliminados satisfactoriamente", "Datos eliminados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Else
                                MessageBox.Show("Error al eliminar los datos", "Datos no eliminados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If
                    Else
                        MsgBox("Datos Incompletos, favor completar")
                        Return
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error :" + ex.ToString)
        End Try
    End Sub

    Private Sub Msk_id_LostFocus(sender As Object, e As EventArgs) Handles Msk_id.LostFocus
        If Cmb_tipoid.Text = "" Or Msk_id.MaskFull = False Then
            MsgBox("Debe seleccionar tipo de identificacion y digitar numero de identificacion para consultar")
            Return
        End If
        If ntipoid = 1 Then
            Try
                Dim videntificacion, valorformateado As String
                videntificacion = ""
                valorformateado = Msk_id.Text
                Dim valorsinformato As String = valorformateado.Replace("-", "")
                videntificacion = valorsinformato
                If valorsinformato.Trim <> "" Then
                    Dim dt = conexion.Busca_padron(videntificacion)
                    If f = 1 Then
                        MsgBox("Registro no existe en el padron, no puede consultar " & Cmb_tipoid.Text & " y número de identificación " & videntificacion & " no se encuentra registrado en el padron.")
                        Msk_id.Focus()
                        Return
                    Else
                        Txtnombre.Text = Trim(dt.Rows(0)!nombre)
                        Txtprimer_apellido.Text = Trim(dt.Rows(0)!apellido1)
                        Txtsegundo_apellido.Text = Trim(dt.Rows(0)!apellido2)
                        'Cajas de texto deshabilitadas para que no se modifiquen los datos traidos del padron
                        Txtnombre.Enabled = False
                        Txtprimer_apellido.Enabled = False
                        Txtsegundo_apellido.Enabled = False
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Error :" + ex.ToString)
            End Try
        End If
    End Sub
    Private Sub Limpiar()
        Dgvpersona.DataSource = Nothing
        Dgvpersona.Rows.Clear()
        Me.CIUDADANOTableAdapter.Fill(Me.II36DB03Q2025DataSet2.CIUDADANO)
        Dgvpersona.DataSource = Me.II36DB03Q2025DataSet2.CIUDADANO
        Msk_id.Clear()
        Txtnombre.Clear()
        Txtprimer_apellido.Clear()
        Txtsegundo_apellido.Clear()
        Dtp_fecha_nacimiento.ResetText()
        Txtcorreo.Clear()
        Txtdireccion.Clear()
        Cmb_tipoid.SelectedIndex = -1
        CmbEstadoCivil.SelectedIndex = -1
        TxtNumeroindentCons.Clear()
        TxtNombCons.Clear()
        TxtPriApellCons.Clear()
        TxtSegApellCons.Clear()

    End Sub

    Private Sub CargarEstados()
        Dim dt As DataTable = conexion.ObtenerEstadosCiviles()
        CmbEstadoCivil.DataSource = dt
        CmbEstadoCivil.DisplayMember = "DESCRIPCION"
        CmbEstadoCivil.ValueMember = "DESCRIPCION"
        CmbEstadoCivil.SelectedIndex = -1
    End Sub
    Private Sub BtnConsultas_Click(sender As Object, e As EventArgs) Handles BtnConsultas.Click

        If String.IsNullOrWhiteSpace(TxtNombCons.Text) AndAlso String.IsNullOrWhiteSpace(TxtPriApellCons.Text) Then
            MessageBox.Show("Debe indicar el nombre o primer apellido.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim vNumeroident As String = TxtNumeroindentCons.Text.Trim()
        Dim vNombre As String = TxtNombCons.Text.Trim()
        Dim vPriAp As String = TxtPriApellCons.Text.Trim()
        Dim vSegAp As String = TxtSegApellCons.Text.Trim()

        Dim dt As DataTable = conexion.Filtra_padron(vNumeroident, vNombre, vPriAp, vSegAp)

        If dt.Columns.Contains("IDENTIFICACION") Then
            dt.Columns("IDENTIFICACION").ColumnName = "NUMERO_IDENTIFICACION"
        End If
        If dt.Columns.Contains("APELLIDO1") Then
            dt.Columns("APELLIDO1").ColumnName = "PRIMER_APELLIDO"
        End If
        If dt.Columns.Contains("APELLIDO2") Then
            dt.Columns("APELLIDO2").ColumnName = "SEGUNDO_APELLIDO"
        End If

        Dgvpersona.DataSource = dt

    End Sub

    Private Sub Dgvpersona_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvpersona.CellContentClick
        Dim i As Integer
        i = Dgvpersona.CurrentRow.Index
        Me.Cmb_tipoid.Text = Dgvpersona.Item(0, i).Value()
        Me.Msk_id.Text = Dgvpersona.Item(1, i).Value()
        Me.Txtnombre.Text = Dgvpersona.Item(2, i).Value()
        Me.Txtprimer_apellido.Text = Dgvpersona.Item(3, i).Value()
        Me.Txtsegundo_apellido.Text = Dgvpersona.Item(4, i).Value()
        Me.Dtp_fecha_nacimiento.Text = Dgvpersona.Item(5, i).Value()
        Me.Txtcorreo.Text = Dgvpersona.Item(6, i).Value()
        Me.Txtdireccion.Text = Dgvpersona.Item(7, i).Value()
    End Sub
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
        Btnconsultar.Enabled = True
    End Sub
    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        If MessageBox.Show("¿Desea salir del programa?", "Confirmar salida",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class
