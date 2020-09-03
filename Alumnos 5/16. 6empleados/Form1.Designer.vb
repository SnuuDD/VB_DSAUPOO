<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmemplados
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
        Me.lstalumno = New System.Windows.Forms.ListBox()
        Me.lstmatricula = New System.Windows.Forms.ListBox()
        Me.lstcalificacion = New System.Windows.Forms.ListBox()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstalumno
        '
        Me.lstalumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lstalumno.FormattingEnabled = True
        Me.lstalumno.ItemHeight = 24
        Me.lstalumno.Location = New System.Drawing.Point(18, 15)
        Me.lstalumno.Margin = New System.Windows.Forms.Padding(4)
        Me.lstalumno.Name = "lstalumno"
        Me.lstalumno.Size = New System.Drawing.Size(160, 124)
        Me.lstalumno.TabIndex = 0
        '
        'lstmatricula
        '
        Me.lstmatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lstmatricula.FormattingEnabled = True
        Me.lstmatricula.ItemHeight = 24
        Me.lstmatricula.Location = New System.Drawing.Point(310, 15)
        Me.lstmatricula.Margin = New System.Windows.Forms.Padding(4)
        Me.lstmatricula.Name = "lstmatricula"
        Me.lstmatricula.Size = New System.Drawing.Size(160, 124)
        Me.lstmatricula.TabIndex = 2
        '
        'lstcalificacion
        '
        Me.lstcalificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lstcalificacion.FormattingEnabled = True
        Me.lstcalificacion.ItemHeight = 24
        Me.lstcalificacion.Location = New System.Drawing.Point(576, 15)
        Me.lstcalificacion.Margin = New System.Windows.Forms.Padding(4)
        Me.lstcalificacion.Name = "lstcalificacion"
        Me.lstcalificacion.Size = New System.Drawing.Size(160, 124)
        Me.lstcalificacion.TabIndex = 5
        '
        'btnborrar
        '
        Me.btnborrar.BackColor = System.Drawing.Color.SkyBlue
        Me.btnborrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnborrar.Location = New System.Drawing.Point(13, 258)
        Me.btnborrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(165, 35)
        Me.btnborrar.TabIndex = 6
        Me.btnborrar.Text = "&Borrar Alumno"
        Me.btnborrar.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button4.Location = New System.Drawing.Point(629, 258)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(107, 32)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "&Salir"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(345, 258)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 32)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "&Limpiar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(345, 218)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 32)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "&Promedio"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(310, 178)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(189, 32)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "&Capturar Alumnos "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmemplados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(759, 303)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.lstcalificacion)
        Me.Controls.Add(Me.lstmatricula)
        Me.Controls.Add(Me.lstalumno)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmemplados"
        Me.Text = "Alumnos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstalumno As System.Windows.Forms.ListBox
    Friend WithEvents lstmatricula As System.Windows.Forms.ListBox
    Friend WithEvents lstcalificacion As System.Windows.Forms.ListBox
    Friend WithEvents btnborrar As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
