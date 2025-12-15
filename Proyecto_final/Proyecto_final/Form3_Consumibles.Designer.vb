<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3_Consumibles
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
        Me.CboFuncionario = New System.Windows.Forms.ComboBox()
        Me.CboConsumible = New System.Windows.Forms.ComboBox()
        Me.Lblfuncionario = New System.Windows.Forms.Label()
        Me.Lblconsumible = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.NumCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Lblprecio = New System.Windows.Forms.Label()
        Me.Lblcantidad = New System.Windows.Forms.Label()
        Me.BtnAgregarConsumo = New System.Windows.Forms.Button()
        Me.LblVales = New System.Windows.Forms.Label()
        Me.TxtMontoAdelanto = New System.Windows.Forms.TextBox()
        Me.BtnRegistrarAdelanto = New System.Windows.Forms.Button()
        Me.DtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.DtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.Lbldesde = New System.Windows.Forms.Label()
        Me.LblHasta = New System.Windows.Forms.Label()
        Me.DgvMovs = New System.Windows.Forms.DataGridView()
        Me.BtnLiquidar = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.LblColones = New System.Windows.Forms.Label()
        Me.LblAgregar = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnMostrarMovs = New System.Windows.Forms.Button()
        Me.BtnGestionar = New System.Windows.Forms.Button()
        Me.BtnUltimoMes = New System.Windows.Forms.Button()
        Me.BtnAplicarRango = New System.Windows.Forms.Button()
        Me.CboRangoRapido = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.NumCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvMovs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CboFuncionario
        '
        Me.CboFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFuncionario.FormattingEnabled = True
        Me.CboFuncionario.Location = New System.Drawing.Point(35, 42)
        Me.CboFuncionario.Name = "CboFuncionario"
        Me.CboFuncionario.Size = New System.Drawing.Size(141, 21)
        Me.CboFuncionario.TabIndex = 0
        '
        'CboConsumible
        '
        Me.CboConsumible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboConsumible.FormattingEnabled = True
        Me.CboConsumible.Location = New System.Drawing.Point(218, 42)
        Me.CboConsumible.Name = "CboConsumible"
        Me.CboConsumible.Size = New System.Drawing.Size(124, 21)
        Me.CboConsumible.TabIndex = 1
        '
        'Lblfuncionario
        '
        Me.Lblfuncionario.AutoSize = True
        Me.Lblfuncionario.Location = New System.Drawing.Point(32, 26)
        Me.Lblfuncionario.Name = "Lblfuncionario"
        Me.Lblfuncionario.Size = New System.Drawing.Size(81, 13)
        Me.Lblfuncionario.TabIndex = 2
        Me.Lblfuncionario.Text = "FUNCIONARIO"
        '
        'Lblconsumible
        '
        Me.Lblconsumible.AutoSize = True
        Me.Lblconsumible.Location = New System.Drawing.Point(215, 26)
        Me.Lblconsumible.Name = "Lblconsumible"
        Me.Lblconsumible.Size = New System.Drawing.Size(77, 13)
        Me.Lblconsumible.TabIndex = 3
        Me.Lblconsumible.Text = "CONSUMIBLE"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(390, 42)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.ReadOnly = True
        Me.TxtPrecio.Size = New System.Drawing.Size(120, 20)
        Me.TxtPrecio.TabIndex = 4
        '
        'NumCantidad
        '
        Me.NumCantidad.Location = New System.Drawing.Point(531, 42)
        Me.NumCantidad.Name = "NumCantidad"
        Me.NumCantidad.ReadOnly = True
        Me.NumCantidad.Size = New System.Drawing.Size(73, 20)
        Me.NumCantidad.TabIndex = 5
        '
        'Lblprecio
        '
        Me.Lblprecio.AutoSize = True
        Me.Lblprecio.Location = New System.Drawing.Point(387, 26)
        Me.Lblprecio.Name = "Lblprecio"
        Me.Lblprecio.Size = New System.Drawing.Size(47, 13)
        Me.Lblprecio.TabIndex = 6
        Me.Lblprecio.Text = "PRECIO"
        '
        'Lblcantidad
        '
        Me.Lblcantidad.AutoSize = True
        Me.Lblcantidad.Location = New System.Drawing.Point(528, 26)
        Me.Lblcantidad.Name = "Lblcantidad"
        Me.Lblcantidad.Size = New System.Drawing.Size(62, 13)
        Me.Lblcantidad.TabIndex = 7
        Me.Lblcantidad.Text = "CANTIDAD"
        '
        'BtnAgregarConsumo
        '
        Me.BtnAgregarConsumo.BackColor = System.Drawing.Color.Lime
        Me.BtnAgregarConsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarConsumo.Location = New System.Drawing.Point(644, 26)
        Me.BtnAgregarConsumo.Name = "BtnAgregarConsumo"
        Me.BtnAgregarConsumo.Size = New System.Drawing.Size(102, 42)
        Me.BtnAgregarConsumo.TabIndex = 8
        Me.BtnAgregarConsumo.Text = "AGREGAR CONSUMIBLE"
        Me.BtnAgregarConsumo.UseVisualStyleBackColor = False
        '
        'LblVales
        '
        Me.LblVales.AutoSize = True
        Me.LblVales.Location = New System.Drawing.Point(35, 86)
        Me.LblVales.Name = "LblVales"
        Me.LblVales.Size = New System.Drawing.Size(41, 13)
        Me.LblVales.TabIndex = 9
        Me.LblVales.Text = "VALES"
        '
        'TxtMontoAdelanto
        '
        Me.TxtMontoAdelanto.Location = New System.Drawing.Point(35, 102)
        Me.TxtMontoAdelanto.Name = "TxtMontoAdelanto"
        Me.TxtMontoAdelanto.Size = New System.Drawing.Size(124, 20)
        Me.TxtMontoAdelanto.TabIndex = 10
        '
        'BtnRegistrarAdelanto
        '
        Me.BtnRegistrarAdelanto.BackColor = System.Drawing.Color.Lime
        Me.BtnRegistrarAdelanto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrarAdelanto.Location = New System.Drawing.Point(209, 86)
        Me.BtnRegistrarAdelanto.Name = "BtnRegistrarAdelanto"
        Me.BtnRegistrarAdelanto.Size = New System.Drawing.Size(83, 37)
        Me.BtnRegistrarAdelanto.TabIndex = 11
        Me.BtnRegistrarAdelanto.Text = "AGREGAR VALE"
        Me.BtnRegistrarAdelanto.UseVisualStyleBackColor = False
        '
        'DtpDesde
        '
        Me.DtpDesde.Location = New System.Drawing.Point(35, 156)
        Me.DtpDesde.Name = "DtpDesde"
        Me.DtpDesde.Size = New System.Drawing.Size(200, 20)
        Me.DtpDesde.TabIndex = 13
        '
        'DtpHasta
        '
        Me.DtpHasta.Location = New System.Drawing.Point(284, 156)
        Me.DtpHasta.Name = "DtpHasta"
        Me.DtpHasta.Size = New System.Drawing.Size(200, 20)
        Me.DtpHasta.TabIndex = 14
        '
        'Lbldesde
        '
        Me.Lbldesde.AutoSize = True
        Me.Lbldesde.Location = New System.Drawing.Point(32, 140)
        Me.Lbldesde.Name = "Lbldesde"
        Me.Lbldesde.Size = New System.Drawing.Size(44, 13)
        Me.Lbldesde.TabIndex = 15
        Me.Lbldesde.Text = "DESDE"
        '
        'LblHasta
        '
        Me.LblHasta.AutoSize = True
        Me.LblHasta.Location = New System.Drawing.Point(281, 140)
        Me.LblHasta.Name = "LblHasta"
        Me.LblHasta.Size = New System.Drawing.Size(43, 13)
        Me.LblHasta.TabIndex = 16
        Me.LblHasta.Text = "HASTA"
        '
        'DgvMovs
        '
        Me.DgvMovs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMovs.Location = New System.Drawing.Point(12, 87)
        Me.DgvMovs.Name = "DgvMovs"
        Me.DgvMovs.Size = New System.Drawing.Size(779, 182)
        Me.DgvMovs.TabIndex = 17
        '
        'BtnLiquidar
        '
        Me.BtnLiquidar.BackColor = System.Drawing.Color.DarkOrange
        Me.BtnLiquidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLiquidar.ForeColor = System.Drawing.Color.White
        Me.BtnLiquidar.Location = New System.Drawing.Point(573, 533)
        Me.BtnLiquidar.Name = "BtnLiquidar"
        Me.BtnLiquidar.Size = New System.Drawing.Size(111, 40)
        Me.BtnLiquidar.TabIndex = 18
        Me.BtnLiquidar.Text = "LIQUIDAR CONSUMIBLES"
        Me.BtnLiquidar.UseVisualStyleBackColor = False
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.Lime
        Me.BtnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(704, 541)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(87, 32)
        Me.BtnRegresar.TabIndex = 19
        Me.BtnRegresar.Text = "REGRESAR"
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'LblColones
        '
        Me.LblColones.AutoSize = True
        Me.LblColones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblColones.Location = New System.Drawing.Point(13, 106)
        Me.LblColones.Name = "LblColones"
        Me.LblColones.Size = New System.Drawing.Size(16, 16)
        Me.LblColones.TabIndex = 20
        Me.LblColones.Text = "₡"
        '
        'LblAgregar
        '
        Me.LblAgregar.AutoSize = True
        Me.LblAgregar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAgregar.ForeColor = System.Drawing.Color.Black
        Me.LblAgregar.Location = New System.Drawing.Point(175, 36)
        Me.LblAgregar.Name = "LblAgregar"
        Me.LblAgregar.Size = New System.Drawing.Size(398, 37)
        Me.LblAgregar.TabIndex = 21
        Me.LblAgregar.Text = "CONSUMIBLES Y VALES"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.LblColones)
        Me.GroupBox1.Controls.Add(Me.LblHasta)
        Me.GroupBox1.Controls.Add(Me.Lbldesde)
        Me.GroupBox1.Controls.Add(Me.DtpHasta)
        Me.GroupBox1.Controls.Add(Me.DtpDesde)
        Me.GroupBox1.Controls.Add(Me.BtnRegistrarAdelanto)
        Me.GroupBox1.Controls.Add(Me.TxtMontoAdelanto)
        Me.GroupBox1.Controls.Add(Me.LblVales)
        Me.GroupBox1.Controls.Add(Me.BtnAgregarConsumo)
        Me.GroupBox1.Controls.Add(Me.Lblcantidad)
        Me.GroupBox1.Controls.Add(Me.Lblprecio)
        Me.GroupBox1.Controls.Add(Me.NumCantidad)
        Me.GroupBox1.Controls.Add(Me.TxtPrecio)
        Me.GroupBox1.Controls.Add(Me.Lblconsumible)
        Me.GroupBox1.Controls.Add(Me.Lblfuncionario)
        Me.GroupBox1.Controls.Add(Me.CboConsumible)
        Me.GroupBox1.Controls.Add(Me.CboFuncionario)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 275)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 186)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cargar consumibles y vales"
        '
        'BtnMostrarMovs
        '
        Me.BtnMostrarMovs.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnMostrarMovs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMostrarMovs.ForeColor = System.Drawing.Color.White
        Me.BtnMostrarMovs.Location = New System.Drawing.Point(25, 13)
        Me.BtnMostrarMovs.Name = "BtnMostrarMovs"
        Me.BtnMostrarMovs.Size = New System.Drawing.Size(102, 36)
        Me.BtnMostrarMovs.TabIndex = 21
        Me.BtnMostrarMovs.Text = "TODOS LOS MOVIMIENTOS"
        Me.BtnMostrarMovs.UseVisualStyleBackColor = False
        '
        'BtnGestionar
        '
        Me.BtnGestionar.BackColor = System.Drawing.Color.SlateBlue
        Me.BtnGestionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGestionar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnGestionar.Location = New System.Drawing.Point(570, 489)
        Me.BtnGestionar.Name = "BtnGestionar"
        Me.BtnGestionar.Size = New System.Drawing.Size(114, 36)
        Me.BtnGestionar.TabIndex = 68
        Me.BtnGestionar.Text = "GESTIONAR CONSUMIBLES"
        Me.BtnGestionar.UseVisualStyleBackColor = False
        '
        'BtnUltimoMes
        '
        Me.BtnUltimoMes.BackColor = System.Drawing.Color.Green
        Me.BtnUltimoMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUltimoMes.ForeColor = System.Drawing.Color.White
        Me.BtnUltimoMes.Location = New System.Drawing.Point(162, 13)
        Me.BtnUltimoMes.Name = "BtnUltimoMes"
        Me.BtnUltimoMes.Size = New System.Drawing.Size(102, 36)
        Me.BtnUltimoMes.TabIndex = 22
        Me.BtnUltimoMes.Text = "ÚLTIMO MES"
        Me.BtnUltimoMes.UseVisualStyleBackColor = False
        '
        'BtnAplicarRango
        '
        Me.BtnAplicarRango.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnAplicarRango.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAplicarRango.ForeColor = System.Drawing.Color.White
        Me.BtnAplicarRango.Location = New System.Drawing.Point(291, 40)
        Me.BtnAplicarRango.Name = "BtnAplicarRango"
        Me.BtnAplicarRango.Size = New System.Drawing.Size(111, 31)
        Me.BtnAplicarRango.TabIndex = 23
        Me.BtnAplicarRango.Text = "POR RANGO"
        Me.BtnAplicarRango.UseVisualStyleBackColor = False
        '
        'CboRangoRapido
        '
        Me.CboRangoRapido.FormattingEnabled = True
        Me.CboRangoRapido.Location = New System.Drawing.Point(291, 13)
        Me.CboRangoRapido.Name = "CboRangoRapido"
        Me.CboRangoRapido.Size = New System.Drawing.Size(111, 21)
        Me.CboRangoRapido.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(242, 464)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 24)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "MOVIMIENTOS"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Thistle
        Me.GroupBox2.Controls.Add(Me.BtnMostrarMovs)
        Me.GroupBox2.Controls.Add(Me.CboRangoRapido)
        Me.GroupBox2.Controls.Add(Me.BtnAplicarRango)
        Me.GroupBox2.Controls.Add(Me.BtnUltimoMes)
        Me.GroupBox2.Location = New System.Drawing.Point(120, 491)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(423, 81)
        Me.GroupBox2.TabIndex = 70
        Me.GroupBox2.TabStop = False
        '
        'Form3_Consumibles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 585)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnGestionar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblAgregar)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnLiquidar)
        Me.Controls.Add(Me.DgvMovs)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form3_Consumibles"
        Me.Text = "Form3_Consumibles"
        CType(Me.NumCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvMovs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CboFuncionario As ComboBox
    Friend WithEvents CboConsumible As ComboBox
    Friend WithEvents Lblfuncionario As Label
    Friend WithEvents Lblconsumible As Label
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents NumCantidad As NumericUpDown
    Friend WithEvents Lblprecio As Label
    Friend WithEvents Lblcantidad As Label
    Friend WithEvents BtnAgregarConsumo As Button
    Friend WithEvents LblVales As Label
    Friend WithEvents TxtMontoAdelanto As TextBox
    Friend WithEvents BtnRegistrarAdelanto As Button
    Friend WithEvents DtpDesde As DateTimePicker
    Friend WithEvents DtpHasta As DateTimePicker
    Friend WithEvents Lbldesde As Label
    Friend WithEvents LblHasta As Label
    Friend WithEvents DgvMovs As DataGridView
    Friend WithEvents BtnLiquidar As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents LblColones As Label
    Friend WithEvents LblAgregar As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnGestionar As Button
    Friend WithEvents BtnMostrarMovs As Button
    Friend WithEvents BtnAplicarRango As Button
    Friend WithEvents BtnUltimoMes As Button
    Friend WithEvents CboRangoRapido As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
End Class
