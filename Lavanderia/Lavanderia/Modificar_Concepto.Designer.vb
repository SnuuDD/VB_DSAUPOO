<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Concepto
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
        Me.Txtid = New System.Windows.Forms.TextBox()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.lblcolor = New System.Windows.Forms.Label()
        Me.lblespecial = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btnguardar = New System.Windows.Forms.Button()
        Me.lblempleado = New System.Windows.Forms.Label()
        Me.txttipo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Btnregresar = New System.Windows.Forms.Button()
        Me.Btnbuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txtid
        '
        Me.Txtid.Location = New System.Drawing.Point(138, 27)
        Me.Txtid.Name = "Txtid"
        Me.Txtid.Size = New System.Drawing.Size(145, 20)
        Me.Txtid.TabIndex = 24
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.lblcolor)
        Me.GroupBox.Controls.Add(Me.lblespecial)
        Me.GroupBox.Controls.Add(Me.txtdescripcion)
        Me.GroupBox.Controls.Add(Me.Label5)
        Me.GroupBox.Controls.Add(Me.Label6)
        Me.GroupBox.Controls.Add(Me.Btnguardar)
        Me.GroupBox.Controls.Add(Me.lblempleado)
        Me.GroupBox.Controls.Add(Me.txttipo)
        Me.GroupBox.Controls.Add(Me.Label4)
        Me.GroupBox.Controls.Add(Me.Label3)
        Me.GroupBox.Controls.Add(Me.Button2)
        Me.GroupBox.Location = New System.Drawing.Point(30, 70)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(406, 170)
        Me.GroupBox.TabIndex = 26
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "MODIFICAR DATOS"
        Me.GroupBox.Visible = False
        '
        'lblcolor
        '
        Me.lblcolor.AutoSize = True
        Me.lblcolor.Location = New System.Drawing.Point(73, 102)
        Me.lblcolor.Name = "lblcolor"
        Me.lblcolor.Size = New System.Drawing.Size(0, 13)
        Me.lblcolor.TabIndex = 35
        '
        'lblespecial
        '
        Me.lblespecial.AutoSize = True
        Me.lblespecial.Location = New System.Drawing.Point(76, 66)
        Me.lblespecial.Name = "lblespecial"
        Me.lblespecial.Size = New System.Drawing.Size(0, 13)
        Me.lblespecial.TabIndex = 34
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(79, 131)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(114, 20)
        Me.txtdescripcion.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Descripcion:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Color:"
        '
        'Btnguardar
        '
        Me.Btnguardar.Location = New System.Drawing.Point(281, 49)
        Me.Btnguardar.Name = "Btnguardar"
        Me.Btnguardar.Size = New System.Drawing.Size(100, 36)
        Me.Btnguardar.TabIndex = 5
        Me.Btnguardar.Text = "Guardar"
        Me.Btnguardar.UseVisualStyleBackColor = True
        '
        'lblempleado
        '
        Me.lblempleado.AutoSize = True
        Me.lblempleado.Location = New System.Drawing.Point(135, 37)
        Me.lblempleado.Name = "lblempleado"
        Me.lblempleado.Size = New System.Drawing.Size(0, 13)
        Me.lblempleado.TabIndex = 2
        '
        'txttipo
        '
        Me.txttipo.Location = New System.Drawing.Point(82, 34)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.Size = New System.Drawing.Size(142, 20)
        Me.txttipo.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Especial:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tipo:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(294, 72)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(0, 0)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Guardar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Btnregresar
        '
        Me.Btnregresar.Location = New System.Drawing.Point(173, 256)
        Me.Btnregresar.Name = "Btnregresar"
        Me.Btnregresar.Size = New System.Drawing.Size(110, 36)
        Me.Btnregresar.TabIndex = 27
        Me.Btnregresar.Text = "Regresar"
        Me.Btnregresar.UseVisualStyleBackColor = True
        '
        'Btnbuscar
        '
        Me.Btnbuscar.Location = New System.Drawing.Point(311, 18)
        Me.Btnbuscar.Name = "Btnbuscar"
        Me.Btnbuscar.Size = New System.Drawing.Size(110, 36)
        Me.Btnbuscar.TabIndex = 25
        Me.Btnbuscar.Text = "Buscar"
        Me.Btnbuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "ID Concepto:"
        '
        'Modificar_Concepto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 305)
        Me.ControlBox = False
        Me.Controls.Add(Me.Txtid)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.Btnregresar)
        Me.Controls.Add(Me.Btnbuscar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Modificar_Concepto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar_Concepto"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtid As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Btnguardar As System.Windows.Forms.Button
    Friend WithEvents lblempleado As System.Windows.Forms.Label
    Friend WithEvents txttipo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Btnregresar As System.Windows.Forms.Button
    Friend WithEvents Btnbuscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblcolor As System.Windows.Forms.Label
    Friend WithEvents lblespecial As System.Windows.Forms.Label
End Class
