<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Asistencias
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
        Me.LabelConsultaAlumnos = New System.Windows.Forms.Label()
        Me.DataGridViewAsistencias = New System.Windows.Forms.DataGridView()
        Me.ButtonElegirPersona = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ButtonResetParametros = New System.Windows.Forms.Button()
        Me.ComboBoxCatedra = New System.Windows.Forms.ComboBox()
        Me.DateAsistencias = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxTipoPersona = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxComision = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxCarrera = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFecha = New System.Windows.Forms.CheckBox()
        Me.CheckBoxComision = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCatedra = New System.Windows.Forms.CheckBox()
        Me.ComboBoxCarrera = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridViewAsistencias, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LabelEncabezado.TabIndex = 88
        Me.LabelEncabezado.Text = "UTN - FRLP - Sistema de Asistencia Biométrico"
        Me.LabelEncabezado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelConsultaAlumnos
        '
        Me.LabelConsultaAlumnos.AutoSize = True
        Me.LabelConsultaAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelConsultaAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LabelConsultaAlumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConsultaAlumnos.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelConsultaAlumnos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LabelConsultaAlumnos.Location = New System.Drawing.Point(12, 37)
        Me.LabelConsultaAlumnos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelConsultaAlumnos.Name = "LabelConsultaAlumnos"
        Me.LabelConsultaAlumnos.Size = New System.Drawing.Size(227, 26)
        Me.LabelConsultaAlumnos.TabIndex = 92
        Me.LabelConsultaAlumnos.Text = "Reporte de Asistencias"
        Me.LabelConsultaAlumnos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataGridViewAsistencias
        '
        Me.DataGridViewAsistencias.AllowUserToAddRows = False
        Me.DataGridViewAsistencias.AllowUserToDeleteRows = False
        Me.DataGridViewAsistencias.AllowUserToOrderColumns = True
        Me.DataGridViewAsistencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewAsistencias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAsistencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ButtonElegirPersona})
        Me.DataGridViewAsistencias.Location = New System.Drawing.Point(6, 144)
        Me.DataGridViewAsistencias.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewAsistencias.Name = "DataGridViewAsistencias"
        Me.DataGridViewAsistencias.ReadOnly = True
        Me.DataGridViewAsistencias.RowTemplate.Height = 24
        Me.DataGridViewAsistencias.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewAsistencias.Size = New System.Drawing.Size(1179, 460)
        Me.DataGridViewAsistencias.TabIndex = 136
        '
        'ButtonElegirPersona
        '
        Me.ButtonElegirPersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Book Antiqua", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.NullValue = "Ver Info."
        Me.ButtonElegirPersona.DefaultCellStyle = DataGridViewCellStyle2
        Me.ButtonElegirPersona.DividerWidth = 2
        Me.ButtonElegirPersona.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonElegirPersona.HeaderText = "Ver Info"
        Me.ButtonElegirPersona.Name = "ButtonElegirPersona"
        Me.ButtonElegirPersona.ReadOnly = True
        Me.ButtonElegirPersona.Text = "Mas Info."
        Me.ButtonElegirPersona.Width = 60
        '
        'ButtonResetParametros
        '
        Me.ButtonResetParametros.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonResetParametros.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonResetParametros.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonResetParametros.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonResetParametros.Location = New System.Drawing.Point(943, 101)
        Me.ButtonResetParametros.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonResetParametros.Name = "ButtonResetParametros"
        Me.ButtonResetParametros.Size = New System.Drawing.Size(107, 38)
        Me.ButtonResetParametros.TabIndex = 157
        Me.ButtonResetParametros.Text = "Resetear Criterios"
        Me.ButtonResetParametros.UseVisualStyleBackColor = False
        '
        'ComboBoxCatedra
        '
        Me.ComboBoxCatedra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCatedra.FormattingEnabled = True
        Me.ComboBoxCatedra.Location = New System.Drawing.Point(116, 42)
        Me.ComboBoxCatedra.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxCatedra.Name = "ComboBoxCatedra"
        Me.ComboBoxCatedra.Size = New System.Drawing.Size(227, 21)
        Me.ComboBoxCatedra.TabIndex = 156
        '
        'DateAsistencias
        '
        Me.DateAsistencias.Location = New System.Drawing.Point(474, 42)
        Me.DateAsistencias.Margin = New System.Windows.Forms.Padding(2)
        Me.DateAsistencias.Name = "DateAsistencias"
        Me.DateAsistencias.Size = New System.Drawing.Size(216, 20)
        Me.DateAsistencias.TabIndex = 155
        '
        'ComboBoxTipoPersona
        '
        Me.ComboBoxTipoPersona.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ComboBoxTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTipoPersona.FormattingEnabled = True
        Me.ComboBoxTipoPersona.Items.AddRange(New Object() {"Alumnos", "Profesores"})
        Me.ComboBoxTipoPersona.Location = New System.Drawing.Point(5, 42)
        Me.ComboBoxTipoPersona.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxTipoPersona.Name = "ComboBoxTipoPersona"
        Me.ComboBoxTipoPersona.Size = New System.Drawing.Size(107, 21)
        Me.ComboBoxTipoPersona.Sorted = True
        Me.ComboBoxTipoPersona.TabIndex = 154
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 22)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 15)
        Me.Label5.TabIndex = 153
        Me.Label5.Text = "Personas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(475, 22)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 15)
        Me.Label8.TabIndex = 152
        Me.Label8.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(344, 22)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 15)
        Me.Label4.TabIndex = 151
        Me.Label4.Text = "Comisión"
        '
        'ComboBoxComision
        '
        Me.ComboBoxComision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxComision.FormattingEnabled = True
        Me.ComboBoxComision.Location = New System.Drawing.Point(347, 42)
        Me.ComboBoxComision.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxComision.Name = "ComboBoxComision"
        Me.ComboBoxComision.Size = New System.Drawing.Size(117, 21)
        Me.ComboBoxComision.TabIndex = 150
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(116, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 149
        Me.Label3.Text = "Cátedra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(691, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 148
        Me.Label2.Text = "Carrera"
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonBuscar.Location = New System.Drawing.Point(851, 101)
        Me.ButtonBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(88, 38)
        Me.ButtonBuscar.TabIndex = 146
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxCarrera)
        Me.GroupBox1.Controls.Add(Me.CheckBoxCarrera)
        Me.GroupBox1.Controls.Add(Me.CheckBoxFecha)
        Me.GroupBox1.Controls.Add(Me.CheckBoxComision)
        Me.GroupBox1.Controls.Add(Me.CheckBoxCatedra)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ComboBoxTipoPersona)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateAsistencias)
        Me.GroupBox1.Controls.Add(Me.ComboBoxCatedra)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ComboBoxComision)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(822, 73)
        Me.GroupBox1.TabIndex = 158
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione un criterio de búsqueda"
        '
        'CheckBoxCarrera
        '
        Me.CheckBoxCarrera.AutoSize = True
        Me.CheckBoxCarrera.Checked = True
        Me.CheckBoxCarrera.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxCarrera.Location = New System.Drawing.Point(738, 23)
        Me.CheckBoxCarrera.Name = "CheckBoxCarrera"
        Me.CheckBoxCarrera.Size = New System.Drawing.Size(56, 17)
        Me.CheckBoxCarrera.TabIndex = 161
        Me.CheckBoxCarrera.Text = "Todas"
        Me.CheckBoxCarrera.UseVisualStyleBackColor = True
        '
        'CheckBoxFecha
        '
        Me.CheckBoxFecha.AutoSize = True
        Me.CheckBoxFecha.Checked = True
        Me.CheckBoxFecha.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxFecha.Location = New System.Drawing.Point(521, 23)
        Me.CheckBoxFecha.Name = "CheckBoxFecha"
        Me.CheckBoxFecha.Size = New System.Drawing.Size(56, 17)
        Me.CheckBoxFecha.TabIndex = 160
        Me.CheckBoxFecha.Text = "Todas"
        Me.CheckBoxFecha.UseVisualStyleBackColor = True
        '
        'CheckBoxComision
        '
        Me.CheckBoxComision.AutoSize = True
        Me.CheckBoxComision.Checked = True
        Me.CheckBoxComision.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxComision.Location = New System.Drawing.Point(408, 23)
        Me.CheckBoxComision.Name = "CheckBoxComision"
        Me.CheckBoxComision.Size = New System.Drawing.Size(56, 17)
        Me.CheckBoxComision.TabIndex = 159
        Me.CheckBoxComision.Text = "Todas"
        Me.CheckBoxComision.UseVisualStyleBackColor = True
        '
        'CheckBoxCatedra
        '
        Me.CheckBoxCatedra.AutoSize = True
        Me.CheckBoxCatedra.Checked = True
        Me.CheckBoxCatedra.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxCatedra.Location = New System.Drawing.Point(171, 23)
        Me.CheckBoxCatedra.Name = "CheckBoxCatedra"
        Me.CheckBoxCatedra.Size = New System.Drawing.Size(56, 17)
        Me.CheckBoxCatedra.TabIndex = 158
        Me.CheckBoxCatedra.Text = "Todas"
        Me.CheckBoxCatedra.UseVisualStyleBackColor = True
        '
        'ComboBoxCarrera
        '
        Me.ComboBoxCarrera.AccessibleDescription = ""
        Me.ComboBoxCarrera.AccessibleName = ""
        Me.ComboBoxCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCarrera.Enabled = False
        Me.ComboBoxCarrera.FormattingEnabled = True
        Me.ComboBoxCarrera.Items.AddRange(New Object() {"Sistemas", "Industrial", "Mecanica", "Quimica", "Electrica", "Civil"})
        Me.ComboBoxCarrera.Location = New System.Drawing.Point(694, 42)
        Me.ComboBoxCarrera.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxCarrera.Name = "ComboBoxCarrera"
        Me.ComboBoxCarrera.Size = New System.Drawing.Size(123, 21)
        Me.ComboBoxCarrera.TabIndex = 162
        '
        'Asistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 598)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonResetParametros)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.DataGridViewAsistencias)
        Me.Controls.Add(Me.LabelConsultaAlumnos)
        Me.Controls.Add(Me.LabelEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Asistencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.DataGridViewAsistencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelEncabezado As Label
    Friend WithEvents LabelConsultaAlumnos As Label
    Friend WithEvents DataGridViewAsistencias As DataGridView
    Friend WithEvents ButtonResetParametros As Button
    Friend WithEvents ComboBoxCatedra As ComboBox
    Friend WithEvents DateAsistencias As DateTimePicker
    Friend WithEvents ComboBoxTipoPersona As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxComision As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonElegirPersona As DataGridViewButtonColumn
    Friend WithEvents CheckBoxCarrera As CheckBox
    Friend WithEvents CheckBoxFecha As CheckBox
    Friend WithEvents CheckBoxComision As CheckBox
    Friend WithEvents CheckBoxCatedra As CheckBox
    Friend WithEvents ComboBoxCarrera As ComboBox
End Class
