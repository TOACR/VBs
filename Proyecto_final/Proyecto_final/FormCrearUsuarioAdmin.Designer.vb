<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCrearUsuarioAdmin
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
        Me.BtnCrearAdmin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnCrearAdmin
        '
        Me.BtnCrearAdmin.Location = New System.Drawing.Point(365, 250)
        Me.BtnCrearAdmin.Name = "BtnCrearAdmin"
        Me.BtnCrearAdmin.Size = New System.Drawing.Size(75, 23)
        Me.BtnCrearAdmin.TabIndex = 0
        Me.BtnCrearAdmin.Text = "Button1"
        Me.BtnCrearAdmin.UseVisualStyleBackColor = True
        '
        'FormCrearUsuarioAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnCrearAdmin)
        Me.Name = "FormCrearUsuarioAdmin"
        Me.Text = "FormCrearUsuarioAdmin"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCrearAdmin As Button
End Class
