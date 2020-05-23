<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrimerInicio
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
        Me.Labelcontraincorrecta = New System.Windows.Forms.Label()
        Me.ButtonContinuar = New System.Windows.Forms.Button()
        Me.TextBoxreingrese = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxnuevacontra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonVolver = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxNombreUsuario = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Labelcontraincorrecta
        '
        Me.Labelcontraincorrecta.AutoSize = True
        Me.Labelcontraincorrecta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Labelcontraincorrecta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Labelcontraincorrecta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelcontraincorrecta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Labelcontraincorrecta.Location = New System.Drawing.Point(308, 235)
        Me.Labelcontraincorrecta.Name = "Labelcontraincorrecta"
        Me.Labelcontraincorrecta.Size = New System.Drawing.Size(204, 17)
        Me.Labelcontraincorrecta.TabIndex = 61
        Me.Labelcontraincorrecta.Text = "Las contraseñas no coinciden!"
        Me.Labelcontraincorrecta.Visible = False
        '
        'ButtonContinuar
        '
        Me.ButtonContinuar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonContinuar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonContinuar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonContinuar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonContinuar.Location = New System.Drawing.Point(426, 267)
        Me.ButtonContinuar.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonContinuar.Name = "ButtonContinuar"
        Me.ButtonContinuar.Size = New System.Drawing.Size(86, 38)
        Me.ButtonContinuar.TabIndex = 60
        Me.ButtonContinuar.Text = "Continuar"
        Me.ButtonContinuar.UseVisualStyleBackColor = False
        '
        'TextBoxreingrese
        '
        Me.TextBoxreingrese.Location = New System.Drawing.Point(337, 207)
        Me.TextBoxreingrese.Name = "TextBoxreingrese"
        Me.TextBoxreingrese.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxreingrese.Size = New System.Drawing.Size(175, 20)
        Me.TextBoxreingrese.TabIndex = 59
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(127, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 16)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Reescriba la nueva contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(322, 15)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Debe cambiar su contraseña en el primer inicio de sesión"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(11, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 26)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Cambio de Contraseña"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBoxnuevacontra
        '
        Me.TextBoxnuevacontra.Location = New System.Drawing.Point(337, 181)
        Me.TextBoxnuevacontra.Name = "TextBoxnuevacontra"
        Me.TextBoxnuevacontra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxnuevacontra.Size = New System.Drawing.Size(175, 20)
        Me.TextBoxnuevacontra.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Nueva contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Location = New System.Drawing.Point(121, 9)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(450, 24)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "UTN - FRLP - Sistema de Asistencia Biométrico"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonVolver
        '
        Me.ButtonVolver.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonVolver.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonVolver.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonVolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonVolver.Location = New System.Drawing.Point(11, 349)
        Me.ButtonVolver.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonVolver.Name = "ButtonVolver"
        Me.ButtonVolver.Size = New System.Drawing.Size(80, 38)
        Me.ButtonVolver.TabIndex = 64
        Me.ButtonVolver.Text = "Volver"
        Me.ButtonVolver.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(497, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 16)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Usuario"
        '
        'TextBoxNombreUsuario
        '
        Me.TextBoxNombreUsuario.Location = New System.Drawing.Point(558, 82)
        Me.TextBoxNombreUsuario.Name = "TextBoxNombreUsuario"
        Me.TextBoxNombreUsuario.ReadOnly = True
        Me.TextBoxNombreUsuario.Size = New System.Drawing.Size(128, 20)
        Me.TextBoxNombreUsuario.TabIndex = 66
        '
        'PrimerInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 398)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBoxNombreUsuario)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ButtonVolver)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Labelcontraincorrecta)
        Me.Controls.Add(Me.ButtonContinuar)
        Me.Controls.Add(Me.TextBoxreingrese)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxnuevacontra)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "PrimerInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Labelcontraincorrecta As Label
    Friend WithEvents ButtonContinuar As Button
    Friend WithEvents TextBoxreingrese As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxnuevacontra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonVolver As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxNombreUsuario As TextBox
End Class
