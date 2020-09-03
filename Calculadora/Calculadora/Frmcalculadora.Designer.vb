<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmcalculadora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmcalculadora))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btn_Sum = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.Btn_Div = New System.Windows.Forms.Button()
        Me.Btn_mul = New System.Windows.Forms.Button()
        Me.Btn_Men = New System.Windows.Forms.Button()
        Me.lblresultado = New System.Windows.Forms.Label()
        Me.Txtnumero = New System.Windows.Forms.TextBox()
        Me.Txtnumero2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Lavender
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Escribe otro numero:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Lavender
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "El resultado es:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Lavender
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Escribe un numero:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(66, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(276, 34)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Calculadora Básica"
        '
        'Btn_Sum
        '
        Me.Btn_Sum.AutoSize = True
        Me.Btn_Sum.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Btn_Sum.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Sum.Location = New System.Drawing.Point(379, 79)
        Me.Btn_Sum.Name = "Btn_Sum"
        Me.Btn_Sum.Size = New System.Drawing.Size(31, 33)
        Me.Btn_Sum.TabIndex = 8
        Me.Btn_Sum.Text = "+"
        Me.Btn_Sum.UseVisualStyleBackColor = False
        '
        'Btn_Salir
        '
        Me.Btn_Salir.AutoSize = True
        Me.Btn_Salir.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Btn_Salir.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Salir.Location = New System.Drawing.Point(318, 366)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(104, 34)
        Me.Btn_Salir.TabIndex = 12
        Me.Btn_Salir.Text = "&Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = False
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.AutoSize = True
        Me.Btn_Limpiar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Btn_Limpiar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Limpiar.Location = New System.Drawing.Point(11, 366)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(104, 34)
        Me.Btn_Limpiar.TabIndex = 13
        Me.Btn_Limpiar.Text = "&Limpiar"
        Me.Btn_Limpiar.UseVisualStyleBackColor = False
        '
        'Btn_Div
        '
        Me.Btn_Div.AutoSize = True
        Me.Btn_Div.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Btn_Div.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Div.Location = New System.Drawing.Point(379, 226)
        Me.Btn_Div.Name = "Btn_Div"
        Me.Btn_Div.Size = New System.Drawing.Size(31, 33)
        Me.Btn_Div.TabIndex = 15
        Me.Btn_Div.Text = "/"
        Me.Btn_Div.UseVisualStyleBackColor = False
        '
        'Btn_mul
        '
        Me.Btn_mul.AutoSize = True
        Me.Btn_mul.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Btn_mul.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_mul.Location = New System.Drawing.Point(379, 176)
        Me.Btn_mul.Name = "Btn_mul"
        Me.Btn_mul.Size = New System.Drawing.Size(31, 33)
        Me.Btn_mul.TabIndex = 16
        Me.Btn_mul.Text = "*"
        Me.Btn_mul.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_mul.UseVisualStyleBackColor = False
        '
        'Btn_Men
        '
        Me.Btn_Men.AutoSize = True
        Me.Btn_Men.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Btn_Men.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Men.Location = New System.Drawing.Point(379, 127)
        Me.Btn_Men.Name = "Btn_Men"
        Me.Btn_Men.Size = New System.Drawing.Size(31, 33)
        Me.Btn_Men.TabIndex = 17
        Me.Btn_Men.Text = "-"
        Me.Btn_Men.UseVisualStyleBackColor = False
        '
        'lblresultado
        '
        Me.lblresultado.AutoSize = True
        Me.lblresultado.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblresultado.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresultado.Location = New System.Drawing.Point(210, 184)
        Me.lblresultado.Name = "lblresultado"
        Me.lblresultado.Size = New System.Drawing.Size(45, 25)
        Me.lblresultado.TabIndex = 5
        Me.lblresultado.Text = "___"
        '
        'Txtnumero
        '
        Me.Txtnumero.Font = New System.Drawing.Font("Century Gothic", 10.25!)
        Me.Txtnumero.Location = New System.Drawing.Point(210, 88)
        Me.Txtnumero.Name = "Txtnumero"
        Me.Txtnumero.Size = New System.Drawing.Size(100, 24)
        Me.Txtnumero.TabIndex = 18
        '
        'Txtnumero2
        '
        Me.Txtnumero2.Font = New System.Drawing.Font("Century Gothic", 10.25!)
        Me.Txtnumero2.Location = New System.Drawing.Point(210, 131)
        Me.Txtnumero2.Name = "Txtnumero2"
        Me.Txtnumero2.Size = New System.Drawing.Size(100, 24)
        Me.Txtnumero2.TabIndex = 19
        '
        'Frmcalculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(434, 412)
        Me.Controls.Add(Me.Txtnumero2)
        Me.Controls.Add(Me.Txtnumero)
        Me.Controls.Add(Me.Btn_Men)
        Me.Controls.Add(Me.Btn_mul)
        Me.Controls.Add(Me.Btn_Div)
        Me.Controls.Add(Me.Btn_Limpiar)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Btn_Sum)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblresultado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmcalculadora"
        Me.Text = "Calculadora Basica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Btn_Sum As System.Windows.Forms.Button
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents Btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents Btn_Div As System.Windows.Forms.Button
    Friend WithEvents Btn_mul As System.Windows.Forms.Button
    Friend WithEvents Btn_Men As System.Windows.Forms.Button
    Friend WithEvents lblresultado As System.Windows.Forms.Label
    Friend WithEvents Txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents Txtnumero2 As System.Windows.Forms.TextBox

End Class
