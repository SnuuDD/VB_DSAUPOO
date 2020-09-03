Public Class Modificar_Concepto
    Dim conexion As New ADODB.Connection
    Dim regconcepto As ADODB.Recordset
    Private Sub Modificar_Concepto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        regconcepto = New ADODB.Recordset
        'ChDir("../../..")
        conexion.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=/Lavanderia/Lavanderia.accdb")
        regconcepto.DataMember = ("Concepto")
        regconcepto.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regconcepto.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regconcepto.Open("Select * from Concepto", conexion)
        regconcepto.Close()

        Call ordentabindex()
    End Sub

    Private Sub Btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnbuscar.Click
        Dim Control, tipo, especial, color, descripcion As String
        Control = Txtid.Text
        regconcepto.Open("Select * from Concepto where IDConcepto=" & Control)
        If regconcepto.RecordCount <> 0 Then
            GroupBox.Visible = True
            MsgBox("El concepto existe", vbInformation)
            tipo = regconcepto.DataSource("tipo").value & " "
            txttipo.Text = tipo
            especial = regconcepto.DataSource("especial").value & " "
            lblespecial.Text = especial
            color = regconcepto.DataSource("color").value & " "
            lblcolor.Text = color
            descripcion = regconcepto.DataSource("descripcion").value & " "
            txtdescripcion.Text = descripcion

        Else
            GroupBox.Visible = False
            MsgBox("No existe el concepto, o no lo escribio correctamente", vbCritical)
            Txtid.Text = ""

        End If
        regconcepto.Close()
    End Sub
    Private Sub ordentabindex()
        Txtid.TabIndex = 0
        Btnbuscar.TabIndex = 1
        txttipo.TabIndex = 2
        lblespecial.TabIndex = 3
        lblcolor.TabIndex = 4
        txtdescripcion.TabIndex = 5
        Btnguardar.TabIndex = 6
        Btnregresar.TabIndex = 7
    End Sub
    Private Sub limpiar_cajas()
        Txtid.Text = ""
        txttipo.Text = ""
        lblespecial.Text = ""
        lblcolor.Text = ""
        txtdescripcion.Text = ""
    End Sub
    Private Sub numeros(ByVal cajatexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = " " Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub Txtid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtid.KeyPress
        If Asc(e.KeyChar) = 10 And Txtid.Text <> "" Then
            Txtid.Focus()
        Else
            Call numeros(Txtid, e)
        End If
    End Sub

    Private Sub Btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnguardar.Click
        Dim clave As String
        clave = Txtid.Text
        regconcepto.Open("Select * from Concepto where IDConcepto=" & clave)
        regconcepto.DataSource("Tipo") = txttipo.Text
      
        regconcepto.DataSource("Descripcion") = txtdescripcion.Text
       
        MsgBox("El registro fue modificado correctamente", vbInformation)
        regconcepto.Update()
        regconcepto.Close()
        Call limpiar_cajas()
        GroupBox.Visible = False
    End Sub

    Private Sub Btnregresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnregresar.Click
        Me.Hide()
        frmmenu.show()
    End Sub

    Private Sub GroupBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox.Enter

    End Sub
End Class