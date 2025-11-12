<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4_Consultas
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
        Me.Lblfuncionario = New System.Windows.Forms.Label()
        Me.CboFuncionario = New System.Windows.Forms.ComboBox()
        Me.DtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.DtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.Lbldesde = New System.Windows.Forms.Label()
        Me.Lblhasta = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.DgvResultado = New System.Windows.Forms.DataGridView()
        Me.LblTotalConsumos = New System.Windows.Forms.TextBox()
        Me.LblTotalAdelantos = New System.Windows.Forms.TextBox()
        Me.Lblcosumibles = New System.Windows.Forms.Label()
        Me.Lblvales = New System.Windows.Forms.Label()
        CType(Me.DgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lblfuncionario
        '
        Me.Lblfuncionario.AutoSize = True
        Me.Lblfuncionario.Location = New System.Drawing.Point(38, 39)
        Me.Lblfuncionario.Name = "Lblfuncionario"
        Me.Lblfuncionario.Size = New System.Drawing.Size(66, 13)
        Me.Lblfuncionario.TabIndex = 0
        Me.Lblfuncionario.Text = "EMPLEADO"
        '
        'CboFuncionario
        '
        Me.CboFuncionario.FormattingEnabled = True
        Me.CboFuncionario.Location = New System.Drawing.Point(41, 70)
        Me.CboFuncionario.Name = "CboFuncionario"
        Me.CboFuncionario.Size = New System.Drawing.Size(152, 21)
        Me.CboFuncionario.TabIndex = 1
        '
        'DtpDesde
        '
        Me.DtpDesde.Location = New System.Drawing.Point(255, 70)
        Me.DtpDesde.Name = "DtpDesde"
        Me.DtpDesde.Size = New System.Drawing.Size(200, 20)
        Me.DtpDesde.TabIndex = 2
        '
        'DtpHasta
        '
        Me.DtpHasta.Location = New System.Drawing.Point(516, 70)
        Me.DtpHasta.Name = "DtpHasta"
        Me.DtpHasta.Size = New System.Drawing.Size(200, 20)
        Me.DtpHasta.TabIndex = 3
        '
        'Lbldesde
        '
        Me.Lbldesde.AutoSize = True
        Me.Lbldesde.Location = New System.Drawing.Point(255, 39)
        Me.Lbldesde.Name = "Lbldesde"
        Me.Lbldesde.Size = New System.Drawing.Size(44, 13)
        Me.Lbldesde.TabIndex = 4
        Me.Lbldesde.Text = "DESDE"
        '
        'Lblhasta
        '
        Me.Lblhasta.AutoSize = True
        Me.Lblhasta.Location = New System.Drawing.Point(516, 39)
        Me.Lblhasta.Name = "Lblhasta"
        Me.Lblhasta.Size = New System.Drawing.Size(43, 13)
        Me.Lblhasta.TabIndex = 5
        Me.Lblhasta.Text = "HASTA"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(328, 125)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 6
        Me.BtnBuscar.Text = "BUSCAR"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'DgvResultado
        '
        Me.DgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvResultado.Location = New System.Drawing.Point(255, 167)
        Me.DgvResultado.Name = "DgvResultado"
        Me.DgvResultado.Size = New System.Drawing.Size(240, 150)
        Me.DgvResultado.TabIndex = 7
        '
        'LblTotalConsumos
        '
        Me.LblTotalConsumos.Location = New System.Drawing.Point(77, 376)
        Me.LblTotalConsumos.Name = "LblTotalConsumos"
        Me.LblTotalConsumos.Size = New System.Drawing.Size(100, 20)
        Me.LblTotalConsumos.TabIndex = 8
        '
        'LblTotalAdelantos
        '
        Me.LblTotalAdelantos.Location = New System.Drawing.Point(555, 375)
        Me.LblTotalAdelantos.Name = "LblTotalAdelantos"
        Me.LblTotalAdelantos.Size = New System.Drawing.Size(100, 20)
        Me.LblTotalAdelantos.TabIndex = 9
        '
        'Lblcosumibles
        '
        Me.Lblcosumibles.AutoSize = True
        Me.Lblcosumibles.Location = New System.Drawing.Point(77, 357)
        Me.Lblcosumibles.Name = "Lblcosumibles"
        Me.Lblcosumibles.Size = New System.Drawing.Size(84, 13)
        Me.Lblcosumibles.TabIndex = 10
        Me.Lblcosumibles.Text = "CONSUMIBLES"
        '
        'Lblvales
        '
        Me.Lblvales.AutoSize = True
        Me.Lblvales.Location = New System.Drawing.Point(555, 356)
        Me.Lblvales.Name = "Lblvales"
        Me.Lblvales.Size = New System.Drawing.Size(41, 13)
        Me.Lblvales.TabIndex = 11
        Me.Lblvales.Text = "VALES"
        '
        'Form4_Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lblvales)
        Me.Controls.Add(Me.Lblcosumibles)
        Me.Controls.Add(Me.LblTotalAdelantos)
        Me.Controls.Add(Me.LblTotalConsumos)
        Me.Controls.Add(Me.DgvResultado)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.Lblhasta)
        Me.Controls.Add(Me.Lbldesde)
        Me.Controls.Add(Me.DtpHasta)
        Me.Controls.Add(Me.DtpDesde)
        Me.Controls.Add(Me.CboFuncionario)
        Me.Controls.Add(Me.Lblfuncionario)
        Me.Name = "Form4_Consultas"
        Me.Text = "Form4_Consultas"
        CType(Me.DgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lblfuncionario As Label
    Friend WithEvents CboFuncionario As ComboBox
    Friend WithEvents DtpDesde As DateTimePicker
    Friend WithEvents DtpHasta As DateTimePicker
    Friend WithEvents Lbldesde As Label
    Friend WithEvents Lblhasta As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents DgvResultado As DataGridView
    Friend WithEvents LblTotalConsumos As TextBox
    Friend WithEvents LblTotalAdelantos As TextBox
    Friend WithEvents Lblcosumibles As Label
    Friend WithEvents Lblvales As Label
End Class
