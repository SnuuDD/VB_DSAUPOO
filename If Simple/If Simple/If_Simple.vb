Public Class If_Simple

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Limpiar.Click
        Txtdesc.Text = ""
    End Sub

    Private Sub Btn_Calcula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Calcula.Click
        If Txtdesc.Text >= 20 Then
            MsgBox(" LE ATINASTE", MsgBoxStyle.Information)
        Else
            MsgBox("Sigue intentado :C ", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        End
    End Sub

    Private Sub Txtdesc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtdesc.TextChanged

    End Sub
End Class
