<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarPersona
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
        Me.ListPersona = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListPersona
        '
        Me.ListPersona.FormattingEnabled = True
        Me.ListPersona.Location = New System.Drawing.Point(123, 72)
        Me.ListPersona.Name = "ListPersona"
        Me.ListPersona.Size = New System.Drawing.Size(378, 212)
        Me.ListPersona.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(232, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Listado de Personas"
        '
        'ListarPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 296)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListPersona)
        Me.Name = "ListarPersona"
        Me.RightToLeftLayout = True
        Me.Text = "ListarPersona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListPersona As ListBox
    Friend WithEvents Label1 As Label
End Class
