Public Class Modificar_Clientes
    Dim conexion As New ADODB.Connection
    Dim regsclientes As ADODB.Recordset
    Private Sub Modificar_Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        regsclientes = New ADODB.Recordset
        'ChDir("../../..")
        conexion.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=/Lavanderia/Lavanderia.accdb")
        regsclientes.DataMember = ("clientes")
        regsclientes.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regsclientes.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regsclientes.Open("Select * from cliente", conexion)
        regsclientes.Close()

        Call ordentabindex()

    End Sub
   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnbuscar.Click
        Dim nombre, control, telefono, direccion As String
        nombre = "'" & Txtnombre.Text & "'"
      
        regsclientes.Open("Select * from Cliente where Nombre_Completo LIKE" & nombre)
        If regsclientes.RecordCount <> 0 Then
            GroupBox.Visible = True
            MsgBox("El cliente existe", vbInformation)
            control = regsclientes.DataSource("IDCliente").value & " "
            lblcliente.Text = control
            telefono = regsclientes.DataSource("telefono").value & " "
            txttelefono.Text = telefono
            direccion = regsclientes.DataSource("direccion").value & " "
            txtdireccion.Text = direccion


        Else
            GroupBox.Visible = False
            MsgBox("No existe el cliente, o no lo escribio correctamente", vbCritical)
            Txtnombre.Text = ""
            
        End If
        regsclientes.Close()
    End Sub
    Private Sub ordentabindex()
        Txtnombre.TabIndex = 0
        Btnbuscar.TabIndex = 1
        txtdireccion.TabIndex = 2
        txttelefono.TabIndex = 3
        Btnguardar.TabIndex = 4
        Btnregresar.TabIndex = 5
    End Sub
    Private Sub limpiar_cajas()
        Txtnombre.Text = ""
        lblcliente.Text = ""
        txtdireccion.Text = ""
        txttelefono.Text = ""
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
    Private Sub txttelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefono.KeyPress
        If Asc(e.KeyChar) = 10 And txttelefono.Text <> "" Then
            txttelefono.Focus()
        Else
            Call numeros(txttelefono, e)
        End If
    End Sub

    Private Sub Btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnguardar.Click
        Dim clave As String
        clave = lblcliente.Text
        regsclientes.Open("Select * from Cliente where IDCliente=" & clave)
        regsclientes.DataSource("Nombre_Completo") = Txtnombre.Text
        regsclientes.DataSource("telefono") = txttelefono.Text
        regsclientes.DataSource("direccion") = txtdireccion.Text
   
        MsgBox("El registro fue modificado correctamente", vbInformation)
        regsclientes.Update()
        regsclientes.Close()
        Call limpiar_cajas()
        GroupBox.Visible = False
    End Sub

    Private Sub Btnregresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnregresar.Click
        Me.Hide()
        frmmenu.show()
    End Sub
End Class