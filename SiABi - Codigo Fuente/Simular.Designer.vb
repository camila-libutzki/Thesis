<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Simular
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ButtonGenerarPlanillas = New System.Windows.Forms.Button()
        Me.datePlanillas = New System.Windows.Forms.DateTimePicker()
        Me.LabelConsultaAlumnos = New System.Windows.Forms.Label()
        Me.LabelEncabezado = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.aulaProfesor = New System.Windows.Forms.ComboBox()
        Me.dateProfesor = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxHoraFinal = New System.Windows.Forms.TextBox()
        Me.ButtonHSalida = New System.Windows.Forms.RadioButton()
        Me.ButtonHEntrada = New System.Windows.Forms.RadioButton()
        Me.ComboBoxMin = New System.Windows.Forms.ComboBox()
        Me.ButtonHuellaProfe = New System.Windows.Forms.Button()
        Me.ComboBoxHora = New System.Windows.Forms.ComboBox()
        Me.legajoProfesor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.aulaAlumno = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dateAlumno = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxHoraFinalA = New System.Windows.Forms.TextBox()
        Me.ButtonHuellaAlumno = New System.Windows.Forms.Button()
        Me.ComboBoxMinA = New System.Windows.Forms.ComboBox()
        Me.legajoAlumno = New System.Windows.Forms.TextBox()
        Me.ComboBoxHoraA = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonVerTodosPlanilla = New System.Windows.Forms.Button()
        Me.DataGridViewPlanillas = New System.Windows.Forms.DataGridView()
        Me.ButtonVerMas = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dateBuscarPlanillas = New System.Windows.Forms.DateTimePicker()
        Me.ButtonBuscarFecha = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dateCierreCursada = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxhoraFinalCierre = New System.Windows.Forms.TextBox()
        Me.ComboBoxminutosSimCierre = New System.Windows.Forms.ComboBox()
        Me.ButtonSimularCierre = New System.Windows.Forms.Button()
        Me.ComboBoxhoraSimCierre = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridViewPlanillas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonGenerarPlanillas
        '
        Me.ButtonGenerarPlanillas.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonGenerarPlanillas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGenerarPlanillas.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonGenerarPlanillas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonGenerarPlanillas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonGenerarPlanillas.Location = New System.Drawing.Point(209, 18)
        Me.ButtonGenerarPlanillas.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonGenerarPlanillas.Name = "ButtonGenerarPlanillas"
        Me.ButtonGenerarPlanillas.Size = New System.Drawing.Size(106, 38)
        Me.ButtonGenerarPlanillas.TabIndex = 141
        Me.ButtonGenerarPlanillas.Text = "Generar Planillas"
        Me.ButtonGenerarPlanillas.UseVisualStyleBackColor = False
        '
        'datePlanillas
        '
        Me.datePlanillas.Location = New System.Drawing.Point(5, 25)
        Me.datePlanillas.Margin = New System.Windows.Forms.Padding(2)
        Me.datePlanillas.Name = "datePlanillas"
        Me.datePlanillas.Size = New System.Drawing.Size(196, 20)
        Me.datePlanillas.TabIndex = 197
        '
        'LabelConsultaAlumnos
        '
        Me.LabelConsultaAlumnos.AutoSize = True
        Me.LabelConsultaAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelConsultaAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LabelConsultaAlumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConsultaAlumnos.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelConsultaAlumnos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LabelConsultaAlumnos.Location = New System.Drawing.Point(11, 47)
        Me.LabelConsultaAlumnos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelConsultaAlumnos.Name = "LabelConsultaAlumnos"
        Me.LabelConsultaAlumnos.Size = New System.Drawing.Size(224, 26)
        Me.LabelConsultaAlumnos.TabIndex = 196
        Me.LabelConsultaAlumnos.Text = "Calendario Académico"
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
        Me.LabelEncabezado.Location = New System.Drawing.Point(371, 9)
        Me.LabelEncabezado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelEncabezado.Name = "LabelEncabezado"
        Me.LabelEncabezado.Size = New System.Drawing.Size(450, 24)
        Me.LabelEncabezado.TabIndex = 195
        Me.LabelEncabezado.Text = "UTN - FRLP - Sistema de Asistencia Biométrico"
        Me.LabelEncabezado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.datePlanillas)
        Me.GroupBox1.Controls.Add(Me.ButtonGenerarPlanillas)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 62)
        Me.GroupBox1.TabIndex = 199
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar fecha para generar las Planillas del día"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.aulaProfesor)
        Me.GroupBox2.Controls.Add(Me.dateProfesor)
        Me.GroupBox2.Controls.Add(Me.TextBoxHoraFinal)
        Me.GroupBox2.Controls.Add(Me.ButtonHSalida)
        Me.GroupBox2.Controls.Add(Me.ButtonHEntrada)
        Me.GroupBox2.Controls.Add(Me.ComboBoxMin)
        Me.GroupBox2.Controls.Add(Me.ButtonHuellaProfe)
        Me.GroupBox2.Controls.Add(Me.ComboBoxHora)
        Me.GroupBox2.Controls.Add(Me.legajoProfesor)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 154)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 163)
        Me.GroupBox2.TabIndex = 200
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Marcar entrada de un profesor a la clase"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1, 92)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 15)
        Me.Label4.TabIndex = 224
        Me.Label4.Text = "Horario"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 22)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 15)
        Me.Label7.TabIndex = 214
        Me.Label7.Text = "Fecha"
        '
        'aulaProfesor
        '
        Me.aulaProfesor.DisplayMember = "aula"
        Me.aulaProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.aulaProfesor.FormattingEnabled = True
        Me.aulaProfesor.Location = New System.Drawing.Point(55, 66)
        Me.aulaProfesor.Name = "aulaProfesor"
        Me.aulaProfesor.Size = New System.Drawing.Size(128, 21)
        Me.aulaProfesor.TabIndex = 222
        Me.aulaProfesor.ValueMember = "aula"
        '
        'dateProfesor
        '
        Me.dateProfesor.Location = New System.Drawing.Point(55, 18)
        Me.dateProfesor.Margin = New System.Windows.Forms.Padding(2)
        Me.dateProfesor.Name = "dateProfesor"
        Me.dateProfesor.Size = New System.Drawing.Size(196, 20)
        Me.dateProfesor.TabIndex = 198
        '
        'TextBoxHoraFinal
        '
        Me.TextBoxHoraFinal.Location = New System.Drawing.Point(139, 91)
        Me.TextBoxHoraFinal.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxHoraFinal.Name = "TextBoxHoraFinal"
        Me.TextBoxHoraFinal.ReadOnly = True
        Me.TextBoxHoraFinal.Size = New System.Drawing.Size(44, 20)
        Me.TextBoxHoraFinal.TabIndex = 208
        '
        'ButtonHSalida
        '
        Me.ButtonHSalida.AutoSize = True
        Me.ButtonHSalida.Location = New System.Drawing.Point(55, 138)
        Me.ButtonHSalida.Name = "ButtonHSalida"
        Me.ButtonHSalida.Size = New System.Drawing.Size(78, 17)
        Me.ButtonHSalida.TabIndex = 212
        Me.ButtonHSalida.Text = "Hora salida"
        Me.ButtonHSalida.UseVisualStyleBackColor = True
        '
        'ButtonHEntrada
        '
        Me.ButtonHEntrada.AutoSize = True
        Me.ButtonHEntrada.Checked = True
        Me.ButtonHEntrada.Location = New System.Drawing.Point(55, 118)
        Me.ButtonHEntrada.Name = "ButtonHEntrada"
        Me.ButtonHEntrada.Size = New System.Drawing.Size(87, 17)
        Me.ButtonHEntrada.TabIndex = 211
        Me.ButtonHEntrada.TabStop = True
        Me.ButtonHEntrada.Text = "Hora entrada"
        Me.ButtonHEntrada.UseVisualStyleBackColor = True
        '
        'ComboBoxMin
        '
        Me.ComboBoxMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMin.FormattingEnabled = True
        Me.ComboBoxMin.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.ComboBoxMin.Location = New System.Drawing.Point(96, 91)
        Me.ComboBoxMin.Name = "ComboBoxMin"
        Me.ComboBoxMin.Size = New System.Drawing.Size(38, 21)
        Me.ComboBoxMin.TabIndex = 213
        '
        'ButtonHuellaProfe
        '
        Me.ButtonHuellaProfe.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonHuellaProfe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonHuellaProfe.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonHuellaProfe.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonHuellaProfe.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonHuellaProfe.Location = New System.Drawing.Point(209, 122)
        Me.ButtonHuellaProfe.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonHuellaProfe.Name = "ButtonHuellaProfe"
        Me.ButtonHuellaProfe.Size = New System.Drawing.Size(103, 36)
        Me.ButtonHuellaProfe.TabIndex = 209
        Me.ButtonHuellaProfe.Text = "Simular huella"
        Me.ButtonHuellaProfe.UseVisualStyleBackColor = False
        '
        'ComboBoxHora
        '
        Me.ComboBoxHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxHora.FormattingEnabled = True
        Me.ComboBoxHora.Items.AddRange(New Object() {"08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.ComboBoxHora.Location = New System.Drawing.Point(54, 91)
        Me.ComboBoxHora.Name = "ComboBoxHora"
        Me.ComboBoxHora.Size = New System.Drawing.Size(38, 21)
        Me.ComboBoxHora.TabIndex = 212
        '
        'legajoProfesor
        '
        Me.legajoProfesor.Location = New System.Drawing.Point(55, 42)
        Me.legajoProfesor.Margin = New System.Windows.Forms.Padding(2)
        Me.legajoProfesor.Name = "legajoProfesor"
        Me.legajoProfesor.Size = New System.Drawing.Size(128, 20)
        Me.legajoProfesor.TabIndex = 201
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 203
        Me.Label2.Text = "Legajo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 67)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 15)
        Me.Label3.TabIndex = 204
        Me.Label3.Text = "Aula"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.aulaAlumno)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.dateAlumno)
        Me.GroupBox3.Controls.Add(Me.TextBoxHoraFinalA)
        Me.GroupBox3.Controls.Add(Me.ButtonHuellaAlumno)
        Me.GroupBox3.Controls.Add(Me.ComboBoxMinA)
        Me.GroupBox3.Controls.Add(Me.legajoAlumno)
        Me.GroupBox3.Controls.Add(Me.ComboBoxHoraA)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 325)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(319, 119)
        Me.GroupBox3.TabIndex = 211
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Marcar la asistencia de un alumno a la clase"
        '
        'aulaAlumno
        '
        Me.aulaAlumno.DisplayMember = "aula"
        Me.aulaAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.aulaAlumno.FormattingEnabled = True
        Me.aulaAlumno.Location = New System.Drawing.Point(54, 66)
        Me.aulaAlumno.Name = "aulaAlumno"
        Me.aulaAlumno.Size = New System.Drawing.Size(128, 21)
        Me.aulaAlumno.TabIndex = 223
        Me.aulaAlumno.ValueMember = "aula"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 22)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 15)
        Me.Label8.TabIndex = 216
        Me.Label8.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 92)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 219
        Me.Label1.Text = "Horario"
        '
        'dateAlumno
        '
        Me.dateAlumno.Location = New System.Drawing.Point(54, 18)
        Me.dateAlumno.Margin = New System.Windows.Forms.Padding(2)
        Me.dateAlumno.Name = "dateAlumno"
        Me.dateAlumno.Size = New System.Drawing.Size(196, 20)
        Me.dateAlumno.TabIndex = 215
        '
        'TextBoxHoraFinalA
        '
        Me.TextBoxHoraFinalA.Location = New System.Drawing.Point(138, 91)
        Me.TextBoxHoraFinalA.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxHoraFinalA.Name = "TextBoxHoraFinalA"
        Me.TextBoxHoraFinalA.ReadOnly = True
        Me.TextBoxHoraFinalA.Size = New System.Drawing.Size(44, 20)
        Me.TextBoxHoraFinalA.TabIndex = 215
        '
        'ButtonHuellaAlumno
        '
        Me.ButtonHuellaAlumno.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonHuellaAlumno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonHuellaAlumno.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonHuellaAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonHuellaAlumno.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonHuellaAlumno.Location = New System.Drawing.Point(208, 75)
        Me.ButtonHuellaAlumno.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonHuellaAlumno.Name = "ButtonHuellaAlumno"
        Me.ButtonHuellaAlumno.Size = New System.Drawing.Size(103, 36)
        Me.ButtonHuellaAlumno.TabIndex = 215
        Me.ButtonHuellaAlumno.Text = "Simular huella"
        Me.ButtonHuellaAlumno.UseVisualStyleBackColor = False
        '
        'ComboBoxMinA
        '
        Me.ComboBoxMinA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMinA.FormattingEnabled = True
        Me.ComboBoxMinA.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.ComboBoxMinA.Location = New System.Drawing.Point(96, 91)
        Me.ComboBoxMinA.Name = "ComboBoxMinA"
        Me.ComboBoxMinA.Size = New System.Drawing.Size(38, 21)
        Me.ComboBoxMinA.TabIndex = 217
        '
        'legajoAlumno
        '
        Me.legajoAlumno.Location = New System.Drawing.Point(54, 42)
        Me.legajoAlumno.Margin = New System.Windows.Forms.Padding(2)
        Me.legajoAlumno.Name = "legajoAlumno"
        Me.legajoAlumno.Size = New System.Drawing.Size(128, 20)
        Me.legajoAlumno.TabIndex = 201
        '
        'ComboBoxHoraA
        '
        Me.ComboBoxHoraA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxHoraA.FormattingEnabled = True
        Me.ComboBoxHoraA.Items.AddRange(New Object() {"08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.ComboBoxHoraA.Location = New System.Drawing.Point(54, 91)
        Me.ComboBoxHoraA.Name = "ComboBoxHoraA"
        Me.ComboBoxHoraA.Size = New System.Drawing.Size(38, 21)
        Me.ComboBoxHoraA.TabIndex = 216
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 43)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 203
        Me.Label5.Text = "Legajo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 67)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 15)
        Me.Label6.TabIndex = 204
        Me.Label6.Text = "Aula"
        '
        'ButtonVerTodosPlanilla
        '
        Me.ButtonVerTodosPlanilla.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonVerTodosPlanilla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonVerTodosPlanilla.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonVerTodosPlanilla.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonVerTodosPlanilla.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonVerTodosPlanilla.Location = New System.Drawing.Point(1078, 104)
        Me.ButtonVerTodosPlanilla.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonVerTodosPlanilla.Name = "ButtonVerTodosPlanilla"
        Me.ButtonVerTodosPlanilla.Size = New System.Drawing.Size(99, 36)
        Me.ButtonVerTodosPlanilla.TabIndex = 213
        Me.ButtonVerTodosPlanilla.Text = "Ver Todas las Planillas"
        Me.ButtonVerTodosPlanilla.UseVisualStyleBackColor = False
        '
        'DataGridViewPlanillas
        '
        Me.DataGridViewPlanillas.AllowUserToAddRows = False
        Me.DataGridViewPlanillas.AllowUserToDeleteRows = False
        Me.DataGridViewPlanillas.AllowUserToOrderColumns = True
        Me.DataGridViewPlanillas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPlanillas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewPlanillas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPlanillas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ButtonVerMas})
        Me.DataGridViewPlanillas.Location = New System.Drawing.Point(367, 144)
        Me.DataGridViewPlanillas.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewPlanillas.Name = "DataGridViewPlanillas"
        Me.DataGridViewPlanillas.ReadOnly = True
        Me.DataGridViewPlanillas.RowTemplate.Height = 24
        Me.DataGridViewPlanillas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPlanillas.Size = New System.Drawing.Size(810, 420)
        Me.DataGridViewPlanillas.TabIndex = 212
        '
        'ButtonVerMas
        '
        Me.ButtonVerMas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Book Antiqua", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.NullValue = "Ver más"
        Me.ButtonVerMas.DefaultCellStyle = DataGridViewCellStyle2
        Me.ButtonVerMas.DividerWidth = 2
        Me.ButtonVerMas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonVerMas.HeaderText = "Seleccionar"
        Me.ButtonVerMas.Name = "ButtonVerMas"
        Me.ButtonVerMas.ReadOnly = True
        Me.ButtonVerMas.Text = "Ver más"
        Me.ButtonVerMas.Width = 82
        '
        'dateBuscarPlanillas
        '
        Me.dateBuscarPlanillas.Location = New System.Drawing.Point(5, 23)
        Me.dateBuscarPlanillas.Margin = New System.Windows.Forms.Padding(2)
        Me.dateBuscarPlanillas.Name = "dateBuscarPlanillas"
        Me.dateBuscarPlanillas.Size = New System.Drawing.Size(196, 20)
        Me.dateBuscarPlanillas.TabIndex = 198
        '
        'ButtonBuscarFecha
        '
        Me.ButtonBuscarFecha.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonBuscarFecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBuscarFecha.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonBuscarFecha.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonBuscarFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonBuscarFecha.Location = New System.Drawing.Point(205, 14)
        Me.ButtonBuscarFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonBuscarFecha.Name = "ButtonBuscarFecha"
        Me.ButtonBuscarFecha.Size = New System.Drawing.Size(99, 36)
        Me.ButtonBuscarFecha.TabIndex = 215
        Me.ButtonBuscarFecha.Text = "Buscar en esa Fecha"
        Me.ButtonBuscarFecha.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.dateCierreCursada)
        Me.GroupBox4.Controls.Add(Me.TextBoxhoraFinalCierre)
        Me.GroupBox4.Controls.Add(Me.ComboBoxminutosSimCierre)
        Me.GroupBox4.Controls.Add(Me.ButtonSimularCierre)
        Me.GroupBox4.Controls.Add(Me.ComboBoxhoraSimCierre)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 452)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(319, 97)
        Me.GroupBox4.TabIndex = 216
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detectar clases no cerradas dentro del horario y cerrarlas"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1, 43)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 15)
        Me.Label10.TabIndex = 224
        Me.Label10.Text = "Horario"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 22)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 15)
        Me.Label9.TabIndex = 214
        Me.Label9.Text = "Fecha"
        '
        'dateCierreCursada
        '
        Me.dateCierreCursada.Location = New System.Drawing.Point(54, 18)
        Me.dateCierreCursada.Margin = New System.Windows.Forms.Padding(2)
        Me.dateCierreCursada.Name = "dateCierreCursada"
        Me.dateCierreCursada.Size = New System.Drawing.Size(196, 20)
        Me.dateCierreCursada.TabIndex = 198
        '
        'TextBoxhoraFinalCierre
        '
        Me.TextBoxhoraFinalCierre.Location = New System.Drawing.Point(139, 42)
        Me.TextBoxhoraFinalCierre.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxhoraFinalCierre.Name = "TextBoxhoraFinalCierre"
        Me.TextBoxhoraFinalCierre.ReadOnly = True
        Me.TextBoxhoraFinalCierre.Size = New System.Drawing.Size(44, 20)
        Me.TextBoxhoraFinalCierre.TabIndex = 208
        '
        'ComboBoxminutosSimCierre
        '
        Me.ComboBoxminutosSimCierre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxminutosSimCierre.FormattingEnabled = True
        Me.ComboBoxminutosSimCierre.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.ComboBoxminutosSimCierre.Location = New System.Drawing.Point(96, 42)
        Me.ComboBoxminutosSimCierre.Name = "ComboBoxminutosSimCierre"
        Me.ComboBoxminutosSimCierre.Size = New System.Drawing.Size(38, 21)
        Me.ComboBoxminutosSimCierre.TabIndex = 213
        '
        'ButtonSimularCierre
        '
        Me.ButtonSimularCierre.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonSimularCierre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSimularCierre.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonSimularCierre.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonSimularCierre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonSimularCierre.Location = New System.Drawing.Point(208, 56)
        Me.ButtonSimularCierre.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonSimularCierre.Name = "ButtonSimularCierre"
        Me.ButtonSimularCierre.Size = New System.Drawing.Size(103, 36)
        Me.ButtonSimularCierre.TabIndex = 209
        Me.ButtonSimularCierre.Text = "Simular Cierre Planillas"
        Me.ButtonSimularCierre.UseVisualStyleBackColor = False
        '
        'ComboBoxhoraSimCierre
        '
        Me.ComboBoxhoraSimCierre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxhoraSimCierre.FormattingEnabled = True
        Me.ComboBoxhoraSimCierre.Items.AddRange(New Object() {"08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.ComboBoxhoraSimCierre.Location = New System.Drawing.Point(54, 42)
        Me.ComboBoxhoraSimCierre.Name = "ComboBoxhoraSimCierre"
        Me.ComboBoxhoraSimCierre.Size = New System.Drawing.Size(38, 21)
        Me.ComboBoxhoraSimCierre.TabIndex = 212
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dateBuscarPlanillas)
        Me.GroupBox5.Controls.Add(Me.ButtonBuscarFecha)
        Me.GroupBox5.Location = New System.Drawing.Point(367, 84)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(310, 56)
        Me.GroupBox5.TabIndex = 217
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Mostrar las planillas de cursada de una fecha"
        '
        'Simular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 568)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ButtonVerTodosPlanilla)
        Me.Controls.Add(Me.DataGridViewPlanillas)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelConsultaAlumnos)
        Me.Controls.Add(Me.LabelEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Simular"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridViewPlanillas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonGenerarPlanillas As Button
    Friend WithEvents datePlanillas As DateTimePicker
    Friend WithEvents LabelConsultaAlumnos As Label
    Friend WithEvents LabelEncabezado As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents legajoProfesor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents legajoAlumno As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBoxHora As ComboBox
    Friend WithEvents ComboBoxMin As ComboBox
    Friend WithEvents TextBoxHoraFinal As TextBox
    Friend WithEvents ButtonHEntrada As RadioButton
    Friend WithEvents ButtonHSalida As RadioButton
    Friend WithEvents ButtonHuellaProfe As Button
    Friend WithEvents TextBoxHoraFinalA As TextBox
    Friend WithEvents ButtonHuellaAlumno As Button
    Friend WithEvents ComboBoxMinA As ComboBox
    Friend WithEvents ComboBoxHoraA As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonVerTodosPlanilla As Button
    Friend WithEvents DataGridViewPlanillas As DataGridView
    Friend WithEvents ButtonVerMas As DataGridViewButtonColumn
    Friend WithEvents dateBuscarPlanillas As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents dateProfesor As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents dateAlumno As DateTimePicker
    Friend WithEvents aulaAlumno As ComboBox
    Friend WithEvents aulaProfesor As ComboBox
    Friend WithEvents ButtonBuscarFecha As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dateCierreCursada As DateTimePicker
    Friend WithEvents TextBoxhoraFinalCierre As TextBox
    Friend WithEvents ComboBoxminutosSimCierre As ComboBox
    Friend WithEvents ButtonSimularCierre As Button
    Friend WithEvents ComboBoxhoraSimCierre As ComboBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
End Class
