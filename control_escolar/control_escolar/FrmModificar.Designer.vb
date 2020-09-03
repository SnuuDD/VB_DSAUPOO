<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPrimerN = New System.Windows.Forms.TextBox()
        Me.TxtSegundoN = New System.Windows.Forms.TextBox()
        Me.TxtAPaterno = New System.Windows.Forms.TextBox()
        Me.TxtAMaterno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblControl = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ESCRIBE EL NOMBRE COMPLETO DEL ALUMNO:"
        '
        'TxtPrimerN
        '
        Me.TxtPrimerN.Location = New System.Drawing.Point(35, 39)
        Me.TxtPrimerN.Name = "TxtPrimerN"
        Me.TxtPrimerN.Size = New System.Drawing.Size(100, 20)
        Me.TxtPrimerN.TabIndex = 1
        '
        'TxtSegundoN
        '
        Me.TxtSegundoN.Location = New System.Drawing.Point(153, 39)
        Me.TxtSegundoN.Name = "TxtSegundoN"
        Me.TxtSegundoN.Size = New System.Drawing.Size(100, 20)
        Me.TxtSegundoN.TabIndex = 2
        '
        'TxtAPaterno
        '
        Me.TxtAPaterno.Location = New System.Drawing.Point(272, 39)
        Me.TxtAPaterno.Name = "TxtAPaterno"
        Me.TxtAPaterno.Size = New System.Drawing.Size(100, 20)
        Me.TxtAPaterno.TabIndex = 3
        '
        'TxtAMaterno
        '
        Me.TxtAMaterno.Location = New System.Drawing.Point(389, 39)
        Me.TxtAMaterno.Name = "TxtAMaterno"
        Me.TxtAMaterno.Size = New System.Drawing.Size(100, 20)
        Me.TxtAMaterno.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(386, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "APELLIDO MATERNO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(269, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "APELLIDO PATERNO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(150, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "SEGUNDO NOMBRE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "PRIMER NOMBRE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "NUMERO DE CONTROL"
        '
        'LblControl
        '
        Me.LblControl.AutoSize = True
        Me.LblControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblControl.Location = New System.Drawing.Point(186, 119)
        Me.LblControl.Name = "LblControl"
        Me.LblControl.Size = New System.Drawing.Size(0, 15)
        Me.LblControl.TabIndex = 10
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(308, 198)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 11
        Me.BtnGuardar.Text = "&GUARDAR"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(77, 198)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegresar.TabIndex = 12
        Me.BtnRegresar.Text = "&REGRESAR"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(524, 36)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 13
        Me.BtnBuscar.Text = "&BUSCAR"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'FrmModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(611, 262)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.LblControl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtAMaterno)
        Me.Controls.Add(Me.TxtAPaterno)
        Me.Controls.Add(Me.TxtSegundoN)
        Me.Controls.Add(Me.TxtPrimerN)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmModificar"
        Me.Text = "FrmModificar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtPrimerN As System.Windows.Forms.TextBox
    Friend WithEvents TxtSegundoN As System.Windows.Forms.TextBox
    Friend WithEvents TxtAPaterno As System.Windows.Forms.TextBox
    Friend WithEvents TxtAMaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblControl As System.Windows.Forms.Label
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnRegresar As System.Windows.Forms.Button
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
End Class
