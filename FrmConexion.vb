Public Class FrmConexion

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        FrmConfiguracion.Visible = True
        Me.Visible = False
    End Sub

    Private Sub rdInalambrica_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub rdCable_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub FrmConexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtDominio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDominio.TextChanged

    End Sub

    Private Sub txtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub txtClave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClave.TextChanged

    End Sub

    Private Sub Label1_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.ParentChanged

    End Sub

    Private Sub Label2_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.ParentChanged

    End Sub

    Private Sub Label3_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.ParentChanged

    End Sub

    Private Sub Label4_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.ParentChanged

    End Sub

    Private Sub txtPuerto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPuerto.ValueChanged

    End Sub
End Class