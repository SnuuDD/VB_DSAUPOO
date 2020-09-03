Public Class Bajas_Empleados
    Dim conexion As New ADODB.Connection
    Dim regsempleados As ADODB.Recordset
    Private Sub Bajas_Empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        regsempleados = New ADODB.Recordset
        'ChDir("../../..")
        conexion.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=/Lavanderia/Lavanderia.accdb")
        regsempleados.DataMember = ("clientes")
        regsempleados.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regsempleados.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regsempleados.Open("Select * from cliente", conexion)
        regsempleados.Close()
        Call llenar_empleados()
        Call limpiar_cajas()
    End Sub
    Private Sub llenar_empleados()
        Dim numempleados, totalempleados As Integer
        Dim IDEmpleado As String
        regsempleados.Open("Select * from Empleados ")
        totalempleados = regsempleados.RecordCount
        For numempleados = 1 To totalempleados Step 1
            IDEmpleado = regsempleados("IDEmpleado").Value
            cboempleado.Items.Add(IDEmpleado)
            regsempleados.MoveNext()

        Next numempleados
        regsempleados.Close()
    End Sub
    Private Sub cboempleado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboempleado.SelectedIndexChanged
        Dim IDEmpleado, nombre2 As String
        IDEmpleado = cboempleado.Text
        regsempleados.Open("Select * from Empleados where IDEmpleado")
        nombre2 = regsempleados.DataSource("Nombre_completo").value
        lblempleado.Text = nombre2
        regsempleados.Close()
    End Sub
    Private Sub limpiar_cajas()
        cboempleado.Text = ""
        lblempleado.Text = ""
    End Sub
    Private Sub ordentabindex()
        cboempleado.TabIndex = 0
        btncancelar.TabIndex = 1
        btneliminar.TabIndex = 2
        btnregresar.TabIndex = 3

    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Dim respuesta As Integer

        respuesta = MsgBox("¿Deseas eliminar la vista seleccionada?", MsgBoxStyle.YesNo)

        If respuesta = vbYes Then

            regsempleados.Open()
            regsempleados.Delete()
            regsempleados.Update()
            regsempleados.Close()
            MsgBox("Elregistro fue eliminado con éxito", vbInformation)
            Call limpiar_cajas()


        End If
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Call limpiar_cajas()
    End Sub

    Private Sub btnregresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregresar.Click
        Me.Hide()
        frmmenu.Show()
    End Sub
End Class