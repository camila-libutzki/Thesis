<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Feriados
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
        Me.LabelEncabezado = New System.Windows.Forms.Label()
        Me.DataGridViewCalendario = New System.Windows.Forms.DataGridView()
        Me.ButtonEliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.LabelConsultaAlumnos = New System.Windows.Forms.Label()
        Me.ButtonMostrarTodos = New System.Windows.Forms.Button()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxCriterioBusqueda = New System.Windows.Forms.ComboBox()
        Me.GroupBoxTipoDia = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBoxBuscarTipoDia = New System.Windows.Forms.ComboBox()
        Me.ButtonMarcarDias = New System.Windows.Forms.Button()
        Me.GroupBoxFecha = New System.Windows.Forms.GroupBox()
        Me.buscarDesde = New System.Windows.Forms.DateTimePicker()
        Me.CheckBoxBuscarHasta = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.buscarHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBoxMarcar = New System.Windows.Forms.GroupBox()
        Me.dateDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxTipoDia = New System.Windows.Forms.ComboBox()
        Me.TextBoxDescripcion = New System.Windows.Forms.RichTextBox()
        Me.CheckBoxHasta = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dateHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewCalendario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxTipoDia.SuspendLayout()
        Me.GroupBoxFecha.SuspendLayout()
        Me.GroupBoxMarcar.SuspendLayout()
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
        Me.LabelEncabezado.Location = New System.Drawing.Point(311, 9)
        Me.LabelEncabezado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelEncabezado.Name = "LabelEncabezado"
        Me.LabelEncabezado.Size = New System.Drawing.Size(450, 24)
        Me.LabelEncabezado.TabIndex = 90
        Me.LabelEncabezado.Text = "UTN - FRLP - Sistema de Asistencia Biométrico"
        Me.LabelEncabezado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataGridViewCalendario
        '
        Me.DataGridViewCalendario.AllowUserToAddRows = False
        Me.DataGridViewCalendario.AllowUserToDeleteRows = False
        Me.DataGridViewCalendario.AllowUserToOrderColumns = True
        Me.DataGridViewCalendario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCalendario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewCalendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCalendario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ButtonEliminar})
        Me.DataGridViewCalendario.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DataGridViewCalendario.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridViewCalendario.Location = New System.Drawing.Point(355, 121)
        Me.DataGridViewCalendario.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewCalendario.Name = "DataGridViewCalendario"
        Me.DataGridViewCalendario.ReadOnly = True
        Me.DataGridViewCalendario.RowTemplate.Height = 24
        Me.DataGridViewCalendario.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCalendario.Size = New System.Drawing.Size(831, 466)
        Me.DataGridViewCalendario.TabIndex = 179
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
        Me.LabelConsultaAlumnos.Size = New System.Drawing.Size(224, 26)
        Me.LabelConsultaAlumnos.TabIndex = 194
        Me.LabelConsultaAlumnos.Text = "Calendario Académico"
        Me.LabelConsultaAlumnos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonMostrarTodos
        '
        Me.ButtonMostrarTodos.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonMostrarTodos.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonMostrarTodos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonMostrarTodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonMostrarTodos.Location = New System.Drawing.Point(99, 312)
        Me.ButtonMostrarTodos.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonMostrarTodos.Name = "ButtonMostrarTodos"
        Me.ButtonMostrarTodos.Size = New System.Drawing.Size(99, 38)
        Me.ButtonMostrarTodos.TabIndex = 195
        Me.ButtonMostrarTodos.Text = "Mostrar todos"
        Me.ButtonMostrarTodos.UseVisualStyleBackColor = False
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonBuscar.Location = New System.Drawing.Point(202, 312)
        Me.ButtonBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(89, 38)
        Me.ButtonBuscar.TabIndex = 196
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 122)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(231, 17)
        Me.Label4.TabIndex = 198
        Me.Label4.Text = "Seleccione un criterio de búsqueda"
        '
        'ComboBoxCriterioBusqueda
        '
        Me.ComboBoxCriterioBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCriterioBusqueda.FormattingEnabled = True
        Me.ComboBoxCriterioBusqueda.Items.AddRange(New Object() {"Fecha", "Tipo de día"})
        Me.ComboBoxCriterioBusqueda.Location = New System.Drawing.Point(19, 141)
        Me.ComboBoxCriterioBusqueda.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxCriterioBusqueda.Name = "ComboBoxCriterioBusqueda"
        Me.ComboBoxCriterioBusqueda.Size = New System.Drawing.Size(109, 21)
        Me.ComboBoxCriterioBusqueda.Sorted = True
        Me.ComboBoxCriterioBusqueda.TabIndex = 197
        '
        'GroupBoxTipoDia
        '
        Me.GroupBoxTipoDia.Controls.Add(Me.Label9)
        Me.GroupBoxTipoDia.Controls.Add(Me.ComboBoxBuscarTipoDia)
        Me.GroupBoxTipoDia.Enabled = False
        Me.GroupBoxTipoDia.Location = New System.Drawing.Point(11, 257)
        Me.GroupBoxTipoDia.Name = "GroupBoxTipoDia"
        Me.GroupBoxTipoDia.Size = New System.Drawing.Size(281, 50)
        Me.GroupBoxTipoDia.TabIndex = 195
        Me.GroupBoxTipoDia.TabStop = False
        Me.GroupBoxTipoDia.Text = "Seleccione el tipo de días a buscar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 16)
        Me.Label9.TabIndex = 193
        Me.Label9.Text = "Tipo de día"
        '
        'ComboBoxBuscarTipoDia
        '
        Me.ComboBoxBuscarTipoDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBuscarTipoDia.FormattingEnabled = True
        Me.ComboBoxBuscarTipoDia.Items.AddRange(New Object() {"Feriado", "Finales", "Vacaciones"})
        Me.ComboBoxBuscarTipoDia.Location = New System.Drawing.Point(89, 22)
        Me.ComboBoxBuscarTipoDia.Name = "ComboBoxBuscarTipoDia"
        Me.ComboBoxBuscarTipoDia.Size = New System.Drawing.Size(167, 21)
        Me.ComboBoxBuscarTipoDia.TabIndex = 192
        '
        'ButtonMarcarDias
        '
        Me.ButtonMarcarDias.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonMarcarDias.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonMarcarDias.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonMarcarDias.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonMarcarDias.Location = New System.Drawing.Point(193, 549)
        Me.ButtonMarcarDias.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonMarcarDias.Name = "ButtonMarcarDias"
        Me.ButtonMarcarDias.Size = New System.Drawing.Size(99, 38)
        Me.ButtonMarcarDias.TabIndex = 145
        Me.ButtonMarcarDias.Text = "Marcar días"
        Me.ButtonMarcarDias.UseVisualStyleBackColor = False
        '
        'GroupBoxFecha
        '
        Me.GroupBoxFecha.Controls.Add(Me.buscarDesde)
        Me.GroupBoxFecha.Controls.Add(Me.CheckBoxBuscarHasta)
        Me.GroupBoxFecha.Controls.Add(Me.Label5)
        Me.GroupBoxFecha.Controls.Add(Me.buscarHasta)
        Me.GroupBoxFecha.Controls.Add(Me.Label8)
        Me.GroupBoxFecha.Enabled = False
        Me.GroupBoxFecha.Location = New System.Drawing.Point(11, 167)
        Me.GroupBoxFecha.Name = "GroupBoxFecha"
        Me.GroupBoxFecha.Size = New System.Drawing.Size(281, 75)
        Me.GroupBoxFecha.TabIndex = 196
        Me.GroupBoxFecha.TabStop = False
        Me.GroupBoxFecha.Text = "Seleccione el rango de días a buscar"
        '
        'buscarDesde
        '
        Me.buscarDesde.Location = New System.Drawing.Point(60, 23)
        Me.buscarDesde.Margin = New System.Windows.Forms.Padding(2)
        Me.buscarDesde.Name = "buscarDesde"
        Me.buscarDesde.Size = New System.Drawing.Size(196, 20)
        Me.buscarDesde.TabIndex = 186
        '
        'CheckBoxBuscarHasta
        '
        Me.CheckBoxBuscarHasta.AutoSize = True
        Me.CheckBoxBuscarHasta.Location = New System.Drawing.Point(261, 47)
        Me.CheckBoxBuscarHasta.Name = "CheckBoxBuscarHasta"
        Me.CheckBoxBuscarHasta.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxBuscarHasta.TabIndex = 185
        Me.CheckBoxBuscarHasta.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 183
        Me.Label5.Text = "Desde"
        '
        'buscarHasta
        '
        Me.buscarHasta.Enabled = False
        Me.buscarHasta.Location = New System.Drawing.Point(60, 47)
        Me.buscarHasta.Margin = New System.Windows.Forms.Padding(2)
        Me.buscarHasta.Name = "buscarHasta"
        Me.buscarHasta.Size = New System.Drawing.Size(196, 20)
        Me.buscarHasta.TabIndex = 182
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 184
        Me.Label8.Text = "Hasta"
        '
        'GroupBoxMarcar
        '
        Me.GroupBoxMarcar.Controls.Add(Me.dateDesde)
        Me.GroupBoxMarcar.Controls.Add(Me.Label7)
        Me.GroupBoxMarcar.Controls.Add(Me.Label6)
        Me.GroupBoxMarcar.Controls.Add(Me.ComboBoxTipoDia)
        Me.GroupBoxMarcar.Controls.Add(Me.TextBoxDescripcion)
        Me.GroupBoxMarcar.Controls.Add(Me.CheckBoxHasta)
        Me.GroupBoxMarcar.Controls.Add(Me.Label1)
        Me.GroupBoxMarcar.Controls.Add(Me.dateHasta)
        Me.GroupBoxMarcar.Controls.Add(Me.Label3)
        Me.GroupBoxMarcar.Location = New System.Drawing.Point(11, 369)
        Me.GroupBoxMarcar.Name = "GroupBoxMarcar"
        Me.GroupBoxMarcar.Size = New System.Drawing.Size(281, 166)
        Me.GroupBoxMarcar.TabIndex = 195
        Me.GroupBoxMarcar.TabStop = False
        Me.GroupBoxMarcar.Text = "Seleccione el día o rango de días a marcar"
        '
        'dateDesde
        '
        Me.dateDesde.Location = New System.Drawing.Point(60, 23)
        Me.dateDesde.Margin = New System.Windows.Forms.Padding(2)
        Me.dateDesde.Name = "dateDesde"
        Me.dateDesde.Size = New System.Drawing.Size(196, 20)
        Me.dateDesde.TabIndex = 194
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 193
        Me.Label7.Text = "Tipo de día"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 190
        Me.Label6.Text = "Descripción"
        '
        'ComboBoxTipoDia
        '
        Me.ComboBoxTipoDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTipoDia.FormattingEnabled = True
        Me.ComboBoxTipoDia.Items.AddRange(New Object() {"Feriado", "Finales", "Vacaciones"})
        Me.ComboBoxTipoDia.Location = New System.Drawing.Point(89, 72)
        Me.ComboBoxTipoDia.Name = "ComboBoxTipoDia"
        Me.ComboBoxTipoDia.Size = New System.Drawing.Size(167, 21)
        Me.ComboBoxTipoDia.TabIndex = 192
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(89, 99)
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.ReadOnly = True
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(167, 59)
        Me.TextBoxDescripcion.TabIndex = 188
        Me.TextBoxDescripcion.Text = ""
        '
        'CheckBoxHasta
        '
        Me.CheckBoxHasta.AutoSize = True
        Me.CheckBoxHasta.Location = New System.Drawing.Point(261, 47)
        Me.CheckBoxHasta.Name = "CheckBoxHasta"
        Me.CheckBoxHasta.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHasta.TabIndex = 185
        Me.CheckBoxHasta.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 183
        Me.Label1.Text = "Desde"
        '
        'dateHasta
        '
        Me.dateHasta.Enabled = False
        Me.dateHasta.Location = New System.Drawing.Point(60, 47)
        Me.dateHasta.Margin = New System.Windows.Forms.Padding(2)
        Me.dateHasta.Name = "dateHasta"
        Me.dateHasta.Size = New System.Drawing.Size(196, 20)
        Me.dateHasta.TabIndex = 182
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 184
        Me.Label3.Text = "Hasta"
        '
        'Feriados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 598)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBoxFecha)
        Me.Controls.Add(Me.GroupBoxTipoDia)
        Me.Controls.Add(Me.GroupBoxMarcar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBoxCriterioBusqueda)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.ButtonMostrarTodos)
        Me.Controls.Add(Me.LabelConsultaAlumnos)
        Me.Controls.Add(Me.DataGridViewCalendario)
        Me.Controls.Add(Me.ButtonMarcarDias)
        Me.Controls.Add(Me.LabelEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Feriados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridViewCalendario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxTipoDia.ResumeLayout(False)
        Me.GroupBoxTipoDia.PerformLayout()
        Me.GroupBoxFecha.ResumeLayout(False)
        Me.GroupBoxFecha.PerformLayout()
        Me.GroupBoxMarcar.ResumeLayout(False)
        Me.GroupBoxMarcar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelEncabezado As Label
    Friend WithEvents DataGridViewCalendario As DataGridView
    Friend WithEvents LabelConsultaAlumnos As Label
    Friend WithEvents ButtonMostrarTodos As Button
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents ButtonEliminar As DataGridViewButtonColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxCriterioBusqueda As ComboBox
    Friend WithEvents GroupBoxTipoDia As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBoxBuscarTipoDia As ComboBox
    Friend WithEvents ButtonMarcarDias As Button
    Friend WithEvents GroupBoxFecha As GroupBox
    Friend WithEvents buscarDesde As DateTimePicker
    Friend WithEvents CheckBoxBuscarHasta As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents buscarHasta As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBoxMarcar As GroupBox
    Friend WithEvents dateDesde As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBoxTipoDia As ComboBox
    Friend WithEvents TextBoxDescripcion As RichTextBox
    Friend WithEvents CheckBoxHasta As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dateHasta As DateTimePicker
    Friend WithEvents Label3 As Label
End Class
