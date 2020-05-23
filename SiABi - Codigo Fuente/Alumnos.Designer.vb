<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Alumnos
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TextoDeAyuda = New System.Windows.Forms.Label()
        Me.LabelAlumnoSeleccionado = New System.Windows.Forms.Label()
        Me.TextBoxSelectedAlumno = New System.Windows.Forms.TextBox()
        Me.ButtonAlumnoVerMas = New System.Windows.Forms.Button()
        Me.DataGridViewAlumnos = New System.Windows.Forms.DataGridView()
        Me.ButtonElegirPersona = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Labelseleccioncriterio = New System.Windows.Forms.Label()
        Me.TextBoxCriterioDato = New System.Windows.Forms.TextBox()
        Me.ComboBoxTipoCriterio = New System.Windows.Forms.ComboBox()
        Me.ButtonBuscarxCriterio = New System.Windows.Forms.Button()
        Me.LabelConsultaAlumnos = New System.Windows.Forms.Label()
        Me.LabelEncabezado = New System.Windows.Forms.Label()
        CType(Me.DataGridViewAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextoDeAyuda
        '
        Me.TextoDeAyuda.AutoSize = True
        Me.TextoDeAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoDeAyuda.Location = New System.Drawing.Point(11, 135)
        Me.TextoDeAyuda.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TextoDeAyuda.Name = "TextoDeAyuda"
        Me.TextoDeAyuda.Size = New System.Drawing.Size(229, 15)
        Me.TextoDeAyuda.TabIndex = 98
        Me.TextoDeAyuda.Text = "Ingrese el legajo sin guiones ni espacios"
        '
        'LabelAlumnoSeleccionado
        '
        Me.LabelAlumnoSeleccionado.AutoSize = True
        Me.LabelAlumnoSeleccionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAlumnoSeleccionado.Location = New System.Drawing.Point(8, 232)
        Me.LabelAlumnoSeleccionado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAlumnoSeleccionado.Name = "LabelAlumnoSeleccionado"
        Me.LabelAlumnoSeleccionado.Size = New System.Drawing.Size(142, 17)
        Me.LabelAlumnoSeleccionado.TabIndex = 97
        Me.LabelAlumnoSeleccionado.Text = "Alumno seleccionado"
        '
        'TextBoxSelectedAlumno
        '
        Me.TextBoxSelectedAlumno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxSelectedAlumno.Location = New System.Drawing.Point(11, 251)
        Me.TextBoxSelectedAlumno.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxSelectedAlumno.Name = "TextBoxSelectedAlumno"
        Me.TextBoxSelectedAlumno.ReadOnly = True
        Me.TextBoxSelectedAlumno.Size = New System.Drawing.Size(212, 20)
        Me.TextBoxSelectedAlumno.TabIndex = 96
        '
        'ButtonAlumnoVerMas
        '
        Me.ButtonAlumnoVerMas.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonAlumnoVerMas.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonAlumnoVerMas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonAlumnoVerMas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAlumnoVerMas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonAlumnoVerMas.Location = New System.Drawing.Point(134, 275)
        Me.ButtonAlumnoVerMas.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAlumnoVerMas.Name = "ButtonAlumnoVerMas"
        Me.ButtonAlumnoVerMas.Size = New System.Drawing.Size(86, 38)
        Me.ButtonAlumnoVerMas.TabIndex = 95
        Me.ButtonAlumnoVerMas.Text = "Ver Más"
        Me.ButtonAlumnoVerMas.UseVisualStyleBackColor = False
        '
        'DataGridViewAlumnos
        '
        Me.DataGridViewAlumnos.AllowUserToAddRows = False
        Me.DataGridViewAlumnos.AllowUserToDeleteRows = False
        Me.DataGridViewAlumnos.AllowUserToOrderColumns = True
        Me.DataGridViewAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewAlumnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ButtonElegirPersona})
        Me.DataGridViewAlumnos.Location = New System.Drawing.Point(352, 93)
        Me.DataGridViewAlumnos.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewAlumnos.Name = "DataGridViewAlumnos"
        Me.DataGridViewAlumnos.ReadOnly = True
        Me.DataGridViewAlumnos.RowTemplate.Height = 24
        Me.DataGridViewAlumnos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewAlumnos.Size = New System.Drawing.Size(825, 475)
        Me.DataGridViewAlumnos.TabIndex = 93
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
        'Labelseleccioncriterio
        '
        Me.Labelseleccioncriterio.AutoSize = True
        Me.Labelseleccioncriterio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelseleccioncriterio.Location = New System.Drawing.Point(8, 93)
        Me.Labelseleccioncriterio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Labelseleccioncriterio.Name = "Labelseleccioncriterio"
        Me.Labelseleccioncriterio.Size = New System.Drawing.Size(231, 17)
        Me.Labelseleccioncriterio.TabIndex = 92
        Me.Labelseleccioncriterio.Text = "Seleccione un criterio de búsqueda"
        '
        'TextBoxCriterioDato
        '
        Me.TextBoxCriterioDato.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxCriterioDato.Location = New System.Drawing.Point(107, 112)
        Me.TextBoxCriterioDato.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxCriterioDato.Name = "TextBoxCriterioDato"
        Me.TextBoxCriterioDato.Size = New System.Drawing.Size(212, 20)
        Me.TextBoxCriterioDato.TabIndex = 91
        '
        'ComboBoxTipoCriterio
        '
        Me.ComboBoxTipoCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTipoCriterio.Items.AddRange(New Object() {"Legajo", "DNI", "Nombre", "Apellido"})
        Me.ComboBoxTipoCriterio.Location = New System.Drawing.Point(11, 112)
        Me.ComboBoxTipoCriterio.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxTipoCriterio.Name = "ComboBoxTipoCriterio"
        Me.ComboBoxTipoCriterio.Size = New System.Drawing.Size(92, 21)
        Me.ComboBoxTipoCriterio.TabIndex = 90
        '
        'ButtonBuscarxCriterio
        '
        Me.ButtonBuscarxCriterio.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonBuscarxCriterio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBuscarxCriterio.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonBuscarxCriterio.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonBuscarxCriterio.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonBuscarxCriterio.Location = New System.Drawing.Point(233, 160)
        Me.ButtonBuscarxCriterio.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonBuscarxCriterio.Name = "ButtonBuscarxCriterio"
        Me.ButtonBuscarxCriterio.Size = New System.Drawing.Size(86, 38)
        Me.ButtonBuscarxCriterio.TabIndex = 89
        Me.ButtonBuscarxCriterio.Text = "Buscar"
        Me.ButtonBuscarxCriterio.UseVisualStyleBackColor = False
        '
        'LabelConsultaAlumnos
        '
        Me.LabelConsultaAlumnos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelConsultaAlumnos.AutoSize = True
        Me.LabelConsultaAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelConsultaAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LabelConsultaAlumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConsultaAlumnos.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelConsultaAlumnos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LabelConsultaAlumnos.Location = New System.Drawing.Point(11, 46)
        Me.LabelConsultaAlumnos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelConsultaAlumnos.Name = "LabelConsultaAlumnos"
        Me.LabelConsultaAlumnos.Size = New System.Drawing.Size(211, 26)
        Me.LabelConsultaAlumnos.TabIndex = 88
        Me.LabelConsultaAlumnos.Text = "Consulta de Alumnos"
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
        Me.LabelEncabezado.Location = New System.Drawing.Point(423, 9)
        Me.LabelEncabezado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelEncabezado.Name = "LabelEncabezado"
        Me.LabelEncabezado.Size = New System.Drawing.Size(450, 24)
        Me.LabelEncabezado.TabIndex = 87
        Me.LabelEncabezado.Text = "UTN - FRLP - Sistema de Asistencia Biométrico"
        Me.LabelEncabezado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Alumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 528)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextoDeAyuda)
        Me.Controls.Add(Me.LabelAlumnoSeleccionado)
        Me.Controls.Add(Me.TextBoxSelectedAlumno)
        Me.Controls.Add(Me.ButtonAlumnoVerMas)
        Me.Controls.Add(Me.DataGridViewAlumnos)
        Me.Controls.Add(Me.Labelseleccioncriterio)
        Me.Controls.Add(Me.TextBoxCriterioDato)
        Me.Controls.Add(Me.ComboBoxTipoCriterio)
        Me.Controls.Add(Me.ButtonBuscarxCriterio)
        Me.Controls.Add(Me.LabelConsultaAlumnos)
        Me.Controls.Add(Me.LabelEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Alumnos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.DataGridViewAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextoDeAyuda As Label
    Friend WithEvents LabelAlumnoSeleccionado As Label
    Friend WithEvents TextBoxSelectedAlumno As TextBox
    Friend WithEvents ButtonAlumnoVerMas As Button
    Friend WithEvents DataGridViewAlumnos As DataGridView
    Friend WithEvents ButtonElegirPersona As DataGridViewButtonColumn
    Friend WithEvents Labelseleccioncriterio As Label
    Friend WithEvents TextBoxCriterioDato As TextBox
    Friend WithEvents ComboBoxTipoCriterio As ComboBox
    Friend WithEvents ButtonBuscarxCriterio As Button
    Friend WithEvents LabelConsultaAlumnos As Label
    Friend WithEvents LabelEncabezado As Label
End Class
