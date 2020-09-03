Public Class FrmBajasCursar
    Dim conexion As New ADODB.Connection
    Dim regscursos As ADODB.Recordset
    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
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

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click

        Dim respuesta As Integer
        Dim clave As String
        respuesta = MsgBox("DESEAS DAR DE BAJA EL CURSO SELECCIONADO?", MsgBoxStyle.YesNo)

        If respuesta = vbYes Then
            clave = "'" & TxtClave.Text & "'"
            regscursos.Open("Select *from cursos where clave=" & clave)
            regscursos.Delete()
            regscursos.Update()
            regscursos.Close()
            MsgBox("SE HA ELIMINADO ESTE curso")

            TxtClave.Text = ""
            Label3.Text = ""
            TxtClave.Focus()

        End If
    End Sub

    Private Sub FrmBajasCursar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        regscursos = New ADODB.Recordset
        ChDir("../../..")
        conexion.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=control_escolar.accdb")
        regscursos.DataMember = ("cursos")
        regscursos.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regscursos.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regscursos.Open("Select * from cursos", conexion)
        regscursos.Close()
    End Sub

    Private Sub BtnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        FrmMenu.Show()

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        TxtClave.Text = ""
        Label3.Text = ""

    End Sub

    Private Sub TxtClave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtClave.KeyPress
        If Asc(e.KeyChar) = 13 And TxtClave.Text <> "" Then
            TxtClave.Focus()
        Else
            Call numeros(TxtClave, e)
        End If
    End Sub

    Private Sub TxtClave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtClave.TextChanged

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

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class