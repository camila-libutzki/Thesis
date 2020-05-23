<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.LabelUsrPassIncorrecto = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.TextBoxContraseña = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCatedra = New System.Windows.Forms.ComboBox()
        Me.LabelDpto = New System.Windows.Forms.Label()
        Me.ComboBoxDpto = New System.Windows.Forms.ComboBox()
        Me.LabelCatedra = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelUsrPassIncorrecto
        '
        Me.LabelUsrPassIncorrecto.AutoSize = True
        Me.LabelUsrPassIncorrecto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LabelUsrPassIncorrecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelUsrPassIncorrecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsrPassIncorrecto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelUsrPassIncorrecto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelUsrPassIncorrecto.Location = New System.Drawing.Point(353, 268)
        Me.LabelUsrPassIncorrecto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelUsrPassIncorrecto.Name = "LabelUsrPassIncorrecto"
        Me.LabelUsrPassIncorrecto.Size = New System.Drawing.Size(225, 17)
        Me.LabelUsrPassIncorrecto.TabIndex = 35
        Me.LabelUsrPassIncorrecto.Text = "Usuario o contraseña incorrectos!"
        Me.LabelUsrPassIncorrecto.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(282, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 26)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Inicio de Sesión"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(81, 131)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'ButtonLogin
        '
        Me.ButtonLogin.AutoSize = True
        Me.ButtonLogin.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.ButtonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonLogin.Location = New System.Drawing.Point(483, 303)
        Me.ButtonLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(95, 39)
        Me.ButtonLogin.TabIndex = 32
        Me.ButtonLogin.Text = "Ingresar"
        Me.ButtonLogin.UseVisualStyleBackColor = False
        '
        'TextBoxContraseña
        '
        Me.TextBoxContraseña.AccessibleDescription = "id de usuario"
        Me.TextBoxContraseña.AccessibleName = "id de usuario"
        Me.TextBoxContraseña.Location = New System.Drawing.Point(390, 230)
        Me.TextBoxContraseña.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxContraseña.Name = "TextBoxContraseña"
        Me.TextBoxContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxContraseña.Size = New System.Drawing.Size(188, 20)
        Me.TextBoxContraseña.TabIndex = 31
        Me.TextBoxContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBoxContraseña.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(305, 231)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Contraseña"
        '
        'TextBoxNombreUsuario
        '
        Me.TextBoxNombreUsuario.AccessibleDescription = "id de usuario"
        Me.TextBoxNombreUsuario.AccessibleName = "id de usuario"
        Me.TextBoxNombreUsuario.Location = New System.Drawing.Point(390, 131)
        Me.TextBoxNombreUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxNombreUsuario.Name = "TextBoxNombreUsuario"
        Me.TextBoxNombreUsuario.Size = New System.Drawing.Size(188, 20)
        Me.TextBoxNombreUsuario.TabIndex = 29
        Me.TextBoxNombreUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(255, 132)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 17)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Nombre de Usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(121, 9)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(450, 24)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "UTN - FRLP - Sistema de Asistencia Biométrico"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(277, 156)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 17)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Tipo de Usuario"
        '
        'ComboBoxTipoUsuario
        '
        Me.ComboBoxTipoUsuario.AccessibleDescription = "Ingrese tipo de Usuario"
        Me.ComboBoxTipoUsuario.AccessibleName = "Ingrese tipo de Usuario"
        Me.ComboBoxTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTipoUsuario.FormattingEnabled = True
        Me.ComboBoxTipoUsuario.Items.AddRange(New Object() {"Administrador", "Bedel", "Jefe de Cátedra", "Jefe de Departamento"})
        Me.ComboBoxTipoUsuario.Location = New System.Drawing.Point(390, 155)
        Me.ComboBoxTipoUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxTipoUsuario.Name = "ComboBoxTipoUsuario"
        Me.ComboBoxTipoUsuario.Size = New System.Drawing.Size(188, 21)
        Me.ComboBoxTipoUsuario.TabIndex = 107
        '
        'ComboBoxCatedra
        '
        Me.ComboBoxCatedra.AccessibleDescription = "Ingrese tipo de Usuario"
        Me.ComboBoxCatedra.AccessibleName = "Ingrese tipo de Usuario"
        Me.ComboBoxCatedra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCatedra.Enabled = False
        Me.ComboBoxCatedra.FormattingEnabled = True
        Me.ComboBoxCatedra.Location = New System.Drawing.Point(390, 205)
        Me.ComboBoxCatedra.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxCatedra.Name = "ComboBoxCatedra"
        Me.ComboBoxCatedra.Size = New System.Drawing.Size(188, 21)
        Me.ComboBoxCatedra.TabIndex = 108
        '
        'LabelDpto
        '
        Me.LabelDpto.AutoSize = True
        Me.LabelDpto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelDpto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelDpto.Location = New System.Drawing.Point(288, 181)
        Me.LabelDpto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDpto.Name = "LabelDpto"
        Me.LabelDpto.Size = New System.Drawing.Size(98, 17)
        Me.LabelDpto.TabIndex = 109
        Me.LabelDpto.Text = "Departamento"
        '
        'ComboBoxDpto
        '
        Me.ComboBoxDpto.AccessibleDescription = "Ingrese tipo de Usuario"
        Me.ComboBoxDpto.AccessibleName = "Ingrese tipo de Usuario"
        Me.ComboBoxDpto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDpto.Enabled = False
        Me.ComboBoxDpto.FormattingEnabled = True
        Me.ComboBoxDpto.Items.AddRange(New Object() {"Sistemas", "Industrial", "Mecanica", "Quimica", "Electrica", "Civil"})
        Me.ComboBoxDpto.Location = New System.Drawing.Point(390, 180)
        Me.ComboBoxDpto.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxDpto.Name = "ComboBoxDpto"
        Me.ComboBoxDpto.Size = New System.Drawing.Size(188, 21)
        Me.ComboBoxDpto.TabIndex = 110
        '
        'LabelCatedra
        '
        Me.LabelCatedra.AutoSize = True
        Me.LabelCatedra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelCatedra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelCatedra.Location = New System.Drawing.Point(328, 206)
        Me.LabelCatedra.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelCatedra.Name = "LabelCatedra"
        Me.LabelCatedra.Size = New System.Drawing.Size(58, 17)
        Me.LabelCatedra.TabIndex = 111
        Me.LabelCatedra.Text = "Cátedra"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Location = New System.Drawing.Point(12, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 29)
        Me.Button1.TabIndex = 113
        Me.Button1.Text = "Modificar BD"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AcceptButton = Me.ButtonLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 398)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelCatedra)
        Me.Controls.Add(Me.ComboBoxDpto)
        Me.Controls.Add(Me.LabelDpto)
        Me.Controls.Add(Me.ComboBoxCatedra)
        Me.Controls.Add(Me.ComboBoxTipoUsuario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelUsrPassIncorrecto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.TextBoxContraseña)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxNombreUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelUsrPassIncorrecto As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents TextBoxContraseña As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNombreUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxTipoUsuario As ComboBox
    Friend WithEvents ComboBoxCatedra As ComboBox
    Friend WithEvents LabelDpto As Label
    Friend WithEvents ComboBoxDpto As ComboBox
    Friend WithEvents LabelCatedra As Label
    Friend WithEvents Button1 As Button
End Class
