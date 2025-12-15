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
        Me.LblTotalConsumibles = New System.Windows.Forms.TextBox()
        Me.LblTotalAdelantos = New System.Windows.Forms.TextBox()
        Me.Lblcosumibles = New System.Windows.Forms.Label()
        Me.Lblvales = New System.Windows.Forms.Label()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.LblTotalConsumos = New System.Windows.Forms.TextBox()
        Me.Lbltotal_consumos = New System.Windows.Forms.Label()
        Me.LblAgregar = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnAplicarRango = New System.Windows.Forms.Button()
        Me.CboRangoRapido = New System.Windows.Forms.ComboBox()
        Me.BtnUltimoMes = New System.Windows.Forms.Button()
        Me.BtnMostrarMovs = New System.Windows.Forms.Button()
        CType(Me.DgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lblfuncionario
        '
        Me.Lblfuncionario.AutoSize = True
        Me.Lblfuncionario.Location = New System.Drawing.Point(10, 13)
        Me.Lblfuncionario.Name = "Lblfuncionario"
        Me.Lblfuncionario.Size = New System.Drawing.Size(81, 13)
        Me.Lblfuncionario.TabIndex = 0
        Me.Lblfuncionario.Text = "FUNCIONARIO"
        '
        'CboFuncionario
        '
        Me.CboFuncionario.FormattingEnabled = True
        Me.CboFuncionario.Location = New System.Drawing.Point(13, 29)
        Me.CboFuncionario.Name = "CboFuncionario"
        Me.CboFuncionario.Size = New System.Drawing.Size(152, 21)
        Me.CboFuncionario.TabIndex = 1
        '
        'DtpDesde
        '
        Me.DtpDesde.Location = New System.Drawing.Point(256, 30)
        Me.DtpDesde.Name = "DtpDesde"
        Me.DtpDesde.Size = New System.Drawing.Size(200, 20)
        Me.DtpDesde.TabIndex = 2
        '
        'DtpHasta
        '
        Me.DtpHasta.Location = New System.Drawing.Point(523, 30)
        Me.DtpHasta.Name = "DtpHasta"
        Me.DtpHasta.Size = New System.Drawing.Size(200, 20)
        Me.DtpHasta.TabIndex = 3
        '
        'Lbldesde
        '
        Me.Lbldesde.AutoSize = True
        Me.Lbldesde.Location = New System.Drawing.Point(253, 13)
        Me.Lbldesde.Name = "Lbldesde"
        Me.Lbldesde.Size = New System.Drawing.Size(44, 13)
        Me.Lbldesde.TabIndex = 4
        Me.Lbldesde.Text = "DESDE"
        '
        'Lblhasta
        '
        Me.Lblhasta.AutoSize = True
        Me.Lblhasta.Location = New System.Drawing.Point(520, 13)
        Me.Lblhasta.Name = "Lblhasta"
        Me.Lblhasta.Size = New System.Drawing.Size(43, 13)
        Me.Lblhasta.TabIndex = 5
        Me.Lblhasta.Text = "HASTA"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.Turquoise
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(591, 94)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(88, 39)
        Me.BtnBuscar.TabIndex = 6
        Me.BtnBuscar.Text = "CALCULAR"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'DgvResultado
        '
        Me.DgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvResultado.Location = New System.Drawing.Point(28, 249)
        Me.DgvResultado.Name = "DgvResultado"
        Me.DgvResultado.Size = New System.Drawing.Size(739, 132)
        Me.DgvResultado.TabIndex = 7
        '
        'LblTotalConsumibles
        '
        Me.LblTotalConsumibles.Location = New System.Drawing.Point(77, 413)
        Me.LblTotalConsumibles.Name = "LblTotalConsumibles"
        Me.LblTotalConsumibles.Size = New System.Drawing.Size(164, 20)
        Me.LblTotalConsumibles.TabIndex = 8
        '
        'LblTotalAdelantos
        '
        Me.LblTotalAdelantos.Location = New System.Drawing.Point(77, 461)
        Me.LblTotalAdelantos.Name = "LblTotalAdelantos"
        Me.LblTotalAdelantos.Size = New System.Drawing.Size(164, 20)
        Me.LblTotalAdelantos.TabIndex = 9
        '
        'Lblcosumibles
        '
        Me.Lblcosumibles.AutoSize = True
        Me.Lblcosumibles.Location = New System.Drawing.Point(74, 397)
        Me.Lblcosumibles.Name = "Lblcosumibles"
        Me.Lblcosumibles.Size = New System.Drawing.Size(84, 13)
        Me.Lblcosumibles.TabIndex = 10
        Me.Lblcosumibles.Text = "CONSUMIBLES"
        '
        'Lblvales
        '
        Me.Lblvales.AutoSize = True
        Me.Lblvales.Location = New System.Drawing.Point(74, 445)
        Me.Lblvales.Name = "Lblvales"
        Me.Lblvales.Size = New System.Drawing.Size(41, 13)
        Me.Lblvales.TabIndex = 11
        Me.Lblvales.Text = "VALES"
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.Lime
        Me.BtnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(687, 448)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(91, 33)
        Me.BtnRegresar.TabIndex = 12
        Me.BtnRegresar.Text = "REGRESAR"
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'LblTotalConsumos
        '
        Me.LblTotalConsumos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalConsumos.Location = New System.Drawing.Point(337, 459)
        Me.LblTotalConsumos.Name = "LblTotalConsumos"
        Me.LblTotalConsumos.Size = New System.Drawing.Size(231, 22)
        Me.LblTotalConsumos.TabIndex = 13
        '
        'Lbltotal_consumos
        '
        Me.Lbltotal_consumos.AutoSize = True
        Me.Lbltotal_consumos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltotal_consumos.Location = New System.Drawing.Point(333, 413)
        Me.Lbltotal_consumos.Name = "Lbltotal_consumos"
        Me.Lbltotal_consumos.Size = New System.Drawing.Size(235, 24)
        Me.Lbltotal_consumos.TabIndex = 14
        Me.Lbltotal_consumos.Text = "TOTAL DE CONSUMOS"
        '
        'LblAgregar
        '
        Me.LblAgregar.AutoSize = True
        Me.LblAgregar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAgregar.ForeColor = System.Drawing.Color.Black
        Me.LblAgregar.Location = New System.Drawing.Point(277, 18)
        Me.LblAgregar.Name = "LblAgregar"
        Me.LblAgregar.Size = New System.Drawing.Size(218, 37)
        Me.LblAgregar.TabIndex = 22
        Me.LblAgregar.Text = "CONSULTAS"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.BtnAplicarRango)
        Me.GroupBox1.Controls.Add(Me.CboRangoRapido)
        Me.GroupBox1.Controls.Add(Me.BtnUltimoMes)
        Me.GroupBox1.Controls.Add(Me.BtnMostrarMovs)
        Me.GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.GroupBox1.Controls.Add(Me.Lblhasta)
        Me.GroupBox1.Controls.Add(Me.Lbldesde)
        Me.GroupBox1.Controls.Add(Me.DtpHasta)
        Me.GroupBox1.Controls.Add(Me.DtpDesde)
        Me.GroupBox1.Controls.Add(Me.CboFuncionario)
        Me.GroupBox1.Controls.Add(Me.Lblfuncionario)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(739, 159)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'BtnAplicarRango
        '
        Me.BtnAplicarRango.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnAplicarRango.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAplicarRango.ForeColor = System.Drawing.Color.White
        Me.BtnAplicarRango.Location = New System.Drawing.Point(415, 122)
        Me.BtnAplicarRango.Name = "BtnAplicarRango"
        Me.BtnAplicarRango.Size = New System.Drawing.Size(111, 31)
        Me.BtnAplicarRango.TabIndex = 26
        Me.BtnAplicarRango.Text = "POR RANGO"
        Me.BtnAplicarRango.UseVisualStyleBackColor = False
        '
        'CboRangoRapido
        '
        Me.CboRangoRapido.FormattingEnabled = True
        Me.CboRangoRapido.Location = New System.Drawing.Point(415, 95)
        Me.CboRangoRapido.Name = "CboRangoRapido"
        Me.CboRangoRapido.Size = New System.Drawing.Size(111, 21)
        Me.CboRangoRapido.TabIndex = 25
        '
        'BtnUltimoMes
        '
        Me.BtnUltimoMes.BackColor = System.Drawing.Color.Green
        Me.BtnUltimoMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUltimoMes.ForeColor = System.Drawing.Color.White
        Me.BtnUltimoMes.Location = New System.Drawing.Point(235, 95)
        Me.BtnUltimoMes.Name = "BtnUltimoMes"
        Me.BtnUltimoMes.Size = New System.Drawing.Size(100, 36)
        Me.BtnUltimoMes.TabIndex = 23
        Me.BtnUltimoMes.Text = "ÚLTIMO MES"
        Me.BtnUltimoMes.UseVisualStyleBackColor = False
        '
        'BtnMostrarMovs
        '
        Me.BtnMostrarMovs.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnMostrarMovs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMostrarMovs.ForeColor = System.Drawing.Color.White
        Me.BtnMostrarMovs.Location = New System.Drawing.Point(79, 95)
        Me.BtnMostrarMovs.Name = "BtnMostrarMovs"
        Me.BtnMostrarMovs.Size = New System.Drawing.Size(102, 36)
        Me.BtnMostrarMovs.TabIndex = 22
        Me.BtnMostrarMovs.Text = "TODOS LOS MOVIMIENTOS"
        Me.BtnMostrarMovs.UseVisualStyleBackColor = False
        '
        'Form4_Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 493)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblAgregar)
        Me.Controls.Add(Me.Lbltotal_consumos)
        Me.Controls.Add(Me.LblTotalConsumos)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.Lblvales)
        Me.Controls.Add(Me.Lblcosumibles)
        Me.Controls.Add(Me.LblTotalAdelantos)
        Me.Controls.Add(Me.LblTotalConsumibles)
        Me.Controls.Add(Me.DgvResultado)
        Me.Name = "Form4_Consultas"
        Me.Text = "Form4_Consultas"
        CType(Me.DgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents LblTotalConsumibles As TextBox
    Friend WithEvents LblTotalAdelantos As TextBox
    Friend WithEvents Lblcosumibles As Label
    Friend WithEvents Lblvales As Label
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents LblTotalConsumos As TextBox
    Friend WithEvents Lbltotal_consumos As Label
    Friend WithEvents LblAgregar As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnMostrarMovs As Button
    Friend WithEvents BtnUltimoMes As Button
    Friend WithEvents CboRangoRapido As ComboBox
    Friend WithEvents BtnAplicarRango As Button
End Class
