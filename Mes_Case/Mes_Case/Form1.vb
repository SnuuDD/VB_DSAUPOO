Public Class Form1

    Private Sub Btn_Acción_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Acción.Click
        Dim mes As String
        mes = Txtnum2.Text
        Select Case mes

            Case "Enero", "enero", "ENERO"
                MsgBox("El mes que escribiste es el PRIMER mes del año", vbInformation, "RESULTADO")
            Case "febrero", "FEBRERO", "Febrero"
                MsgBox("El mes que escribiste es el SEGUNDO mes del año", vbInformation, "RESULTADO")
            Case "marzo", ""
                MsgBox("El mes que escribiste es el TERCERO mes del año", vbInformation, "RESULTADO")
            Case "Enero", "enero"
                MsgBox("El mes que escribiste es el CUARTO mes del año", vbInformation, "RESULTADO")
            Case "Enero", "enero"
                MsgBox("El mes que escribiste es el QUINTO mes del año", vbInformation, "RESULTADO")
            Case "Enero", "enero"
                MsgBox("El mes que escribiste es el SEXTO mes del año", vbInformation, "RESULTADO")
            Case "Enero", "enero"
                MsgBox("El mes que escribiste es el SEPTIMO mes del año", vbInformation, "RESULTADO")
            Case "Enero", "enero"
                MsgBox("El mes que escribiste es el OCTAVO mes del año", vbInformation, "RESULTADO")
            Case "Enero", "enero"
                MsgBox("El mes que escribiste es el NOVENO mes del año", vbInformation, "RESULTADO")
            Case "OCTUBRE", "Octubre", "octubre"
                MsgBox("El mes que escribiste es el DECIMO mes del año", vbInformation, "RESULTADO")
            Case "NOVIEMBRE", "Noviembre", "noviembre"
                MsgBox("El mes que escribiste es el ONCEAVO mes del año", vbInformation, "RESULTADO")
            Case "Diciembre", "diciembre", "DICIEMBRE"
                MsgBox("El mes que escribiste es el DOCEAVO  mes del año", vbInformation, "RESULTADO")
        End Select

    End Sub

    Private Sub Btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Limpiar.Click

    End Sub

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
