Public Class TiendaP
    Dim SUBTOTAL2 As String
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo1.SelectedIndexChanged
        Dim cbo As String

        cbo = cbo1.Text

        If cbo = "Doritos" Then
            lblprecio.Text = "$10"

        End If
        If cbo = "Sprite" Then
            lblprecio.Text = "$8"
        End If
        If cbo = "Papas" Then
            lblprecio.Text = "$9"
        End If


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        Dim nombre, precio, cantidad, subtotal, dori As String
        nombre = cbo1.Text
        precio = lblprecio.Text
        cantidad = txtcant.Text
        subtotal = lblprecio.Text * Val(txtcant.Text)
        DataGridView1.Rows.Add(nombre, precio, cantidad, subtotal)
        SUBTOTAL2 = (cantidad * precio) + SUBTOTAL2
        If cbo1.Text = "Doritos" Then
            dori = "Doritos"
            Label5.Text = dori
            Label6.Text = cantidad
            Label7.Text = "$10"
        ElseIf cbo1.Text = "Sprite" Then
            dori = "Sprite"
            Label10.Text = dori
            Label9.Text = cantidad
            Label8.Text = "$8"
        ElseIf cbo1.Text = "Papas" Then
            dori = "Papas"
            Label13.Text = dori
            Label12.Text = cantidad
            Label11.Text = "$9"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cbo1.Text = ""
        lblprecio.Text = ""
        txtcant.Text = ""
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim can1, can2, can3 As Integer
        Dim iva, subtotal, TOTAL As Double

        can1 = Val(txtcant.Text) * lblprecio.Text
        can2 = Val(txtcant.Text) * lblprecio.Text
        can3 = Val(txtcant.Text) * lblprecio.Text



        TOTAL = subtotal2
        iva = total * 0.16
        subtotal = total - iva

        Me.Hide()
        ticket.Show()
        ticket.LblTotal.Text = TOTAL
        ticket.LblSub.Text = subtotal
    End Sub
End Class
