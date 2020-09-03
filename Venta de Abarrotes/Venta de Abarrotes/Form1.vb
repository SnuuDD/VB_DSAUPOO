Public Class Form1

    Private Sub Btn_Calcula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Calcula.Click
        Dim opc As String
        opc = CboOperaciones.Text
        Select Case opc
            Case "Arroz"
                p1.Text = "Arroz"
                precio1.Text = "$20"
                txt1.Visible = True
                txt1.Focus()
                DataGridView1.Rows.Add(p1.Text, precio1.Text, txt1.Text, Val(txt1.Text) * 20)
            Case ("Frijoles")
                p2.Text = "Frijoles"
                precio2.Text = "$16.50"
                txt2.Visible = True
                txt2.Focus()
                DataGridView1.Rows.Add(p2.Text, precio2.Text, txt2.Text, Val(txt2.Text) * 20)
            Case "Pasta de Dientes"
                p3.Text = "Pasta de Dientes"
                precio3.Text = "$18.30"
                txt3.Visible = True
                txt3.Focus()
                DataGridView1.Rows.Add(p3.Text, precio3.Text, txt3.Text, Val(txt3.Text) * 20)
        End Select

    End Sub

    Private Sub Btn_Pagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Pagar.Click
        Dim num1, num2, num3, total As Double
        Dim Po1, Po2, Po3, pr1, pr2, pr3, T1, T2, T3 As String
        num1 = Val(txt1.Text) * 20
        num2 = Val(txt2.Text) * 16.5
        num3 = Val(txt3.Text) * 18.3
        Po1 = (p1.Text)
        Po2 = (p2.Text)
        Po3 = (p3.Text)
        pr1 = (precio1.Text)
        pr2 = (precio2.Text)
        pr3 = (precio3.Text)
        T1 = (txt1.Text)
        T2 = (txt2.Text)
        T3 = (txt3.Text)
        total = num1 + num2 + num3
        MsgBox("Tienda de Abarrotes :v" & vbCrLf & "Producto     Precio       Cantidad" & vbCrLf & Po1 & "           " & pr1 & "             " & T1 & vbCrLf & Po2 & "        " & pr2 & "       " & T2 & vbCrLf & Po3 & "      " & pr3 & "        " & T3 & vbCr & "I.V.A. : $" & (total * 84%) & vbCr & "SubTotal. : $" & (total - 16%) & vbCr & "Total. : $" & (total))
    End Sub

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        p1.Text = ""
        p2.Text = ""
        p3.Text = ""
        precio1.Text = ""
        precio2.Text = ""
        precio3.Text = ""
        txt1.Text = ""
        txt2.Text = ""
        txt3.Text = ""
        CboOperaciones.Text = ""
    End Sub

    Private Sub txt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1.TextChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class


