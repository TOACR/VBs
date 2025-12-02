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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnRegistro = New System.Windows.Forms.Button()
        Me.BtnConsumibles = New System.Windows.Forms.Button()
        Me.BtnConsultas = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Txt_fecha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lable2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BtnRegistro
        '
        Me.BtnRegistro.BackColor = System.Drawing.Color.SkyBlue
        Me.BtnRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistro.Location = New System.Drawing.Point(128, 42)
        Me.BtnRegistro.Name = "BtnRegistro"
        Me.BtnRegistro.Size = New System.Drawing.Size(120, 57)
        Me.BtnRegistro.TabIndex = 1
        Me.BtnRegistro.Text = "ADMINISTRAR"
        Me.BtnRegistro.UseVisualStyleBackColor = False
        '
        'BtnConsumibles
        '
        Me.BtnConsumibles.BackColor = System.Drawing.Color.Bisque
        Me.BtnConsumibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsumibles.Location = New System.Drawing.Point(331, 42)
        Me.BtnConsumibles.Name = "BtnConsumibles"
        Me.BtnConsumibles.Size = New System.Drawing.Size(109, 57)
        Me.BtnConsumibles.TabIndex = 2
        Me.BtnConsumibles.Text = "CARGAR CONSUMIBLES"
        Me.BtnConsumibles.UseVisualStyleBackColor = False
        '
        'BtnConsultas
        '
        Me.BtnConsultas.BackColor = System.Drawing.Color.Violet
        Me.BtnConsultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultas.Location = New System.Drawing.Point(524, 39)
        Me.BtnConsultas.Name = "BtnConsultas"
        Me.BtnConsultas.Size = New System.Drawing.Size(100, 60)
        Me.BtnConsultas.TabIndex = 3
        Me.BtnConsultas.Text = "CONSULTAS"
        Me.BtnConsultas.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Lime
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(667, 84)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(85, 39)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.Text = "SALIR"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Txt_fecha
        '
        Me.Txt_fecha.Location = New System.Drawing.Point(546, 12)
        Me.Txt_fecha.Name = "Txt_fecha"
        Me.Txt_fecha.ReadOnly = True
        Me.Txt_fecha.Size = New System.Drawing.Size(224, 20)
        Me.Txt_fecha.TabIndex = 7
        Me.Txt_fecha.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 27.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(246, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 43)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "LUBRI DELUXE"
        '
        'Lable2
        '
        Me.Lable2.AutoSize = True
        Me.Lable2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 26.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lable2.ForeColor = System.Drawing.Color.LightCoral
        Me.Lable2.Location = New System.Drawing.Point(193, 109)
        Me.Lable2.Name = "Lable2"
        Me.Lable2.Size = New System.Drawing.Size(404, 40)
        Me.Lable2.TabIndex = 9
        Me.Lable2.Text = "FULL WASH SPA O Y S"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(249, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(329, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "CONTROL DE CONSUMIBLES"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.BtnRegistro)
        Me.GroupBox1.Controls.Add(Me.BtnConsumibles)
        Me.GroupBox1.Controls.Add(Me.BtnConsultas)
        Me.GroupBox1.Controls.Add(Me.BtnSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 201)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(758, 136)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(628, 49)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(142, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 354)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Lable2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_fecha)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnRegistro As Button
    Friend WithEvents BtnConsumibles As Button
    Friend WithEvents BtnConsultas As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Txt_fecha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Lable2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
