<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Aulas
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
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.LabelAulaSeleccionada = New System.Windows.Forms.Label()
        Me.TextBoxSelectedAula = New System.Windows.Forms.TextBox()
        Me.ButtonVerMas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxBusquedaAulas = New System.Windows.Forms.TextBox()
        Me.ComboBoxAula = New System.Windows.Forms.ComboBox()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonNuevaAula = New System.Windows.Forms.Button()
        Me.ComboBoxEstado = New System.Windows.Forms.ComboBox()
        Me.DataGridViewAulas = New System.Windows.Forms.DataGridView()
        Me.ButtonElegirAula = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridViewAulas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ButtonEliminar
        '
        Me.ButtonEliminar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEliminar.ForeColor = System.Drawing.Color.Coral
        Me.ButtonEliminar.Location = New System.Drawing.Point(120, 280)
        Me.ButtonEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(86, 38)
        Me.ButtonEliminar.TabIndex = 166
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        Me.ButtonEliminar.Visible = False
        '
        'LabelAulaSeleccionada
        '
        Me.LabelAulaSeleccionada.AutoSize = True
        Me.LabelAulaSeleccionada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAulaSeleccionada.Location = New System.Drawing.Point(11, 236)
        Me.LabelAulaSeleccionada.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAulaSeleccionada.Name = "LabelAulaSeleccionada"
        Me.LabelAulaSeleccionada.Size = New System.Drawing.Size(123, 17)
        Me.LabelAulaSeleccionada.TabIndex = 165
        Me.LabelAulaSeleccionada.Text = "Aula seleccionada"
        '
        'TextBoxSelectedAula
        '
        Me.TextBoxSelectedAula.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxSelectedAula.Location = New System.Drawing.Point(14, 255)
        Me.TextBoxSelectedAula.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxSelectedAula.Name = "TextBoxSelectedAula"
        Me.TextBoxSelectedAula.ReadOnly = True
        Me.TextBoxSelectedAula.Size = New System.Drawing.Size(282, 20)
        Me.TextBoxSelectedAula.TabIndex = 164
        '
        'ButtonVerMas
        '
        Me.ButtonVerMas.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonVerMas.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonVerMas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonVerMas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonVerMas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonVerMas.Location = New System.Drawing.Point(210, 279)
        Me.ButtonVerMas.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonVerMas.Name = "ButtonVerMas"
        Me.ButtonVerMas.Size = New System.Drawing.Size(86, 38)
        Me.ButtonVerMas.TabIndex = 163
        Me.ButtonVerMas.Text = "Ver Más"
        Me.ButtonVerMas.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 97)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 17)
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "Seleccione un criterio de búsqueda"
        '
        'TextBoxBusquedaAulas
        '
        Me.TextBoxBusquedaAulas.Location = New System.Drawing.Point(133, 116)
        Me.TextBoxBusquedaAulas.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxBusquedaAulas.Name = "TextBoxBusquedaAulas"
        Me.TextBoxBusquedaAulas.Size = New System.Drawing.Size(189, 20)
        Me.TextBoxBusquedaAulas.TabIndex = 159
        '
        'ComboBoxAula
        '
        Me.ComboBoxAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAula.FormattingEnabled = True
        Me.ComboBoxAula.Items.AddRange(New Object() {"Aula", "Edificio", "Estado del Aula", "Estado del Lector", "Serial del Lector"})
        Me.ComboBoxAula.Location = New System.Drawing.Point(14, 116)
        Me.ComboBoxAula.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxAula.Name = "ComboBoxAula"
        Me.ComboBoxAula.Size = New System.Drawing.Size(114, 21)
        Me.ComboBoxAula.Sorted = True
        Me.ComboBoxAula.TabIndex = 158
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonBuscar.Location = New System.Drawing.Point(133, 142)
        Me.ButtonBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(86, 38)
        Me.ButtonBuscar.TabIndex = 157
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.Location = New System.Drawing.Point(11, 45)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 26)
        Me.Label3.TabIndex = 156
        Me.Label3.Text = "Listado de Aulas"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonNuevaAula
        '
        Me.ButtonNuevaAula.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonNuevaAula.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonNuevaAula.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonNuevaAula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNuevaAula.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonNuevaAula.Location = New System.Drawing.Point(14, 279)
        Me.ButtonNuevaAula.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonNuevaAula.Name = "ButtonNuevaAula"
        Me.ButtonNuevaAula.Size = New System.Drawing.Size(102, 38)
        Me.ButtonNuevaAula.TabIndex = 167
        Me.ButtonNuevaAula.Text = "Nueva Aula"
        Me.ButtonNuevaAula.UseVisualStyleBackColor = False
        Me.ButtonNuevaAula.Visible = False
        '
        'ComboBoxEstado
        '
        Me.ComboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEstado.FormattingEnabled = True
        Me.ComboBoxEstado.Items.AddRange(New Object() {"No", "Si"})
        Me.ComboBoxEstado.Location = New System.Drawing.Point(133, 116)
        Me.ComboBoxEstado.Name = "ComboBoxEstado"
        Me.ComboBoxEstado.Size = New System.Drawing.Size(109, 21)
        Me.ComboBoxEstado.TabIndex = 168
        Me.ComboBoxEstado.Visible = False
        '
        'DataGridViewAulas
        '
        Me.DataGridViewAulas.AllowUserToAddRows = False
        Me.DataGridViewAulas.AllowUserToDeleteRows = False
        Me.DataGridViewAulas.AllowUserToOrderColumns = True
        Me.DataGridViewAulas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewAulas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAulas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ButtonElegirAula})
        Me.DataGridViewAulas.Location = New System.Drawing.Point(326, 97)
        Me.DataGridViewAulas.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewAulas.Name = "DataGridViewAulas"
        Me.DataGridViewAulas.ReadOnly = True
        Me.DataGridViewAulas.RowTemplate.Height = 24
        Me.DataGridViewAulas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewAulas.Size = New System.Drawing.Size(851, 460)
        Me.DataGridViewAulas.TabIndex = 169
        '
        'ButtonElegirAula
        '
        Me.ButtonElegirAula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Book Antiqua", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.NullValue = "Elegir"
        Me.ButtonElegirAula.DefaultCellStyle = DataGridViewCellStyle2
        Me.ButtonElegirAula.DividerWidth = 2
        Me.ButtonElegirAula.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonElegirAula.HeaderText = "Seleccionar"
        Me.ButtonElegirAula.Name = "ButtonElegirAula"
        Me.ButtonElegirAula.ReadOnly = True
        Me.ButtonElegirAula.Text = "Elegir"
        Me.ButtonElegirAula.Width = 82
        '
        'Aulas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 568)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridViewAulas)
        Me.Controls.Add(Me.ComboBoxEstado)
        Me.Controls.Add(Me.ButtonNuevaAula)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.LabelAulaSeleccionada)
        Me.Controls.Add(Me.TextBoxSelectedAula)
        Me.Controls.Add(Me.ButtonVerMas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxBusquedaAulas)
        Me.Controls.Add(Me.ComboBoxAula)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Aulas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.DataGridViewAulas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelEncabezado As Label
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents LabelAulaSeleccionada As Label
    Friend WithEvents TextBoxSelectedAula As TextBox
    Friend WithEvents ButtonVerMas As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxBusquedaAulas As TextBox
    Friend WithEvents ComboBoxAula As ComboBox
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonNuevaAula As Button
    Friend WithEvents ComboBoxEstado As ComboBox
    Friend WithEvents DataGridViewAulas As DataGridView
    Friend WithEvents ButtonElegirAula As DataGridViewButtonColumn
End Class
