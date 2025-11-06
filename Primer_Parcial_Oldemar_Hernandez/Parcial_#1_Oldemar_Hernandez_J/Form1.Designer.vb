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
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.LblID = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.LblConsumo = New System.Windows.Forms.Label()
        Me.TxtConsumo = New System.Windows.Forms.TextBox()
        Me.LblCategoria = New System.Windows.Forms.Label()
        Me.CmbCategoria = New System.Windows.Forms.ComboBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.TxtPago = New System.Windows.Forms.TextBox()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.TxtResultado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LblTitulo.Location = New System.Drawing.Point(21, 21)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(524, 29)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "EcoEnergy Solutions - Calculadora de Pago"
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblID.Location = New System.Drawing.Point(23, 78)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(122, 16)
        Me.LblID.TabIndex = 1
        Me.LblID.Text = "ID DEL CLIENTE"
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(26, 97)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(126, 20)
        Me.TxtID.TabIndex = 2
        '
        'LblConsumo
        '
        Me.LblConsumo.AutoSize = True
        Me.LblConsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConsumo.Location = New System.Drawing.Point(225, 78)
        Me.LblConsumo.Name = "LblConsumo"
        Me.LblConsumo.Size = New System.Drawing.Size(127, 16)
        Me.LblConsumo.TabIndex = 3
        Me.LblConsumo.Text = "CONSUMO (kWh)"
        '
        'TxtConsumo
        '
        Me.TxtConsumo.Location = New System.Drawing.Point(226, 97)
        Me.TxtConsumo.Name = "TxtConsumo"
        Me.TxtConsumo.Size = New System.Drawing.Size(126, 20)
        Me.TxtConsumo.TabIndex = 4
        '
        'LblCategoria
        '
        Me.LblCategoria.AutoSize = True
        Me.LblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCategoria.Location = New System.Drawing.Point(418, 78)
        Me.LblCategoria.Name = "LblCategoria"
        Me.LblCategoria.Size = New System.Drawing.Size(143, 16)
        Me.LblCategoria.TabIndex = 5
        Me.LblCategoria.Text = "CATEGORIA (R/C/I)"
        '
        'CmbCategoria
        '
        Me.CmbCategoria.FormattingEnabled = True
        Me.CmbCategoria.Items.AddRange(New Object() {"R", "C", "I"})
        Me.CmbCategoria.Location = New System.Drawing.Point(421, 97)
        Me.CmbCategoria.Name = "CmbCategoria"
        Me.CmbCategoria.Size = New System.Drawing.Size(121, 21)
        Me.CmbCategoria.TabIndex = 6
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(216, 415)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(126, 16)
        Me.LblTotal.TabIndex = 7
        Me.LblTotal.Text = "TOTAL A PAGAR"
        '
        'TxtPago
        '
        Me.TxtPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPago.Location = New System.Drawing.Point(181, 434)
        Me.TxtPago.Name = "TxtPago"
        Me.TxtPago.ReadOnly = True
        Me.TxtPago.Size = New System.Drawing.Size(208, 26)
        Me.TxtPago.TabIndex = 8
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.Lime
        Me.BtnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular.Location = New System.Drawing.Point(218, 487)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(134, 60)
        Me.BtnCalcular.TabIndex = 9
        Me.BtnCalcular.Text = "Calcular pago"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'TxtResultado
        '
        Me.TxtResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResultado.Location = New System.Drawing.Point(93, 166)
        Me.TxtResultado.Multiline = True
        Me.TxtResultado.Name = "TxtResultado"
        Me.TxtResultado.ReadOnly = True
        Me.TxtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtResultado.Size = New System.Drawing.Size(399, 209)
        Me.TxtResultado.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 578)
        Me.Controls.Add(Me.TxtResultado)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.TxtPago)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.CmbCategoria)
        Me.Controls.Add(Me.LblCategoria)
        Me.Controls.Add(Me.TxtConsumo)
        Me.Controls.Add(Me.LblConsumo)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.LblID)
        Me.Controls.Add(Me.LblTitulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitulo As Label
    Friend WithEvents LblID As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents LblConsumo As Label
    Friend WithEvents TxtConsumo As TextBox
    Friend WithEvents LblCategoria As Label
    Friend WithEvents CmbCategoria As ComboBox
    Friend WithEvents LblTotal As Label
    Friend WithEvents TxtPago As TextBox
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents TxtResultado As TextBox
End Class
