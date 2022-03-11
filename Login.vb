Option Explicit On

Public Class Login

    '    Public oclave As Articulos

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Visible = False
        Me.txtclave.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Select Case FrmPrincipal.oclave.macceso

            Case "salir"

                If FrmPrincipal.oclave.loginClave(Me.txtclave.Text) = True Then
                    Me.txtclave.Text = ""
                    FrmPrincipal.Close()
                Else
                    MsgBox("Clave Incorrecta. Contactese con el administrador del sistema.", MsgBoxStyle.Critical, "Informacion del Sistema.")
                    Me.txtclave.Text = ""
                    Me.txtclave.Focus()
                End If

            Case "configurar"

                If FrmPrincipal.oclave.loginClave(Me.txtclave.Text) = True Then
                    Me.txtclave.Text = ""
                    FrmConfiguracion.Visible = True
                Else
                    MsgBox("Clave Incorrecta. Contactese con el administrador del sistema.", MsgBoxStyle.Critical, "Informacion del Sistema.")
                    Me.txtclave.Text = ""
                    Me.txtclave.Focus()
                End If


        End Select
    End Sub

    Private Sub txtclave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtclave.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            Select Case FrmPrincipal.oclave.macceso

                Case "salir"

                    If FrmPrincipal.oclave.loginClave(Me.txtclave.Text) = True Then
                        Me.txtclave.Text = ""
                        FrmPrincipal.Close()
                    Else
                        MsgBox("Clave Incorrecta. Contactese con el administrador del sistema.", MsgBoxStyle.Critical, "Informacion del Sistema.")
                        Me.txtclave.Text = ""
                        Me.txtclave.Focus()
                    End If

                Case "configurar"

                    If FrmPrincipal.oclave.loginClave(Me.txtclave.Text) = True Then
                        Me.txtclave.Text = ""
                        FrmConfiguracion.Visible = True
                    Else
                        MsgBox("Clave Incorrecta. Contactese con el administrador del sistema.", MsgBoxStyle.Critical, "Informacion del Sistema.")
                        Me.txtclave.Text = ""
                        Me.txtclave.Focus()
                    End If


            End Select
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Timer1.Interval = 5000
        MsgBox("Hola. Iré adiós en 5 segundos")
        Me.Timer1.Interval = 0
    End Sub
End Class