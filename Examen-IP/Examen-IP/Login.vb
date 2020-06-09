Public Class Login
    Dim Usuario, Contraseña As String
    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
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


        Contraseña = txtContraseReg.Text
        Usuario = txtUsuarioreg.Text
        lbRegistro.Hide()
        btnInicioSesion.Show()
        txtContraseña.Show()
        txtNombreUser.Show()
        txtContraseReg.Hide()
        txtUsuarioreg.Hide()
        btnTerminado.Hide()
        btnRegistrarse.Hide()

    End Sub

    Private Sub btnInicioSesion_Click(sender As Object, e As EventArgs) Handles btnInicioSesion.Click


        If Contraseña = "" And Usuario = "" Then
            MsgBox("El usuario debe registrarse", vbOKOnly + vbExclamation, "Alerta")
            txtContraseña.Clear()
            txtNombreUser.Clear()

        ElseIf txtNombreUser.Text = usuario And txtContraseña.Text = contraseña Then
            PruebasRealizadas.Show()
            Me.Hide()
        Else

            MsgBox("Nombre de Usuario o Contraseña Incorrecta", vbOKOnly + vbExclamation, "Atención")
            txtNombreUser.Clear()
            txtContraseña.Clear()

        End If
    End Sub
End Class
