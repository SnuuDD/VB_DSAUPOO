<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmServicio_Bajas
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
        Me.btncanselar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.lbltratamiento = New System.Windows.Forms.Label()
        Me.i = New System.Windows.Forms.Label()
        Me.h = New System.Windows.Forms.Label()
        Me.g = New System.Windows.Forms.Label()
        Me.a = New System.Windows.Forms.Label()
        Me.b = New System.Windows.Forms.Label()
        Me.c = New System.Windows.Forms.Label()
        Me.d = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.f = New System.Windows.Forms.Label()
        Me.cboempleado = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboconcepto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbocliente = New System.Windows.Forms.ComboBox()
        Me.j = New System.Windows.Forms.Label()
        Me.z = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btncanselar
        '
        Me.btncanselar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncanselar.Location = New System.Drawing.Point(66, 578)
        Me.btncanselar.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btncanselar.Name = "btncanselar"
        Me.btncanselar.Size = New System.Drawing.Size(126, 37)
        Me.btncanselar.TabIndex = 5
        Me.btncanselar.Text = "Cancelar"
        Me.btncanselar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(406, 578)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 37)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "&Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(235, 578)
        Me.btneliminar.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(126, 37)
        Me.btneliminar.TabIndex = 6
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(447, 142)
        Me.btnbuscar.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(138, 35)
        Me.btnbuscar.TabIndex = 4
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'lbltratamiento
        '
        Me.lbltratamiento.AutoSize = True
        Me.lbltratamiento.Location = New System.Drawing.Point(275, 578)
        Me.lbltratamiento.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbltratamiento.Name = "lbltratamiento"
        Me.lbltratamiento.Size = New System.Drawing.Size(30, 23)
        Me.lbltratamiento.TabIndex = 35
        Me.lbltratamiento.Text = "    "
        Me.lbltratamiento.Visible = False
        '
        'i
        '
        Me.i.AutoSize = True
        Me.i.Location = New System.Drawing.Point(289, 455)
        Me.i.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.i.Name = "i"
        Me.i.Size = New System.Drawing.Size(30, 23)
        Me.i.TabIndex = 34
        Me.i.Text = "    "
        Me.i.Visible = False
        '
        'h
        '
        Me.h.AutoSize = True
        Me.h.Location = New System.Drawing.Point(289, 391)
        Me.h.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.h.Name = "h"
        Me.h.Size = New System.Drawing.Size(30, 23)
        Me.h.TabIndex = 33
        Me.h.Text = "    "
        Me.h.Visible = False
        '
        'g
        '
        Me.g.AutoSize = True
        Me.g.Location = New System.Drawing.Point(289, 317)
        Me.g.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.g.Name = "g"
        Me.g.Size = New System.Drawing.Size(30, 23)
        Me.g.TabIndex = 32
        Me.g.Text = "    "
        Me.g.Visible = False
        '
        'a
        '
        Me.a.AutoSize = True
        Me.a.Location = New System.Drawing.Point(48, 251)
        Me.a.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(52, 23)
        Me.a.TabIndex = 31
        Me.a.Text = "Kilos"
        Me.a.Visible = False
        '
        'b
        '
        Me.b.AutoSize = True
        Me.b.Location = New System.Drawing.Point(41, 320)
        Me.b.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(81, 23)
        Me.b.TabIndex = 30
        Me.b.Text = "Entrega"
        Me.b.Visible = False
        '
        'c
        '
        Me.c.AutoSize = True
        Me.c.Location = New System.Drawing.Point(41, 386)
        Me.c.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(117, 23)
        Me.c.TabIndex = 29
        Me.c.Text = "Precio Total"
        Me.c.Visible = False
        '
        'd
        '
        Me.d.AutoSize = True
        Me.d.Location = New System.Drawing.Point(41, 446)
        Me.d.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(59, 23)
        Me.d.TabIndex = 28
        Me.d.Text = "Pagó"
        Me.d.Visible = False
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(295, 197)
        Me.lblfecha.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(0, 23)
        Me.lblfecha.TabIndex = 25
        '
        'f
        '
        Me.f.AutoSize = True
        Me.f.Location = New System.Drawing.Point(289, 251)
        Me.f.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.f.Name = "f"
        Me.f.Size = New System.Drawing.Size(30, 23)
        Me.f.TabIndex = 24
        Me.f.Text = "    "
        Me.f.Visible = False
        '
        'cboempleado
        '
        Me.cboempleado.FormattingEnabled = True
        Me.cboempleado.Location = New System.Drawing.Point(196, 142)
        Me.cboempleado.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.cboempleado.Name = "cboempleado"
        Me.cboempleado.Size = New System.Drawing.Size(219, 31)
        Me.cboempleado.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 142)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 23)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Empleado"
        '
        'cboconcepto
        '
        Me.cboconcepto.FormattingEnabled = True
        Me.cboconcepto.Location = New System.Drawing.Point(196, 92)
        Me.cboconcepto.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.cboconcepto.Name = "cboconcepto"
        Me.cboconcepto.Size = New System.Drawing.Size(219, 31)
        Me.cboconcepto.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 98)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 23)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Concepto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 192)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 23)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Cliente"
        '
        'cbocliente
        '
        Me.cbocliente.FormattingEnabled = True
        Me.cbocliente.Location = New System.Drawing.Point(196, 192)
        Me.cbocliente.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.cbocliente.Name = "cbocliente"
        Me.cbocliente.Size = New System.Drawing.Size(219, 31)
        Me.cbocliente.TabIndex = 3
        '
        'j
        '
        Me.j.AutoSize = True
        Me.j.Location = New System.Drawing.Point(289, 522)
        Me.j.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.j.Name = "j"
        Me.j.Size = New System.Drawing.Size(30, 23)
        Me.j.TabIndex = 43
        Me.j.Text = "    "
        Me.j.Visible = False
        '
        'z
        '
        Me.z.AutoSize = True
        Me.z.Location = New System.Drawing.Point(41, 513)
        Me.z.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.z.Name = "z"
        Me.z.Size = New System.Drawing.Size(174, 23)
        Me.z.TabIndex = 42
        Me.z.Text = "Direccion Entrega"
        Me.z.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(123, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(317, 23)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "AGREGA EL SERVICIO A ELIMINAR "
        '
        'FrmServicio_Bajas
        '
        Me.AcceptButton = Me.btnbuscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.CancelButton = Me.btncanselar
        Me.ClientSize = New System.Drawing.Size(600, 650)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.j)
        Me.Controls.Add(Me.z)
        Me.Controls.Add(Me.cbocliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btncanselar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.lbltratamiento)
        Me.Controls.Add(Me.i)
        Me.Controls.Add(Me.h)
        Me.Controls.Add(Me.g)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.d)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.f)
        Me.Controls.Add(Me.cboempleado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboconcepto)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "FrmServicio_Bajas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "B A J A S   S E R V I C I O"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncanselar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents lbltratamiento As System.Windows.Forms.Label
    Friend WithEvents i As System.Windows.Forms.Label
    Friend WithEvents h As System.Windows.Forms.Label
    Friend WithEvents g As System.Windows.Forms.Label
    Friend WithEvents a As System.Windows.Forms.Label
    Friend WithEvents b As System.Windows.Forms.Label
    Friend WithEvents c As System.Windows.Forms.Label
    Friend WithEvents d As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents f As System.Windows.Forms.Label
    Friend WithEvents cboempleado As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboconcepto As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbocliente As System.Windows.Forms.ComboBox
    Friend WithEvents j As System.Windows.Forms.Label
    Friend WithEvents z As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
