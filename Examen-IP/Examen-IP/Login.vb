Imports System.ComponentModel

Public Class Login
    Dim Usuario, Contraseña As String
    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        lbrIngreseDatos.Hide()
        lbRegistro.Show()
        btnInicioSesion.Hide()
        btnTerminado.Show()
        txtContraseña.Hide()
        txtNombreUser.Hide()
        txtContraseReg.Show()
        txtUsuarioreg.Show()
        btnRegistrarse.Hide()

    End Sub

    Private Sub btnTerminado_Click(sender As Object, e As EventArgs) Handles btnTerminado.Click
        Dim RegUsuario As String



        If txtUsuarioreg.Text = "" Or txtContraseReg.Text = "" Then
            MsgBox("Debe llenar los datos de registro", vbOKOnly + vbExclamation, "Alerta")
        Else
            RegUsuario = txtUsuarioreg.Text.ToLowerInvariant

            Contraseña = txtContraseReg.Text
            Usuario = RegUsuario

            lbRegistro.Hide()
            lbrIngreseDatos.Show()
            btnInicioSesion.Show()
            txtContraseña.Show()
            txtNombreUser.Show()
            txtContraseReg.Hide()
            txtUsuarioreg.Hide()
            btnTerminado.Hide()
            btnRegistrarse.Hide()


        End If



    End Sub

    Private Sub txtUsuarioreg_TextChanged(sender As Object, e As EventArgs) Handles txtUsuarioreg.TextChanged

    End Sub

    Private Sub txtContraseReg_TextChanged(sender As Object, e As EventArgs) Handles txtContraseReg.TextChanged

    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged

    End Sub

    Private Sub txtNombreUser_TextChanged(sender As Object, e As EventArgs) Handles txtNombreUser.TextChanged

    End Sub

    Private Sub btnInicioSesion_Click(sender As Object, e As EventArgs) Handles btnInicioSesion.Click
        Dim REGusuario As String

        REGusuario = txtNombreUser.Text.ToLowerInvariant

        If Contraseña = "" And Usuario = "" Then
            MsgBox("El usuario debe registrarse", vbOKOnly + vbExclamation, "Alerta")
            txtContraseña.Clear()
            txtNombreUser.Clear()

        ElseIf REGusuario = Usuario And txtContraseña.Text = Contraseña Then
            PruebasRealizadas.Show()
            Me.Hide()
        Else

            MsgBox("Nombre de Usuario o Contraseña Incorrecta", vbOKOnly + vbExclamation, "Atención")
            txtNombreUser.Clear()
            txtContraseña.Clear()

        End If
    End Sub

    Private Sub txtUsuarioreg_Validating(sender As Object, e As CancelEventArgs) Handles txtUsuarioreg.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtContraseReg_Validating(sender As Object, e As CancelEventArgs) Handles txtContraseReg.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtContraseña_Validating(sender As Object, e As CancelEventArgs) Handles txtContraseña.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtNombreUser_Validating(sender As Object, e As CancelEventArgs) Handles txtNombreUser.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtUsuarioreg_MouseHover(sender As Object, e As EventArgs) Handles txtUsuarioreg.MouseHover
        ToolTip.SetToolTip(txtUsuarioreg, "Ingrese El Nombre de Usuario")
        ToolTip.ToolTipTitle = "Nombre de Usuario"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtContraseReg_MouseHover(sender As Object, e As EventArgs) Handles txtContraseReg.MouseHover
        ToolTip.SetToolTip(txtContraseReg, "Ingrese Su Contraseña")
        ToolTip.ToolTipTitle = "Contraseña"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtContraseña_MouseHover(sender As Object, e As EventArgs) Handles txtContraseña.MouseHover
        ToolTip.SetToolTip(txtContraseña, "Ingrese Su Contraseña")
        ToolTip.ToolTipTitle = "Contraseña"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtUsuarioreg_MouseEnter(sender As Object, e As EventArgs) Handles txtUsuarioreg.MouseEnter
        If (txtUsuarioreg.Text) = "USUARIO" Then
            txtUsuarioreg.Text = ""
            txtUsuarioreg.ForeColor = Color.LightGray

        End If
    End Sub

    Private Sub txtContraseReg_MouseEnter(sender As Object, e As EventArgs) Handles txtContraseReg.MouseEnter
        If (txtContraseReg.Text) = "CONTRASEÑA" Then
            txtContraseReg.Text = ""
            txtContraseReg.ForeColor = Color.LightGray

            txtContraseReg.UseSystemPasswordChar = False
        End If

    End Sub

    Private Sub txtNombreUser_MouseEnter(sender As Object, e As EventArgs) Handles txtNombreUser.MouseEnter
        If (txtNombreUser.Text) = "USUARIO" Then
            txtNombreUser.Text = ""
            txtNombreUser.ForeColor = Color.LightGray

        End If
    End Sub

    Private Sub txtContraseña_MouseEnter(sender As Object, e As EventArgs) Handles txtContraseña.MouseEnter
        If (txtContraseña.Text) = "CONTRASEÑA" Then
            txtContraseña.Text = ""
            txtContraseña.ForeColor = Color.LightGray
            txtContraseña.UseSystemPasswordChar = False
        End If

    End Sub

    Private Sub txtNombreUser_MouseHover(sender As Object, e As EventArgs) Handles txtNombreUser.MouseHover
        ToolTip.SetToolTip(txtNombreUser, "Ingrese Su Nombre de Usuario")
        ToolTip.ToolTipTitle = "Nombre de Usuario"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtUsuarioreg_MouseLeave(sender As Object, e As EventArgs) Handles txtUsuarioreg.MouseLeave
        If (txtUsuarioreg.Text) = "" Then
            txtUsuarioreg.Text = "USUARIO"
            txtUsuarioreg.ForeColor = Color.LightGray

        End If
    End Sub

    Private Sub txtContraseReg_MouseLeave(sender As Object, e As EventArgs) Handles txtContraseReg.MouseLeave
        If (txtContraseReg.Text) = "" Then
            txtContraseReg.Text = "CONTRASEÑA"
            txtContraseReg.ForeColor = Color.LightGray
            txtContraseReg.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtContraseña_MouseLeave(sender As Object, e As EventArgs) Handles txtContraseña.MouseLeave
        If (txtContraseña.Text) = "" Then
            txtContraseña.Text = "CONTRASEÑA"
            txtContraseña.ForeColor = Color.LightGray
            txtContraseña.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If MsgBox("¿Esta seguro de salir?", vbQuestion + vbYesNo, "Pregunta") = vbNo Then

        Else
            End
        End If
    End Sub

    Private Sub txtNombreUser_MouseLeave(sender As Object, e As EventArgs) Handles txtNombreUser.MouseLeave
        If (txtNombreUser.Text) = "" Then
            txtNombreUser.Text = "USUARIO"
            txtNombreUser.ForeColor = Color.LightGray

        End If
    End Sub
End Class
