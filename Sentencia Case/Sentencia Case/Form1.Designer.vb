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
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Acción = New System.Windows.Forms.Button()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Txtnum2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CboOperaciones = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtnum1
        '
        Me.txtnum1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtnum1.Location = New System.Drawing.Point(319, 103)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(100, 26)
        Me.txtnum1.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(243, 23)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Escribe el primer numero:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 23)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Escribe la operacion a realizar"
        '
        'Btn_Acción
        '
        Me.Btn_Acción.AutoSize = True
        Me.Btn_Acción.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btn_Acción.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Acción.Location = New System.Drawing.Point(467, 53)
        Me.Btn_Acción.Name = "Btn_Acción"
        Me.Btn_Acción.Size = New System.Drawing.Size(104, 34)
        Me.Btn_Acción.TabIndex = 57
        Me.Btn_Acción.Text = "&Calcular"
        Me.Btn_Acción.UseVisualStyleBackColor = False
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.AutoSize = True
        Me.Btn_Limpiar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btn_Limpiar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Limpiar.Location = New System.Drawing.Point(467, 234)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(104, 34)
        Me.Btn_Limpiar.TabIndex = 58
        Me.Btn_Limpiar.Text = "&Limpiar"
        Me.Btn_Limpiar.UseVisualStyleBackColor = False
        '
        'Btn_Salir
        '
        Me.Btn_Salir.AutoSize = True
        Me.Btn_Salir.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btn_Salir.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Salir.Location = New System.Drawing.Point(12, 234)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(104, 34)
        Me.Btn_Salir.TabIndex = 56
        Me.Btn_Salir.Text = "&Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = False
        '
        'Txtnum2
        '
        Me.Txtnum2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Txtnum2.Location = New System.Drawing.Point(319, 143)
        Me.Txtnum2.Name = "Txtnum2"
        Me.Txtnum2.Size = New System.Drawing.Size(100, 26)
        Me.Txtnum2.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(263, 23)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Escribe el segundo numero:"
        '
        'CboOperaciones
        '
        Me.CboOperaciones.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.CboOperaciones.FormattingEnabled = True
        Me.CboOperaciones.Items.AddRange(New Object() {"Suma", "Resta", "Multiplicación", "División"})
        Me.CboOperaciones.Location = New System.Drawing.Point(319, 61)
        Me.CboOperaciones.Name = "CboOperaciones"
        Me.CboOperaciones.Size = New System.Drawing.Size(121, 26)
        Me.CboOperaciones.TabIndex = 68
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 280)
        Me.Controls.Add(Me.CboOperaciones)
        Me.Controls.Add(Me.Txtnum2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Acción)
        Me.Controls.Add(Me.Btn_Limpiar)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnum1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Acción As System.Windows.Forms.Button
    Friend WithEvents Btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents Txtnum2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboOperaciones As System.Windows.Forms.ComboBox

End Class
