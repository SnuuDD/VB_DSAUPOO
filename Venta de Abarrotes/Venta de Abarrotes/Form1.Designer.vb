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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_Calcula = New System.Windows.Forms.Button()
        Me.Btn_Pagar = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboOperaciones = New System.Windows.Forms.ComboBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.precio1 = New System.Windows.Forms.Label()
        Me.precio2 = New System.Windows.Forms.Label()
        Me.precio3 = New System.Windows.Forms.Label()
        Me.p1 = New System.Windows.Forms.Label()
        Me.p2 = New System.Windows.Forms.Label()
        Me.p3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(270, 23)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Elige el producto a comprar"
        '
        'Btn_Calcula
        '
        Me.Btn_Calcula.AutoSize = True
        Me.Btn_Calcula.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btn_Calcula.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Calcula.Location = New System.Drawing.Point(508, 79)
        Me.Btn_Calcula.Name = "Btn_Calcula"
        Me.Btn_Calcula.Size = New System.Drawing.Size(104, 34)
        Me.Btn_Calcula.TabIndex = 42
        Me.Btn_Calcula.Text = "&Agregar"
        Me.Btn_Calcula.UseVisualStyleBackColor = False
        '
        'Btn_Pagar
        '
        Me.Btn_Pagar.AutoSize = True
        Me.Btn_Pagar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btn_Pagar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Pagar.Location = New System.Drawing.Point(12, 527)
        Me.Btn_Pagar.Name = "Btn_Pagar"
        Me.Btn_Pagar.Size = New System.Drawing.Size(104, 34)
        Me.Btn_Pagar.TabIndex = 41
        Me.Btn_Pagar.Text = "&Pagar"
        Me.Btn_Pagar.UseVisualStyleBackColor = False
        '
        'Btn_Salir
        '
        Me.Btn_Salir.AutoSize = True
        Me.Btn_Salir.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btn_Salir.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Salir.Location = New System.Drawing.Point(508, 527)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(104, 34)
        Me.Btn_Salir.TabIndex = 40
        Me.Btn_Salir.Text = "&Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(227, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 32)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Abarrotes :v"
        '
        'CboOperaciones
        '
        Me.CboOperaciones.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.CboOperaciones.FormattingEnabled = True
        Me.CboOperaciones.Items.AddRange(New Object() {"Arroz", "Frijoles", "Pasta de Dientes"})
        Me.CboOperaciones.Location = New System.Drawing.Point(335, 79)
        Me.CboOperaciones.Name = "CboOperaciones"
        Me.CboOperaciones.Size = New System.Drawing.Size(157, 31)
        Me.CboOperaciones.TabIndex = 46
        '
        'txt3
        '
        Me.txt3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txt3.Location = New System.Drawing.Point(166, 232)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(100, 26)
        Me.txt3.TabIndex = 53
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(248, 527)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 34)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "&Nueva Compra"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 23)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Cantidad"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Descripcion, Me.Cantidad, Me.Precio, Me.Importe})
        Me.DataGridView1.Location = New System.Drawing.Point(87, 355)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(479, 150)
        Me.DataGridView1.TabIndex = 59
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 23)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Precio"
        '
        'txt2
        '
        Me.txt2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txt2.Location = New System.Drawing.Point(166, 232)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(100, 26)
        Me.txt2.TabIndex = 54
        '
        'txt1
        '
        Me.txt1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txt1.Location = New System.Drawing.Point(166, 232)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 26)
        Me.txt1.TabIndex = 44
        '
        'precio1
        '
        Me.precio1.AutoSize = True
        Me.precio1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.precio1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.precio1.Location = New System.Drawing.Point(132, 174)
        Me.precio1.Name = "precio1"
        Me.precio1.Size = New System.Drawing.Size(15, 23)
        Me.precio1.TabIndex = 50
        Me.precio1.Text = " "
        '
        'precio2
        '
        Me.precio2.AutoSize = True
        Me.precio2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.precio2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.precio2.Location = New System.Drawing.Point(127, 178)
        Me.precio2.Name = "precio2"
        Me.precio2.Size = New System.Drawing.Size(20, 23)
        Me.precio2.TabIndex = 51
        Me.precio2.Text = "  "
        '
        'precio3
        '
        Me.precio3.AutoSize = True
        Me.precio3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.precio3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.precio3.Location = New System.Drawing.Point(127, 178)
        Me.precio3.Name = "precio3"
        Me.precio3.Size = New System.Drawing.Size(15, 23)
        Me.precio3.TabIndex = 52
        Me.precio3.Text = " "
        '
        'p1
        '
        Me.p1.AutoSize = True
        Me.p1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.p1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1.Location = New System.Drawing.Point(132, 126)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(0, 23)
        Me.p1.TabIndex = 47
        '
        'p2
        '
        Me.p2.AutoSize = True
        Me.p2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.p2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p2.Location = New System.Drawing.Point(132, 126)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(15, 23)
        Me.p2.TabIndex = 48
        Me.p2.Text = " "
        '
        'p3
        '
        Me.p3.AutoSize = True
        Me.p3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.p3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p3.Location = New System.Drawing.Point(132, 126)
        Me.p3.Name = "p3"
        Me.p3.Size = New System.Drawing.Size(15, 23)
        Me.p3.TabIndex = 49
        Me.p3.Text = " "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 23)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Producto"
        '
        'Importe
        '
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(632, 573)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.precio3)
        Me.Controls.Add(Me.precio2)
        Me.Controls.Add(Me.precio1)
        Me.Controls.Add(Me.p3)
        Me.Controls.Add(Me.p2)
        Me.Controls.Add(Me.p1)
        Me.Controls.Add(Me.CboOperaciones)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Btn_Calcula)
        Me.Controls.Add(Me.Btn_Pagar)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Btn_Calcula As System.Windows.Forms.Button
    Friend WithEvents Btn_Pagar As System.Windows.Forms.Button
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboOperaciones As System.Windows.Forms.ComboBox
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents precio1 As System.Windows.Forms.Label
    Friend WithEvents precio2 As System.Windows.Forms.Label
    Friend WithEvents precio3 As System.Windows.Forms.Label
    Friend WithEvents p1 As System.Windows.Forms.Label
    Friend WithEvents p2 As System.Windows.Forms.Label
    Friend WithEvents p3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
