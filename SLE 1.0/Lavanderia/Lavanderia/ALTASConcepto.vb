Public Class ALTASConcepto
    Dim regsconcepto As ADODB.Recordset
    Dim conexion As New ADODB.Connection
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        regsconcepto = New ADODB.Recordset
        'ChDir("../../..")
        conexion.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Lavanderia.accdb")
        regsconcepto.DataMember = ("Concepto")
        regsconcepto.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regsconcepto.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regsconcepto.Open("Select * from Concepto", conexion)
        regsconcepto.Close()
    End Sub
    Private Sub limpiar_cajas()
        txtidconcepto.Text = ""
        txttipoconcepto.Text = ""
        CheckBoxEspecial.Checked = False
        CheckBoxColor.Checked = False
        txtdescripcion.Text = ""
        txtidconcepto.Focus()
    End Sub
    Private Sub txtnumero_control_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtidconcepto.TextChanged

    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        Dim clave As String
        clave = "" & txtidconcepto.Text & ""
        regsconcepto.Open("Select * from concepto where IDConcepto=" & clave)
        If regsconcepto.RecordCount <> 0 Then
            MsgBox("El concepto a ingresar ya existe, ingrese uno nuevo", vbQuestion)
            txtidconcepto.Text = ""
            txtidconcepto.Focus()
            regsconcepto.Close()
        Else
            regsconcepto.AddNew()
            regsconcepto.DataSource("IDConcepto") = txtidconcepto.Text
            regsconcepto.DataSource("Tipo") = txttipoconcepto.Text
            regsconcepto.DataSource("Especial") = CheckBoxEspecial.Checked
            regsconcepto.DataSource("Color") = CheckBoxColor.Checked
            regsconcepto.DataSource("Descripcion") = txtdescripcion.Text
            MsgBox("El registro fue agregado correctamente", vbInformation)
            regsconcepto.Update()
            regsconcepto.Close()
        End If
        Call limpiar_cajas()

    End Sub


    Private Sub txtdescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescripcion.TextChanged

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Call limpiar_cajas()
    End Sub

    Private Sub BtnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        frmmenu.Show()
    End Sub
End Class
