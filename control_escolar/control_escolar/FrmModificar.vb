Public Class FrmModificar
    Dim conexion As New ADODB.Connection
    Dim regsalumnos As ADODB.Recordset
    Private Sub BtnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        FrmMenu.Show()

    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dim pn, sn, app, apm As String
        pn = "'" & TxtPrimerN.Text & "'"
        sn = "'" & TxtSegundoN.Text & "'"
        app = "'" & TxtAPaterno.Text & "'"
        apm = "'" & TxtAMaterno.Text & "'"
        regsalumnos.Open("Select *from alumnos where p_nombre LIKE" & pn & "and s_nombre LIKE" & sn & "and app LIKE" & app & "and apm LIKE" & apm)
        If regsalumnos.RecordCount <> 0 Then
            MsgBox("EL ALUMNO EXISTE")
            Me.Hide()
            FrmAlumModif.Show()
            Dim calle, colonia As String

            FrmAlumModif.txtp_nombre_a.Text = TxtPrimerN.Text
            FrmAlumModif.txtsnombre_a.Text = TxtSegundoN.Text
            FrmAlumModif.txtapp_a.Text = TxtAPaterno.Text
            FrmAlumModif.txtapm_a.Text = TxtAMaterno.Text

            regsalumnos.Open("Select calle,numero,colonia from alumnos where p_nombre LIKE" & pn & "and s_nombre LIKE" & sn & "and app LIKE" & app & "and apm LIKE" & apm)
        Else
            MsgBox("NO EXISTE EL ALUMNO O NO LO ESCRIBIO CORRECTAMENTE", vbCritical)
        End If
        regsalumnos.Close()
    End Sub

    Private Sub FrmModificar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        regsalumnos = New ADODB.Recordset
        ChDir("../../..")
        conexion.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=control_escolar.accdb")
        regsalumnos.DataMember = ("alumnos")
        regsalumnos.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regsalumnos.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regsalumnos.Open("Select * from alumnos", conexion)
        regsalumnos.Close()

    End Sub

End Class