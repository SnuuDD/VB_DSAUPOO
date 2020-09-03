Public Class FrmMenu

    Private Sub ARCHIVOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ARCHIVOToolStripMenuItem.Click

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIRToolStripMenuItem.Click
        End
    End Sub

    Private Sub PARESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        FrmAlta_alumnos.Show()

    End Sub

    Private Sub AlumnosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlumnosToolStripMenuItem.Click
        Me.Hide()
        FrmAlta_alumnos.Show()

    End Sub

    Private Sub AlumnosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlumnosToolStripMenuItem1.Click
        Me.Hide()
        FrmBajas.Show()
    End Sub

    Private Sub AlumnosToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlumnosToolStripMenuItem2.Click
        Me.Hide()
        FrmModificar.Show()
    End Sub

    Private Sub AlumnosToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlumnosToolStripMenuItem3.Click
        Me.Hide()
        FrmConsultasGralAlumnos.Show()
    End Sub
End Class
