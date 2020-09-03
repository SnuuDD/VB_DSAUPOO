<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ticket
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
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnTicket = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblSub = New System.Windows.Forms.Label()
        Me.TxtCambio = New System.Windows.Forms.TextBox()
        Me.TxtEfectivo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(31, 155)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegresar.TabIndex = 21
        Me.BtnRegresar.Text = "&REGRESAR"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'BtnTicket
        '
        Me.BtnTicket.Location = New System.Drawing.Point(171, 155)
        Me.BtnTicket.Name = "BtnTicket"
        Me.BtnTicket.Size = New System.Drawing.Size(75, 23)
        Me.BtnTicket.TabIndex = 20
        Me.BtnTicket.Text = "&TICKET"
        Me.BtnTicket.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LblTotal)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.LblSub)
        Me.Panel1.Controls.Add(Me.TxtCambio)
        Me.Panel1.Controls.Add(Me.TxtEfectivo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(31, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 121)
        Me.Panel1.TabIndex = 19
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(97, 36)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(0, 13)
        Me.LblTotal.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "SUBTOTAL"
        '
        'LblSub
        '
        Me.LblSub.AutoSize = True
        Me.LblSub.Location = New System.Drawing.Point(97, 10)
        Me.LblSub.Name = "LblSub"
        Me.LblSub.Size = New System.Drawing.Size(0, 13)
        Me.LblSub.TabIndex = 6
        '
        'TxtCambio
        '
        Me.TxtCambio.Location = New System.Drawing.Point(100, 84)
        Me.TxtCambio.Name = "TxtCambio"
        Me.TxtCambio.Size = New System.Drawing.Size(100, 20)
        Me.TxtCambio.TabIndex = 5
        '
        'TxtEfectivo
        '
        Me.TxtEfectivo.Location = New System.Drawing.Point(100, 57)
        Me.TxtEfectivo.Name = "TxtEfectivo"
        Me.TxtEfectivo.Size = New System.Drawing.Size(100, 20)
        Me.TxtEfectivo.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CAMBIO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "EFECTIVO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TOTAL:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 187)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnTicket)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnRegresar As System.Windows.Forms.Button
    Friend WithEvents BtnTicket As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblSub As System.Windows.Forms.Label
    Friend WithEvents TxtCambio As System.Windows.Forms.TextBox
    Friend WithEvents TxtEfectivo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
