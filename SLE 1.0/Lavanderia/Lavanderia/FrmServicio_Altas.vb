Public Class FrmServicio_Altas
    Dim conexion As New ADODB.Connection
    Dim regsservicio As ADODB.Recordset
    Dim regsconcepto As ADODB.Recordset
    Dim regsempleados As ADODB.Recordset
    Dim regsclientes As ADODB.Recordset


    Private Sub FrmServicio_Altas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        regsservicio = New ADODB.Recordset
        regsconcepto = New ADODB.Recordset
        regsempleados = New ADODB.Recordset
        regsclientes = New ADODB.Recordset
        'ChDir("../../..")
        conexion.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Lavanderia.accdb")
        regsconcepto.DataMember = ("Concepto")
        regsconcepto.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regsconcepto.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regsconcepto.Open("Select * from Concepto", conexion)
        regsconcepto.Close()

        regsempleados.DataMember = ("Empleados")
        regsempleados.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regsempleados.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regsempleados.Open("Select * from Empleados", conexion)
        regsempleados.Close()

        regsclientes.DataMember = ("Cliente")
        regsclientes.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regsclientes.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regsclientes.Open("Select * from Cliente", conexion)
        regsclientes.Close()

        regsservicio.DataMember = ("Servicio")
        regsservicio.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regsservicio.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regsservicio.Open("Select * from Servicio", conexion)
        regsservicio.Close()

        Call llenar_concepto()
        Call llenar_empleado()
        Call llenar_cliente()

    End Sub
    Private Sub llenar_concepto()
        Dim numconcepto, totalconceptos As Integer
        Dim IDConcepto As String
        regsconcepto.Open("Select * from Concepto")
        totalconceptos = regsconcepto.RecordCount
        For numconcepto = 1 To totalconceptos Step 1
            IDConcepto = regsconcepto("IDConcepto").Value
            cboconcepto.Items.Add(IDConcepto)
            regsconcepto.MoveNext()

        Next numconcepto
        regsconcepto.Close()

    End Sub
    Private Sub llenar_empleado()
        Dim numempleado, totalempleado As Integer
        Dim IDEmpleado As String
        regsempleados.Open("Select * from Empleados")
        totalempleado = regsempleados.RecordCount
        For numempleado = 1 To totalempleado Step 1
            IDEmpleado = regsempleados("IDEmpleado").Value
            cboempleado.Items.Add(IDEmpleado)
            regsempleados.MoveNext()

        Next numempleado
        regsempleados.Close()

    End Sub
    Private Sub llenar_cliente()
        Dim numcliente, totalcliente As Integer
        Dim IDCliente As String
        regsclientes.Open("Select * from Cliente")
        totalcliente = regsclientes.RecordCount
        For numcliente = 1 To totalcliente Step 1
            IDCliente = regsclientes("IDCliente").Value
            cbocliente.Items.Add(IDCliente)
            regsclientes.MoveNext()

        Next numcliente
        regsclientes.Close()

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboconcepto.SelectedIndexChanged
        Dim IDConcepto, Tipo As String
        IDConcepto = cboconcepto.Text
        regsconcepto.Open("Select * from Concepto where IDConcepto")
        Tipo = regsconcepto.DataSource("Tipo").value & ""
        lbltipo.Text = Tipo
        lbltipo.Visible = True
        regsconcepto.Close()


    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboempleado.SelectedIndexChanged
        Dim IDEmpleado, Nombre_Completo2 As String
        IDEmpleado = cboempleado.Text
        regsempleados.Open("Select * from Empleados where IDEmpleado")
        Nombre_Completo2 = regsempleados.DataSource("Nombre_Completo").value & ""
        lblnombre2.Text = Nombre_Completo2
        lblnombre2.Visible = True
        regsempleados.Close()

    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        Dim id As String
        id = TextBoxID.Text
        regsservicio.Open("Select * from Servicio where idservicio=" & id)
        If regsservicio.RecordCount <> 0 Then
            MsgBox("El numero de control a ingresar ya esta en la tabla,capturar otro", vbQuestion)
            TextBoxID.Text = ""
            TextBoxID.Focus()
            regsservicio.Close()
        Else
            regsservicio.AddNew()
            regsservicio.DataSource("IDServicio") = TextBox1.Text
            regsservicio.DataSource("Kilos") = TextBox3.Text
            regsservicio.DataSource("Entrega") = CheckBoxentrega.Checked
            regsservicio.DataSource("Pago") = CheckBoxpago.Checked
            regsservicio.DataSource("Precio_T") = TextBox1.Text
            regsservicio.Update()
            regsservicio.Close()
            MsgBox("El registro fue agregado correctamente", vbInformation)
            Call limpiar_cajas()
        End If



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

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress

        If Asc(e.KeyChar) = 13 And TextBox3.Text <> "" Then
            TextBox3.Focus()
        Else
            Call numeros(TextBox3, e)
        End If
    End Sub

   
    Private Sub limpiar_cajas()
        cbocliente.Items.Clear()
        cboempleado.Items.Clear()
        cboconcepto.Items.Clear()
        TextBoxID.Text = ""
        TextBox3.Text = ""
        TextBox1.Text = ""
        CheckBoxentrega.Checked = False
        CheckBoxpago.Checked = False


    End Sub
    Private Sub combo_cliente()

    End Sub


    Private Sub cbocliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbocliente.SelectedIndexChanged
        Dim IDCliente, Nombre_Completo As String
        IDCliente = cbocliente.Text
        regsclientes.Open("Select * from Cliente where IDCliente")
        Nombre_Completo = regsclientes.DataSource("Nombre_Completo").value & ""
        lblnombre1.Text = Nombre_Completo
        lblnombre1.Visible = True
        regsclientes.Close()

    End Sub
  
  
    Private Sub BtnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        frmmenu.Show()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBoxID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxID.KeyPress
        If Asc(e.KeyChar) = 13 And TextBoxID.Text <> "" Then
            TextBoxID.Focus()
        Else
            Call numeros(TextBoxID, e)
        End If
    End Sub

    Private Sub TextBoxID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxID.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 And TextBox1.Text <> "" Then
            TextBox1.Focus()
        Else
            Call numeros(TextBox1, e)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Call limpiar_cajas()
    End Sub
End Class