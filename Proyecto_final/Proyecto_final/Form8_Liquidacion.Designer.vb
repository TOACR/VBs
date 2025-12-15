<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8_Liquidacion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblHasta = New System.Windows.Forms.Label()
        Me.Lbldesde = New System.Windows.Forms.Label()
        Me.DtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.DtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Lblfuncionario = New System.Windows.Forms.Label()
        Me.CboFuncionario = New System.Windows.Forms.ComboBox()
        Me.LblAgregar = New System.Windows.Forms.Label()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnLiquidar = New System.Windows.Forms.Button()
        Me.DgvMovs = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnMostrarMovs = New System.Windows.Forms.Button()
        Me.CboRangoRapido = New System.Windows.Forms.ComboBox()
        Me.BtnAplicarRango = New System.Windows.Forms.Button()
        Me.BtnUltimoMes = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvMovs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(233, 340)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 24)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "MOVIMIENTOS"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.LblHasta)
        Me.GroupBox1.Controls.Add(Me.Lbldesde)
        Me.GroupBox1.Controls.Add(Me.DtpHasta)
        Me.GroupBox1.Controls.Add(Me.DtpDesde)
        Me.GroupBox1.Controls.Add(Me.Lblfuncionario)
        Me.GroupBox1.Controls.Add(Me.CboFuncionario)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 248)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 89)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liquidación"
        '
        'LblHasta
        '
        Me.LblHasta.AutoSize = True
        Me.LblHasta.Location = New System.Drawing.Point(534, 23)
        Me.LblHasta.Name = "LblHasta"
        Me.LblHasta.Size = New System.Drawing.Size(43, 13)
        Me.LblHasta.TabIndex = 16
        Me.LblHasta.Text = "HASTA"
        '
        'Lbldesde
        '
        Me.Lbldesde.AutoSize = True
        Me.Lbldesde.Location = New System.Drawing.Point(251, 26)
        Me.Lbldesde.Name = "Lbldesde"
        Me.Lbldesde.Size = New System.Drawing.Size(44, 13)
        Me.Lbldesde.TabIndex = 15
        Me.Lbldesde.Text = "DESDE"
        '
        'DtpHasta
        '
        Me.DtpHasta.Location = New System.Drawing.Point(537, 39)
        Me.DtpHasta.Name = "DtpHasta"
        Me.DtpHasta.Size = New System.Drawing.Size(200, 20)
        Me.DtpHasta.TabIndex = 14
        '
        'DtpDesde
        '
        Me.DtpDesde.Location = New System.Drawing.Point(254, 42)
        Me.DtpDesde.Name = "DtpDesde"
        Me.DtpDesde.Size = New System.Drawing.Size(200, 20)
        Me.DtpDesde.TabIndex = 13
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
        'CboFuncionario
        '
        Me.CboFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFuncionario.FormattingEnabled = True
        Me.CboFuncionario.Location = New System.Drawing.Point(35, 42)
        Me.CboFuncionario.Name = "CboFuncionario"
        Me.CboFuncionario.Size = New System.Drawing.Size(141, 21)
        Me.CboFuncionario.TabIndex = 0
        '
        'LblAgregar
        '
        Me.LblAgregar.AutoSize = True
        Me.LblAgregar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAgregar.ForeColor = System.Drawing.Color.Black
        Me.LblAgregar.Location = New System.Drawing.Point(266, 9)
        Me.LblAgregar.Name = "LblAgregar"
        Me.LblAgregar.Size = New System.Drawing.Size(277, 37)
        Me.LblAgregar.TabIndex = 74
        Me.LblAgregar.Text = "LIQUIDACIONES"
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.Lime
        Me.BtnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(695, 417)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(87, 32)
        Me.BtnRegresar.TabIndex = 73
        Me.BtnRegresar.Text = "REGRESAR"
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'BtnLiquidar
        '
        Me.BtnLiquidar.BackColor = System.Drawing.Color.DarkOrange
        Me.BtnLiquidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLiquidar.ForeColor = System.Drawing.Color.White
        Me.BtnLiquidar.Location = New System.Drawing.Point(564, 367)
        Me.BtnLiquidar.Name = "BtnLiquidar"
        Me.BtnLiquidar.Size = New System.Drawing.Size(111, 40)
        Me.BtnLiquidar.TabIndex = 72
        Me.BtnLiquidar.Text = "LIQUIDAR CONSUMIBLES"
        Me.BtnLiquidar.UseVisualStyleBackColor = False
        '
        'DgvMovs
        '
        Me.DgvMovs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMovs.Location = New System.Drawing.Point(9, 60)
        Me.DgvMovs.Name = "DgvMovs"
        Me.DgvMovs.Size = New System.Drawing.Size(779, 182)
        Me.DgvMovs.TabIndex = 71
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Thistle
        Me.GroupBox2.Controls.Add(Me.BtnMostrarMovs)
        Me.GroupBox2.Controls.Add(Me.CboRangoRapido)
        Me.GroupBox2.Controls.Add(Me.BtnAplicarRango)
        Me.GroupBox2.Controls.Add(Me.BtnUltimoMes)
        Me.GroupBox2.Location = New System.Drawing.Point(111, 367)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(423, 81)
        Me.GroupBox2.TabIndex = 78
        Me.GroupBox2.TabStop = False
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
        'CboRangoRapido
        '
        Me.CboRangoRapido.FormattingEnabled = True
        Me.CboRangoRapido.Location = New System.Drawing.Point(291, 13)
        Me.CboRangoRapido.Name = "CboRangoRapido"
        Me.CboRangoRapido.Size = New System.Drawing.Size(111, 21)
        Me.CboRangoRapido.TabIndex = 24
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
        'Form8_Liquidacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 459)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblAgregar)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnLiquidar)
        Me.Controls.Add(Me.DgvMovs)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form8_Liquidacion"
        Me.Text = "Form8_Liquidacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvMovs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblHasta As Label
    Friend WithEvents Lbldesde As Label
    Friend WithEvents DtpHasta As DateTimePicker
    Friend WithEvents DtpDesde As DateTimePicker
    Friend WithEvents Lblfuncionario As Label
    Friend WithEvents CboFuncionario As ComboBox
    Friend WithEvents LblAgregar As Label
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnLiquidar As Button
    Friend WithEvents DgvMovs As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnMostrarMovs As Button
    Friend WithEvents CboRangoRapido As ComboBox
    Friend WithEvents BtnAplicarRango As Button
    Friend WithEvents BtnUltimoMes As Button
End Class
