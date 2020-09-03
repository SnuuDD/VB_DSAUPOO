Public Class Form1
    Dim acomulador As String = ""


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
                Dim acont, a, x, y As Integer
        x = Val(txttamblax.Text)
        y = Val(txthasta.Text)
        For acont = 1 To y Step 1
            a = a + 1
            acomulador = acomulador & x & " x " & a & " = " & x * a & vbCrLf
        Next
        MsgBox("La tabla del " & x & " es: " & vbCrLf & acomulador & vbCrLf)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim acont, x As Integer
        For acont = 2 To 20 Step 2
            x = x + 1
            acomulador = acomulador & "2 x " & x & " = " & acont & vbCrLf
        Next
        MsgBox("La tabla del 2 es: " & vbCrLf & acomulador & vbCrLf)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim acont, x, y As Integer
        y = txttabla.Text
        For acont = y To y * 10 Step y
            x = x + 1
            acomulador = acomulador & y & " x " & x & " = " & acont & vbCrLf
        Next
        MsgBox("La tabla del " & y & " es: " & vbCrLf & acomulador & vbCrLf)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttamblax.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txthasta.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        End
    End Sub

    Private Sub txttabla_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttabla.TextChanged

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        txthasta.Text = ""
        txttabla.Text = ""
        txttamblax.Text = ""
        acomulador = ""
    End Sub
End Class
