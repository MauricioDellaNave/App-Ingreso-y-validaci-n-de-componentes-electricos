Imports System.IO

Public Class Articulos

#Region "Declaraciones"

    Public macceso As String

#End Region

#Region "Metodos"

    Public Function longArticulo(ByVal articulo As String) As Boolean
        'valido la longitud del articulo
        If articulo.Length < FrmParametros.txtArticulo.Value Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function longSerial(ByVal serial As String) As Boolean
        'valido la longitud del articulo
        If serial.Length < FrmParametros.txtSerial.Value Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function longEtiqueta(ByVal etiqueta As String) As Boolean
        'valido la longitud del articulo
        If etiqueta.Length < FrmParametros.txtEtiqueta.Value Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function loginClave(ByVal clave As String) As Boolean
        '///////////////////////////////
        'Creamos la carpeta UPLOAD
        If Not Directory.Exists("\Upload") Then
            Directory.CreateDirectory("\Upload")
            'creamos el archivo txt y escribimos
            Dim ruta As String = "\Upload\clave.txt"
            'MsgBox("el txt no existe lo creo")
            Dim sw As New System.IO.StreamWriter(ruta)
            sw.WriteLine("123456")
            sw.Close()

        End If
        '///////////////////////////////

        'valido la clave desde el archivo
        Const fic As String = "\Upload\clave.txt"
        Dim txtclave As String

        Dim sr As New System.IO.StreamReader(fic)
        txtclave = sr.ReadLine
        sr.Close()

        If txtclave = clave Then
            Return True
        Else
            Return False
        End If

    End Function

#End Region

End Class
