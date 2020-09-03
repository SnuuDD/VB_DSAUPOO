﻿Public Class Consultas_Empleados

    Dim conexion As New ADODB.Connection
    'se declara una variable de tipo registro (RecordSet) para crear un conjunto de registro
    Dim regsempleados As ADODB.Recordset



    Private Sub frmconsultas_general_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        regsempleados = New ADODB.Recordset
        'ChDir("../../..")
        conexion.Open("provider=microsoft.ACE.OLEDB.12.0;Data source=Lavanderia.accdb")
        regsempleados.DataMember = ("Empleados")
        'linea para definir el tipo de uso que se le da a la tabla'
        regsempleados.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        'linea para definir el candado a utilizar para los registros'
        regsempleados.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regsempleados.Open("select * from Empleados", conexion)
        regsempleados.Close()
        Call generarenglones()
    End Sub
    Private Sub generarenglones()
        Dim totalalumnos As Integer
        Dim numregistros As Integer
        Dim renglones(12) As Object
        regsempleados.Open("select * from Empleados")
        totalalumnos = regsempleados.RecordCount
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
            regsempleados.MoveFirst()
            For numregistros = 1 To totalalumnos
                renglones(0) = regsempleados("IDEmpleado").Value
                renglones(1) = regsempleados("Nombre_Completo").Value
                renglones(2) = regsempleados("Direccion").Value
                renglones(3) = regsempleados("Telefono").Value
                renglones(4) = regsempleados("Horario").Value
                renglones(5) = regsempleados("Sueldo").Value

                DataGridView1.Rows.Add(renglones)
                regsempleados.MoveNext()
            Next numregistros
        Else
            MsgBox("No hay registro que mostrar")
        End If
        regsempleados.Close()
    End Sub


    Private Sub btnregresar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinkLabel1.Click
        'DataGridViewl.Rows.clear ()
        Me.Hide()
        frmmenu.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class