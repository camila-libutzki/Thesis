<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VerMasAula
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LabelEncabezado = New System.Windows.Forms.Label()
        Me.ButtonsLector = New System.Windows.Forms.GroupBox()
        Me.RadioButtonOffline = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOnline = New System.Windows.Forms.RadioButton()
        Me.ButtonsAula = New System.Windows.Forms.GroupBox()
        Me.RadioButtonLibre = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOcupado = New System.Windows.Forms.RadioButton()
        Me.LabelConsultaAlumnos = New System.Windows.Forms.Label()
        Me.DataGridViewComisionesXAula = New System.Windows.Forms.DataGridView()
        Me.ButtonEliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TextBoxSerialLector = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNroAula = New System.Windows.Forms.TextBox()
        Me.ButtonmodificarDatos = New System.Windows.Forms.Button()
        Me.ButtonGuardarDatos = New System.Windows.Forms.Button()
        Me.LabelGuardarCambios = New System.Windows.Forms.Label()
        Me.ButtonPrestarAula = New System.Windows.Forms.Button()
        Me.ButtonDevolver = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxPrestada = New System.Windows.Forms.TextBox()
        Me.LabeCatedra = New System.Windows.Forms.Label()
        Me.LabelComision = New System.Windows.Forms.Label()
        Me.TextBoxCatedra = New System.Windows.Forms.TextBox()
        Me.TextBoxComision = New System.Windows.Forms.TextBox()
        Me.ButtonAgregarComision = New System.Windows.Forms.Button()
        Me.GroupBoxPrestada = New System.Windows.Forms.GroupBox()
        Me.TextBoxCarrera = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxEdificio = New System.Windows.Forms.TextBox()
        Me.ButtonsLector.SuspendLayout()
        Me.ButtonsAula.SuspendLayout()
        CType(Me.DataGridViewComisionesXAula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxPrestada.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        'ButtonsLector
        '
        Me.ButtonsLector.Controls.Add(Me.RadioButtonOffline)
        Me.ButtonsLector.Controls.Add(Me.RadioButtonOnline)
        Me.ButtonsLector.Location = New System.Drawing.Point(454, 19)
        Me.ButtonsLector.Name = "ButtonsLector"
        Me.ButtonsLector.Size = New System.Drawing.Size(126, 48)
        Me.ButtonsLector.TabIndex = 142
        Me.ButtonsLector.TabStop = False
        Me.ButtonsLector.Text = "Estado del Lector"
        '
        'RadioButtonOffline
        '
        Me.RadioButtonOffline.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButtonOffline.AutoSize = True
        Me.RadioButtonOffline.Enabled = False
        Me.RadioButtonOffline.Location = New System.Drawing.Point(59, 19)
        Me.RadioButtonOffline.Name = "RadioButtonOffline"
        Me.RadioButtonOffline.Size = New System.Drawing.Size(61, 23)
        Me.RadioButtonOffline.TabIndex = 1
        Me.RadioButtonOffline.Text = "OFFLINE"
        Me.RadioButtonOffline.UseVisualStyleBackColor = True
        '
        'RadioButtonOnline
        '
        Me.RadioButtonOnline.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButtonOnline.AutoSize = True
        Me.RadioButtonOnline.Enabled = False
        Me.RadioButtonOnline.Location = New System.Drawing.Point(6, 19)
        Me.RadioButtonOnline.Name = "RadioButtonOnline"
        Me.RadioButtonOnline.Size = New System.Drawing.Size(47, 23)
        Me.RadioButtonOnline.TabIndex = 0
        Me.RadioButtonOnline.Text = "Online"
        Me.RadioButtonOnline.UseVisualStyleBackColor = True
        '
        'ButtonsAula
        '
        Me.ButtonsAula.Controls.Add(Me.RadioButtonLibre)
        Me.ButtonsAula.Controls.Add(Me.RadioButtonOcupado)
        Me.ButtonsAula.Location = New System.Drawing.Point(315, 19)
        Me.ButtonsAula.Name = "ButtonsAula"
        Me.ButtonsAula.Size = New System.Drawing.Size(118, 48)
        Me.ButtonsAula.TabIndex = 141
        Me.ButtonsAula.TabStop = False
        Me.ButtonsAula.Text = "Estado del Aula"
        '
        'RadioButtonLibre
        '
        Me.RadioButtonLibre.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButtonLibre.AutoSize = True
        Me.RadioButtonLibre.Enabled = False
        Me.RadioButtonLibre.Location = New System.Drawing.Point(6, 19)
        Me.RadioButtonLibre.Name = "RadioButtonLibre"
        Me.RadioButtonLibre.Size = New System.Drawing.Size(40, 23)
        Me.RadioButtonLibre.TabIndex = 0
        Me.RadioButtonLibre.Text = "Libre"
        Me.RadioButtonLibre.UseVisualStyleBackColor = True
        '
        'RadioButtonOcupado
        '
        Me.RadioButtonOcupado.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButtonOcupado.AutoSize = True
        Me.RadioButtonOcupado.Enabled = False
        Me.RadioButtonOcupado.Location = New System.Drawing.Point(52, 19)
        Me.RadioButtonOcupado.Name = "RadioButtonOcupado"
        Me.RadioButtonOcupado.Size = New System.Drawing.Size(61, 23)
        Me.RadioButtonOcupado.TabIndex = 1
        Me.RadioButtonOcupado.Text = "Ocupada"
        Me.RadioButtonOcupado.UseVisualStyleBackColor = True
        '
        'LabelConsultaAlumnos
        '
        Me.LabelConsultaAlumnos.AutoSize = True
        Me.LabelConsultaAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelConsultaAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LabelConsultaAlumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConsultaAlumnos.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelConsultaAlumnos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LabelConsultaAlumnos.Location = New System.Drawing.Point(11, 65)
        Me.LabelConsultaAlumnos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelConsultaAlumnos.Name = "LabelConsultaAlumnos"
        Me.LabelConsultaAlumnos.Size = New System.Drawing.Size(147, 26)
        Me.LabelConsultaAlumnos.TabIndex = 140
        Me.LabelConsultaAlumnos.Text = "Datos del Aula"
        Me.LabelConsultaAlumnos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataGridViewComisionesXAula
        '
        Me.DataGridViewComisionesXAula.AllowUserToAddRows = False
        Me.DataGridViewComisionesXAula.AllowUserToDeleteRows = False
        Me.DataGridViewComisionesXAula.AllowUserToOrderColumns = True
        Me.DataGridViewComisionesXAula.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComisionesXAula.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewComisionesXAula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewComisionesXAula.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ButtonEliminar})
        Me.DataGridViewComisionesXAula.Location = New System.Drawing.Point(368, 237)
        Me.DataGridViewComisionesXAula.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewComisionesXAula.Name = "DataGridViewComisionesXAula"
        Me.DataGridViewComisionesXAula.ReadOnly = True
        Me.DataGridViewComisionesXAula.RowTemplate.Height = 24
        Me.DataGridViewComisionesXAula.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComisionesXAula.Size = New System.Drawing.Size(775, 361)
        Me.DataGridViewComisionesXAula.TabIndex = 139
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Book Antiqua", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.NullValue = "Eliminar"
        Me.ButtonEliminar.DefaultCellStyle = DataGridViewCellStyle2
        Me.ButtonEliminar.DividerWidth = 2
        Me.ButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonEliminar.HeaderText = "Seleccionar"
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.ReadOnly = True
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.Width = 82
        '
        'TextBoxSerialLector
        '
        Me.TextBoxSerialLector.Location = New System.Drawing.Point(122, 45)
        Me.TextBoxSerialLector.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxSerialLector.Name = "TextBoxSerialLector"
        Me.TextBoxSerialLector.ReadOnly = True
        Me.TextBoxSerialLector.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxSerialLector.TabIndex = 137
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 22)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 17)
        Me.Label6.TabIndex = 135
        Me.Label6.Text = "Número de Aula"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 46)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 17)
        Me.Label5.TabIndex = 134
        Me.Label5.Text = "Serial del Lector"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Edificio"
        '
        'TextBoxNroAula
        '
        Me.TextBoxNroAula.Location = New System.Drawing.Point(122, 21)
        Me.TextBoxNroAula.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxNroAula.Name = "TextBoxNroAula"
        Me.TextBoxNroAula.ReadOnly = True
        Me.TextBoxNroAula.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxNroAula.TabIndex = 130
        '
        'ButtonmodificarDatos
        '
        Me.ButtonmodificarDatos.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonmodificarDatos.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonmodificarDatos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonmodificarDatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonmodificarDatos.Location = New System.Drawing.Point(233, 170)
        Me.ButtonmodificarDatos.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonmodificarDatos.Name = "ButtonmodificarDatos"
        Me.ButtonmodificarDatos.Size = New System.Drawing.Size(112, 38)
        Me.ButtonmodificarDatos.TabIndex = 129
        Me.ButtonmodificarDatos.Text = "Modificar Datos"
        Me.ButtonmodificarDatos.UseVisualStyleBackColor = False
        Me.ButtonmodificarDatos.Visible = False
        '
        'ButtonGuardarDatos
        '
        Me.ButtonGuardarDatos.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonGuardarDatos.Enabled = False
        Me.ButtonGuardarDatos.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonGuardarDatos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonGuardarDatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonGuardarDatos.Location = New System.Drawing.Point(349, 170)
        Me.ButtonGuardarDatos.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonGuardarDatos.Name = "ButtonGuardarDatos"
        Me.ButtonGuardarDatos.Size = New System.Drawing.Size(112, 38)
        Me.ButtonGuardarDatos.TabIndex = 128
        Me.ButtonGuardarDatos.Text = "Guardar Datos"
        Me.ButtonGuardarDatos.UseVisualStyleBackColor = False
        Me.ButtonGuardarDatos.Visible = False
        '
        'LabelGuardarCambios
        '
        Me.LabelGuardarCambios.AutoSize = True
        Me.LabelGuardarCambios.BackColor = System.Drawing.Color.Moccasin
        Me.LabelGuardarCambios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGuardarCambios.Location = New System.Drawing.Point(465, 181)
        Me.LabelGuardarCambios.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelGuardarCambios.Name = "LabelGuardarCambios"
        Me.LabelGuardarCambios.Size = New System.Drawing.Size(365, 15)
        Me.LabelGuardarCambios.TabIndex = 143
        Me.LabelGuardarCambios.Text = "Los cambios serán aplicados al presionar el botón Guardar Datos"
        Me.LabelGuardarCambios.Visible = False
        '
        'ButtonPrestarAula
        '
        Me.ButtonPrestarAula.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonPrestarAula.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonPrestarAula.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonPrestarAula.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonPrestarAula.Location = New System.Drawing.Point(106, 42)
        Me.ButtonPrestarAula.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonPrestarAula.Name = "ButtonPrestarAula"
        Me.ButtonPrestarAula.Size = New System.Drawing.Size(99, 34)
        Me.ButtonPrestarAula.TabIndex = 144
        Me.ButtonPrestarAula.Text = "Prestar Aula"
        Me.ButtonPrestarAula.UseVisualStyleBackColor = False
        Me.ButtonPrestarAula.Visible = False
        '
        'ButtonDevolver
        '
        Me.ButtonDevolver.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonDevolver.Enabled = False
        Me.ButtonDevolver.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonDevolver.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonDevolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonDevolver.Location = New System.Drawing.Point(210, 169)
        Me.ButtonDevolver.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonDevolver.Name = "ButtonDevolver"
        Me.ButtonDevolver.Size = New System.Drawing.Size(116, 34)
        Me.ButtonDevolver.TabIndex = 146
        Me.ButtonDevolver.Text = "Liberar préstamo"
        Me.ButtonDevolver.UseVisualStyleBackColor = False
        Me.ButtonDevolver.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 19)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 148
        Me.Label4.Text = "Aula Prestada"
        '
        'TextBoxPrestada
        '
        Me.TextBoxPrestada.Location = New System.Drawing.Point(106, 18)
        Me.TextBoxPrestada.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxPrestada.Name = "TextBoxPrestada"
        Me.TextBoxPrestada.ReadOnly = True
        Me.TextBoxPrestada.Size = New System.Drawing.Size(52, 20)
        Me.TextBoxPrestada.TabIndex = 147
        Me.TextBoxPrestada.Text = "No"
        '
        'LabeCatedra
        '
        Me.LabeCatedra.AutoSize = True
        Me.LabeCatedra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.LabeCatedra.Location = New System.Drawing.Point(45, 122)
        Me.LabeCatedra.Name = "LabeCatedra"
        Me.LabeCatedra.Size = New System.Drawing.Size(56, 16)
        Me.LabeCatedra.TabIndex = 167
        Me.LabeCatedra.Text = "Cátedra"
        '
        'LabelComision
        '
        Me.LabelComision.AutoSize = True
        Me.LabelComision.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.LabelComision.Location = New System.Drawing.Point(37, 146)
        Me.LabelComision.Name = "LabelComision"
        Me.LabelComision.Size = New System.Drawing.Size(64, 16)
        Me.LabelComision.TabIndex = 166
        Me.LabelComision.Text = "Comisión"
        '
        'TextBoxCatedra
        '
        Me.TextBoxCatedra.Location = New System.Drawing.Point(106, 121)
        Me.TextBoxCatedra.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxCatedra.Name = "TextBoxCatedra"
        Me.TextBoxCatedra.ReadOnly = True
        Me.TextBoxCatedra.Size = New System.Drawing.Size(220, 20)
        Me.TextBoxCatedra.TabIndex = 168
        '
        'TextBoxComision
        '
        Me.TextBoxComision.Location = New System.Drawing.Point(106, 145)
        Me.TextBoxComision.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxComision.Name = "TextBoxComision"
        Me.TextBoxComision.ReadOnly = True
        Me.TextBoxComision.Size = New System.Drawing.Size(166, 20)
        Me.TextBoxComision.TabIndex = 169
        '
        'ButtonAgregarComision
        '
        Me.ButtonAgregarComision.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonAgregarComision.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonAgregarComision.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonAgregarComision.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonAgregarComision.Location = New System.Drawing.Point(1027, 195)
        Me.ButtonAgregarComision.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAgregarComision.Name = "ButtonAgregarComision"
        Me.ButtonAgregarComision.Size = New System.Drawing.Size(116, 38)
        Me.ButtonAgregarComision.TabIndex = 170
        Me.ButtonAgregarComision.Text = "Agregar Comisión"
        Me.ButtonAgregarComision.UseVisualStyleBackColor = False
        Me.ButtonAgregarComision.Visible = False
        '
        'GroupBoxPrestada
        '
        Me.GroupBoxPrestada.Controls.Add(Me.TextBoxCarrera)
        Me.GroupBoxPrestada.Controls.Add(Me.Label7)
        Me.GroupBoxPrestada.Controls.Add(Me.Label4)
        Me.GroupBoxPrestada.Controls.Add(Me.ButtonPrestarAula)
        Me.GroupBoxPrestada.Controls.Add(Me.TextBoxComision)
        Me.GroupBoxPrestada.Controls.Add(Me.ButtonDevolver)
        Me.GroupBoxPrestada.Controls.Add(Me.TextBoxCatedra)
        Me.GroupBoxPrestada.Controls.Add(Me.TextBoxPrestada)
        Me.GroupBoxPrestada.Controls.Add(Me.LabeCatedra)
        Me.GroupBoxPrestada.Controls.Add(Me.LabelComision)
        Me.GroupBoxPrestada.Location = New System.Drawing.Point(11, 261)
        Me.GroupBoxPrestada.Name = "GroupBoxPrestada"
        Me.GroupBoxPrestada.Size = New System.Drawing.Size(334, 213)
        Me.GroupBoxPrestada.TabIndex = 171
        Me.GroupBoxPrestada.TabStop = False
        Me.GroupBoxPrestada.Text = "Préstamo de Aula"
        '
        'TextBoxCarrera
        '
        Me.TextBoxCarrera.Location = New System.Drawing.Point(106, 97)
        Me.TextBoxCarrera.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxCarrera.Name = "TextBoxCarrera"
        Me.TextBoxCarrera.ReadOnly = True
        Me.TextBoxCarrera.Size = New System.Drawing.Size(166, 20)
        Me.TextBoxCarrera.TabIndex = 171
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(49, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 16)
        Me.Label7.TabIndex = 170
        Me.Label7.Text = "Carrera"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxEdificio)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBoxNroAula)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ButtonsLector)
        Me.GroupBox1.Controls.Add(Me.TextBoxSerialLector)
        Me.GroupBox1.Controls.Add(Me.ButtonsAula)
        Me.GroupBox1.Location = New System.Drawing.Point(233, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(588, 100)
        Me.GroupBox1.TabIndex = 172
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del Aula"
        '
        'TextBoxEdificio
        '
        Me.TextBoxEdificio.Location = New System.Drawing.Point(122, 70)
        Me.TextBoxEdificio.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxEdificio.Name = "TextBoxEdificio"
        Me.TextBoxEdificio.ReadOnly = True
        Me.TextBoxEdificio.Size = New System.Drawing.Size(157, 20)
        Me.TextBoxEdificio.TabIndex = 146
        '
        'VerMasAula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 598)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxPrestada)
        Me.Controls.Add(Me.ButtonAgregarComision)
        Me.Controls.Add(Me.LabelGuardarCambios)
        Me.Controls.Add(Me.LabelConsultaAlumnos)
        Me.Controls.Add(Me.DataGridViewComisionesXAula)
        Me.Controls.Add(Me.ButtonmodificarDatos)
        Me.Controls.Add(Me.ButtonGuardarDatos)
        Me.Controls.Add(Me.LabelEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "VerMasAula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ButtonsLector.ResumeLayout(False)
        Me.ButtonsLector.PerformLayout()
        Me.ButtonsAula.ResumeLayout(False)
        Me.ButtonsAula.PerformLayout()
        CType(Me.DataGridViewComisionesXAula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxPrestada.ResumeLayout(False)
        Me.GroupBoxPrestada.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelEncabezado As Label
    Friend WithEvents ButtonsLector As GroupBox
    Friend WithEvents RadioButtonOffline As RadioButton
    Friend WithEvents RadioButtonOnline As RadioButton
    Friend WithEvents ButtonsAula As GroupBox
    Friend WithEvents RadioButtonOcupado As RadioButton
    Friend WithEvents RadioButtonLibre As RadioButton
    Friend WithEvents LabelConsultaAlumnos As Label
    Friend WithEvents DataGridViewComisionesXAula As DataGridView
    Friend WithEvents TextBoxSerialLector As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNroAula As TextBox
    Friend WithEvents ButtonmodificarDatos As Button
    Friend WithEvents ButtonGuardarDatos As Button
    Friend WithEvents LabelGuardarCambios As Label
    Friend WithEvents ButtonPrestarAula As Button
    Friend WithEvents ButtonDevolver As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxPrestada As TextBox
    Friend WithEvents LabeCatedra As Label
    Friend WithEvents LabelComision As Label
    Friend WithEvents TextBoxCatedra As TextBox
    Friend WithEvents TextBoxComision As TextBox
    Friend WithEvents ButtonAgregarComision As Button
    Friend WithEvents ButtonEliminar As DataGridViewButtonColumn
    Friend WithEvents GroupBoxPrestada As GroupBox
    Friend WithEvents TextBoxCarrera As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxEdificio As TextBox
End Class
