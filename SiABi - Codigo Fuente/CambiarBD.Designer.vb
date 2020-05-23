<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambiarBD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CambiarBD))
        Me.LabelConsultaAlumnos = New System.Windows.Forms.Label()
        Me.LabelEncabezado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelServer = New System.Windows.Forms.Label()
        Me.LabelUser = New System.Windows.Forms.Label()
        Me.LabelPass = New System.Windows.Forms.Label()
        Me.LabelDatabase = New System.Windows.Forms.Label()
        Me.TextBoxServerDB = New System.Windows.Forms.TextBox()
        Me.TextBoxDatabaseDB = New System.Windows.Forms.TextBox()
        Me.TextBoxPasswordDB = New System.Windows.Forms.TextBox()
        Me.TextBoxUserDB = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ButtonDBcami = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelConsultaAlumnos
        '
        Me.LabelConsultaAlumnos.AutoSize = True
        Me.LabelConsultaAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelConsultaAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LabelConsultaAlumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConsultaAlumnos.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelConsultaAlumnos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LabelConsultaAlumnos.Location = New System.Drawing.Point(-288, 131)
        Me.LabelConsultaAlumnos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelConsultaAlumnos.Name = "LabelConsultaAlumnos"
        Me.LabelConsultaAlumnos.Size = New System.Drawing.Size(227, 26)
        Me.LabelConsultaAlumnos.TabIndex = 94
        Me.LabelConsultaAlumnos.Text = "Reporte de Asistencias"
        Me.LabelConsultaAlumnos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelEncabezado
        '
        Me.LabelEncabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelEncabezado.AutoSize = True
        Me.LabelEncabezado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEncabezado.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelEncabezado.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LabelEncabezado.Location = New System.Drawing.Point(66, 9)
        Me.LabelEncabezado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelEncabezado.Name = "LabelEncabezado"
        Me.LabelEncabezado.Size = New System.Drawing.Size(450, 24)
        Me.LabelEncabezado.TabIndex = 93
        Me.LabelEncabezado.Text = "UTN - FRLP - Sistema de Asistencia Biométrico"
        Me.LabelEncabezado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(106, 70)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 26)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Modificar Conexion a Base de Datos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelServer
        '
        Me.LabelServer.AutoSize = True
        Me.LabelServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelServer.Location = New System.Drawing.Point(131, 130)
        Me.LabelServer.Name = "LabelServer"
        Me.LabelServer.Size = New System.Drawing.Size(70, 16)
        Me.LabelServer.TabIndex = 96
        Me.LabelServer.Text = "Server BD"
        '
        'LabelUser
        '
        Me.LabelUser.AutoSize = True
        Me.LabelUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUser.Location = New System.Drawing.Point(164, 156)
        Me.LabelUser.Name = "LabelUser"
        Me.LabelUser.Size = New System.Drawing.Size(37, 16)
        Me.LabelUser.TabIndex = 97
        Me.LabelUser.Text = "User"
        '
        'LabelPass
        '
        Me.LabelPass.AutoSize = True
        Me.LabelPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPass.Location = New System.Drawing.Point(133, 182)
        Me.LabelPass.Name = "LabelPass"
        Me.LabelPass.Size = New System.Drawing.Size(68, 16)
        Me.LabelPass.TabIndex = 98
        Me.LabelPass.Text = "Password"
        '
        'LabelDatabase
        '
        Me.LabelDatabase.AutoSize = True
        Me.LabelDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDatabase.Location = New System.Drawing.Point(133, 208)
        Me.LabelDatabase.Name = "LabelDatabase"
        Me.LabelDatabase.Size = New System.Drawing.Size(68, 16)
        Me.LabelDatabase.TabIndex = 99
        Me.LabelDatabase.Text = "Database"
        '
        'TextBoxServerDB
        '
        Me.TextBoxServerDB.Location = New System.Drawing.Point(207, 129)
        Me.TextBoxServerDB.Name = "TextBoxServerDB"
        Me.TextBoxServerDB.Size = New System.Drawing.Size(216, 20)
        Me.TextBoxServerDB.TabIndex = 100
        '
        'TextBoxDatabaseDB
        '
        Me.TextBoxDatabaseDB.Location = New System.Drawing.Point(207, 207)
        Me.TextBoxDatabaseDB.Name = "TextBoxDatabaseDB"
        Me.TextBoxDatabaseDB.Size = New System.Drawing.Size(216, 20)
        Me.TextBoxDatabaseDB.TabIndex = 101
        '
        'TextBoxPasswordDB
        '
        Me.TextBoxPasswordDB.Location = New System.Drawing.Point(207, 181)
        Me.TextBoxPasswordDB.Name = "TextBoxPasswordDB"
        Me.TextBoxPasswordDB.Size = New System.Drawing.Size(216, 20)
        Me.TextBoxPasswordDB.TabIndex = 102
        '
        'TextBoxUserDB
        '
        Me.TextBoxUserDB.Location = New System.Drawing.Point(207, 155)
        Me.TextBoxUserDB.Name = "TextBoxUserDB"
        Me.TextBoxUserDB.Size = New System.Drawing.Size(216, 20)
        Me.TextBoxUserDB.TabIndex = 103
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Orange
        Me.Button1.Location = New System.Drawing.Point(279, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 38)
        Me.Button1.TabIndex = 104
        Me.Button1.Text = "Modificar Conexion a BD"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(348, 334)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 105
        Me.Button2.Text = "DBfacu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ButtonDBcami
        '
        Me.ButtonDBcami.Location = New System.Drawing.Point(267, 334)
        Me.ButtonDBcami.Name = "ButtonDBcami"
        Me.ButtonDBcami.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDBcami.TabIndex = 106
        Me.ButtonDBcami.Text = "DBcami"
        Me.ButtonDBcami.UseVisualStyleBackColor = True
        '
        'CambiarBD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 376)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonDBcami)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxUserDB)
        Me.Controls.Add(Me.TextBoxPasswordDB)
        Me.Controls.Add(Me.TextBoxDatabaseDB)
        Me.Controls.Add(Me.TextBoxServerDB)
        Me.Controls.Add(Me.LabelDatabase)
        Me.Controls.Add(Me.LabelPass)
        Me.Controls.Add(Me.LabelUser)
        Me.Controls.Add(Me.LabelServer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelConsultaAlumnos)
        Me.Controls.Add(Me.LabelEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CambiarBD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelConsultaAlumnos As Label
    Friend WithEvents LabelEncabezado As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelServer As Label
    Friend WithEvents LabelUser As Label
    Friend WithEvents LabelPass As Label
    Friend WithEvents LabelDatabase As Label
    Friend WithEvents TextBoxServerDB As TextBox
    Friend WithEvents TextBoxDatabaseDB As TextBox
    Friend WithEvents TextBoxPasswordDB As TextBox
    Friend WithEvents TextBoxUserDB As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ButtonDBcami As Button
End Class
