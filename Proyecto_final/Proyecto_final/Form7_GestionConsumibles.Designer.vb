<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7_GestionConsumibles
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
        Me.DgvConsumibles = New System.Windows.Forms.DataGridView()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.LblProducto = New System.Windows.Forms.Label()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.LblMoneda = New System.Windows.Forms.Label()
        Me.LblGestionConsumibles = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnVerInactivos = New System.Windows.Forms.Button()
        Me.BtnReactivar = New System.Windows.Forms.Button()
        CType(Me.DgvConsumibles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvConsumibles
        '
        Me.DgvConsumibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConsumibles.Location = New System.Drawing.Point(36, 87)
        Me.DgvConsumibles.Name = "DgvConsumibles"
        Me.DgvConsumibles.Size = New System.Drawing.Size(589, 120)
        Me.DgvConsumibles.TabIndex = 0
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(11, 51)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(156, 20)
        Me.TxtNombre.TabIndex = 1
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(219, 51)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.TxtPrecio.TabIndex = 2
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(362, 21)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(84, 32)
        Me.BtnGuardar.TabIndex = 3
        Me.BtnGuardar.Text = "GUARDAR"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Red
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(362, 98)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(84, 32)
        Me.BtnEliminar.TabIndex = 4
        Me.BtnEliminar.Text = "ELIMINAR"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.Lime
        Me.BtnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(559, 434)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(90, 34)
        Me.BtnRegresar.TabIndex = 5
        Me.BtnRegresar.Text = "REGRESAR"
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'LblProducto
        '
        Me.LblProducto.AutoSize = True
        Me.LblProducto.Location = New System.Drawing.Point(8, 31)
        Me.LblProducto.Name = "LblProducto"
        Me.LblProducto.Size = New System.Drawing.Size(77, 13)
        Me.LblProducto.TabIndex = 6
        Me.LblProducto.Text = "CONSUMIBLE"
        '
        'LblPrecio
        '
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.Location = New System.Drawing.Point(216, 31)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(47, 13)
        Me.LblPrecio.TabIndex = 7
        Me.LblPrecio.Text = "PRECIO"
        '
        'LblMoneda
        '
        Me.LblMoneda.AutoSize = True
        Me.LblMoneda.Location = New System.Drawing.Point(198, 54)
        Me.LblMoneda.Name = "LblMoneda"
        Me.LblMoneda.Size = New System.Drawing.Size(15, 13)
        Me.LblMoneda.TabIndex = 8
        Me.LblMoneda.Text = "₡"
        '
        'LblGestionConsumibles
        '
        Me.LblGestionConsumibles.AutoSize = True
        Me.LblGestionConsumibles.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGestionConsumibles.ForeColor = System.Drawing.Color.Black
        Me.LblGestionConsumibles.Location = New System.Drawing.Point(100, 36)
        Me.LblGestionConsumibles.Name = "LblGestionConsumibles"
        Me.LblGestionConsumibles.Size = New System.Drawing.Size(463, 37)
        Me.LblGestionConsumibles.TabIndex = 22
        Me.LblGestionConsumibles.Text = "GESTIÓN DE CONSUMIBLES"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.LightCoral
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(362, 59)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(84, 32)
        Me.BtnCancelar.TabIndex = 24
        Me.BtnCancelar.Text = "CANCELAR"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.LblMoneda)
        Me.GroupBox1.Controls.Add(Me.LblPrecio)
        Me.GroupBox1.Controls.Add(Me.LblProducto)
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Controls.Add(Me.TxtPrecio)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(97, 283)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(466, 145)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consumibles"
        '
        'BtnVerInactivos
        '
        Me.BtnVerInactivos.BackColor = System.Drawing.Color.MistyRose
        Me.BtnVerInactivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerInactivos.Location = New System.Drawing.Point(185, 240)
        Me.BtnVerInactivos.Name = "BtnVerInactivos"
        Me.BtnVerInactivos.Size = New System.Drawing.Size(125, 23)
        Me.BtnVerInactivos.TabIndex = 26
        Me.BtnVerInactivos.Text = "VER INACTIVOS"
        Me.BtnVerInactivos.UseVisualStyleBackColor = False
        '
        'BtnReactivar
        '
        Me.BtnReactivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReactivar.Location = New System.Drawing.Point(351, 240)
        Me.BtnReactivar.Name = "BtnReactivar"
        Me.BtnReactivar.Size = New System.Drawing.Size(125, 23)
        Me.BtnReactivar.TabIndex = 27
        Me.BtnReactivar.Text = "ACTIVAR"
        Me.BtnReactivar.UseVisualStyleBackColor = True
        '
        'Form7_GestionConsumibles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 480)
        Me.Controls.Add(Me.BtnReactivar)
        Me.Controls.Add(Me.BtnVerInactivos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblGestionConsumibles)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.DgvConsumibles)
        Me.Name = "Form7_GestionConsumibles"
        Me.Text = "Form7_GestionConsumibles"
        CType(Me.DgvConsumibles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvConsumibles As DataGridView
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents LblProducto As Label
    Friend WithEvents LblPrecio As Label
    Friend WithEvents LblMoneda As Label
    Friend WithEvents LblGestionConsumibles As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnVerInactivos As Button
    Friend WithEvents BtnReactivar As Button
End Class
