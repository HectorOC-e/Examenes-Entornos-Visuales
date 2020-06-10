<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PruebasRealizadas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PruebasRealizadas))
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkMuerto = New System.Windows.Forms.CheckBox()
        Me.chkRecuperado = New System.Windows.Forms.CheckBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkNegativa = New System.Windows.Forms.CheckBox()
        Me.chkPositiva = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbCasosDep = New System.Windows.Forms.ComboBox()
        Me.lstbHistorialCasos = New System.Windows.Forms.ListBox()
        Me.txtTotalActivos = New System.Windows.Forms.TextBox()
        Me.txtRecuperado = New System.Windows.Forms.TextBox()
        Me.txtNegativo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMuertos = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDepartamento.ForeColor = System.Drawing.Color.DimGray
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Items.AddRange(New Object() {"Atlántida", "Choluteca", "Colón", "Comayagua", "Copán", "Cortés", "El Paraíso", "Francisco Morazán", "Gracias a Dios", "Intibucá", "Islas de la Bahía", "La Paz", "Lempira", "Ocotepeque", "Olancho", "Santa Bárbara", "Valle", "Yoro"})
        Me.cmbDepartamento.Location = New System.Drawing.Point(190, 129)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(175, 29)
        Me.cmbDepartamento.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.chkMuerto)
        Me.GroupBox1.Controls.Add(Me.chkRecuperado)
        Me.GroupBox1.Controls.Add(Me.chkActivo)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.chkNegativa)
        Me.GroupBox1.Controls.Add(Me.chkPositiva)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMunicipio)
        Me.GroupBox1.Controls.Add(Me.txtEdad)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbDepartamento)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Location = New System.Drawing.Point(37, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(545, 598)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese los datos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 287)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 21)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Estado Del paciente"
        '
        'chkMuerto
        '
        Me.chkMuerto.AutoSize = True
        Me.chkMuerto.Enabled = False
        Me.chkMuerto.ForeColor = System.Drawing.Color.DimGray
        Me.chkMuerto.Location = New System.Drawing.Point(347, 316)
        Me.chkMuerto.Name = "chkMuerto"
        Me.chkMuerto.Size = New System.Drawing.Size(89, 25)
        Me.chkMuerto.TabIndex = 16
        Me.chkMuerto.Text = "Muerto"
        Me.chkMuerto.UseVisualStyleBackColor = True
        '
        'chkRecuperado
        '
        Me.chkRecuperado.AutoSize = True
        Me.chkRecuperado.Enabled = False
        Me.chkRecuperado.ForeColor = System.Drawing.Color.DimGray
        Me.chkRecuperado.Location = New System.Drawing.Point(189, 316)
        Me.chkRecuperado.Name = "chkRecuperado"
        Me.chkRecuperado.Size = New System.Drawing.Size(133, 25)
        Me.chkRecuperado.TabIndex = 15
        Me.chkRecuperado.Text = "Recuperado"
        Me.chkRecuperado.UseVisualStyleBackColor = True
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Enabled = False
        Me.chkActivo.ForeColor = System.Drawing.Color.DimGray
        Me.chkActivo.Location = New System.Drawing.Point(40, 316)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(86, 25)
        Me.chkActivo.TabIndex = 14
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Location = New System.Drawing.Point(108, 535)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(184, 38)
        Me.btnAgregar.TabIndex = 13
        Me.btnAgregar.Text = "Agregar Caso"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 386)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 84)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Breve " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "descripción" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del estado " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del paciente"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.ForeColor = System.Drawing.Color.DimGray
        Me.txtDescripcion.Location = New System.Drawing.Point(175, 370)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(336, 140)
        Me.txtDescripcion.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Estado de la prueba"
        '
        'chkNegativa
        '
        Me.chkNegativa.AutoSize = True
        Me.chkNegativa.Location = New System.Drawing.Point(189, 251)
        Me.chkNegativa.Name = "chkNegativa"
        Me.chkNegativa.Size = New System.Drawing.Size(108, 25)
        Me.chkNegativa.TabIndex = 9
        Me.chkNegativa.Text = "Negativa"
        Me.chkNegativa.UseVisualStyleBackColor = True
        '
        'chkPositiva
        '
        Me.chkPositiva.AutoSize = True
        Me.chkPositiva.Location = New System.Drawing.Point(40, 251)
        Me.chkPositiva.Name = "chkPositiva"
        Me.chkPositiva.Size = New System.Drawing.Size(94, 25)
        Me.chkPositiva.TabIndex = 8
        Me.chkPositiva.Text = "Positiva"
        Me.chkPositiva.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Municipio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Edad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre"
        '
        'txtMunicipio
        '
        Me.txtMunicipio.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtMunicipio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMunicipio.ForeColor = System.Drawing.Color.DimGray
        Me.txtMunicipio.Location = New System.Drawing.Point(190, 175)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(100, 28)
        Me.txtMunicipio.TabIndex = 4
        '
        'txtEdad
        '
        Me.txtEdad.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEdad.ForeColor = System.Drawing.Color.DimGray
        Me.txtEdad.Location = New System.Drawing.Point(190, 83)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(100, 28)
        Me.txtEdad.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.ForeColor = System.Drawing.Color.DimGray
        Me.txtNombre.Location = New System.Drawing.Point(190, 37)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(255, 28)
        Me.txtNombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Departamento"
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cmbCasosDep)
        Me.GroupBox2.Controls.Add(Me.lstbHistorialCasos)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox2.Location = New System.Drawing.Point(751, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(577, 598)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Historial de Casos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(37, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(178, 21)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Elegir Departamento"
        '
        'cmbCasosDep
        '
        Me.cmbCasosDep.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbCasosDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCasosDep.ForeColor = System.Drawing.Color.DimGray
        Me.cmbCasosDep.FormattingEnabled = True
        Me.cmbCasosDep.Items.AddRange(New Object() {"Atlántida", "Choluteca", "Colón", "Comayagua", "Copán", "Cortés", "El Paraíso", "Francisco Morazán", "Gracias a Dios", "Intibucá", "Islas de la Bahía", "La Paz", "Lempira", "Ocotepeque", "Olancho", "Santa Bárbara", "Valle", "Yoro"})
        Me.cmbCasosDep.Location = New System.Drawing.Point(34, 53)
        Me.cmbCasosDep.Name = "cmbCasosDep"
        Me.cmbCasosDep.Size = New System.Drawing.Size(164, 29)
        Me.cmbCasosDep.TabIndex = 1
        '
        'lstbHistorialCasos
        '
        Me.lstbHistorialCasos.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lstbHistorialCasos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstbHistorialCasos.ForeColor = System.Drawing.Color.DimGray
        Me.lstbHistorialCasos.FormattingEnabled = True
        Me.lstbHistorialCasos.ItemHeight = 21
        Me.lstbHistorialCasos.Location = New System.Drawing.Point(34, 93)
        Me.lstbHistorialCasos.Name = "lstbHistorialCasos"
        Me.lstbHistorialCasos.Size = New System.Drawing.Size(525, 464)
        Me.lstbHistorialCasos.TabIndex = 0
        '
        'txtTotalActivos
        '
        Me.txtTotalActivos.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtTotalActivos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalActivos.ForeColor = System.Drawing.Color.DimGray
        Me.txtTotalActivos.Location = New System.Drawing.Point(27, 118)
        Me.txtTotalActivos.Multiline = True
        Me.txtTotalActivos.Name = "txtTotalActivos"
        Me.txtTotalActivos.ReadOnly = True
        Me.txtTotalActivos.Size = New System.Drawing.Size(89, 32)
        Me.txtTotalActivos.TabIndex = 4
        '
        'txtRecuperado
        '
        Me.txtRecuperado.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtRecuperado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRecuperado.ForeColor = System.Drawing.Color.DimGray
        Me.txtRecuperado.Location = New System.Drawing.Point(23, 231)
        Me.txtRecuperado.Multiline = True
        Me.txtRecuperado.Name = "txtRecuperado"
        Me.txtRecuperado.ReadOnly = True
        Me.txtRecuperado.Size = New System.Drawing.Size(89, 31)
        Me.txtRecuperado.TabIndex = 5
        '
        'txtNegativo
        '
        Me.txtNegativo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNegativo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNegativo.ForeColor = System.Drawing.Color.DimGray
        Me.txtNegativo.Location = New System.Drawing.Point(23, 331)
        Me.txtNegativo.Multiline = True
        Me.txtNegativo.Name = "txtNegativo"
        Me.txtNegativo.ReadOnly = True
        Me.txtNegativo.Size = New System.Drawing.Size(93, 31)
        Me.txtNegativo.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 21)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Activos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 21)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Recuperados"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 295)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 21)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Negativos"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(28, 403)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 21)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Muertos"
        '
        'txtMuertos
        '
        Me.txtMuertos.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtMuertos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMuertos.ForeColor = System.Drawing.Color.Red
        Me.txtMuertos.Location = New System.Drawing.Point(23, 441)
        Me.txtMuertos.Multiline = True
        Me.txtMuertos.Name = "txtMuertos"
        Me.txtMuertos.ReadOnly = True
        Me.txtMuertos.Size = New System.Drawing.Size(93, 31)
        Me.txtMuertos.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtTotalActivos)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtMuertos)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtNegativo)
        Me.GroupBox3.Controls.Add(Me.txtRecuperado)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox3.Location = New System.Drawing.Point(604, 41)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(132, 592)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Totales"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Location = New System.Drawing.Point(347, 535)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(117, 38)
        Me.btnLimpiar.TabIndex = 18
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 686)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1349, 45)
        Me.Panel1.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1349, 45)
        Me.Panel2.TabIndex = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1269, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'PruebasRealizadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1349, 731)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PruebasRealizadas"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PruebasRealizadas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbDepartamento As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chkNegativa As CheckBox
    Friend WithEvents chkPositiva As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents chkMuerto As CheckBox
    Friend WithEvents chkRecuperado As CheckBox
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNegativo As TextBox
    Friend WithEvents txtRecuperado As TextBox
    Friend WithEvents txtTotalActivos As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbCasosDep As ComboBox
    Friend WithEvents lstbHistorialCasos As ListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtMuertos As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
