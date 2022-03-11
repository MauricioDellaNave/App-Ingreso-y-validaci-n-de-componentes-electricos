Option Explicit On
Imports System.IO
Imports ClienteFTPPDA
Imports System.Windows.Forms.Keys
Imports System.Drawing


Public Class FrmIngreso

#Region "Declaraciones"

    Dim mlongArticulo As New Articulos
    Dim mlongSerial As New Articulos
    Dim mlongEtiqueta As New Articulos
    Dim ArchivoEnviado As String
    Dim ArchivoRenombrado As String

#End Region

#Region "Eventos Form"

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        FrmPrincipal.Visible = True
        Me.Visible = False
    End Sub

    Private Sub FrmIngreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Visible = True
        Me.txtArticulo1.Focus()  
    End Sub

    Private Sub txtArticulo1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtArticulo1.KeyPress
        'Se comprueba si el ingreso es Numerico
        If Not Char.IsNumber(e.KeyChar) Then
            'Indico que no ingresamos nada
            e.Handled = True
        End If

        'Al cargar la lectura con enter paso al otro registro
        If e.KeyChar = ChrW(Keys.Enter) Then

            ' verifico longitud del articulo ingresado
            If mlongArticulo.longArticulo(Me.txtArticulo1.Text) = False Then
                'MsgBox("Longitud no valida", MsgBoxStyle.Information, "Articulo")
                Me.ErrorLongitud.Visible = True

                Me.txtArticulo1.Text = ""
                Me.txtArticulo1.Focus()
            Else
                Me.txtArticulo1.Enabled = False
                Me.txtSerial.Focus()
            End If

        End If
    End Sub

    Private Sub txtSerial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerial.KeyPress
        'Se comprueba si el ingreso es Numerico
        If Not Char.IsNumber(e.KeyChar) Then
            'Indico que no ingresamos nada
            e.Handled = True
        End If

        'Al cargar la lectura con enter paso al otro registro
        If e.KeyChar = ChrW(Keys.Enter) Then

            ' verifico longitud del serial ingresado
            If mlongSerial.longSerial(Me.txtSerial.Text) = False Then
                'MsgBox("Longitud no valida", MsgBoxStyle.Information, "Serial")
                Me.ErrorLongitud.Visible = True
                Me.txtSerial.Text = ""
                Me.txtSerial.Focus()
            Else
                Me.txtSerial.Enabled = False
                Me.txtArticulo2.Focus()
            End If

        End If
    End Sub

    Private Sub txtArticulo2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtArticulo2.KeyPress
        'Se comprueba si el ingreso es Numerico
        If Not Char.IsNumber(e.KeyChar) Then
            'Indico que no ingresamos nada
            e.Handled = True
        End If

        'Al cargar la lectura con enter paso al otro registro
        If e.KeyChar = ChrW(Keys.Enter) Then

            ' verifico longitud del articulo ingresado
            If mlongArticulo.longArticulo(Me.txtArticulo2.Text) = False Then
                'MsgBox("Longitud no valida", MsgBoxStyle.Information, "Articulo")
                Me.ErrorLongitud.Visible = True
                Me.txtArticulo2.Text = ""
                Me.txtArticulo2.Focus()
            Else
                'Me.txtArticulo2.Enabled = False
                Me.txtEtiqueta.Focus()
            End If

            ' verifico la coincidencia entre ambos articulos
            If Not Me.txtArticulo1.Text = Me.txtArticulo2.Text Then
                'MsgBox("El articulo ingresado no es el correcto", MsgBoxStyle.Information, "Articulo")
                Me.ErrorArticulo.Visible = True
                Me.txtArticulo2.Text = ""
                Me.txtArticulo2.Focus()
            Else
                Me.txtArticulo2.Enabled = False
                Me.txtEtiqueta.Focus()
            End If

        End If
    End Sub

    Private Sub txtEtiqueta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEtiqueta.KeyPress
        'Se comprueba si el ingreso es Numerico
        If Not Char.IsNumber(e.KeyChar) Then
            'Indico que no ingresamos nada
            e.Handled = True
        End If

        'Al cargar la lectura con enter paso al otro registro
        If e.KeyChar = ChrW(Keys.Enter) Then

            ' verifico longitud del campo etiqueta
            If mlongEtiqueta.longEtiqueta(Me.txtEtiqueta.Text) = False Then
                'MsgBox("Longitud no valida", MsgBoxStyle.Information, "Etiqueta")
                Me.ErrorLongitud.Visible = True
                Me.txtEtiqueta.Text = ""
                Me.txtEtiqueta.Focus()
            Else
                Me.txtEtiqueta.Enabled = False
                '/////////////////ARCHIVO////////////////////

                Try

                    'Creamos la carpeta UPLOAD
                    If Not Directory.Exists("\Upload") Then
                        MsgBox("Se creo la carpeta \UPLOAD donde se almacenaran las lecturas", MsgBoxStyle.Information, "Informacion del Sistema")
                        Directory.CreateDirectory("\Upload")

                        'creamos el archivo txt y escribimos
                        Const fic As String = "\Upload\Lecturas.txt"
                        'MsgBox("el txt no existe lo creo")
                        Dim sw As New System.IO.StreamWriter(fic)
                        sw.WriteLine(Me.txtArticulo1.Text & "," & Me.txtSerial.Text & "," & Me.txtArticulo2.Text & "," & Me.txtEtiqueta.Text & "," & Format(Now(), "ddMMyyyy") & "," & Format(Now(), "hhmmss"))
                        sw.Close()


                    Else

                        'escribimos en el archivo txt ya existente
                        Const fic As String = "\Upload\Lecturas.txt"
                        'MsgBox("el txt ya existe escribo linea nueva")
                        Dim sw As New System.IO.StreamWriter(fic, True)
                        sw.WriteLine(Me.txtArticulo1.Text & "," & Me.txtSerial.Text & "," & Me.txtArticulo2.Text & "," & Me.txtEtiqueta.Text & "," & Format(Now(), "ddMMyyyy") & "," & Format(Now(), "hhmmss"))
                        sw.Close()

                    End If


                Catch oe As Exception
                    MsgBox(oe.Message, MsgBoxStyle.Critical)
                End Try

                'MsgBox("Los datos se almacenaron satisfactoriamente.", MsgBoxStyle.Information, "Carga de datos Exitosa")
                Me.CargaExitosa.Visible = True

                'Borro todos los registros
                Me.txtArticulo1.Text = ""
                Me.txtSerial.Text = ""
                Me.txtArticulo2.Text = ""
                Me.txtEtiqueta.Text = ""
                Me.txtArticulo1.Enabled = True
                Me.txtSerial.Enabled = True
                Me.txtArticulo2.Enabled = True
                Me.txtEtiqueta.Enabled = True
                Me.txtArticulo1.Focus()
            End If

        End If
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        If (MsgBox("¿Esta seguro que desea borrar todos los registros?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Información del Sistema")) = MsgBoxResult.Yes Then
            Me.txtArticulo1.Text = ""
            Me.txtSerial.Text = ""
            Me.txtArticulo2.Text = ""
            Me.txtEtiqueta.Text = ""
            Me.txtArticulo1.Enabled = True
            Me.txtSerial.Enabled = True
            Me.txtArticulo2.Enabled = True
            Me.txtEtiqueta.Enabled = True
            Me.txtArticulo1.Focus()
        End If
    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click


        'Configuro la conexion FTP

        Dim cftp As New ClienteFTPPDA.ClienteFTP(FrmConexion.txtDominio.Text, FrmConexion.txtUsuario.Text, FrmConexion.txtClave.Text, "Upload", FrmConexion.txtPuerto.Value)

        Try
            If cftp.Login() Then
                cftp.TipoServidor = True
                'renombro el archivo Lecturas con la fecha de envio antes de enviarlo
                '////////////////////////////////////////////////
                Const Origen As String = "\Upload\Lecturas.txt"
                ArchivoEnviado = ("\Upload\" & Format(Now(), "yyyyMMdd_hhmmss") & ".txt")
                File.Move(Origen, ArchivoEnviado)
                '///////////////////////////////////////////////
                cftp.UploadFile(ArchivoEnviado, True)
                MsgBox("El archivo a sido enviado satisfactoriamente", MsgBoxStyle.Information, "Archivo enviado")
                Me.txtArticulo1.Focus()
            Else
                MsgBox("Verifique tener activo Wifi y los datos de su cuenta FTP.", MsgBoxStyle.Critical, "Error conexion FTP")
                Me.txtArticulo1.Focus()
            End If
        Catch ex As Exception
        End Try
        cftp.LogOut()

    End Sub


#End Region

End Class