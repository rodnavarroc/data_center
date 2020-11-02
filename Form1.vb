Public Class Form1



    'Declaración de variables globales (no sé si sea correcto esto XD)
    Public Shared interior As Integer = 18
    Public Shared exterior As Integer = 45
    Public Shared I As Long
    Public Shared X As Long
    Public Shared Tt As Long = -2
    Public Shared a As Long = 1
    Public Shared ApagarServ As Long = 1
    Public Shared apagon As String = ""
    Public Shared Tiempo As String = "00:00"
    Public Shared eventos As String = "" 'String eventos sirve para mostrar los eventos ocurridos en el registro de eventos.

    Private Sub ActualizarValores(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If String.IsNullOrEmpty(txtInterior.Text) Then 'Comprobamos que haya valor escrito en el txtExt.
            MessageBox.Show("Introduce un valor para la temperatura")
        Else
            Dim temperatura As String = txtInterior.Text
            txtInterior.Text = temperatura
            eventos = eventos & vbCrLf & "[" & Tiempo & "] " & String.Format("Temperatura {0}°C", temperatura)
            txtEventos.Text = eventos
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
        eventos = "[00:00] Simulación iniciada." & vbCrLf & String.Format("Humedad {0}%", exterior) & vbCrLf & String.Format("Temperatura {0}°C", interior) 'Añadimos este texto al string eventos
        txtEventos.Text = eventos 'se cambia el texto del cuadro "Registro de eventos"
        txtInterior.Enabled = True
        txtOff.Enabled = True
        btnActualizar.Enabled = True
        btnCausar.Enabled = True
        btnMantenimiento.Enabled = True
        btnOff.Enabled = True
        btnProvocar.Enabled = True
        btnRed.Enabled = True
        btnSimular.Enabled = True
        btnDetener.Enabled = True
        btnIniciar.Enabled = True
        Reanudar.Enabled = False
        txtInterior.Text = StringInterior
        txtInterior.Enabled = True



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
        PictureBox30.BackColor = Color.Red
        PictureBox29.BackColor = Color.White
        PictureBox43.BackColor = Color.White
        PictureBox45.BackColor = Color.White
        PictureBox41.BackColor = Color.Silver
        PictureBox46.BackColor = Color.Silver
        PictureBox40.BackColor = Color.Silver
        PictureBox39.BackColor = Color.Silver
        PictureBox35.BackColor = Color.Silver
        PictureBox38.BackColor = Color.Silver
        PictureBox34.BackColor = Color.Silver
        PictureBox37.BackColor = Color.Silver
        PictureBox33.BackColor = Color.Silver
        PictureBox36.BackColor = Color.Silver
        PictureBox32.BackColor = Color.Silver
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If ApagarServ = 1 Then
            eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "Empezó el análisis del problema que causo la falla."
            txtEventos.Text = eventos
        End If
        If ApagarServ = 2 Then
            eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "Se ha encontrado el problema y se ha solucionado."
            txtEventos.Text = eventos
        End If
        If ApagarServ = 3 Then
            eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "Inicializando el servidor y haciendo análisis de la información."
            txtEventos.Text = eventos
        End If
        If ApagarServ = 4 Then
            eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor se ha encendido correctamente."
            txtEventos.Text = eventos
            Timer5.Stop()
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
            txtInterior.Enabled = True
            txtOff.Enabled = True
            btnActualizar.Enabled = True
            btnCausar.Enabled = True
            btnMantenimiento.Enabled = True
            btnOff.Enabled = True
            btnProvocar.Enabled = True
            btnRed.Enabled = True
            btnSimular.Enabled = True
            btnDetener.Enabled = True
            btnIniciar.Enabled = True
            Reanudar.Enabled = False
            txtInterior.Enabled = True
            txtInterior.Enabled = True
        End If
        ApagarServ = ApagarServ + 1
    End Sub

    Private Sub ServidoresApagadoEncendido(sender As Object, e As EventArgs) Handles btnOff.Click
        If txtOff.Enabled = False Then 'Comprobamos si la simulación ya se inició
            MessageBox.Show("Favor de iniciar la simulación")
        ElseIf String.IsNullOrEmpty(txtOff.Text) Then 'Comprobamos si se introdujo un valor en el campo
            MessageBox.Show("Introduce un valor")
        Else Dim servidor As String = Convert.ToDouble(txtOff.Text) 'Convertimos el numero introducido al double para utilizarlo en el Select Case
            txtInterior.Enabled = False
            txtOff.Enabled = False
            btnActualizar.Enabled = False
            btnCausar.Enabled = False
            btnMantenimiento.Enabled = False
            btnOff.Enabled = False
            btnProvocar.Enabled = False
            btnRed.Enabled = False
            btnSimular.Enabled = False
            btnDetener.Enabled = True
            btnIniciar.Enabled = True
            Reanudar.Enabled = False
            txtInterior.Enabled = False
            txtInterior.Enabled = True
            ApagarServ = 1
            Select Case servidor 'Se utiliza la variable anterior para seleccionar el no. de servidor
                Case 1
                    If PictureBox2.BackColor = Color.LightSteelBlue Then 'Si el servidor es color Azul, lo cambiamos a gris y notificamos que se apagó.
                        PictureBox2.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 1 se ha apagado debido a un problema no esperado." 'Igualamos el string eventos a eventos para no perder la información anterior y le agregamos que se apagó el servidor.
                        txtEventos.Text = eventos 'Mostramos el string en el registro de eventos.
                        Timer5.Enabled = True
                        Timer5.Start()
                    End If
                Case 2
                    If PictureBox3.BackColor = Color.LightSteelBlue Then
                        PictureBox3.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 2 se ha apagado debido a un problema no esperado." 'Igualamos el string eventos a eventos para no perder la información anterior y le agregamos que se apagó el servidor.
                        txtEventos.Text = eventos 'Mostramos el string en el registro de eventos.
                        Timer5.Enabled = True
                        Timer5.Start()
                    End If
                Case 3
                    If PictureBox4.BackColor = Color.LightSteelBlue Then
                        PictureBox4.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 3 se ha apagado debido a un problema no esperado." 'Igualamos el string eventos a eventos para no perder la información anterior y le agregamos que se apagó el servidor.
                        txtEventos.Text = eventos 'Mostramos el string en el registro de eventos.
                        Timer5.Enabled = True
                        Timer5.Start()
                    End If
                Case 4
                    If PictureBox5.BackColor = Color.LightSteelBlue Then
                        PictureBox5.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 4 se ha apagado debido a un problema no esperado." 'Igualamos el string eventos a eventos para no perder la información anterior y le agregamos que se apagó el servidor.
                        txtEventos.Text = eventos 'Mostramos el string en el registro de eventos.
                        Timer5.Enabled = True
                        Timer5.Start()
                    End If
                Case 5
                    If PictureBox6.BackColor = Color.LightSteelBlue Then
                        PictureBox6.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 5 se ha apagado debido a un problema no esperado." 'Igualamos el string eventos a eventos para no perder la información anterior y le agregamos que se apagó el servidor.
                        txtEventos.Text = eventos 'Mostramos el string en el registro de eventos.
                        Timer5.Enabled = True
                        Timer5.Start()
                    End If
                Case 6
                    If PictureBox7.BackColor = Color.LightSteelBlue Then
                        PictureBox7.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 6 se ha apagado debido a un problema no esperado." 'Igualamos el string eventos a eventos para no perder la información anterior y le agregamos que se apagó el servidor.
                        txtEventos.Text = eventos 'Mostramos el string en el registro de eventos.
                        Timer5.Enabled = True
                        Timer5.Start()
                    End If
                Case 7
                    If PictureBox8.BackColor = Color.LightSteelBlue Then
                        PictureBox8.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 7 se ha apagado debido a un problema no esperado." 'Igualamos el string eventos a eventos para no perder la información anterior y le agregamos que se apagó el servidor.
                        txtEventos.Text = eventos 'Mostramos el string en el registro de eventos.
                        Timer5.Enabled = True
                        Timer5.Start()
                    End If
                Case 8
                    If PictureBox9.BackColor = Color.LightSteelBlue Then
                        PictureBox9.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 8 se ha apagado debido a un problema no esperado." 'Igualamos el string eventos a eventos para no perder la información anterior y le agregamos que se apagó el servidor.
                        txtEventos.Text = eventos 'Mostramos el string en el registro de eventos.
                        Timer5.Enabled = True
                        Timer5.Start()
                    End If
                Case 9
                    If PictureBox10.BackColor = Color.LightSteelBlue Then
                        PictureBox10.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 9 se ha apagado debido a un problema no esperado." 'Igualamos el string eventos a eventos para no perder la información anterior y le agregamos que se apagó el servidor.
                        txtEventos.Text = eventos 'Mostramos el string en el registro de eventos.
                        Timer5.Enabled = True
                        Timer5.Start()
                    End If
                Case 10
                    If PictureBox11.BackColor = Color.LightSteelBlue Then
                        PictureBox11.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 10 se ha apagado debido a un problema no esperado." 'Igualamos el string eventos a eventos para no perder la información anterior y le agregamos que se apagó el servidor.
                        txtEventos.Text = eventos 'Mostramos el string en el registro de eventos.
                        Timer5.Enabled = True
                        Timer5.Start()
                    End If
                Case 11
                    If PictureBox12.BackColor = Color.LightSteelBlue Then
                        PictureBox12.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 11 se ha apagado debido a un problema no esperado." 'Igualamos el string eventos a eventos para no perder la información anterior y le agregamos que se apagó el servidor.
                        txtEventos.Text = eventos 'Mostramos el string en el registro de eventos.
                        Timer5.Enabled = True
                        Timer5.Start()
                    End If
                Case 12
                    If PictureBox13.BackColor = Color.LightSteelBlue Then
                        PictureBox13.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 12 se ha apagado debido a un problema no esperado." 'Igualamos el string eventos a eventos para no perder la información anterior y le agregamos que se apagó el servidor.
                        txtEventos.Text = eventos 'Mostramos el string en el registro de eventos.
                        Timer5.Enabled = True
                        Timer5.Start()
                    End If
                Case 13
                    If PictureBox14.BackColor = Color.LightSteelBlue Then
                        PictureBox14.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 13 se ha apagado debido a un problema no esperado." 'Igualamos el string eventos a eventos para no perder la información anterior y le agregamos que se apagó el servidor.
                        txtEventos.Text = eventos 'Mostramos el string en el registro de eventos.
                        Timer5.Enabled = True
                        Timer5.Start()
                    End If
                Case 14
                    If PictureBox15.BackColor = Color.LightSteelBlue Then
                        PictureBox15.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 14 se ha apagado debido a un problema no esperado." 'Igualamos el string eventos a eventos para no perder la información anterior y le agregamos que se apagó el servidor.
                        txtEventos.Text = eventos 'Mostramos el string en el registro de eventos.
                        Timer5.Enabled = True
                        Timer5.Start()
                    End If
                Case 15
                    If PictureBox16.BackColor = Color.LightSteelBlue Then
                        PictureBox16.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 15 se ha apagado debido a un problema no esperado." 'Igualamos el string eventos a eventos para no perder la información anterior y le agregamos que se apagó el servidor.
                        txtEventos.Text = eventos 'Mostramos el string en el registro de eventos.
                        Timer5.Enabled = True
                        Timer5.Start()
                    End If
                Case 16
                    If PictureBox17.BackColor = Color.LightSteelBlue Then
                        PictureBox17.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 16 se ha apagado debido a un problema no esperado." 'Igualamos el string eventos a eventos para no perder la información anterior y le agregamos que se apagó el servidor.
                        txtEventos.Text = eventos 'Mostramos el string en el registro de eventos.
                        Timer5.Enabled = True
                        Timer5.Start()
                    End If
                Case 17
                    If PictureBox18.BackColor = Color.LightSteelBlue Then
                        PictureBox18.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 17 se ha apagado debido a un problema no esperado." 'Igualamos el string eventos a eventos para no perder la información anterior y le agregamos que se apagó el servidor.
                        txtEventos.Text = eventos 'Mostramos el string en el registro de eventos.
                        Timer5.Enabled = True
                        Timer5.Start()
                    End If
                Case 18
                    If PictureBox19.BackColor = Color.LightSteelBlue Then
                        PictureBox19.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 18 se ha apagado debido a un problema no esperado." 'Igualamos el string eventos a eventos para no perder la información anterior y le agregamos que se apagó el servidor.
                        txtEventos.Text = eventos 'Mostramos el string en el registro de eventos.
                        Timer5.Enabled = True
                        Timer5.Start()
                    End If
                Case 19
                    If PictureBox20.BackColor = Color.LightSteelBlue Then
                        PictureBox20.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 19 se ha apagado debido a un problema no esperado." 'Igualamos el string eventos a eventos para no perder la información anterior y le agregamos que se apagó el servidor.
                        txtEventos.Text = eventos 'Mostramos el string en el registro de eventos.
                        Timer5.Enabled = True
                        Timer5.Start()
                    End If
                Case 20
                    If PictureBox21.BackColor = Color.LightSteelBlue Then
                        PictureBox21.BackColor = Color.Gray
                        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "El servidor 20 se ha apagado debido a un problema no esperado." 'Igualamos el string eventos a eventos para no perder la información anterior y le agregamos que se apagó el servidor.
                        txtEventos.Text = eventos 'Mostramos el string en el registro de eventos.
                        Timer5.Enabled = True
                        Timer5.Start()
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

    Private Sub txtExt_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'Restricciones para aceptar solo numeros en el txtExt
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnFalla_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCausar_Click(sender As Object, e As EventArgs) Handles btnCausar.Click
        Tt = -1
        btnCausar.Enabled = False

        txtInterior.Enabled = False
        txtOff.Enabled = False
        btnActualizar.Enabled = False
        btnMantenimiento.Enabled = False
        btnOff.Enabled = False
        btnProvocar.Enabled = False
        btnRed.Enabled = False
        btnSimular.Enabled = False
        btnDetener.Enabled = True
        btnIniciar.Enabled = True

        'Cambio de color en la energía
        PictureBox30.BackColor = Color.White
        PictureBox41.BackColor = Color.White
        PictureBox46.BackColor = Color.White
        PictureBox40.BackColor = Color.White
        PictureBox39.BackColor = Color.White
        PictureBox35.BackColor = Color.White
        PictureBox38.BackColor = Color.White
        PictureBox34.BackColor = Color.White
        PictureBox37.BackColor = Color.White
        PictureBox33.BackColor = Color.White
        PictureBox36.BackColor = Color.White
        PictureBox32.BackColor = Color.White

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
        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "Ha sucedido un apagón, los servidores pasaron a recibir fuente de alimentación de respaldo"
        txtEventos.Text = eventos
        Timer3.Enabled = True
        Timer3.Start()
        Timer3.Interval = 3000

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        If Tt = 1 Then
            Timer4.Enabled = True
            a = 2
            Timer4.Start()
            Timer4.Interval = 1500
            Timer3.Stop()
        End If

        If Tt = 0 Then
            PictureBox43.BackColor = Color.FromArgb(255, 128, 128)
            PictureBox45.BackColor = Color.FromArgb(255, 128, 128)
            PictureBox46.BackColor = Color.FromArgb(255, 128, 128)
            PictureBox40.BackColor = Color.FromArgb(255, 128, 128)
            PictureBox39.BackColor = Color.FromArgb(255, 128, 128)
            PictureBox35.BackColor = Color.FromArgb(255, 128, 128)
            eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "Se están arreglando fallas de la fuente de alimentación inicial"
            txtEventos.Text = eventos
            Tt = 1
        End If

        If Tt = -1 Then
            PictureBox29.BackColor = Color.Red
            Tt = 0
        End If

        If Tt = 2 Then
            PictureBox30.BackColor = Color.Red
            PictureBox29.BackColor = Color.White
            PictureBox43.BackColor = Color.White
            PictureBox45.BackColor = Color.White
            PictureBox41.BackColor = Color.Silver
            PictureBox46.BackColor = Color.Silver
            PictureBox40.BackColor = Color.Silver
            PictureBox39.BackColor = Color.Silver
            PictureBox35.BackColor = Color.Silver
            PictureBox38.BackColor = Color.Silver
            PictureBox34.BackColor = Color.Silver
            PictureBox37.BackColor = Color.Silver
            PictureBox33.BackColor = Color.Silver
            PictureBox36.BackColor = Color.Silver
            PictureBox32.BackColor = Color.Silver
            eventos = eventos & "[" & Tiempo & "] " & "La servidores han sido conectados a la fuente de alimentación principal" & vbCrLf
            txtEventos.Text = eventos
            btnCausar.Enabled = True
            txtInterior.Enabled = True
            txtOff.Enabled = True
            btnActualizar.Enabled = True
            btnMantenimiento.Enabled = True
            btnOff.Enabled = True
            btnProvocar.Enabled = True
            btnRed.Enabled = True
            btnSimular.Enabled = True
            btnDetener.Enabled = True
            btnIniciar.Enabled = True

            Timer3.Stop()
            Tt = -2
        End If

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If a = 2 Then
            PictureBox21.BackColor = Color.LightSteelBlue
        End If
        If a = 3 Then
            PictureBox20.BackColor = Color.LightSteelBlue
        End If
        If a = 4 Then
            PictureBox19.BackColor = Color.LightSteelBlue
        End If
        If a = 5 Then
            PictureBox18.BackColor = Color.LightSteelBlue
        End If
        If a = 6 Then
            PictureBox17.BackColor = Color.LightSteelBlue
            Timer4.Interval = 2000
        End If
        If a = 7 Then
            PictureBox38.BackColor = Color.FromArgb(255, 128, 128)
            PictureBox34.BackColor = Color.FromArgb(255, 128, 128)
            Timer4.Interval = 1500
        End If
        If a = 8 Then
            PictureBox16.BackColor = Color.LightSteelBlue
        End If
        If a = 9 Then
            PictureBox15.BackColor = Color.LightSteelBlue
        End If
        If a = 10 Then
            PictureBox14.BackColor = Color.LightSteelBlue
        End If
        If a = 11 Then
            PictureBox13.BackColor = Color.LightSteelBlue
        End If
        If a = 12 Then
            PictureBox12.BackColor = Color.LightSteelBlue
            Timer4.Interval = 2000
        End If
        If a = 13 Then
            PictureBox37.BackColor = Color.FromArgb(255, 128, 128)
            PictureBox33.BackColor = Color.FromArgb(255, 128, 128)
            Timer4.Interval = 1500
        End If
        If a = 14 Then
            PictureBox11.BackColor = Color.LightSteelBlue
        End If
        If a = 15 Then
            PictureBox10.BackColor = Color.LightSteelBlue
        End If
        If a = 16 Then
            PictureBox9.BackColor = Color.LightSteelBlue
        End If
        If a = 17 Then
            PictureBox8.BackColor = Color.LightSteelBlue
        End If
        If a = 18 Then
            PictureBox7.BackColor = Color.LightSteelBlue
            Timer4.Interval = 2000
        End If
        If a = 19 Then
            PictureBox36.BackColor = Color.FromArgb(255, 128, 128)
            PictureBox32.BackColor = Color.FromArgb(255, 128, 128)
            Timer4.Interval = 1500
        End If
        If a = 20 Then
            PictureBox6.BackColor = Color.LightSteelBlue
        End If
        If a = 21 Then
            PictureBox5.BackColor = Color.LightSteelBlue
        End If
        If a = 22 Then
            PictureBox4.BackColor = Color.LightSteelBlue
        End If
        If a = 23 Then
            PictureBox3.BackColor = Color.LightSteelBlue
        End If
        If a = 24 Then
            PictureBox2.BackColor = Color.LightSteelBlue
            eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "Se han arreglado los problemas, preparando cambio de fuente" & vbCrLf
            txtEventos.Text = eventos
            Tt = 2
            Timer3.Interval = 3000
            Timer3.Enabled = True
            Timer3.Start()
            Timer4.Stop()
        End If
        a = a + 1


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
        txtOff.Enabled = False
        btnActualizar.Enabled = False
        btnCausar.Enabled = False
        btnMantenimiento.Enabled = False
        btnOff.Enabled = False
        btnProvocar.Enabled = False
        btnRed.Enabled = False
        btnSimular.Enabled = False
        btnDetener.Enabled = False
        btnIniciar.Enabled = True
        Reanudar.Enabled = True
        txtEventos.Text = eventos
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()
        Timer5.Stop()
    End Sub

    Private Sub txtOff_TextChanged(sender As Object, e As EventArgs) Handles txtOff.TextChanged

    End Sub

    Private Sub txtInterior_TextChanged(sender As Object, e As EventArgs) Handles txtInterior.TextChanged

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub btnReanudar_Click(sender As Object, e As EventArgs) Handles Reanudar.Click
        eventos = eventos & vbCrLf & "[" & Tiempo & "] " & "La simulación se ha reanudado."
        txtEventos.Text = eventos 'se cambia el texto del cuadro "Registro de eventos"
        btnDetener.Enabled = True
        Reanudar.Enabled = False
        txtEventos.Text = eventos
        Timer1.Start()
        If Tt = 1 Then
            Timer4.Start()
            Timer4.Interval = 1500
            If a < 2 Then
                a = 2
            End If
        End If
        If Tt = -2 Or Tt = -1 Or Tt = 0 Or Tt = 2 Then
            Timer3.Start()
            Timer3.Interval = 3000
        End If
        Timer5.Start()
    End Sub

End Class


