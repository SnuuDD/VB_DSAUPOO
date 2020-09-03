Public Class FrmCursos
    Dim conexion As New ADODB.Connection
    Dim regscursos As ADODB.Recordset
    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        Dim clave As String
        clave = "'" & TxtClave.Text & "'"
        regscursos.Open("Select * from cursos where clave=" & clave)
        If regscursos.RecordCount <> 0 Then
            MsgBox("El numero de control a ingresar ya esta en la tabla,capturar otro", vbQuestion)
            TxtClave.Text = ""
            TxtClave.Focus()
            regscursos.Close()
            Call limpiar_cajas()
        Else
            regscursos.AddNew()
            regscursos.DataSource("clave") = TxtClave.Text
            regscursos.DataSource("nombre_curso") = TxtNombreCurso.Text
            regscursos.Update()
            regscursos.Close()
            MsgBox("El registro fue agregado correctamente", vbInformation)

        End If
        Call limpiar_cajas()
    End Sub

    Private Sub FrmCursos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        regscursos = New ADODB.Recordset
        ChDir("../../..")
        conexion.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=control_escolar.accdb")
        regscursos.DataMember = ("cursos")
        regscursos.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regscursos.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regscursos.Open("Select * from cursos", conexion)
        regscursos.Close()
        Call ordentabindex()

    End Sub
    Private Sub limpiar_cajas()
        TxtClave.Text = ""
        TxtNombreCurso.Text = ""

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Call limpiar_cajas()

    End Sub
    Private Sub ordentabindex()
        TxtClave.TabIndex = 0
        TxtNombreCurso.TabIndex = 1
    End Sub

    
End Class