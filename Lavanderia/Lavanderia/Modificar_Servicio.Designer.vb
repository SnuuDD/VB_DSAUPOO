<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Servicio
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
        Me.lblconcepto = New System.Windows.Forms.Label()
        Me.lblnempleado = New System.Windows.Forms.Label()
        Me.lblcliente = New System.Windows.Forms.Label()
        Me.lblpago = New System.Windows.Forms.Label()
        Me.lblentrega = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btnguardar = New System.Windows.Forms.Button()
        Me.lblempleado = New System.Windows.Forms.Label()
        Me.txttipo = New System.Windows.Forms.TextBox()
        Me.label34 = New System.Windows.Forms.Label()
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
        Me.Txtid.Location = New System.Drawing.Point(136, 17)
        Me.Txtid.Name = "Txtid"
        Me.Txtid.Size = New System.Drawing.Size(145, 20)
        Me.Txtid.TabIndex = 29
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.lblconcepto)
        Me.GroupBox.Controls.Add(Me.lblnempleado)
        Me.GroupBox.Controls.Add(Me.lblcliente)
        Me.GroupBox.Controls.Add(Me.lblpago)
        Me.GroupBox.Controls.Add(Me.lblentrega)
        Me.GroupBox.Controls.Add(Me.Label8)
        Me.GroupBox.Controls.Add(Me.Label7)
        Me.GroupBox.Controls.Add(Me.Label2)
        Me.GroupBox.Controls.Add(Me.txtprecio)
        Me.GroupBox.Controls.Add(Me.Label5)
        Me.GroupBox.Controls.Add(Me.Label6)
        Me.GroupBox.Controls.Add(Me.Btnguardar)
        Me.GroupBox.Controls.Add(Me.lblempleado)
        Me.GroupBox.Controls.Add(Me.txttipo)
        Me.GroupBox.Controls.Add(Me.label34)
        Me.GroupBox.Controls.Add(Me.Label3)
        Me.GroupBox.Controls.Add(Me.Button2)
        Me.GroupBox.Location = New System.Drawing.Point(28, 60)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(406, 251)
        Me.GroupBox.TabIndex = 31
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "MODIFICAR DATOS"
        Me.GroupBox.Visible = False
        '
        'lblconcepto
        '
        Me.lblconcepto.AutoSize = True
        Me.lblconcepto.Location = New System.Drawing.Point(100, 89)
        Me.lblconcepto.Name = "lblconcepto"
        Me.lblconcepto.Size = New System.Drawing.Size(0, 13)
        Me.lblconcepto.TabIndex = 36
        '
        'lblnempleado
        '
        Me.lblnempleado.AutoSize = True
        Me.lblnempleado.Location = New System.Drawing.Point(105, 60)
        Me.lblnempleado.Name = "lblnempleado"
        Me.lblnempleado.Size = New System.Drawing.Size(0, 13)
        Me.lblnempleado.TabIndex = 35
        '
        'lblcliente
        '
        Me.lblcliente.AutoSize = True
        Me.lblcliente.Location = New System.Drawing.Point(105, 27)
        Me.lblcliente.Name = "lblcliente"
        Me.lblcliente.Size = New System.Drawing.Size(0, 13)
        Me.lblcliente.TabIndex = 34
        '
        'lblpago
        '
        Me.lblpago.AutoSize = True
        Me.lblpago.Location = New System.Drawing.Point(81, 183)
        Me.lblpago.Name = "lblpago"
        Me.lblpago.Size = New System.Drawing.Size(0, 13)
        Me.lblpago.TabIndex = 33
        '
        'lblentrega
        '
        Me.lblentrega.AutoSize = True
        Me.lblentrega.Location = New System.Drawing.Point(81, 150)
        Me.lblentrega.Name = "lblentrega"
        Me.lblentrega.Size = New System.Drawing.Size(0, 13)
        Me.lblentrega.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "ID Cliente:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "ID Empleado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "ID Concepto:"
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(94, 212)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(114, 20)
        Me.txtprecio.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Precio Total:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Pagó:"
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
        Me.lblempleado.Location = New System.Drawing.Point(139, 108)
        Me.lblempleado.Name = "lblempleado"
        Me.lblempleado.Size = New System.Drawing.Size(0, 13)
        Me.lblempleado.TabIndex = 2
        '
        'txttipo
        '
        Me.txttipo.Location = New System.Drawing.Point(56, 112)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.Size = New System.Drawing.Size(142, 20)
        Me.txttipo.TabIndex = 3
        '
        'label34
        '
        Me.label34.AutoSize = True
        Me.label34.Location = New System.Drawing.Point(24, 150)
        Me.label34.Name = "label34"
        Me.label34.Size = New System.Drawing.Size(47, 13)
        Me.label34.TabIndex = 7
        Me.label34.Text = "Entrega:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Kilos:"
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
        Me.Btnregresar.Location = New System.Drawing.Point(171, 317)
        Me.Btnregresar.Name = "Btnregresar"
        Me.Btnregresar.Size = New System.Drawing.Size(110, 36)
        Me.Btnregresar.TabIndex = 32
        Me.Btnregresar.Text = "Regresar"
        Me.Btnregresar.UseVisualStyleBackColor = True
        '
        'Btnbuscar
        '
        Me.Btnbuscar.Location = New System.Drawing.Point(309, 8)
        Me.Btnbuscar.Name = "Btnbuscar"
        Me.Btnbuscar.Size = New System.Drawing.Size(110, 36)
        Me.Btnbuscar.TabIndex = 30
        Me.Btnbuscar.Text = "Buscar"
        Me.Btnbuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "ID Servicio:"
        '
        'Modificar_Servicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 362)
        Me.ControlBox = False
        Me.Controls.Add(Me.Txtid)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.Btnregresar)
        Me.Controls.Add(Me.Btnbuscar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Modificar_Servicio"
        Me.Text = "Modificar_Servicio"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtid As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents lblconcepto As System.Windows.Forms.Label
    Friend WithEvents lblnempleado As System.Windows.Forms.Label
    Friend WithEvents lblcliente As System.Windows.Forms.Label
    Friend WithEvents lblpago As System.Windows.Forms.Label
    Friend WithEvents lblentrega As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Btnguardar As System.Windows.Forms.Button
    Friend WithEvents lblempleado As System.Windows.Forms.Label
    Friend WithEvents txttipo As System.Windows.Forms.TextBox
    Friend WithEvents label34 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Btnregresar As System.Windows.Forms.Button
    Friend WithEvents Btnbuscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
