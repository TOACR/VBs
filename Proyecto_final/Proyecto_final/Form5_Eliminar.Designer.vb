<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5_Eliminar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5_Eliminar))
        Me.DgvFuncionarios = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Msk_id = New System.Windows.Forms.TextBox()
        Me.lblFuncionarioId = New System.Windows.Forms.TextBox()
        Me.Lblidentificacion = New System.Windows.Forms.Label()
        Me.Lblnombrecompleto = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.DgvFuncionarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvFuncionarios
        '
        Me.DgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFuncionarios.Location = New System.Drawing.Point(12, 87)
        Me.DgvFuncionarios.Name = "DgvFuncionarios"
        Me.DgvFuncionarios.Size = New System.Drawing.Size(754, 150)
        Me.DgvFuncionarios.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(226, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ELIMINACION DE FUNCIONARIOS"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Red
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnEliminar.Location = New System.Drawing.Point(331, 320)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(111, 39)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "ELIMINAR FUNCIONARIO"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(666, 324)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(90, 35)
        Me.BtnCancelar.TabIndex = 4
        Me.BtnCancelar.Text = "CANCELAR"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'Msk_id
        '
        Me.Msk_id.Location = New System.Drawing.Point(175, 280)
        Me.Msk_id.Name = "Msk_id"
        Me.Msk_id.Size = New System.Drawing.Size(158, 20)
        Me.Msk_id.TabIndex = 5
        '
        'lblFuncionarioId
        '
        Me.lblFuncionarioId.Location = New System.Drawing.Point(443, 280)
        Me.lblFuncionarioId.Name = "lblFuncionarioId"
        Me.lblFuncionarioId.Size = New System.Drawing.Size(195, 20)
        Me.lblFuncionarioId.TabIndex = 6
        '
        'Lblidentificacion
        '
        Me.Lblidentificacion.AutoSize = True
        Me.Lblidentificacion.Location = New System.Drawing.Point(172, 264)
        Me.Lblidentificacion.Name = "Lblidentificacion"
        Me.Lblidentificacion.Size = New System.Drawing.Size(161, 13)
        Me.Lblidentificacion.TabIndex = 7
        Me.Lblidentificacion.Text = "NUMERO DE IDENTIFICACION"
        '
        'Lblnombrecompleto
        '
        Me.Lblnombrecompleto.AutoSize = True
        Me.Lblnombrecompleto.Location = New System.Drawing.Point(440, 263)
        Me.Lblnombrecompleto.Name = "Lblnombrecompleto"
        Me.Lblnombrecompleto.Size = New System.Drawing.Size(54, 13)
        Me.Lblnombrecompleto.TabIndex = 8
        Me.Lblnombrecompleto.Text = "NOMBRE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(567, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(182, 32)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(38, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Form5_Eliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 371)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Lblnombrecompleto)
        Me.Controls.Add(Me.Lblidentificacion)
        Me.Controls.Add(Me.lblFuncionarioId)
        Me.Controls.Add(Me.Msk_id)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvFuncionarios)
        Me.Name = "Form5_Eliminar"
        Me.Text = "Form_Eliminar"
        CType(Me.DgvFuncionarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvFuncionarios As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Msk_id As TextBox
    Friend WithEvents lblFuncionarioId As TextBox
    Friend WithEvents Lblidentificacion As Label
    Friend WithEvents Lblnombrecompleto As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
