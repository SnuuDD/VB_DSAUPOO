Public Class Form1



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        TXTB.Text = ""
        TXTC.Text = ""
        TXTF.Text = ""
        TXTN.Text = ""
        TXTQ.Text = ""
        CBXGRADO.Text = ""
        CBXGRUPO.Text = ""
        TXTB.Visible = False
        TXTF.Visible = False
        TXTQ.Visible = False
        TXTC.Visible = False
        CheckBoxbiologia.Checked = False
        CheckBoxfisica.Checked = False
        CheckBoxquimica.Checked = False
        CheckBoxcomputacion.Checked = False

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxbiologia.CheckedChanged
        If CheckBoxbiologia.Checked = True Then
            TXTB.Visible = True
            TXTB.Focus()
        End If
        If CheckBoxbiologia.Checked = False Then
            TXTB.Visible = False
            TXTB.Text = ""
        End If
    End Sub

    Private Sub CheckBoxfisica_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxfisica.CheckedChanged
        If CheckBoxfisica.Checked = True Then
            TXTF.Visible = True
            TXTF.Focus()
        End If
        If CheckBoxfisica.Checked = False Then
            TXTF.Visible = False
            TXTF.Text = ""
        End If
    End Sub


    Private Sub CheckBoxquimica_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxquimica.CheckedChanged
        If CheckBoxquimica.Checked = True Then
            TXTQ.Visible = True
            TXTQ.Focus()
        End If
        If CheckBoxquimica.Checked = False Then
            TXTQ.Visible = False
            TXTQ.Text = ""
        End If
    End Sub

    Private Sub CheckBoxcomputacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxcomputacion.CheckedChanged
        If CheckBoxcomputacion.Checked = True Then
            TXTC.Visible = True
            TXTC.Focus()
        End If
        If CheckBoxcomputacion.Checked = False Then
            TXTC.Visible = False
            TXTC.Text = ""
        End If
    End Sub

    Private Sub BTNBOLETA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNBOLETA.Click
        Dim F, B, Q, C, X As Double
        Dim N, M, O As String

        N = TXTN.Text
        M = CBXGRADO.Text
        O = CBXGRUPO.Text

        F = Val(TXTF.Text)
        B = Val(TXTB.Text)
        Q = Val(TXTQ.Text)
        C = Val(TXTC.Text)

        X = (F + B + C + Q) / 4

        If N = "" Then
            MsgBox("TE FALTA ESCRIBIR TU NOMBRE")
        ElseIf M = "" Then
            MsgBox("TE FALTA SELECCIONAR EL GRADO")
        ElseIf O = "" Then
            MsgBox("TE FALTA SELECCIONAR EL GRUPO")
        ElseIf F = 0 Then
            MsgBox("TE FALTA LA CALIFICACIÓN DE FISICA")
        ElseIf B = 0 Then
            MsgBox("TE FALTA LA CALIFICACIÓN DE BIOLOGÍA")
        ElseIf Q = 0 Then
            MsgBox("TE FALTA LA CALIFICACIÓN DE QUÍMICA")
        ElseIf C = 0 Then
            MsgBox("TE FALTA LA CALIFICACIÓN DE COMPUTACIÓN")
        Else
            MsgBox("BOLETA DE CALIFICACIONES" & vbCrLf & "Nombre del alumno: " & N & vbCrLf & "Grado " & M & vbCrLf & "Grupo " & O & vbCrLf & "CALIFICACIONES" & vbCrLf & "FÍSICA:  " & F & vbCrLf & "BIOLOGÍA: " & B & vbCrLf &
                "QUÍMICA: " & Q & vbCrLf & "COMPUTACIÓN: " & C & vbCrLf & "PROMEDIO FINAL: " & X)
        End If


    End Sub

    Private Sub TXTN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
