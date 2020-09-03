<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Evalua_Numeros
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
        Me.mayor = New System.Windows.Forms.Label()
        Me.n1 = New System.Windows.Forms.TextBox()
        Me.Btn_Acción = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.n2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.n3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.menor = New System.Windows.Forms.Label()
        Me.igual = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'mayor
        '
        Me.mayor.AutoSize = True
        Me.mayor.BackColor = System.Drawing.Color.CornflowerBlue
        Me.mayor.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mayor.Location = New System.Drawing.Point(156, 215)
        Me.mayor.Name = "mayor"
        Me.mayor.Size = New System.Drawing.Size(221, 23)
        Me.mayor.TabIndex = 49
        Me.mayor.Text = "Aparezco deaparezco"
        Me.mayor.Visible = False
        '
        'n1
        '
        Me.n1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.n1.Location = New System.Drawing.Point(311, 98)
        Me.n1.Name = "n1"
        Me.n1.Size = New System.Drawing.Size(100, 26)
        Me.n1.TabIndex = 43
        '
        'Btn_Acción
        '
        Me.Btn_Acción.AutoSize = True
        Me.Btn_Acción.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btn_Acción.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Acción.Location = New System.Drawing.Point(221, 345)
        Me.Btn_Acción.Name = "Btn_Acción"
        Me.Btn_Acción.Size = New System.Drawing.Size(104, 34)
        Me.Btn_Acción.TabIndex = 46
        Me.Btn_Acción.Text = "&Acción"
        Me.Btn_Acción.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 23)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Escribe el primer numero:"
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.AutoSize = True
        Me.Btn_Limpiar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btn_Limpiar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Limpiar.Location = New System.Drawing.Point(397, 345)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(104, 34)
        Me.Btn_Limpiar.TabIndex = 47
        Me.Btn_Limpiar.Text = "&Limpiar"
        Me.Btn_Limpiar.UseVisualStyleBackColor = False
        '
        'Btn_Salir
        '
        Me.Btn_Salir.AutoSize = True
        Me.Btn_Salir.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btn_Salir.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Salir.Location = New System.Drawing.Point(43, 345)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(104, 34)
        Me.Btn_Salir.TabIndex = 45
        Me.Btn_Salir.Text = "&Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(150, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(259, 34)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Evalua 3 Numeros."
        '
        'n2
        '
        Me.n2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.n2.Location = New System.Drawing.Point(311, 132)
        Me.n2.Name = "n2"
        Me.n2.Size = New System.Drawing.Size(100, 26)
        Me.n2.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 23)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Escribe el segundo numero:"
        '
        'n3
        '
        Me.n3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.n3.Location = New System.Drawing.Point(311, 164)
        Me.n3.Name = "n3"
        Me.n3.Size = New System.Drawing.Size(100, 26)
        Me.n3.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(237, 23)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Escribe el tercer numero:"
        '
        'menor
        '
        Me.menor.AutoSize = True
        Me.menor.BackColor = System.Drawing.Color.CornflowerBlue
        Me.menor.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menor.Location = New System.Drawing.Point(156, 252)
        Me.menor.Name = "menor"
        Me.menor.Size = New System.Drawing.Size(221, 23)
        Me.menor.TabIndex = 54
        Me.menor.Text = "Aparezco deaparezco"
        Me.menor.Visible = False
        '
        'igual
        '
        Me.igual.AutoSize = True
        Me.igual.BackColor = System.Drawing.Color.CornflowerBlue
        Me.igual.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.igual.Location = New System.Drawing.Point(156, 290)
        Me.igual.Name = "igual"
        Me.igual.Size = New System.Drawing.Size(0, 23)
        Me.igual.TabIndex = 55
        Me.igual.Visible = False
        '
        'Evalua_Numeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(546, 406)
        Me.Controls.Add(Me.igual)
        Me.Controls.Add(Me.menor)
        Me.Controls.Add(Me.n3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.n2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mayor)
        Me.Controls.Add(Me.n1)
        Me.Controls.Add(Me.Btn_Acción)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_Limpiar)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Evalua_Numeros"
        Me.Text = "Evalua un Numero"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mayor As System.Windows.Forms.Label
    Friend WithEvents n1 As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Acción As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents n2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents n3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents menor As System.Windows.Forms.Label
    Friend WithEvents igual As System.Windows.Forms.Label

End Class
