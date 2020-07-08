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
        Me.SuspendLayout()
        '
        'TitleAltaPersona
        '
        Me.TitleAltaPersona.AutoSize = True
        Me.TitleAltaPersona.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleAltaPersona.ForeColor = System.Drawing.SystemColors.MenuText
        Me.TitleAltaPersona.Location = New System.Drawing.Point(263, 61)
        Me.TitleAltaPersona.Name = "TitleAltaPersona"
        Me.TitleAltaPersona.Size = New System.Drawing.Size(243, 40)
        Me.TitleAltaPersona.TabIndex = 0
        Me.TitleAltaPersona.Text = "ALTA PERSONA"
        '
        'NombrePersonaText
        '
        Me.NombrePersonaText.AutoSize = True
        Me.NombrePersonaText.Location = New System.Drawing.Point(251, 139)
        Me.NombrePersonaText.Name = "NombrePersonaText"
        Me.NombrePersonaText.Size = New System.Drawing.Size(47, 13)
        Me.NombrePersonaText.TabIndex = 1
        Me.NombrePersonaText.Text = "Nombre:"
        '
        'NombrePersonaInput
        '
        Me.NombrePersonaInput.Location = New System.Drawing.Point(325, 132)
        Me.NombrePersonaInput.Name = "NombrePersonaInput"
        Me.NombrePersonaInput.Size = New System.Drawing.Size(194, 20)
        Me.NombrePersonaInput.TabIndex = 2
        '
        'CIPersonaInput
        '
        Me.CIPersonaInput.Location = New System.Drawing.Point(325, 158)
        Me.CIPersonaInput.Name = "CIPersonaInput"
        Me.CIPersonaInput.Size = New System.Drawing.Size(194, 20)
        Me.CIPersonaInput.TabIndex = 3
        '
        'DireccionPersonaInput
        '
        Me.DireccionPersonaInput.Location = New System.Drawing.Point(325, 203)
        Me.DireccionPersonaInput.Name = "DireccionPersonaInput"
        Me.DireccionPersonaInput.Size = New System.Drawing.Size(194, 20)
        Me.DireccionPersonaInput.TabIndex = 4
        '
        'CIPersonaText
        '
        Me.CIPersonaText.AutoSize = True
        Me.CIPersonaText.Location = New System.Drawing.Point(254, 165)
        Me.CIPersonaText.Name = "CIPersonaText"
        Me.CIPersonaText.Size = New System.Drawing.Size(20, 13)
        Me.CIPersonaText.TabIndex = 5
        Me.CIPersonaText.Text = "CI:"
        '
        'DireccionPersonaText
        '
        Me.DireccionPersonaText.AutoSize = True
        Me.DireccionPersonaText.Location = New System.Drawing.Point(254, 206)
        Me.DireccionPersonaText.Name = "DireccionPersonaText"
        Me.DireccionPersonaText.Size = New System.Drawing.Size(55, 13)
        Me.DireccionPersonaText.TabIndex = 6
        Me.DireccionPersonaText.Text = "Direccion:"
        '
        'AceptarPersonaBtn
        '
        Me.AceptarPersonaBtn.Location = New System.Drawing.Point(426, 276)
        Me.AceptarPersonaBtn.Name = "AceptarPersonaBtn"
        Me.AceptarPersonaBtn.Size = New System.Drawing.Size(93, 28)
        Me.AceptarPersonaBtn.TabIndex = 7
        Me.AceptarPersonaBtn.Text = "Aceptar"
        Me.AceptarPersonaBtn.UseVisualStyleBackColor = True
        '
        'CancelarPersonabtn
        '
        Me.CancelarPersonabtn.Location = New System.Drawing.Point(254, 276)
        Me.CancelarPersonabtn.Name = "CancelarPersonabtn"
        Me.CancelarPersonabtn.Size = New System.Drawing.Size(92, 28)
        Me.CancelarPersonabtn.TabIndex = 8
        Me.CancelarPersonabtn.Text = "Cancelar"
        Me.CancelarPersonabtn.UseVisualStyleBackColor = True
        '
        'TelefonoPersonaInput
        '
        Me.TelefonoPersonaInput.Location = New System.Drawing.Point(326, 230)
        Me.TelefonoPersonaInput.Name = "TelefonoPersonaInput"
        Me.TelefonoPersonaInput.Size = New System.Drawing.Size(193, 20)
        Me.TelefonoPersonaInput.TabIndex = 9
        '
        'TelefonoPersonaText
        '
        Me.TelefonoPersonaText.AutoSize = True
        Me.TelefonoPersonaText.Location = New System.Drawing.Point(254, 233)
        Me.TelefonoPersonaText.Name = "TelefonoPersonaText"
        Me.TelefonoPersonaText.Size = New System.Drawing.Size(52, 13)
        Me.TelefonoPersonaText.TabIndex = 10
        Me.TelefonoPersonaText.Text = "Telefono:"
        '
        'AltaPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class
