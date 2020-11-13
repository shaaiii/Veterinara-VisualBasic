<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AltaPersona
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TitleAltaPersona = New System.Windows.Forms.Label()
        Me.NombrePersonaText = New System.Windows.Forms.Label()
        Me.NombrePersonaInput = New System.Windows.Forms.TextBox()
        Me.CIPersonaInput = New System.Windows.Forms.TextBox()
        Me.DireccionPersonaInput = New System.Windows.Forms.TextBox()
        Me.CIPersonaText = New System.Windows.Forms.Label()
        Me.DireccionPersonaText = New System.Windows.Forms.Label()
        Me.AceptarPersonaBtn = New System.Windows.Forms.Button()
        Me.CancelarPersonabtn = New System.Windows.Forms.Button()
        Me.TelefonoPersonaInput = New System.Windows.Forms.TextBox()
        Me.TelefonoPersonaText = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lv_telefono = New System.Windows.Forms.ListView()
        Me.ModificarPersona = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TitleAltaPersona
        '
        Me.TitleAltaPersona.AutoSize = True
        Me.TitleAltaPersona.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleAltaPersona.ForeColor = System.Drawing.SystemColors.MenuText
        Me.TitleAltaPersona.Location = New System.Drawing.Point(89, 20)
        Me.TitleAltaPersona.Name = "TitleAltaPersona"
        Me.TitleAltaPersona.Size = New System.Drawing.Size(193, 36)
        Me.TitleAltaPersona.TabIndex = 0
        Me.TitleAltaPersona.Text = "Alta Persona"
        '
        'NombrePersonaText
        '
        Me.NombrePersonaText.AutoSize = True
        Me.NombrePersonaText.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombrePersonaText.Location = New System.Drawing.Point(27, 115)
        Me.NombrePersonaText.Name = "NombrePersonaText"
        Me.NombrePersonaText.Size = New System.Drawing.Size(54, 16)
        Me.NombrePersonaText.TabIndex = 1
        Me.NombrePersonaText.Text = "Nombre:"
        '
        'NombrePersonaInput
        '
        Me.NombrePersonaInput.Location = New System.Drawing.Point(87, 113)
        Me.NombrePersonaInput.Name = "NombrePersonaInput"
        Me.NombrePersonaInput.Size = New System.Drawing.Size(194, 20)
        Me.NombrePersonaInput.TabIndex = 2
        '
        'CIPersonaInput
        '
        Me.CIPersonaInput.Location = New System.Drawing.Point(88, 83)
        Me.CIPersonaInput.Name = "CIPersonaInput"
        Me.CIPersonaInput.Size = New System.Drawing.Size(194, 20)
        Me.CIPersonaInput.TabIndex = 3
        '
        'DireccionPersonaInput
        '
        Me.DireccionPersonaInput.Location = New System.Drawing.Point(88, 151)
        Me.DireccionPersonaInput.Name = "DireccionPersonaInput"
        Me.DireccionPersonaInput.Size = New System.Drawing.Size(194, 20)
        Me.DireccionPersonaInput.TabIndex = 4
        '
        'CIPersonaText
        '
        Me.CIPersonaText.AutoSize = True
        Me.CIPersonaText.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CIPersonaText.Location = New System.Drawing.Point(27, 84)
        Me.CIPersonaText.Name = "CIPersonaText"
        Me.CIPersonaText.Size = New System.Drawing.Size(23, 16)
        Me.CIPersonaText.TabIndex = 5
        Me.CIPersonaText.Text = "CI:"
        '
        'DireccionPersonaText
        '
        Me.DireccionPersonaText.AutoSize = True
        Me.DireccionPersonaText.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionPersonaText.Location = New System.Drawing.Point(27, 153)
        Me.DireccionPersonaText.Name = "DireccionPersonaText"
        Me.DireccionPersonaText.Size = New System.Drawing.Size(61, 16)
        Me.DireccionPersonaText.TabIndex = 6
        Me.DireccionPersonaText.Text = "Direccion:"
        '
        'AceptarPersonaBtn
        '
        Me.AceptarPersonaBtn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AceptarPersonaBtn.Location = New System.Drawing.Point(288, 366)
        Me.AceptarPersonaBtn.Name = "AceptarPersonaBtn"
        Me.AceptarPersonaBtn.Size = New System.Drawing.Size(102, 27)
        Me.AceptarPersonaBtn.TabIndex = 7
        Me.AceptarPersonaBtn.Text = "Aceptar"
        Me.AceptarPersonaBtn.UseVisualStyleBackColor = True
        '
        'CancelarPersonabtn
        '
        Me.CancelarPersonabtn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelarPersonabtn.Location = New System.Drawing.Point(12, 368)
        Me.CancelarPersonabtn.Name = "CancelarPersonabtn"
        Me.CancelarPersonabtn.Size = New System.Drawing.Size(101, 27)
        Me.CancelarPersonabtn.TabIndex = 8
        Me.CancelarPersonabtn.Text = "Limpiar"
        Me.CancelarPersonabtn.UseVisualStyleBackColor = True
        '
        'TelefonoPersonaInput
        '
        Me.TelefonoPersonaInput.Location = New System.Drawing.Point(88, 192)
        Me.TelefonoPersonaInput.Name = "TelefonoPersonaInput"
        Me.TelefonoPersonaInput.Size = New System.Drawing.Size(194, 20)
        Me.TelefonoPersonaInput.TabIndex = 9
        '
        'TelefonoPersonaText
        '
        Me.TelefonoPersonaText.AutoSize = True
        Me.TelefonoPersonaText.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoPersonaText.Location = New System.Drawing.Point(30, 195)
        Me.TelefonoPersonaText.Name = "TelefonoPersonaText"
        Me.TelefonoPersonaText.Size = New System.Drawing.Size(56, 16)
        Me.TelefonoPersonaText.TabIndex = 10
        Me.TelefonoPersonaText.Text = "Telefono:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(288, 189)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(18, 24)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lv_telefono
        '
        Me.lv_telefono.HideSelection = False
        Me.lv_telefono.Location = New System.Drawing.Point(88, 230)
        Me.lv_telefono.Name = "lv_telefono"
        Me.lv_telefono.Size = New System.Drawing.Size(194, 109)
        Me.lv_telefono.TabIndex = 12
        Me.lv_telefono.UseCompatibleStateImageBehavior = False
        Me.lv_telefono.View = System.Windows.Forms.View.List
        '
        'ModificarPersona
        '
        Me.ModificarPersona.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModificarPersona.Location = New System.Drawing.Point(158, 369)
        Me.ModificarPersona.Name = "ModificarPersona"
        Me.ModificarPersona.Size = New System.Drawing.Size(91, 24)
        Me.ModificarPersona.TabIndex = 13
        Me.ModificarPersona.Text = "Modificar"
        Me.ModificarPersona.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(308, 81)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 22)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Buscar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'AltaPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 422)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ModificarPersona)
        Me.Controls.Add(Me.lv_telefono)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TelefonoPersonaText)
        Me.Controls.Add(Me.TelefonoPersonaInput)
        Me.Controls.Add(Me.CancelarPersonabtn)
        Me.Controls.Add(Me.AceptarPersonaBtn)
        Me.Controls.Add(Me.DireccionPersonaText)
        Me.Controls.Add(Me.CIPersonaText)
        Me.Controls.Add(Me.DireccionPersonaInput)
        Me.Controls.Add(Me.CIPersonaInput)
        Me.Controls.Add(Me.NombrePersonaInput)
        Me.Controls.Add(Me.NombrePersonaText)
        Me.Controls.Add(Me.TitleAltaPersona)
        Me.Name = "AltaPersona"
        Me.Text = "Alta Persona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleAltaPersona As Label
    Friend WithEvents NombrePersonaText As Label
    Friend WithEvents NombrePersonaInput As TextBox
    Friend WithEvents CIPersonaInput As TextBox
    Friend WithEvents DireccionPersonaInput As TextBox
    Friend WithEvents CIPersonaText As Label
    Friend WithEvents DireccionPersonaText As Label
    Friend WithEvents AceptarPersonaBtn As Button
    Friend WithEvents CancelarPersonabtn As Button
    Friend WithEvents TelefonoPersonaInput As TextBox
    Friend WithEvents TelefonoPersonaText As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lv_telefono As ListView
    Friend WithEvents ModificarPersona As Button
    Friend WithEvents Button3 As Button
End Class
