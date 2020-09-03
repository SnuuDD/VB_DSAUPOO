Public Class frmemplados

    Private Sub btncapturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncapturar.Click
        Dim nombre As String
        Dim c As Integer

        For c = 1 To 6 Step 1
            nombre = InputBox("Introduce elnombre de los empleado " & c)
            lstnombre.Items.Add(nombre)

        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstsueldo.SelectedIndexChanged

    End Sub

    Private Sub btncapturarsueldo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sueldo, c, aum, total As Integer
        For c = 1 To 6 Step 1

            sueldo = InputBox("Sueldo " & c)
            lstsueldo.Items.Add(sueldo)
            aum = sueldo * 0.3
            total = sueldo + aum
            lstsueldoaumentado.Items.Add(total)
        Next

    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub btnaumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lstnombre.Items.Clear()
        lstsueldo.Items.Clear()
        lstsueldoaumentado.Items.Clear()
    End Sub

    Private Sub btnborrarempleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sueldo, c, aum, total As Double

        For c = 1 To 6 Step 1

            sueldo = InputBox("Sueldo " & c)
            lstsueldo.Items.Add(sueldo)
            aum = sueldo * 0.3
            total = sueldo + aum
            lstsueldoaumentado.Items.Add(total)
        Next

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim pos As Integer
        pos = InputBox("EMPLEADO A ELIMINAR")
        If pos >= 0 And pos <= 5 Then
            lstnombre.Items.RemoveAt(pos)
            lstsueldo.Items.RemoveAt(pos)
            lstsueldoaumentado.Items.RemoveAt(pos)
        Else
            MsgBox("EL EMPLEADO NO EXISTE", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        lstnombre.Items.Clear()
        lstsueldo.Items.Clear()
        lstsueldoaumentado.Items.Clear()
    End Sub

    Private Sub lstsueldoaumentado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstsueldoaumentado.SelectedIndexChanged

    End Sub
End Class
