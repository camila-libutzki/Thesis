<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AltaUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltaUsuario))
        Me.LabelEncabezado = New System.Windows.Forms.Label()
        Me.TextBoxLegajo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxDNI = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxNombreApellido = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.Labelaltadeusuario = New System.Windows.Forms.Label()
        Me.ComboBoxTipo = New System.Windows.Forms.ComboBox()
        Me.TextBoxNombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelInscripto = New System.Windows.Forms.Label()
        Me.TextoDeAyuda = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxDpto = New System.Windows.Forms.ComboBox()
        Me.LabelDpto = New System.Windows.Forms.Label()
        Me.ComboBoxCatedra = New System.Windows.Forms.ComboBox()
        Me.LabelCat = New System.Windows.Forms.Label()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelEncabezado
        '
        Me.LabelEncabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelEncabezado.AutoSize = True
        Me.LabelEncabezado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEncabezado.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelEncabezado.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LabelEncabezado.Location = New System.Drawing.Point(161, 9)
        Me.LabelEncabezado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelEncabezado.Name = "LabelEncabezado"
        Me.LabelEncabezado.Size = New System.Drawing.Size(450, 24)
        Me.LabelEncabezado.TabIndex = 89
        Me.LabelEncabezado.Text = "UTN - FRLP - Sistema de Asistencia Biométrico"
        Me.LabelEncabezado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBoxLegajo
        '
        Me.TextBoxLegajo.Location = New System.Drawing.Point(495, 324)
        Me.TextBoxLegajo.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxLegajo.Name = "TextBoxLegajo"
        Me.TextBoxLegajo.Size = New System.Drawing.Size(212, 20)
        Me.TextBoxLegajo.TabIndex = 105
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(440, 325)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 17)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Legajo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(460, 284)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 17)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "DNI"
        '
        'TextBoxDNI
        '
        Me.TextBoxDNI.Location = New System.Drawing.Point(495, 283)
        Me.TextBoxDNI.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxDNI.Name = "TextBoxDNI"
        Me.TextBoxDNI.Size = New System.Drawing.Size(212, 20)
        Me.TextBoxDNI.TabIndex = 102
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(368, 245)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 17)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "Nombre y Apellido"
        '
        'TextBoxNombreApellido
        '
        Me.TextBoxNombreApellido.Location = New System.Drawing.Point(495, 244)
        Me.TextBoxNombreApellido.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxNombreApellido.Name = "TextBoxNombreApellido"
        Me.TextBoxNombreApellido.Size = New System.Drawing.Size(212, 20)
        Me.TextBoxNombreApellido.TabIndex = 100
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.ForeColor = System.Drawing.SystemColors.Control
        Me.Button5.Location = New System.Drawing.Point(135, 275)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(86, 38)
        Me.Button5.TabIndex = 98
        Me.Button5.Text = "Examinar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox.Image = CType(resources.GetObject("PictureBox.Image"), System.Drawing.Image)
        Me.PictureBox.Location = New System.Drawing.Point(91, 141)
        Me.PictureBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(130, 130)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 96
        Me.PictureBox.TabStop = False
        '
        'Labelaltadeusuario
        '
        Me.Labelaltadeusuario.AutoSize = True
        Me.Labelaltadeusuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Labelaltadeusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelaltadeusuario.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Labelaltadeusuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Labelaltadeusuario.Location = New System.Drawing.Point(11, 65)
        Me.Labelaltadeusuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Labelaltadeusuario.Name = "Labelaltadeusuario"
        Me.Labelaltadeusuario.Size = New System.Drawing.Size(152, 26)
        Me.Labelaltadeusuario.TabIndex = 95
        Me.Labelaltadeusuario.Text = "Alta de usuario"
        Me.Labelaltadeusuario.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComboBoxTipo
        '
        Me.ComboBoxTipo.AccessibleDescription = ""
        Me.ComboBoxTipo.AccessibleName = ""
        Me.ComboBoxTipo.Cursor = System.Windows.Forms.Cursors.Default
        Me.ComboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTipo.FormattingEnabled = True
        Me.ComboBoxTipo.Items.AddRange(New Object() {"Administrador", "Bedel", "Jefe de Cátedra", "Jefe de Departamento"})
        Me.ComboBoxTipo.Location = New System.Drawing.Point(495, 141)
        Me.ComboBoxTipo.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxTipo.Name = "ComboBoxTipo"
        Me.ComboBoxTipo.Size = New System.Drawing.Size(212, 21)
        Me.ComboBoxTipo.TabIndex = 94
        '
        'TextBoxNombreUsuario
        '
        Me.TextBoxNombreUsuario.AccessibleDescription = "id de usuario"
        Me.TextBoxNombreUsuario.AccessibleName = "id de usuario"
        Me.TextBoxNombreUsuario.AllowDrop = True
        Me.TextBoxNombreUsuario.Location = New System.Drawing.Point(495, 220)
        Me.TextBoxNombreUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxNombreUsuario.Name = "TextBoxNombreUsuario"
        Me.TextBoxNombreUsuario.Size = New System.Drawing.Size(212, 20)
        Me.TextBoxNombreUsuario.TabIndex = 93
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(382, 142)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Tipo de Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(360, 221)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 17)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Nombre de Usuario"
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(618, 430)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 38)
        Me.Button1.TabIndex = 90
        Me.Button1.Text = "Dar de Alta"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LabelInscripto
        '
        Me.LabelInscripto.AutoSize = True
        Me.LabelInscripto.BackColor = System.Drawing.Color.Moccasin
        Me.LabelInscripto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInscripto.Location = New System.Drawing.Point(441, 377)
        Me.LabelInscripto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelInscripto.Name = "LabelInscripto"
        Me.LabelInscripto.Size = New System.Drawing.Size(266, 15)
        Me.LabelInscripto.TabIndex = 141
        Me.LabelInscripto.Text = "La contraseña por defecto es el DNI del usuario"
        Me.LabelInscripto.Visible = False
        '
        'TextoDeAyuda
        '
        Me.TextoDeAyuda.AutoSize = True
        Me.TextoDeAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoDeAyuda.Location = New System.Drawing.Point(478, 346)
        Me.TextoDeAyuda.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TextoDeAyuda.Name = "TextoDeAyuda"
        Me.TextoDeAyuda.Size = New System.Drawing.Size(229, 15)
        Me.TextoDeAyuda.TabIndex = 142
        Me.TextoDeAyuda.Text = "Ingrese el legajo sin guiones ni espacios"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(563, 305)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 15)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "Ingrese el DNI sin puntos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Moccasin
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(379, 392)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(328, 15)
        Me.Label4.TabIndex = 144
        Me.Label4.Text = "El usuario deberá modificarla en su primer inicio de sesión"
        Me.Label4.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(563, 266)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 15)
        Me.Label5.TabIndex = 146
        Me.Label5.Text = "Nombre y Apellido reales"
        '
        'ComboBoxDpto
        '
        Me.ComboBoxDpto.AccessibleDescription = ""
        Me.ComboBoxDpto.AccessibleName = ""
        Me.ComboBoxDpto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDpto.Enabled = False
        Me.ComboBoxDpto.FormattingEnabled = True
        Me.ComboBoxDpto.Items.AddRange(New Object() {"Sistemas", "Industrial", "Mecanica", "Quimica", "Electrica", "Civil"})
        Me.ComboBoxDpto.Location = New System.Drawing.Point(495, 166)
        Me.ComboBoxDpto.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxDpto.Name = "ComboBoxDpto"
        Me.ComboBoxDpto.Size = New System.Drawing.Size(212, 21)
        Me.ComboBoxDpto.TabIndex = 149
        '
        'LabelDpto
        '
        Me.LabelDpto.AutoSize = True
        Me.LabelDpto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelDpto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelDpto.Location = New System.Drawing.Point(393, 167)
        Me.LabelDpto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDpto.Name = "LabelDpto"
        Me.LabelDpto.Size = New System.Drawing.Size(98, 17)
        Me.LabelDpto.TabIndex = 148
        Me.LabelDpto.Text = "Departamento"
        '
        'ComboBoxCatedra
        '
        Me.ComboBoxCatedra.AccessibleDescription = ""
        Me.ComboBoxCatedra.AccessibleName = ""
        Me.ComboBoxCatedra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCatedra.Enabled = False
        Me.ComboBoxCatedra.FormattingEnabled = True
        Me.ComboBoxCatedra.Location = New System.Drawing.Point(495, 191)
        Me.ComboBoxCatedra.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxCatedra.Name = "ComboBoxCatedra"
        Me.ComboBoxCatedra.Size = New System.Drawing.Size(212, 21)
        Me.ComboBoxCatedra.TabIndex = 147
        '
        'LabelCat
        '
        Me.LabelCat.AutoSize = True
        Me.LabelCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelCat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelCat.Location = New System.Drawing.Point(433, 192)
        Me.LabelCat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelCat.Name = "LabelCat"
        Me.LabelCat.Size = New System.Drawing.Size(58, 17)
        Me.LabelCat.TabIndex = 150
        Me.LabelCat.Text = "Cátedra"
        '
        'AltaUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 487)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelCat)
        Me.Controls.Add(Me.ComboBoxDpto)
        Me.Controls.Add(Me.LabelDpto)
        Me.Controls.Add(Me.ComboBoxCatedra)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextoDeAyuda)
        Me.Controls.Add(Me.LabelInscripto)
        Me.Controls.Add(Me.TextBoxLegajo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxDNI)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBoxNombreApellido)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.Labelaltadeusuario)
        Me.Controls.Add(Me.ComboBoxTipo)
        Me.Controls.Add(Me.TextBoxNombreUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AltaUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelEncabezado As Label
    Friend WithEvents TextBoxLegajo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxDNI As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxNombreApellido As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents Labelaltadeusuario As Label
    Friend WithEvents ComboBoxTipo As ComboBox
    Friend WithEvents TextBoxNombreUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelInscripto As Label
    Friend WithEvents TextoDeAyuda As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxDpto As ComboBox
    Friend WithEvents LabelDpto As Label
    Friend WithEvents ComboBoxCatedra As ComboBox
    Friend WithEvents LabelCat As Label
End Class
