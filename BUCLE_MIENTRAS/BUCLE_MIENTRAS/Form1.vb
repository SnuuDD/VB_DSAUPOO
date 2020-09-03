Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cont As Integer
        Dim a As String
        cont = 1
        While cont < 5
            a = a + (cont & vbCrLf)
            cont = cont + 1

        End While
        MsgBox(a)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNumeros.Click
        Dim a, b, cont As Integer
        Dim ac As String
        a = InputBox("INGRESA EL NUMERO  DE INICIO")

        b = InputBox("INGRESA EL NUMERO  DE FIN")

        cont = a
        While cont < b + 1
            ac = ac + (cont & vbCrLf)
            cont = cont + 1
        End While
        MsgBox(ac)
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub BtnAtinale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAtinale.Click
        Dim x As String
        x = InputBox("TECLEA UNA LETRA CUALQUIERA")
        While x <> ("S") Or x = ("s")

            If x = ("S") Or x = ("s") Then
                MsgBox("¡¡FELICIDADES!!...LE ATINASTE")
                End

            ElseIf x <> ("S") Or x <> ("s") Then
                MsgBox("NO LE ATINASTE")
                x = InputBox("TECLEA UNA LETRA CUALQUIERA")

            End If

        End While
    End Sub
End Class
