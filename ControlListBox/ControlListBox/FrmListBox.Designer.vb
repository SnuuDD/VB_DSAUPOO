<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListBox
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
        Me.Btn_Acción = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Textnumagregar = New System.Windows.Forms.TextBox()
        Me.Btnagregar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lslnum = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Acción
        '
        Me.Btn_Acción.AutoSize = True
        Me.Btn_Acción.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btn_Acción.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Acción.Location = New System.Drawing.Point(327, 316)
        Me.Btn_Acción.Name = "Btn_Acción"
        Me.Btn_Acción.Size = New System.Drawing.Size(104, 34)
        Me.Btn_Acción.TabIndex = 48
        Me.Btn_Acción.Text = "&Acción"
        Me.Btn_Acción.UseVisualStyleBackColor = False
        '
        'Btn_Salir
        '
        Me.Btn_Salir.AutoSize = True
        Me.Btn_Salir.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btn_Salir.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Salir.Location = New System.Drawing.Point(12, 316)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(104, 34)
        Me.Btn_Salir.TabIndex = 47
        Me.Btn_Salir.Text = "&Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(211, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 23)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Escribe un numero"
        '
        'Textnumagregar
        '
        Me.Textnumagregar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Textnumagregar.Location = New System.Drawing.Point(242, 73)
        Me.Textnumagregar.Name = "Textnumagregar"
        Me.Textnumagregar.Size = New System.Drawing.Size(100, 26)
        Me.Textnumagregar.TabIndex = 58
        '
        'Btnagregar
        '
        Me.Btnagregar.AutoSize = True
        Me.Btnagregar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btnagregar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btnagregar.Location = New System.Drawing.Point(242, 115)
        Me.Btnagregar.Name = "Btnagregar"
        Me.Btnagregar.Size = New System.Drawing.Size(100, 34)
        Me.Btnagregar.TabIndex = 59
        Me.Btnagregar.Text = "&Agregar"
        Me.Btnagregar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(12, 174)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(207, 34)
        Me.Button2.TabIndex = 60
        Me.Button2.Text = "Limpiar Toda la Lista"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(12, 214)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(231, 34)
        Me.Button3.TabIndex = 61
        Me.Button3.Text = "Limpiar Segun Posicion"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'lslnum
        '
        Me.lslnum.Font = New System.Drawing.Font("Century Gothic", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lslnum.FormattingEnabled = True
        Me.lslnum.ItemHeight = 17
        Me.lslnum.Location = New System.Drawing.Point(33, 12)
        Me.lslnum.Name = "lslnum"
        Me.lslnum.Size = New System.Drawing.Size(125, 140)
        Me.lslnum.TabIndex = 62
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Century Gothic", 10.25!, System.Drawing.FontStyle.Bold)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Location = New System.Drawing.Point(482, 30)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(125, 140)
        Me.ListBox1.TabIndex = 64
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button4.Location = New System.Drawing.Point(242, 164)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(105, 34)
        Me.Button4.TabIndex = 65
        Me.Button4.Text = "&Mover >>"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'FrmListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 401)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lslnum)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Btnagregar)
        Me.Controls.Add(Me.Textnumagregar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Btn_Acción)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Name = "FrmListBox"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Acción As System.Windows.Forms.Button
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Textnumagregar As System.Windows.Forms.TextBox
    Friend WithEvents Btnagregar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lslnum As System.Windows.Forms.ListBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
