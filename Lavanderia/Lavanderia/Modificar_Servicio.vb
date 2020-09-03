Public Class Modificar_Servicio
    Dim conexion As New ADODB.Connection
    Dim regservicio As ADODB.Recordset
    Private Sub Modificar_Servicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        regservicio = New ADODB.Recordset
        'ChDir("../../..")
        conexion.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=/Lavanderia/Lavanderia.accdb")
        regservicio.DataMember = ("Servicio")
        regservicio.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regservicio.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regservicio.Open("Select * from Servicio", conexion)
        regservicio.Close()

        Call ordentabindex()
    End Sub

    Private Sub Btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnbuscar.Click
        Dim Control, IDCliente, IDEmpleado, IDConcepto, tipo, entrega, pago, precio_t As String
        Control = Txtid.Text
        regservicio.Open("Select * from Servicio where IDServicio=" & Control)
        If regservicio.RecordCount <> 0 Then
            GroupBox.Visible = True
            MsgBox("El servicio existe", vbInformation)
            IDCliente = regservicio.DataSource("IDCliente").value & " "
            lblcliente.Text = IDCliente
            IDEmpleado = regservicio.DataSource("IDEmpleado").value & " "
            lblnempleado.Text = IDEmpleado
            IDConcepto = regservicio.DataSource("IDConcepto").value & " "
            lblconcepto.Text = IDConcepto
            tipo = regservicio.DataSource("kilos").value & " "
            txttipo.Text = tipo
            entrega = regservicio.DataSource("entrega").value & " "
            lblentrega.Text = entrega
            pago = regservicio.DataSource("pago").value & " "
            lblpago.Text = pago
            precio_t = regservicio.DataSource("precio_t").value & " "
            txtprecio.Text = precio_t
        Else
            GroupBox.Visible = False
            MsgBox("No existe el servicio, o no lo escribio correctamente", vbCritical)
            Txtid.Text = ""

        End If
        regservicio.Close()
    End Sub
    Private Sub ordentabindex()
        Txtid.TabIndex = 0
        Btnbuscar.TabIndex = 1
        txttipo.TabIndex = 2
        txtprecio.TabIndex = 3
        Btnguardar.TabIndex = 4
        Btnregresar.TabIndex = 5
    End Sub
    Private Sub limpiar_cajas()
        Txtid.Text = ""
        Btnbuscar.Text = ""
        txttipo.Text = ""
        txtprecio.Text = ""
        Btnguardar.Text = ""
        Btnregresar.Text = ""
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
    Private Sub txttipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttipo.KeyPress
        If Asc(e.KeyChar) = 10 And txttipo.Text <> "" Then
            txttipo.Focus()
        Else
            Call numeros(txttipo, e)
        End If
    End Sub
    Private Sub txtprecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprecio.KeyPress
        If Asc(e.KeyChar) = 10 And txtprecio.Text <> "" Then
            txtprecio.Focus()
        Else
            Call numeros(txtprecio, e)
        End If
    End Sub

    Private Sub Btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnguardar.Click
        Dim clave As String
        clave = Txtid.Text
        regservicio.Open("Select * from Servicio where IDServicio=" & clave)
        regservicio.DataSource("kilos") = txttipo.Text

        regservicio.DataSource("Precio_T") = txtprecio.Text

        MsgBox("El registro fue modificado correctamente", vbInformation)
        regservicio.Update()
        regservicio.Close()
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