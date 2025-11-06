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
        Me.Msk_id = New System.Windows.Forms.MaskedTextBox()
        Me.Lblsalario_neto = New System.Windows.Forms.Label()
        Me.Lbldeducciones = New System.Windows.Forms.Label()
        Me.Lblsalario_bruto = New System.Windows.Forms.Label()
        Me.Lblextras = New System.Windows.Forms.Label()
        Me.Lblanualidad = New System.Windows.Forms.Label()
        Me.Lblcategoria = New System.Windows.Forms.Label()
        Me.Lblsegundo_apellido = New System.Windows.Forms.Label()
        Me.Lblprimer_apellido = New System.Windows.Forms.Label()
        Me.Lblnombre = New System.Windows.Forms.Label()
        Me.Lblid = New System.Windows.Forms.Label()
        Me.Txtsalario_neto = New System.Windows.Forms.TextBox()
        Me.Txtdeducciones = New System.Windows.Forms.TextBox()
        Me.Txtsalario_bruto = New System.Windows.Forms.TextBox()
        Me.Txtextra = New System.Windows.Forms.TextBox()
        Me.Cmb_anualidad = New System.Windows.Forms.ComboBox()
        Me.Txtsegundo_apellido = New System.Windows.Forms.TextBox()
        Me.Cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.Txtprimer_apellido = New System.Windows.Forms.TextBox()
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.TxtRenta = New System.Windows.Forms.TextBox()
        Me.TxtAsociacion = New System.Windows.Forms.TextBox()
        Me.TxtCCSS = New System.Windows.Forms.TextBox()
        Me.TxtMontoHE = New System.Windows.Forms.TextBox()
        Me.TxtTarifaHE = New System.Windows.Forms.TextBox()
        Me.TxtAnualidades = New System.Windows.Forms.TextBox()
        Me.TxtDE = New System.Windows.Forms.TextBox()
        Me.Lblrenta = New System.Windows.Forms.Label()
        Me.Lblasociacion = New System.Windows.Forms.Label()
        Me.Lbldeduccion_ccss = New System.Windows.Forms.Label()
        Me.Lblmonto_extras = New System.Windows.Forms.Label()
        Me.Lbltarifa_extra = New System.Windows.Forms.Label()
        Me.Lblanualidades = New System.Windows.Forms.Label()
        Me.Lbldedicacion = New System.Windows.Forms.Label()
        Me.Lblsalario_base = New System.Windows.Forms.Label()
        Me.Txtsalario_base = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Msk_id
        '
        Me.Msk_id.Location = New System.Drawing.Point(21, 51)
        Me.Msk_id.Mask = "9-9999-9999"
        Me.Msk_id.Name = "Msk_id"
        Me.Msk_id.Size = New System.Drawing.Size(203, 20)
        Me.Msk_id.TabIndex = 1
        '
        'Lblsalario_neto
        '
        Me.Lblsalario_neto.AutoSize = True
        Me.Lblsalario_neto.Location = New System.Drawing.Point(704, 364)
        Me.Lblsalario_neto.Name = "Lblsalario_neto"
        Me.Lblsalario_neto.Size = New System.Drawing.Size(86, 13)
        Me.Lblsalario_neto.TabIndex = 50
        Me.Lblsalario_neto.Text = "SALARIO NETO"
        '
        'Lbldeducciones
        '
        Me.Lbldeducciones.AutoSize = True
        Me.Lbldeducciones.Location = New System.Drawing.Point(439, 364)
        Me.Lbldeducciones.Name = "Lbldeducciones"
        Me.Lbldeducciones.Size = New System.Drawing.Size(141, 13)
        Me.Lbldeducciones.TabIndex = 49
        Me.Lbldeducciones.Text = "TOTAL DE DEDUCCIONES"
        '
        'Lblsalario_bruto
        '
        Me.Lblsalario_bruto.AutoSize = True
        Me.Lblsalario_bruto.Location = New System.Drawing.Point(205, 364)
        Me.Lblsalario_bruto.Name = "Lblsalario_bruto"
        Me.Lblsalario_bruto.Size = New System.Drawing.Size(94, 13)
        Me.Lblsalario_bruto.TabIndex = 48
        Me.Lblsalario_bruto.Text = "SALARIO BRUTO"
        '
        'Lblextras
        '
        Me.Lblextras.AutoSize = True
        Me.Lblextras.Location = New System.Drawing.Point(581, 126)
        Me.Lblextras.Name = "Lblextras"
        Me.Lblextras.Size = New System.Drawing.Size(146, 13)
        Me.Lblextras.TabIndex = 39
        Me.Lblextras.Text = "DIGITE LAS HORAS EXTRA"
        '
        'Lblanualidad
        '
        Me.Lblanualidad.AutoSize = True
        Me.Lblanualidad.Location = New System.Drawing.Point(316, 126)
        Me.Lblanualidad.Name = "Lblanualidad"
        Me.Lblanualidad.Size = New System.Drawing.Size(139, 13)
        Me.Lblanualidad.TabIndex = 38
        Me.Lblanualidad.Text = "SELECCIONE ANUALIDAD"
        '
        'Lblcategoria
        '
        Me.Lblcategoria.AutoSize = True
        Me.Lblcategoria.Location = New System.Drawing.Point(18, 126)
        Me.Lblcategoria.Name = "Lblcategoria"
        Me.Lblcategoria.Size = New System.Drawing.Size(139, 13)
        Me.Lblcategoria.TabIndex = 37
        Me.Lblcategoria.Text = "SELECCIONE CATEGORIA"
        '
        'Lblsegundo_apellido
        '
        Me.Lblsegundo_apellido.AutoSize = True
        Me.Lblsegundo_apellido.Location = New System.Drawing.Point(855, 24)
        Me.Lblsegundo_apellido.Name = "Lblsegundo_apellido"
        Me.Lblsegundo_apellido.Size = New System.Drawing.Size(116, 13)
        Me.Lblsegundo_apellido.TabIndex = 36
        Me.Lblsegundo_apellido.Text = "SEGUNDO APELLIDO"
        '
        'Lblprimer_apellido
        '
        Me.Lblprimer_apellido.AutoSize = True
        Me.Lblprimer_apellido.Location = New System.Drawing.Point(581, 24)
        Me.Lblprimer_apellido.Name = "Lblprimer_apellido"
        Me.Lblprimer_apellido.Size = New System.Drawing.Size(104, 13)
        Me.Lblprimer_apellido.TabIndex = 35
        Me.Lblprimer_apellido.Text = "PRIMER APELLIDO"
        '
        'Lblnombre
        '
        Me.Lblnombre.AutoSize = True
        Me.Lblnombre.Location = New System.Drawing.Point(306, 24)
        Me.Lblnombre.Name = "Lblnombre"
        Me.Lblnombre.Size = New System.Drawing.Size(54, 13)
        Me.Lblnombre.TabIndex = 34
        Me.Lblnombre.Text = "NOMBRE"
        '
        'Lblid
        '
        Me.Lblid.AutoSize = True
        Me.Lblid.Location = New System.Drawing.Point(18, 24)
        Me.Lblid.Name = "Lblid"
        Me.Lblid.Size = New System.Drawing.Size(92, 13)
        Me.Lblid.TabIndex = 33
        Me.Lblid.Text = "IDENTIFICACION"
        '
        'Txtsalario_neto
        '
        Me.Txtsalario_neto.Location = New System.Drawing.Point(707, 389)
        Me.Txtsalario_neto.Name = "Txtsalario_neto"
        Me.Txtsalario_neto.Size = New System.Drawing.Size(100, 20)
        Me.Txtsalario_neto.TabIndex = 32
        Me.Txtsalario_neto.TabStop = False
        '
        'Txtdeducciones
        '
        Me.Txtdeducciones.Location = New System.Drawing.Point(457, 389)
        Me.Txtdeducciones.Name = "Txtdeducciones"
        Me.Txtdeducciones.Size = New System.Drawing.Size(100, 20)
        Me.Txtdeducciones.TabIndex = 31
        Me.Txtdeducciones.TabStop = False
        '
        'Txtsalario_bruto
        '
        Me.Txtsalario_bruto.Location = New System.Drawing.Point(208, 389)
        Me.Txtsalario_bruto.Name = "Txtsalario_bruto"
        Me.Txtsalario_bruto.Size = New System.Drawing.Size(100, 20)
        Me.Txtsalario_bruto.TabIndex = 30
        Me.Txtsalario_bruto.TabStop = False
        '
        'Txtextra
        '
        Me.Txtextra.Location = New System.Drawing.Point(584, 161)
        Me.Txtextra.Name = "Txtextra"
        Me.Txtextra.Size = New System.Drawing.Size(60, 20)
        Me.Txtextra.TabIndex = 7
        '
        'Cmb_anualidad
        '
        Me.Cmb_anualidad.FormattingEnabled = True
        Me.Cmb_anualidad.Location = New System.Drawing.Point(319, 160)
        Me.Cmb_anualidad.Name = "Cmb_anualidad"
        Me.Cmb_anualidad.Size = New System.Drawing.Size(133, 21)
        Me.Cmb_anualidad.TabIndex = 6
        '
        'Txtsegundo_apellido
        '
        Me.Txtsegundo_apellido.Location = New System.Drawing.Point(858, 51)
        Me.Txtsegundo_apellido.Name = "Txtsegundo_apellido"
        Me.Txtsegundo_apellido.Size = New System.Drawing.Size(203, 20)
        Me.Txtsegundo_apellido.TabIndex = 4
        '
        'Cmb_categoria
        '
        Me.Cmb_categoria.FormattingEnabled = True
        Me.Cmb_categoria.Items.AddRange(New Object() {"OFICINISTA", "TECNICO", "PROFESIONAL"})
        Me.Cmb_categoria.Location = New System.Drawing.Point(21, 160)
        Me.Cmb_categoria.Name = "Cmb_categoria"
        Me.Cmb_categoria.Size = New System.Drawing.Size(203, 21)
        Me.Cmb_categoria.TabIndex = 5
        '
        'Txtprimer_apellido
        '
        Me.Txtprimer_apellido.Location = New System.Drawing.Point(584, 51)
        Me.Txtprimer_apellido.Name = "Txtprimer_apellido"
        Me.Txtprimer_apellido.Size = New System.Drawing.Size(203, 20)
        Me.Txtprimer_apellido.TabIndex = 3
        '
        'Txtnombre
        '
        Me.Txtnombre.Location = New System.Drawing.Point(309, 51)
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(203, 20)
        Me.Txtnombre.TabIndex = 2
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.Lime
        Me.BtnCalcular.Location = New System.Drawing.Point(444, 443)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(136, 81)
        Me.BtnCalcular.TabIndex = 8
        Me.BtnCalcular.Text = "PROCESAR PLANILLA"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'TxtRenta
        '
        Me.TxtRenta.Location = New System.Drawing.Point(944, 313)
        Me.TxtRenta.Name = "TxtRenta"
        Me.TxtRenta.Size = New System.Drawing.Size(100, 20)
        Me.TxtRenta.TabIndex = 57
        Me.TxtRenta.TabStop = False
        '
        'TxtAsociacion
        '
        Me.TxtAsociacion.Location = New System.Drawing.Point(802, 313)
        Me.TxtAsociacion.Name = "TxtAsociacion"
        Me.TxtAsociacion.Size = New System.Drawing.Size(100, 20)
        Me.TxtAsociacion.TabIndex = 56
        Me.TxtAsociacion.TabStop = False
        '
        'TxtCCSS
        '
        Me.TxtCCSS.Location = New System.Drawing.Point(641, 313)
        Me.TxtCCSS.Name = "TxtCCSS"
        Me.TxtCCSS.Size = New System.Drawing.Size(100, 20)
        Me.TxtCCSS.TabIndex = 55
        Me.TxtCCSS.TabStop = False
        '
        'TxtMontoHE
        '
        Me.TxtMontoHE.Location = New System.Drawing.Point(407, 313)
        Me.TxtMontoHE.Name = "TxtMontoHE"
        Me.TxtMontoHE.Size = New System.Drawing.Size(100, 20)
        Me.TxtMontoHE.TabIndex = 54
        Me.TxtMontoHE.TabStop = False
        '
        'TxtTarifaHE
        '
        Me.TxtTarifaHE.Location = New System.Drawing.Point(280, 313)
        Me.TxtTarifaHE.Name = "TxtTarifaHE"
        Me.TxtTarifaHE.Size = New System.Drawing.Size(100, 20)
        Me.TxtTarifaHE.TabIndex = 53
        Me.TxtTarifaHE.TabStop = False
        '
        'TxtAnualidades
        '
        Me.TxtAnualidades.Location = New System.Drawing.Point(161, 313)
        Me.TxtAnualidades.Name = "TxtAnualidades"
        Me.TxtAnualidades.Size = New System.Drawing.Size(100, 20)
        Me.TxtAnualidades.TabIndex = 52
        Me.TxtAnualidades.TabStop = False
        '
        'TxtDE
        '
        Me.TxtDE.Location = New System.Drawing.Point(38, 313)
        Me.TxtDE.Name = "TxtDE"
        Me.TxtDE.Size = New System.Drawing.Size(100, 20)
        Me.TxtDE.TabIndex = 51
        Me.TxtDE.TabStop = False
        '
        'Lblrenta
        '
        Me.Lblrenta.AutoSize = True
        Me.Lblrenta.Location = New System.Drawing.Point(944, 277)
        Me.Lblrenta.Name = "Lblrenta"
        Me.Lblrenta.Size = New System.Drawing.Size(44, 13)
        Me.Lblrenta.TabIndex = 47
        Me.Lblrenta.Text = "RENTA"
        '
        'Lblasociacion
        '
        Me.Lblasociacion.AutoSize = True
        Me.Lblasociacion.Location = New System.Drawing.Point(799, 277)
        Me.Lblasociacion.Name = "Lblasociacion"
        Me.Lblasociacion.Size = New System.Drawing.Size(72, 13)
        Me.Lblasociacion.TabIndex = 46
        Me.Lblasociacion.Text = "ASOCIACION"
        '
        'Lbldeduccion_ccss
        '
        Me.Lbldeduccion_ccss.AutoSize = True
        Me.Lbldeduccion_ccss.Location = New System.Drawing.Point(638, 277)
        Me.Lbldeduccion_ccss.Name = "Lbldeduccion_ccss"
        Me.Lbldeduccion_ccss.Size = New System.Drawing.Size(116, 13)
        Me.Lbldeduccion_ccss.TabIndex = 45
        Me.Lbldeduccion_ccss.Text = "DEDUCCIONES CCSS"
        '
        'Lblmonto_extras
        '
        Me.Lblmonto_extras.AutoSize = True
        Me.Lblmonto_extras.Location = New System.Drawing.Point(404, 277)
        Me.Lblmonto_extras.Name = "Lblmonto_extras"
        Me.Lblmonto_extras.Size = New System.Drawing.Size(93, 13)
        Me.Lblmonto_extras.TabIndex = 44
        Me.Lblmonto_extras.Text = "MONTO EXTRAS"
        '
        'Lbltarifa_extra
        '
        Me.Lbltarifa_extra.AutoSize = True
        Me.Lbltarifa_extra.Location = New System.Drawing.Point(277, 277)
        Me.Lbltarifa_extra.Name = "Lbltarifa_extra"
        Me.Lbltarifa_extra.Size = New System.Drawing.Size(84, 13)
        Me.Lbltarifa_extra.TabIndex = 43
        Me.Lbltarifa_extra.Text = "TARIFA EXTRA"
        '
        'Lblanualidades
        '
        Me.Lblanualidades.AutoSize = True
        Me.Lblanualidades.Location = New System.Drawing.Point(158, 277)
        Me.Lblanualidades.Name = "Lblanualidades"
        Me.Lblanualidades.Size = New System.Drawing.Size(83, 13)
        Me.Lblanualidades.TabIndex = 42
        Me.Lblanualidades.Text = "ANUALIDADES"
        '
        'Lbldedicacion
        '
        Me.Lbldedicacion.AutoSize = True
        Me.Lbldedicacion.Location = New System.Drawing.Point(35, 277)
        Me.Lbldedicacion.Name = "Lbldedicacion"
        Me.Lbldedicacion.Size = New System.Drawing.Size(73, 13)
        Me.Lbldedicacion.TabIndex = 41
        Me.Lbldedicacion.Text = "DEDICACION"
        '
        'Lblsalario_base
        '
        Me.Lblsalario_base.AutoSize = True
        Me.Lblsalario_base.Location = New System.Drawing.Point(23, 198)
        Me.Lblsalario_base.Name = "Lblsalario_base"
        Me.Lblsalario_base.Size = New System.Drawing.Size(84, 13)
        Me.Lblsalario_base.TabIndex = 40
        Me.Lblsalario_base.Text = "SALARIO BASE"
        '
        'Txtsalario_base
        '
        Me.Txtsalario_base.Location = New System.Drawing.Point(21, 223)
        Me.Txtsalario_base.Name = "Txtsalario_base"
        Me.Txtsalario_base.Size = New System.Drawing.Size(100, 20)
        Me.Txtsalario_base.TabIndex = 59
        Me.Txtsalario_base.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 546)
        Me.Controls.Add(Me.Txtsalario_base)
        Me.Controls.Add(Me.Lblsalario_base)
        Me.Controls.Add(Me.TxtRenta)
        Me.Controls.Add(Me.TxtAsociacion)
        Me.Controls.Add(Me.TxtCCSS)
        Me.Controls.Add(Me.TxtMontoHE)
        Me.Controls.Add(Me.TxtTarifaHE)
        Me.Controls.Add(Me.TxtAnualidades)
        Me.Controls.Add(Me.TxtDE)
        Me.Controls.Add(Me.Lblrenta)
        Me.Controls.Add(Me.Lblasociacion)
        Me.Controls.Add(Me.Lbldeduccion_ccss)
        Me.Controls.Add(Me.Lblmonto_extras)
        Me.Controls.Add(Me.Lbltarifa_extra)
        Me.Controls.Add(Me.Lblanualidades)
        Me.Controls.Add(Me.Lbldedicacion)
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
        Me.Controls.Add(Me.BtnCalcular)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Msk_id As MaskedTextBox
    Friend WithEvents Lblsalario_neto As Label
    Friend WithEvents Lbldeducciones As Label
    Friend WithEvents Lblsalario_bruto As Label
    Friend WithEvents Lblextras As Label
    Friend WithEvents Lblanualidad As Label
    Friend WithEvents Lblcategoria As Label
    Friend WithEvents Lblsegundo_apellido As Label
    Friend WithEvents Lblprimer_apellido As Label
    Friend WithEvents Lblnombre As Label
    Friend WithEvents Lblid As Label
    Friend WithEvents Txtsalario_neto As TextBox
    Friend WithEvents Txtdeducciones As TextBox
    Friend WithEvents Txtsalario_bruto As TextBox
    Friend WithEvents Txtextra As TextBox
    Friend WithEvents Cmb_anualidad As ComboBox
    Friend WithEvents Txtsegundo_apellido As TextBox
    Friend WithEvents Cmb_categoria As ComboBox
    Friend WithEvents Txtprimer_apellido As TextBox
    Friend WithEvents Txtnombre As TextBox
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents TxtRenta As TextBox
    Friend WithEvents TxtAsociacion As TextBox
    Friend WithEvents TxtCCSS As TextBox
    Friend WithEvents TxtMontoHE As TextBox
    Friend WithEvents TxtTarifaHE As TextBox
    Friend WithEvents TxtAnualidades As TextBox
    Friend WithEvents TxtDE As TextBox
    Friend WithEvents Lblrenta As Label
    Friend WithEvents Lblasociacion As Label
    Friend WithEvents Lbldeduccion_ccss As Label
    Friend WithEvents Lblmonto_extras As Label
    Friend WithEvents Lbltarifa_extra As Label
    Friend WithEvents Lblanualidades As Label
    Friend WithEvents Lbldedicacion As Label
    Friend WithEvents Lblsalario_base As Label
    Friend WithEvents Txtsalario_base As TextBox
End Class
