Public Class frmacumulador
    Dim acumular As Integer

    Public Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim num As Integer
        num = Val(Txtnum2.Text)
        acumular = acumular + num
        Txtnum2.Text = ""
        Txtnum2.Focus()

    End Sub

    Private Sub Btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Limpiar.Click
        MsgBox("EL TOTAL DE LA ACUMULACION ES: " & acumular, vbInformation)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        acumular = 0
    End Sub

    Private Sub frmacumulador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
