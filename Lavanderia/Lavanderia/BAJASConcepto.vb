Public Class BAJASConcepto
    Dim regsconcepto As ADODB.Recordset
    Dim conexion As New ADODB.Connection
    Private Sub BAJASConcepto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        regsconcepto = New ADODB.Recordset
        'ChDir("../../..")
        conexion.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=/Lavanderia/Lavanderia.accdb")
        regsconcepto.DataMember = ("Concepto")
        regsconcepto.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regsconcepto.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regsconcepto.Open("Select * from Concepto", conexion)
        regsconcepto.Close()
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dim clave, descripcion, tipo As String
        clave = TxtBuscar.Text
        regsconcepto.Open("Select* from Concepto where IDConcepto=" & clave)
        If regsconcepto.RecordCount <> 0 Then
            descripcion = regsconcepto.DataSource("Descripcion").value
            tipo = regsconcepto.DataSource("Tipo").value
            Label3.Visible = True
            Label4.Visible = True
            Label3.Text = descripcion
            Label4.Text = tipo
        Else
            MsgBox("El CONCEPTO que buscas no existe  en la tabla" & vbCrLf & "Intenta de nuevo", vbCritical)
            TxtBuscar.Text = ""
            TxtBuscar.Focus()
        End If
        regsconcepto.Close()
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click

        Dim respuesta As Integer
        Dim clave As String
        respuesta = MsgBox("¿Deseas dar de baja el concepto seleccionado?", MsgBoxStyle.YesNo)
        If respuesta = vbYes Then
            clave = TxtBuscar.Text
            regsconcepto.Open("Select* from Concepto where IDConcepto=" & clave)
            regsconcepto.Delete()
            regsconcepto.Update()
            regsconcepto.Close()
            TxtBuscar.Text = ""
            Label3.Visible = False
            Label3.Text = ""
            Label3.Visible = False
            Label4.Text = ""
            TxtBuscar.Focus()
            MsgBox("Registro eliminado")

        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        TxtBuscar.Text = ""
        Label3.Visible = False
        Label3.Text = ""
        Label3.Visible = False
        Label4.Text = ""
    End Sub

    Private Sub BtnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        frmmenu.Show()
    End Sub
End Class