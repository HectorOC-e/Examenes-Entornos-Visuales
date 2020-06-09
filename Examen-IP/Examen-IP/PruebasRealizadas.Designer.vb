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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtTotalActivos = New System.Windows.Forms.TextBox()
        Me.txtRecuperado = New System.Windows.Forms.TextBox()
        Me.txtNegativo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Items.AddRange(New Object() {"Comayagua", "Francisco Morazán"})
        Me.cmbDepartamento.Location = New System.Drawing.Point(161, 129)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(175, 24)
        Me.cmbDepartamento.TabIndex = 0
        '
        'GroupBox1
        '
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
        Me.Label7.Size = New System.Drawing.Size(135, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Estado Del paciente"
        '
        'chkMuerto
        '
        Me.chkMuerto.AutoSize = True
        Me.chkMuerto.Enabled = False
        Me.chkMuerto.Location = New System.Drawing.Point(308, 307)
        Me.chkMuerto.Name = "chkMuerto"
        Me.chkMuerto.Size = New System.Drawing.Size(74, 21)
        Me.chkMuerto.TabIndex = 16
        Me.chkMuerto.Text = "Muerto"
        Me.chkMuerto.UseVisualStyleBackColor = True
        '
        'chkRecuperado
        '
        Me.chkRecuperado.AutoSize = True
        Me.chkRecuperado.Enabled = False
        Me.chkRecuperado.Location = New System.Drawing.Point(189, 307)
        Me.chkRecuperado.Name = "chkRecuperado"
        Me.chkRecuperado.Size = New System.Drawing.Size(108, 21)
        Me.chkRecuperado.TabIndex = 15
        Me.chkRecuperado.Text = "Recuperado"
        Me.chkRecuperado.UseVisualStyleBackColor = True
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Enabled = False
        Me.chkActivo.Location = New System.Drawing.Point(40, 307)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(68, 21)
        Me.chkActivo.TabIndex = 14
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(236, 538)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(100, 38)
        Me.btnAgregar.TabIndex = 13
        Me.btnAgregar.Text = "btnAgregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 369)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 51)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Breve " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "descripción del" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "estado del paciente"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(144, 366)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(361, 143)
        Me.txtDescripcion.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Estado de la prueba"
        '
        'chkNegativa
        '
        Me.chkNegativa.AutoSize = True
        Me.chkNegativa.Location = New System.Drawing.Point(189, 251)
        Me.chkNegativa.Name = "chkNegativa"
        Me.chkNegativa.Size = New System.Drawing.Size(86, 21)
        Me.chkNegativa.TabIndex = 9
        Me.chkNegativa.Text = "Negativa"
        Me.chkNegativa.UseVisualStyleBackColor = True
        '
        'chkPositiva
        '
        Me.chkPositiva.AutoSize = True
        Me.chkPositiva.Location = New System.Drawing.Point(40, 251)
        Me.chkPositiva.Name = "chkPositiva"
        Me.chkPositiva.Size = New System.Drawing.Size(79, 21)
        Me.chkPositiva.TabIndex = 8
        Me.chkPositiva.Text = "Positiva"
        Me.chkPositiva.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Municipio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Edad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre"
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(161, 175)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(100, 22)
        Me.txtMunicipio.TabIndex = 4
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(161, 83)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(100, 22)
        Me.txtEdad.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(161, 37)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(255, 22)
        Me.txtNombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
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
        Me.GroupBox2.Location = New System.Drawing.Point(621, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(479, 587)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Historial de Casos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(42, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(138, 17)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Elegir Departamento"
        '
        'cmbCasosDep
        '
        Me.cmbCasosDep.FormattingEnabled = True
        Me.cmbCasosDep.Items.AddRange(New Object() {"Comayagua", "Francisco Morazán"})
        Me.cmbCasosDep.Location = New System.Drawing.Point(39, 48)
        Me.cmbCasosDep.Name = "cmbCasosDep"
        Me.cmbCasosDep.Size = New System.Drawing.Size(164, 24)
        Me.cmbCasosDep.TabIndex = 1
        '
        'lstbHistorialCasos
        '
        Me.lstbHistorialCasos.FormattingEnabled = True
        Me.lstbHistorialCasos.ItemHeight = 16
        Me.lstbHistorialCasos.Location = New System.Drawing.Point(39, 88)
        Me.lstbHistorialCasos.Name = "lstbHistorialCasos"
        Me.lstbHistorialCasos.Size = New System.Drawing.Size(403, 468)
        Me.lstbHistorialCasos.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(517, 670)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(141, 49)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir del Formulario"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtTotalActivos
        '
        Me.txtTotalActivos.Location = New System.Drawing.Point(718, 683)
        Me.txtTotalActivos.Name = "txtTotalActivos"
        Me.txtTotalActivos.Size = New System.Drawing.Size(61, 22)
        Me.txtTotalActivos.TabIndex = 4
        '
        'txtRecuperado
        '
        Me.txtRecuperado.Location = New System.Drawing.Point(852, 683)
        Me.txtRecuperado.Name = "txtRecuperado"
        Me.txtRecuperado.Size = New System.Drawing.Size(61, 22)
        Me.txtRecuperado.TabIndex = 5
        '
        'txtNegativo
        '
        Me.txtNegativo.Location = New System.Drawing.Point(1002, 683)
        Me.txtNegativo.Name = "txtNegativo"
        Me.txtNegativo.Size = New System.Drawing.Size(61, 22)
        Me.txtNegativo.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(715, 653)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Activos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(849, 653)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Recuperados"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(999, 653)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Negativos"
        '
        'PruebasRealizadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 731)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNegativo)
        Me.Controls.Add(Me.txtRecuperado)
        Me.Controls.Add(Me.txtTotalActivos)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PruebasRealizadas"
        Me.Text = "PruebasRealizadas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbCasosDep As ComboBox
    Friend WithEvents lstbHistorialCasos As ListBox
    Friend WithEvents Label11 As Label
End Class
