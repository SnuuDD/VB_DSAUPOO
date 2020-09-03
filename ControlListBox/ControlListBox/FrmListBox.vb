Public Class FrmListBox

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        End
    End Sub

    Private Sub Btn_Acción_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Acción.Click
        Dim num As Integer
        num = InputBox("Escribe un numero", "Baia Baia :v")
        MsgBox("El numero que usted introdujo es: " & num)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnagregar.Click
        Dim num As Integer
        num = Val(Textnumagregar.Text)
        lslnum.Items.Add(num)
        Textnumagregar.Text = ""
        Textnumagregar.Focus()



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        lslnum.Items.Clear()
        Textnumagregar.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim posicion, cant As Integer
        posicion = InputBox("Escribe la posicion del dato borrar", "Baia Baia :v")
        cant = lslnum.Items.Count
        If (posicion <= cant) Then
            lslnum.Items.RemoveAt(posicion)
        Else
            MsgBox("¡NO EXISTE ESA POSICON!", MsgBoxStyle.Critical)
            Textnumagregar.Focus()

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim cant, n, num As Integer
        cant = lslnum.Items.Count
        For n = 0 To cant - 1
            num = lslnum.Items(n)
            ListBox1.Items.Add(num)
        Next
    End Sub
End Class
