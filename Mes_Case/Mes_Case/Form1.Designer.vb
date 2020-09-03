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
        Me.Txtnum2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btn_Acción = New System.Windows.Forms.Button()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Txtnum2
        '
        Me.Txtnum2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Txtnum2.Location = New System.Drawing.Point(259, 61)
        Me.Txtnum2.Name = "Txtnum2"
        Me.Txtnum2.Size = New System.Drawing.Size(100, 26)
        Me.Txtnum2.TabIndex = 72
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(227, 23)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Escribe un mes del año:"
        '
        'Btn_Acción
        '
        Me.Btn_Acción.AutoSize = True
        Me.Btn_Acción.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btn_Acción.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Acción.Location = New System.Drawing.Point(390, 28)
        Me.Btn_Acción.Name = "Btn_Acción"
        Me.Btn_Acción.Size = New System.Drawing.Size(104, 34)
        Me.Btn_Acción.TabIndex = 69
        Me.Btn_Acción.Text = "&Calcular"
        Me.Btn_Acción.UseVisualStyleBackColor = False
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.AutoSize = True
        Me.Btn_Limpiar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btn_Limpiar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Limpiar.Location = New System.Drawing.Point(391, 124)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(104, 34)
        Me.Btn_Limpiar.TabIndex = 70
        Me.Btn_Limpiar.Text = "&Limpiar"
        Me.Btn_Limpiar.UseVisualStyleBackColor = False
        '
        'Btn_Salir
        '
        Me.Btn_Salir.AutoSize = True
        Me.Btn_Salir.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btn_Salir.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Salir.Location = New System.Drawing.Point(26, 124)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(104, 34)
        Me.Btn_Salir.TabIndex = 68
        Me.Btn_Salir.Text = "&Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 171)
        Me.Controls.Add(Me.Txtnum2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Btn_Acción)
        Me.Controls.Add(Me.Btn_Limpiar)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtnum2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Btn_Acción As System.Windows.Forms.Button
    Friend WithEvents Btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button

End Class
