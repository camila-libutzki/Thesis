<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Usuarios
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LabelEncabezado = New System.Windows.Forms.Label()
        Me.LabelusuarioSeleccionado = New System.Windows.Forms.Label()
        Me.TextBoxUsuarioSeleccionado = New System.Windows.Forms.TextBox()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonVerMas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxBusquedaXCriterio = New System.Windows.Forms.TextBox()
        Me.ComboBoxCriterio = New System.Windows.Forms.ComboBox()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.DataGridViewUsuarios = New System.Windows.Forms.DataGridView()
        Me.Seleccionado = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ComboBoxTipoUsuario = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridViewUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'LabelusuarioSeleccionado
        '
        Me.LabelusuarioSeleccionado.AutoSize = True
        Me.LabelusuarioSeleccionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelusuarioSeleccionado.Location = New System.Drawing.Point(11, 232)
        Me.LabelusuarioSeleccionado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelusuarioSeleccionado.Name = "LabelusuarioSeleccionado"
        Me.LabelusuarioSeleccionado.Size = New System.Drawing.Size(144, 17)
        Me.LabelusuarioSeleccionado.TabIndex = 100
        Me.LabelusuarioSeleccionado.Text = "Usuario seleccionado"
        '
        'TextBoxUsuarioSeleccionado
        '
        Me.TextBoxUsuarioSeleccionado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBoxUsuarioSeleccionado.Location = New System.Drawing.Point(14, 251)
        Me.TextBoxUsuarioSeleccionado.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxUsuarioSeleccionado.Name = "TextBoxUsuarioSeleccionado"
        Me.TextBoxUsuarioSeleccionado.ReadOnly = True
        Me.TextBoxUsuarioSeleccionado.Size = New System.Drawing.Size(212, 20)
        Me.TextBoxUsuarioSeleccionado.TabIndex = 99
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEliminar.ForeColor = System.Drawing.Color.Coral
        Me.ButtonEliminar.Location = New System.Drawing.Point(50, 275)
        Me.ButtonEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(86, 38)
        Me.ButtonEliminar.TabIndex = 98
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        Me.ButtonEliminar.Visible = False
        '
        'ButtonVerMas
        '
        Me.ButtonVerMas.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonVerMas.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonVerMas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonVerMas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonVerMas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonVerMas.Location = New System.Drawing.Point(140, 275)
        Me.ButtonVerMas.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonVerMas.Name = "ButtonVerMas"
        Me.ButtonVerMas.Size = New System.Drawing.Size(86, 38)
        Me.ButtonVerMas.TabIndex = 97
        Me.ButtonVerMas.Text = "Ver Más"
        Me.ButtonVerMas.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 93)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 17)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Seleccione un criterio de búsqueda"
        '
        'TextBoxBusquedaXCriterio
        '
        Me.TextBoxBusquedaXCriterio.Location = New System.Drawing.Point(140, 112)
        Me.TextBoxBusquedaXCriterio.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxBusquedaXCriterio.Name = "TextBoxBusquedaXCriterio"
        Me.TextBoxBusquedaXCriterio.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxBusquedaXCriterio.TabIndex = 94
        '
        'ComboBoxCriterio
        '
        Me.ComboBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCriterio.FormattingEnabled = True
        Me.ComboBoxCriterio.Items.AddRange(New Object() {"Legajo", "Nombre de Usuario", "Nombre y Apellido", "Tipo"})
        Me.ComboBoxCriterio.Location = New System.Drawing.Point(14, 112)
        Me.ComboBoxCriterio.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxCriterio.Name = "ComboBoxCriterio"
        Me.ComboBoxCriterio.Size = New System.Drawing.Size(122, 21)
        Me.ComboBoxCriterio.Sorted = True
        Me.ComboBoxCriterio.TabIndex = 93
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonBuscar.Location = New System.Drawing.Point(240, 136)
        Me.ButtonBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(86, 38)
        Me.ButtonBuscar.TabIndex = 92
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = False
        '
        'DataGridViewUsuarios
        '
        Me.DataGridViewUsuarios.AllowUserToAddRows = False
        Me.DataGridViewUsuarios.AllowUserToDeleteRows = False
        Me.DataGridViewUsuarios.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionado})
        Me.DataGridViewUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridViewUsuarios.Location = New System.Drawing.Point(354, 93)
        Me.DataGridViewUsuarios.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewUsuarios.MultiSelect = False
        Me.DataGridViewUsuarios.Name = "DataGridViewUsuarios"
        Me.DataGridViewUsuarios.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewUsuarios.RowTemplate.Height = 24
        Me.DataGridViewUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewUsuarios.Size = New System.Drawing.Size(823, 475)
        Me.DataGridViewUsuarios.TabIndex = 91
        '
        'Seleccionado
        '
        Me.Seleccionado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Book Antiqua", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.NullValue = "Elegir"
        Me.Seleccionado.DefaultCellStyle = DataGridViewCellStyle3
        Me.Seleccionado.DividerWidth = 2
        Me.Seleccionado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Seleccionado.HeaderText = "Seleccionar"
        Me.Seleccionado.Name = "Seleccionado"
        Me.Seleccionado.ReadOnly = True
        Me.Seleccionado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Seleccionado.Text = "Elegir"
        Me.Seleccionado.Width = 82
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label6.Location = New System.Drawing.Point(11, 47)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(210, 26)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Consulta de Usuarios"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComboBoxTipoUsuario
        '
        Me.ComboBoxTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTipoUsuario.FormattingEnabled = True
        Me.ComboBoxTipoUsuario.Items.AddRange(New Object() {"Administrador", "Bedel", "Jefe de Cátedra", "Jefe de Departamento", "Todos"})
        Me.ComboBoxTipoUsuario.Location = New System.Drawing.Point(140, 112)
        Me.ComboBoxTipoUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxTipoUsuario.Name = "ComboBoxTipoUsuario"
        Me.ComboBoxTipoUsuario.Size = New System.Drawing.Size(143, 21)
        Me.ComboBoxTipoUsuario.Sorted = True
        Me.ComboBoxTipoUsuario.TabIndex = 101
        Me.ComboBoxTipoUsuario.Visible = False
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 568)
        Me.ControlBox = False
        Me.Controls.Add(Me.ComboBoxTipoUsuario)
        Me.Controls.Add(Me.LabelusuarioSeleccionado)
        Me.Controls.Add(Me.TextBoxUsuarioSeleccionado)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonVerMas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxBusquedaXCriterio)
        Me.Controls.Add(Me.ComboBoxCriterio)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.DataGridViewUsuarios)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.DataGridViewUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelEncabezado As Label
    Friend WithEvents LabelusuarioSeleccionado As Label
    Friend WithEvents TextBoxUsuarioSeleccionado As TextBox
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonVerMas As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxBusquedaXCriterio As TextBox
    Friend WithEvents ComboBoxCriterio As ComboBox
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents DataGridViewUsuarios As DataGridView
    Friend WithEvents Seleccionado As DataGridViewButtonColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ComboBoxTipoUsuario As ComboBox
End Class
