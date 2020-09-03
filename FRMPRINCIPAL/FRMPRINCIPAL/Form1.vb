Public Class Form1

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub j1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles j1.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        FRM2.Show()
        FRM2.Label2.Text = k1.Text
        FRM2.Label6.Text = k1.Text
        FRM2.Label3.Text = j1.Text


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub
End Class
