Public Class Nivel_Escolar

    Private Sub Btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Limpiar.Click
        apa_desapa.Visible = False
        txtprimero.TabIndex = 0
        txtprimero.Text = ""
        txtprimero.TabIndex = 0
    End Sub

    Private Sub Btn_Acción_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Acción.Click
        apa_desapa.Visible = True
        If Val(txtprimero.Text) <= 4 And Val(txtprimero.Text) >= -2 Then
            apa_desapa.Text = ("Estas MUY PEQUEÑO AÚN ☻")
        ElseIf txtprimero.Text <= 5 And txtprimero.Text >= 3 Then
            apa_desapa.Text = ("Estas cursando PREESCOLAR")
        ElseIf txtprimero.Text >= 6 And txtprimero.Text <= 11 Then
            apa_desapa.Text = ("Estas cursando PRIMARIA")
        ElseIf txtprimero.Text >= 12 And txtprimero.Text <= 14 Then
            apa_desapa.Text = ("Estas cursando SECUNDARIA")
        ElseIf txtprimero.Text >= 15 And txtprimero.Text <= 18 Then
            apa_desapa.Text = ("Estas cursando PREPARATORIA")
        ElseIf txtprimero.Text >= 19 And txtprimero.Text <= 27 Then
            apa_desapa.Text = ("Estas cursando UNIVERSIDAD")
        End If

    End Sub

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        End

    End Sub
End Class
