Public Class Frmcalculadora

    Private Sub Frmcalculadora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Sum.Click
        Dim x, y, res As Integer
        x = Val(Txtnumero.Text)
        y = Val(Txtnumero2.Text)
        res = x + y
        lblresultado.Text = res
    End Sub

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        End
    End Sub

    Private Sub Btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Limpiar.Click
        Txtnumero.Text = ""
        Txtnumero2.Text = ""
        lblresultado.Text = "___"
    End Sub

    Private Sub Btn_Men_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Men.Click
        Dim x, y, res As Integer
        x = Val(Txtnumero.Text)
        y = Val(Txtnumero2.Text)
        res = x - y
        lblresultado.Text = res
    End Sub

    Private Sub Btn_mul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_mul.Click
        Dim x, y, res As Integer
        x = Val(Txtnumero.Text)
        y = Val(Txtnumero2.Text)
        res = x * y
        lblresultado.Text = res
    End Sub

    Private Sub Btn_Div_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Div.Click
        Dim x, y, res As Double
        x = Val(Txtnumero.Text)
        y = Val(Txtnumero2.Text)
        res = x / y
        lblresultado.Text = res
    End Sub

    Private Sub lblresultado_Click(sender As Object, e As EventArgs) Handles lblresultado.Click

    End Sub
End Class
