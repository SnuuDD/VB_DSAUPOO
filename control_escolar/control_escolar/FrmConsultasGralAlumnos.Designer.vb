<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultasGralAlumnos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cControl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrimerN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSegundoN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cApellidoP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cApellidoM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cColonia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPNombreT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSNombreT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cApellidoPtutor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cApellidoMatTutor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(394, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ALUMNOS INSCRITOS"
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(483, 416)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(96, 47)
        Me.BtnRegresar.TabIndex = 2
        Me.BtnRegresar.Text = "&REGRESAR"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cControl, Me.cPrimerN, Me.cSegundoN, Me.cApellidoP, Me.cApellidoM, Me.cTelefono, Me.cCalle, Me.cNumero, Me.cColonia, Me.cPNombreT, Me.cSNombreT, Me.cApellidoPtutor, Me.cApellidoMatTutor})
        Me.DataGridView1.Location = New System.Drawing.Point(22, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(943, 276)
        Me.DataGridView1.TabIndex = 3
        '
        'cControl
        '
        Me.cControl.HeaderText = "Numero de Control"
        Me.cControl.Name = "cControl"
        '
        'cPrimerN
        '
        Me.cPrimerN.HeaderText = "Primer Nombre del Alumno"
        Me.cPrimerN.Name = "cPrimerN"
        '
        'cSegundoN
        '
        Me.cSegundoN.HeaderText = "Segundo Nombre del Alumno"
        Me.cSegundoN.Name = "cSegundoN"
        '
        'cApellidoP
        '
        Me.cApellidoP.HeaderText = "Apellido Paterno"
        Me.cApellidoP.Name = "cApellidoP"
        '
        'cApellidoM
        '
        Me.cApellidoM.HeaderText = "Apellido Materno"
        Me.cApellidoM.Name = "cApellidoM"
        '
        'cTelefono
        '
        Me.cTelefono.HeaderText = "Telefono"
        Me.cTelefono.Name = "cTelefono"
        '
        'cCalle
        '
        Me.cCalle.HeaderText = "Calle"
        Me.cCalle.Name = "cCalle"
        '
        'cNumero
        '
        Me.cNumero.HeaderText = "Numero"
        Me.cNumero.Name = "cNumero"
        '
        'cColonia
        '
        Me.cColonia.HeaderText = "Colonia"
        Me.cColonia.Name = "cColonia"
        '
        'cPNombreT
        '
        Me.cPNombreT.HeaderText = "Primer Nombre del Tutor"
        Me.cPNombreT.Name = "cPNombreT"
        '
        'cSNombreT
        '
        Me.cSNombreT.HeaderText = "Segundo Nombre del Tutor"
        Me.cSNombreT.Name = "cSNombreT"
        '
        'cApellidoPtutor
        '
        Me.cApellidoPtutor.HeaderText = "Apellido Paterno del Tutor"
        Me.cApellidoPtutor.Name = "cApellidoPtutor"
        '
        'cApellidoMatTutor
        '
        Me.cApellidoMatTutor.HeaderText = "Apellido Materno del Tutor"
        Me.cApellidoMatTutor.Name = "cApellidoMatTutor"
        '
        'FrmConsultasGralAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(987, 492)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmConsultasGralAlumnos"
        Me.Text = "FrmConsultasGralAlumnos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnRegresar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cControl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPrimerN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSegundoN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cApellidoP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cApellidoM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTelefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cColonia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPNombreT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSNombreT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cApellidoPtutor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cApellidoMatTutor As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
