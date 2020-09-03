Public Class Evalua_Numeros

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        End

    End Sub

    Private Sub Btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Limpiar.Click
        mayor.Visible = False
        menor.Visible = False
        igual.Visible = False
        n1.Text = ""
        n3.Text = ""
        n2.Text = ""
    End Sub

    Private Sub apa_desapa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mayor.Click

    End Sub

    Private Sub Btn_Acción_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Acción.Click
        mayor.Visible = True
        menor.Visible = True
        igual.Visible = True
        If n1.Text > n2.Text And n1.Text > n3.Text Then
            mayor.Text = ("El numero mayor es : " & n1.Text)
        ElseIf n2.Text > n1.Text And n2.Text > n3.Text Then
            mayor.Text = ("El numero mayor es : " & n2.Text)
        ElseIf n3.Text > n2.Text And n3.Text > n1.Text Then
            mayor.Text = ("El numero mayor es : " & n3.Text)
        End If
        If n1.Text = n2.Text And n1.Text = n3.Text And n2.Text = n3.Text Then
            igual.Text = ("Los numeros: " & n1.Text & ", " & n2.Text & " y " & n3.Text & " son iguales.")
            mayor.Visible = False
            menor.Visible = False
        ElseIf n1.Text = n2.Text And n3.Text <> n1.Text Then
            igual.Text = ("El numero: " & n3.Text & " es diferente.")
            mayor.Visible = False
            menor.Visible = False
        ElseIf n3.Text = n2.Text And n1.Text <> n2.Text Then
            igual.Text = ("El numero: " & n1.Text & " es diferente.")
            mayor.Visible = False
            menor.Visible = False
        ElseIf n1.Text = n3.Text And n2.Text <> n1.Text Then
            igual.Text = ("El numero: " & n2.Text & " es diferente.")
            mayor.Visible = False
            menor.Visible = False
        End If
        If n1.Text < n2.Text And n1.Text < n3.Text Then
            menor.Text = ("El numero menor es : " & n1.Text)
        ElseIf n2.Text < n1.Text And n2.Text < n3.Text Then
            menor.Text = ("El numero menor es : " & n2.Text)
        ElseIf n3.Text < n2.Text And n3.Text < n1.Text Then
            menor.Text = ("El numero menor es : " & n3.Text)
        End If
    End Sub

End Class
