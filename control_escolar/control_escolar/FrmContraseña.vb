Public Class FrmContraseña
    Dim cont, cont1 As Integer
    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim usuario, contraseña As String
        Dim i As Integer

        usuario = TxtUsuario.Text
        contraseña = TxtContraseña.Text

        If cont = 2 Or cont1 = 2 Then
            End
        End If
        
        cont = cont + 1
        If usuario = "brenda" And contraseña = "maestra" Or usuario = "belen" And contraseña = "mendieta" Then
            Me.Hide()
            FrmBarraInicio.Show()

        Else
            If usuario <> "brenda" Or contraseña <> "maestra" Or usuario = "belen" And contraseña <> "mendieta" Then
                MsgBox("ERROR:Contraseña incorrecta")

                TxtContraseña.Text = ""
            ElseIf usuario <> "belen" And contraseña = "mendieta" Or usuario <> "brenda" And contraseña = "maestra" Then
                MsgBox("ERROR:Usuario.incorrecta")

                TxtContraseña.Clear()
            End If
        End If
    End Sub
End Class
