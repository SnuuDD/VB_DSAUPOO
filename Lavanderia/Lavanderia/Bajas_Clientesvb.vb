Public Class Bajas_Clientesvb
    Dim conexion As New ADODB.Connection
    Dim regsclientes As ADODB.Recordset
    Private Sub Bajas_Clientesvb_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        regsclientes = New ADODB.Recordset
        'ChDir("../../..")
        conexion.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=/Lavanderia/Lavanderia.accdb")
        regsclientes.DataMember = ("clientes")
        regsclientes.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regsclientes.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regsclientes.Open("Select * from cliente", conexion)
        regsclientes.Close()
        Call llenar_clientes()
        Call limpiar_cajas()
    End Sub
    Private Sub llenar_clientes()
        Dim numclientes, totalclientes As Integer
        Dim IDCliente As String
        regsclientes.Open("Select * from cliente")
        totalclientes = regsclientes.RecordCount
        For numclientes = 1 To totalclientes Step 1
            IDCliente = regsclientes("IDCliente").Value
            cbocliente.Items.Add(IDCliente)
            regsclientes.MoveNext()

        Next numclientes
        regsclientes.Close()
    End Sub
    
    Private Sub cbocliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbocliente.SelectedIndexChanged
        Dim IDCliente, nombre As String
        IDCliente = cbocliente.Text
        regsclientes.Open("Select * from Cliente where IDCliente")
        nombre = regsclientes.DataSource("Nombre_Completo").value
        lblcliente.Text = nombre
        regsclientes.Close()
    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Dim respuesta As Integer

        respuesta = MsgBox("¿Deseas eliminar la vista seleccionada?", MsgBoxStyle.YesNo)

        If respuesta = vbYes Then

            regsclientes.Open()
            regsclientes.Delete()
            regsclientes.Update()
            regsclientes.Close()
            MsgBox("El 6registro fue eliminado con éxito", vbInformation)
            Call limpiar_cajas()


        End If
    End Sub
    Private Sub limpiar_cajas()
        cbocliente.Text = ""
        lblcliente.Text = ""
    End Sub
    Private Sub ordentabindex()
        cbocliente.TabIndex = 0
        btncancelar.TabIndex = 1
        btneliminar.TabIndex = 2
        btnregresar.TabIndex = 3

    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Call limpiar_cajas()
    End Sub

    Private Sub btnregresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregresar.Click
        Me.Hide()
        frmmenu.Show()
    End Sub
End Class