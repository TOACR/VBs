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
        Me.components = New System.ComponentModel.Container()
        Me.Btnprocesar = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.Txtprimer_apellido = New System.Windows.Forms.TextBox()
        Me.Cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.Txtsegundo_apellido = New System.Windows.Forms.TextBox()
        Me.Cmb_anualidad = New System.Windows.Forms.ComboBox()
        Me.Txtextra = New System.Windows.Forms.TextBox()
        Me.Txtsalario_bruto = New System.Windows.Forms.TextBox()
        Me.Txtdeducciones = New System.Windows.Forms.TextBox()
        Me.Txtsalario_neto = New System.Windows.Forms.TextBox()
        Me.Lblid = New System.Windows.Forms.Label()
        Me.Lblnombre = New System.Windows.Forms.Label()
        Me.Lblprimer_apellido = New System.Windows.Forms.Label()
        Me.Lblsegundo_apellido = New System.Windows.Forms.Label()
        Me.Lblcategoria = New System.Windows.Forms.Label()
        Me.Lblanualidad = New System.Windows.Forms.Label()
        Me.Lblextras = New System.Windows.Forms.Label()
        Me.Lblsalario_bruto = New System.Windows.Forms.Label()
        Me.Lbldeducciones = New System.Windows.Forms.Label()
        Me.Lblsalario_neto = New System.Windows.Forms.Label()
        Me.Msk_id = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDE = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btnprocesar
        '
        Me.Btnprocesar.BackColor = System.Drawing.Color.Lime
        Me.Btnprocesar.Location = New System.Drawing.Point(449, 636)
        Me.Btnprocesar.Name = "Btnprocesar"
        Me.Btnprocesar.Size = New System.Drawing.Size(136, 81)
        Me.Btnprocesar.TabIndex = 0
        Me.Btnprocesar.Text = "PROCESAR PLANILLA"
        Me.Btnprocesar.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Txtnombre
        '
        Me.Txtnombre.Location = New System.Drawing.Point(329, 83)
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(203, 20)
        Me.Txtnombre.TabIndex = 3
        '
        'Txtprimer_apellido
        '
        Me.Txtprimer_apellido.Location = New System.Drawing.Point(604, 83)
        Me.Txtprimer_apellido.Name = "Txtprimer_apellido"
        Me.Txtprimer_apellido.Size = New System.Drawing.Size(203, 20)
        Me.Txtprimer_apellido.TabIndex = 4
        '
        'Cmb_categoria
        '
        Me.Cmb_categoria.FormattingEnabled = True
        Me.Cmb_categoria.Items.AddRange(New Object() {"OFICINISTA", "TECNICO", "PROFESIONAL"})
        Me.Cmb_categoria.Location = New System.Drawing.Point(41, 192)
        Me.Cmb_categoria.Name = "Cmb_categoria"
        Me.Cmb_categoria.Size = New System.Drawing.Size(203, 21)
        Me.Cmb_categoria.TabIndex = 5
        '
        'Txtsegundo_apellido
        '
        Me.Txtsegundo_apellido.Location = New System.Drawing.Point(878, 83)
        Me.Txtsegundo_apellido.Name = "Txtsegundo_apellido"
        Me.Txtsegundo_apellido.Size = New System.Drawing.Size(203, 20)
        Me.Txtsegundo_apellido.TabIndex = 6
        '
        'Cmb_anualidad
        '
        Me.Cmb_anualidad.FormattingEnabled = True
        Me.Cmb_anualidad.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.Cmb_anualidad.Location = New System.Drawing.Point(339, 192)
        Me.Cmb_anualidad.Name = "Cmb_anualidad"
        Me.Cmb_anualidad.Size = New System.Drawing.Size(133, 21)
        Me.Cmb_anualidad.TabIndex = 7
        '
        'Txtextra
        '
        Me.Txtextra.Location = New System.Drawing.Point(604, 193)
        Me.Txtextra.Name = "Txtextra"
        Me.Txtextra.Size = New System.Drawing.Size(60, 20)
        Me.Txtextra.TabIndex = 8
        '
        'Txtsalario_bruto
        '
        Me.Txtsalario_bruto.Location = New System.Drawing.Point(218, 560)
        Me.Txtsalario_bruto.Name = "Txtsalario_bruto"
        Me.Txtsalario_bruto.Size = New System.Drawing.Size(100, 20)
        Me.Txtsalario_bruto.TabIndex = 9
        '
        'Txtdeducciones
        '
        Me.Txtdeducciones.Location = New System.Drawing.Point(469, 560)
        Me.Txtdeducciones.Name = "Txtdeducciones"
        Me.Txtdeducciones.Size = New System.Drawing.Size(100, 20)
        Me.Txtdeducciones.TabIndex = 10
        '
        'Txtsalario_neto
        '
        Me.Txtsalario_neto.Location = New System.Drawing.Point(756, 560)
        Me.Txtsalario_neto.Name = "Txtsalario_neto"
        Me.Txtsalario_neto.Size = New System.Drawing.Size(100, 20)
        Me.Txtsalario_neto.TabIndex = 11
        '
        'Lblid
        '
        Me.Lblid.AutoSize = True
        Me.Lblid.Location = New System.Drawing.Point(38, 56)
        Me.Lblid.Name = "Lblid"
        Me.Lblid.Size = New System.Drawing.Size(92, 13)
        Me.Lblid.TabIndex = 12
        Me.Lblid.Text = "IDENTIFICACION"
        '
        'Lblnombre
        '
        Me.Lblnombre.AutoSize = True
        Me.Lblnombre.Location = New System.Drawing.Point(326, 56)
        Me.Lblnombre.Name = "Lblnombre"
        Me.Lblnombre.Size = New System.Drawing.Size(54, 13)
        Me.Lblnombre.TabIndex = 13
        Me.Lblnombre.Text = "NOMBRE"
        '
        'Lblprimer_apellido
        '
        Me.Lblprimer_apellido.AutoSize = True
        Me.Lblprimer_apellido.Location = New System.Drawing.Point(601, 56)
        Me.Lblprimer_apellido.Name = "Lblprimer_apellido"
        Me.Lblprimer_apellido.Size = New System.Drawing.Size(104, 13)
        Me.Lblprimer_apellido.TabIndex = 14
        Me.Lblprimer_apellido.Text = "PRIMER APELLIDO"
        '
        'Lblsegundo_apellido
        '
        Me.Lblsegundo_apellido.AutoSize = True
        Me.Lblsegundo_apellido.Location = New System.Drawing.Point(875, 56)
        Me.Lblsegundo_apellido.Name = "Lblsegundo_apellido"
        Me.Lblsegundo_apellido.Size = New System.Drawing.Size(116, 13)
        Me.Lblsegundo_apellido.TabIndex = 15
        Me.Lblsegundo_apellido.Text = "SEGUNDO APELLIDO"
        '
        'Lblcategoria
        '
        Me.Lblcategoria.AutoSize = True
        Me.Lblcategoria.Location = New System.Drawing.Point(38, 158)
        Me.Lblcategoria.Name = "Lblcategoria"
        Me.Lblcategoria.Size = New System.Drawing.Size(139, 13)
        Me.Lblcategoria.TabIndex = 16
        Me.Lblcategoria.Text = "SELECCIONE CATEGORIA"
        '
        'Lblanualidad
        '
        Me.Lblanualidad.AutoSize = True
        Me.Lblanualidad.Location = New System.Drawing.Point(336, 158)
        Me.Lblanualidad.Name = "Lblanualidad"
        Me.Lblanualidad.Size = New System.Drawing.Size(139, 13)
        Me.Lblanualidad.TabIndex = 17
        Me.Lblanualidad.Text = "SELECCIONE ANUALIDAD"
        '
        'Lblextras
        '
        Me.Lblextras.AutoSize = True
        Me.Lblextras.Location = New System.Drawing.Point(601, 158)
        Me.Lblextras.Name = "Lblextras"
        Me.Lblextras.Size = New System.Drawing.Size(146, 13)
        Me.Lblextras.TabIndex = 18
        Me.Lblextras.Text = "DIGITE LAS HORAS EXTRA"
        '
        'Lblsalario_bruto
        '
        Me.Lblsalario_bruto.AutoSize = True
        Me.Lblsalario_bruto.Location = New System.Drawing.Point(215, 528)
        Me.Lblsalario_bruto.Name = "Lblsalario_bruto"
        Me.Lblsalario_bruto.Size = New System.Drawing.Size(94, 13)
        Me.Lblsalario_bruto.TabIndex = 19
        Me.Lblsalario_bruto.Text = "SALARIO BRUTO"
        '
        'Lbldeducciones
        '
        Me.Lbldeducciones.AutoSize = True
        Me.Lbldeducciones.Location = New System.Drawing.Point(466, 528)
        Me.Lbldeducciones.Name = "Lbldeducciones"
        Me.Lbldeducciones.Size = New System.Drawing.Size(141, 13)
        Me.Lbldeducciones.TabIndex = 20
        Me.Lbldeducciones.Text = "TOTAL DE DEDUCCIONES"
        '
        'Lblsalario_neto
        '
        Me.Lblsalario_neto.AutoSize = True
        Me.Lblsalario_neto.Location = New System.Drawing.Point(753, 528)
        Me.Lblsalario_neto.Name = "Lblsalario_neto"
        Me.Lblsalario_neto.Size = New System.Drawing.Size(86, 13)
        Me.Lblsalario_neto.TabIndex = 21
        Me.Lblsalario_neto.Text = "SALARIO NETO"
        '
        'Msk_id
        '
        Me.Msk_id.Location = New System.Drawing.Point(41, 83)
        Me.Msk_id.Mask = "9-9999-9999"
        Me.Msk_id.Name = "Msk_id"
        Me.Msk_id.Size = New System.Drawing.Size(203, 20)
        Me.Msk_id.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "DEDICACION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 316)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "ANUALIDADES"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(280, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "TARIFA EXTRA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(407, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "MONTO EXTRAS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(641, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "DEDUCCIONES CCSS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(802, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "ASOCIACION"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(947, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "RENTA"
        '
        'TxtDE
        '
        Me.TxtDE.Location = New System.Drawing.Point(41, 352)
        Me.TxtDE.Name = "TxtDE"
        Me.TxtDE.Size = New System.Drawing.Size(100, 20)
        Me.TxtDE.TabIndex = 30
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(164, 352)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 31
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(283, 352)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 32
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(410, 352)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 33
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(644, 352)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 34
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(805, 352)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 35
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(947, 352)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 36
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1118, 738)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TxtDE)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Msk_id)
        Me.Controls.Add(Me.Lblsalario_neto)
        Me.Controls.Add(Me.Lbldeducciones)
        Me.Controls.Add(Me.Lblsalario_bruto)
        Me.Controls.Add(Me.Lblextras)
        Me.Controls.Add(Me.Lblanualidad)
        Me.Controls.Add(Me.Lblcategoria)
        Me.Controls.Add(Me.Lblsegundo_apellido)
        Me.Controls.Add(Me.Lblprimer_apellido)
        Me.Controls.Add(Me.Lblnombre)
        Me.Controls.Add(Me.Lblid)
        Me.Controls.Add(Me.Txtsalario_neto)
        Me.Controls.Add(Me.Txtdeducciones)
        Me.Controls.Add(Me.Txtsalario_bruto)
        Me.Controls.Add(Me.Txtextra)
        Me.Controls.Add(Me.Cmb_anualidad)
        Me.Controls.Add(Me.Txtsegundo_apellido)
        Me.Controls.Add(Me.Cmb_categoria)
        Me.Controls.Add(Me.Txtprimer_apellido)
        Me.Controls.Add(Me.Txtnombre)
        Me.Controls.Add(Me.Btnprocesar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btnprocesar As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Txtnombre As TextBox
    Friend WithEvents Txtprimer_apellido As TextBox
    Friend WithEvents Cmb_categoria As ComboBox
    Friend WithEvents Txtsegundo_apellido As TextBox
    Friend WithEvents Cmb_anualidad As ComboBox
    Friend WithEvents Txtextra As TextBox
    Friend WithEvents Txtsalario_bruto As TextBox
    Friend WithEvents Txtdeducciones As TextBox
    Friend WithEvents Txtsalario_neto As TextBox
    Friend WithEvents Lblid As Label
    Friend WithEvents Lblnombre As Label
    Friend WithEvents Lblprimer_apellido As Label
    Friend WithEvents Lblsegundo_apellido As Label
    Friend WithEvents Lblcategoria As Label
    Friend WithEvents Lblanualidad As Label
    Friend WithEvents Lblextras As Label
    Friend WithEvents Lblsalario_bruto As Label
    Friend WithEvents Lbldeducciones As Label
    Friend WithEvents Lblsalario_neto As Label
    Friend WithEvents Msk_id As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtDE As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
End Class
