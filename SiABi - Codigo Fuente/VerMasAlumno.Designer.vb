<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VerMasAlumno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerMasAlumno))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LabelEncabezado = New System.Windows.Forms.Label()
        Me.ButtonModificarHuellas = New System.Windows.Forms.Button()
        Me.LabelInscripto = New System.Windows.Forms.Label()
        Me.LabelDedoMano2 = New System.Windows.Forms.Label()
        Me.LabelMano2 = New System.Windows.Forms.Label()
        Me.LabelDedoMano1 = New System.Windows.Forms.Label()
        Me.LabelMano1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EstadoRegularidad = New System.Windows.Forms.TextBox()
        Me.ComboBoxCarreraAlumno = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxLegajoAlumno = New System.Windows.Forms.TextBox()
        Me.TextBoxDNIAlumno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxApAlumno = New System.Windows.Forms.TextBox()
        Me.TextBoxNomAlumno = New System.Windows.Forms.TextBox()
        Me.PictureHuella2 = New System.Windows.Forms.PictureBox()
        Me.PictureHuella1 = New System.Windows.Forms.PictureBox()
        Me.PictureAlumno = New System.Windows.Forms.PictureBox()
        Me.DataGridViewDatosMaterias = New System.Windows.Forms.DataGridView()
        Me.ButtonElegirPersona = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.LabelConsultaAlumnos = New System.Windows.Forms.Label()
        Me.ButtonReincorporar = New System.Windows.Forms.Button()
        Me.ComboBoxAñoCursada = New System.Windows.Forms.ComboBox()
        Me.ButtonVerTodos = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonVerPlanilla = New System.Windows.Forms.Button()
        Me.TextBoxSelectedMateria = New System.Windows.Forms.TextBox()
        Me.TextBoxEstadoCursada = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxMaterias = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonMaterias = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAñoCursada = New System.Windows.Forms.RadioButton()
        Me.ButtonMostrar = New System.Windows.Forms.Button()
        CType(Me.PictureHuella2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureHuella1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureAlumno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewDatosMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
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
        Me.LabelEncabezado.TabIndex = 88
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
        Me.ButtonModificarHuellas.Location = New System.Drawing.Point(248, 373)
        Me.ButtonModificarHuellas.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonModificarHuellas.Name = "ButtonModificarHuellas"
        Me.ButtonModificarHuellas.Size = New System.Drawing.Size(106, 38)
        Me.ButtonModificarHuellas.TabIndex = 140
        Me.ButtonModificarHuellas.Text = "Modificar huellas"
        Me.ButtonModificarHuellas.UseVisualStyleBackColor = False
        Me.ButtonModificarHuellas.Visible = False
        '
        'LabelInscripto
        '
        Me.LabelInscripto.AutoSize = True
        Me.LabelInscripto.BackColor = System.Drawing.Color.Moccasin
        Me.LabelInscripto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInscripto.Location = New System.Drawing.Point(738, 93)
        Me.LabelInscripto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelInscripto.Name = "LabelInscripto"
        Me.LabelInscripto.Size = New System.Drawing.Size(417, 15)
        Me.LabelInscripto.TabIndex = 139
        Me.LabelInscripto.Text = "El alumno no está inscripto a ninguna materia para la carrera seleccionada"
        Me.LabelInscripto.Visible = False
        '
        'LabelDedoMano2
        '
        Me.LabelDedoMano2.AutoSize = True
        Me.LabelDedoMano2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDedoMano2.Location = New System.Drawing.Point(244, 35)
        Me.LabelDedoMano2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDedoMano2.Name = "LabelDedoMano2"
        Me.LabelDedoMano2.Size = New System.Drawing.Size(40, 15)
        Me.LabelDedoMano2.TabIndex = 138
        Me.LabelDedoMano2.Text = "Dedo:"
        '
        'LabelMano2
        '
        Me.LabelMano2.AutoSize = True
        Me.LabelMano2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMano2.Location = New System.Drawing.Point(244, 18)
        Me.LabelMano2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMano2.Name = "LabelMano2"
        Me.LabelMano2.Size = New System.Drawing.Size(42, 15)
        Me.LabelMano2.TabIndex = 137
        Me.LabelMano2.Text = "Mano:"
        '
        'LabelDedoMano1
        '
        Me.LabelDedoMano1.AutoSize = True
        Me.LabelDedoMano1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDedoMano1.Location = New System.Drawing.Point(77, 35)
        Me.LabelDedoMano1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDedoMano1.Name = "LabelDedoMano1"
        Me.LabelDedoMano1.Size = New System.Drawing.Size(40, 15)
        Me.LabelDedoMano1.TabIndex = 136
        Me.LabelDedoMano1.Text = "Dedo:"
        '
        'LabelMano1
        '
        Me.LabelMano1.AutoSize = True
        Me.LabelMano1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMano1.Location = New System.Drawing.Point(77, 18)
        Me.LabelMano1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMano1.Name = "LabelMano1"
        Me.LabelMano1.Size = New System.Drawing.Size(42, 15)
        Me.LabelMano1.TabIndex = 135
        Me.LabelMano1.Text = "Mano:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 140)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 15)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Alumno regular en Carrera"
        '
        'EstadoRegularidad
        '
        Me.EstadoRegularidad.Location = New System.Drawing.Point(165, 139)
        Me.EstadoRegularidad.Margin = New System.Windows.Forms.Padding(2)
        Me.EstadoRegularidad.Name = "EstadoRegularidad"
        Me.EstadoRegularidad.ReadOnly = True
        Me.EstadoRegularidad.Size = New System.Drawing.Size(59, 20)
        Me.EstadoRegularidad.TabIndex = 131
        '
        'ComboBoxCarreraAlumno
        '
        Me.ComboBoxCarreraAlumno.AccessibleDescription = "Ingrese tipo de Usuario"
        Me.ComboBoxCarreraAlumno.AccessibleName = "Ingrese tipo de Usuario"
        Me.ComboBoxCarreraAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCarreraAlumno.FormattingEnabled = True
        Me.ComboBoxCarreraAlumno.Location = New System.Drawing.Point(62, 114)
        Me.ComboBoxCarreraAlumno.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxCarreraAlumno.Name = "ComboBoxCarreraAlumno"
        Me.ComboBoxCarreraAlumno.Size = New System.Drawing.Size(162, 21)
        Me.ComboBoxCarreraAlumno.TabIndex = 130
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 115)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 15)
        Me.Label8.TabIndex = 129
        Me.Label8.Text = "Carrera"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 91)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 15)
        Me.Label9.TabIndex = 128
        Me.Label9.Text = "Legajo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 67)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 15)
        Me.Label10.TabIndex = 127
        Me.Label10.Text = "DNI"
        '
        'TextBoxLegajoAlumno
        '
        Me.TextBoxLegajoAlumno.Location = New System.Drawing.Point(62, 90)
        Me.TextBoxLegajoAlumno.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxLegajoAlumno.Name = "TextBoxLegajoAlumno"
        Me.TextBoxLegajoAlumno.ReadOnly = True
        Me.TextBoxLegajoAlumno.Size = New System.Drawing.Size(162, 20)
        Me.TextBoxLegajoAlumno.TabIndex = 126
        '
        'TextBoxDNIAlumno
        '
        Me.TextBoxDNIAlumno.Location = New System.Drawing.Point(62, 66)
        Me.TextBoxDNIAlumno.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxDNIAlumno.Name = "TextBoxDNIAlumno"
        Me.TextBoxDNIAlumno.ReadOnly = True
        Me.TextBoxDNIAlumno.Size = New System.Drawing.Size(162, 20)
        Me.TextBoxDNIAlumno.TabIndex = 125
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 43)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Nombre"
        '
        'TextBoxApAlumno
        '
        Me.TextBoxApAlumno.Location = New System.Drawing.Point(62, 42)
        Me.TextBoxApAlumno.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxApAlumno.Name = "TextBoxApAlumno"
        Me.TextBoxApAlumno.ReadOnly = True
        Me.TextBoxApAlumno.Size = New System.Drawing.Size(162, 20)
        Me.TextBoxApAlumno.TabIndex = 122
        '
        'TextBoxNomAlumno
        '
        Me.TextBoxNomAlumno.Location = New System.Drawing.Point(62, 18)
        Me.TextBoxNomAlumno.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxNomAlumno.Name = "TextBoxNomAlumno"
        Me.TextBoxNomAlumno.ReadOnly = True
        Me.TextBoxNomAlumno.Size = New System.Drawing.Size(162, 20)
        Me.TextBoxNomAlumno.TabIndex = 121
        '
        'PictureHuella2
        '
        Me.PictureHuella2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureHuella2.Image = CType(resources.GetObject("PictureHuella2.Image"), System.Drawing.Image)
        Me.PictureHuella2.InitialImage = CType(resources.GetObject("PictureHuella2.InitialImage"), System.Drawing.Image)
        Me.PictureHuella2.Location = New System.Drawing.Point(177, 18)
        Me.PictureHuella2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureHuella2.Name = "PictureHuella2"
        Me.PictureHuella2.Size = New System.Drawing.Size(63, 63)
        Me.PictureHuella2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureHuella2.TabIndex = 120
        Me.PictureHuella2.TabStop = False
        '
        'PictureHuella1
        '
        Me.PictureHuella1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureHuella1.Image = CType(resources.GetObject("PictureHuella1.Image"), System.Drawing.Image)
        Me.PictureHuella1.InitialImage = CType(resources.GetObject("PictureHuella1.InitialImage"), System.Drawing.Image)
        Me.PictureHuella1.Location = New System.Drawing.Point(10, 18)
        Me.PictureHuella1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureHuella1.Name = "PictureHuella1"
        Me.PictureHuella1.Size = New System.Drawing.Size(63, 63)
        Me.PictureHuella1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureHuella1.TabIndex = 119
        Me.PictureHuella1.TabStop = False
        '
        'PictureAlumno
        '
        Me.PictureAlumno.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureAlumno.Image = CType(resources.GetObject("PictureAlumno.Image"), System.Drawing.Image)
        Me.PictureAlumno.InitialImage = CType(resources.GetObject("PictureAlumno.InitialImage"), System.Drawing.Image)
        Me.PictureAlumno.Location = New System.Drawing.Point(11, 93)
        Me.PictureAlumno.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureAlumno.Name = "PictureAlumno"
        Me.PictureAlumno.Size = New System.Drawing.Size(130, 130)
        Me.PictureAlumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureAlumno.TabIndex = 118
        Me.PictureAlumno.TabStop = False
        '
        'DataGridViewDatosMaterias
        '
        Me.DataGridViewDatosMaterias.AllowUserToAddRows = False
        Me.DataGridViewDatosMaterias.AllowUserToDeleteRows = False
        Me.DataGridViewDatosMaterias.AllowUserToOrderColumns = True
        Me.DataGridViewDatosMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewDatosMaterias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewDatosMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDatosMaterias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ButtonElegirPersona})
        Me.DataGridViewDatosMaterias.Location = New System.Drawing.Point(401, 164)
        Me.DataGridViewDatosMaterias.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewDatosMaterias.Name = "DataGridViewDatosMaterias"
        Me.DataGridViewDatosMaterias.ReadOnly = True
        Me.DataGridViewDatosMaterias.RowTemplate.Height = 24
        Me.DataGridViewDatosMaterias.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewDatosMaterias.Size = New System.Drawing.Size(777, 429)
        Me.DataGridViewDatosMaterias.TabIndex = 116
        '
        'ButtonElegirPersona
        '
        Me.ButtonElegirPersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Book Antiqua", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.NullValue = "Elegir"
        Me.ButtonElegirPersona.DefaultCellStyle = DataGridViewCellStyle4
        Me.ButtonElegirPersona.DividerWidth = 2
        Me.ButtonElegirPersona.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonElegirPersona.HeaderText = "Seleccionar"
        Me.ButtonElegirPersona.Name = "ButtonElegirPersona"
        Me.ButtonElegirPersona.ReadOnly = True
        Me.ButtonElegirPersona.Text = "Elegir"
        Me.ButtonElegirPersona.Width = 82
        '
        'LabelConsultaAlumnos
        '
        Me.LabelConsultaAlumnos.AutoSize = True
        Me.LabelConsultaAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelConsultaAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LabelConsultaAlumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConsultaAlumnos.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelConsultaAlumnos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LabelConsultaAlumnos.Location = New System.Drawing.Point(11, 46)
        Me.LabelConsultaAlumnos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelConsultaAlumnos.Name = "LabelConsultaAlumnos"
        Me.LabelConsultaAlumnos.Size = New System.Drawing.Size(177, 26)
        Me.LabelConsultaAlumnos.TabIndex = 115
        Me.LabelConsultaAlumnos.Text = "Datos del Alumno"
        Me.LabelConsultaAlumnos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonReincorporar
        '
        Me.ButtonReincorporar.BackColor = System.Drawing.Color.Gold
        Me.ButtonReincorporar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonReincorporar.Enabled = False
        Me.ButtonReincorporar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonReincorporar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonReincorporar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonReincorporar.Location = New System.Drawing.Point(228, 60)
        Me.ButtonReincorporar.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonReincorporar.Name = "ButtonReincorporar"
        Me.ButtonReincorporar.Size = New System.Drawing.Size(104, 30)
        Me.ButtonReincorporar.TabIndex = 177
        Me.ButtonReincorporar.Text = "ReIncorporar"
        Me.ButtonReincorporar.UseVisualStyleBackColor = False
        Me.ButtonReincorporar.Visible = False
        '
        'ComboBoxAñoCursada
        '
        Me.ComboBoxAñoCursada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAñoCursada.Enabled = False
        Me.ComboBoxAñoCursada.FormattingEnabled = True
        Me.ComboBoxAñoCursada.Location = New System.Drawing.Point(138, 19)
        Me.ComboBoxAñoCursada.Name = "ComboBoxAñoCursada"
        Me.ComboBoxAñoCursada.Size = New System.Drawing.Size(86, 21)
        Me.ComboBoxAñoCursada.TabIndex = 179
        '
        'ButtonVerTodos
        '
        Me.ButtonVerTodos.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonVerTodos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonVerTodos.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonVerTodos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonVerTodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonVerTodos.Location = New System.Drawing.Point(1056, 124)
        Me.ButtonVerTodos.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonVerTodos.Name = "ButtonVerTodos"
        Me.ButtonVerTodos.Size = New System.Drawing.Size(121, 33)
        Me.ButtonVerTodos.TabIndex = 180
        Me.ButtonVerTodos.Text = "Ver todos los años"
        Me.ButtonVerTodos.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxNomAlumno)
        Me.GroupBox1.Controls.Add(Me.TextBoxApAlumno)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxDNIAlumno)
        Me.GroupBox1.Controls.Add(Me.TextBoxLegajoAlumno)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ComboBoxCarreraAlumno)
        Me.GroupBox1.Controls.Add(Me.EstadoRegularidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(146, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 164)
        Me.GroupBox1.TabIndex = 181
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Alumno"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureHuella1)
        Me.GroupBox2.Controls.Add(Me.PictureHuella2)
        Me.GroupBox2.Controls.Add(Me.LabelMano1)
        Me.GroupBox2.Controls.Add(Me.LabelDedoMano1)
        Me.GroupBox2.Controls.Add(Me.LabelMano2)
        Me.GroupBox2.Controls.Add(Me.LabelDedoMano2)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 281)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(358, 87)
        Me.GroupBox2.TabIndex = 182
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de las huellas"
        '
        'ButtonVerPlanilla
        '
        Me.ButtonVerPlanilla.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonVerPlanilla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonVerPlanilla.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonVerPlanilla.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonVerPlanilla.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonVerPlanilla.Location = New System.Drawing.Point(228, 18)
        Me.ButtonVerPlanilla.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonVerPlanilla.Name = "ButtonVerPlanilla"
        Me.ButtonVerPlanilla.Size = New System.Drawing.Size(152, 38)
        Me.ButtonVerPlanilla.TabIndex = 117
        Me.ButtonVerPlanilla.Text = "Ver Planilla de Asistencias"
        Me.ButtonVerPlanilla.UseVisualStyleBackColor = False
        '
        'TextBoxSelectedMateria
        '
        Me.TextBoxSelectedMateria.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxSelectedMateria.Location = New System.Drawing.Point(9, 28)
        Me.TextBoxSelectedMateria.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxSelectedMateria.Name = "TextBoxSelectedMateria"
        Me.TextBoxSelectedMateria.ReadOnly = True
        Me.TextBoxSelectedMateria.Size = New System.Drawing.Size(215, 20)
        Me.TextBoxSelectedMateria.TabIndex = 133
        '
        'TextBoxEstadoCursada
        '
        Me.TextBoxEstadoCursada.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxEstadoCursada.Location = New System.Drawing.Point(135, 66)
        Me.TextBoxEstadoCursada.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxEstadoCursada.Name = "TextBoxEstadoCursada"
        Me.TextBoxEstadoCursada.ReadOnly = True
        Me.TextBoxEstadoCursada.Size = New System.Drawing.Size(89, 20)
        Me.TextBoxEstadoCursada.TabIndex = 183
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(7, 67)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 15)
        Me.Label5.TabIndex = 184
        Me.Label5.Text = "Estado de la Cursada"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBoxSelectedMateria)
        Me.GroupBox3.Controls.Add(Me.TextBoxEstadoCursada)
        Me.GroupBox3.Controls.Add(Me.ButtonReincorporar)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.ButtonVerPlanilla)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 496)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(385, 97)
        Me.GroupBox3.TabIndex = 185
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Materia seleccionada de la grilla"
        '
        'ComboBoxMaterias
        '
        Me.ComboBoxMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMaterias.Enabled = False
        Me.ComboBoxMaterias.FormattingEnabled = True
        Me.ComboBoxMaterias.Location = New System.Drawing.Point(9, 43)
        Me.ComboBoxMaterias.Name = "ComboBoxMaterias"
        Me.ComboBoxMaterias.Size = New System.Drawing.Size(215, 21)
        Me.ComboBoxMaterias.TabIndex = 187
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButtonMaterias)
        Me.GroupBox4.Controls.Add(Me.RadioButtonAñoCursada)
        Me.GroupBox4.Controls.Add(Me.ComboBoxAñoCursada)
        Me.GroupBox4.Controls.Add(Me.ComboBoxMaterias)
        Me.GroupBox4.Location = New System.Drawing.Point(401, 88)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(332, 71)
        Me.GroupBox4.TabIndex = 188
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Mostrar cursadas según:"
        '
        'RadioButtonMaterias
        '
        Me.RadioButtonMaterias.AutoSize = True
        Me.RadioButtonMaterias.Location = New System.Drawing.Point(230, 44)
        Me.RadioButtonMaterias.Name = "RadioButtonMaterias"
        Me.RadioButtonMaterias.Size = New System.Drawing.Size(65, 17)
        Me.RadioButtonMaterias.TabIndex = 189
        Me.RadioButtonMaterias.Text = "Materias"
        Me.RadioButtonMaterias.UseVisualStyleBackColor = True
        '
        'RadioButtonAñoCursada
        '
        Me.RadioButtonAñoCursada.AutoSize = True
        Me.RadioButtonAñoCursada.Checked = True
        Me.RadioButtonAñoCursada.Location = New System.Drawing.Point(230, 20)
        Me.RadioButtonAñoCursada.Name = "RadioButtonAñoCursada"
        Me.RadioButtonAñoCursada.Size = New System.Drawing.Size(100, 17)
        Me.RadioButtonAñoCursada.TabIndex = 188
        Me.RadioButtonAñoCursada.TabStop = True
        Me.RadioButtonAñoCursada.Text = "Año de cursada"
        Me.RadioButtonAñoCursada.UseVisualStyleBackColor = True
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonMostrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMostrar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonMostrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonMostrar.Location = New System.Drawing.Point(738, 124)
        Me.ButtonMostrar.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(79, 33)
        Me.ButtonMostrar.TabIndex = 189
        Me.ButtonMostrar.Text = "Mostrar"
        Me.ButtonMostrar.UseVisualStyleBackColor = False
        '
        'VerMasAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 596)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonMostrar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonVerTodos)
        Me.Controls.Add(Me.ButtonModificarHuellas)
        Me.Controls.Add(Me.LabelInscripto)
        Me.Controls.Add(Me.PictureAlumno)
        Me.Controls.Add(Me.DataGridViewDatosMaterias)
        Me.Controls.Add(Me.LabelConsultaAlumnos)
        Me.Controls.Add(Me.LabelEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "VerMasAlumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.PictureHuella2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureHuella1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureAlumno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewDatosMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelEncabezado As Label
    Friend WithEvents ButtonModificarHuellas As Button
    Friend WithEvents LabelInscripto As Label
    Friend WithEvents LabelDedoMano2 As Label
    Friend WithEvents LabelMano2 As Label
    Friend WithEvents LabelDedoMano1 As Label
    Friend WithEvents LabelMano1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EstadoRegularidad As TextBox
    Friend WithEvents ComboBoxCarreraAlumno As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxLegajoAlumno As TextBox
    Friend WithEvents TextBoxDNIAlumno As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxApAlumno As TextBox
    Friend WithEvents TextBoxNomAlumno As TextBox
    Friend WithEvents PictureHuella2 As PictureBox
    Friend WithEvents PictureHuella1 As PictureBox
    Friend WithEvents PictureAlumno As PictureBox
    Friend WithEvents DataGridViewDatosMaterias As DataGridView
    Friend WithEvents ButtonElegirPersona As DataGridViewButtonColumn
    Friend WithEvents LabelConsultaAlumnos As Label
    Friend WithEvents ButtonReincorporar As Button
    Friend WithEvents ComboBoxAñoCursada As ComboBox
    Friend WithEvents ButtonVerTodos As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonVerPlanilla As Button
    Friend WithEvents TextBoxSelectedMateria As TextBox
    Friend WithEvents TextBoxEstadoCursada As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboBoxMaterias As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RadioButtonMaterias As RadioButton
    Friend WithEvents RadioButtonAñoCursada As RadioButton
    Friend WithEvents ButtonMostrar As Button
End Class
