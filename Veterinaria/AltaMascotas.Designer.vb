<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaMascotas
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
        Me.AltaMascota = New System.Windows.Forms.Label()
        Me.NombreMascotaText = New System.Windows.Forms.Label()
        Me.NombreMascotaInput = New System.Windows.Forms.TextBox()
        Me.CIDueñoInput = New System.Windows.Forms.TextBox()
        Me.CIDueñoText = New System.Windows.Forms.Label()
        Me.AñoNacimientoText = New System.Windows.Forms.Label()
        Me.AñoNacimientoInput = New System.Windows.Forms.TextBox()
        Me.AceptarMascotabtn = New System.Windows.Forms.Button()
        Me.CancelarMascotabtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'AltaMascota
        '
        Me.AltaMascota.AutoSize = True
        Me.AltaMascota.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AltaMascota.Location = New System.Drawing.Point(12, 18)
        Me.AltaMascota.Name = "AltaMascota"
        Me.AltaMascota.Size = New System.Drawing.Size(236, 38)
        Me.AltaMascota.TabIndex = 0
        Me.AltaMascota.Text = "ALTA MASCOTA"
        '
        'NombreMascotaText
        '
        Me.NombreMascotaText.AutoSize = True
        Me.NombreMascotaText.Location = New System.Drawing.Point(16, 79)
        Me.NombreMascotaText.Name = "NombreMascotaText"
        Me.NombreMascotaText.Size = New System.Drawing.Size(47, 13)
        Me.NombreMascotaText.TabIndex = 1
        Me.NombreMascotaText.Text = "Nombre:"
        '
        'NombreMascotaInput
        '
        Me.NombreMascotaInput.Location = New System.Drawing.Point(69, 76)
        Me.NombreMascotaInput.Name = "NombreMascotaInput"
        Me.NombreMascotaInput.Size = New System.Drawing.Size(202, 20)
        Me.NombreMascotaInput.TabIndex = 2
        '
        'CIDueñoInput
        '
        Me.CIDueñoInput.Location = New System.Drawing.Point(97, 156)
        Me.CIDueñoInput.Name = "CIDueñoInput"
        Me.CIDueñoInput.Size = New System.Drawing.Size(174, 20)
        Me.CIDueñoInput.TabIndex = 3
        '
        'CIDueñoText
        '
        Me.CIDueñoText.AutoSize = True
        Me.CIDueñoText.Location = New System.Drawing.Point(16, 159)
        Me.CIDueñoText.Name = "CIDueñoText"
        Me.CIDueñoText.Size = New System.Drawing.Size(75, 13)
        Me.CIDueñoText.TabIndex = 4
        Me.CIDueñoText.Text = "C.I del Dueño:"
        '
        'AñoNacimientoText
        '
        Me.AñoNacimientoText.AutoSize = True
        Me.AñoNacimientoText.Location = New System.Drawing.Point(16, 119)
        Me.AñoNacimientoText.Name = "AñoNacimientoText"
        Me.AñoNacimientoText.Size = New System.Drawing.Size(100, 13)
        Me.AñoNacimientoText.TabIndex = 5
        Me.AñoNacimientoText.Text = "Año de Nacimiento:"
        '
        'AñoNacimientoInput
        '
        Me.AñoNacimientoInput.Location = New System.Drawing.Point(121, 116)
        Me.AñoNacimientoInput.Name = "AñoNacimientoInput"
        Me.AñoNacimientoInput.Size = New System.Drawing.Size(150, 20)
        Me.AñoNacimientoInput.TabIndex = 6
        '
        'AceptarMascotabtn
        '
        Me.AceptarMascotabtn.Location = New System.Drawing.Point(184, 330)
        Me.AceptarMascotabtn.Name = "AceptarMascotabtn"
        Me.AceptarMascotabtn.Size = New System.Drawing.Size(87, 21)
        Me.AceptarMascotabtn.TabIndex = 7
        Me.AceptarMascotabtn.Text = "Aceptar"
        Me.AceptarMascotabtn.UseVisualStyleBackColor = True
        '
        'CancelarMascotabtn
        '
        Me.CancelarMascotabtn.Location = New System.Drawing.Point(19, 330)
        Me.CancelarMascotabtn.Name = "CancelarMascotabtn"
        Me.CancelarMascotabtn.Size = New System.Drawing.Size(86, 22)
        Me.CancelarMascotabtn.TabIndex = 8
        Me.CancelarMascotabtn.Text = "Cancelar"
        Me.CancelarMascotabtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ID:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(68, 198)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(203, 20)
        Me.TextBox1.TabIndex = 10
        '
        'AltaMascotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 367)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CancelarMascotabtn)
        Me.Controls.Add(Me.AceptarMascotabtn)
        Me.Controls.Add(Me.AñoNacimientoInput)
        Me.Controls.Add(Me.AñoNacimientoText)
        Me.Controls.Add(Me.CIDueñoText)
        Me.Controls.Add(Me.CIDueñoInput)
        Me.Controls.Add(Me.NombreMascotaInput)
        Me.Controls.Add(Me.NombreMascotaText)
        Me.Controls.Add(Me.AltaMascota)
        Me.Name = "AltaMascotas"
        Me.Text = "Alta Mascota"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AltaMascota As Label
    Friend WithEvents NombreMascotaText As Label
    Friend WithEvents NombreMascotaInput As TextBox
    Friend WithEvents CIDueñoInput As TextBox
    Friend WithEvents CIDueñoText As Label
    Friend WithEvents AñoNacimientoText As Label
    Friend WithEvents AñoNacimientoInput As TextBox
    Friend WithEvents AceptarMascotabtn As Button
    Friend WithEvents CancelarMascotabtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
