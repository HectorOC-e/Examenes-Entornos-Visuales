Imports System.ComponentModel

Public Class PruebasRealizadas
    Dim edad, totalActivos, TotalRecuperados, TotalMuertos, totalnegativas As Integer
    Dim a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s As Integer
    Dim Nombre, municipio, estado, descripcion As String
    Dim Departamentos(18, 1000) As String

    Private Sub Agregarpaciente()

        Nombre = txtNombre.Text
        edad = Val(txtEdad.Text)
        municipio = txtMunicipio.Text
        descripcion = txtDescripcion.Text

        If txtNombre.Text = "" Or txtEdad.Text = "" Or txtMunicipio.Text = "" Or txtDescripcion.Text = "" Or txtEdad.Text = "" Then
            MsgBox("Debe ingresar todos los datos", vbOKOnly + vbExclamation, "Error al ingresar datos")

        ElseIf Not IsNumeric(txtEdad.Text) Then
            MsgBox("Ingrese una edad valida", vbOKOnly + vbExclamation, "Error Edad")

        ElseIf Not Val(txtEdad.Text) - Int(Val(txtEdad.Text)) = 0 Then
            MsgBox("Ingrese una edad valida", vbOKOnly + vbExclamation, "Error Edad")
        ElseIf chkPositiva.Checked = False And chkNegativa.Checked = False Then
            MsgBox("Debe seleccionar el resultado de la prueba", vbOKOnly + vbExclamation, "Error de resultado de la prueba")

        Else

            If chkPositiva.Checked = True Then
                If chkActivo.Checked = True Then
                    totalActivos += 1
                    estado = "Activo"
                ElseIf chkMuerto.Checked = True Then
                    TotalMuertos += 1
                    estado = "Fallecido"
                End If
            ElseIf chkNegativa.Checked = True And chkRecuperado.Checked = False Then
                totalnegativas += 1
                estado = "Negativo"
            ElseIf chkNegativa.Checked = True And chkRecuperado.Checked = True Then
                TotalRecuperados += 1
                estado = "Recuperado"
            End If

        End If


    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtDescripcion.Clear()
        txtEdad.Clear()
        txtMunicipio.Clear()
        chkPositiva.Checked = False
        chkNegativa.Checked = False
        cmbDepartamento.SelectedItem = -1
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If MsgBox("¿Esta seguro de salir?", vbQuestion + vbYesNo, "Seguro") = vbYes Then
            End
        End If
    End Sub

    Private Sub historialgeneral(valorX, valorZ)
        txtMuertos.Text = TotalMuertos
        txtTotalActivos.Text = totalActivos
        txtRecuperado.Text = TotalRecuperados
        txtNegativo.Text = totalnegativas
        lstbHistorialCasos.Items.Add(Departamentos(valorX, valorZ))
        lstbHistorialCasos.Items.Add(Environment.NewLine)
    End Sub

    Private Sub ImprimirHistorial(z, x)

        For y = 1 To x Step 1
            lstbHistorialCasos.Items.Add(Departamentos(z, y))
            lstbHistorialCasos.Items.Add(Environment.NewLine)

        Next

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click



        Select Case cmbDepartamento.SelectedIndex
            Case 0

                a += 1
                Agregarpaciente()
                Departamentos(1, a) = Nombre & ", " & edad & " años  estado: " & estado & " Atlántida, " & municipio & " " & descripcion
                historialgeneral(1, a)

            Case 1

                Agregarpaciente()
                b += 1
                Departamentos(2, b) = Nombre & ", " & edad & " años  estado: " & estado & " Choluteca, " & municipio & " " & descripcion
                historialgeneral(2, b)

            Case 2

                Agregarpaciente()
                c += 1
                Departamentos(3, c) = Nombre & ", " & edad & " años  estado: " & estado & " Colón, " & municipio & " " & descripcion
                historialgeneral(3, c)

            Case 3

                Agregarpaciente()
                d += 1
                Departamentos(4, d) = Nombre & ", " & edad & " años  estado: " & estado & " Comayagua, " & municipio & " " & descripcion
                historialgeneral(4, d)

            Case 4

                Agregarpaciente()
                f += 1
                Departamentos(5, f) = Nombre & ", " & edad & " años  estado: " & estado & " Copán, " & municipio & " " & descripcion
                historialgeneral(5, f)

            Case 5

                Agregarpaciente()
                g += 1
                Departamentos(6, g) = Nombre & ", " & edad & " años  estado: " & estado & " Cortés, " & municipio & " " & descripcion
                historialgeneral(6, g)

            Case 6

                Agregarpaciente()
                h += 1
                Departamentos(7, h) = Nombre & ", " & edad & " años  estado: " & estado & " El Paraíso, " & municipio & " " & descripcion
                historialgeneral(7, h)

            Case 7

                Agregarpaciente()
                i += 1
                Departamentos(8, i) = Nombre & ", " & edad & " años  estado: " & estado & " Francisco Morazán, " & municipio & " " & descripcion
                historialgeneral(8, i)

            Case 8

                Agregarpaciente()
                j += 1
                Departamentos(9, j) = Nombre & ", " & edad & " años  estado: " & estado & " Gracias a Dios, " & municipio & " " & descripcion
                historialgeneral(9, j)

            Case 9

                Agregarpaciente()
                k += 1
                Departamentos(10, k) = Nombre & ", " & edad & " años  estado: " & estado & " Intibucá, " & municipio & " " & descripcion
                historialgeneral(10, k)

            Case 10

                Agregarpaciente()
                l += 1
                Departamentos(11, l) = Nombre & ", " & edad & " años  estado: " & estado & " Islas de la Bahía, " & municipio & " " & descripcion
                historialgeneral(11, l)

            Case 11

                Agregarpaciente()
                m += 1
                Departamentos(12, m) = Nombre & ", " & edad & " años  estado: " & estado & " La Paz, " & municipio & " " & descripcion
                historialgeneral(12, m)

            Case 12

                Agregarpaciente()
                n += 1
                Departamentos(13, n) = Nombre & ", " & edad & " años  estado: " & estado & " Lempira, " & municipio & " " & descripcion
                historialgeneral(13, n)

            Case 13

                Agregarpaciente()
                o += 1
                Departamentos(14, o) = Nombre & ", " & edad & " años  estado: " & estado & " Ocotepeque, " & municipio & " " & descripcion
                historialgeneral(14, o)

            Case 14

                Agregarpaciente()
                p += 1
                Departamentos(15, p) = Nombre & ", " & edad & " años  estado: " & estado & " Olancho, " & municipio & " " & descripcion
                historialgeneral(15, p)

            Case 15

                Agregarpaciente()
                q += 1
                Departamentos(16, q) = Nombre & ", " & edad & " años  estado: " & estado & " Santa Bárbara, " & municipio & " " & descripcion
                historialgeneral(16, q)

            Case 16

                Agregarpaciente()
                r += 1
                Departamentos(17, r) = Nombre & ", " & edad & " años  estado: " & estado & " Valle, " & municipio & " " & descripcion
                historialgeneral(17, r)

            Case 17

                Agregarpaciente()
                s += 1
                Departamentos(18, s) = Nombre & ", " & edad & " años  estado: " & estado & " Yoro, " & municipio & " " & descripcion
                historialgeneral(18, s)


            Case Else
                    MsgBox("No se ha seleccionado un departamento")

            End Select



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

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip.SetToolTip(txtNombre, "Ingrese el nombre del paciente")
        ToolTip.ToolTipTitle = "Nombre del Paciente"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEdad_MouseHover(sender As Object, e As EventArgs) Handles txtEdad.MouseHover
        ToolTip.SetToolTip(txtEdad, "Ingrese la edad del paciente")
        ToolTip.ToolTipTitle = "Edad del Paciente"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMunicipio_MouseHover(sender As Object, e As EventArgs) Handles txtMunicipio.MouseHover
        ToolTip.SetToolTip(txtMunicipio, "Ingrese el municipio donde se encuentra el paciente")
        ToolTip.ToolTipTitle = "Municipio del Paciente"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDescripcion_MouseHover(sender As Object, e As EventArgs) Handles txtDescripcion.MouseHover
        ToolTip.SetToolTip(txtDescripcion, "Ingrese una descripcion del paciente")
        ToolTip.ToolTipTitle = "Estado del Paciente"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub chkPositiva_CheckedChanged(sender As Object, e As EventArgs) Handles chkPositiva.CheckedChanged
        If chkPositiva.Checked = True Then
            chkNegativa.Enabled = False
            chkMuerto.Enabled = True
            chkActivo.Enabled = True
            chkRecuperado.Enabled = False
        Else
            chkNegativa.Enabled = True
            chkMuerto.Enabled = False
            chkMuerto.Checked = False
            chkActivo.Enabled = False
            chkActivo.Checked = False
        End If
    End Sub

    Private Sub PruebasRealizadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub chkNegativa_CheckedChanged(sender As Object, e As EventArgs) Handles chkNegativa.CheckedChanged
        If chkNegativa.Checked = True Then
            chkPositiva.Enabled = False
            chkRecuperado.Enabled = True

        Else
            chkPositiva.Enabled = True
            chkRecuperado.Enabled = False
            chkRecuperado.Checked = False

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

        Select Case cmbCasosDep.SelectedIndex

            Case 0

                lstbHistorialCasos.Items.Clear()
                ImprimirHistorial(1, a)
            Case 1
                lstbHistorialCasos.Items.Clear()
                ImprimirHistorial(2, b)

            Case 2
                lstbHistorialCasos.Items.Clear()
                ImprimirHistorial(3, c)
            Case 3
                lstbHistorialCasos.Items.Clear()
                ImprimirHistorial(4, d)

            Case 4
                lstbHistorialCasos.Items.Clear()
                ImprimirHistorial(5, f)

            Case 5
                lstbHistorialCasos.Items.Clear()
                ImprimirHistorial(6, g)

            Case 6
                lstbHistorialCasos.Items.Clear()
                ImprimirHistorial(7, h)

            Case 7
                lstbHistorialCasos.Items.Clear()
                ImprimirHistorial(8, i)

            Case 8
                lstbHistorialCasos.Items.Clear()
                ImprimirHistorial(9, j)

            Case 9
                lstbHistorialCasos.Items.Clear()
                ImprimirHistorial(10, k)

            Case 10
                lstbHistorialCasos.Items.Clear()
                ImprimirHistorial(11, l)

            Case 11
                lstbHistorialCasos.Items.Clear()
                ImprimirHistorial(12, m)

            Case 12
                lstbHistorialCasos.Items.Clear()
                ImprimirHistorial(13, n)

            Case 13
                lstbHistorialCasos.Items.Clear()
                ImprimirHistorial(14, o)

            Case 14
                lstbHistorialCasos.Items.Clear()
                ImprimirHistorial(15, p)

            Case 15
                lstbHistorialCasos.Items.Clear()
                ImprimirHistorial(16, q)

            Case 16
                lstbHistorialCasos.Items.Clear()
                ImprimirHistorial(17, r)

            Case 17
                lstbHistorialCasos.Items.Clear()
                ImprimirHistorial(18, s)


            Case Else
                MsgBox("No se ha seleccionado un departamento")

        End Select

    End Sub
End Class