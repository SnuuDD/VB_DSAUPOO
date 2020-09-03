Public Class FrmBajasCursarCursar
    Dim conexion As New ADODB.Connection
    Dim regsalumnos As ADODB.Recordset
    Dim conexion2 As New ADODB.Connection
    Dim regscursos As ADODB.Recordset
    Dim regscursar As ADODB.Recordset
    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click

        Dim clave, nombre_completo As String
        clave = "'" & TxtBuscar.Text & "'"
        regsalumnos.Open("Select * from alumnos where numero_control=" & clave)
        If regsalumnos.RecordCount <> 0 Then
            nombre_completo = regsalumnos.DataSource("p_nombre").value & " "
            nombre_completo = nombre_completo & regsalumnos.DataSource("app").value & " "
            nombre_completo = nombre_completo & regsalumnos.DataSource("apm").value & " "
            Label3.Text = nombre_completo
        Else
            MsgBox("EL NUMERO DE CONTROL QUE BUSCAS NO EXISTE EN LA TABLA" & vbCrLf & "INTENTA DE NUEVO" & vbCritical)
            TxtBuscar.Text = ""
            TxtBuscar.Focus()
        End If
        regsalumnos.Close()


    End Sub

    Private Sub BtnBuscar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar1.Click

        Dim clave, nombre_curso As String
        clave = "'" & TxtClave.Text & "'"
        regscursos.Open("Select * from cursos where clave=" & clave)
        If regscursos.RecordCount <> 0 Then
            nombre_curso = regscursos.DataSource("nombre_curso").value

            Label3.Text = nombre_curso
        Else
            MsgBox("LA CLAVE QUE BUSCAS NO EXISTE EN LA TABLA " & vbCrLf & "INTENTA DE NUEVO " & vbCritical)
            TxtClave.Text = ""
            TxtClave.Focus()
        End If
        regscursos.Close()
    End Sub

    Private Sub FrmBajasCursarCursar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        regsalumnos = New ADODB.Recordset
        ChDir("../../..")
        conexion.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=control_escolar.accdb")
        regsalumnos.DataMember = ("alumnos")
        regsalumnos.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regsalumnos.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regsalumnos.Open("Select * from alumnos", conexion)
        regsalumnos.Close()

        regscursos = New ADODB.Recordset
        ChDir("../../..")
        conexion.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=control_escolar.accdb")
        regscursos.DataMember = ("cursos")
        regscursos.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regscursos.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regscursos.Open("Select * from cursos", conexion)
        regscursos.Close()
        regscursar = New ADODB.Recordset
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Dim respuesta As Integer
        Dim clave, clave2 As String
        respuesta = MsgBox("DESEAS DAR DE BAJA EL ALUMNO SELECCIONADO?", MsgBoxStyle.YesNo)

        If respuesta = vbYes Then
            clave = "'" & TxtBuscar.Text & "'"
            regscursar.Open("Select *from cursar where numero_control=" & clave)
            clave2 = "'" & TxtClave.Text & "'"
            regscursar.Open("Select *from cursar where clave=" & clave2)
            If clave = TxtBuscar.Text And clave2 = TxtBuscar.Text Then
                regscursar.Delete()
                regscursar.Update()
                regscursar.Close()
                MsgBox("SE HA ELIMINADO ESTE REGISTRO")

                TxtBuscar.Text = ""
                Label3.Text = ""
                TxtBuscar.Focus()
                TxtClave.Text = ""
                Label3.Text = ""
                TxtClave.Focus()
            End If

        End If


     
    End Sub
End Class