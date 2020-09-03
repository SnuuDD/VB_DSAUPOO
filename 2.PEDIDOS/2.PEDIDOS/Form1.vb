Public Class Form1
    Dim x, y, z, a, b, c, total, efec As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RBtnPequeña_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnPequeña.CheckedChanged
        If RBtnPequeña.Checked = True
            x = 120
        End If
    End Sub

    Private Sub RBtnMed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnMed.CheckedChanged
        If RBtnMed.Checked = True Then
            x = 150
        End If
    End Sub

    Private Sub RBtnGrande_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnGrande.CheckedChanged
        If RBtnGrande.Checked = True Then
            x = 190
        End If
    End Sub

    Private Sub RBtnPepperoni_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnPepperoni.CheckedChanged
        If RBtnPepperoni.Checked = True Then
            y = 20
        End If
    End Sub

    Private Sub RBtnHawaiana_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnHawaiana.CheckedChanged
        If RBtnHawaiana.Checked = True Then
            y = 15
        End If
    End Sub

    Private Sub RBtnMexicana_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBtnMexicana.CheckedChanged
        If RBtnMexicana.Checked = 1 Then
            y = 25
        End If
    End Sub

    Private Sub CheckExtra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckExtra.CheckedChanged
        If CheckExtra.CheckState = 1 Then
            a = 10
        ElseIf CheckExtra.CheckState = 0 Then
            a = 0
        End If
    End Sub

    Private Sub CheckDoble_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckDoble.CheckedChanged
        If CheckDoble.CheckState = 1 Then
            b = 15
        ElseIf CheckDoble.CheckState = 0 Then
            b = 0
        End If
    End Sub

    Private Sub CheckAlitas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckAlitas.CheckedChanged
        If CheckAlitas.CheckState = 1 Then
            c = 25
        ElseIf CheckAlitas.CheckState = 0 Then
            c = 0
        End If
    End Sub

    Private Sub BtnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        efec = Val(TxtEfectivo.Text)
    End Sub

    Private Sub BtnNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        total = x + y + a + b + c
        Panel1.Visible = True
        efec = Val(TxtEfectivo.Text)
        Dim cambio As Integer
        TxtTotal.Text = total
        efec = Val(TxtEfectivo.Text)
        cambio = efec - total
        TxtCambio.Text = cambio
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        RBtnGrande.Checked = False
        RBtnHawaiana.Checked = False
        RBtnMed.Checked = False
        RBtnMexicana.Checked = False
        RBtnPepperoni.Checked = False
        RBtnPequeña.Checked = False
        CheckExtra.Checked = False
        CheckAlitas.Checked = False
        CheckDoble.Checked = False
        TxtCambio.Text = ""
        TxtEfectivo.Text = ""
        TxtTotal.Text = ""
    End Sub
End Class
