Public Class FrmAlta_alumnos
    Dim conexion As New ADODB.Connection
    Dim regsalumnos As ADODB.Recordset
    Private Sub ordentabindex()
        txtnumero_control.TabIndex = 0
        txtp_nombre_a.TabIndex = 1
        txtsnombre_a.TabIndex = 2
        txtapp_a.TabIndex = 3
        txtapm_a.TabIndex = 4
        txtcalle.TabIndex = 5
        txtnumero.TabIndex = 6
        txtcolonia.TabIndex = 7
        txttelefono.TabIndex = 8
        txtpnombre_t.TabIndex = 9
        txtsnombre_a.TabIndex = 10
        txtapp_t.TabIndex = 11
        txtapm_t.TabIndex = 12
        BtnAgregar.TabIndex = 13
       
    End Sub
    
    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        Dim clave As String
        clave = "'" & txtnumero_control.Text & "'"
        regsalumnos.Open("Select * from alumnos where numero_control=" & clave)
        If regsalumnos.RecordCount <> 0 Then
            MsgBox("El numero de control a ingresar ya esta en la tabla,capturar otro", vbQuestion)
            txtnumero_control.Text = ""
            txtnumero_control.Focus()
            regsalumnos.Close()
        Else
            regsalumnos.AddNew()
            regsalumnos.DataSource("numero_control") = txtnumero_control.Text
            regsalumnos.DataSource("p_nombre") = txtp_nombre_a.Text
            regsalumnos.DataSource("s_nombre") = txtsnombre_a.Text
            regsalumnos.DataSource("app") = txtapp_a.Text
            regsalumnos.DataSource("apm") = txtapm_a.Text
            regsalumnos.DataSource("telefono") = txttelefono.Text
            regsalumnos.DataSource("calle") = txtcalle.Text
            regsalumnos.DataSource("numero") = txtnumero.Text
            regsalumnos.DataSource("colonia") = txtcolonia.Text
            regsalumnos.DataSource("p_nombre_t") = txtpnombre_t.Text
            regsalumnos.DataSource("s_nombre_t") = txtsnombre_t.Text
            regsalumnos.DataSource("app_t") = txtapp_t.Text
            MsgBox("El registro fue agregado correctamente", vbInformation)
            regsalumnos.DataSource("apm_t") = txtapm_t.Text
            regsalumnos.Update()
            regsalumnos.Close()
            Call limpiar_cajas()
        End If


    End Sub
    Private Sub limpiar_cajas()
        txtnumero_control.Clear()
        txtp_nombre_a.Clear()
        txtsnombre_a.Clear()
        txtapp_a.Clear()
        txtapm_a.Clear()
        txtcalle.Clear()
        txtnumero.Clear()
        txtcolonia.Clear()
        txttelefono.Clear()
        txtpnombre_t.Clear()
        txtsnombre_a.Clear()
        txtapp_t.Clear()
        txtapm_t.Clear()

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

    Private Sub txtnumero_control_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumero_control.KeyPress
        If Asc(e.KeyChar) = 13 And txtnumero_control.Text <> "" Then
            txtnumero_control.Focus()
        Else
            Call numeros(txtnumero_control, e)
        End If
    End Sub

    Private Sub txttelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefono.KeyPress
        If Asc(e.KeyChar) = 13 And txtnumero_control.Text <> "" Then
            txtnumero_control.Focus()
        Else
            Call numeros(txtnumero_control, e)
        End If
    End Sub
    Private Sub letrasyespacios(ByVal cajatexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = " " Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub



    Private Sub txtsnombre_a_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsnombre_a.KeyPress
        If Asc(e.KeyChar) = 13 And txtsnombre_a.Text <> "" Then
            txtsnombre_a.Focus()
        Else
            Call letrasyespacios(txtsnombre_a, e)
        End If
    End Sub
    Private Sub txtp_nombre_a_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsnombre_a.KeyPress
        If Asc(e.KeyChar) = 13 And txtp_nombre_a.Text <> "" Then
            txtsnombre_a.Focus()
        Else
            Call letrasyespacios(txtsnombre_a, e)
        End If
    End Sub

    Private Sub txtapp_a_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtapp_a.KeyPress
        If Asc(e.KeyChar) = 13 And txtapp_a.Text <> "" Then
            txtapp_a.Focus()
        Else
            Call letrasyespacios(txtapp_a, e)
        End If
    End Sub

    Private Sub txtapm_a_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtapm_a.KeyPress
        If Asc(e.KeyChar) = 13 And txtapm_a.Text <> "" Then
            txtapm_a.Focus()
        Else
            Call letrasyespacios(txtapm_a, e)
        End If
    End Sub

    Private Sub txtpnombre_t_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpnombre_t.KeyPress
        If Asc(e.KeyChar) = 13 And txtpnombre_t.Text <> "" Then
            txtpnombre_t.Focus()
        Else
            Call letrasyespacios(txtpnombre_t, e)
        End If
    End Sub

    Private Sub txtsnombre_t_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsnombre_t.KeyPress
        If Asc(e.KeyChar) = 13 And txtsnombre_t.Text <> "" Then
            txtsnombre_t.Focus()
        Else
            Call letrasyespacios(txtsnombre_t, e)
        End If
    End Sub

    Private Sub txtapp_t_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtapp_t.KeyPress
        If Asc(e.KeyChar) = 13 And txtapp_t.Text <> "" Then
            txtapp_t.Focus()
        Else
            Call letrasyespacios(txtapp_t, e)
        End If
    End Sub

    Private Sub txtapm_t_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtapm_t.KeyPress
        If Asc(e.KeyChar) = 13 And txtapm_t.Text <> "" Then
            txtapm_t.Focus()
        Else
            Call letrasyespacios(txtapm_t, e)
        End If
    End Sub

    Private Sub BtnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        FrmMenu.Show()
    End Sub

   
   
    Private Sub FrmAlta_alumnos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        regsalumnos = New ADODB.Recordset
        ChDir("../../..")
        conexion.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=control_escolar.accdb")
        regsalumnos.DataMember = ("alumnos")
        regsalumnos.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
        regsalumnos.LockType = ADODB.LockTypeEnum.adLockOptimistic
        regsalumnos.Open("Select * from alumnos", conexion)
        regsalumnos.Close()
        Call ordentabindex()

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Call limpiar_cajas()

    End Sub

    Private Sub txtnumero_control_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnumero_control.TextChanged

    End Sub
End Class
