<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Empleados
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
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.txtsueldo = New System.Windows.Forms.TextBox()
        Me.txthorario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btnguardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblempleado = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Btnregresar = New System.Windows.Forms.Button()
        Me.Btnbuscar = New System.Windows.Forms.Button()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txtnombre
        '
        Me.Txtnombre.Location = New System.Drawing.Point(137, 29)
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(145, 20)
        Me.Txtnombre.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre del empleado:"
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.txtsueldo)
        Me.GroupBox.Controls.Add(Me.txthorario)
        Me.GroupBox.Controls.Add(Me.Label5)
        Me.GroupBox.Controls.Add(Me.Label6)
        Me.GroupBox.Controls.Add(Me.Btnguardar)
        Me.GroupBox.Controls.Add(Me.Label1)
        Me.GroupBox.Controls.Add(Me.lblempleado)
        Me.GroupBox.Controls.Add(Me.txttelefono)
        Me.GroupBox.Controls.Add(Me.txtdireccion)
        Me.GroupBox.Controls.Add(Me.Label4)
        Me.GroupBox.Controls.Add(Me.Label3)
        Me.GroupBox.Controls.Add(Me.Button2)
        Me.GroupBox.Location = New System.Drawing.Point(29, 72)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(406, 204)
        Me.GroupBox.TabIndex = 11
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "MODIFICAR DATOS"
        Me.GroupBox.Visible = False
        '
        'txtsueldo
        '
        Me.txtsueldo.Location = New System.Drawing.Point(79, 166)
        Me.txtsueldo.Name = "txtsueldo"
        Me.txtsueldo.Size = New System.Drawing.Size(114, 20)
        Me.txtsueldo.TabIndex = 10
        '
        'txthorario
        '
        Me.txthorario.Location = New System.Drawing.Point(79, 134)
        Me.txthorario.Name = "txthorario"
        Me.txthorario.Size = New System.Drawing.Size(114, 20)
        Me.txthorario.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Sueldo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Horario"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID Empleado:"
        '
        'lblempleado
        '
        Me.lblempleado.AutoSize = True
        Me.lblempleado.Location = New System.Drawing.Point(135, 37)
        Me.lblempleado.Name = "lblempleado"
        Me.lblempleado.Size = New System.Drawing.Size(0, 13)
        Me.lblempleado.TabIndex = 2
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(74, 101)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(134, 20)
        Me.txttelefono.TabIndex = 4
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(82, 69)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(142, 20)
        Me.txtdireccion.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Direccion:"
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
        Me.Btnregresar.Location = New System.Drawing.Point(172, 282)
        Me.Btnregresar.Name = "Btnregresar"
        Me.Btnregresar.Size = New System.Drawing.Size(110, 36)
        Me.Btnregresar.TabIndex = 12
        Me.Btnregresar.Text = "Regresar"
        Me.Btnregresar.UseVisualStyleBackColor = True
        '
        'Btnbuscar
        '
        Me.Btnbuscar.Location = New System.Drawing.Point(310, 20)
        Me.Btnbuscar.Name = "Btnbuscar"
        Me.Btnbuscar.Size = New System.Drawing.Size(110, 36)
        Me.Btnbuscar.TabIndex = 10
        Me.Btnbuscar.Text = "Buscar"
        Me.Btnbuscar.UseVisualStyleBackColor = True
        '
        'Modificar_Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 335)
        Me.ControlBox = False
        Me.Controls.Add(Me.Txtnombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.Btnregresar)
        Me.Controls.Add(Me.Btnbuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Modificar_Empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar_Empleados"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Btnguardar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblempleado As System.Windows.Forms.Label
    Friend WithEvents txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Btnregresar As System.Windows.Forms.Button
    Friend WithEvents Btnbuscar As System.Windows.Forms.Button
    Friend WithEvents txtsueldo As System.Windows.Forms.TextBox
    Friend WithEvents txthorario As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
