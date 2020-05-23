<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarPersona
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarPersona))
        Me.LabelInscripto = New System.Windows.Forms.Label()
        Me.LabelConsultaAlumnos = New System.Windows.Forms.Label()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.LabelEncabezado = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxApellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxDNI = New System.Windows.Forms.TextBox()
        Me.TextBoxLegajo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureAltaPersona = New System.Windows.Forms.PictureBox()
        Me.ButtonTomarHuella2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonMano2H = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMano2D = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxDedoMano2 = New System.Windows.Forms.ComboBox()
        Me.FotoHuella2 = New System.Windows.Forms.PictureBox()
        Me.ButtonTomarHuella1 = New System.Windows.Forms.Button()
        Me.ButtonsMano1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonMano1H = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMano1D = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxDedoMano1 = New System.Windows.Forms.ComboBox()
        Me.FotoHuella1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureAltaPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FotoHuella2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ButtonsMano1.SuspendLayout()
        CType(Me.FotoHuella1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelInscripto
        '
        Me.LabelInscripto.AutoSize = True
        Me.LabelInscripto.BackColor = System.Drawing.Color.Moccasin
        Me.LabelInscripto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInscripto.Location = New System.Drawing.Point(370, 498)
        Me.LabelInscripto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelInscripto.Name = "LabelInscripto"
        Me.LabelInscripto.Size = New System.Drawing.Size(395, 15)
        Me.LabelInscripto.TabIndex = 180
        Me.LabelInscripto.Text = "Las huellas se guardarán al presionar el botón Guardar Modificaciones"
        Me.LabelInscripto.Visible = False
        '
        'LabelConsultaAlumnos
        '
        Me.LabelConsultaAlumnos.AutoSize = True
        Me.LabelConsultaAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelConsultaAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LabelConsultaAlumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConsultaAlumnos.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelConsultaAlumnos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LabelConsultaAlumnos.Location = New System.Drawing.Point(203, 81)
        Me.LabelConsultaAlumnos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelConsultaAlumnos.Name = "LabelConsultaAlumnos"
        Me.LabelConsultaAlumnos.Size = New System.Drawing.Size(256, 26)
        Me.LabelConsultaAlumnos.TabIndex = 179
        Me.LabelConsultaAlumnos.Text = "Modificar huellas en SiABi"
        Me.LabelConsultaAlumnos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonModificar
        '
        Me.ButtonModificar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonModificar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonModificar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonModificar.Location = New System.Drawing.Point(769, 487)
        Me.ButtonModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(97, 38)
        Me.ButtonModificar.TabIndex = 178
        Me.ButtonModificar.Text = "Guardar Modificaciones"
        Me.ButtonModificar.UseVisualStyleBackColor = False
        '
        'LabelEncabezado
        '
        Me.LabelEncabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelEncabezado.AutoSize = True
        Me.LabelEncabezado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEncabezado.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelEncabezado.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LabelEncabezado.Location = New System.Drawing.Point(385, 32)
        Me.LabelEncabezado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelEncabezado.Name = "LabelEncabezado"
        Me.LabelEncabezado.Size = New System.Drawing.Size(450, 24)
        Me.LabelEncabezado.TabIndex = 158
        Me.LabelEncabezado.Text = "UTN - FRLP - Sistema de Asistencia Biométrico"
        Me.LabelEncabezado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxNombre)
        Me.GroupBox2.Controls.Add(Me.TextBoxApellido)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBoxDNI)
        Me.GroupBox2.Controls.Add(Me.TextBoxLegajo)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.PictureAltaPersona)
        Me.GroupBox2.Location = New System.Drawing.Point(422, 127)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(395, 156)
        Me.GroupBox2.TabIndex = 187
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de la Persona"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(67, 17)
        Me.TextBoxNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.ReadOnly = True
        Me.TextBoxNombre.Size = New System.Drawing.Size(175, 20)
        Me.TextBoxNombre.TabIndex = 134
        '
        'TextBoxApellido
        '
        Me.TextBoxApellido.Location = New System.Drawing.Point(67, 41)
        Me.TextBoxApellido.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxApellido.Name = "TextBoxApellido"
        Me.TextBoxApellido.ReadOnly = True
        Me.TextBoxApellido.Size = New System.Drawing.Size(175, 20)
        Me.TextBoxApellido.TabIndex = 135
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 42)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 137
        Me.Label3.Text = "Apellido"
        '
        'TextBoxDNI
        '
        Me.TextBoxDNI.Location = New System.Drawing.Point(67, 65)
        Me.TextBoxDNI.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxDNI.Name = "TextBoxDNI"
        Me.TextBoxDNI.ReadOnly = True
        Me.TextBoxDNI.Size = New System.Drawing.Size(175, 20)
        Me.TextBoxDNI.TabIndex = 138
        '
        'TextBoxLegajo
        '
        Me.TextBoxLegajo.Location = New System.Drawing.Point(67, 89)
        Me.TextBoxLegajo.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxLegajo.Name = "TextBoxLegajo"
        Me.TextBoxLegajo.ReadOnly = True
        Me.TextBoxLegajo.Size = New System.Drawing.Size(175, 20)
        Me.TextBoxLegajo.TabIndex = 139
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(32, 66)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 17)
        Me.Label10.TabIndex = 140
        Me.Label10.Text = "DNI"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 90)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 17)
        Me.Label9.TabIndex = 141
        Me.Label9.Text = "Legajo"
        '
        'PictureAltaPersona
        '
        Me.PictureAltaPersona.Image = CType(resources.GetObject("PictureAltaPersona.Image"), System.Drawing.Image)
        Me.PictureAltaPersona.InitialImage = CType(resources.GetObject("PictureAltaPersona.InitialImage"), System.Drawing.Image)
        Me.PictureAltaPersona.Location = New System.Drawing.Point(256, 17)
        Me.PictureAltaPersona.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureAltaPersona.Name = "PictureAltaPersona"
        Me.PictureAltaPersona.Size = New System.Drawing.Size(130, 130)
        Me.PictureAltaPersona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureAltaPersona.TabIndex = 142
        Me.PictureAltaPersona.TabStop = False
        '
        'ButtonTomarHuella2
        '
        Me.ButtonTomarHuella2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonTomarHuella2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonTomarHuella2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonTomarHuella2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonTomarHuella2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonTomarHuella2.Location = New System.Drawing.Point(865, 401)
        Me.ButtonTomarHuella2.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonTomarHuella2.Name = "ButtonTomarHuella2"
        Me.ButtonTomarHuella2.Size = New System.Drawing.Size(97, 38)
        Me.ButtonTomarHuella2.TabIndex = 186
        Me.ButtonTomarHuella2.Text = "Tomar Huella 2"
        Me.ButtonTomarHuella2.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonMano2H)
        Me.GroupBox1.Controls.Add(Me.RadioButtonMano2D)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ComboBoxDedoMano2)
        Me.GroupBox1.Location = New System.Drawing.Point(731, 303)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(231, 93)
        Me.GroupBox1.TabIndex = 185
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Huella 2"
        '
        'RadioButtonMano2H
        '
        Me.RadioButtonMano2H.AutoSize = True
        Me.RadioButtonMano2H.Checked = True
        Me.RadioButtonMano2H.Location = New System.Drawing.Point(6, 42)
        Me.RadioButtonMano2H.Name = "RadioButtonMano2H"
        Me.RadioButtonMano2H.Size = New System.Drawing.Size(97, 17)
        Me.RadioButtonMano2H.TabIndex = 1
        Me.RadioButtonMano2H.TabStop = True
        Me.RadioButtonMano2H.Text = "Mano izquierda"
        Me.RadioButtonMano2H.UseVisualStyleBackColor = True
        '
        'RadioButtonMano2D
        '
        Me.RadioButtonMano2D.AutoSize = True
        Me.RadioButtonMano2D.Location = New System.Drawing.Point(6, 19)
        Me.RadioButtonMano2D.Name = "RadioButtonMano2D"
        Me.RadioButtonMano2D.Size = New System.Drawing.Size(94, 17)
        Me.RadioButtonMano2D.TabIndex = 0
        Me.RadioButtonMano2D.TabStop = True
        Me.RadioButtonMano2D.Text = "Mano derecha"
        Me.RadioButtonMano2D.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(5, 66)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 15)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "Dedo seleccionado"
        '
        'ComboBoxDedoMano2
        '
        Me.ComboBoxDedoMano2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDedoMano2.FormattingEnabled = True
        Me.ComboBoxDedoMano2.Items.AddRange(New Object() {"Indice", "Pulgar", "Medio", "Anular", "Meñique"})
        Me.ComboBoxDedoMano2.Location = New System.Drawing.Point(123, 65)
        Me.ComboBoxDedoMano2.Name = "ComboBoxDedoMano2"
        Me.ComboBoxDedoMano2.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxDedoMano2.TabIndex = 153
        '
        'FotoHuella2
        '
        Me.FotoHuella2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FotoHuella2.Image = CType(resources.GetObject("FotoHuella2.Image"), System.Drawing.Image)
        Me.FotoHuella2.InitialImage = CType(resources.GetObject("FotoHuella2.InitialImage"), System.Drawing.Image)
        Me.FotoHuella2.Location = New System.Drawing.Point(646, 303)
        Me.FotoHuella2.Margin = New System.Windows.Forms.Padding(2)
        Me.FotoHuella2.Name = "FotoHuella2"
        Me.FotoHuella2.Size = New System.Drawing.Size(80, 80)
        Me.FotoHuella2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoHuella2.TabIndex = 184
        Me.FotoHuella2.TabStop = False
        Me.FotoHuella2.Visible = False
        '
        'ButtonTomarHuella1
        '
        Me.ButtonTomarHuella1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonTomarHuella1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonTomarHuella1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonTomarHuella1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonTomarHuella1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonTomarHuella1.Location = New System.Drawing.Point(509, 401)
        Me.ButtonTomarHuella1.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonTomarHuella1.Name = "ButtonTomarHuella1"
        Me.ButtonTomarHuella1.Size = New System.Drawing.Size(97, 38)
        Me.ButtonTomarHuella1.TabIndex = 183
        Me.ButtonTomarHuella1.Text = "Tomar Huella 1"
        Me.ButtonTomarHuella1.UseVisualStyleBackColor = False
        '
        'ButtonsMano1
        '
        Me.ButtonsMano1.Controls.Add(Me.RadioButtonMano1H)
        Me.ButtonsMano1.Controls.Add(Me.RadioButtonMano1D)
        Me.ButtonsMano1.Controls.Add(Me.Label4)
        Me.ButtonsMano1.Controls.Add(Me.ComboBoxDedoMano1)
        Me.ButtonsMano1.Location = New System.Drawing.Point(375, 303)
        Me.ButtonsMano1.Name = "ButtonsMano1"
        Me.ButtonsMano1.Size = New System.Drawing.Size(231, 93)
        Me.ButtonsMano1.TabIndex = 182
        Me.ButtonsMano1.TabStop = False
        Me.ButtonsMano1.Text = "Huella 1"
        '
        'RadioButtonMano1H
        '
        Me.RadioButtonMano1H.AutoSize = True
        Me.RadioButtonMano1H.Location = New System.Drawing.Point(6, 42)
        Me.RadioButtonMano1H.Name = "RadioButtonMano1H"
        Me.RadioButtonMano1H.Size = New System.Drawing.Size(97, 17)
        Me.RadioButtonMano1H.TabIndex = 1
        Me.RadioButtonMano1H.TabStop = True
        Me.RadioButtonMano1H.Text = "Mano izquierda"
        Me.RadioButtonMano1H.UseVisualStyleBackColor = True
        '
        'RadioButtonMano1D
        '
        Me.RadioButtonMano1D.AutoSize = True
        Me.RadioButtonMano1D.Checked = True
        Me.RadioButtonMano1D.Location = New System.Drawing.Point(6, 19)
        Me.RadioButtonMano1D.Name = "RadioButtonMano1D"
        Me.RadioButtonMano1D.Size = New System.Drawing.Size(94, 17)
        Me.RadioButtonMano1D.TabIndex = 0
        Me.RadioButtonMano1D.TabStop = True
        Me.RadioButtonMano1D.Text = "Mano derecha"
        Me.RadioButtonMano1D.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(5, 65)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 15)
        Me.Label4.TabIndex = 144
        Me.Label4.Text = "Dedo seleccionado"
        '
        'ComboBoxDedoMano1
        '
        Me.ComboBoxDedoMano1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDedoMano1.FormattingEnabled = True
        Me.ComboBoxDedoMano1.Items.AddRange(New Object() {"Indice", "Pulgar", "Medio", "Anular", "Meñique"})
        Me.ComboBoxDedoMano1.Location = New System.Drawing.Point(123, 64)
        Me.ComboBoxDedoMano1.Name = "ComboBoxDedoMano1"
        Me.ComboBoxDedoMano1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxDedoMano1.TabIndex = 148
        '
        'FotoHuella1
        '
        Me.FotoHuella1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FotoHuella1.Image = CType(resources.GetObject("FotoHuella1.Image"), System.Drawing.Image)
        Me.FotoHuella1.InitialImage = CType(resources.GetObject("FotoHuella1.InitialImage"), System.Drawing.Image)
        Me.FotoHuella1.Location = New System.Drawing.Point(290, 303)
        Me.FotoHuella1.Margin = New System.Windows.Forms.Padding(2)
        Me.FotoHuella1.Name = "FotoHuella1"
        Me.FotoHuella1.Size = New System.Drawing.Size(80, 80)
        Me.FotoHuella1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoHuella1.TabIndex = 181
        Me.FotoHuella1.TabStop = False
        Me.FotoHuella1.Visible = False
        '
        'ModificarPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 568)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ButtonTomarHuella2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FotoHuella2)
        Me.Controls.Add(Me.ButtonTomarHuella1)
        Me.Controls.Add(Me.ButtonsMano1)
        Me.Controls.Add(Me.FotoHuella1)
        Me.Controls.Add(Me.LabelInscripto)
        Me.Controls.Add(Me.LabelConsultaAlumnos)
        Me.Controls.Add(Me.ButtonModificar)
        Me.Controls.Add(Me.LabelEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ModificarPersona"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureAltaPersona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.FotoHuella2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ButtonsMano1.ResumeLayout(False)
        Me.ButtonsMano1.PerformLayout()
        CType(Me.FotoHuella1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelInscripto As Label
    Friend WithEvents LabelConsultaAlumnos As Label
    Friend WithEvents ButtonModificar As Button
    Friend WithEvents LabelEncabezado As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxApellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxDNI As TextBox
    Friend WithEvents TextBoxLegajo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureAltaPersona As PictureBox
    Friend WithEvents ButtonTomarHuella2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonMano2H As RadioButton
    Friend WithEvents RadioButtonMano2D As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxDedoMano2 As ComboBox
    Friend WithEvents FotoHuella2 As PictureBox
    Friend WithEvents ButtonTomarHuella1 As Button
    Friend WithEvents ButtonsMano1 As GroupBox
    Friend WithEvents RadioButtonMano1H As RadioButton
    Friend WithEvents RadioButtonMano1D As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxDedoMano1 As ComboBox
    Friend WithEvents FotoHuella1 As PictureBox
End Class
