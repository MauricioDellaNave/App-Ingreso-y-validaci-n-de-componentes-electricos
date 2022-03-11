Option Explicit On
Module Modulo

    ' Declaraciones del Api   
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''   

    ' finaliza el temporizador creado con SetTimer   
    Public Declare Function KillTimer Lib "user32" ( _
        ByVal hwnd As Long, _
        ByVal nIDEvent As Long) As Long

    ' PAra buscar el Handle del Msgbox   
    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" ( _
        ByVal lpClassName As String, _
        ByVal lpWindowName As String) As Long

    ' Para crear el timer   
    Public Declare Function SetTimer Lib "user32" ( _
        ByVal hwnd As Long, _
        ByVal nIDEvent As Long, _
        ByVal uElapse As Long, _
        ByVal lpTimerFunc As Long) As Long


    ' cierra el Msgbox a partir del Handle   
    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" ( _
        ByVal hwnd As Long, _
        ByVal wMsg As Long, _
        ByVal wParam As Long, _
    ByVal lParam As String) As Long

    Const SC_CLOSE = &HF060&
    Const WM_SYSCOMMAND = &H112
    Public Miliseg As Long
    Private hMessageBox As Long
    Public TIULO_MSGBOX As String
    'Public hwnd As Long


    ' Función para el temporizador   
    '''''''''''''''''''''''''''''''''''''''''''''''''''   
    Public Sub TimerProc(ByVal hwnd As Long, _
                         ByVal uMsg As Long, _
                         ByVal idEvent As Long, _
                         ByVal dwTime As Long)

        ' handle del cuadro de mensaje   
        hMessageBox = FindWindow("#32770", TIULO_MSGBOX)

        If hMessageBox Then
            ' lo cierra   
            Call SendMessage(hMessageBox, WM_SYSCOMMAND, SC_CLOSE, 0&)
        End If
        ' finaliza este timer   
        KillTimer(hwnd, 1)
    End Sub

End Module
