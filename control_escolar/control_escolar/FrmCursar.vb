Public Class FrmCursar
    Dim conexion As New ADODB.Connection
    Dim regsalumnos As ADODB.Recordset
    Dim regscursos As ADODB.Recordset
    Dim regscursar As ADODB.Recordset

    Private Sub combo_llenar_alumnos()
        Dim numalumnos, totalalumnos As Integer
        Dim NUMERO_CONTROL As String
        regsalumnos.Open("select * from alumnos")
        totalalumnos = regsalumnos.RecordCount
        For numalumnos = 1 To totalalumnos Step 1
            NUMERO_CONTROL = regsalumnos("numero_control").Value
            ComboBox1.Items.Add(NUMERO_CONTROL)
            regsalumnos.MoveNext()
        Next numalumnos
        regsalumnos.Close()

    End Sub
    Private Sub combo_llenar_cursos()
        Dim numcursos, totalcursos As Integer
        Dim clave As String
        regscursos.Open("select * from cursos")
        totalcursos = regscursos.RecordCount
        For numcursos = 1 To totalcursos Step 1
            clave = regscursos("clave").Value
            ComboBox2.Items.Add(clave)
            regscursos.MoveNext()
        Next numcursos
        regscursos.Close()
    End Sub


    Private Sub FrmCursar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        regsalumnos = New ADODB.Recordset
        regscursos = New ADODB.Recordset
        regscursar = New ADODB.Recordset
        ChDir("../../..")
        conexion.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=control_escolar.accdb")
        regsalumnos.DataMember = ("alumnos")
        regsalumnos.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regsalumnos.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regsalumnos.Open("Select * from alumnos", conexion)
        regsalumnos.Close()

        regscursos.DataMember = ("cursos")
        regscursos.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regscursos.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regscursos.Open("Select * from cursos", conexion)
        regscursos.Close()
        Call combo_llenar_alumnos()
        Call combo_llenar_cursos()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim clave, nombre_completo As String
        clave = "'" & ComboBox1.Text & "'"
        regsalumnos.Open("Select * from alumnos where numero_control")
        nombre_completo = regsalumnos.DataSource("p_nombre").value & ""

        nombre_completo = nombre_completo & regsalumnos.DataSource("app").value & " "
        nombre_completo = nombre_completo & regsalumnos.DataSource("apm").value
        Label3.Text = nombre_completo
        regsalumnos.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim clave As String
        Dim nombre_curso As String
        clave = ComboBox2.Text
        regscursos.Open("select * from  cursos where clave=" & clave)
        nombre_curso = regscursos.DataSource("nombre_curso").value

        Label6.Text = nombre_curso
        regscursos.Close()
    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        regscursar.Open()
        If regscursar.RecordCount <> 0 Then
            regscursar.AddNew()
            regscursar.DataSource("numero_control") = ComboBox1.Text
            regscursar.DataSource("clave") = ComboBox2.Text
            regscursar.DataSource("calificacion") = TextBox1.Text
            regscursar.Update()
            regscursar.Close()
            MsgBox("El registro fue agregado correctamente", vbInformation)
        End If


        Call limpiarcajas()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 And TextBox1.Text <> "" Then
            TextBox1.Focus()
        Else
            Call numeros(TextBox1, e)
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


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub limpiarcajas()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
    End Sub
  
End Class