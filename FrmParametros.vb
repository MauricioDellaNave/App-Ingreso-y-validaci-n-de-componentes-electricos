Public Class FrmParametros

    Private Sub NumericUpDown3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEtiqueta.ValueChanged

    End Sub

    Private Sub NumericUpDown2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerial.ValueChanged

    End Sub

    Private Sub Label6_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.ParentChanged

    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        FrmConfiguracion.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Longitud de los textbox del formulario de ingreso
        FrmIngreso.txtArticulo1.MaxLength = Me.txtArticulo.Value
        FrmIngreso.txtArticulo2.MaxLength = Me.txtArticulo.Value
        FrmIngreso.txtSerial.MaxLength = Me.txtSerial.Value
        FrmIngreso.txtEtiqueta.MaxLength = Me.txtEtiqueta.Value

        MsgBox("Parametros cargados correctamente", MsgBoxStyle.Information, "Informacion del Sistema")

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub
End Class