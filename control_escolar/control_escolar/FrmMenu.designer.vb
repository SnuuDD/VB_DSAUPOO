<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ARCHIVOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MISPROGRAMASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BAJASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MODIFICACIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumnosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumnosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumnosToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ARCHIVOToolStripMenuItem, Me.MISPROGRAMASToolStripMenuItem, Me.BAJASToolStripMenuItem, Me.MODIFICACIONESToolStripMenuItem, Me.CONSULTASToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(508, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ARCHIVOToolStripMenuItem
        '
        Me.ARCHIVOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SALIRToolStripMenuItem})
        Me.ARCHIVOToolStripMenuItem.Name = "ARCHIVOToolStripMenuItem"
        Me.ARCHIVOToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ARCHIVOToolStripMenuItem.Text = "&ARCHIVO"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'MISPROGRAMASToolStripMenuItem
        '
        Me.MISPROGRAMASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlumnosToolStripMenuItem})
        Me.MISPROGRAMASToolStripMenuItem.Name = "MISPROGRAMASToolStripMenuItem"
        Me.MISPROGRAMASToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.MISPROGRAMASToolStripMenuItem.Text = "ALTAS"
        '
        'AlumnosToolStripMenuItem
        '
        Me.AlumnosToolStripMenuItem.Name = "AlumnosToolStripMenuItem"
        Me.AlumnosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AlumnosToolStripMenuItem.Text = "Alumnos"
        '
        'BAJASToolStripMenuItem
        '
        Me.BAJASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlumnosToolStripMenuItem1})
        Me.BAJASToolStripMenuItem.Name = "BAJASToolStripMenuItem"
        Me.BAJASToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.BAJASToolStripMenuItem.Text = "BAJAS"
        '
        'MODIFICACIONESToolStripMenuItem
        '
        Me.MODIFICACIONESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlumnosToolStripMenuItem2})
        Me.MODIFICACIONESToolStripMenuItem.Name = "MODIFICACIONESToolStripMenuItem"
        Me.MODIFICACIONESToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.MODIFICACIONESToolStripMenuItem.Text = "MODIFICACIONES"
        '
        'CONSULTASToolStripMenuItem
        '
        Me.CONSULTASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlumnosToolStripMenuItem3})
        Me.CONSULTASToolStripMenuItem.Name = "CONSULTASToolStripMenuItem"
        Me.CONSULTASToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.CONSULTASToolStripMenuItem.Text = "CONSULTAS"
        '
        'AlumnosToolStripMenuItem1
        '
        Me.AlumnosToolStripMenuItem1.Name = "AlumnosToolStripMenuItem1"
        Me.AlumnosToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.AlumnosToolStripMenuItem1.Text = "Alumnos"
        '
        'AlumnosToolStripMenuItem2
        '
        Me.AlumnosToolStripMenuItem2.Name = "AlumnosToolStripMenuItem2"
        Me.AlumnosToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.AlumnosToolStripMenuItem2.Text = "Alumnos"
        '
        'AlumnosToolStripMenuItem3
        '
        Me.AlumnosToolStripMenuItem3.Name = "AlumnosToolStripMenuItem3"
        Me.AlumnosToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.AlumnosToolStripMenuItem3.Text = "Alumnos"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(508, 262)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FrmMenu"
        Me.Text = "Formulario Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ARCHIVOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MISPROGRAMASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlumnosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BAJASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlumnosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MODIFICACIONESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlumnosToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONSULTASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlumnosToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem

End Class
