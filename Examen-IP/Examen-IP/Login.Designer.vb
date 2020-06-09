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
        Me.txtNombreUser = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnInicioSesion = New System.Windows.Forms.Button()
        Me.btnRegistrarse = New System.Windows.Forms.Button()
        Me.txtContraseReg = New System.Windows.Forms.TextBox()
        Me.txtUsuarioreg = New System.Windows.Forms.TextBox()
        Me.lbRegistro = New System.Windows.Forms.Label()
        Me.btnTerminado = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNombreUser
        '
        Me.txtNombreUser.Location = New System.Drawing.Point(185, 86)
        Me.txtNombreUser.Multiline = True
        Me.txtNombreUser.Name = "txtNombreUser"
        Me.txtNombreUser.Size = New System.Drawing.Size(162, 36)
        Me.txtNombreUser.TabIndex = 0
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(185, 177)
        Me.txtContraseña.Multiline = True
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(162, 36)
        Me.txtContraseña.TabIndex = 1
        Me.txtContraseña.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(182, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre de usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña"
        '
        'btnInicioSesion
        '
        Me.btnInicioSesion.Location = New System.Drawing.Point(116, 254)
        Me.btnInicioSesion.Name = "btnInicioSesion"
        Me.btnInicioSesion.Size = New System.Drawing.Size(101, 37)
        Me.btnInicioSesion.TabIndex = 4
        Me.btnInicioSesion.Text = "Iniciar sesion"
        Me.btnInicioSesion.UseVisualStyleBackColor = True
        '
        'btnRegistrarse
        '
        Me.btnRegistrarse.Location = New System.Drawing.Point(317, 254)
        Me.btnRegistrarse.Name = "btnRegistrarse"
        Me.btnRegistrarse.Size = New System.Drawing.Size(95, 37)
        Me.btnRegistrarse.TabIndex = 5
        Me.btnRegistrarse.Text = "Registrarse"
        Me.btnRegistrarse.UseVisualStyleBackColor = True
        '
        'txtContraseReg
        '
        Me.txtContraseReg.Location = New System.Drawing.Point(185, 177)
        Me.txtContraseReg.Multiline = True
        Me.txtContraseReg.Name = "txtContraseReg"
        Me.txtContraseReg.Size = New System.Drawing.Size(162, 36)
        Me.txtContraseReg.TabIndex = 7
        Me.txtContraseReg.UseSystemPasswordChar = True
        Me.txtContraseReg.Visible = False
        '
        'txtUsuarioreg
        '
        Me.txtUsuarioreg.Location = New System.Drawing.Point(185, 86)
        Me.txtUsuarioreg.Multiline = True
        Me.txtUsuarioreg.Name = "txtUsuarioreg"
        Me.txtUsuarioreg.Size = New System.Drawing.Size(162, 36)
        Me.txtUsuarioreg.TabIndex = 6
        Me.txtUsuarioreg.Visible = False
        '
        'lbRegistro
        '
        Me.lbRegistro.AutoSize = True
        Me.lbRegistro.Location = New System.Drawing.Point(67, 18)
        Me.lbRegistro.Name = "lbRegistro"
        Me.lbRegistro.Size = New System.Drawing.Size(132, 17)
        Me.lbRegistro.TabIndex = 8
        Me.lbRegistro.Text = "Registro de usuario"
        '
        'btnTerminado
        '
        Me.btnTerminado.Location = New System.Drawing.Point(223, 259)
        Me.btnTerminado.Name = "btnTerminado"
        Me.btnTerminado.Size = New System.Drawing.Size(88, 27)
        Me.btnTerminado.TabIndex = 9
        Me.btnTerminado.Text = "Terminado"
        Me.btnTerminado.UseVisualStyleBackColor = True
        Me.btnTerminado.Visible = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(544, 353)
        Me.Controls.Add(Me.btnTerminado)
        Me.Controls.Add(Me.lbRegistro)
        Me.Controls.Add(Me.txtContraseReg)
        Me.Controls.Add(Me.txtUsuarioreg)
        Me.Controls.Add(Me.btnRegistrarse)
        Me.Controls.Add(Me.btnInicioSesion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtNombreUser)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.Text = "Inicio de Sesion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents txtNombreUser As TextBox
    Public WithEvents txtContraseña As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnInicioSesion As Button
    Friend WithEvents btnRegistrarse As Button
    Public WithEvents txtContraseReg As TextBox
    Public WithEvents txtUsuarioreg As TextBox
    Friend WithEvents lbRegistro As Label
    Friend WithEvents btnTerminado As Button
End Class
