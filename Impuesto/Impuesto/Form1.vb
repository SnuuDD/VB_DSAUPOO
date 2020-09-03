Public Class Form1

    Private Sub CboOperaciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboOperaciones.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim a, b, c, d, e2, f, g, h, i, j, k, l As Double
        Dim opc As String
        opc = CboOperaciones.Text
        a = a1.Text
        b = Val(a1.Text) * (0.08)
        b1.Text = b
        c = Val(a1.Text) * (.03)
        c1.Text = c
        e2 = Val(a1.Text) * (0.02)
        e1.Text = e2
        f = Val(a1.Text) * (0.05)
        f1.Text = f
        g = Val(a1.Text) * (0.03)
        g1.Text = g
        h = Val(a1.Text) * (0.05)
        h1.Text = h
        i = Val(a1.Text) * (0.05)
        i1.Text = i

        Select opc
            Case "QA"
                d = Val(a1.Text) * (0.05)
                d1.Text = d
            Case "QB"
                d = Val(a1.Text) * (0.07)
                d1.Text = d
            Case "QC"
                d = Val(a1.Text) * (0.1)
                d1.Text = d
            Case "QD"
                d = Val(a1.Text) * (0.15)
                d1.Text = d
        End Select
        j = Val(a1.Text) + b + c + Val(d1.Text)
        j1.Text = j
        k = e2 + f + g + h + i
        k1.Text = k
        l = j - k
        l1.Text = l
       


    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        a1.Text = ""
        b1.Text = ""
        c1.Text = ""
        d1.Text = ""
        e1.Text = ""
        f1.Text = ""
        g1.Text = ""
        h1.Text = ""
        i1.Text = ""
        j1.Text = ""
        k1.Text = ""
        l1.Text = ""
        TextBox13.Text = ""
        CboOperaciones.Text = ""
    End Sub
End Class
