Public Class frmmenu

    Private Sub SALIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIRToolStripMenuItem.Click
        End
    End Sub

    Private Sub AlumnosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlumnosToolStripMenuItem.Click
        Me.Hide()
        ALTASConcepto.Show()
    End Sub

    Private Sub AlumnosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlumnosToolStripMenuItem1.Click
        Me.Hide()
        FrmServicio_Bajas.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Me.Hide()
        Altas_Clientes.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Me.Hide()
        Altas_Empleados.Show()
    End Sub

    Private Sub ServicioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServicioToolStripMenuItem.Click
        Me.Hide()
        FrmServicio_Altas.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadosToolStripMenuItem1.Click
        Me.Hide()
        Bajas_Empleados.Show()
    End Sub

    Private Sub ConceptoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConceptoToolStripMenuItem.Click
        Me.Hide()
        BAJASConcepto.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem1.Click
        Me.Hide()
        Bajas_Clientesvb.Show()
    End Sub

    Private Sub AlumnosToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlumnosToolStripMenuItem2.Click
        Me.Hide()
        Modificar_Clientes.Show()
    End Sub

    Private Sub frmmenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ChDir("../../..")
    End Sub

    Private Sub ClientesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem2.Click
        Me.Hide()
        Consultas_Clientes.Show()

    End Sub

    Private Sub EmpleadosToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadosToolStripMenuItem2.Click
        Me.Hide()
        Consultas_Empleados.Show()
    End Sub

    Private Sub ConceptoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConceptoToolStripMenuItem1.Click
        Me.Hide()
        Consultas_Concepto.Show()

    End Sub

    Private Sub ServicioToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServicioToolStripMenuItem1.Click
        Me.Hide()
        Consultas_Servicio.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadosToolStripMenuItem3.Click
        Me.Hide()
        Consultas_Empleados.Show()
    End Sub

    Private Sub ConceptoToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConceptoToolStripMenuItem2.Click
        Me.Hide()
        Consultas_Concepto.Show()
    End Sub

    Private Sub ServicioToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServicioToolStripMenuItem2.Click
        Me.Hide()
        Consultas_Servicio.Show()

    End Sub
End Class