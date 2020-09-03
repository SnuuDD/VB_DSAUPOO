Public Class Frmbajascursos
    Dim conexion As New ADODB.Connection
    Dim regscursos As ADODB.Recordset
    Private Sub Frmbajascursos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        regscursos = New ADODB.Recordset
        ChDir("../../..")
        conexion.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=control_escolar.accdb")
        regscursos.DataMember = ("cursos")
        regscursos.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regscursos.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regscursos.Open("Select * from cursos", conexion)
        regscursos.Close()

    End Sub
    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Dim respuesta As Integer
        Dim clave As String
        respuesta = MsgBox("¿Deseas dar de baja al curso seleccionado?", MsgBoxStyle.YesNo)
        If respuesta = vbYes Then
            clave = "'" & TxtBuscar.Text & "'"
            regscursos.Open("Select * from cursos where clave=" & clave)
            regscursos.Delete()
            regscursos.Update()
            regscursos.Close()
            TxtBuscar.Text = ""
            Label3.Text = ""
            TxtBuscar.Focus()
        End If
    End Sub
    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dim clave, nombre_curso As String
        clave = "'" & TxtBuscar.Text & "'"
        regscursos.Open("Select * from cursos where clave=" & clave)
        If regscursos.RecordCount <> 0 Then
            nombre_curso = regscursos.DataSource("nombre_curso").value & " "
              Label3.Text = nombre_curso
        Else
            MsgBox("La clave que buscas no existe  en la tabla" & vbCrLf & "intenta de nuevo", vbCritical)
            TxtBuscar.Text = ""
            TxtBuscar.Focus()
        End If
        regscursos.Close()
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
    Private Sub TxtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBuscar.KeyPress
        If Asc(e.KeyChar) = 13 And TxtBuscar.Text <> "" Then
            TxtBuscar.Focus()
        Else
            Call numeros(TxtBuscar, e)
        End If
    End Sub
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        TxtBuscar.Text = ""
        TxtBuscar.Focus()
    End Sub
    Private Sub BtnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        FrmMenu.Show()
    End Sub
End Class
