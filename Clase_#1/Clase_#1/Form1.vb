Imports System.Data.SqlClient

Public Class Form1
    Dim conexion As Conexion = New Conexion()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Bienvenidos al curso de Progra II")

        '1-1056-0601 Nacional
        '123456789123 Dimex
        '9MXA1545KYUI56 Alfa 24

        conexion.conectar()
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
            Msk_id.Mask = "999999999999"
            SendKeys.Send("{tab}")
        ElseIf Cmb_tipoid.Text = "PASAPORTE" Then
            ntipoid = 3
            Msk_id.Mask = "AAAAAAAAAAAAAAAAAAAAAAAA"
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        f = 0
        Dim vtipoid As Integer
        vtipoid = 0
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
                        strsql = "INSERT CIUDADANO (TIPO_IDENTIFICACION, NUMERO_IDENTIFICACION, NOMBRE, PRIMER_APELLIDO, SEGUNDO_APELLIDO, FECHA_NACIMIENTO, CORREO_ELECTRONICO, DIRECCION)"
                        strsql += vbCrLf + "VALUES ('" & vtipoid & "','" & vnumeroid & "','" & vnombre & "','" & vapellido1 & "','" & vapellido2 & "','" & vfechanacimiento & "','" & vcorreo & "','" & vdireccion & "')"
                        strsqlbit = "INSERT BITACORA_CIUDADANO (ID_BITACORA, TIPO_IDENTIFICACION, NUMERO_IDENTIFICACION, FECHA_HORA, USUARIO, ACCION)"
                        strsqlbit += vbCrLf + "VALUES ('" & vidbitacora & "','" & vtipoid & "','" & vnumeroid & "','" & vfecha & "','" & vusuario & "','" & vaccion & "')"
                        MsgBox(strsql)
                        conexion.inserta_datos(strsql)
                        conexion.inserta_datos(strsqlbit)
                        If f = 0 Then
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

    Private Sub Btneliminar_Click(sender As Object, e As EventArgs) Handles Btneliminar.Click
        If MessageBox.Show("¿Eliminar TODO en CIUDADANO y BITACORA_CIUDADANO y reiniciar consecutivos?",
                       "Confirmar eliminación masiva", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then
            Exit Sub
        End If

        Dim cs As String = "Data Source=DESKTOP-HPG8TC6\SQLEXPRESS;Initial Catalog=II36DB03Q2025;Trusted_connection=Yes"

        Using cn As New SqlConnection(cs)
            cn.Open()
            Using tx = cn.BeginTransaction()
                Try
                    ' 1) Borrar primero BITACORA (hija) y luego CIUDADANO (padre)
                    Using cmd1 As New SqlCommand("DELETE FROM dbo.BITACORA_CIUDADANO;", cn, tx)
                        cmd1.ExecuteNonQuery()
                    End Using

                    Using cmd2 As New SqlCommand("DELETE FROM dbo.CIUDADANO;", cn, tx)
                        cmd2.ExecuteNonQuery()
                    End Using

                    ' 2) RESEED condicional SOLO si la tabla tiene IDENTITY
                    Dim sqlReseed As String =
                    "IF EXISTS (SELECT 1 FROM sys.identity_columns WHERE object_id = OBJECT_ID('dbo.CIUDADANO'))
                    BEGIN
                        DBCC CHECKIDENT ('dbo.CIUDADANO', RESEED, 0);
                    END;

                    IF EXISTS (SELECT 1 FROM sys.identity_columns WHERE object_id = OBJECT_ID('dbo.BITACORA_CIUDADANO'))
                    BEGIN
                        DBCC CHECKIDENT ('dbo.BITACORA_CIUDADANO', RESEED, 0);
                    END;

                    IF OBJECT_ID('dbo.seq_bitacora', 'SO') IS NOT NULL
                    BEGIN
                        ALTER SEQUENCE dbo.seq_bitacora RESTART WITH 1;
                    END;"

                    Using cmdReseed As New SqlCommand(sqlReseed, cn, tx)
                        cmdReseed.CommandType = CommandType.Text
                        cmdReseed.ExecuteNonQuery()
                    End Using

                    tx.Commit()
                    MessageBox.Show("Registros eliminados. Consecutivos reiniciados según corresponda.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    tx.Rollback()
                    MessageBox.Show("Error al eliminar/reiniciar: " & ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        If MessageBox.Show("¿Desea salir del programa?", "Confirmar salida",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()   ' Cierra toda la aplicación
        End If
    End Sub
End Class
