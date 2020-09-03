Public Class frmemplados

    Private Sub btncapturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstmatricula.SelectedIndexChanged

    End Sub

    Private Sub btncapturarsueldo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnaumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnborrarempleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnborrar.Click
        Dim pos As Integer
        pos = InputBox("Alumno Eliminar")
        If pos >= 0 And pos <= 5 Then
            lstalumno.Items.RemoveAt(pos)
            lstmatricula.Items.RemoveAt(pos)
            lstcalificacion.Items.RemoveAt(pos)
        Else
            MsgBox("Ese numero de alumno no existe", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub frmemplados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lstempleado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstalumno.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        lstalumno.Items.Clear()
        lstmatricula.Items.Clear()
        lstcalificacion.Items.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim total As Double

        total = (lstcalificacion.Items.Item(0) + lstcalificacion.Items.Item(1) + lstcalificacion.Items.Item(2) + lstcalificacion.Items.Item(3) + lstcalificacion.Items.Item(4)) / 5
        MsgBox("El promedio de todas las calificaciones es: " & total)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim nombre As String
        Dim c As Integer

        For c = 1 To 5 Step 1
            nombre = InputBox("Introduce el nombre del alumnos " & c)
            lstalumno.Items.Add(nombre)

        Next
        Dim matri, calificacion As Double

        For c = 1 To 5 Step 1

            matri = InputBox("Matricula " & c)
            lstmatricula.Items.Add(matri)
        Next
        For c = 1 To 5 Step 1

            calificacion = InputBox("Calificacion " & c)
            lstcalificacion.Items.Add(calificacion)
        Next

    End Sub
End Class
