<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.BtnCargar = New System.Windows.Forms.Button()
        Me.LblRuta = New System.Windows.Forms.Label()
        Me.TxtRuta = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnCargar
        '
        Me.BtnCargar.Location = New System.Drawing.Point(317, 95)
        Me.BtnCargar.Name = "BtnCargar"
        Me.BtnCargar.Size = New System.Drawing.Size(153, 59)
        Me.BtnCargar.TabIndex = 0
        Me.BtnCargar.Text = "CARGAR ARCHIVO PLANO"
        Me.BtnCargar.UseVisualStyleBackColor = True
        '
        'LblRuta
        '
        Me.LblRuta.AutoSize = True
        Me.LblRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRuta.Location = New System.Drawing.Point(140, 32)
        Me.LblRuta.Name = "LblRuta"
        Me.LblRuta.Size = New System.Drawing.Size(62, 20)
        Me.LblRuta.TabIndex = 1
        Me.LblRuta.Text = "RUTA:"
        '
        'TxtRuta
        '
        Me.TxtRuta.Location = New System.Drawing.Point(220, 31)
        Me.TxtRuta.Name = "TxtRuta"
        Me.TxtRuta.Size = New System.Drawing.Size(437, 20)
        Me.TxtRuta.TabIndex = 2
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 185)
        Me.Controls.Add(Me.TxtRuta)
        Me.Controls.Add(Me.LblRuta)
        Me.Controls.Add(Me.BtnCargar)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCargar As Button
    Friend WithEvents LblRuta As Label
    Friend WithEvents TxtRuta As TextBox
End Class
