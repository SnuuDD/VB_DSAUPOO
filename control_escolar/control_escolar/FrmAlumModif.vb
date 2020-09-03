Public Class FrmAlumModif
    Dim conexion As New ADODB.Connection
    Dim regsalumnos As ADODB.Recordset
    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

    End Sub

    Private Sub FrmAlumModif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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