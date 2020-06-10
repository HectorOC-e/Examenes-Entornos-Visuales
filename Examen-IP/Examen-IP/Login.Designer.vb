<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.txtNombreUser = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.btnInicioSesion = New System.Windows.Forms.Button()
        Me.btnRegistrarse = New System.Windows.Forms.Button()
        Me.txtContraseReg = New System.Windows.Forms.TextBox()
        Me.txtUsuarioreg = New System.Windows.Forms.TextBox()
        Me.lbRegistro = New System.Windows.Forms.Label()
        Me.btnTerminado = New System.Windows.Forms.Button()
        Me.lbrIngreseDatos = New System.Windows.Forms.Label()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombreUser
        '
        Me.txtNombreUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNombreUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreUser.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreUser.ForeColor = System.Drawing.Color.DimGray
        Me.txtNombreUser.Location = New System.Drawing.Point(324, 87)
        Me.txtNombreUser.Multiline = True
        Me.txtNombreUser.Name = "txtNombreUser"
        Me.txtNombreUser.Size = New System.Drawing.Size(403, 36)
        Me.txtNombreUser.TabIndex = 0
        Me.txtNombreUser.Text = "USUARIO"
        '
        'txtContraseña
        '
        Me.txtContraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContraseña.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.ForeColor = System.Drawing.Color.DimGray
        Me.txtContraseña.Location = New System.Drawing.Point(324, 178)
        Me.txtContraseña.Multiline = True
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9829)
        Me.txtContraseña.Size = New System.Drawing.Size(403, 36)
        Me.txtContraseña.TabIndex = 1
        Me.txtContraseña.Text = "CONTRASEÑA"
        Me.txtContraseña.UseSystemPasswordChar = True
        '
        'btnInicioSesion
        '
        Me.btnInicioSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnInicioSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnInicioSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicioSesion.ForeColor = System.Drawing.Color.LightGray
        Me.btnInicioSesion.Location = New System.Drawing.Point(468, 220)
        Me.btnInicioSesion.Name = "btnInicioSesion"
        Me.btnInicioSesion.Size = New System.Drawing.Size(101, 37)
        Me.btnInicioSesion.TabIndex = 4
        Me.btnInicioSesion.Text = "Iniciar sesion"
        Me.btnInicioSesion.UseVisualStyleBackColor = False
        '
        'btnRegistrarse
        '
        Me.btnRegistrarse.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnRegistrarse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnRegistrarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarse.ForeColor = System.Drawing.Color.LightGray
        Me.btnRegistrarse.Location = New System.Drawing.Point(468, 295)
        Me.btnRegistrarse.Name = "btnRegistrarse"
        Me.btnRegistrarse.Size = New System.Drawing.Size(101, 37)
        Me.btnRegistrarse.TabIndex = 5
        Me.btnRegistrarse.Text = "Registrarse"
        Me.btnRegistrarse.UseVisualStyleBackColor = False
        '
        'txtContraseReg
        '
        Me.txtContraseReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtContraseReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContraseReg.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseReg.ForeColor = System.Drawing.Color.DimGray
        Me.txtContraseReg.Location = New System.Drawing.Point(324, 178)
        Me.txtContraseReg.Multiline = True
        Me.txtContraseReg.Name = "txtContraseReg"
        Me.txtContraseReg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9829)
        Me.txtContraseReg.Size = New System.Drawing.Size(403, 36)
        Me.txtContraseReg.TabIndex = 7
        Me.txtContraseReg.Text = "CONTRASEÑA"
        Me.txtContraseReg.UseSystemPasswordChar = True
        Me.txtContraseReg.Visible = False
        '
        'txtUsuarioreg
        '
        Me.txtUsuarioreg.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtUsuarioreg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuarioreg.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuarioreg.ForeColor = System.Drawing.Color.DimGray
        Me.txtUsuarioreg.Location = New System.Drawing.Point(324, 87)
        Me.txtUsuarioreg.Multiline = True
        Me.txtUsuarioreg.Name = "txtUsuarioreg"
        Me.txtUsuarioreg.Size = New System.Drawing.Size(403, 36)
        Me.txtUsuarioreg.TabIndex = 6
        Me.txtUsuarioreg.Text = "USUARIO"
        Me.txtUsuarioreg.Visible = False
        '
        'lbRegistro
        '
        Me.lbRegistro.AutoSize = True
        Me.lbRegistro.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRegistro.ForeColor = System.Drawing.Color.DimGray
        Me.lbRegistro.Location = New System.Drawing.Point(319, 16)
        Me.lbRegistro.Name = "lbRegistro"
        Me.lbRegistro.Size = New System.Drawing.Size(205, 28)
        Me.lbRegistro.TabIndex = 8
        Me.lbRegistro.Text = "Registro de usuario"
        Me.lbRegistro.Visible = False
        '
        'btnTerminado
        '
        Me.btnTerminado.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnTerminado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnTerminado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTerminado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTerminado.ForeColor = System.Drawing.Color.LightGray
        Me.btnTerminado.Location = New System.Drawing.Point(468, 263)
        Me.btnTerminado.Name = "btnTerminado"
        Me.btnTerminado.Size = New System.Drawing.Size(101, 27)
        Me.btnTerminado.TabIndex = 9
        Me.btnTerminado.Text = "Terminado"
        Me.btnTerminado.UseVisualStyleBackColor = False
        Me.btnTerminado.Visible = False
        '
        'lbrIngreseDatos
        '
        Me.lbrIngreseDatos.AutoSize = True
        Me.lbrIngreseDatos.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbrIngreseDatos.ForeColor = System.Drawing.Color.DimGray
        Me.lbrIngreseDatos.Location = New System.Drawing.Point(319, 16)
        Me.lbrIngreseDatos.Name = "lbrIngreseDatos"
        Me.lbrIngreseDatos.Size = New System.Drawing.Size(186, 28)
        Me.lbrIngreseDatos.TabIndex = 11
        Me.lbrIngreseDatos.Text = "Ingrese sus Datos"
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 353)
        Me.Panel1.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(727, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 67)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(218, 241)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(774, 353)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbrIngreseDatos)
        Me.Controls.Add(Me.btnTerminado)
        Me.Controls.Add(Me.lbRegistro)
        Me.Controls.Add(Me.txtContraseReg)
        Me.Controls.Add(Me.txtUsuarioreg)
        Me.Controls.Add(Me.btnRegistrarse)
        Me.Controls.Add(Me.btnInicioSesion)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtNombreUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de Sesion"
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents txtNombreUser As TextBox
    Public WithEvents txtContraseña As TextBox
    Friend WithEvents btnInicioSesion As Button
    Friend WithEvents btnRegistrarse As Button
    Public WithEvents txtContraseReg As TextBox
    Public WithEvents txtUsuarioreg As TextBox
    Friend WithEvents lbRegistro As Label
    Friend WithEvents btnTerminado As Button
    Friend WithEvents lbrIngreseDatos As Label
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
