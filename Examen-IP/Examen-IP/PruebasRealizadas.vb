Imports System.ComponentModel

Public Class PruebasRealizadas
    Dim DatosFrancisco, DatosComayagua, totalActivos, TotalRecuperados, TotalMuertos, totalnegativas As Integer
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If chkPositiva.Checked = True Then
            If chkActivo.Checked = True Then
                totalActivos += 1
            ElseIf chkMuerto.checked = True Then
                TotalMuertos += 1
            End If
        ElseIf chkNegativa.checked = True And chkRecuperado.checked = False Then
            totalnegativas += 1
        ElseIf chkNegativa.Checked = True And chkRecuperado.Checked = True Then
            TotalRecuperados += 1
        End If

        If cmbDepartamento.SelectedItem = "Comayagua" Then
            DatosComayagua += 1
            lstbHistorialCasos.Items.Add("Hola")
        ElseIf cmbDepartamento.SelectedItem = "Francisco Morazán" Then
            DatosFrancisco += 1
            lstbHistorialCasos.Items.Add("ADIOS")
        End If

        txtTotalActivos.Text = totalActivos
        txtRecuperado.Text = TotalRecuperados
        txtNegativo.Text = totalnegativas

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtEdad_TextChanged(sender As Object, e As EventArgs) Handles txtEdad.TextChanged

    End Sub

    Private Sub txtMunicipio_TextChanged(sender As Object, e As EventArgs) Handles txtMunicipio.TextChanged

    End Sub

    Private Sub cmbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartamento.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged

    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As CancelEventArgs) Handles txtEdad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtMunicipio_Validating(sender As Object, e As CancelEventArgs) Handles txtMunicipio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub cmbDepartamento_MouseHover(sender As Object, e As EventArgs) Handles cmbDepartamento.MouseHover

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip.SetToolTip(txtNombre, "Ingrese el nombre del paciente")
        ToolTip.ToolTipTitle = ""
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEdad_MouseHover(sender As Object, e As EventArgs) Handles txtEdad.MouseHover
        ToolTip.SetToolTip(txtEdad, "Ingrese la edad del paciente")
        ToolTip.ToolTipTitle = ""
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMunicipio_MouseHover(sender As Object, e As EventArgs) Handles txtMunicipio.MouseHover
        ToolTip.SetToolTip(txtMunicipio, "Ingrese el municipio")
        ToolTip.ToolTipTitle = ""
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDescripcion_MouseHover(sender As Object, e As EventArgs) Handles txtDescripcion.MouseHover
        ToolTip.SetToolTip(txtDescripcion, "Ingrese una descripcion del paciente")
        ToolTip.ToolTipTitle = ""
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub chkPositiva_CheckedChanged(sender As Object, e As EventArgs) Handles chkPositiva.CheckedChanged
        If chkPositiva.Checked = True Then
            chkNegativa.Enabled = False
            chkMuerto.Enabled = True
            chkActivo.Enabled = True
        Else
            chkNegativa.Enabled = True
            chkMuerto.Enabled = False
            chkActivo.Enabled = False
        End If
    End Sub

    Private Sub chkNegativa_CheckedChanged(sender As Object, e As EventArgs) Handles chkNegativa.CheckedChanged
        If chkNegativa.Checked = True Then
            chkPositiva.Enabled = False
            chkRecuperado.Enabled = True

        Else
            chkPositiva.Enabled = True
        End If
    End Sub

    Private Sub chkActivo_CheckedChanged(sender As Object, e As EventArgs) Handles chkActivo.CheckedChanged
        If chkActivo.Checked = True Then
            chkMuerto.Enabled = False
        Else
            chkMuerto.Enabled = True
        End If
    End Sub

    Private Sub chkRecuperado_CheckedChanged(sender As Object, e As EventArgs) Handles chkRecuperado.CheckedChanged

    End Sub

    Private Sub chkMuerto_CheckedChanged(sender As Object, e As EventArgs) Handles chkMuerto.CheckedChanged
        If chkMuerto.Checked = True Then
            chkActivo.Enabled = False
        Else
            chkActivo.Enabled = True
        End If
    End Sub

    Private Sub cmbCasosDep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCasosDep.SelectedIndexChanged
        If cmbCasosDep.SelectedItem = "Comayagua" Then
            lstbHistorialCasos.Items.Clear()
            lstbHistorialCasos.Items.Add("Casos en comayagua casos totales " & DatosComayagua)
        ElseIf cmbCasosDep.SelectedItem = "Francisco Morazán" Then
            lstbHistorialCasos.Items.Clear()
            lstbHistorialCasos.Items.Add("Casos en comayagua casos totales " & DatosFrancisco)
        End If
    End Sub
End Class