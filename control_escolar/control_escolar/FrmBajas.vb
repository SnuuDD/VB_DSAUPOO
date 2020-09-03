Public Class FrmBajas
    Dim conexion As New ADODB.Connection
    Dim regsalumnos As ADODB.Recordset
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

    Private Sub FrmBajas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        regsalumnos = New ADODB.Recordset
        ChDir("../../..")
        conexion.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=control_escolar.accdb")
        regsalumnos.DataMember = ("alumnos")
        regsalumnos.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regsalumnos.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regsalumnos.Open("Select * from alumnos", conexion)
        regsalumnos.Close()

    End Sub

    Private Sub BtnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        FrmMenu.Show()

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        TxtBuscar.Text = ""
        Label3.Text = ""

    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Dim respuesta As Integer
        Dim clave As String
        respuesta = MsgBox("DESEAS DAR DE BAJA EL ALUMNO SELECCIONADO?", MsgBoxStyle.YesNo)

        If respuesta = vbYes Then
            clave = "'" & TxtBuscar.Text & "'"
            regsalumnos.Open("Select *from alumnos where numero_control=" & clave)
            regsalumnos.Delete()
            regsalumnos.Update()
            regsalumnos.Close()
            MsgBox("SE HA ELIMINADO ESTE REGISTRO")

            TxtBuscar.Text = ""
            Label3.Text = ""
            TxtBuscar.Focus()

        End If
    End Sub

    Private Sub TxtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBuscar.KeyPress
        If Asc(e.KeyChar) = 13 And TxtBuscar.Text <> "" Then
            TxtBuscar.Focus()
        Else
            Call numeros(TxtBuscar, e)
        End If
    End Sub

    Private Sub TxtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscar.TextChanged

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

    
End Class