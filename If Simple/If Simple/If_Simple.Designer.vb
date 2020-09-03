<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class If_Simple
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(If_Simple))
        Me.Txtdesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_Calcula = New System.Windows.Forms.Button()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Txtdesc
        '
        Me.Txtdesc.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Txtdesc.Location = New System.Drawing.Point(249, 56)
        Me.Txtdesc.Name = "Txtdesc"
        Me.Txtdesc.Size = New System.Drawing.Size(100, 26)
        Me.Txtdesc.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 23)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Ingresa un Numero"
        '
        'Btn_Calcula
        '
        Me.Btn_Calcula.AutoSize = True
        Me.Btn_Calcula.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btn_Calcula.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Calcula.Location = New System.Drawing.Point(175, 159)
        Me.Btn_Calcula.Name = "Btn_Calcula"
        Me.Btn_Calcula.Size = New System.Drawing.Size(104, 34)
        Me.Btn_Calcula.TabIndex = 37
        Me.Btn_Calcula.Text = "&Calcular"
        Me.Btn_Calcula.UseVisualStyleBackColor = False
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.AutoSize = True
        Me.Btn_Limpiar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btn_Limpiar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Limpiar.Location = New System.Drawing.Point(27, 159)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(104, 34)
        Me.Btn_Limpiar.TabIndex = 36
        Me.Btn_Limpiar.Text = "&Limpiar"
        Me.Btn_Limpiar.UseVisualStyleBackColor = False
        '
        'Btn_Salir
        '
        Me.Btn_Salir.AutoSize = True
        Me.Btn_Salir.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btn_Salir.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Salir.Location = New System.Drawing.Point(321, 159)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(104, 34)
        Me.Btn_Salir.TabIndex = 35
        Me.Btn_Salir.Text = "&Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = False
        '
        'If_Simple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(452, 205)
        Me.Controls.Add(Me.Txtdesc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Btn_Calcula)
        Me.Controls.Add(Me.Btn_Limpiar)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "If_Simple"
        Me.Text = "IF Simple"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Btn_Calcula As System.Windows.Forms.Button
    Friend WithEvents Btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button

End Class
