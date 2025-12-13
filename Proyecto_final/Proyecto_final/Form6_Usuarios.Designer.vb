<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6_Usuarios
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
        Me.TxtUserName = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtConfirmar = New System.Windows.Forms.TextBox()
        Me.CmbRol = New System.Windows.Forms.ComboBox()
        Me.DgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblConfirmar = New System.Windows.Forms.Label()
        Me.LblUsuarioId = New System.Windows.Forms.TextBox()
        Me.LblRol = New System.Windows.Forms.Label()
        Me.LblAgregar = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtUserName
        '
        Me.TxtUserName.Location = New System.Drawing.Point(17, 47)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(100, 20)
        Me.TxtUserName.TabIndex = 0
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(206, 47)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(100, 20)
        Me.TxtPassword.TabIndex = 1
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'TxtConfirmar
        '
        Me.TxtConfirmar.Location = New System.Drawing.Point(396, 46)
        Me.TxtConfirmar.Name = "TxtConfirmar"
        Me.TxtConfirmar.Size = New System.Drawing.Size(112, 20)
        Me.TxtConfirmar.TabIndex = 2
        Me.TxtConfirmar.UseSystemPasswordChar = True
        '
        'CmbRol
        '
        Me.CmbRol.FormattingEnabled = True
        Me.CmbRol.Location = New System.Drawing.Point(584, 46)
        Me.CmbRol.Name = "CmbRol"
        Me.CmbRol.Size = New System.Drawing.Size(121, 21)
        Me.CmbRol.TabIndex = 3
        '
        'DgvUsuarios
        '
        Me.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvUsuarios.Location = New System.Drawing.Point(57, 200)
        Me.DgvUsuarios.Name = "DgvUsuarios"
        Me.DgvUsuarios.Size = New System.Drawing.Size(688, 116)
        Me.DgvUsuarios.TabIndex = 5
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.Turquoise
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(520, 324)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(100, 41)
        Me.BtnNuevo.TabIndex = 6
        Me.BtnNuevo.Text = "LIMPIAR FORMULARIO"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(207, 324)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 41)
        Me.BtnGuardar.TabIndex = 7
        Me.BtnGuardar.Text = "GUARDAR"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.LightCoral
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(364, 324)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(100, 41)
        Me.BtnEliminar.TabIndex = 8
        Me.BtnEliminar.Text = "ELIMINAR"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.Lime
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.Location = New System.Drawing.Point(703, 365)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(85, 34)
        Me.BtnCerrar.TabIndex = 9
        Me.BtnCerrar.Text = "CERRAR"
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Location = New System.Drawing.Point(17, 31)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(56, 13)
        Me.LblUsuario.TabIndex = 10
        Me.LblUsuario.Text = "USUARIO"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(203, 31)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(81, 13)
        Me.LblPassword.TabIndex = 11
        Me.LblPassword.Text = "CONTRASEÑA"
        '
        'LblConfirmar
        '
        Me.LblConfirmar.AutoSize = True
        Me.LblConfirmar.Location = New System.Drawing.Point(393, 30)
        Me.LblConfirmar.Name = "LblConfirmar"
        Me.LblConfirmar.Size = New System.Drawing.Size(71, 13)
        Me.LblConfirmar.TabIndex = 12
        Me.LblConfirmar.Text = "CONFIRMAR"
        '
        'LblUsuarioId
        '
        Me.LblUsuarioId.Location = New System.Drawing.Point(336, 83)
        Me.LblUsuarioId.Name = "LblUsuarioId"
        Me.LblUsuarioId.Size = New System.Drawing.Size(37, 20)
        Me.LblUsuarioId.TabIndex = 13
        Me.LblUsuarioId.Visible = False
        '
        'LblRol
        '
        Me.LblRol.AutoSize = True
        Me.LblRol.Location = New System.Drawing.Point(581, 30)
        Me.LblRol.Name = "LblRol"
        Me.LblRol.Size = New System.Drawing.Size(29, 13)
        Me.LblRol.TabIndex = 14
        Me.LblRol.Text = "ROL"
        '
        'LblAgregar
        '
        Me.LblAgregar.AutoSize = True
        Me.LblAgregar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAgregar.ForeColor = System.Drawing.Color.Black
        Me.LblAgregar.Location = New System.Drawing.Point(134, 32)
        Me.LblAgregar.Name = "LblAgregar"
        Me.LblAgregar.Size = New System.Drawing.Size(537, 37)
        Me.LblAgregar.TabIndex = 23
        Me.LblAgregar.Text = "ADMINISTRACIÓN DE USUARIOS"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.LblRol)
        Me.GroupBox1.Controls.Add(Me.LblUsuarioId)
        Me.GroupBox1.Controls.Add(Me.LblConfirmar)
        Me.GroupBox1.Controls.Add(Me.LblPassword)
        Me.GroupBox1.Controls.Add(Me.LblUsuario)
        Me.GroupBox1.Controls.Add(Me.CmbRol)
        Me.GroupBox1.Controls.Add(Me.TxtConfirmar)
        Me.GroupBox1.Controls.Add(Me.TxtPassword)
        Me.GroupBox1.Controls.Add(Me.TxtUserName)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(724, 115)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del usuario"
        '
        'Form6_Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 411)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblAgregar)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.DgvUsuarios)
        Me.Name = "Form6_Usuarios"
        Me.Text = "Form6_Usuarios"
        CType(Me.DgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtUserName As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtConfirmar As TextBox
    Friend WithEvents CmbRol As ComboBox
    Friend WithEvents DgvUsuarios As DataGridView
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents LblUsuario As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblConfirmar As Label
    Friend WithEvents LblUsuarioId As TextBox
    Friend WithEvents LblRol As Label
    Friend WithEvents LblAgregar As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
