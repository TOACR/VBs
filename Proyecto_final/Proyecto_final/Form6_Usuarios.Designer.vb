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
        CType(Me.DgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtUserName
        '
        Me.TxtUserName.Location = New System.Drawing.Point(57, 57)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(100, 20)
        Me.TxtUserName.TabIndex = 0
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(233, 57)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(100, 20)
        Me.TxtPassword.TabIndex = 1
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'TxtConfirmar
        '
        Me.TxtConfirmar.Location = New System.Drawing.Point(392, 57)
        Me.TxtConfirmar.Name = "TxtConfirmar"
        Me.TxtConfirmar.Size = New System.Drawing.Size(112, 20)
        Me.TxtConfirmar.TabIndex = 2
        Me.TxtConfirmar.UseSystemPasswordChar = True
        '
        'CmbRol
        '
        Me.CmbRol.FormattingEnabled = True
        Me.CmbRol.Location = New System.Drawing.Point(57, 122)
        Me.CmbRol.Name = "CmbRol"
        Me.CmbRol.Size = New System.Drawing.Size(121, 21)
        Me.CmbRol.TabIndex = 3
        '
        'DgvUsuarios
        '
        Me.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvUsuarios.Location = New System.Drawing.Point(57, 180)
        Me.DgvUsuarios.Name = "DgvUsuarios"
        Me.DgvUsuarios.Size = New System.Drawing.Size(688, 106)
        Me.DgvUsuarios.TabIndex = 5
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(57, 341)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(100, 41)
        Me.BtnNuevo.TabIndex = 6
        Me.BtnNuevo.Text = "LIMPIAR FORMULARIO"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(240, 341)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(93, 41)
        Me.BtnGuardar.TabIndex = 7
        Me.BtnGuardar.Text = "GUARDAR"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(408, 343)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(96, 37)
        Me.BtnEliminar.TabIndex = 8
        Me.BtnEliminar.Text = "ELIMINAR"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(584, 343)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(105, 38)
        Me.BtnCerrar.TabIndex = 9
        Me.BtnCerrar.Text = "CERRAR"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Location = New System.Drawing.Point(57, 38)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(56, 13)
        Me.LblUsuario.TabIndex = 10
        Me.LblUsuario.Text = "USUARIO"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(233, 37)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(81, 13)
        Me.LblPassword.TabIndex = 11
        Me.LblPassword.Text = "CONTRASEÑA"
        '
        'LblConfirmar
        '
        Me.LblConfirmar.AutoSize = True
        Me.LblConfirmar.Location = New System.Drawing.Point(392, 38)
        Me.LblConfirmar.Name = "LblConfirmar"
        Me.LblConfirmar.Size = New System.Drawing.Size(71, 13)
        Me.LblConfirmar.TabIndex = 12
        Me.LblConfirmar.Text = "CONFIRMAR"
        '
        'LblUsuarioId
        '
        Me.LblUsuarioId.Location = New System.Drawing.Point(552, 57)
        Me.LblUsuarioId.Name = "LblUsuarioId"
        Me.LblUsuarioId.Size = New System.Drawing.Size(37, 20)
        Me.LblUsuarioId.TabIndex = 13
        Me.LblUsuarioId.Visible = False
        '
        'LblRol
        '
        Me.LblRol.AutoSize = True
        Me.LblRol.Location = New System.Drawing.Point(57, 106)
        Me.LblRol.Name = "LblRol"
        Me.LblRol.Size = New System.Drawing.Size(29, 13)
        Me.LblRol.TabIndex = 14
        Me.LblRol.Text = "ROL"
        '
        'Form6_Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblRol)
        Me.Controls.Add(Me.LblUsuarioId)
        Me.Controls.Add(Me.LblConfirmar)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.DgvUsuarios)
        Me.Controls.Add(Me.CmbRol)
        Me.Controls.Add(Me.TxtConfirmar)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUserName)
        Me.Name = "Form6_Usuarios"
        Me.Text = "Form6_Usuarios"
        CType(Me.DgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
