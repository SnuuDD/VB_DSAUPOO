Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cont As String
        cont = InputBox("Ingresa la letra")
        While cont <> "s"
            MsgBox("No le atinaste")
            cont = InputBox("Ingresa la letra")
        End While
        MsgBox("LE ATINASTE :v")
        End

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
