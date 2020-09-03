Public Class frmemplados

    Private Sub btncapturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncapturar.Click
        Dim nombre, sueldo As String
        Dim c As Integer

        For c = 1 To 5 Step 1
            sueldo = InputBox("Matricula " & c)
            lstsueldoaumentado.Items.Add(sueldo)
            nombre = InputBox("Introduce del nombre del alumno " & c)
            lstnombre.Items.Add(nombre)
            sueldo = InputBox("Calificación " & c)
            lstsueldo.Items.Add(sueldo)

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sueldo, c, aum, total As Double

        For c = 1 To 6 Step 1
        Next

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim pos As Integer
        pos = InputBox("ALUMNO A ELIMINAR")
        If pos >= 0 And pos <= 4 Then
            lstnombre.Items.RemoveAt(pos)
            lstsueldo.Items.RemoveAt(pos)
            lstsueldoaumentado.Items.RemoveAt(pos)
        Else
            MsgBox("EL ALUMNO NO EXISTE", MsgBoxStyle.Critical)
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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sueldo, c, aum, total As Double

        For c = 1 To 6 Step 1

        Next

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim total As Double
        total = (lstsueldo.Items.Item(0) + lstsueldo.Items.Item(1) + lstsueldo.Items.Item(2) + lstsueldo.Items.Item(3) + lstsueldo.Items.Item(4)) / 5
        MsgBox("El promedio de los 5 alumnos es:" & total)

    End Sub
End Class
