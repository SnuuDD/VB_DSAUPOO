Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CboOperaciones.Text = ""
        txtnum1.Text = ""
        Txtnum2.Text = ""
    End Sub

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        End

    End Sub

    Private Sub Btn_Acción_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Acción.Click
        Dim num1, num2, res As Double
        Dim opc As String
        num1 = Val(txtnum1.Text)
        num2 = Val(Txtnum2.Text)
        opc = CboOperaciones.Text
        Select Case opc
            Case "Suma"
                res = num1 + num2
                MsgBox("El resultado de la suma es: " & res, vbInformation, "RESULTADO")
            Case "Resta"
                res = num1 - num2
                MsgBox("El resultado de la resta es: " & res, vbInformation, "RESULTADO")
            Case "Multiplicación"
                res = num1 * num2
                MsgBox("El resultado de la multiplicación es: " & res, vbInformation, "RESULTADO")
            Case "División"
                res = num1 / num2
                MsgBox("El resultado de la división es: " & res, vbInformation, "RESULTADO")


        End Select
    End Sub
End Class
