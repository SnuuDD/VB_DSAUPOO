<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ALTASConcepto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ALTASConcepto))
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.txtidconcepto = New System.Windows.Forms.TextBox()
        Me.txttipoconcepto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBoxEspecial = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBoxColor = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnRegresar
        '
        Me.BtnRegresar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnRegresar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnRegresar.Location = New System.Drawing.Point(20, 386)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(113, 32)
        Me.BtnRegresar.TabIndex = 44
        Me.BtnRegresar.Text = "&REGRESAR"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCancelar.Location = New System.Drawing.Point(20, 330)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(109, 29)
        Me.BtnCancelar.TabIndex = 43
        Me.BtnCancelar.Text = "&CANCELAR"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnAgregar.Location = New System.Drawing.Point(20, 271)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(109, 32)
        Me.BtnAgregar.TabIndex = 42
        Me.BtnAgregar.Text = "&AGREGAR"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'txtidconcepto
        '
        Me.txtidconcepto.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtidconcepto.Location = New System.Drawing.Point(223, 63)
        Me.txtidconcepto.Name = "txtidconcepto"
        Me.txtidconcepto.Size = New System.Drawing.Size(100, 27)
        Me.txtidconcepto.TabIndex = 1
        '
        'txttipoconcepto
        '
        Me.txttipoconcepto.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txttipoconcepto.Location = New System.Drawing.Point(223, 105)
        Me.txttipoconcepto.Name = "txttipoconcepto"
        Me.txttipoconcepto.Size = New System.Drawing.Size(100, 27)
        Me.txttipoconcepto.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(41, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 23)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Especial"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(41, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 23)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Tipo de Concepto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(41, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 23)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "IDConcepto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 23)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Ingresa todos los datos del CONCEPTO"
        '
        'CheckBoxEspecial
        '
        Me.CheckBoxEspecial.BackColor = System.Drawing.Color.CornflowerBlue
        Me.CheckBoxEspecial.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBoxEspecial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBoxEspecial.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBoxEspecial.ForeColor = System.Drawing.Color.White
        Me.CheckBoxEspecial.Location = New System.Drawing.Point(146, 145)
        Me.CheckBoxEspecial.Name = "CheckBoxEspecial"
        Me.CheckBoxEspecial.Size = New System.Drawing.Size(28, 23)
        Me.CheckBoxEspecial.TabIndex = 3
        Me.CheckBoxEspecial.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(41, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 23)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Color"
        '
        'CheckBoxColor
        '
        Me.CheckBoxColor.BackColor = System.Drawing.Color.CornflowerBlue
        Me.CheckBoxColor.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBoxColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBoxColor.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBoxColor.ForeColor = System.Drawing.Color.White
        Me.CheckBoxColor.Location = New System.Drawing.Point(146, 187)
        Me.CheckBoxColor.Name = "CheckBoxColor"
        Me.CheckBoxColor.Size = New System.Drawing.Size(28, 23)
        Me.CheckBoxColor.TabIndex = 46
        Me.CheckBoxColor.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(43, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 23)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Descripción"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdescripcion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtdescripcion.Location = New System.Drawing.Point(168, 224)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(278, 194)
        Me.txtdescripcion.TabIndex = 48
        '
        'ALTASConcepto
        '
        Me.AcceptButton = Me.BtnAgregar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.CancelButton = Me.BtnRegresar
        Me.ClientSize = New System.Drawing.Size(467, 443)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CheckBoxColor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckBoxEspecial)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.txtidconcepto)
        Me.Controls.Add(Me.txttipoconcepto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.PanNorth
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "ALTASConcepto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "A L T A S   C O N C E P T O"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnRegresar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtidconcepto As System.Windows.Forms.TextBox
    Friend WithEvents txttipoconcepto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxEspecial As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxColor As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox

End Class
