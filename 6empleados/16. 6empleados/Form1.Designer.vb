<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmemplados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmemplados))
        Me.lstnombre = New System.Windows.Forms.ListBox()
        Me.btncapturar = New System.Windows.Forms.Button()
        Me.lstsueldo = New System.Windows.Forms.ListBox()
        Me.lstsueldoaumentado = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstnombre
        '
        Me.lstnombre.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lstnombre.FormattingEnabled = True
        Me.lstnombre.ItemHeight = 23
        Me.lstnombre.Location = New System.Drawing.Point(18, 15)
        Me.lstnombre.Margin = New System.Windows.Forms.Padding(4)
        Me.lstnombre.Name = "lstnombre"
        Me.lstnombre.Size = New System.Drawing.Size(178, 142)
        Me.lstnombre.TabIndex = 0
        '
        'btncapturar
        '
        Me.btncapturar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btncapturar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btncapturar.Location = New System.Drawing.Point(222, 179)
        Me.btncapturar.Margin = New System.Windows.Forms.Padding(4)
        Me.btncapturar.Name = "btncapturar"
        Me.btncapturar.Size = New System.Drawing.Size(222, 32)
        Me.btncapturar.TabIndex = 1
        Me.btncapturar.Text = "&Agregar Empleado"
        Me.btncapturar.UseVisualStyleBackColor = False
        '
        'lstsueldo
        '
        Me.lstsueldo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lstsueldo.FormattingEnabled = True
        Me.lstsueldo.ItemHeight = 23
        Me.lstsueldo.Location = New System.Drawing.Point(236, 13)
        Me.lstsueldo.Margin = New System.Windows.Forms.Padding(4)
        Me.lstsueldo.Name = "lstsueldo"
        Me.lstsueldo.Size = New System.Drawing.Size(173, 142)
        Me.lstsueldo.TabIndex = 2
        '
        'lstsueldoaumentado
        '
        Me.lstsueldoaumentado.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lstsueldoaumentado.FormattingEnabled = True
        Me.lstsueldoaumentado.ItemHeight = 23
        Me.lstsueldoaumentado.Location = New System.Drawing.Point(460, 15)
        Me.lstsueldoaumentado.Margin = New System.Windows.Forms.Padding(4)
        Me.lstsueldoaumentado.Name = "lstsueldoaumentado"
        Me.lstsueldoaumentado.Size = New System.Drawing.Size(178, 142)
        Me.lstsueldoaumentado.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(222, 219)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(222, 32)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&Agregar Sueldo"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(222, 259)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(222, 32)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "&Eliminar Empleado"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(13, 263)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 32)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "&Limpiar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button4.Location = New System.Drawing.Point(544, 263)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(107, 32)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "&Salir"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'frmemplados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(664, 308)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstsueldoaumentado)
        Me.Controls.Add(Me.lstsueldo)
        Me.Controls.Add(Me.btncapturar)
        Me.Controls.Add(Me.lstnombre)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmemplados"
        Me.Text = "Empleados :v"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstnombre As System.Windows.Forms.ListBox
    Friend WithEvents btncapturar As System.Windows.Forms.Button
    Friend WithEvents lstsueldo As System.Windows.Forms.ListBox
    Friend WithEvents lstsueldoaumentado As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
