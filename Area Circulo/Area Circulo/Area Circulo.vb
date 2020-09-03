Public Class Frmarea

    Private Sub Btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Limpiar.Click
        txtradio.Text = ""
        lblresultado.Text = "El area del resultado es:          ,  cuando el radio es:          ."
    End Sub

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        End

    End Sub

    Private Sub Frmarea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_Calcula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Calcula.Click
        Const PI = 3.1416
        Dim x, res As Double
        x = Val(txtradio.Text)
        res = x * x * PI
        ' lblresultado.Text = "El area del resultado es: " & res & " ,  cuando el radio es: " & x & " ." '
        MsgBox("El circulo con radio: " & x & vbCrLf & "Tiene un area de: " & res & " .", vbExclamation, "Ventana Resultado")
    End Sub

    Private Sub lblresultado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblresultado.Click

    End Sub
End Class
