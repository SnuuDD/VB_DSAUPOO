Public Class Desc_Desglo

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Limpiar.Click
        Txtdesc.Text = ""
        Txtsegundo.Text = ""
        txtprimero.Text = ""
        Lbltotal.Text = ""
        Lbldosproductos.Text = ""
        Lbldesc.Text = ""

    End Sub

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        End
    End Sub

    Private Sub Btn_Calcula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Calcula.Click
        Dim x1, x2, desc, d, res1, res2 As Double
        x1 = Val(txtprimero.Text)
        x2 = Val(Txtsegundo.Text)
        d = Val(Txtdesc.Text)
        desc = d * 100
        res1 = x1 + x2
        res2 = res1 - desc

        Lbldosproductos.Text = "$ " & res1
        Lbldesc.Text = desc & " %"
        Lbltotal.Text = "$ " & res2
    End Sub

    Private Sub Desc_Desglo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
