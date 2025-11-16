<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.Lblingreso = New System.Windows.Forms.Label()
        Me.Lblrol = New System.Windows.Forms.Label()
        Me.CmbRol = New System.Windows.Forms.ComboBox()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.BtnEntrar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Lblusuario = New System.Windows.Forms.Label()
        Me.Lblcontraseña = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lblingreso
        '
        Me.Lblingreso.AutoSize = True
        Me.Lblingreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblingreso.ForeColor = System.Drawing.Color.OliveDrab
        Me.Lblingreso.Location = New System.Drawing.Point(49, 27)
        Me.Lblingreso.Name = "Lblingreso"
        Me.Lblingreso.Size = New System.Drawing.Size(255, 25)
        Me.Lblingreso.TabIndex = 6
        Me.Lblingreso.Text = "INGRESO AL SISTEMA"
        '
        'Lblrol
        '
        Me.Lblrol.AutoSize = True
        Me.Lblrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblrol.Location = New System.Drawing.Point(121, 78)
        Me.Lblrol.Name = "Lblrol"
        Me.Lblrol.Size = New System.Drawing.Size(120, 13)
        Me.Lblrol.TabIndex = 7
        Me.Lblrol.Text = "ROL DEL USUARIO"
        '
        'CmbRol
        '
        Me.CmbRol.FormattingEnabled = True
        Me.CmbRol.Items.AddRange(New Object() {"ADMIN", "CONSUMIBLES"})
        Me.CmbRol.Location = New System.Drawing.Point(120, 94)
        Me.CmbRol.Name = "CmbRol"
        Me.CmbRol.Size = New System.Drawing.Size(121, 21)
        Me.CmbRol.TabIndex = 8
        Me.CmbRol.UseWaitCursor = True
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(32, 39)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.TxtUsuario.TabIndex = 0
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(210, 39)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(100, 20)
        Me.TxtPassword.TabIndex = 1
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'BtnEntrar
        '
        Me.BtnEntrar.BackColor = System.Drawing.Color.LawnGreen
        Me.BtnEntrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEntrar.Location = New System.Drawing.Point(44, 94)
        Me.BtnEntrar.Name = "BtnEntrar"
        Me.BtnEntrar.Size = New System.Drawing.Size(88, 37)
        Me.BtnEntrar.TabIndex = 2
        Me.BtnEntrar.Text = "ENTRAR"
        Me.BtnEntrar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.LightCoral
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(210, 94)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(81, 37)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.Text = "CANCELAR"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'Lblusuario
        '
        Me.Lblusuario.AutoSize = True
        Me.Lblusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblusuario.Location = New System.Drawing.Point(29, 23)
        Me.Lblusuario.Name = "Lblusuario"
        Me.Lblusuario.Size = New System.Drawing.Size(67, 13)
        Me.Lblusuario.TabIndex = 4
        Me.Lblusuario.Text = "USUARIO:"
        '
        'Lblcontraseña
        '
        Me.Lblcontraseña.AutoSize = True
        Me.Lblcontraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcontraseña.Location = New System.Drawing.Point(210, 23)
        Me.Lblcontraseña.Name = "Lblcontraseña"
        Me.Lblcontraseña.Size = New System.Drawing.Size(95, 13)
        Me.Lblcontraseña.TabIndex = 5
        Me.Lblcontraseña.Text = "CONTRASEÑA:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Lblcontraseña)
        Me.GroupBox1.Controls.Add(Me.Lblusuario)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnEntrar)
        Me.GroupBox1.Controls.Add(Me.TxtPassword)
        Me.GroupBox1.Controls.Add(Me.TxtUsuario)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 154)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 153)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Credenciales"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 319)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CmbRol)
        Me.Controls.Add(Me.Lblrol)
        Me.Controls.Add(Me.Lblingreso)
        Me.Name = "FormLogin"
        Me.Text = "FormLogin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lblingreso As Label
    Friend WithEvents Lblrol As Label
    Friend WithEvents CmbRol As ComboBox
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents BtnEntrar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Lblusuario As Label
    Friend WithEvents Lblcontraseña As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
