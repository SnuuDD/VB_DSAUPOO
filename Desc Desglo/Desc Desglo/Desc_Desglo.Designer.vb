<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Desc_Desglo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Desc_Desglo))
        Me.txtprimero = New System.Windows.Forms.TextBox()
        Me.Btn_Calcula = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtsegundo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtdesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Lbldosproductos = New System.Windows.Forms.Label()
        Me.Lbldesc = New System.Windows.Forms.Label()
        Me.Lbltotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtprimero
        '
        Me.txtprimero.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtprimero.Location = New System.Drawing.Point(405, 83)
        Me.txtprimero.Name = "txtprimero"
        Me.txtprimero.Size = New System.Drawing.Size(100, 26)
        Me.txtprimero.TabIndex = 24
        '
        'Btn_Calcula
        '
        Me.Btn_Calcula.AutoSize = True
        Me.Btn_Calcula.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btn_Calcula.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Calcula.Location = New System.Drawing.Point(228, 326)
        Me.Btn_Calcula.Name = "Btn_Calcula"
        Me.Btn_Calcula.Size = New System.Drawing.Size(104, 34)
        Me.Btn_Calcula.TabIndex = 23
        Me.Btn_Calcula.Text = "&Calcular"
        Me.Btn_Calcula.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(360, 23)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Ingresa el precio del primer producto:"
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.AutoSize = True
        Me.Btn_Limpiar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btn_Limpiar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Limpiar.Location = New System.Drawing.Point(24, 326)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(104, 34)
        Me.Btn_Limpiar.TabIndex = 21
        Me.Btn_Limpiar.Text = "&Limpiar"
        Me.Btn_Limpiar.UseVisualStyleBackColor = False
        '
        'Btn_Salir
        '
        Me.Btn_Salir.AutoSize = True
        Me.Btn_Salir.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Btn_Salir.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Salir.Location = New System.Drawing.Point(424, 326)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(104, 34)
        Me.Btn_Salir.TabIndex = 20
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
        Me.Label5.Location = New System.Drawing.Point(47, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(450, 34)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Total con descuento desglosado."
        '
        'Txtsegundo
        '
        Me.Txtsegundo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Txtsegundo.Location = New System.Drawing.Point(405, 117)
        Me.Txtsegundo.Name = "Txtsegundo"
        Me.Txtsegundo.Size = New System.Drawing.Size(100, 26)
        Me.Txtsegundo.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 23)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Ingresa el precio del segundo producto:"
        '
        'Txtdesc
        '
        Me.Txtdesc.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Txtdesc.Location = New System.Drawing.Point(405, 160)
        Me.Txtdesc.Name = "Txtdesc"
        Me.Txtdesc.Size = New System.Drawing.Size(100, 26)
        Me.Txtdesc.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(318, 23)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Ingresa el descuento en decimal:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(260, 23)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Total del los dos productos:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(220, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 23)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Descuento:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(192, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 23)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Total a pagar:"
        '
        'Lbldosproductos
        '
        Me.Lbldosproductos.AutoSize = True
        Me.Lbldosproductos.BackColor = System.Drawing.Color.Transparent
        Me.Lbldosproductos.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbldosproductos.Location = New System.Drawing.Point(338, 198)
        Me.Lbldosproductos.Name = "Lbldosproductos"
        Me.Lbldosproductos.Size = New System.Drawing.Size(0, 23)
        Me.Lbldosproductos.TabIndex = 32
        '
        'Lbldesc
        '
        Me.Lbldesc.AutoSize = True
        Me.Lbldesc.BackColor = System.Drawing.Color.Transparent
        Me.Lbldesc.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbldesc.Location = New System.Drawing.Point(338, 231)
        Me.Lbldesc.Name = "Lbldesc"
        Me.Lbldesc.Size = New System.Drawing.Size(0, 23)
        Me.Lbldesc.TabIndex = 33
        '
        'Lbltotal
        '
        Me.Lbltotal.AutoSize = True
        Me.Lbltotal.BackColor = System.Drawing.Color.Transparent
        Me.Lbltotal.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltotal.Location = New System.Drawing.Point(338, 264)
        Me.Lbltotal.Name = "Lbltotal"
        Me.Lbltotal.Size = New System.Drawing.Size(0, 23)
        Me.Lbltotal.TabIndex = 34
        '
        'Desc_Desglo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(552, 372)
        Me.Controls.Add(Me.Lbltotal)
        Me.Controls.Add(Me.Lbldesc)
        Me.Controls.Add(Me.Lbldosproductos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txtdesc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txtsegundo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtprimero)
        Me.Controls.Add(Me.Btn_Calcula)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_Limpiar)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Label5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Desc_Desglo"
        Me.Text = "Descuento Desglosado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtprimero As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Calcula As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txtsegundo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Lbldosproductos As System.Windows.Forms.Label
    Friend WithEvents Lbldesc As System.Windows.Forms.Label
    Friend WithEvents Lbltotal As System.Windows.Forms.Label

End Class
