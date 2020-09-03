Public Class Form2
    Dim CONTADOR As Byte
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Me.Opacity = Me.Opacity - 0.1
            If Me.Opacity = 0.0 Then
                Me.Hide()
                Form1.Show()
                Timer1.Enabled = False
            End If
        Else
            ProgressBar1.Value = ProgressBar1.Value + 4
            If ProgressBar1.Value = CONTADOR Then
                LBLCA.Text = "CARGANDO BASE :v ........."
                LBLES.Text = "ESPERE :'v"
            Else
                If ProgressBar1.Value = CONTADOR + 36 Then
                    LBLCA.Text = "CARGANDO BASE :v ........."
                    LBLES.Text = "ESPERE :'v"
                    CONTADOR = 20 + 20
                End If
            End If
        End If
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub
End Class