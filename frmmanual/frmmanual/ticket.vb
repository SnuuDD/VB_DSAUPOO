Public Class ticket
    Dim total, efec As Double
    Private Sub TxtEfectivo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEfectivo.TextChanged
        Dim cambio As Double
        total = Val(LblTotal.Text)
        efec = Val(TxtEfectivo.Text)
        cambio = efec - total
        TxtCambio.Text = cambio
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BtnTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTicket.Click
        Dim t As String
        t = Val(TxtEfectivo.Text)

        If t = "" Then
            MsgBox("NO HAS PAGADO :v")
        Else
            MsgBox("Tienda de Abarrotes :v" & vbCrLf & "Producto     Precio       Cantidad" & vbCrLf & TiendaP.Label5.Text & "           " & TiendaP.Label6.Text & "             " & TiendaP.Label7.Text & vbCrLf & TiendaP.Label10.Text & "        " & TiendaP.Label9.Text & "       " & TiendaP.Label8.Text & vbCrLf & TiendaP.Label13.Text & "      " & TiendaP.Label12.Text & "        " & TiendaP.Label11.Text & vbCr & "Total. : $" & (total))
        End If

    End Sub
End Class