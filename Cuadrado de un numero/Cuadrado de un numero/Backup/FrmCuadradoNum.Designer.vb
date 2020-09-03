<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Operaciones
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Txt_num = New System.Windows.Forms.TextBox
        Me.Btn_Salir = New System.Windows.Forms.Button
        Me.btn_calcular = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblresultado = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cuadrado de un Número"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(21, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(257, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingrese un numero compa:"
        '
        'Txt_num
        '
        Me.Txt_num.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Txt_num.Location = New System.Drawing.Point(284, 80)
        Me.Txt_num.Name = "Txt_num"
        Me.Txt_num.Size = New System.Drawing.Size(100, 27)
        Me.Txt_num.TabIndex = 2
        '
        'Btn_Salir
        '
        Me.Btn_Salir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Salir.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Salir.Location = New System.Drawing.Point(347, 368)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(75, 32)
        Me.Btn_Salir.TabIndex = 3
        Me.Btn_Salir.Text = "&Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'btn_calcular
        '
        Me.btn_calcular.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_calcular.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btn_calcular.Location = New System.Drawing.Point(12, 368)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(116, 32)
        Me.btn_calcular.TabIndex = 4
        Me.btn_calcular.Text = "Calcular"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(74, 195)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 23)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Su resultado es:"
        '
        'lblresultado
        '
        Me.lblresultado.AutoSize = True
        Me.lblresultado.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblresultado.Location = New System.Drawing.Point(232, 195)
        Me.lblresultado.Name = "lblresultado"
        Me.lblresultado.Size = New System.Drawing.Size(0, 23)
        Me.lblresultado.TabIndex = 6
        '
        'Operaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(434, 412)
        Me.Controls.Add(Me.lblresultado)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Txt_num)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Operaciones"
        Me.Text = "Operaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_num As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents btn_calcular As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblresultado As System.Windows.Forms.Label

End Class
