<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ARCHIVOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MISPROGRAMASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BAJASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConceptoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumnosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MODIFICACIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumnosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CONSULTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConceptoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServicioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConceptoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServicioToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ARCHIVOToolStripMenuItem, Me.MISPROGRAMASToolStripMenuItem, Me.BAJASToolStripMenuItem, Me.MODIFICACIONESToolStripMenuItem, Me.CONSULTASToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(562, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ARCHIVOToolStripMenuItem
        '
        Me.ARCHIVOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SALIRToolStripMenuItem})
        Me.ARCHIVOToolStripMenuItem.Name = "ARCHIVOToolStripMenuItem"
        Me.ARCHIVOToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.ARCHIVOToolStripMenuItem.Text = "&ARCHIVO"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'MISPROGRAMASToolStripMenuItem
        '
        Me.MISPROGRAMASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlumnosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.ServicioToolStripMenuItem})
        Me.MISPROGRAMASToolStripMenuItem.Name = "MISPROGRAMASToolStripMenuItem"
        Me.MISPROGRAMASToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MISPROGRAMASToolStripMenuItem.Text = "ALTAS"
        '
        'AlumnosToolStripMenuItem
        '
        Me.AlumnosToolStripMenuItem.Name = "AlumnosToolStripMenuItem"
        Me.AlumnosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AlumnosToolStripMenuItem.Text = "Concepto"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'ServicioToolStripMenuItem
        '
        Me.ServicioToolStripMenuItem.Name = "ServicioToolStripMenuItem"
        Me.ServicioToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ServicioToolStripMenuItem.Text = "Servicio"
        '
        'BAJASToolStripMenuItem
        '
        Me.BAJASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem1, Me.ConceptoToolStripMenuItem, Me.ClientesToolStripMenuItem1, Me.AlumnosToolStripMenuItem1})
        Me.BAJASToolStripMenuItem.Name = "BAJASToolStripMenuItem"
        Me.BAJASToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.BAJASToolStripMenuItem.Text = "BAJAS"
        '
        'EmpleadosToolStripMenuItem1
        '
        Me.EmpleadosToolStripMenuItem1.Name = "EmpleadosToolStripMenuItem1"
        Me.EmpleadosToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.EmpleadosToolStripMenuItem1.Text = "Empleados"
        '
        'ConceptoToolStripMenuItem
        '
        Me.ConceptoToolStripMenuItem.Name = "ConceptoToolStripMenuItem"
        Me.ConceptoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ConceptoToolStripMenuItem.Text = "Concepto"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ClientesToolStripMenuItem1.Text = "Clientes"
        '
        'AlumnosToolStripMenuItem1
        '
        Me.AlumnosToolStripMenuItem1.Name = "AlumnosToolStripMenuItem1"
        Me.AlumnosToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.AlumnosToolStripMenuItem1.Text = "Servicio"
        '
        'MODIFICACIONESToolStripMenuItem
        '
        Me.MODIFICACIONESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlumnosToolStripMenuItem2, Me.EmpleadosToolStripMenuItem3, Me.ConceptoToolStripMenuItem2, Me.ServicioToolStripMenuItem2})
        Me.MODIFICACIONESToolStripMenuItem.Name = "MODIFICACIONESToolStripMenuItem"
        Me.MODIFICACIONESToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.MODIFICACIONESToolStripMenuItem.Text = "MODIFICACIONES"
        '
        'AlumnosToolStripMenuItem2
        '
        Me.AlumnosToolStripMenuItem2.Name = "AlumnosToolStripMenuItem2"
        Me.AlumnosToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.AlumnosToolStripMenuItem2.Text = "Clientes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(448, 29)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "SISTEMA DE LAVANDERIA EFICAZ 1.0"
        '
        'CONSULTASToolStripMenuItem
        '
        Me.CONSULTASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem2, Me.EmpleadosToolStripMenuItem2, Me.ConceptoToolStripMenuItem1, Me.ServicioToolStripMenuItem1})
        Me.CONSULTASToolStripMenuItem.Name = "CONSULTASToolStripMenuItem"
        Me.CONSULTASToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.CONSULTASToolStripMenuItem.Text = "CONSULTAS"
        '
        'ClientesToolStripMenuItem2
        '
        Me.ClientesToolStripMenuItem2.Name = "ClientesToolStripMenuItem2"
        Me.ClientesToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ClientesToolStripMenuItem2.Text = "Clientes"
        '
        'EmpleadosToolStripMenuItem2
        '
        Me.EmpleadosToolStripMenuItem2.Name = "EmpleadosToolStripMenuItem2"
        Me.EmpleadosToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.EmpleadosToolStripMenuItem2.Text = "Empleados"
        '
        'ConceptoToolStripMenuItem1
        '
        Me.ConceptoToolStripMenuItem1.Name = "ConceptoToolStripMenuItem1"
        Me.ConceptoToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ConceptoToolStripMenuItem1.Text = "Concepto"
        '
        'ServicioToolStripMenuItem1
        '
        Me.ServicioToolStripMenuItem1.Name = "ServicioToolStripMenuItem1"
        Me.ServicioToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ServicioToolStripMenuItem1.Text = "Servicio"
        '
        'EmpleadosToolStripMenuItem3
        '
        Me.EmpleadosToolStripMenuItem3.Name = "EmpleadosToolStripMenuItem3"
        Me.EmpleadosToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.EmpleadosToolStripMenuItem3.Text = "Empleados"
        '
        'ConceptoToolStripMenuItem2
        '
        Me.ConceptoToolStripMenuItem2.Name = "ConceptoToolStripMenuItem2"
        Me.ConceptoToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ConceptoToolStripMenuItem2.Text = "Concepto"
        '
        'ServicioToolStripMenuItem2
        '
        Me.ServicioToolStripMenuItem2.Name = "ServicioToolStripMenuItem2"
        Me.ServicioToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ServicioToolStripMenuItem2.Text = "Servicio"
        '
        'frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(562, 290)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENU"
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
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConceptoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CONSULTASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConceptoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServicioToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConceptoToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServicioToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
End Class
