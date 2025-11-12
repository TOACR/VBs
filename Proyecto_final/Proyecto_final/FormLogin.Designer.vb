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
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.BtnEntrar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Lblusuario = New System.Windows.Forms.Label()
        Me.Lblcontraseña = New System.Windows.Forms.Label()
        Me.Lblingreso = New System.Windows.Forms.Label()
        Me.Lblrol = New System.Windows.Forms.Label()
        Me.CmbRol = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(74, 120)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.TxtUsuario.TabIndex = 0
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(74, 212)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(100, 20)
        Me.TxtPassword.TabIndex = 1
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'BtnEntrar
        '
        Me.BtnEntrar.Location = New System.Drawing.Point(235, 301)
        Me.BtnEntrar.Name = "BtnEntrar"
        Me.BtnEntrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEntrar.TabIndex = 2
        Me.BtnEntrar.Text = "ENTRAR"
        Me.BtnEntrar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(444, 301)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.Text = "CANCELAR"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'Lblusuario
        '
        Me.Lblusuario.AutoSize = True
        Me.Lblusuario.Location = New System.Drawing.Point(74, 84)
        Me.Lblusuario.Name = "Lblusuario"
        Me.Lblusuario.Size = New System.Drawing.Size(56, 13)
        Me.Lblusuario.TabIndex = 4
        Me.Lblusuario.Text = "USUARIO"
        '
        'Lblcontraseña
        '
        Me.Lblcontraseña.AutoSize = True
        Me.Lblcontraseña.Location = New System.Drawing.Point(77, 180)
        Me.Lblcontraseña.Name = "Lblcontraseña"
        Me.Lblcontraseña.Size = New System.Drawing.Size(81, 13)
        Me.Lblcontraseña.TabIndex = 5
        Me.Lblcontraseña.Text = "CONTRASEÑA"
        '
        'Lblingreso
        '
        Me.Lblingreso.AutoSize = True
        Me.Lblingreso.Location = New System.Drawing.Point(330, 60)
        Me.Lblingreso.Name = "Lblingreso"
        Me.Lblingreso.Size = New System.Drawing.Size(122, 13)
        Me.Lblingreso.TabIndex = 6
        Me.Lblingreso.Text = "INGRESO AL SISTEMA"
        '
        'Lblrol
        '
        Me.Lblrol.AutoSize = True
        Me.Lblrol.Location = New System.Drawing.Point(274, 84)
        Me.Lblrol.Name = "Lblrol"
        Me.Lblrol.Size = New System.Drawing.Size(29, 13)
        Me.Lblrol.TabIndex = 7
        Me.Lblrol.Text = "ROL"
        '
        'CmbRol
        '
        Me.CmbRol.FormattingEnabled = True
        Me.CmbRol.Items.AddRange(New Object() {"ADMIN", "CONSUMIBLES"})
        Me.CmbRol.Location = New System.Drawing.Point(277, 120)
        Me.CmbRol.Name = "CmbRol"
        Me.CmbRol.Size = New System.Drawing.Size(121, 21)
        Me.CmbRol.TabIndex = 8
        Me.CmbRol.UseWaitCursor = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CmbRol)
        Me.Controls.Add(Me.Lblrol)
        Me.Controls.Add(Me.Lblingreso)
        Me.Controls.Add(Me.Lblcontraseña)
        Me.Controls.Add(Me.Lblusuario)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEntrar)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Name = "FormLogin"
        Me.Text = "FormLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents BtnEntrar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Lblusuario As Label
    Friend WithEvents Lblcontraseña As Label
    Friend WithEvents Lblingreso As Label
    Friend WithEvents Lblrol As Label
    Friend WithEvents CmbRol As ComboBox
End Class
