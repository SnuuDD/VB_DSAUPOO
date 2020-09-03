Public Class If_Simple

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Limpiar.Click
        Txtdesc.Text = ""
    End Sub

    Private Sub Btn_Calcula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Calcula.Click
        If Txtdesc.Text >= 1 Then
            MsgBox("El numero: " & Txtdesc.Text & " es POSITIVO, y multiplicado por 20 nos da: " & Txtdesc.Text * 20, MsgBoxStyle.Information)
        ElseIf Txtdesc.Text <= -1 Then
            MsgBox("El numero: " & Txtdesc.Text & " es NEGATIVO, y multiplicado por -2 nos da: " & Txtdesc.Text * -2, MsgBoxStyle.Information)
        Else : Txtdesc.Text = 0
            MsgBox("El numero: " & Txtdesc.Text & " es NEUTRO", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        End
    End Sub

    Private Sub Txtdesc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtdesc.TextChanged

    End Sub
End Class
