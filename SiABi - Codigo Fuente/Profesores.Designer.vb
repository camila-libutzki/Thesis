<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profesores
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
        Me.LabelPersonaSeleccionada = New System.Windows.Forms.Label()
        Me.TextBoxSelectedProfesor = New System.Windows.Forms.TextBox()
        Me.ButtonProfesorVerMas = New System.Windows.Forms.Button()
        Me.DataGridViewProfesores = New System.Windows.Forms.DataGridView()
        Me.ButtonElegirPersona = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ButtonBuscarProfesores = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxBusqueda = New System.Windows.Forms.TextBox()
        Me.ComboBoxCriterio = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextoDeAyuda = New System.Windows.Forms.Label()
        CType(Me.DataGridViewProfesores, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'LabelPersonaSeleccionada
        '
        Me.LabelPersonaSeleccionada.AutoSize = True
        Me.LabelPersonaSeleccionada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPersonaSeleccionada.Location = New System.Drawing.Point(11, 253)
        Me.LabelPersonaSeleccionada.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPersonaSeleccionada.Name = "LabelPersonaSeleccionada"
        Me.LabelPersonaSeleccionada.Size = New System.Drawing.Size(149, 17)
        Me.LabelPersonaSeleccionada.TabIndex = 100
        Me.LabelPersonaSeleccionada.Text = "Profesor seleccionado"
        '
        'TextBoxSelectedProfesor
        '
        Me.TextBoxSelectedProfesor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxSelectedProfesor.Location = New System.Drawing.Point(14, 272)
        Me.TextBoxSelectedProfesor.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxSelectedProfesor.Name = "TextBoxSelectedProfesor"
        Me.TextBoxSelectedProfesor.ReadOnly = True
        Me.TextBoxSelectedProfesor.Size = New System.Drawing.Size(212, 20)
        Me.TextBoxSelectedProfesor.TabIndex = 99
        '
        'ButtonProfesorVerMas
        '
        Me.ButtonProfesorVerMas.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonProfesorVerMas.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonProfesorVerMas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonProfesorVerMas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProfesorVerMas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonProfesorVerMas.Location = New System.Drawing.Point(140, 296)
        Me.ButtonProfesorVerMas.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonProfesorVerMas.Name = "ButtonProfesorVerMas"
        Me.ButtonProfesorVerMas.Size = New System.Drawing.Size(86, 38)
        Me.ButtonProfesorVerMas.TabIndex = 98
        Me.ButtonProfesorVerMas.Text = "Ver Más"
        Me.ButtonProfesorVerMas.UseVisualStyleBackColor = False
        '
        'DataGridViewProfesores
        '
        Me.DataGridViewProfesores.AllowUserToAddRows = False
        Me.DataGridViewProfesores.AllowUserToDeleteRows = False
        Me.DataGridViewProfesores.AllowUserToOrderColumns = True
        Me.DataGridViewProfesores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewProfesores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProfesores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ButtonElegirPersona})
        Me.DataGridViewProfesores.Location = New System.Drawing.Point(292, 65)
        Me.DataGridViewProfesores.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewProfesores.Name = "DataGridViewProfesores"
        Me.DataGridViewProfesores.ReadOnly = True
        Me.DataGridViewProfesores.RowTemplate.Height = 24
        Me.DataGridViewProfesores.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewProfesores.Size = New System.Drawing.Size(885, 503)
        Me.DataGridViewProfesores.TabIndex = 97
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
        'ButtonBuscarProfesores
        '
        Me.ButtonBuscarProfesores.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonBuscarProfesores.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonBuscarProfesores.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonBuscarProfesores.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonBuscarProfesores.Location = New System.Drawing.Point(192, 176)
        Me.ButtonBuscarProfesores.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonBuscarProfesores.Name = "ButtonBuscarProfesores"
        Me.ButtonBuscarProfesores.Size = New System.Drawing.Size(86, 35)
        Me.ButtonBuscarProfesores.TabIndex = 95
        Me.ButtonBuscarProfesores.Text = "Buscar"
        Me.ButtonBuscarProfesores.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 114)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 17)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Seleccione un criterio de búsqueda"
        '
        'TextBoxBusqueda
        '
        Me.TextBoxBusqueda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxBusqueda.Location = New System.Drawing.Point(110, 133)
        Me.TextBoxBusqueda.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxBusqueda.Name = "TextBoxBusqueda"
        Me.TextBoxBusqueda.Size = New System.Drawing.Size(168, 20)
        Me.TextBoxBusqueda.TabIndex = 93
        '
        'ComboBoxCriterio
        '
        Me.ComboBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCriterio.FormattingEnabled = True
        Me.ComboBoxCriterio.Items.AddRange(New Object() {"Legajo", "DNI", "Nombre", "Apellido"})
        Me.ComboBoxCriterio.Location = New System.Drawing.Point(14, 133)
        Me.ComboBoxCriterio.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxCriterio.Name = "ComboBoxCriterio"
        Me.ComboBoxCriterio.Size = New System.Drawing.Size(92, 21)
        Me.ComboBoxCriterio.TabIndex = 92
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label6.Location = New System.Drawing.Point(11, 65)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(229, 26)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Consulta de Profesores"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextoDeAyuda
        '
        Me.TextoDeAyuda.AutoSize = True
        Me.TextoDeAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextoDeAyuda.Location = New System.Drawing.Point(11, 156)
        Me.TextoDeAyuda.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TextoDeAyuda.Name = "TextoDeAyuda"
        Me.TextoDeAyuda.Size = New System.Drawing.Size(229, 15)
        Me.TextoDeAyuda.TabIndex = 101
        Me.TextoDeAyuda.Text = "Ingrese el legajo sin guiones ni espacios"
        '
        'Profesores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 536)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextoDeAyuda)
        Me.Controls.Add(Me.LabelPersonaSeleccionada)
        Me.Controls.Add(Me.TextBoxSelectedProfesor)
        Me.Controls.Add(Me.ButtonProfesorVerMas)
        Me.Controls.Add(Me.DataGridViewProfesores)
        Me.Controls.Add(Me.ButtonBuscarProfesores)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxBusqueda)
        Me.Controls.Add(Me.ComboBoxCriterio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Profesores"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.DataGridViewProfesores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelEncabezado As Label
    Friend WithEvents LabelPersonaSeleccionada As Label
    Friend WithEvents TextBoxSelectedProfesor As TextBox
    Friend WithEvents ButtonProfesorVerMas As Button
    Friend WithEvents DataGridViewProfesores As DataGridView
    Friend WithEvents ButtonBuscarProfesores As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxBusqueda As TextBox
    Friend WithEvents ComboBoxCriterio As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextoDeAyuda As Label
    Friend WithEvents ButtonElegirPersona As DataGridViewButtonColumn
End Class
