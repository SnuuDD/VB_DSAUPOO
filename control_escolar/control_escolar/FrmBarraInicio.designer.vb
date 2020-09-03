<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBarraInicio
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
        Me.components = New System.ComponentModel.Container()
        Me.ProgressBar_Cargar = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblCargando = New System.Windows.Forms.Label()
        Me.LblEsperar = New System.Windows.Forms.Label()
        Me.Timer_Tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ProgressBar_Cargar
        '
        Me.ProgressBar_Cargar.Location = New System.Drawing.Point(87, 96)
        Me.ProgressBar_Cargar.Name = "ProgressBar_Cargar"
        Me.ProgressBar_Cargar.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar_Cargar.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BIENVENIDOS"
        '
        'LblCargando
        '
        Me.LblCargando.AutoSize = True
        Me.LblCargando.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCargando.Location = New System.Drawing.Point(87, 149)
        Me.LblCargando.Name = "LblCargando"
        Me.LblCargando.Size = New System.Drawing.Size(2, 15)
        Me.LblCargando.TabIndex = 2
        '
        'LblEsperar
        '
        Me.LblEsperar.AutoSize = True
        Me.LblEsperar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblEsperar.Location = New System.Drawing.Point(110, 197)
        Me.LblEsperar.Name = "LblEsperar"
        Me.LblEsperar.Size = New System.Drawing.Size(2, 15)
        Me.LblEsperar.TabIndex = 3
        '
        'Timer_Tiempo
        '
        Me.Timer_Tiempo.Enabled = True
        Me.Timer_Tiempo.Interval = 500
        '
        'FrmBarraInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblEsperar)
        Me.Controls.Add(Me.LblCargando)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar_Cargar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBarraInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar_Cargar As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblCargando As System.Windows.Forms.Label
    Friend WithEvents LblEsperar As System.Windows.Forms.Label
    Friend WithEvents Timer_Tiempo As System.Windows.Forms.Timer
End Class
