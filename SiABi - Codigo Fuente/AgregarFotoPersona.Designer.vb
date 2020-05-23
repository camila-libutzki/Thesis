<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarFotoPersona
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarFotoPersona))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonUsuario = New System.Windows.Forms.RadioButton()
        Me.RadioButtonProfesor = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAlumno = New System.Windows.Forms.RadioButton()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBoxLegajo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonUsuario)
        Me.GroupBox1.Controls.Add(Me.RadioButtonProfesor)
        Me.GroupBox1.Controls.Add(Me.RadioButtonAlumno)
        Me.GroupBox1.Location = New System.Drawing.Point(248, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 106)
        Me.GroupBox1.TabIndex = 108
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Persona"
        '
        'RadioButtonUsuario
        '
        Me.RadioButtonUsuario.AutoSize = True
        Me.RadioButtonUsuario.Location = New System.Drawing.Point(6, 82)
        Me.RadioButtonUsuario.Name = "RadioButtonUsuario"
        Me.RadioButtonUsuario.Size = New System.Drawing.Size(61, 17)
        Me.RadioButtonUsuario.TabIndex = 106
        Me.RadioButtonUsuario.Text = "Usuario"
        Me.RadioButtonUsuario.UseVisualStyleBackColor = True
        '
        'RadioButtonProfesor
        '
        Me.RadioButtonProfesor.AutoSize = True
        Me.RadioButtonProfesor.Location = New System.Drawing.Point(6, 59)
        Me.RadioButtonProfesor.Name = "RadioButtonProfesor"
        Me.RadioButtonProfesor.Size = New System.Drawing.Size(64, 17)
        Me.RadioButtonProfesor.TabIndex = 105
        Me.RadioButtonProfesor.Text = "Profesor"
        Me.RadioButtonProfesor.UseVisualStyleBackColor = True
        '
        'RadioButtonAlumno
        '
        Me.RadioButtonAlumno.AutoSize = True
        Me.RadioButtonAlumno.Checked = True
        Me.RadioButtonAlumno.Location = New System.Drawing.Point(6, 36)
        Me.RadioButtonAlumno.Name = "RadioButtonAlumno"
        Me.RadioButtonAlumno.Size = New System.Drawing.Size(60, 17)
        Me.RadioButtonAlumno.TabIndex = 104
        Me.RadioButtonAlumno.TabStop = True
        Me.RadioButtonAlumno.Text = "Alumno"
        Me.RadioButtonAlumno.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.ForeColor = System.Drawing.SystemColors.Control
        Me.Button5.Location = New System.Drawing.Point(88, 170)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(86, 38)
        Me.Button5.TabIndex = 107
        Me.Button5.Text = "Examinar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox.Location = New System.Drawing.Point(44, 36)
        Me.PictureBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(130, 130)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 106
        Me.PictureBox.TabStop = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(307, 224)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 38)
        Me.Button1.TabIndex = 105
        Me.Button1.Text = "Agregar Foto"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBoxLegajo
        '
        Me.TextBoxLegajo.Location = New System.Drawing.Point(296, 159)
        Me.TextBoxLegajo.Name = "TextBoxLegajo"
        Me.TextBoxLegajo.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxLegajo.TabIndex = 109
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(251, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "Legajo"
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(11, 248)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 38)
        Me.Button2.TabIndex = 111
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'AgregarFotoPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 297)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxLegajo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AgregarFotoPersona"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarFotoPersona"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonProfesor As RadioButton
    Friend WithEvents RadioButtonAlumno As RadioButton
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextBoxLegajo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButtonUsuario As RadioButton
    Friend WithEvents Button2 As Button
End Class
