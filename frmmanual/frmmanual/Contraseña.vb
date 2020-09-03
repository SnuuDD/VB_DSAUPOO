Public Class Contraseña

    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        If (contra.Text = "Jesus_MJ" And usuario.Text = "jesus") Or (contra.Text = "corderuki" And usuario.Text = "angel") Then
            Me.Hide()
            Form2.Show()
        ElseIf (contra.Text = "" And usuario.Text = "") Then
            MsgBox("INGRESA LOS DATOS >:v")
        ElseIf (contra.Text <> "Jesus_MJ" Or usuario.Text <> "jesus") Or (contra.Text <> "corderuki" Or usuario.Text <> "angel") Then
            MsgBox("NOMBRE DE USUARIO O CONTRASEÑA ERRONEOS >:v")
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        End
    End Sub
End Class