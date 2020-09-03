Public Class Consultas_Clientes
    Dim conexion As New ADODB.Connection
    'se declara una variable de tipo registro (RecordSet) para crear un conjunto de registro
    Dim regsclientes As ADODB.Recordset
    Private Sub Consultas_Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        regsclientes = New ADODB.Recordset
        'ChDir("../../..")
        conexion.Open("provider=microsoft.ACE.OLEDB.12.0;Data source=Lavanderia.accdb")
        regsclientes.DataMember = ("Cliente")
        'linea para definir el tipo de uso que se le da a la tabla'
        regsclientes.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        'linea para definir el candado a utilizar para los registros'
        regsclientes.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regsclientes.Open("select * from cliente", conexion)
        regsclientes.Close()
        Call generarenglones()
    End Sub
    Private Sub generarenglones()
        Dim totalalumnos As Integer
        Dim numregistros As Integer
        Dim renglones(12) As Object
        regsclientes.Open("select * from cliente")
        totalalumnos = regsclientes.RecordCount
        If (totalalumnos <> 0) Then
            DataGridView1.RowHeadersVisible = False 'Indica si la columna que contiene los encabezados de fila se muestran
            DataGridView1.ColumnHeadersVisible = True 'Indica si la fila de encabezado de columna se muestra
            DataGridView1.AllowUserToAddRows = False 'Indica si la opcion de agregar filas se muestra al usuario
            DataGridView1.AllowUserToDeleteRows = False 'Indica si se permite al usuario eliminar filas
            DataGridView1.AllowUserToOrderColumns = False 'Indica si el usuario puede cambiar el orden de las columnas
            DataGridView1.AllowUserToResizeColumns = False 'Indica si el usuario puede cambiar el tamaño de las columnas
            DataGridView1.AllowUserToResizeRows = False 'Indica si el usuario puede cambiar el tamaño de las filas
            DataGridView1.RowHeadersWidth = 700 'Indica el ancho en pixeles de la columna ue ontiene los encabezados de la fila
            DataGridView1.RowHeadersVisible = False 'Indica si la columna que contiene los encabezados de fila se muestra
            regsclientes.MoveFirst()
            For numregistros = 1 To totalalumnos
                renglones(0) = regsclientes("IDCliente").Value
                renglones(1) = regsclientes("Nombre_Completo").Value
                renglones(2) = regsclientes("Direccion").Value
                renglones(3) = regsclientes("Telefono").Value

                DataGridView1.Rows.Add(renglones)
                regsclientes.MoveNext()
            Next numregistros
        Else
            MsgBox("No hay registro que mostrar")
        End If
        regsclientes.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        frmmenu.Show()
    End Sub
End Class