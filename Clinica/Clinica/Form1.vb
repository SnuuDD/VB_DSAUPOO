Public Class Form1
    Dim resp As Integer
    Dim conexion As New ADODB.Connection
    Dim regsalumnos As ADODB.Recordset
    Dim regscursos As ADODB.Recordset
    Dim regscursar As ADODB.Recordset

    Function checar_cajas(ByVal resp) As Integer
        If Cboalumno.Text = "" Then
            MsgBox("No ha capturado la clave del medico porfavor verifique el formulario", vbCritical)
            Cboalumno.Text = ""
            Cboalumno.Focus()
            resp = 1
            Return resp
        ElseIf Cbocurso.Text = "" Then
            MsgBox("No ha capturado la clave del paciente porfavor verifique el formulario", vbCritical)
            Cbocurso.Text = ""
            Cbocurso.Focus()
            resp = 1
        End If
    End Function
    Private Sub combo_cursos()
        Dim numcurso, totalcurso As Integer
        Dim clave As String
        regscursos.Open("select * from pacientes")
        totalcurso = regscursos.RecordCount
        For numcurso = 1 To totalcurso Step 1
            clave = regscursos("Codigo_del_Paciente").Value
            Cbocurso.Items.Add(clave)
            regscursos.MoveNext()
        Next numcurso
        regscursos.Close()
    End Sub

    Private Sub combo_llenar_alumnos()
        Dim numalumnos, totalalumnos As Integer
        Dim numero_control As String
        regsalumnos.Open("select * from medicos ")
        totalalumnos = regsalumnos.RecordCount
        For numalumnos = 1 To totalalumnos Step 1
            numero_control = regsalumnos("Codigo_de_doctor").Value
            Cboalumno.Items.Add(numero_control)
            regsalumnos.MoveNext()
        Next numalumnos
        regsalumnos.Close()
    End Sub
    Private Sub orden()
        Cboalumno.TabIndex = 0
        Cbocurso.TabIndex = 1
        Btncapturar.TabIndex = 3
        BtnRegresar.TabIndex = 4
    End Sub
    Private Sub limpiar()
        Cboalumno.Focus()
    End Sub
    Private Sub BtnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresar.Click
        Dim r As String
        R = MsgBox("¿Desea Salir?", vbYesNo)
        If R = vbYes Then
            End
        End If

    End Sub

    Private Sub Cboalumno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cboalumno.SelectedIndexChanged
        Dim clave, nombre_completo As String
        clave = "'" & Cboalumno.Text & "'"
        regsalumnos.Open("select * from medicos where Codigo_de_doctor=" & clave)
        nombre_completo = regsalumnos.DataSource("nombre").value & " "
        nombre_completo = nombre_completo & regsalumnos.DataSource("apellidos").value & " "
        Lblnombre.Text = nombre_completo
        regsalumnos.Close()

    End Sub

    Private Sub Frmcursar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChDir("../../..")
        regsalumnos = New ADODB.Recordset
        regscursos = New ADODB.Recordset
        regscursar = New ADODB.Recordset
        conexion.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Clinica.accdb")

        regsalumnos.DataMember = ("medicos")
        regsalumnos.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regsalumnos.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regsalumnos.Open("Select * from medicos", conexion)
        regsalumnos.Close()

        regscursos.DataMember = ("pacientes")
        regscursos.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regscursos.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regscursos.Open("Select * from pacientes", conexion)
        regscursos.Close()

        regscursar.DataMember = ("visitas")
        regscursar.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regscursar.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regscursar.Open("Select * from visitas", conexion)
        regscursar.Close()

        Call orden()
        limpiar()
        Call combo_llenar_alumnos()
        Call combo_cursos()
    End Sub

    Private Sub Btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar()
    End Sub

    Private Sub Cbocurso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbocurso.SelectedIndexChanged
        Dim clave, curso As String
        clave = "'" & Cboalumno.Text & "'"
        regscursos.Open("select * from pacientes where Codigo_del_Paciente=" & clave)
        curso = regscursos.DataSource("nombre").value & " "
        curso = curso & regscursos.DataSource("apellidos").value & " "
    End Sub

    Private Sub Txtcali_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
        If IsNumeric(e.KeyChar) Then
            e.Handled = False
        End If
        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = " " Then
            e.Handled = True
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Txtcali_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Btncapturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncapturar.Click
        regscursar.Open()
        regscursar.Delete()
        regscursar.Update()
        regscursar.Close()
        MsgBox("El registro fue exitoso", vbExclamation)
    End Sub

    Private Sub Cboalumno_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cboalumno.SelectedIndexChanged

    End Sub

    Private Sub Lblnombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lblnombre.Click

    End Sub

    Private Sub Label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class