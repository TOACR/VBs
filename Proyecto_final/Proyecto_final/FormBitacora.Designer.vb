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
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.TxtTabla = New System.Windows.Forms.TextBox()
        Me.LblTabla = New System.Windows.Forms.Label()
        Me.CboAccion = New System.Windows.Forms.ComboBox()
        Me.LblAcciones = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.DgvBitacora = New System.Windows.Forms.DataGridView()
        CType(Me.DgvBitacora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtpDesde
        '
        Me.DtpDesde.Location = New System.Drawing.Point(135, 112)
        Me.DtpDesde.Name = "DtpDesde"
        Me.DtpDesde.Size = New System.Drawing.Size(200, 20)
        Me.DtpDesde.TabIndex = 0
        '
        'DtpHasta
        '
        Me.DtpHasta.Location = New System.Drawing.Point(405, 112)
        Me.DtpHasta.Name = "DtpHasta"
        Me.DtpHasta.Size = New System.Drawing.Size(200, 20)
        Me.DtpHasta.TabIndex = 1
        '
        'Lbldesde
        '
        Me.Lbldesde.AutoSize = True
        Me.Lbldesde.Location = New System.Drawing.Point(132, 96)
        Me.Lbldesde.Name = "Lbldesde"
        Me.Lbldesde.Size = New System.Drawing.Size(44, 13)
        Me.Lbldesde.TabIndex = 16
        Me.Lbldesde.Text = "DESDE"
        '
        'LblHasta
        '
        Me.LblHasta.AutoSize = True
        Me.LblHasta.Location = New System.Drawing.Point(402, 96)
        Me.LblHasta.Name = "LblHasta"
        Me.LblHasta.Size = New System.Drawing.Size(43, 13)
        Me.LblHasta.TabIndex = 17
        Me.LblHasta.Text = "HASTA"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(135, 47)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.TxtUsuario.TabIndex = 18
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Location = New System.Drawing.Point(132, 31)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(56, 13)
        Me.LblUsuario.TabIndex = 19
        Me.LblUsuario.Text = "USUARIO"
        '
        'TxtTabla
        '
        Me.TxtTabla.Location = New System.Drawing.Point(314, 47)
        Me.TxtTabla.Name = "TxtTabla"
        Me.TxtTabla.Size = New System.Drawing.Size(100, 20)
        Me.TxtTabla.TabIndex = 20
        '
        'LblTabla
        '
        Me.LblTabla.AutoSize = True
        Me.LblTabla.Location = New System.Drawing.Point(311, 31)
        Me.LblTabla.Name = "LblTabla"
        Me.LblTabla.Size = New System.Drawing.Size(41, 13)
        Me.LblTabla.TabIndex = 21
        Me.LblTabla.Text = "TABLA"
        '
        'CboAccion
        '
        Me.CboAccion.FormattingEnabled = True
        Me.CboAccion.Location = New System.Drawing.Point(486, 47)
        Me.CboAccion.Name = "CboAccion"
        Me.CboAccion.Size = New System.Drawing.Size(121, 21)
        Me.CboAccion.TabIndex = 22
        '
        'LblAcciones
        '
        Me.LblAcciones.AutoSize = True
        Me.LblAcciones.Location = New System.Drawing.Point(483, 31)
        Me.LblAcciones.Name = "LblAcciones"
        Me.LblAcciones.Size = New System.Drawing.Size(61, 13)
        Me.LblAcciones.TabIndex = 23
        Me.LblAcciones.Text = "ACCIONES"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(327, 158)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(118, 34)
        Me.BtnBuscar.TabIndex = 24
        Me.BtnBuscar.Text = "BUSCAR"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(670, 404)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(118, 34)
        Me.BtnCerrar.TabIndex = 25
        Me.BtnCerrar.Text = "CERRAR"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'DgvBitacora
        '
        Me.DgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBitacora.Location = New System.Drawing.Point(74, 211)
        Me.DgvBitacora.Name = "DgvBitacora"
        Me.DgvBitacora.Size = New System.Drawing.Size(648, 149)
        Me.DgvBitacora.TabIndex = 26
        '
        'FormBitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DgvBitacora)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.LblAcciones)
        Me.Controls.Add(Me.CboAccion)
        Me.Controls.Add(Me.LblTabla)
        Me.Controls.Add(Me.TxtTabla)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.LblHasta)
        Me.Controls.Add(Me.Lbldesde)
        Me.Controls.Add(Me.DtpHasta)
        Me.Controls.Add(Me.DtpDesde)
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
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents LblUsuario As Label
    Friend WithEvents TxtTabla As TextBox
    Friend WithEvents LblTabla As Label
    Friend WithEvents CboAccion As ComboBox
    Friend WithEvents LblAcciones As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents DgvBitacora As DataGridView
End Class
