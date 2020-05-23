<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerMasProfesor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerMasProfesor))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LabelEncabezado = New System.Windows.Forms.Label()
        Me.ButtonModificarHuellas = New System.Windows.Forms.Button()
        Me.LabelDedoMano2 = New System.Windows.Forms.Label()
        Me.LabelMano2 = New System.Windows.Forms.Label()
        Me.LabelDedoMano1 = New System.Windows.Forms.Label()
        Me.LabelMano1 = New System.Windows.Forms.Label()
        Me.TextBoxSelectedMateria = New System.Windows.Forms.TextBox()
        Me.ComboBoxCarreraProf = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxLegajoProf = New System.Windows.Forms.TextBox()
        Me.TextBoxDNIProf = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxApProf = New System.Windows.Forms.TextBox()
        Me.TextBoxNomProf = New System.Windows.Forms.TextBox()
        Me.PictureHuella1 = New System.Windows.Forms.PictureBox()
        Me.PictureProfesor = New System.Windows.Forms.PictureBox()
        Me.ButtonVerPlanilla = New System.Windows.Forms.Button()
        Me.DataGridViewdatosProfe = New System.Windows.Forms.DataGridView()
        Me.ButtonElegirPersona = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.LabelConsultaProfesor = New System.Windows.Forms.Label()
        Me.PictureHuella2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabelCarrerasProfe = New System.Windows.Forms.Label()
        CType(Me.PictureHuella1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureProfesor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewdatosProfe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureHuella2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        Me.LabelEncabezado.Location = New System.Drawing.Point(423, 9)
        Me.LabelEncabezado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelEncabezado.Name = "LabelEncabezado"
        Me.LabelEncabezado.Size = New System.Drawing.Size(450, 24)
        Me.LabelEncabezado.TabIndex = 89
        Me.LabelEncabezado.Text = "UTN - FRLP - Sistema de Asistencia Biométrico"
        Me.LabelEncabezado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonModificarHuellas
        '
        Me.ButtonModificarHuellas.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonModificarHuellas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonModificarHuellas.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonModificarHuellas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonModificarHuellas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonModificarHuellas.Location = New System.Drawing.Point(249, 391)
        Me.ButtonModificarHuellas.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonModificarHuellas.Name = "ButtonModificarHuellas"
        Me.ButtonModificarHuellas.Size = New System.Drawing.Size(106, 38)
        Me.ButtonModificarHuellas.TabIndex = 189
        Me.ButtonModificarHuellas.Text = "Modificar huellas"
        Me.ButtonModificarHuellas.UseVisualStyleBackColor = False
        Me.ButtonModificarHuellas.Visible = False
        '
        'LabelDedoMano2
        '
        Me.LabelDedoMano2.AutoSize = True
        Me.LabelDedoMano2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.LabelDedoMano2.Location = New System.Drawing.Point(257, 35)
        Me.LabelDedoMano2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDedoMano2.Name = "LabelDedoMano2"
        Me.LabelDedoMano2.Size = New System.Drawing.Size(40, 15)
        Me.LabelDedoMano2.TabIndex = 187
        Me.LabelDedoMano2.Text = "Dedo:"
        '
        'LabelMano2
        '
        Me.LabelMano2.AutoSize = True
        Me.LabelMano2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.LabelMano2.Location = New System.Drawing.Point(257, 18)
        Me.LabelMano2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMano2.Name = "LabelMano2"
        Me.LabelMano2.Size = New System.Drawing.Size(42, 15)
        Me.LabelMano2.TabIndex = 186
        Me.LabelMano2.Text = "Mano:"
        '
        'LabelDedoMano1
        '
        Me.LabelDedoMano1.AutoSize = True
        Me.LabelDedoMano1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.LabelDedoMano1.Location = New System.Drawing.Point(77, 35)
        Me.LabelDedoMano1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDedoMano1.Name = "LabelDedoMano1"
        Me.LabelDedoMano1.Size = New System.Drawing.Size(40, 15)
        Me.LabelDedoMano1.TabIndex = 185
        Me.LabelDedoMano1.Text = "Dedo:"
        '
        'LabelMano1
        '
        Me.LabelMano1.AutoSize = True
        Me.LabelMano1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.LabelMano1.Location = New System.Drawing.Point(77, 18)
        Me.LabelMano1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMano1.Name = "LabelMano1"
        Me.LabelMano1.Size = New System.Drawing.Size(42, 15)
        Me.LabelMano1.TabIndex = 184
        Me.LabelMano1.Text = "Mano:"
        '
        'TextBoxSelectedMateria
        '
        Me.TextBoxSelectedMateria.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxSelectedMateria.Location = New System.Drawing.Point(5, 18)
        Me.TextBoxSelectedMateria.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxSelectedMateria.Name = "TextBoxSelectedMateria"
        Me.TextBoxSelectedMateria.ReadOnly = True
        Me.TextBoxSelectedMateria.Size = New System.Drawing.Size(249, 20)
        Me.TextBoxSelectedMateria.TabIndex = 182
        '
        'ComboBoxCarreraProf
        '
        Me.ComboBoxCarreraProf.AccessibleDescription = "Ingrese tipo de Usuario"
        Me.ComboBoxCarreraProf.AccessibleName = "Ingrese tipo de Usuario"
        Me.ComboBoxCarreraProf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCarreraProf.FormattingEnabled = True
        Me.ComboBoxCarreraProf.Location = New System.Drawing.Point(66, 114)
        Me.ComboBoxCarreraProf.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxCarreraProf.Name = "ComboBoxCarreraProf"
        Me.ComboBoxCarreraProf.Size = New System.Drawing.Size(158, 21)
        Me.ComboBoxCarreraProf.TabIndex = 181
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(14, 115)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 15)
        Me.Label8.TabIndex = 180
        Me.Label8.Text = "Carrera"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(17, 91)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 15)
        Me.Label9.TabIndex = 179
        Me.Label9.Text = "Legajo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(34, 67)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 15)
        Me.Label10.TabIndex = 178
        Me.Label10.Text = "DNI"
        '
        'TextBoxLegajoProf
        '
        Me.TextBoxLegajoProf.Location = New System.Drawing.Point(66, 90)
        Me.TextBoxLegajoProf.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxLegajoProf.Name = "TextBoxLegajoProf"
        Me.TextBoxLegajoProf.ReadOnly = True
        Me.TextBoxLegajoProf.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxLegajoProf.TabIndex = 177
        '
        'TextBoxDNIProf
        '
        Me.TextBoxDNIProf.Location = New System.Drawing.Point(66, 66)
        Me.TextBoxDNIProf.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxDNIProf.Name = "TextBoxDNIProf"
        Me.TextBoxDNIProf.ReadOnly = True
        Me.TextBoxDNIProf.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxDNIProf.TabIndex = 176
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(11, 43)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 175
        Me.Label3.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(10, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 174
        Me.Label2.Text = "Nombre"
        '
        'TextBoxApProf
        '
        Me.TextBoxApProf.Location = New System.Drawing.Point(66, 42)
        Me.TextBoxApProf.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxApProf.Name = "TextBoxApProf"
        Me.TextBoxApProf.ReadOnly = True
        Me.TextBoxApProf.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxApProf.TabIndex = 173
        '
        'TextBoxNomProf
        '
        Me.TextBoxNomProf.Location = New System.Drawing.Point(66, 18)
        Me.TextBoxNomProf.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxNomProf.Name = "TextBoxNomProf"
        Me.TextBoxNomProf.ReadOnly = True
        Me.TextBoxNomProf.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxNomProf.TabIndex = 172
        '
        'PictureHuella1
        '
        Me.PictureHuella1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureHuella1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureHuella1.Image = CType(resources.GetObject("PictureHuella1.Image"), System.Drawing.Image)
        Me.PictureHuella1.InitialImage = CType(resources.GetObject("PictureHuella1.InitialImage"), System.Drawing.Image)
        Me.PictureHuella1.Location = New System.Drawing.Point(10, 18)
        Me.PictureHuella1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureHuella1.Name = "PictureHuella1"
        Me.PictureHuella1.Size = New System.Drawing.Size(63, 63)
        Me.PictureHuella1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureHuella1.TabIndex = 171
        Me.PictureHuella1.TabStop = False
        '
        'PictureProfesor
        '
        Me.PictureProfesor.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureProfesor.Image = CType(resources.GetObject("PictureProfesor.Image"), System.Drawing.Image)
        Me.PictureProfesor.InitialImage = CType(resources.GetObject("PictureProfesor.InitialImage"), System.Drawing.Image)
        Me.PictureProfesor.Location = New System.Drawing.Point(11, 99)
        Me.PictureProfesor.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureProfesor.Name = "PictureProfesor"
        Me.PictureProfesor.Size = New System.Drawing.Size(130, 130)
        Me.PictureProfesor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureProfesor.TabIndex = 170
        Me.PictureProfesor.TabStop = False
        '
        'ButtonVerPlanilla
        '
        Me.ButtonVerPlanilla.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonVerPlanilla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonVerPlanilla.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonVerPlanilla.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonVerPlanilla.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonVerPlanilla.Location = New System.Drawing.Point(91, 42)
        Me.ButtonVerPlanilla.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonVerPlanilla.Name = "ButtonVerPlanilla"
        Me.ButtonVerPlanilla.Size = New System.Drawing.Size(163, 38)
        Me.ButtonVerPlanilla.TabIndex = 169
        Me.ButtonVerPlanilla.Text = "Ver Planilla de Asistencias"
        Me.ButtonVerPlanilla.UseVisualStyleBackColor = False
        '
        'DataGridViewdatosProfe
        '
        Me.DataGridViewdatosProfe.AllowUserToAddRows = False
        Me.DataGridViewdatosProfe.AllowUserToDeleteRows = False
        Me.DataGridViewdatosProfe.AllowUserToOrderColumns = True
        Me.DataGridViewdatosProfe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewdatosProfe.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewdatosProfe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewdatosProfe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ButtonElegirPersona})
        Me.DataGridViewdatosProfe.Location = New System.Drawing.Point(389, 99)
        Me.DataGridViewdatosProfe.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewdatosProfe.Name = "DataGridViewdatosProfe"
        Me.DataGridViewdatosProfe.ReadOnly = True
        Me.DataGridViewdatosProfe.RowTemplate.Height = 24
        Me.DataGridViewdatosProfe.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewdatosProfe.Size = New System.Drawing.Size(788, 458)
        Me.DataGridViewdatosProfe.TabIndex = 168
        '
        'ButtonElegirPersona
        '
        Me.ButtonElegirPersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Book Antiqua", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.NullValue = "Elegir"
        Me.ButtonElegirPersona.DefaultCellStyle = DataGridViewCellStyle2
        Me.ButtonElegirPersona.DividerWidth = 2
        Me.ButtonElegirPersona.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonElegirPersona.HeaderText = "Seleccionar"
        Me.ButtonElegirPersona.Name = "ButtonElegirPersona"
        Me.ButtonElegirPersona.ReadOnly = True
        Me.ButtonElegirPersona.Text = "Elegir"
        Me.ButtonElegirPersona.Width = 82
        '
        'LabelConsultaProfesor
        '
        Me.LabelConsultaProfesor.AutoSize = True
        Me.LabelConsultaProfesor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelConsultaProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LabelConsultaProfesor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConsultaProfesor.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelConsultaProfesor.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LabelConsultaProfesor.Location = New System.Drawing.Point(11, 52)
        Me.LabelConsultaProfesor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelConsultaProfesor.Name = "LabelConsultaProfesor"
        Me.LabelConsultaProfesor.Size = New System.Drawing.Size(183, 26)
        Me.LabelConsultaProfesor.TabIndex = 167
        Me.LabelConsultaProfesor.Text = "Datos del Profesor"
        Me.LabelConsultaProfesor.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureHuella2
        '
        Me.PictureHuella2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureHuella2.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureHuella2.Image = CType(resources.GetObject("PictureHuella2.Image"), System.Drawing.Image)
        Me.PictureHuella2.InitialImage = CType(resources.GetObject("PictureHuella2.InitialImage"), System.Drawing.Image)
        Me.PictureHuella2.Location = New System.Drawing.Point(190, 18)
        Me.PictureHuella2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureHuella2.Name = "PictureHuella2"
        Me.PictureHuella2.Size = New System.Drawing.Size(63, 63)
        Me.PictureHuella2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureHuella2.TabIndex = 190
        Me.PictureHuella2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxNomProf)
        Me.GroupBox1.Controls.Add(Me.TextBoxApProf)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxDNIProf)
        Me.GroupBox1.Controls.Add(Me.TextBoxLegajoProf)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ComboBoxCarreraProf)
        Me.GroupBox1.Location = New System.Drawing.Point(146, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 142)
        Me.GroupBox1.TabIndex = 193
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Profesor"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureHuella1)
        Me.GroupBox2.Controls.Add(Me.LabelMano1)
        Me.GroupBox2.Controls.Add(Me.PictureHuella2)
        Me.GroupBox2.Controls.Add(Me.LabelDedoMano1)
        Me.GroupBox2.Controls.Add(Me.LabelMano2)
        Me.GroupBox2.Controls.Add(Me.LabelDedoMano2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 299)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(358, 87)
        Me.GroupBox2.TabIndex = 194
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de las huellas"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBoxSelectedMateria)
        Me.GroupBox3.Controls.Add(Me.ButtonVerPlanilla)
        Me.GroupBox3.Location = New System.Drawing.Point(92, 470)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(263, 86)
        Me.GroupBox3.TabIndex = 195
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Materia seleccionada de la grilla"
        '
        'LabelCarrerasProfe
        '
        Me.LabelCarrerasProfe.AutoSize = True
        Me.LabelCarrerasProfe.BackColor = System.Drawing.Color.Moccasin
        Me.LabelCarrerasProfe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCarrerasProfe.Location = New System.Drawing.Point(116, 248)
        Me.LabelCarrerasProfe.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelCarrerasProfe.Name = "LabelCarrerasProfe"
        Me.LabelCarrerasProfe.Size = New System.Drawing.Size(262, 15)
        Me.LabelCarrerasProfe.TabIndex = 196
        Me.LabelCarrerasProfe.Text = "El profesor no está asociado a ninguna carrera"
        Me.LabelCarrerasProfe.Visible = False
        '
        'VerMasProfesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 568)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelCarrerasProfe)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonModificarHuellas)
        Me.Controls.Add(Me.PictureProfesor)
        Me.Controls.Add(Me.DataGridViewdatosProfe)
        Me.Controls.Add(Me.LabelConsultaProfesor)
        Me.Controls.Add(Me.LabelEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "VerMasProfesor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.PictureHuella1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureProfesor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewdatosProfe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureHuella2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelEncabezado As Label
    Friend WithEvents ButtonModificarHuellas As Button
    Friend WithEvents LabelDedoMano2 As Label
    Friend WithEvents LabelMano2 As Label
    Friend WithEvents LabelDedoMano1 As Label
    Friend WithEvents LabelMano1 As Label
    Friend WithEvents TextBoxSelectedMateria As TextBox
    Friend WithEvents ComboBoxCarreraProf As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxLegajoProf As TextBox
    Friend WithEvents TextBoxDNIProf As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxApProf As TextBox
    Friend WithEvents TextBoxNomProf As TextBox
    Friend WithEvents PictureHuella1 As PictureBox
    Friend WithEvents PictureProfesor As PictureBox
    Friend WithEvents ButtonVerPlanilla As Button
    Friend WithEvents DataGridViewdatosProfe As DataGridView
    Friend WithEvents ButtonElegirPersona As DataGridViewButtonColumn
    Friend WithEvents LabelConsultaProfesor As Label
    Friend WithEvents PictureHuella2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LabelCarrerasProfe As Label
End Class
