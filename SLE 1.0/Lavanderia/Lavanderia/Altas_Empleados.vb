Public Class Altas_Empleados
    Dim conexion As New ADODB.Connection
    Dim regsempleados As ADODB.Recordset
    Private Sub Altas_Empleados_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        regsempleados = New ADODB.Recordset
        'ChDir("../../..")
        conexion.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Lavanderia.accdb")
        regsempleados.DataMember = ("empleados")
        regsempleados.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regsempleados.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regsempleados.Open("Select * from empleados", conexion)
        regsempleados.Close()
        Call ordentabindex()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Call limpiar_cajas()

    End Sub
    Private Sub limpiar_cajas()
        txtdireccion.Text = ""
        txtempleado.Text = ""
        txthorario.Text = ""
        txtnombre.Text = ""
        txtsueldo.Text = ""
        txttelefono.Text = ""
        txtempleado.Focus()
    End Sub
    Private Sub ordentabindex()
        txtdireccion.TabIndex = 0
        txtempleado.TabIndex = 1
        txthorario.TabIndex = 2
        txtnombre.TabIndex = 3
        txtsueldo.TabIndex = 4
        txttelefono.TabIndex = 5
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
    Private Sub txtempleado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtempleado.KeyPress
        If Asc(e.KeyChar) = 13 And txtempleado.Text <> "" Then
            txtempleado.Focus()
        Else
            Call numeros(txtempleado, e)
        End If
    End Sub
    Private Sub txthorario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txthorario.KeyPress
        If Asc(e.KeyChar) = 13 And txthorario.Text <> "" Then
            txthorario.Focus()
        Else
            Call numeros(txthorario, e)
        End If
    End Sub

    Private Sub txttelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefono.KeyPress
        If Asc(e.KeyChar) = 13 And txttelefono.Text <> "" Then
            txttelefono.Focus()
        Else
            Call numeros(txttelefono, e)
        End If
    End Sub
    Private Sub txtsueldo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsueldo.KeyPress
        If Asc(e.KeyChar) = 13 And txtsueldo.Text <> "" Then
            txtsueldo.Focus()
        Else
            Call numeros(txtsueldo, e)
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
    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        If Asc(e.KeyChar) = 13 And txtnombre.Text <> "" Then
            txtnombre.Focus()
        Else
            Call letrasyespacios(txtnombre, e)
        End If
    End Sub
    Private Sub txtdireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdireccion.KeyPress
        If Asc(e.KeyChar) = 13 And txtdireccion.Text <> "" Then
            txtdireccion.Focus()
        Else
            Call letrasyespacios(txtdireccion, e)
        End If
    End Sub

    Private Sub btnregistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregistrar.Click
        Dim empleado As String
        empleado = txtempleado.Text
        regsempleados.Open("Select * from Empleados where idempleado=" & empleado)
        If regsempleados.RecordCount <> 0 Then
            MsgBox("El numero de control a ingresar ya esta en la tabla,capturar otro", vbQuestion)
            txtempleado.Text = ""
            txtempleado.Focus()
            regsempleados.Close()
        Else
            regsempleados.AddNew()
            regsempleados.DataSource("IDEmpleado") = txtempleado.Text
            regsempleados.DataSource("Nombre_Completo") = txtnombre.Text
            regsempleados.DataSource("Direccion") = txtdireccion.Text
            regsempleados.DataSource("Telefono") = txttelefono.Text
            regsempleados.DataSource("Horario") = txthorario.Text
            regsempleados.DataSource("Sueldo") = txtsueldo.Text
            regsempleados.Update()
            regsempleados.Close()
            MsgBox("El registro fue agregado correctamente", vbInformation)
            Call limpiar_cajas()
        End If
    End Sub

    Private Sub btnregresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregresar.Click
        Me.Hide()
        frmmenu.Show()
    End Sub
End Class