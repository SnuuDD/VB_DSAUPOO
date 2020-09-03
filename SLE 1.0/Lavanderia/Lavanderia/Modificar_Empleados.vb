Public Class Modificar_Empleados
    Dim conexion As New ADODB.Connection
    Dim regsempleados As ADODB.Recordset
    Private Sub Modificar_Empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        regsempleados = New ADODB.Recordset
        'ChDir("../../..")
        conexion.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Lavanderia.accdb")
        regsempleados.DataMember = ("Empleados")
        regsempleados.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regsempleados.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regsempleados.Open("Select * from Empleados", conexion)
        regsempleados.Close()

        Call ordentabindex()
    End Sub

    Private Sub Btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnbuscar.Click
        Dim nombre, control, telefono, direccion, horario, sueldo As String
        nombre = "'" & Txtnombre.Text & "'"
        regsempleados.Open("Select * from Empleados where Nombre_Completo=" & nombre)
        If regsempleados.RecordCount <> 0 Then
            GroupBox.Visible = True
            MsgBox("El empleado existe", vbInformation)
            control = regsempleados.DataSource("IDEmpleado").value & " "
            lblempleado.Text = control
            telefono = regsempleados.DataSource("telefono").value & " "
            txttelefono.Text = telefono
            direccion = regsempleados.DataSource("direccion").value & " "
            txtdireccion.Text = direccion
            horario = regsempleados.DataSource("horario").value & " "
            txthorario.Text = horario
            sueldo = regsempleados.DataSource("sueldo").value & " "
            txtsueldo.Text = sueldo

        Else
            GroupBox.Visible = False
            MsgBox("No existe el empleado, o no lo escribio correctamente", vbCritical)
            Txtnombre.Text = ""

        End If
        regsempleados.Close()
    End Sub
    Private Sub ordentabindex()
        Txtnombre.TabIndex = 0
        Btnbuscar.TabIndex = 1
        txtdireccion.TabIndex = 2
        txttelefono.TabIndex = 3
        txthorario.TabIndex = 4
        txtsueldo.TabIndex = 5
        Btnguardar.TabIndex = 6
        Btnregresar.TabIndex = 7
    End Sub
    Private Sub limpiar_cajas()
        Txtnombre.Text = ""
        lblempleado.Text = ""
        txtdireccion.Text = ""
        txttelefono.Text = ""
        txthorario.Text = ""
        txtsueldo.Text = ""
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
    Private Sub txthorario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txthorario.KeyPress
        If Asc(e.KeyChar) = 8 And txthorario.Text <> "" Then
            txthorario.Focus()
        Else
            Call numeros(txthorario, e)
        End If
    End Sub
    Private Sub Btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnguardar.Click
        Dim clave As String
        clave = lblempleado.Text
        regsempleados.Open("Select * from Emplados where IDEmpleado=" & clave)
        regsempleados.DataSource("Nombre_Completo") = Txtnombre.Text
        regsempleados.DataSource("telefono") = txttelefono.Text
        regsempleados.DataSource("direccion") = txtdireccion.Text
        regsempleados.DataSource("horario") = txthorario.Text
        regsempleados.DataSource("sueldo") = txtsueldo.Text

        MsgBox("El registro fue modificado correctamente", vbInformation)
        regsempleados.Update()
        regsempleados.Close()
        Call limpiar_cajas()
        GroupBox.Visible = False
    End Sub

    Private Sub Btnregresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnregresar.Click
        Me.Hide()
        frmmenu.show()
    End Sub
End Class
