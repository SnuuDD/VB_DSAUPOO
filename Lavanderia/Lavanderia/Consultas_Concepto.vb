Public Class Consultas_Concepto
    Dim conexion As New ADODB.Connection
    'se declara una variable de tipo registro (RecordSet) para crear un conjunto de registro
    Dim regsconcepto As ADODB.Recordset



    Private Sub frmconsultas_general_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        regsconcepto = New ADODB.Recordset
        'ChDir("../../..")
        conexion.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=/Lavanderia/Lavanderia.accdb")
        regsconcepto.DataMember = ("Concepto")
        'linea para definir el tipo de uso que se le da a la tabla'
        regsconcepto.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        'linea para definir el candado a utilizar para los registros'
        regsconcepto.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regsconcepto.Open("select * from Concepto", conexion)
        regsconcepto.Update()
        regsconcepto.Close()
        Call generarenglones()
    End Sub
    Private Sub generarenglones()
        Dim totalalumnos As Integer
        Dim numregistros As Integer
        Dim renglones(12) As Object
        regsconcepto.Open("select * from Concepto")
        totalalumnos = regsconcepto.RecordCount
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
            regsconcepto.MoveFirst()
            For numregistros = 1 To totalalumnos
                renglones(0) = regsconcepto("IDConcepto").Value
                renglones(1) = regsconcepto("Tipo").Value
                renglones(2) = regsconcepto("Especial").Value
                renglones(3) = regsconcepto("Color").Value
                renglones(4) = regsconcepto("Descripcion").Value
                DataGridView1.Rows.Add(renglones)
                regsconcepto.Update()
                regsconcepto.MoveNext()
            Next numregistros
        Else
            MsgBox("No hay registro que mostrar")
        End If
        regsconcepto.Close()
    End Sub


    Private Sub btnregresar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinkLabel1.Click
        'DataGridViewl.Rows.clear ()
        Me.Hide()
        frmmenu.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub
End Class