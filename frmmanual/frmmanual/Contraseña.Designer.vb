<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contraseña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contraseña))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.usuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.contra = New System.Windows.Forms.TextBox()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(12, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre de Usuario"
        '
        'usuario
        '
        Me.usuario.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.usuario.Location = New System.Drawing.Point(224, 45)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(100, 31)
        Me.usuario.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(12, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Contraseña"
        '
        'contra
        '
        Me.contra.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Bold)
        Me.contra.Location = New System.Drawing.Point(179, 97)
        Me.contra.Name = "contra"
        Me.contra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9787)
        Me.contra.Size = New System.Drawing.Size(145, 21)
        Me.contra.TabIndex = 7
        '
        'btnagregar
        '
        Me.btnagregar.Image = CType(resources.GetObject("btnagregar.Image"), System.Drawing.Image)
        Me.btnagregar.Location = New System.Drawing.Point(106, 146)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(49, 40)
        Me.btnagregar.TabIndex = 9
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(206, 146)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(47, 40)
        Me.Button5.TabIndex = 12
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Contraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 198)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.contra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.usuario)
        Me.Name = "Contraseña"
        Me.Text = "Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents contra As System.Windows.Forms.TextBox
    Friend WithEvents btnagregar As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
