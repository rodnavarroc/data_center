Public Class Form1



    'Declaración de variables globales (no sé si sea correcto esto XD)
    Public Shared interior As Integer = 17
    Public Shared exterior As Integer = 25
    Public Shared I As Long
    Public Shared X As Long
    Public Shared Tiempo As String
    Public Shared eventos As String = "" 'String eventos sirve para mostrar los eventos ocurridos en el registro de eventos.

    Private Sub ActualizarValores(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If txtExt.Enabled = False Then 'Comprobamos si la simulación ya se inició. 
            MessageBox.Show("Favor de iniciar la simulación")
        ElseIf String.IsNullOrEmpty(txtExt.Text) Then 'Comprobamos que haya valor escrito en el txtExt.
            MessageBox.Show("Introduce un valor")
        End If
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click

    End Sub

    Private Sub IniciarSimulacion(sender As Object, e As EventArgs) Handles btnIniciar.Click 'click botón iniciar
        I = 0
        If Not Timer1.Enabled Then 'already running?
            Timer1.Start() 'no
        End If
        Dim StringInterior As String = interior.ToString 'Hacemos string la temperatura para pasarla al txtField
        Dim StringExterior As String = exterior.ToString
        eventos = "[00:00] Simulación iniciada." & vbCrLf & "Temperatura exterior: 25°C" & vbCrLf & "Temperatura interior: 17°C" 'Añadimos este texto al string eventos
        txtEventos.Text = eventos 'se cambia el texto del cuadro "Registro de eventos"
        txtInterior.Enabled = True
        txtExt.Enabled = True
        txtOff.Enabled = True
        btnActualizar.Enabled = True
        btnCausar.Enabled = True
        btnFalla.Enabled = True
        btnMantenimiento.Enabled = True
        btnOff.Enabled = True
        btnProvocar.Enabled = True
        btnRed.Enabled = True
        btnSimular.Enabled = True
        btnDetener.Enabled = True
        btnIniciar.Enabled = False
        txtInterior.Text = StringInterior & "°C" 'Le concatenamos el °C
        txtExt.Text = StringExterior & "°C"
        txtInterior.Enabled = False

        PictureBox2.BackColor = Color.LightSteelBlue
        PictureBox3.BackColor = Color.LightSteelBlue
        PictureBox4.BackColor = Color.LightSteelBlue
        PictureBox5.BackColor = Color.LightSteelBlue
        PictureBox6.BackColor = Color.LightSteelBlue
        PictureBox7.BackColor = Color.LightSteelBlue
        PictureBox8.BackColor = Color.LightSteelBlue
        PictureBox9.BackColor = Color.LightSteelBlue
        PictureBox10.BackColor = Color.LightSteelBlue
        PictureBox11.BackColor = Color.LightSteelBlue
        PictureBox12.BackColor = Color.LightSteelBlue
        PictureBox13.BackColor = Color.LightSteelBlue
        PictureBox14.BackColor = Color.LightSteelBlue
        PictureBox15.BackColor = Color.LightSteelBlue
        PictureBox16.BackColor = Color.LightSteelBlue
        PictureBox17.BackColor = Color.LightSteelBlue
        PictureBox18.BackColor = Color.LightSteelBlue
        PictureBox19.BackColor = Color.LightSteelBlue
        PictureBox20.BackColor = Color.LightSteelBlue
        PictureBox21.BackColor = Color.LightSteelBlue


    End Sub

    Private Sub ServidoresApagadoEncendido(sender As Object, e As EventArgs) Handles btnOff.Click
        If txtOff.Enabled = False Then 'Comprobamos si la simulación ya se inició
            MessageBox.Show("Favor de iniciar la simulación")
        ElseIf String.IsNullOrEmpty(txtOff.Text) Then 'Comprobamos si se introdujo un valor en el campo
            MessageBox.Show("Introduce un valor")
        Else Dim servidor As String = Convert.ToDouble(txtOff.Text) 'Convertimos el numero introducido al double para utilizarlo en el Select Case
            Select Case servidor 'Se utiliza la variable anterior para seleccionar el no. de servidor
                Case 1
                    If PictureBox2.BackColor = Color.LightSteelBlue Then 'Si el servidor es color Azul, lo cambiamos a gris y notificamos que se apagó.
                        PictureBox2.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 1 se ha apagado." 'Igualamos el string eventos a eventos para no perder la información anterior y le agregamos que se apagó el servidor.
                        txtEventos.Text = eventos 'Mostramos el string en el registro de eventos.
                    ElseIf PictureBox2.BackColor = Color.Gray Then 'Si el servidor es color Gris, lo cambiamos a azul y notificamos que se inició.
                        PictureBox2.BackColor = Color.LightSteelBlue
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 1 se ha iniciado."
                        txtEventos.Text = eventos
                    End If
                Case 2
                    If PictureBox3.BackColor = Color.LightSteelBlue Then
                        PictureBox3.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 2 se ha apagado."
                        txtEventos.Text = eventos
                    ElseIf PictureBox3.BackColor = Color.Gray Then
                        PictureBox3.BackColor = Color.LightSteelBlue
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 2 se ha iniciado."
                        txtEventos.Text = eventos
                    End If
                Case 3
                    If PictureBox4.BackColor = Color.LightSteelBlue Then
                        PictureBox4.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 3 se ha apagado."
                        txtEventos.Text = eventos
                    ElseIf PictureBox4.BackColor = Color.Gray Then
                        PictureBox4.BackColor = Color.LightSteelBlue
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 3 se ha iniciado."
                        txtEventos.Text = eventos
                    End If
                Case 4
                    If PictureBox5.BackColor = Color.LightSteelBlue Then
                        PictureBox5.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 4 se ha apagado."
                        txtEventos.Text = eventos
                    ElseIf PictureBox5.BackColor = Color.Gray Then
                        PictureBox5.BackColor = Color.LightSteelBlue
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 4 se ha iniciado."
                        txtEventos.Text = eventos
                    End If
                Case 5
                    If PictureBox6.BackColor = Color.LightSteelBlue Then
                        PictureBox6.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 5 se ha apagado."
                        txtEventos.Text = eventos
                    ElseIf PictureBox6.BackColor = Color.Gray Then
                        PictureBox6.BackColor = Color.LightSteelBlue
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 5 se ha iniciado."
                        txtEventos.Text = eventos
                    End If
                Case 6
                    If PictureBox7.BackColor = Color.LightSteelBlue Then
                        PictureBox7.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 6 se ha apagado."
                        txtEventos.Text = eventos
                    ElseIf PictureBox7.BackColor = Color.Gray Then
                        PictureBox7.BackColor = Color.LightSteelBlue
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 6 se ha iniciado."
                        txtEventos.Text = eventos
                    End If
                Case 7
                    If PictureBox8.BackColor = Color.LightSteelBlue Then
                        PictureBox8.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 7 se ha apagado."
                        txtEventos.Text = eventos
                    ElseIf PictureBox8.BackColor = Color.Gray Then
                        PictureBox8.BackColor = Color.LightSteelBlue
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 7 se ha encendido."
                        txtEventos.Text = eventos
                    End If
                Case 8
                    If PictureBox9.BackColor = Color.LightSteelBlue Then
                        PictureBox9.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 8 se ha apagado."
                        txtEventos.Text = eventos
                    ElseIf PictureBox9.BackColor = Color.Gray Then
                        PictureBox9.BackColor = Color.LightSteelBlue
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 8 se ha iniciado."
                        txtEventos.Text = eventos
                    End If
                Case 9
                    If PictureBox10.BackColor = Color.LightSteelBlue Then
                        PictureBox10.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 9 se ha apagado."
                        txtEventos.Text = eventos
                    ElseIf PictureBox10.BackColor = Color.Gray Then
                        PictureBox10.BackColor = Color.LightSteelBlue
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 9 se ha encendido."
                        txtEventos.Text = eventos
                    End If
                Case 10
                    If PictureBox11.BackColor = Color.LightSteelBlue Then
                        PictureBox11.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 10 se ha apagado."
                        txtEventos.Text = eventos
                    ElseIf PictureBox11.BackColor = Color.Gray Then
                        PictureBox11.BackColor = Color.LightSteelBlue
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 10 se ha iniciado."
                        txtEventos.Text = eventos
                    End If
                Case 11
                    If PictureBox12.BackColor = Color.LightSteelBlue Then
                        PictureBox12.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 11 se ha apagado."
                        txtEventos.Text = eventos
                    ElseIf PictureBox12.BackColor = Color.Gray Then
                        PictureBox12.BackColor = Color.LightSteelBlue
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 11 se ha iniciado."
                        txtEventos.Text = eventos
                    End If
                Case 12
                    If PictureBox13.BackColor = Color.LightSteelBlue Then
                        PictureBox13.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 12 se ha apagado."
                        txtEventos.Text = eventos
                    ElseIf PictureBox13.BackColor = Color.Gray Then
                        PictureBox13.BackColor = Color.LightSteelBlue
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 12 se ha iniciado."
                        txtEventos.Text = eventos
                    End If
                Case 13
                    If PictureBox14.BackColor = Color.LightSteelBlue Then
                        PictureBox14.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 13 se ha apagado."
                        txtEventos.Text = eventos
                    ElseIf PictureBox14.BackColor = Color.Gray Then
                        PictureBox14.BackColor = Color.LightSteelBlue
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 13 se ha iniciado."
                        txtEventos.Text = eventos
                    End If
                Case 14
                    If PictureBox15.BackColor = Color.LightSteelBlue Then
                        PictureBox15.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 14 se ha apagado."
                        txtEventos.Text = eventos
                    ElseIf PictureBox15.BackColor = Color.Gray Then
                        PictureBox15.BackColor = Color.LightSteelBlue
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 14 se ha iniciado."
                        txtEventos.Text = eventos
                    End If
                Case 15
                    If PictureBox16.BackColor = Color.LightSteelBlue Then
                        PictureBox16.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 15 se ha apagado."
                        txtEventos.Text = eventos
                    ElseIf PictureBox16.BackColor = Color.Gray Then
                        PictureBox16.BackColor = Color.LightSteelBlue
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 15 se ha iniciado."
                        txtEventos.Text = eventos
                    End If
                Case 16
                    If PictureBox17.BackColor = Color.LightSteelBlue Then
                        PictureBox17.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 16 se ha apagado."
                        txtEventos.Text = eventos
                    ElseIf PictureBox17.BackColor = Color.Gray Then
                        PictureBox17.BackColor = Color.LightSteelBlue
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 16 se ha iniciado."
                        txtEventos.Text = eventos
                    End If
                Case 17
                    If PictureBox18.BackColor = Color.LightSteelBlue Then
                        PictureBox18.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 17 se ha apagado."
                        txtEventos.Text = eventos
                    ElseIf PictureBox18.BackColor = Color.Gray Then
                        PictureBox18.BackColor = Color.LightSteelBlue
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 17 se ha iniciado."
                        txtEventos.Text = eventos
                    End If
                Case 18
                    If PictureBox19.BackColor = Color.LightSteelBlue Then
                        PictureBox19.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 18 se ha apagado."
                        txtEventos.Text = eventos
                    ElseIf PictureBox19.BackColor = Color.Gray Then
                        PictureBox19.BackColor = Color.LightSteelBlue
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 18 se ha iniciado."
                        txtEventos.Text = eventos
                    End If
                Case 19
                    If PictureBox20.BackColor = Color.LightSteelBlue Then
                        PictureBox20.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 19 se ha apagado."
                        txtEventos.Text = eventos
                    ElseIf PictureBox20.BackColor = Color.Gray Then
                        PictureBox20.BackColor = Color.LightSteelBlue
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 19 se ha iniciado."
                        txtEventos.Text = eventos
                    End If
                Case 20
                    If PictureBox21.BackColor = Color.LightSteelBlue Then
                        PictureBox21.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 20 se ha apagado."
                        txtEventos.Text = eventos
                    ElseIf PictureBox21.BackColor = Color.Gray Then
                        PictureBox21.BackColor = Color.LightSteelBlue
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 20 se ha iniciado."
                        txtEventos.Text = eventos
                    End If
                Case Else 'Cualquier otro numero que no sea del 1 al 20 mostrará este mensaje.
                    MessageBox.Show("No existe este servidor")
            End Select
        End If
    End Sub

    Private Sub txtOff_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOff.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'Restricciones para aceptar solo numeros en el txtOff
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtExt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtExt.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'Restricciones para aceptar solo numeros en el txtExt
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnFalla_Click(sender As Object, e As EventArgs) Handles btnFalla.Click

    End Sub

    Private Sub btnCausar_Click(sender As Object, e As EventArgs) Handles btnCausar.Click

        If PictureBox2.BackColor = Color.LightSteelBlue Or
        PictureBox3.BackColor = Color.LightSteelBlue Or
        PictureBox4.BackColor = Color.LightSteelBlue Or
        PictureBox5.BackColor = Color.LightSteelBlue Or
        PictureBox6.BackColor = Color.LightSteelBlue Or
        PictureBox7.BackColor = Color.LightSteelBlue Or
        PictureBox8.BackColor = Color.LightSteelBlue Or
        PictureBox9.BackColor = Color.LightSteelBlue Or
        PictureBox10.BackColor = Color.LightSteelBlue Or
        PictureBox11.BackColor = Color.LightSteelBlue Or
        PictureBox12.BackColor = Color.LightSteelBlue Or
        PictureBox13.BackColor = Color.LightSteelBlue Or
        PictureBox14.BackColor = Color.LightSteelBlue Or
        PictureBox15.BackColor = Color.LightSteelBlue Or
        PictureBox16.BackColor = Color.LightSteelBlue Or
        PictureBox17.BackColor = Color.LightSteelBlue Or
        PictureBox18.BackColor = Color.LightSteelBlue Or
        PictureBox19.BackColor = Color.LightSteelBlue Or
        PictureBox20.BackColor = Color.LightSteelBlue Or
        PictureBox21.BackColor = Color.LightSteelBlue Then
            PictureBox2.BackColor = Color.Gray
            PictureBox3.BackColor = Color.Gray
            PictureBox4.BackColor = Color.Gray
            PictureBox5.BackColor = Color.Gray
            PictureBox6.BackColor = Color.Gray
            PictureBox7.BackColor = Color.Gray
            PictureBox8.BackColor = Color.Gray
            PictureBox9.BackColor = Color.Gray
            PictureBox10.BackColor = Color.Gray
            PictureBox11.BackColor = Color.Gray
            PictureBox12.BackColor = Color.Gray
            PictureBox13.BackColor = Color.Gray
            PictureBox14.BackColor = Color.Gray
            PictureBox15.BackColor = Color.Gray
            PictureBox16.BackColor = Color.Gray
            PictureBox17.BackColor = Color.Gray
            PictureBox18.BackColor = Color.Gray
            PictureBox19.BackColor = Color.Gray
            PictureBox20.BackColor = Color.Gray
            PictureBox21.BackColor = Color.Gray
            eventos = eventos & vbCrLf & "[" & Tiempo & "]" & "Error en el Data Center.." & vbCrLf & "Apagando servidores.."
            txtEventos.Text = eventos
        End If

        If PictureBox2.BackColor = Color.Gray And
        PictureBox3.BackColor = Color.Gray And
        PictureBox4.BackColor = Color.Gray And
        PictureBox5.BackColor = Color.Gray And
        PictureBox6.BackColor = Color.Gray And
        PictureBox7.BackColor = Color.Gray And
        PictureBox8.BackColor = Color.Gray And
        PictureBox9.BackColor = Color.Gray And
        PictureBox10.BackColor = Color.Gray And
        PictureBox11.BackColor = Color.Gray And
        PictureBox12.BackColor = Color.Gray And
        PictureBox13.BackColor = Color.Gray And
        PictureBox14.BackColor = Color.Gray And
        PictureBox15.BackColor = Color.Gray And
        PictureBox16.BackColor = Color.Gray And
        PictureBox17.BackColor = Color.Gray And
        PictureBox18.BackColor = Color.Gray And
        PictureBox19.BackColor = Color.Gray And
        PictureBox20.BackColor = Color.Gray And
        PictureBox21.BackColor = Color.Gray Then
            eventos = eventos & vbCrLf & "Los servidores se encuentran actualmente apagados."
            txtEventos.Text = eventos
        End If
    End Sub

    Private Sub btnProvocar_Click(sender As Object, e As EventArgs) Handles btnProvocar.Click
        If PictureBox2.BackColor = Color.LightSteelBlue And
       PictureBox3.BackColor = Color.LightSteelBlue And
       PictureBox4.BackColor = Color.LightSteelBlue And
       PictureBox5.BackColor = Color.LightSteelBlue And
       PictureBox6.BackColor = Color.LightSteelBlue And
       PictureBox7.BackColor = Color.LightSteelBlue And
       PictureBox8.BackColor = Color.LightSteelBlue And
       PictureBox9.BackColor = Color.LightSteelBlue And
       PictureBox10.BackColor = Color.LightSteelBlue And
       PictureBox11.BackColor = Color.LightSteelBlue And
       PictureBox12.BackColor = Color.LightSteelBlue And
       PictureBox13.BackColor = Color.LightSteelBlue And
       PictureBox14.BackColor = Color.LightSteelBlue And
       PictureBox15.BackColor = Color.LightSteelBlue And
       PictureBox16.BackColor = Color.LightSteelBlue And
       PictureBox17.BackColor = Color.LightSteelBlue And
       PictureBox18.BackColor = Color.LightSteelBlue And
       PictureBox19.BackColor = Color.LightSteelBlue And
       PictureBox20.BackColor = Color.LightSteelBlue And
       PictureBox21.BackColor = Color.LightSteelBlue Then
            Timer2.Interval = 3000
            If Not Timer2.Enabled Then 'already running?
                Timer2.Start() 'no
            End If
            PictureBox2.BackColor = Color.Yellow
            PictureBox3.BackColor = Color.Yellow
            PictureBox4.BackColor = Color.Yellow
            PictureBox5.BackColor = Color.Yellow
            PictureBox6.BackColor = Color.Yellow
            PictureBox7.BackColor = Color.Yellow
            PictureBox8.BackColor = Color.Yellow
            PictureBox9.BackColor = Color.Yellow
            PictureBox10.BackColor = Color.Yellow
            PictureBox11.BackColor = Color.Yellow
            PictureBox12.BackColor = Color.Yellow
            PictureBox13.BackColor = Color.Yellow
            PictureBox14.BackColor = Color.Yellow
            PictureBox15.BackColor = Color.Yellow
            PictureBox16.BackColor = Color.Yellow
            PictureBox17.BackColor = Color.Yellow
            PictureBox18.BackColor = Color.Yellow
            PictureBox19.BackColor = Color.Yellow
            PictureBox20.BackColor = Color.Yellow
            PictureBox21.BackColor = Color.Yellow
            eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "Los servidores están experimentando una sobrecarga de información." & vbCrLf & "--Iniciando protocolo de restauración--"
            txtEventos.Text = eventos
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        I = I + 1
        If I Mod 60 = 0 Then
            X = X + 1
        End If
        Tiempo = Format(X Mod 24, "00:") &
                       Format(I Mod 60, "00")
        Label12.Text = "Hora de la simulación: " & Tiempo

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox2.BackColor = Color.LightSteelBlue
        PictureBox3.BackColor = Color.LightSteelBlue
        PictureBox4.BackColor = Color.LightSteelBlue
        PictureBox5.BackColor = Color.LightSteelBlue
        PictureBox6.BackColor = Color.LightSteelBlue
        PictureBox7.BackColor = Color.LightSteelBlue
        PictureBox8.BackColor = Color.LightSteelBlue
        PictureBox9.BackColor = Color.LightSteelBlue
        PictureBox10.BackColor = Color.LightSteelBlue
        PictureBox11.BackColor = Color.LightSteelBlue
        PictureBox12.BackColor = Color.LightSteelBlue
        PictureBox13.BackColor = Color.LightSteelBlue
        PictureBox14.BackColor = Color.LightSteelBlue
        PictureBox15.BackColor = Color.LightSteelBlue
        PictureBox16.BackColor = Color.LightSteelBlue
        PictureBox17.BackColor = Color.LightSteelBlue
        PictureBox18.BackColor = Color.LightSteelBlue
        PictureBox19.BackColor = Color.LightSteelBlue
        PictureBox20.BackColor = Color.LightSteelBlue
        PictureBox21.BackColor = Color.LightSteelBlue
        eventos = eventos & vbCrLf & "Completado." & vbCrLf & "[" & Tiempo & "] " & "Servidores operando normalmente."
        txtEventos.Text = eventos
        Timer2.Stop()
    End Sub

    Private Sub btnDetener_Click(sender As Object, e As EventArgs) Handles btnDetener.Click
        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "La simulación se ha detenido."
        txtInterior.Enabled = False
        txtExt.Enabled = False
        txtOff.Enabled = False
        btnActualizar.Enabled = False
        btnCausar.Enabled = False
        btnFalla.Enabled = False
        btnMantenimiento.Enabled = False
        btnOff.Enabled = False
        btnProvocar.Enabled = False
        btnRed.Enabled = False
        btnSimular.Enabled = False
        btnDetener.Enabled = False
        btnIniciar.Enabled = True
        txtEventos.Text = eventos
        Timer1.Stop()
    End Sub
End Class

