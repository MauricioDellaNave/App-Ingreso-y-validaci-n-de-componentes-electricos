'Imports ClienteFTPPDA

Public Class FrmPrincipal

    Dim txtclave As String
    Public oclave As New Articulos

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Login.Visible = True
        Login.txtclave.Focus()
        oclave.macceso = "salir"
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmConfiguracion.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Se eliminaran los datos cargados", MsgBoxStyle.OkCancel, "Informacion del Sistema")
    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        FrmIngreso.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        oclave.macceso = "configurar"
        Login.Visible = True
        Login.txtclave.Text = ""
        Login.txtclave.Focus()
    End Sub

    Private Sub FrmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Visible = True
    End Sub

End Class
