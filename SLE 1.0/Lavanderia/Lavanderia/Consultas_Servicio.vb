Public Class Consultas_Servicio

    Dim conexion As New ADODB.Connection
    'se declara una variable de tipo registro (RecordSet) para crear un conjunto de registro
    Dim regsservicio As ADODB.Recordset



    Private Sub frmconsultas_general_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        regsservicio = New ADODB.Recordset
        'ChDir("../../..")
        conexion.Open("provider=microsoft.ACE.OLEDB.12.0;Data source=Lavanderia.accdb")
        regsservicio.DataMember = ("Servicio")
        'linea para definir el tipo de uso que se le da a la tabla'
        regsservicio.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        'linea para definir el candado a utilizar para los registros'
        regsservicio.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regsservicio.Open("select * from Servicio", conexion)
        regsservicio.Close()
        Call generarenglones()
    End Sub
    Private Sub generarenglones()
        Dim totalalumnos As Integer
        Dim numregistros As Integer
        Dim renglones(12) As Object
        regsservicio.Open("select * from Servicio")
        totalalumnos = regsservicio.RecordCount
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
            regsservicio.MoveFirst()
            For numregistros = 1 To totalalumnos
                renglones(0) = regsservicio("IDServicio").Value
                renglones(1) = regsservicio("Tipo").Value
                renglones(2) = regsservicio("Entrega").Value
                renglones(3) = regsservicio("Direccion_entrega").Value
                renglones(4) = regsservicio("Precio_T").Value
                renglones(5) = regsservicio("Pago").Value
                renglones(6) = regsservicio("IDEmpleado").Value
                renglones(7) = regsservicio("IDCliente").Value
                renglones(8) = regsservicio("IDConcepto").Value

                DataGridView1.Rows.Add(renglones)
                regsservicio.MoveNext()
            Next numregistros
        Else
            MsgBox("No hay registro que mostrar")
        End If
        regsservicio.Close()
    End Sub


    Private Sub btnregresar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinkLabel1.Click
        'DataGridViewl.Rows.clear ()
        Me.Hide()
        frmmenu.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
