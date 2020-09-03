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
        Me.GrpTamaño = New System.Windows.Forms.GroupBox()
        Me.RBtnGrande = New System.Windows.Forms.RadioButton()
        Me.RBtnMed = New System.Windows.Forms.RadioButton()
        Me.RBtnPequeña = New System.Windows.Forms.RadioButton()
        Me.GrpIngredientes = New System.Windows.Forms.GroupBox()
        Me.RBtnMexicana = New System.Windows.Forms.RadioButton()
        Me.RBtnHawaiana = New System.Windows.Forms.RadioButton()
        Me.RBtnPepperoni = New System.Windows.Forms.RadioButton()
        Me.GrpExtra = New System.Windows.Forms.GroupBox()
        Me.CheckAlitas = New System.Windows.Forms.CheckBox()
        Me.CheckDoble = New System.Windows.Forms.CheckBox()
        Me.CheckExtra = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtCambio = New System.Windows.Forms.TextBox()
        Me.TxtEfectivo = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GrpTamaño.SuspendLayout()
        Me.GrpIngredientes.SuspendLayout()
        Me.GrpExtra.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpTamaño
        '
        Me.GrpTamaño.Controls.Add(Me.RBtnGrande)
        Me.GrpTamaño.Controls.Add(Me.RBtnMed)
        Me.GrpTamaño.Controls.Add(Me.RBtnPequeña)
        Me.GrpTamaño.Font = New System.Drawing.Font("Century Gothic", 10.25!, System.Drawing.FontStyle.Bold)
        Me.GrpTamaño.Location = New System.Drawing.Point(16, 50)
        Me.GrpTamaño.Margin = New System.Windows.Forms.Padding(4)
        Me.GrpTamaño.Name = "GrpTamaño"
        Me.GrpTamaño.Padding = New System.Windows.Forms.Padding(4)
        Me.GrpTamaño.Size = New System.Drawing.Size(267, 131)
        Me.GrpTamaño.TabIndex = 0
        Me.GrpTamaño.TabStop = False
        Me.GrpTamaño.Text = "TAMAÑO DE PIZZA"
        '
        'RBtnGrande
        '
        Me.RBtnGrande.AutoSize = True
        Me.RBtnGrande.Location = New System.Drawing.Point(15, 81)
        Me.RBtnGrande.Margin = New System.Windows.Forms.Padding(4)
        Me.RBtnGrande.Name = "RBtnGrande"
        Me.RBtnGrande.Size = New System.Drawing.Size(83, 21)
        Me.RBtnGrande.TabIndex = 2
        Me.RBtnGrande.TabStop = True
        Me.RBtnGrande.Text = "GRANDE"
        Me.RBtnGrande.UseVisualStyleBackColor = True
        '
        'RBtnMed
        '
        Me.RBtnMed.AutoSize = True
        Me.RBtnMed.Location = New System.Drawing.Point(15, 51)
        Me.RBtnMed.Margin = New System.Windows.Forms.Padding(4)
        Me.RBtnMed.Name = "RBtnMed"
        Me.RBtnMed.Size = New System.Drawing.Size(90, 21)
        Me.RBtnMed.TabIndex = 1
        Me.RBtnMed.TabStop = True
        Me.RBtnMed.Text = "MEDIANA"
        Me.RBtnMed.UseVisualStyleBackColor = True
        '
        'RBtnPequeña
        '
        Me.RBtnPequeña.AutoSize = True
        Me.RBtnPequeña.Location = New System.Drawing.Point(15, 21)
        Me.RBtnPequeña.Margin = New System.Windows.Forms.Padding(4)
        Me.RBtnPequeña.Name = "RBtnPequeña"
        Me.RBtnPequeña.Size = New System.Drawing.Size(89, 21)
        Me.RBtnPequeña.TabIndex = 0
        Me.RBtnPequeña.TabStop = True
        Me.RBtnPequeña.Text = "PEQUEÑA"
        Me.RBtnPequeña.UseVisualStyleBackColor = True
        '
        'GrpIngredientes
        '
        Me.GrpIngredientes.Controls.Add(Me.RBtnMexicana)
        Me.GrpIngredientes.Controls.Add(Me.RBtnHawaiana)
        Me.GrpIngredientes.Controls.Add(Me.RBtnPepperoni)
        Me.GrpIngredientes.Font = New System.Drawing.Font("Century Gothic", 10.25!, System.Drawing.FontStyle.Bold)
        Me.GrpIngredientes.Location = New System.Drawing.Point(332, 50)
        Me.GrpIngredientes.Margin = New System.Windows.Forms.Padding(4)
        Me.GrpIngredientes.Name = "GrpIngredientes"
        Me.GrpIngredientes.Padding = New System.Windows.Forms.Padding(4)
        Me.GrpIngredientes.Size = New System.Drawing.Size(267, 131)
        Me.GrpIngredientes.TabIndex = 0
        Me.GrpIngredientes.TabStop = False
        Me.GrpIngredientes.Text = "INGREDIENTES"
        '
        'RBtnMexicana
        '
        Me.RBtnMexicana.AutoSize = True
        Me.RBtnMexicana.Location = New System.Drawing.Point(15, 81)
        Me.RBtnMexicana.Margin = New System.Windows.Forms.Padding(4)
        Me.RBtnMexicana.Name = "RBtnMexicana"
        Me.RBtnMexicana.Size = New System.Drawing.Size(148, 21)
        Me.RBtnMexicana.TabIndex = 2
        Me.RBtnMexicana.TabStop = True
        Me.RBtnMexicana.Text = "PIZZA SORPRESA :v"
        Me.RBtnMexicana.UseVisualStyleBackColor = True
        '
        'RBtnHawaiana
        '
        Me.RBtnHawaiana.AutoSize = True
        Me.RBtnHawaiana.Location = New System.Drawing.Point(15, 51)
        Me.RBtnHawaiana.Margin = New System.Windows.Forms.Padding(4)
        Me.RBtnHawaiana.Name = "RBtnHawaiana"
        Me.RBtnHawaiana.Size = New System.Drawing.Size(125, 21)
        Me.RBtnHawaiana.TabIndex = 1
        Me.RBtnHawaiana.TabStop = True
        Me.RBtnHawaiana.Text = "GZUZ ESPECIAL"
        Me.RBtnHawaiana.UseVisualStyleBackColor = True
        '
        'RBtnPepperoni
        '
        Me.RBtnPepperoni.AutoSize = True
        Me.RBtnPepperoni.Location = New System.Drawing.Point(15, 21)
        Me.RBtnPepperoni.Margin = New System.Windows.Forms.Padding(4)
        Me.RBtnPepperoni.Name = "RBtnPepperoni"
        Me.RBtnPepperoni.Size = New System.Drawing.Size(151, 21)
        Me.RBtnPepperoni.TabIndex = 0
        Me.RBtnPepperoni.TabStop = True
        Me.RBtnPepperoni.Text = "CARNES CALIENTES"
        Me.RBtnPepperoni.UseVisualStyleBackColor = True
        '
        'GrpExtra
        '
        Me.GrpExtra.Controls.Add(Me.CheckAlitas)
        Me.GrpExtra.Controls.Add(Me.CheckDoble)
        Me.GrpExtra.Controls.Add(Me.CheckExtra)
        Me.GrpExtra.Font = New System.Drawing.Font("Century Gothic", 10.25!, System.Drawing.FontStyle.Bold)
        Me.GrpExtra.Location = New System.Drawing.Point(668, 50)
        Me.GrpExtra.Margin = New System.Windows.Forms.Padding(4)
        Me.GrpExtra.Name = "GrpExtra"
        Me.GrpExtra.Padding = New System.Windows.Forms.Padding(4)
        Me.GrpExtra.Size = New System.Drawing.Size(267, 131)
        Me.GrpExtra.TabIndex = 1
        Me.GrpExtra.TabStop = False
        Me.GrpExtra.Text = "INGREDIENTES EXTRA"
        '
        'CheckAlitas
        '
        Me.CheckAlitas.AutoSize = True
        Me.CheckAlitas.Location = New System.Drawing.Point(15, 81)
        Me.CheckAlitas.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckAlitas.Name = "CheckAlitas"
        Me.CheckAlitas.Size = New System.Drawing.Size(153, 21)
        Me.CheckAlitas.TabIndex = 2
        Me.CheckAlitas.Text = "REFRESCO Y PAPAS"
        Me.CheckAlitas.UseVisualStyleBackColor = True
        '
        'CheckDoble
        '
        Me.CheckDoble.AutoSize = True
        Me.CheckDoble.Location = New System.Drawing.Point(15, 51)
        Me.CheckDoble.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckDoble.Name = "CheckDoble"
        Me.CheckDoble.Size = New System.Drawing.Size(145, 21)
        Me.CheckDoble.TabIndex = 1
        Me.CheckDoble.Text = "COMBO AMIGOS"
        Me.CheckDoble.UseVisualStyleBackColor = True
        '
        'CheckExtra
        '
        Me.CheckExtra.AutoSize = True
        Me.CheckExtra.Location = New System.Drawing.Point(15, 22)
        Me.CheckExtra.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckExtra.Name = "CheckExtra"
        Me.CheckExtra.Size = New System.Drawing.Size(117, 21)
        Me.CheckExtra.TabIndex = 0
        Me.CheckExtra.Text = "TRIPLE QUESO"
        Me.CheckExtra.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TxtCambio)
        Me.Panel1.Controls.Add(Me.TxtEfectivo)
        Me.Panel1.Controls.Add(Me.TxtTotal)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(347, 205)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 131)
        Me.Panel1.TabIndex = 5
        Me.Panel1.Visible = False
        '
        'TxtCambio
        '
        Me.TxtCambio.Location = New System.Drawing.Point(99, 93)
        Me.TxtCambio.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCambio.Name = "TxtCambio"
        Me.TxtCambio.Size = New System.Drawing.Size(132, 24)
        Me.TxtCambio.TabIndex = 5
        '
        'TxtEfectivo
        '
        Me.TxtEfectivo.Location = New System.Drawing.Point(113, 54)
        Me.TxtEfectivo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtEfectivo.Name = "TxtEfectivo"
        Me.TxtEfectivo.Size = New System.Drawing.Size(132, 24)
        Me.TxtEfectivo.TabIndex = 4
        '
        'TxtTotal
        '
        Me.TxtTotal.Font = New System.Drawing.Font("Century Gothic", 10.25!, System.Drawing.FontStyle.Bold)
        Me.TxtTotal.Location = New System.Drawing.Point(149, 22)
        Me.TxtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(109, 24)
        Me.TxtTotal.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 97)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CAMBIO: $"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "EFECTIVO: $"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TOTAL A PAGAR: $"
        '
        'Btn_Salir
        '
        Me.Btn_Salir.AutoSize = True
        Me.Btn_Salir.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btn_Salir.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Salir.Location = New System.Drawing.Point(832, 344)
        Me.Btn_Salir.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(139, 44)
        Me.Btn_Salir.TabIndex = 46
        Me.Btn_Salir.Text = "&Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(25, 335)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 44)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "&Pagar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(376, 344)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(217, 44)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "Nueva Compra"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(361, -2)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(217, 44)
        Me.Button3.TabIndex = 49
        Me.Button3.Text = "PIZZERIA GZUZ"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(984, 395)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GrpExtra)
        Me.Controls.Add(Me.GrpIngredientes)
        Me.Controls.Add(Me.GrpTamaño)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GrpTamaño.ResumeLayout(False)
        Me.GrpTamaño.PerformLayout()
        Me.GrpIngredientes.ResumeLayout(False)
        Me.GrpIngredientes.PerformLayout()
        Me.GrpExtra.ResumeLayout(False)
        Me.GrpExtra.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpTamaño As System.Windows.Forms.GroupBox
    Friend WithEvents GrpIngredientes As System.Windows.Forms.GroupBox
    Friend WithEvents RBtnGrande As System.Windows.Forms.RadioButton
    Friend WithEvents RBtnMed As System.Windows.Forms.RadioButton
    Friend WithEvents RBtnPequeña As System.Windows.Forms.RadioButton
    Friend WithEvents RBtnMexicana As System.Windows.Forms.RadioButton
    Friend WithEvents RBtnHawaiana As System.Windows.Forms.RadioButton
    Friend WithEvents RBtnPepperoni As System.Windows.Forms.RadioButton
    Friend WithEvents GrpExtra As System.Windows.Forms.GroupBox
    Friend WithEvents CheckAlitas As System.Windows.Forms.CheckBox
    Friend WithEvents CheckDoble As System.Windows.Forms.CheckBox
    Friend WithEvents CheckExtra As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCambio As System.Windows.Forms.TextBox
    Friend WithEvents TxtEfectivo As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
