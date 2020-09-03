Public Class FrmBarraInicio
    Dim contador As Byte
    Private Sub Timer_Tiempo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Tiempo.Tick
        If ProgressBar_Cargar.Value = 100 Then
            Me.Opacity = Me.Opacity - 0.07
            If Me.Opacity = 0.0 Then
                Me.Hide()
                FrmMenu.Show()
                Timer_Tiempo.Enabled = False
            End If
        Else
            ProgressBar_Cargar.Value = ProgressBar_Cargar.Value + 4
            If ProgressBar_Cargar.Value = contador Then
                LblCargando.Text = "CARGANDO BASE DE DATOS"
                LblEsperar.Text = "ESPERE"
            Else
                If ProgressBar_Cargar.Value = contador + 16 Then
                    LblCargando.Text = ""
                    LblEsperar.Text = ""
                    contador = contador + 20

                End If
            End If
        End If
    End Sub
End Class