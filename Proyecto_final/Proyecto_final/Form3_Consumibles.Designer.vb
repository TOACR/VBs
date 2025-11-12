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
        Me.LblLiquidacion = New System.Windows.Forms.Label()
        Me.DtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.DtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.Lbldesde = New System.Windows.Forms.Label()
        Me.LblHasta = New System.Windows.Forms.Label()
        Me.DgvMovs = New System.Windows.Forms.DataGridView()
        Me.BtnLiquidar = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.LblColones = New System.Windows.Forms.Label()
        Me.LblAgregar = New System.Windows.Forms.Label()
        CType(Me.NumCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvMovs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CboFuncionario
        '
        Me.CboFuncionario.FormattingEnabled = True
        Me.CboFuncionario.Location = New System.Drawing.Point(51, 231)
        Me.CboFuncionario.Name = "CboFuncionario"
        Me.CboFuncionario.Size = New System.Drawing.Size(121, 21)
        Me.CboFuncionario.TabIndex = 0
        '
        'CboConsumible
        '
        Me.CboConsumible.FormattingEnabled = True
        Me.CboConsumible.Location = New System.Drawing.Point(48, 284)
        Me.CboConsumible.Name = "CboConsumible"
        Me.CboConsumible.Size = New System.Drawing.Size(124, 21)
        Me.CboConsumible.TabIndex = 1
        '
        'Lblfuncionario
        '
        Me.Lblfuncionario.AutoSize = True
        Me.Lblfuncionario.Location = New System.Drawing.Point(48, 215)
        Me.Lblfuncionario.Name = "Lblfuncionario"
        Me.Lblfuncionario.Size = New System.Drawing.Size(66, 13)
        Me.Lblfuncionario.TabIndex = 2
        Me.Lblfuncionario.Text = "EMPLEADO"
        '
        'Lblconsumible
        '
        Me.Lblconsumible.AutoSize = True
        Me.Lblconsumible.Location = New System.Drawing.Point(48, 268)
        Me.Lblconsumible.Name = "Lblconsumible"
        Me.Lblconsumible.Size = New System.Drawing.Size(77, 13)
        Me.Lblconsumible.TabIndex = 3
        Me.Lblconsumible.Text = "CONSUMIBLE"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(217, 284)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(120, 20)
        Me.TxtPrecio.TabIndex = 4
        '
        'NumCantidad
        '
        Me.NumCantidad.Location = New System.Drawing.Point(377, 284)
        Me.NumCantidad.Name = "NumCantidad"
        Me.NumCantidad.Size = New System.Drawing.Size(73, 20)
        Me.NumCantidad.TabIndex = 5
        '
        'Lblprecio
        '
        Me.Lblprecio.AutoSize = True
        Me.Lblprecio.Location = New System.Drawing.Point(214, 268)
        Me.Lblprecio.Name = "Lblprecio"
        Me.Lblprecio.Size = New System.Drawing.Size(47, 13)
        Me.Lblprecio.TabIndex = 6
        Me.Lblprecio.Text = "PRECIO"
        '
        'Lblcantidad
        '
        Me.Lblcantidad.AutoSize = True
        Me.Lblcantidad.Location = New System.Drawing.Point(374, 268)
        Me.Lblcantidad.Name = "Lblcantidad"
        Me.Lblcantidad.Size = New System.Drawing.Size(62, 13)
        Me.Lblcantidad.TabIndex = 7
        Me.Lblcantidad.Text = "CANTIDAD"
        '
        'BtnAgregarConsumo
        '
        Me.BtnAgregarConsumo.Location = New System.Drawing.Point(505, 263)
        Me.BtnAgregarConsumo.Name = "BtnAgregarConsumo"
        Me.BtnAgregarConsumo.Size = New System.Drawing.Size(90, 42)
        Me.BtnAgregarConsumo.TabIndex = 8
        Me.BtnAgregarConsumo.Text = "AGREGAR CONSUMIBLE"
        Me.BtnAgregarConsumo.UseVisualStyleBackColor = True
        '
        'LblVales
        '
        Me.LblVales.AutoSize = True
        Me.LblVales.Location = New System.Drawing.Point(51, 320)
        Me.LblVales.Name = "LblVales"
        Me.LblVales.Size = New System.Drawing.Size(41, 13)
        Me.LblVales.TabIndex = 9
        Me.LblVales.Text = "VALES"
        '
        'TxtMontoAdelanto
        '
        Me.TxtMontoAdelanto.Location = New System.Drawing.Point(48, 336)
        Me.TxtMontoAdelanto.Name = "TxtMontoAdelanto"
        Me.TxtMontoAdelanto.Size = New System.Drawing.Size(124, 20)
        Me.TxtMontoAdelanto.TabIndex = 10
        '
        'BtnRegistrarAdelanto
        '
        Me.BtnRegistrarAdelanto.Location = New System.Drawing.Point(217, 332)
        Me.BtnRegistrarAdelanto.Name = "BtnRegistrarAdelanto"
        Me.BtnRegistrarAdelanto.Size = New System.Drawing.Size(79, 35)
        Me.BtnRegistrarAdelanto.TabIndex = 11
        Me.BtnRegistrarAdelanto.Text = "AGREGAR VALE"
        Me.BtnRegistrarAdelanto.UseVisualStyleBackColor = True
        '
        'LblLiquidacion
        '
        Me.LblLiquidacion.AutoSize = True
        Me.LblLiquidacion.Location = New System.Drawing.Point(674, 307)
        Me.LblLiquidacion.Name = "LblLiquidacion"
        Me.LblLiquidacion.Size = New System.Drawing.Size(76, 13)
        Me.LblLiquidacion.TabIndex = 12
        Me.LblLiquidacion.Text = "LIQUIDACION"
        '
        'DtpDesde
        '
        Me.DtpDesde.Location = New System.Drawing.Point(48, 396)
        Me.DtpDesde.Name = "DtpDesde"
        Me.DtpDesde.Size = New System.Drawing.Size(200, 20)
        Me.DtpDesde.TabIndex = 13
        '
        'DtpHasta
        '
        Me.DtpHasta.Location = New System.Drawing.Point(284, 396)
        Me.DtpHasta.Name = "DtpHasta"
        Me.DtpHasta.Size = New System.Drawing.Size(200, 20)
        Me.DtpHasta.TabIndex = 14
        '
        'Lbldesde
        '
        Me.Lbldesde.AutoSize = True
        Me.Lbldesde.Location = New System.Drawing.Point(48, 377)
        Me.Lbldesde.Name = "Lbldesde"
        Me.Lbldesde.Size = New System.Drawing.Size(44, 13)
        Me.Lbldesde.TabIndex = 15
        Me.Lbldesde.Text = "DESDE"
        '
        'LblHasta
        '
        Me.LblHasta.AutoSize = True
        Me.LblHasta.Location = New System.Drawing.Point(284, 377)
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
        Me.DgvMovs.Size = New System.Drawing.Size(779, 111)
        Me.DgvMovs.TabIndex = 17
        '
        'BtnLiquidar
        '
        Me.BtnLiquidar.Location = New System.Drawing.Point(677, 323)
        Me.BtnLiquidar.Name = "BtnLiquidar"
        Me.BtnLiquidar.Size = New System.Drawing.Size(87, 44)
        Me.BtnLiquidar.TabIndex = 18
        Me.BtnLiquidar.Text = "LIQUIDAR"
        Me.BtnLiquidar.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(677, 396)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(87, 32)
        Me.BtnRegresar.TabIndex = 19
        Me.BtnRegresar.Text = "REGRESAR"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'LblColones
        '
        Me.LblColones.AutoSize = True
        Me.LblColones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblColones.Location = New System.Drawing.Point(26, 336)
        Me.LblColones.Name = "LblColones"
        Me.LblColones.Size = New System.Drawing.Size(16, 16)
        Me.LblColones.TabIndex = 20
        Me.LblColones.Text = "₡"
        '
        'LblAgregar
        '
        Me.LblAgregar.AutoSize = True
        Me.LblAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAgregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblAgregar.Location = New System.Drawing.Point(175, 36)
        Me.LblAgregar.Name = "LblAgregar"
        Me.LblAgregar.Size = New System.Drawing.Size(411, 37)
        Me.LblAgregar.TabIndex = 21
        Me.LblAgregar.Text = "CONSUMIBLES Y VALES"
        '
        'Form3_Consumibles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblAgregar)
        Me.Controls.Add(Me.LblColones)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnLiquidar)
        Me.Controls.Add(Me.DgvMovs)
        Me.Controls.Add(Me.LblHasta)
        Me.Controls.Add(Me.Lbldesde)
        Me.Controls.Add(Me.DtpHasta)
        Me.Controls.Add(Me.DtpDesde)
        Me.Controls.Add(Me.LblLiquidacion)
        Me.Controls.Add(Me.BtnRegistrarAdelanto)
        Me.Controls.Add(Me.TxtMontoAdelanto)
        Me.Controls.Add(Me.LblVales)
        Me.Controls.Add(Me.BtnAgregarConsumo)
        Me.Controls.Add(Me.Lblcantidad)
        Me.Controls.Add(Me.Lblprecio)
        Me.Controls.Add(Me.NumCantidad)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Me.Lblconsumible)
        Me.Controls.Add(Me.Lblfuncionario)
        Me.Controls.Add(Me.CboConsumible)
        Me.Controls.Add(Me.CboFuncionario)
        Me.Name = "Form3_Consumibles"
        Me.Text = "Form3_Consumibles"
        CType(Me.NumCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvMovs, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LblLiquidacion As Label
    Friend WithEvents DtpDesde As DateTimePicker
    Friend WithEvents DtpHasta As DateTimePicker
    Friend WithEvents Lbldesde As Label
    Friend WithEvents LblHasta As Label
    Friend WithEvents DgvMovs As DataGridView
    Friend WithEvents BtnLiquidar As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents LblColones As Label
    Friend WithEvents LblAgregar As Label
End Class
