<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Txt_fecha = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Cmb_tipoid = New System.Windows.Forms.ComboBox()
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.Txtprimer_apellido = New System.Windows.Forms.TextBox()
        Me.Msk_id = New System.Windows.Forms.MaskedTextBox()
        Me.Txtcorreo = New System.Windows.Forms.TextBox()
        Me.Dtp_fecha_nacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Txtdireccion = New System.Windows.Forms.TextBox()
        Me.Lbltipoid = New System.Windows.Forms.Label()
        Me.Lblnumeroid = New System.Windows.Forms.Label()
        Me.Lblnombre = New System.Windows.Forms.Label()
        Me.Lblprimer_apellido = New System.Windows.Forms.Label()
        Me.Lblsegundo_apellido = New System.Windows.Forms.Label()
        Me.Lblfecha_nacimiento = New System.Windows.Forms.Label()
        Me.Lblcorreo_electronico = New System.Windows.Forms.Label()
        Me.Lbldireccion = New System.Windows.Forms.Label()
        Me.Grb_captura = New System.Windows.Forms.GroupBox()
        Me.Txtsegundo_apellido = New System.Windows.Forms.TextBox()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.Btnconsultar = New System.Windows.Forms.Button()
        Me.Btnmodificar = New System.Windows.Forms.Button()
        Me.Btneliminar = New System.Windows.Forms.Button()
        Me.Btnsalir = New System.Windows.Forms.Button()
        Me.Grbacciones = New System.Windows.Forms.GroupBox()
        Me.Grb_captura.SuspendLayout()
        Me.Grbacciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt_fecha
        '
        Me.Txt_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_fecha.Location = New System.Drawing.Point(1163, 19)
        Me.Txt_fecha.Name = "Txt_fecha"
        Me.Txt_fecha.ReadOnly = True
        Me.Txt_fecha.Size = New System.Drawing.Size(268, 26)
        Me.Txt_fecha.TabIndex = 30
        Me.Txt_fecha.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Cmb_tipoid
        '
        Me.Cmb_tipoid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_tipoid.FormattingEnabled = True
        Me.Cmb_tipoid.Items.AddRange(New Object() {"CEDULA NACIONAL", "DIMEX", "PASAPORTE"})
        Me.Cmb_tipoid.Location = New System.Drawing.Point(15, 101)
        Me.Cmb_tipoid.Name = "Cmb_tipoid"
        Me.Cmb_tipoid.Size = New System.Drawing.Size(194, 21)
        Me.Cmb_tipoid.TabIndex = 0
        '
        'Txtnombre
        '
        Me.Txtnombre.Location = New System.Drawing.Point(605, 102)
        Me.Txtnombre.MaxLength = 30
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(223, 20)
        Me.Txtnombre.TabIndex = 2
        '
        'Txtprimer_apellido
        '
        Me.Txtprimer_apellido.Location = New System.Drawing.Point(910, 101)
        Me.Txtprimer_apellido.MaxLength = 30
        Me.Txtprimer_apellido.Name = "Txtprimer_apellido"
        Me.Txtprimer_apellido.Size = New System.Drawing.Size(223, 20)
        Me.Txtprimer_apellido.TabIndex = 3
        '
        'Msk_id
        '
        Me.Msk_id.Location = New System.Drawing.Point(292, 102)
        Me.Msk_id.Name = "Msk_id"
        Me.Msk_id.Size = New System.Drawing.Size(219, 20)
        Me.Msk_id.TabIndex = 1
        '
        'Txtcorreo
        '
        Me.Txtcorreo.Location = New System.Drawing.Point(288, 254)
        Me.Txtcorreo.MaxLength = 50
        Me.Txtcorreo.Name = "Txtcorreo"
        Me.Txtcorreo.Size = New System.Drawing.Size(223, 20)
        Me.Txtcorreo.TabIndex = 6
        '
        'Dtp_fecha_nacimiento
        '
        Me.Dtp_fecha_nacimiento.Location = New System.Drawing.Point(15, 251)
        Me.Dtp_fecha_nacimiento.Name = "Dtp_fecha_nacimiento"
        Me.Dtp_fecha_nacimiento.Size = New System.Drawing.Size(200, 20)
        Me.Dtp_fecha_nacimiento.TabIndex = 5
        '
        'Txtdireccion
        '
        Me.Txtdireccion.Location = New System.Drawing.Point(605, 251)
        Me.Txtdireccion.Multiline = True
        Me.Txtdireccion.Name = "Txtdireccion"
        Me.Txtdireccion.Size = New System.Drawing.Size(800, 87)
        Me.Txtdireccion.TabIndex = 7
        '
        'Lbltipoid
        '
        Me.Lbltipoid.AutoSize = True
        Me.Lbltipoid.Location = New System.Drawing.Point(8, 25)
        Me.Lbltipoid.Name = "Lbltipoid"
        Me.Lbltipoid.Size = New System.Drawing.Size(120, 13)
        Me.Lbltipoid.TabIndex = 10
        Me.Lbltipoid.Text = "TIPO IDENTIFICACION"
        '
        'Lblnumeroid
        '
        Me.Lblnumeroid.AutoSize = True
        Me.Lblnumeroid.Location = New System.Drawing.Point(282, 25)
        Me.Lblnumeroid.Name = "Lblnumeroid"
        Me.Lblnumeroid.Size = New System.Drawing.Size(143, 13)
        Me.Lblnumeroid.TabIndex = 11
        Me.Lblnumeroid.Text = "NUMERO IDENTIFICACION"
        '
        'Lblnombre
        '
        Me.Lblnombre.AutoSize = True
        Me.Lblnombre.Location = New System.Drawing.Point(595, 25)
        Me.Lblnombre.Name = "Lblnombre"
        Me.Lblnombre.Size = New System.Drawing.Size(54, 13)
        Me.Lblnombre.TabIndex = 12
        Me.Lblnombre.Text = "NOMBRE"
        '
        'Lblprimer_apellido
        '
        Me.Lblprimer_apellido.AutoSize = True
        Me.Lblprimer_apellido.Location = New System.Drawing.Point(900, 25)
        Me.Lblprimer_apellido.Name = "Lblprimer_apellido"
        Me.Lblprimer_apellido.Size = New System.Drawing.Size(104, 13)
        Me.Lblprimer_apellido.TabIndex = 13
        Me.Lblprimer_apellido.Text = "PRIMER APELLIDO"
        '
        'Lblsegundo_apellido
        '
        Me.Lblsegundo_apellido.AutoSize = True
        Me.Lblsegundo_apellido.Location = New System.Drawing.Point(1172, 25)
        Me.Lblsegundo_apellido.Name = "Lblsegundo_apellido"
        Me.Lblsegundo_apellido.Size = New System.Drawing.Size(116, 13)
        Me.Lblsegundo_apellido.TabIndex = 14
        Me.Lblsegundo_apellido.Text = "SEGUNDO APELLIDO"
        '
        'Lblfecha_nacimiento
        '
        Me.Lblfecha_nacimiento.AutoSize = True
        Me.Lblfecha_nacimiento.Location = New System.Drawing.Point(8, 175)
        Me.Lblfecha_nacimiento.Name = "Lblfecha_nacimiento"
        Me.Lblfecha_nacimiento.Size = New System.Drawing.Size(112, 13)
        Me.Lblfecha_nacimiento.TabIndex = 15
        Me.Lblfecha_nacimiento.Text = "FECHA NACIMIENTO"
        '
        'Lblcorreo_electronico
        '
        Me.Lblcorreo_electronico.AutoSize = True
        Me.Lblcorreo_electronico.Location = New System.Drawing.Point(282, 175)
        Me.Lblcorreo_electronico.Name = "Lblcorreo_electronico"
        Me.Lblcorreo_electronico.Size = New System.Drawing.Size(132, 13)
        Me.Lblcorreo_electronico.TabIndex = 16
        Me.Lblcorreo_electronico.Text = "CORREO ELECTRONICO"
        '
        'Lbldireccion
        '
        Me.Lbldireccion.AutoSize = True
        Me.Lbldireccion.Location = New System.Drawing.Point(595, 175)
        Me.Lbldireccion.Name = "Lbldireccion"
        Me.Lbldireccion.Size = New System.Drawing.Size(66, 13)
        Me.Lbldireccion.TabIndex = 17
        Me.Lbldireccion.Text = "DIRECCION"
        '
        'Grb_captura
        '
        Me.Grb_captura.BackColor = System.Drawing.Color.CadetBlue
        Me.Grb_captura.Controls.Add(Me.Lbldireccion)
        Me.Grb_captura.Controls.Add(Me.Lblcorreo_electronico)
        Me.Grb_captura.Controls.Add(Me.Lblsegundo_apellido)
        Me.Grb_captura.Controls.Add(Me.Lblfecha_nacimiento)
        Me.Grb_captura.Controls.Add(Me.Lblprimer_apellido)
        Me.Grb_captura.Controls.Add(Me.Lbltipoid)
        Me.Grb_captura.Controls.Add(Me.Lblnumeroid)
        Me.Grb_captura.Controls.Add(Me.Lblnombre)
        Me.Grb_captura.Location = New System.Drawing.Point(7, 51)
        Me.Grb_captura.Name = "Grb_captura"
        Me.Grb_captura.Size = New System.Drawing.Size(1423, 332)
        Me.Grb_captura.TabIndex = 100
        Me.Grb_captura.TabStop = False
        Me.Grb_captura.Text = "Datos Estudiante"
        '
        'Txtsegundo_apellido
        '
        Me.Txtsegundo_apellido.Location = New System.Drawing.Point(1182, 101)
        Me.Txtsegundo_apellido.MaxLength = 30
        Me.Txtsegundo_apellido.Name = "Txtsegundo_apellido"
        Me.Txtsegundo_apellido.Size = New System.Drawing.Size(223, 20)
        Me.Txtsegundo_apellido.TabIndex = 4
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Location = New System.Drawing.Point(25, 20)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(102, 42)
        Me.BtnInsertar.TabIndex = 8
        Me.BtnInsertar.Text = "&Insertar"
        Me.BtnInsertar.UseVisualStyleBackColor = True
        '
        'Btnconsultar
        '
        Me.Btnconsultar.Location = New System.Drawing.Point(173, 20)
        Me.Btnconsultar.Name = "Btnconsultar"
        Me.Btnconsultar.Size = New System.Drawing.Size(102, 42)
        Me.Btnconsultar.TabIndex = 9
        Me.Btnconsultar.Text = "&Consultar"
        Me.Btnconsultar.UseVisualStyleBackColor = True
        '
        'Btnmodificar
        '
        Me.Btnmodificar.Location = New System.Drawing.Point(321, 20)
        Me.Btnmodificar.Name = "Btnmodificar"
        Me.Btnmodificar.Size = New System.Drawing.Size(102, 42)
        Me.Btnmodificar.TabIndex = 10
        Me.Btnmodificar.Text = "&Modificar"
        Me.Btnmodificar.UseVisualStyleBackColor = True
        '
        'Btneliminar
        '
        Me.Btneliminar.Location = New System.Drawing.Point(473, 20)
        Me.Btneliminar.Name = "Btneliminar"
        Me.Btneliminar.Size = New System.Drawing.Size(102, 42)
        Me.Btneliminar.TabIndex = 11
        Me.Btneliminar.Text = "&Eliminar"
        Me.Btneliminar.UseVisualStyleBackColor = True
        '
        'Btnsalir
        '
        Me.Btnsalir.Location = New System.Drawing.Point(628, 20)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(102, 42)
        Me.Btnsalir.TabIndex = 12
        Me.Btnsalir.Text = "&Salir"
        Me.Btnsalir.UseVisualStyleBackColor = True
        '
        'Grbacciones
        '
        Me.Grbacciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Grbacciones.Controls.Add(Me.Btnconsultar)
        Me.Grbacciones.Controls.Add(Me.Btnsalir)
        Me.Grbacciones.Controls.Add(Me.BtnInsertar)
        Me.Grbacciones.Controls.Add(Me.Btnmodificar)
        Me.Grbacciones.Controls.Add(Me.Btneliminar)
        Me.Grbacciones.Location = New System.Drawing.Point(342, 400)
        Me.Grbacciones.Name = "Grbacciones"
        Me.Grbacciones.Size = New System.Drawing.Size(747, 79)
        Me.Grbacciones.TabIndex = 24
        Me.Grbacciones.TabStop = False
        Me.Grbacciones.Text = "Acciones"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1439, 518)
        Me.Controls.Add(Me.Txtsegundo_apellido)
        Me.Controls.Add(Me.Txtdireccion)
        Me.Controls.Add(Me.Dtp_fecha_nacimiento)
        Me.Controls.Add(Me.Txtcorreo)
        Me.Controls.Add(Me.Msk_id)
        Me.Controls.Add(Me.Txtprimer_apellido)
        Me.Controls.Add(Me.Txtnombre)
        Me.Controls.Add(Me.Cmb_tipoid)
        Me.Controls.Add(Me.Txt_fecha)
        Me.Controls.Add(Me.Grb_captura)
        Me.Controls.Add(Me.Grbacciones)
        Me.Name = "Form1"
        Me.Text = "Clase#1"
        Me.Grb_captura.ResumeLayout(False)
        Me.Grb_captura.PerformLayout()
        Me.Grbacciones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_fecha As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Cmb_tipoid As ComboBox
    Friend WithEvents Txtnombre As TextBox
    Friend WithEvents Txtprimer_apellido As TextBox
    Friend WithEvents Msk_id As MaskedTextBox
    Friend WithEvents Txtcorreo As TextBox
    Friend WithEvents Dtp_fecha_nacimiento As DateTimePicker
    Friend WithEvents Txtdireccion As TextBox
    Friend WithEvents Lbltipoid As Label
    Friend WithEvents Lblnumeroid As Label
    Friend WithEvents Lblnombre As Label
    Friend WithEvents Lblprimer_apellido As Label
    Friend WithEvents Lblsegundo_apellido As Label
    Friend WithEvents Lblfecha_nacimiento As Label
    Friend WithEvents Lblcorreo_electronico As Label
    Friend WithEvents Lbldireccion As Label
    Friend WithEvents Grb_captura As GroupBox
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents Btnconsultar As Button
    Friend WithEvents Btnmodificar As Button
    Friend WithEvents Btneliminar As Button
    Friend WithEvents Btnsalir As Button
    Friend WithEvents Grbacciones As GroupBox
    Friend WithEvents Txtsegundo_apellido As TextBox
End Class
