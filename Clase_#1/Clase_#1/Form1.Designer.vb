<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Txt_fecha = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Cmb_tipoid = New System.Windows.Forms.ComboBox()
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.Txtprimer_apellido = New System.Windows.Forms.TextBox()
        Me.Msk_id = New System.Windows.Forms.MaskedTextBox()
        Me.Txtcorreo = New System.Windows.Forms.TextBox()
        Me.Dtp_fecha_nacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Txtdireccion = New System.Windows.Forms.TextBox()
        Me.Lbltipoid = New System.Windows.Forms.Label()
        Me.Lblnumeroid = New System.Windows.Forms.Label()
        Me.Lblnombre = New System.Windows.Forms.Label()
        Me.Lblprimer_apellido = New System.Windows.Forms.Label()
        Me.Lblsegundo_apellido = New System.Windows.Forms.Label()
        Me.Lblfecha_nacimiento = New System.Windows.Forms.Label()
        Me.Lblcorreo_electronico = New System.Windows.Forms.Label()
        Me.Lbldireccion = New System.Windows.Forms.Label()
        Me.Grb_captura = New System.Windows.Forms.GroupBox()
        Me.CmbEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.Txtsegundo_apellido = New System.Windows.Forms.TextBox()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.Btnconsultar = New System.Windows.Forms.Button()
        Me.Btnmodificar = New System.Windows.Forms.Button()
        Me.Btneliminar = New System.Windows.Forms.Button()
        Me.Btnsalir = New System.Windows.Forms.Button()
        Me.Grbacciones = New System.Windows.Forms.GroupBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.Dgvpersona = New System.Windows.Forms.DataGridView()
        Me.TIPOIDENTIFICACIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMEROIDENTIFICACIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRIMERAPELLIDODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEGUNDOAPELLIDODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHANACIMIENTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CORREOELECTRONICODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIRECCIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDSECUENCIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGOCIVILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIUDADANOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.II36DB03Q2025DataSet2 = New Clase__1.II36DB03Q2025DataSet2()
        Me.CIUDADANOTableAdapter = New Clase__1.II36DB03Q2025DataSet2TableAdapters.CIUDADANOTableAdapter()
        Me.TxtNombCons = New System.Windows.Forms.TextBox()
        Me.TxtPriApellCons = New System.Windows.Forms.TextBox()
        Me.BtnConsultas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Grb_captura.SuspendLayout()
        Me.Grbacciones.SuspendLayout()
        CType(Me.Dgvpersona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CIUDADANOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.II36DB03Q2025DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txt_fecha
        '
        Me.Txt_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_fecha.Location = New System.Drawing.Point(1163, 19)
        Me.Txt_fecha.Name = "Txt_fecha"
        Me.Txt_fecha.ReadOnly = True
        Me.Txt_fecha.Size = New System.Drawing.Size(268, 26)
        Me.Txt_fecha.TabIndex = 30
        Me.Txt_fecha.TabStop = False
        '
        'Timer1
        '
        '
        'Cmb_tipoid
        '
        Me.Cmb_tipoid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_tipoid.FormattingEnabled = True
        Me.Cmb_tipoid.Items.AddRange(New Object() {"CEDULA NACIONAL", "DIMEX", "PASAPORTE"})
        Me.Cmb_tipoid.Location = New System.Drawing.Point(15, 101)
        Me.Cmb_tipoid.Name = "Cmb_tipoid"
        Me.Cmb_tipoid.Size = New System.Drawing.Size(194, 21)
        Me.Cmb_tipoid.TabIndex = 0
        '
        'Txtnombre
        '
        Me.Txtnombre.Location = New System.Drawing.Point(605, 102)
        Me.Txtnombre.MaxLength = 30
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(223, 20)
        Me.Txtnombre.TabIndex = 2
        '
        'Txtprimer_apellido
        '
        Me.Txtprimer_apellido.Location = New System.Drawing.Point(910, 101)
        Me.Txtprimer_apellido.MaxLength = 30
        Me.Txtprimer_apellido.Name = "Txtprimer_apellido"
        Me.Txtprimer_apellido.Size = New System.Drawing.Size(223, 20)
        Me.Txtprimer_apellido.TabIndex = 3
        '
        'Msk_id
        '
        Me.Msk_id.Location = New System.Drawing.Point(292, 102)
        Me.Msk_id.Name = "Msk_id"
        Me.Msk_id.Size = New System.Drawing.Size(219, 20)
        Me.Msk_id.TabIndex = 1
        '
        'Txtcorreo
        '
        Me.Txtcorreo.Location = New System.Drawing.Point(288, 254)
        Me.Txtcorreo.MaxLength = 50
        Me.Txtcorreo.Name = "Txtcorreo"
        Me.Txtcorreo.Size = New System.Drawing.Size(223, 20)
        Me.Txtcorreo.TabIndex = 6
        '
        'Dtp_fecha_nacimiento
        '
        Me.Dtp_fecha_nacimiento.Location = New System.Drawing.Point(15, 251)
        Me.Dtp_fecha_nacimiento.Name = "Dtp_fecha_nacimiento"
        Me.Dtp_fecha_nacimiento.Size = New System.Drawing.Size(200, 20)
        Me.Dtp_fecha_nacimiento.TabIndex = 5
        '
        'Txtdireccion
        '
        Me.Txtdireccion.Location = New System.Drawing.Point(605, 251)
        Me.Txtdireccion.Multiline = True
        Me.Txtdireccion.Name = "Txtdireccion"
        Me.Txtdireccion.Size = New System.Drawing.Size(800, 87)
        Me.Txtdireccion.TabIndex = 7
        '
        'Lbltipoid
        '
        Me.Lbltipoid.AutoSize = True
        Me.Lbltipoid.Location = New System.Drawing.Point(8, 25)
        Me.Lbltipoid.Name = "Lbltipoid"
        Me.Lbltipoid.Size = New System.Drawing.Size(120, 13)
        Me.Lbltipoid.TabIndex = 10
        Me.Lbltipoid.Text = "TIPO IDENTIFICACION"
        '
        'Lblnumeroid
        '
        Me.Lblnumeroid.AutoSize = True
        Me.Lblnumeroid.Location = New System.Drawing.Point(282, 25)
        Me.Lblnumeroid.Name = "Lblnumeroid"
        Me.Lblnumeroid.Size = New System.Drawing.Size(143, 13)
        Me.Lblnumeroid.TabIndex = 11
        Me.Lblnumeroid.Text = "NUMERO IDENTIFICACION"
        '
        'Lblnombre
        '
        Me.Lblnombre.AutoSize = True
        Me.Lblnombre.Location = New System.Drawing.Point(595, 25)
        Me.Lblnombre.Name = "Lblnombre"
        Me.Lblnombre.Size = New System.Drawing.Size(54, 13)
        Me.Lblnombre.TabIndex = 12
        Me.Lblnombre.Text = "NOMBRE"
        '
        'Lblprimer_apellido
        '
        Me.Lblprimer_apellido.AutoSize = True
        Me.Lblprimer_apellido.Location = New System.Drawing.Point(900, 25)
        Me.Lblprimer_apellido.Name = "Lblprimer_apellido"
        Me.Lblprimer_apellido.Size = New System.Drawing.Size(104, 13)
        Me.Lblprimer_apellido.TabIndex = 13
        Me.Lblprimer_apellido.Text = "PRIMER APELLIDO"
        '
        'Lblsegundo_apellido
        '
        Me.Lblsegundo_apellido.AutoSize = True
        Me.Lblsegundo_apellido.Location = New System.Drawing.Point(1172, 25)
        Me.Lblsegundo_apellido.Name = "Lblsegundo_apellido"
        Me.Lblsegundo_apellido.Size = New System.Drawing.Size(116, 13)
        Me.Lblsegundo_apellido.TabIndex = 14
        Me.Lblsegundo_apellido.Text = "SEGUNDO APELLIDO"
        '
        'Lblfecha_nacimiento
        '
        Me.Lblfecha_nacimiento.AutoSize = True
        Me.Lblfecha_nacimiento.Location = New System.Drawing.Point(8, 175)
        Me.Lblfecha_nacimiento.Name = "Lblfecha_nacimiento"
        Me.Lblfecha_nacimiento.Size = New System.Drawing.Size(112, 13)
        Me.Lblfecha_nacimiento.TabIndex = 15
        Me.Lblfecha_nacimiento.Text = "FECHA NACIMIENTO"
        '
        'Lblcorreo_electronico
        '
        Me.Lblcorreo_electronico.AutoSize = True
        Me.Lblcorreo_electronico.Location = New System.Drawing.Point(282, 175)
        Me.Lblcorreo_electronico.Name = "Lblcorreo_electronico"
        Me.Lblcorreo_electronico.Size = New System.Drawing.Size(132, 13)
        Me.Lblcorreo_electronico.TabIndex = 16
        Me.Lblcorreo_electronico.Text = "CORREO ELECTRONICO"
        '
        'Lbldireccion
        '
        Me.Lbldireccion.AutoSize = True
        Me.Lbldireccion.Location = New System.Drawing.Point(595, 175)
        Me.Lbldireccion.Name = "Lbldireccion"
        Me.Lbldireccion.Size = New System.Drawing.Size(66, 13)
        Me.Lbldireccion.TabIndex = 17
        Me.Lbldireccion.Text = "DIRECCION"
        '
        'Grb_captura
        '
        Me.Grb_captura.BackColor = System.Drawing.Color.CadetBlue
        Me.Grb_captura.Controls.Add(Me.CmbEstadoCivil)
        Me.Grb_captura.Controls.Add(Me.LblEstado)
        Me.Grb_captura.Controls.Add(Me.Lbldireccion)
        Me.Grb_captura.Controls.Add(Me.Lblcorreo_electronico)
        Me.Grb_captura.Controls.Add(Me.Lblsegundo_apellido)
        Me.Grb_captura.Controls.Add(Me.Lblfecha_nacimiento)
        Me.Grb_captura.Controls.Add(Me.Lblprimer_apellido)
        Me.Grb_captura.Controls.Add(Me.Lbltipoid)
        Me.Grb_captura.Controls.Add(Me.Lblnumeroid)
        Me.Grb_captura.Controls.Add(Me.Lblnombre)
        Me.Grb_captura.Location = New System.Drawing.Point(7, 51)
        Me.Grb_captura.Name = "Grb_captura"
        Me.Grb_captura.Size = New System.Drawing.Size(1423, 332)
        Me.Grb_captura.TabIndex = 100
        Me.Grb_captura.TabStop = False
        Me.Grb_captura.Text = "Datos Estudiante"
        '
        'CmbEstadoCivil
        '
        Me.CmbEstadoCivil.FormattingEnabled = True
        Me.CmbEstadoCivil.Location = New System.Drawing.Point(97, 261)
        Me.CmbEstadoCivil.Name = "CmbEstadoCivil"
        Me.CmbEstadoCivil.Size = New System.Drawing.Size(121, 21)
        Me.CmbEstadoCivil.TabIndex = 19
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Location = New System.Drawing.Point(11, 261)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(80, 13)
        Me.LblEstado.TabIndex = 18
        Me.LblEstado.Text = "ESTADO CIVIL"
        '
        'Txtsegundo_apellido
        '
        Me.Txtsegundo_apellido.Location = New System.Drawing.Point(1182, 101)
        Me.Txtsegundo_apellido.MaxLength = 30
        Me.Txtsegundo_apellido.Name = "Txtsegundo_apellido"
        Me.Txtsegundo_apellido.Size = New System.Drawing.Size(223, 20)
        Me.Txtsegundo_apellido.TabIndex = 4
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Location = New System.Drawing.Point(25, 20)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(102, 42)
        Me.BtnInsertar.TabIndex = 8
        Me.BtnInsertar.Text = "&Insertar"
        Me.BtnInsertar.UseVisualStyleBackColor = True
        '
        'Btnconsultar
        '
        Me.Btnconsultar.Location = New System.Drawing.Point(173, 20)
        Me.Btnconsultar.Name = "Btnconsultar"
        Me.Btnconsultar.Size = New System.Drawing.Size(102, 42)
        Me.Btnconsultar.TabIndex = 9
        Me.Btnconsultar.Text = "&Consultar"
        Me.Btnconsultar.UseVisualStyleBackColor = True
        '
        'Btnmodificar
        '
        Me.Btnmodificar.Location = New System.Drawing.Point(321, 20)
        Me.Btnmodificar.Name = "Btnmodificar"
        Me.Btnmodificar.Size = New System.Drawing.Size(102, 42)
        Me.Btnmodificar.TabIndex = 10
        Me.Btnmodificar.Text = "&Modificar"
        Me.Btnmodificar.UseVisualStyleBackColor = True
        '
        'Btneliminar
        '
        Me.Btneliminar.Location = New System.Drawing.Point(473, 20)
        Me.Btneliminar.Name = "Btneliminar"
        Me.Btneliminar.Size = New System.Drawing.Size(102, 42)
        Me.Btneliminar.TabIndex = 11
        Me.Btneliminar.Text = "&Eliminar"
        Me.Btneliminar.UseVisualStyleBackColor = True
        '
        'Btnsalir
        '
        Me.Btnsalir.Location = New System.Drawing.Point(773, 20)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(102, 42)
        Me.Btnsalir.TabIndex = 12
        Me.Btnsalir.Text = "&Salir"
        Me.Btnsalir.UseVisualStyleBackColor = True
        '
        'Grbacciones
        '
        Me.Grbacciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Grbacciones.Controls.Add(Me.BtnLimpiar)
        Me.Grbacciones.Controls.Add(Me.Btnconsultar)
        Me.Grbacciones.Controls.Add(Me.Btnsalir)
        Me.Grbacciones.Controls.Add(Me.BtnInsertar)
        Me.Grbacciones.Controls.Add(Me.Btnmodificar)
        Me.Grbacciones.Controls.Add(Me.Btneliminar)
        Me.Grbacciones.Location = New System.Drawing.Point(269, 650)
        Me.Grbacciones.Name = "Grbacciones"
        Me.Grbacciones.Size = New System.Drawing.Size(902, 79)
        Me.Grbacciones.TabIndex = 24
        Me.Grbacciones.TabStop = False
        Me.Grbacciones.Text = "Acciones"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(625, 20)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(102, 42)
        Me.BtnLimpiar.TabIndex = 13
        Me.BtnLimpiar.Text = "&Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'Dgvpersona
        '
        Me.Dgvpersona.AllowUserToOrderColumns = True
        Me.Dgvpersona.AutoGenerateColumns = False
        Me.Dgvpersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvpersona.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TIPOIDENTIFICACIONDataGridViewTextBoxColumn, Me.NUMEROIDENTIFICACIONDataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.PRIMERAPELLIDODataGridViewTextBoxColumn, Me.SEGUNDOAPELLIDODataGridViewTextBoxColumn, Me.FECHANACIMIENTODataGridViewTextBoxColumn, Me.CORREOELECTRONICODataGridViewTextBoxColumn, Me.DIRECCIONDataGridViewTextBoxColumn, Me.IDSECUENCIADataGridViewTextBoxColumn, Me.CODIGOCIVILDataGridViewTextBoxColumn})
        Me.Dgvpersona.DataSource = Me.CIUDADANOBindingSource
        Me.Dgvpersona.Location = New System.Drawing.Point(196, 494)
        Me.Dgvpersona.Name = "Dgvpersona"
        Me.Dgvpersona.Size = New System.Drawing.Size(1044, 150)
        Me.Dgvpersona.TabIndex = 101
        '
        'TIPOIDENTIFICACIONDataGridViewTextBoxColumn
        '
        Me.TIPOIDENTIFICACIONDataGridViewTextBoxColumn.DataPropertyName = "TIPO_IDENTIFICACION"
        Me.TIPOIDENTIFICACIONDataGridViewTextBoxColumn.HeaderText = "TIPO_IDENTIFICACION"
        Me.TIPOIDENTIFICACIONDataGridViewTextBoxColumn.Name = "TIPOIDENTIFICACIONDataGridViewTextBoxColumn"
        '
        'NUMEROIDENTIFICACIONDataGridViewTextBoxColumn
        '
        Me.NUMEROIDENTIFICACIONDataGridViewTextBoxColumn.DataPropertyName = "NUMERO_IDENTIFICACION"
        Me.NUMEROIDENTIFICACIONDataGridViewTextBoxColumn.HeaderText = "NUMERO_IDENTIFICACION"
        Me.NUMEROIDENTIFICACIONDataGridViewTextBoxColumn.Name = "NUMEROIDENTIFICACIONDataGridViewTextBoxColumn"
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        '
        'PRIMERAPELLIDODataGridViewTextBoxColumn
        '
        Me.PRIMERAPELLIDODataGridViewTextBoxColumn.DataPropertyName = "PRIMER_APELLIDO"
        Me.PRIMERAPELLIDODataGridViewTextBoxColumn.HeaderText = "PRIMER_APELLIDO"
        Me.PRIMERAPELLIDODataGridViewTextBoxColumn.Name = "PRIMERAPELLIDODataGridViewTextBoxColumn"
        '
        'SEGUNDOAPELLIDODataGridViewTextBoxColumn
        '
        Me.SEGUNDOAPELLIDODataGridViewTextBoxColumn.DataPropertyName = "SEGUNDO_APELLIDO"
        Me.SEGUNDOAPELLIDODataGridViewTextBoxColumn.HeaderText = "SEGUNDO_APELLIDO"
        Me.SEGUNDOAPELLIDODataGridViewTextBoxColumn.Name = "SEGUNDOAPELLIDODataGridViewTextBoxColumn"
        '
        'FECHANACIMIENTODataGridViewTextBoxColumn
        '
        Me.FECHANACIMIENTODataGridViewTextBoxColumn.DataPropertyName = "FECHA_NACIMIENTO"
        Me.FECHANACIMIENTODataGridViewTextBoxColumn.HeaderText = "FECHA_NACIMIENTO"
        Me.FECHANACIMIENTODataGridViewTextBoxColumn.Name = "FECHANACIMIENTODataGridViewTextBoxColumn"
        '
        'CORREOELECTRONICODataGridViewTextBoxColumn
        '
        Me.CORREOELECTRONICODataGridViewTextBoxColumn.DataPropertyName = "CORREO_ELECTRONICO"
        Me.CORREOELECTRONICODataGridViewTextBoxColumn.HeaderText = "CORREO_ELECTRONICO"
        Me.CORREOELECTRONICODataGridViewTextBoxColumn.Name = "CORREOELECTRONICODataGridViewTextBoxColumn"
        '
        'DIRECCIONDataGridViewTextBoxColumn
        '
        Me.DIRECCIONDataGridViewTextBoxColumn.DataPropertyName = "DIRECCION"
        Me.DIRECCIONDataGridViewTextBoxColumn.HeaderText = "DIRECCION"
        Me.DIRECCIONDataGridViewTextBoxColumn.Name = "DIRECCIONDataGridViewTextBoxColumn"
        '
        'IDSECUENCIADataGridViewTextBoxColumn
        '
        Me.IDSECUENCIADataGridViewTextBoxColumn.DataPropertyName = "ID_SECUENCIA"
        Me.IDSECUENCIADataGridViewTextBoxColumn.HeaderText = "ID_SECUENCIA"
        Me.IDSECUENCIADataGridViewTextBoxColumn.Name = "IDSECUENCIADataGridViewTextBoxColumn"
        Me.IDSECUENCIADataGridViewTextBoxColumn.ReadOnly = True
        '
        'CODIGOCIVILDataGridViewTextBoxColumn
        '
        Me.CODIGOCIVILDataGridViewTextBoxColumn.DataPropertyName = "CODIGO_CIVIL"
        Me.CODIGOCIVILDataGridViewTextBoxColumn.HeaderText = "CODIGO_CIVIL"
        Me.CODIGOCIVILDataGridViewTextBoxColumn.Name = "CODIGOCIVILDataGridViewTextBoxColumn"
        '
        'CIUDADANOBindingSource
        '
        Me.CIUDADANOBindingSource.DataMember = "CIUDADANO"
        Me.CIUDADANOBindingSource.DataSource = Me.II36DB03Q2025DataSet2
        '
        'II36DB03Q2025DataSet2
        '
        Me.II36DB03Q2025DataSet2.DataSetName = "II36DB03Q2025DataSet2"
        Me.II36DB03Q2025DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CIUDADANOTableAdapter
        '
        Me.CIUDADANOTableAdapter.ClearBeforeFill = True
        '
        'TxtNombCons
        '
        Me.TxtNombCons.Location = New System.Drawing.Point(482, 456)
        Me.TxtNombCons.Name = "TxtNombCons"
        Me.TxtNombCons.Size = New System.Drawing.Size(127, 20)
        Me.TxtNombCons.TabIndex = 102
        '
        'TxtPriApellCons
        '
        Me.TxtPriApellCons.Location = New System.Drawing.Point(680, 456)
        Me.TxtPriApellCons.Name = "TxtPriApellCons"
        Me.TxtPriApellCons.Size = New System.Drawing.Size(137, 20)
        Me.TxtPriApellCons.TabIndex = 103
        '
        'BtnConsultas
        '
        Me.BtnConsultas.Location = New System.Drawing.Point(884, 435)
        Me.BtnConsultas.Name = "BtnConsultas"
        Me.BtnConsultas.Size = New System.Drawing.Size(112, 41)
        Me.BtnConsultas.TabIndex = 104
        Me.BtnConsultas.Text = "&Consultas"
        Me.BtnConsultas.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(479, 435)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "NOMBRE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(677, 435)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "PRIMER APELLIDO"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1439, 741)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnConsultas)
        Me.Controls.Add(Me.TxtPriApellCons)
        Me.Controls.Add(Me.TxtNombCons)
        Me.Controls.Add(Me.Dgvpersona)
        Me.Controls.Add(Me.Txtsegundo_apellido)
        Me.Controls.Add(Me.Txtdireccion)
        Me.Controls.Add(Me.Dtp_fecha_nacimiento)
        Me.Controls.Add(Me.Txtcorreo)
        Me.Controls.Add(Me.Msk_id)
        Me.Controls.Add(Me.Txtprimer_apellido)
        Me.Controls.Add(Me.Txtnombre)
        Me.Controls.Add(Me.Cmb_tipoid)
        Me.Controls.Add(Me.Txt_fecha)
        Me.Controls.Add(Me.Grb_captura)
        Me.Controls.Add(Me.Grbacciones)
        Me.Name = "Form1"
        Me.Text = "Clase#1"
        Me.Grb_captura.ResumeLayout(False)
        Me.Grb_captura.PerformLayout()
        Me.Grbacciones.ResumeLayout(False)
        CType(Me.Dgvpersona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CIUDADANOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.II36DB03Q2025DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_fecha As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Cmb_tipoid As ComboBox
    Friend WithEvents Txtnombre As TextBox
    Friend WithEvents Txtprimer_apellido As TextBox
    Friend WithEvents Msk_id As MaskedTextBox
    Friend WithEvents Txtcorreo As TextBox
    Friend WithEvents Dtp_fecha_nacimiento As DateTimePicker
    Friend WithEvents Txtdireccion As TextBox
    Friend WithEvents Lbltipoid As Label
    Friend WithEvents Lblnumeroid As Label
    Friend WithEvents Lblnombre As Label
    Friend WithEvents Lblprimer_apellido As Label
    Friend WithEvents Lblsegundo_apellido As Label
    Friend WithEvents Lblfecha_nacimiento As Label
    Friend WithEvents Lblcorreo_electronico As Label
    Friend WithEvents Lbldireccion As Label
    Friend WithEvents Grb_captura As GroupBox
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents Btnconsultar As Button
    Friend WithEvents Btnmodificar As Button
    Friend WithEvents Btneliminar As Button
    Friend WithEvents Btnsalir As Button
    Friend WithEvents Grbacciones As GroupBox
    Friend WithEvents Txtsegundo_apellido As TextBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents CmbEstadoCivil As ComboBox
    Friend WithEvents LblEstado As Label
    Friend WithEvents Dgvpersona As DataGridView
    Friend WithEvents II36DB03Q2025DataSet2 As II36DB03Q2025DataSet2
    Friend WithEvents CIUDADANOBindingSource As BindingSource
    Friend WithEvents CIUDADANOTableAdapter As II36DB03Q2025DataSet2TableAdapters.CIUDADANOTableAdapter
    Friend WithEvents TIPOIDENTIFICACIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NUMEROIDENTIFICACIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRIMERAPELLIDODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SEGUNDOAPELLIDODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FECHANACIMIENTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CORREOELECTRONICODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DIRECCIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDSECUENCIADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODIGOCIVILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TxtNombCons As TextBox
    Friend WithEvents TxtPriApellCons As TextBox
    Friend WithEvents BtnConsultas As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
