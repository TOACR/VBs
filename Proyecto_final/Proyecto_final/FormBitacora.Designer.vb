<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBitacora
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
        Me.DtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.DtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.Lbldesde = New System.Windows.Forms.Label()
        Me.LblHasta = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.CboAccion = New System.Windows.Forms.ComboBox()
        Me.LblAcciones = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.DgvBitacora = New System.Windows.Forms.DataGridView()
        Me.CboUsuario = New System.Windows.Forms.ComboBox()
        Me.LblGestionConsumibles = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DgvBitacora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtpDesde
        '
        Me.DtpDesde.Location = New System.Drawing.Point(264, 160)
        Me.DtpDesde.Name = "DtpDesde"
        Me.DtpDesde.Size = New System.Drawing.Size(200, 20)
        Me.DtpDesde.TabIndex = 2
        '
        'DtpHasta
        '
        Me.DtpHasta.Location = New System.Drawing.Point(582, 160)
        Me.DtpHasta.Name = "DtpHasta"
        Me.DtpHasta.Size = New System.Drawing.Size(200, 20)
        Me.DtpHasta.TabIndex = 3
        '
        'Lbldesde
        '
        Me.Lbldesde.AutoSize = True
        Me.Lbldesde.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Lbldesde.Location = New System.Drawing.Point(261, 144)
        Me.Lbldesde.Name = "Lbldesde"
        Me.Lbldesde.Size = New System.Drawing.Size(44, 13)
        Me.Lbldesde.TabIndex = 16
        Me.Lbldesde.Text = "DESDE"
        '
        'LblHasta
        '
        Me.LblHasta.AutoSize = True
        Me.LblHasta.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LblHasta.Location = New System.Drawing.Point(579, 144)
        Me.LblHasta.Name = "LblHasta"
        Me.LblHasta.Size = New System.Drawing.Size(43, 13)
        Me.LblHasta.TabIndex = 17
        Me.LblHasta.Text = "HASTA"
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LblUsuario.Location = New System.Drawing.Point(340, 92)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(56, 13)
        Me.LblUsuario.TabIndex = 19
        Me.LblUsuario.Text = "USUARIO"
        '
        'CboAccion
        '
        Me.CboAccion.FormattingEnabled = True
        Me.CboAccion.Location = New System.Drawing.Point(582, 108)
        Me.CboAccion.Name = "CboAccion"
        Me.CboAccion.Size = New System.Drawing.Size(121, 21)
        Me.CboAccion.TabIndex = 1
        '
        'LblAcciones
        '
        Me.LblAcciones.AutoSize = True
        Me.LblAcciones.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LblAcciones.Location = New System.Drawing.Point(579, 92)
        Me.LblAcciones.Name = "LblAcciones"
        Me.LblAcciones.Size = New System.Drawing.Size(61, 13)
        Me.LblAcciones.TabIndex = 23
        Me.LblAcciones.Text = "ACCIONES"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(462, 197)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(118, 34)
        Me.BtnBuscar.TabIndex = 4
        Me.BtnBuscar.Text = "BUSCAR"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.LightCoral
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.Location = New System.Drawing.Point(910, 404)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(118, 34)
        Me.BtnCerrar.TabIndex = 5
        Me.BtnCerrar.Text = "CERRAR"
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'DgvBitacora
        '
        Me.DgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBitacora.Location = New System.Drawing.Point(25, 237)
        Me.DgvBitacora.Name = "DgvBitacora"
        Me.DgvBitacora.Size = New System.Drawing.Size(1003, 161)
        Me.DgvBitacora.TabIndex = 26
        '
        'CboUsuario
        '
        Me.CboUsuario.FormattingEnabled = True
        Me.CboUsuario.Location = New System.Drawing.Point(343, 108)
        Me.CboUsuario.Name = "CboUsuario"
        Me.CboUsuario.Size = New System.Drawing.Size(121, 21)
        Me.CboUsuario.TabIndex = 0
        '
        'LblGestionConsumibles
        '
        Me.LblGestionConsumibles.AutoSize = True
        Me.LblGestionConsumibles.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGestionConsumibles.ForeColor = System.Drawing.Color.Black
        Me.LblGestionConsumibles.Location = New System.Drawing.Point(307, 23)
        Me.LblGestionConsumibles.Name = "LblGestionConsumibles"
        Me.LblGestionConsumibles.Size = New System.Drawing.Size(429, 37)
        Me.LblGestionConsumibles.TabIndex = 28
        Me.LblGestionConsumibles.Text = "CONSULTA DE BITÁCORA"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(243, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 118)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        '
        'FormBitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 450)
        Me.Controls.Add(Me.LblGestionConsumibles)
        Me.Controls.Add(Me.CboUsuario)
        Me.Controls.Add(Me.DgvBitacora)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.LblAcciones)
        Me.Controls.Add(Me.CboAccion)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.LblHasta)
        Me.Controls.Add(Me.Lbldesde)
        Me.Controls.Add(Me.DtpHasta)
        Me.Controls.Add(Me.DtpDesde)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormBitacora"
        Me.Text = "FormBitacora"
        CType(Me.DgvBitacora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DtpDesde As DateTimePicker
    Friend WithEvents DtpHasta As DateTimePicker
    Friend WithEvents Lbldesde As Label
    Friend WithEvents LblHasta As Label
    Friend WithEvents LblUsuario As Label
    Friend WithEvents CboAccion As ComboBox
    Friend WithEvents LblAcciones As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents DgvBitacora As DataGridView
    Friend WithEvents CboUsuario As ComboBox
    Friend WithEvents LblGestionConsumibles As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
