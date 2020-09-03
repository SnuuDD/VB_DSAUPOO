Public Class Form1

    Private Sub Btn_Sum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Sum.Click
        Dim x, y, c, d As Integer
        If Val(menor.Text) > Val(mayor.Text) Then
            MsgBox("¡EL NUMERO MENOR NO PUEDE SER MAS GRANDE!")
            MsgBox("PORFAVOR CORRRIGELO")
            MsgBox("¡ :V !")
        ElseIf Val(menor.Text) = Val(mayor.Text) Then
            MsgBox("¡LOS NUMEROS NO PUEDEN SER IGUALES!")
            MsgBox("PORFAVOR CORRRIGELOS")
            MsgBox("¡ >:v !")
        ElseIf Val(menor.Text) < Val(mayor.Text) Then
            If Val(menor.Text) Mod 2 = 0 Then
                x = Val(menor.Text)
                y = Val(mayor.Text)
                While x > y
                    x = x + 2
                    c = x + x

                End While
                MsgBox("La suma de los numeros es: " & c)
            End If

        End If
    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
    Private Sub Txtnumero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menor.TextChanged

    End Sub
    Private Sub Txtnumero2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mayor.TextChanged

    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        End
    End Sub
    Private Sub Btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Limpiar.Click

    End Sub
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
End Class
