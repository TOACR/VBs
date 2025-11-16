<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2_Admin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.ChkActivo = New System.Windows.Forms.CheckBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnDesactivar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Lblcedula = New System.Windows.Forms.Label()
        Me.Lblnombre = New System.Windows.Forms.Label()
        Me.DgvFuncionarios = New System.Windows.Forms.DataGridView()
        Me.lblFuncionarioId = New System.Windows.Forms.TextBox()
        Me.Lblfuncionario = New System.Windows.Forms.Label()
        Me.Btnregresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmb_tipoid = New System.Windows.Forms.ComboBox()
        Me.Lbltipoidentificacion = New System.Windows.Forms.Label()
        Me.Lblprimer_apellido = New System.Windows.Forms.Label()
        Me.Txtprimer_apellido = New System.Windows.Forms.TextBox()
        Me.Lblsegundo_apellido = New System.Windows.Forms.Label()
        Me.Txtsegundo_apellido = New System.Windows.Forms.TextBox()
        Me.Dtp_fecha_nacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Lblfecha_nacimiento = New System.Windows.Forms.Label()
        Me.Msk_id = New System.Windows.Forms.MaskedTextBox()
        Me.BtnVerInactivos = New System.Windows.Forms.Button()
        Me.BtnActivar = New System.Windows.Forms.Button()
        Me.LblEstadoLista = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnUsuarios = New System.Windows.Forms.Button()
        CType(Me.DgvFuncionarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(357, 87)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(138, 20)
        Me.TxtNombre.TabIndex = 2
        '
        'ChkActivo
        '
        Me.ChkActivo.AutoSize = True
        Me.ChkActivo.Location = New System.Drawing.Point(249, 165)
        Me.ChkActivo.Name = "ChkActivo"
        Me.ChkActivo.Size = New System.Drawing.Size(64, 17)
        Me.ChkActivo.TabIndex = 6
        Me.ChkActivo.Text = "Habilitar"
        Me.ChkActivo.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Location = New System.Drawing.Point(516, 453)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(100, 53)
        Me.BtnLimpiar.TabIndex = 9
        Me.BtnLimpiar.Text = "LIMPIAR FORMULARIO"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(238, 453)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 53)
        Me.BtnGuardar.TabIndex = 7
        Me.BtnGuardar.Text = "GUARDAR FUNCIONARIO"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnDesactivar
        '
        Me.BtnDesactivar.BackColor = System.Drawing.Color.LightSalmon
        Me.BtnDesactivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDesactivar.Location = New System.Drawing.Point(383, 453)
        Me.BtnDesactivar.Name = "BtnDesactivar"
        Me.BtnDesactivar.Size = New System.Drawing.Size(100, 53)
        Me.BtnDesactivar.TabIndex = 8
        Me.BtnDesactivar.Text = "DESACTIVAR FUNCIONARIO"
        Me.BtnDesactivar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Red
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnEliminar.Location = New System.Drawing.Point(10, 461)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(114, 37)
        Me.BtnEliminar.TabIndex = 10
        Me.BtnEliminar.Text = "ELIMINAR FUNCIONARIO"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'Lblcedula
        '
        Me.Lblcedula.AutoSize = True
        Me.Lblcedula.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Lblcedula.Location = New System.Drawing.Point(177, 70)
        Me.Lblcedula.Name = "Lblcedula"
        Me.Lblcedula.Size = New System.Drawing.Size(161, 13)
        Me.Lblcedula.TabIndex = 21
        Me.Lblcedula.Text = "NUMERO DE IDENTIFICACION"
        '
        'Lblnombre
        '
        Me.Lblnombre.AutoSize = True
        Me.Lblnombre.Location = New System.Drawing.Point(344, 21)
        Me.Lblnombre.Name = "Lblnombre"
        Me.Lblnombre.Size = New System.Drawing.Size(54, 13)
        Me.Lblnombre.TabIndex = 22
        Me.Lblnombre.Text = "NOMBRE"
        '
        'DgvFuncionarios
        '
        Me.DgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFuncionarios.Location = New System.Drawing.Point(15, 279)
        Me.DgvFuncionarios.Name = "DgvFuncionarios"
        Me.DgvFuncionarios.Size = New System.Drawing.Size(845, 168)
        Me.DgvFuncionarios.TabIndex = 30
        Me.DgvFuncionarios.TabStop = False
        '
        'lblFuncionarioId
        '
        Me.lblFuncionarioId.Location = New System.Drawing.Point(356, 163)
        Me.lblFuncionarioId.Name = "lblFuncionarioId"
        Me.lblFuncionarioId.ReadOnly = True
        Me.lblFuncionarioId.Size = New System.Drawing.Size(48, 20)
        Me.lblFuncionarioId.TabIndex = 10
        Me.lblFuncionarioId.TabStop = False
        '
        'Lblfuncionario
        '
        Me.Lblfuncionario.AutoSize = True
        Me.Lblfuncionario.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Lblfuncionario.Location = New System.Drawing.Point(353, 144)
        Me.Lblfuncionario.Name = "Lblfuncionario"
        Me.Lblfuncionario.Size = New System.Drawing.Size(90, 13)
        Me.Lblfuncionario.TabIndex = 26
        Me.Lblfuncionario.Text = "IDENTIFICADOR"
        '
        'Btnregresar
        '
        Me.Btnregresar.BackColor = System.Drawing.Color.Lime
        Me.Btnregresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnregresar.Location = New System.Drawing.Point(773, 497)
        Me.Btnregresar.Name = "Btnregresar"
        Me.Btnregresar.Size = New System.Drawing.Size(87, 36)
        Me.Btnregresar.TabIndex = 11
        Me.Btnregresar.Text = "REGRESAR"
        Me.Btnregresar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(173, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(512, 37)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "REGISTRO DE FUNCIONARIOS"
        '
        'Cmb_tipoid
        '
        Me.Cmb_tipoid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_tipoid.FormattingEnabled = True
        Me.Cmb_tipoid.Items.AddRange(New Object() {"CEDULA NACIONAL", "DIMEX", "PASAPORTE"})
        Me.Cmb_tipoid.Location = New System.Drawing.Point(15, 87)
        Me.Cmb_tipoid.Name = "Cmb_tipoid"
        Me.Cmb_tipoid.Size = New System.Drawing.Size(138, 21)
        Me.Cmb_tipoid.TabIndex = 0
        '
        'Lbltipoidentificacion
        '
        Me.Lbltipoidentificacion.AutoSize = True
        Me.Lbltipoidentificacion.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Lbltipoidentificacion.Location = New System.Drawing.Point(15, 70)
        Me.Lbltipoidentificacion.Name = "Lbltipoidentificacion"
        Me.Lbltipoidentificacion.Size = New System.Drawing.Size(138, 13)
        Me.Lbltipoidentificacion.TabIndex = 20
        Me.Lbltipoidentificacion.Text = "TIPO DE IDENTIFICACION"
        '
        'Lblprimer_apellido
        '
        Me.Lblprimer_apellido.AutoSize = True
        Me.Lblprimer_apellido.Location = New System.Drawing.Point(503, 21)
        Me.Lblprimer_apellido.Name = "Lblprimer_apellido"
        Me.Lblprimer_apellido.Size = New System.Drawing.Size(104, 13)
        Me.Lblprimer_apellido.TabIndex = 23
        Me.Lblprimer_apellido.Text = "PRIMER APELLIDO"
        '
        'Txtprimer_apellido
        '
        Me.Txtprimer_apellido.Location = New System.Drawing.Point(505, 38)
        Me.Txtprimer_apellido.MaxLength = 30
        Me.Txtprimer_apellido.Name = "Txtprimer_apellido"
        Me.Txtprimer_apellido.Size = New System.Drawing.Size(167, 20)
        Me.Txtprimer_apellido.TabIndex = 3
        '
        'Lblsegundo_apellido
        '
        Me.Lblsegundo_apellido.AutoSize = True
        Me.Lblsegundo_apellido.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Lblsegundo_apellido.Location = New System.Drawing.Point(699, 70)
        Me.Lblsegundo_apellido.Name = "Lblsegundo_apellido"
        Me.Lblsegundo_apellido.Size = New System.Drawing.Size(116, 13)
        Me.Lblsegundo_apellido.TabIndex = 24
        Me.Lblsegundo_apellido.Text = "SEGUNDO APELLIDO"
        '
        'Txtsegundo_apellido
        '
        Me.Txtsegundo_apellido.Location = New System.Drawing.Point(686, 38)
        Me.Txtsegundo_apellido.MaxLength = 30
        Me.Txtsegundo_apellido.Name = "Txtsegundo_apellido"
        Me.Txtsegundo_apellido.Size = New System.Drawing.Size(158, 20)
        Me.Txtsegundo_apellido.TabIndex = 4
        '
        'Dtp_fecha_nacimiento
        '
        Me.Dtp_fecha_nacimiento.Location = New System.Drawing.Point(8, 106)
        Me.Dtp_fecha_nacimiento.Name = "Dtp_fecha_nacimiento"
        Me.Dtp_fecha_nacimiento.Size = New System.Drawing.Size(200, 20)
        Me.Dtp_fecha_nacimiento.TabIndex = 5
        '
        'Lblfecha_nacimiento
        '
        Me.Lblfecha_nacimiento.AutoSize = True
        Me.Lblfecha_nacimiento.Location = New System.Drawing.Point(6, 88)
        Me.Lblfecha_nacimiento.Name = "Lblfecha_nacimiento"
        Me.Lblfecha_nacimiento.Size = New System.Drawing.Size(112, 13)
        Me.Lblfecha_nacimiento.TabIndex = 25
        Me.Lblfecha_nacimiento.Text = "FECHA NACIMIENTO"
        '
        'Msk_id
        '
        Me.Msk_id.Location = New System.Drawing.Point(180, 87)
        Me.Msk_id.Name = "Msk_id"
        Me.Msk_id.Size = New System.Drawing.Size(158, 20)
        Me.Msk_id.TabIndex = 1
        '
        'BtnVerInactivos
        '
        Me.BtnVerInactivos.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnVerInactivos.Location = New System.Drawing.Point(740, 208)
        Me.BtnVerInactivos.Name = "BtnVerInactivos"
        Me.BtnVerInactivos.Size = New System.Drawing.Size(120, 29)
        Me.BtnVerInactivos.TabIndex = 64
        Me.BtnVerInactivos.Text = "VER INACTIVOS"
        Me.BtnVerInactivos.UseVisualStyleBackColor = False
        '
        'BtnActivar
        '
        Me.BtnActivar.BackColor = System.Drawing.Color.Transparent
        Me.BtnActivar.Location = New System.Drawing.Point(740, 243)
        Me.BtnActivar.Name = "BtnActivar"
        Me.BtnActivar.Size = New System.Drawing.Size(120, 30)
        Me.BtnActivar.TabIndex = 65
        Me.BtnActivar.Text = "ACTIVAR"
        Me.BtnActivar.UseVisualStyleBackColor = False
        '
        'LblEstadoLista
        '
        Me.LblEstadoLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstadoLista.Location = New System.Drawing.Point(289, 243)
        Me.LblEstadoLista.Name = "LblEstadoLista"
        Me.LblEstadoLista.Size = New System.Drawing.Size(315, 22)
        Me.LblEstadoLista.TabIndex = 66
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.Dtp_fecha_nacimiento)
        Me.GroupBox1.Controls.Add(Me.Lblfecha_nacimiento)
        Me.GroupBox1.Controls.Add(Me.Txtsegundo_apellido)
        Me.GroupBox1.Controls.Add(Me.Txtprimer_apellido)
        Me.GroupBox1.Controls.Add(Me.Lblprimer_apellido)
        Me.GroupBox1.Controls.Add(Me.Lblnombre)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(850, 153)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del funcionario"
        '
        'BtnUsuarios
        '
        Me.BtnUsuarios.BackColor = System.Drawing.Color.Plum
        Me.BtnUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnUsuarios.Location = New System.Drawing.Point(10, 504)
        Me.BtnUsuarios.Name = "BtnUsuarios"
        Me.BtnUsuarios.Size = New System.Drawing.Size(114, 36)
        Me.BtnUsuarios.TabIndex = 68
        Me.BtnUsuarios.Text = "CREAR USUARIOS"
        Me.BtnUsuarios.UseVisualStyleBackColor = False
        '
        'Form2_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 545)
        Me.Controls.Add(Me.BtnUsuarios)
        Me.Controls.Add(Me.LblEstadoLista)
        Me.Controls.Add(Me.BtnActivar)
        Me.Controls.Add(Me.BtnVerInactivos)
        Me.Controls.Add(Me.Msk_id)
        Me.Controls.Add(Me.Lblsegundo_apellido)
        Me.Controls.Add(Me.Lbltipoidentificacion)
        Me.Controls.Add(Me.Cmb_tipoid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btnregresar)
        Me.Controls.Add(Me.Lblfuncionario)
        Me.Controls.Add(Me.lblFuncionarioId)
        Me.Controls.Add(Me.DgvFuncionarios)
        Me.Controls.Add(Me.Lblcedula)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnDesactivar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.ChkActivo)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2_Admin"
        Me.Text = "10"
        CType(Me.DgvFuncionarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents ChkActivo As CheckBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnDesactivar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Lblcedula As Label
    Friend WithEvents Lblnombre As Label
    Friend WithEvents DgvFuncionarios As DataGridView
    Friend WithEvents lblFuncionarioId As TextBox
    Friend WithEvents Lblfuncionario As Label
    Friend WithEvents Btnregresar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Cmb_tipoid As ComboBox
    Friend WithEvents Lbltipoidentificacion As Label
    Friend WithEvents Lblprimer_apellido As Label
    Friend WithEvents Txtprimer_apellido As TextBox
    Friend WithEvents Lblsegundo_apellido As Label
    Friend WithEvents Txtsegundo_apellido As TextBox
    Friend WithEvents Dtp_fecha_nacimiento As DateTimePicker
    Friend WithEvents Lblfecha_nacimiento As Label
    Friend WithEvents Msk_id As MaskedTextBox
    Friend WithEvents BtnVerInactivos As Button
    Friend WithEvents BtnActivar As Button
    Friend WithEvents LblEstadoLista As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnUsuarios As Button
End Class
