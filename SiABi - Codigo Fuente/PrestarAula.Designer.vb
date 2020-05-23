<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrestarAula
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrestarAula))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxHoraFinal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxMin = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxHora = New System.Windows.Forms.ComboBox()
        Me.datePrestarAula = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxCarrera = New System.Windows.Forms.ComboBox()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonGuardarCambios = New System.Windows.Forms.Button()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxComision = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxCatedra = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxHoraFinal)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ComboBoxMin)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ComboBoxHora)
        Me.GroupBox1.Controls.Add(Me.datePrestarAula)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 56)
        Me.GroupBox1.TabIndex = 192
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Simular Fecha y Hora actuales para validar contra HoraInicioOficial"
        '
        'TextBoxHoraFinal
        '
        Me.TextBoxHoraFinal.Location = New System.Drawing.Point(402, 22)
        Me.TextBoxHoraFinal.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxHoraFinal.Name = "TextBoxHoraFinal"
        Me.TextBoxHoraFinal.ReadOnly = True
        Me.TextBoxHoraFinal.Size = New System.Drawing.Size(44, 20)
        Me.TextBoxHoraFinal.TabIndex = 215
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(273, 24)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 17)
        Me.Label7.TabIndex = 219
        Me.Label7.Text = "Hora"
        '
        'ComboBoxMin
        '
        Me.ComboBoxMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMin.FormattingEnabled = True
        Me.ComboBoxMin.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.ComboBoxMin.Location = New System.Drawing.Point(359, 22)
        Me.ComboBoxMin.Name = "ComboBoxMin"
        Me.ComboBoxMin.Size = New System.Drawing.Size(38, 21)
        Me.ComboBoxMin.TabIndex = 217
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 24)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 17)
        Me.Label6.TabIndex = 218
        Me.Label6.Text = "Fecha"
        '
        'ComboBoxHora
        '
        Me.ComboBoxHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxHora.FormattingEnabled = True
        Me.ComboBoxHora.Items.AddRange(New Object() {"08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.ComboBoxHora.Location = New System.Drawing.Point(317, 22)
        Me.ComboBoxHora.Name = "ComboBoxHora"
        Me.ComboBoxHora.Size = New System.Drawing.Size(38, 21)
        Me.ComboBoxHora.TabIndex = 216
        '
        'datePrestarAula
        '
        Me.datePrestarAula.Location = New System.Drawing.Point(56, 22)
        Me.datePrestarAula.Margin = New System.Windows.Forms.Padding(2)
        Me.datePrestarAula.Name = "datePrestarAula"
        Me.datePrestarAula.Size = New System.Drawing.Size(196, 20)
        Me.datePrestarAula.TabIndex = 214
        '
        'ComboBoxCarrera
        '
        Me.ComboBoxCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCarrera.FormattingEnabled = True
        Me.ComboBoxCarrera.Items.AddRange(New Object() {"Sistemas", "Industrial", "Mecanica", "Quimica", "Electrica"})
        Me.ComboBoxCarrera.Location = New System.Drawing.Point(215, 166)
        Me.ComboBoxCarrera.Name = "ComboBoxCarrera"
        Me.ComboBoxCarrera.Size = New System.Drawing.Size(131, 21)
        Me.ComboBoxCarrera.TabIndex = 191
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.Location = New System.Drawing.Point(48, 24)
        Me.LabelTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(470, 17)
        Me.LabelTitulo.TabIndex = 190
        Me.LabelTitulo.Text = "Las aulas se pueden prestar 15 minutos antes de la Hora de Inicio Oficial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(154, 167)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 189
        Me.Label4.Text = "Carrera"
        '
        'ButtonGuardarCambios
        '
        Me.ButtonGuardarCambios.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonGuardarCambios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGuardarCambios.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonGuardarCambios.Location = New System.Drawing.Point(336, 264)
        Me.ButtonGuardarCambios.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonGuardarCambios.Name = "ButtonGuardarCambios"
        Me.ButtonGuardarCambios.Size = New System.Drawing.Size(98, 38)
        Me.ButtonGuardarCambios.TabIndex = 188
        Me.ButtonGuardarCambios.Text = "Prestar Aula"
        Me.ButtonGuardarCambios.UseVisualStyleBackColor = False
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCancelar.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonCancelar.Location = New System.Drawing.Point(148, 286)
        Me.ButtonCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(86, 38)
        Me.ButtonCancelar.TabIndex = 187
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(145, 221)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 186
        Me.Label3.Text = "Comision"
        '
        'ComboBoxComision
        '
        Me.ComboBoxComision.DisplayMember = "nroComision"
        Me.ComboBoxComision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxComision.FormattingEnabled = True
        Me.ComboBoxComision.Location = New System.Drawing.Point(215, 220)
        Me.ComboBoxComision.Name = "ComboBoxComision"
        Me.ComboBoxComision.Size = New System.Drawing.Size(128, 21)
        Me.ComboBoxComision.TabIndex = 185
        Me.ComboBoxComision.ValueMember = "nroComision"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 133)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 184
        Me.Label1.Text = "Prestar a:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(154, 194)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 183
        Me.Label2.Text = "Cátedra"
        '
        'ComboBoxCatedra
        '
        Me.ComboBoxCatedra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCatedra.FormattingEnabled = True
        Me.ComboBoxCatedra.Location = New System.Drawing.Point(215, 193)
        Me.ComboBoxCatedra.Name = "ComboBoxCatedra"
        Me.ComboBoxCatedra.Size = New System.Drawing.Size(219, 21)
        Me.ComboBoxCatedra.TabIndex = 182
        '
        'PrestarAula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(572, 353)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBoxCarrera)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonGuardarCambios)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxComision)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxCatedra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PrestarAula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxHoraFinal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxMin As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBoxHora As ComboBox
    Friend WithEvents datePrestarAula As DateTimePicker
    Friend WithEvents ComboBoxCarrera As ComboBox
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonGuardarCambios As Button
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxComision As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxCatedra As ComboBox
End Class
