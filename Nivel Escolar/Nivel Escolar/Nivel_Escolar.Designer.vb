<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nivel_Escolar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nivel_Escolar))
        Me.txtprimero = New System.Windows.Forms.TextBox()
        Me.Btn_Acción = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.apa_desapa = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtprimero
        '
        Me.txtprimero.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtprimero.Location = New System.Drawing.Point(276, 91)
        Me.txtprimero.Name = "txtprimero"
        Me.txtprimero.Size = New System.Drawing.Size(100, 26)
        Me.txtprimero.TabIndex = 0
        '
        'Btn_Acción
        '
        Me.Btn_Acción.AutoSize = True
        Me.Btn_Acción.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btn_Acción.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Acción.Location = New System.Drawing.Point(190, 279)
        Me.Btn_Acción.Name = "Btn_Acción"
        Me.Btn_Acción.Size = New System.Drawing.Size(104, 34)
        Me.Btn_Acción.TabIndex = 37
        Me.Btn_Acción.Text = "&Acción"
        Me.Btn_Acción.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(111, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 23)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Escribe tu edad:"
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.AutoSize = True
        Me.Btn_Limpiar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btn_Limpiar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Limpiar.Location = New System.Drawing.Point(372, 279)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(104, 34)
        Me.Btn_Limpiar.TabIndex = 38
        Me.Btn_Limpiar.Text = "&Limpiar"
        Me.Btn_Limpiar.UseVisualStyleBackColor = False
        '
        'Btn_Salir
        '
        Me.Btn_Salir.AutoSize = True
        Me.Btn_Salir.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btn_Salir.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Salir.Location = New System.Drawing.Point(12, 279)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(104, 34)
        Me.Btn_Salir.TabIndex = 36
        Me.Btn_Salir.Text = "&Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(115, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(256, 34)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Encuentra tu nivel."
        '
        'apa_desapa
        '
        Me.apa_desapa.AutoSize = True
        Me.apa_desapa.BackColor = System.Drawing.Color.CornflowerBlue
        Me.apa_desapa.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apa_desapa.Location = New System.Drawing.Point(98, 157)
        Me.apa_desapa.Name = "apa_desapa"
        Me.apa_desapa.Size = New System.Drawing.Size(221, 23)
        Me.apa_desapa.TabIndex = 42
        Me.apa_desapa.Text = "Aparezco deaparezco"
        Me.apa_desapa.Visible = False
        '
        'Nivel_Escolar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(488, 325)
        Me.Controls.Add(Me.apa_desapa)
        Me.Controls.Add(Me.txtprimero)
        Me.Controls.Add(Me.Btn_Acción)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_Limpiar)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Label5)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Nivel_Escolar"
        Me.Text = "Nivel Escolar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtprimero As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Acción As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents apa_desapa As System.Windows.Forms.Label

End Class
