<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.Btncapturar = New System.Windows.Forms.Button()
        Me.Cbocurso = New System.Windows.Forms.ComboBox()
        Me.Lbl3 = New System.Windows.Forms.Label()
        Me.Lblnombre = New System.Windows.Forms.Label()
        Me.Cboalumno = New System.Windows.Forms.ComboBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(384, 376)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegresar.TabIndex = 24
        Me.BtnRegresar.Text = "&Salir"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'Btncapturar
        '
        Me.Btncapturar.Location = New System.Drawing.Point(25, 376)
        Me.Btncapturar.Name = "Btncapturar"
        Me.Btncapturar.Size = New System.Drawing.Size(75, 23)
        Me.Btncapturar.TabIndex = 23
        Me.Btncapturar.Text = "&Eliminar"
        Me.Btncapturar.UseVisualStyleBackColor = True
        '
        'Cbocurso
        '
        Me.Cbocurso.FormattingEnabled = True
        Me.Cbocurso.Location = New System.Drawing.Point(247, 66)
        Me.Cbocurso.Name = "Cbocurso"
        Me.Cbocurso.Size = New System.Drawing.Size(121, 21)
        Me.Cbocurso.TabIndex = 19
        '
        'Lbl3
        '
        Me.Lbl3.AutoSize = True
        Me.Lbl3.Location = New System.Drawing.Point(22, 69)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(150, 13)
        Me.Lbl3.TabIndex = 17
        Me.Lbl3.Text = "Selecciona la Clave del curso:"
        '
        'Lblnombre
        '
        Me.Lblnombre.AutoSize = True
        Me.Lblnombre.Location = New System.Drawing.Point(244, 45)
        Me.Lblnombre.Name = "Lblnombre"
        Me.Lblnombre.Size = New System.Drawing.Size(13, 13)
        Me.Lblnombre.TabIndex = 16
        Me.Lblnombre.Text = ".."
        '
        'Cboalumno
        '
        Me.Cboalumno.FormattingEnabled = True
        Me.Cboalumno.Location = New System.Drawing.Point(247, 16)
        Me.Cboalumno.Name = "Cboalumno"
        Me.Cboalumno.Size = New System.Drawing.Size(121, 21)
        Me.Cboalumno.TabIndex = 14
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(22, 19)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(165, 13)
        Me.Label.TabIndex = 13
        Me.Label.Text = "Selecciona el Codigo del Medico:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Motivo de la visita"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Pruebas_realizadas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Diagnostico"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Tratamiento"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(199, 376)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 411)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.Btncapturar)
        Me.Controls.Add(Me.Cbocurso)
        Me.Controls.Add(Me.Lbl3)
        Me.Controls.Add(Me.Lblnombre)
        Me.Controls.Add(Me.Cboalumno)
        Me.Controls.Add(Me.Label)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnRegresar As System.Windows.Forms.Button
    Friend WithEvents Btncapturar As System.Windows.Forms.Button
    Friend WithEvents Cbocurso As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl3 As System.Windows.Forms.Label
    Friend WithEvents Lblnombre As System.Windows.Forms.Label
    Friend WithEvents Cboalumno As System.Windows.Forms.ComboBox
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
