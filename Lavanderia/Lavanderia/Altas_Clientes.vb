Public Class Altas_Clientes
    Dim conexion As New ADODB.Connection
    Dim regsclientes As ADODB.Recordset
    Private Sub ordentabindex()
        txtid.TabIndex = 0
        txtnombre.TabIndex = 1
        txtdireccion.TabIndex = 2
        txttelefono.TabIndex = 3
       
    End Sub
    Private Sub limpiar_cajas()
        txtid.Text = ""
        txtnombre.Text = ""
        txtdireccion.Text = ""
        txttelefono.Text = ""
        txtid.Focus()
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
    Private Sub txtid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtid.KeyPress
        If Asc(e.KeyChar) = 13 And txtid.Text <> "" Then
            txtid.Focus()
        Else
            Call numeros(txtid, e)
        End If
    End Sub
    Private Sub txttelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefono.KeyPress
        If Asc(e.KeyChar) = 13 And txttelefono.Text <> "" Then
            txttelefono.Focus()
        Else
            Call numeros(txttelefono, e)
        End If
    End Sub
    Private Sub letrasyespacios(ByVal cajatexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = " " Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
  
    Private Sub Altas_Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        regsclientes = New ADODB.Recordset
        'ChDir("../../..")
        conexion.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=/Lavanderia/Lavanderia.accdb")
        regsclientes.DataMember = ("clientes")
        regsclientes.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regsclientes.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regsclientes.Open("Select * from cliente",conexion)
        regsclientes.Close()
        Call ordentabindex()
    End Sub

    Private Sub btnregistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregistrar.Click
        Dim id As String
        id = txtid.Text
        regsclientes.Open("Select * from Cliente where idcliente=" & id)
        If regsclientes.RecordCount <> 0 Then
            MsgBox("El numero de control a ingresar ya esta en la tabla,capturar otro", vbQuestion)
            txtid.Text = ""
            txtid.Focus()
            regsclientes.Close()
        Else
            regsclientes.AddNew()
            regsclientes.DataSource("IDCliente") = txtid.Text
            regsclientes.DataSource("Nombre_Completo") = txtnombre.Text
            regsclientes.DataSource("Direccion") = txtdireccion.Text
            regsclientes.DataSource("Telefono") = txttelefono.Text
            regsclientes.Update()
            regsclientes.Close()
            MsgBox("El registro fue agregado correctamente", vbInformation)
            Call limpiar_cajas()
        End If
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
       Call limpiar_cajas 
    End Sub

    Private Sub btnregresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregresar.Click
        Me.Hide()
        frmmenu.Show()

    End Sub

    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged

    End Sub
End Class
