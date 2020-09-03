Public Class FrmServicio_Bajas

    Dim conexion As New ADODB.Connection
    Dim regsservicio As ADODB.Recordset
    Dim regsconcepto As ADODB.Recordset
    Dim regsempleados As ADODB.Recordset
    Dim regsclientes As ADODB.Recordset

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        regsservicio = New ADODB.Recordset
        regsconcepto = New ADODB.Recordset
        regsempleados = New ADODB.Recordset
        regsclientes = New ADODB.Recordset
        'ChDir("../../..")
        conexion.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=/Lavanderia/Lavanderia.accdb")
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

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click

        Dim IDConcepto, IDEmpleado, IDCliente As Integer
        Dim Tipo, Entrega, Direccion_entrega, Precio_T, Pago As String
        IDCliente = Val(cbocliente.Text)
        IDConcepto = Val(cboconcepto.Text)
        IDEmpleado = Val(cboempleado.Text)
        If cboconcepto.Text = "" Or cbocliente.Text = "" Or cboempleado.Text = "" Then
            MsgBox("Falta ingresar datos")
        End If
        regsservicio.Open("select * from  Servicio where IDConcepto=" & IDConcepto & "and IDEmpleado=" & IDEmpleado & "and IDCLiente=" & IDCliente)


        If regsservicio.RecordCount <> 0 Then

            Tipo = regsservicio.DataSource("Kilos").value
            Entrega = regsservicio.DataSource("Entrega").value
            Direccion_entrega = regsservicio.DataSource("Direccion_entrega").value
            Precio_T = regsservicio.DataSource("Precio_T").value
            Pago = regsservicio.DataSource("Pago").value

            f.Text = Tipo
            g.Text = Entrega
            j.Text = Direccion_entrega
            h.Text = Precio_T
            i.Text = Pago

        Else
            MsgBox("El registro no existe", vbCritical)
            cboconcepto.Text = ""
            cbocliente.Text = ""
            cboconcepto.Focus()
            cboempleado.Text = ""
        End If

        regsservicio.Close()
        a.Visible = True
        b.Visible = True
        c.Visible = True
        d.Visible = True
        z.Visible = True
        f.Visible = True
        g.Visible = True
        h.Visible = True
        i.Visible = True
        j.Visible = True

    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Dim respuesta As Integer

        respuesta = MsgBox("¿Deseas eliminar el serivicio seleccionada?", MsgBoxStyle.YesNo)

        If respuesta = vbYes Then

            regsservicio.Open()
            regsservicio.Delete()
            regsservicio.Update()
            regsservicio.Close()

            Call limpiar()

        End If
    End Sub
    Private Sub limpiar()
        cboempleado.Text = ""
        cboconcepto.Text = ""
        cbocliente.Text = ""
        i.Text = ""
        j.Text = ""
        g.Text = ""
        f.Text = ""
        h.Text = ""


    End Sub

    Private Sub btncanselar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncanselar.Click
        Call limpiar()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        frmmenu.Show()
    End Sub
End Class

