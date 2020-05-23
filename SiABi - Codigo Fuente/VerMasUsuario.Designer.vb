<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerMasUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerMasUsuario))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LabelEncabezado = New System.Windows.Forms.Label()
        Me.ButtonExaminarFoto = New System.Windows.Forms.Button()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonresetContraseña = New System.Windows.Forms.Button()
        Me.ButtonmodificarDatos = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxLegajo = New System.Windows.Forms.TextBox()
        Me.TextBoxDNI = New System.Windows.Forms.TextBox()
        Me.ButtonGuardarDatos = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNombreApellido = New System.Windows.Forms.TextBox()
        Me.TextBoxNombreUsuario = New System.Windows.Forms.TextBox()
        Me.LabelGuardarCambios = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridViewPerfilesXUsuario = New System.Windows.Forms.DataGridView()
        Me.ButtonEliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ButtonAgregarComision = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.fotoAuxiliar = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewPerfilesXUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.fotoAuxiliar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ButtonExaminarFoto
        '
        Me.ButtonExaminarFoto.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonExaminarFoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonExaminarFoto.Enabled = False
        Me.ButtonExaminarFoto.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonExaminarFoto.Location = New System.Drawing.Point(240, 239)
        Me.ButtonExaminarFoto.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonExaminarFoto.Name = "ButtonExaminarFoto"
        Me.ButtonExaminarFoto.Size = New System.Drawing.Size(86, 38)
        Me.ButtonExaminarFoto.TabIndex = 97
        Me.ButtonExaminarFoto.Text = "Examinar"
        Me.ButtonExaminarFoto.UseVisualStyleBackColor = False
        Me.ButtonExaminarFoto.Visible = False
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox.Image = CType(resources.GetObject("PictureBox.Image"), System.Drawing.Image)
        Me.PictureBox.InitialImage = CType(resources.GetObject("PictureBox.InitialImage"), System.Drawing.Image)
        Me.PictureBox.Location = New System.Drawing.Point(196, 105)
        Me.PictureBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(130, 130)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 95
        Me.PictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(11, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 26)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Datos del Usuario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonresetContraseña
        '
        Me.ButtonresetContraseña.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonresetContraseña.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonresetContraseña.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonresetContraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonresetContraseña.Location = New System.Drawing.Point(745, 190)
        Me.ButtonresetContraseña.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonresetContraseña.Name = "ButtonresetContraseña"
        Me.ButtonresetContraseña.Size = New System.Drawing.Size(112, 38)
        Me.ButtonresetContraseña.TabIndex = 116
        Me.ButtonresetContraseña.Text = "Resetear Contraseña"
        Me.ButtonresetContraseña.UseVisualStyleBackColor = False
        Me.ButtonresetContraseña.Visible = False
        '
        'ButtonmodificarDatos
        '
        Me.ButtonmodificarDatos.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonmodificarDatos.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonmodificarDatos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonmodificarDatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonmodificarDatos.Location = New System.Drawing.Point(745, 114)
        Me.ButtonmodificarDatos.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonmodificarDatos.Name = "ButtonmodificarDatos"
        Me.ButtonmodificarDatos.Size = New System.Drawing.Size(112, 38)
        Me.ButtonmodificarDatos.TabIndex = 115
        Me.ButtonmodificarDatos.Text = "Modificar Datos"
        Me.ButtonmodificarDatos.UseVisualStyleBackColor = False
        Me.ButtonmodificarDatos.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(85, 92)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 17)
        Me.Label9.TabIndex = 112
        Me.Label9.Text = "Legajo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(105, 68)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 17)
        Me.Label10.TabIndex = 111
        Me.Label10.Text = "DNI"
        '
        'TextBoxLegajo
        '
        Me.TextBoxLegajo.Location = New System.Drawing.Point(140, 91)
        Me.TextBoxLegajo.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxLegajo.Name = "TextBoxLegajo"
        Me.TextBoxLegajo.ReadOnly = True
        Me.TextBoxLegajo.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxLegajo.TabIndex = 110
        '
        'TextBoxDNI
        '
        Me.TextBoxDNI.Location = New System.Drawing.Point(140, 67)
        Me.TextBoxDNI.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxDNI.Name = "TextBoxDNI"
        Me.TextBoxDNI.ReadOnly = True
        Me.TextBoxDNI.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxDNI.TabIndex = 109
        '
        'ButtonGuardarDatos
        '
        Me.ButtonGuardarDatos.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonGuardarDatos.Enabled = False
        Me.ButtonGuardarDatos.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonGuardarDatos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonGuardarDatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonGuardarDatos.Location = New System.Drawing.Point(861, 114)
        Me.ButtonGuardarDatos.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonGuardarDatos.Name = "ButtonGuardarDatos"
        Me.ButtonGuardarDatos.Size = New System.Drawing.Size(112, 38)
        Me.ButtonGuardarDatos.TabIndex = 107
        Me.ButtonGuardarDatos.Text = "Guardar Datos"
        Me.ButtonGuardarDatos.UseVisualStyleBackColor = False
        Me.ButtonGuardarDatos.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 44)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 17)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Nombre y Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 17)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Nombre de Usuario"
        '
        'TextBoxNombreApellido
        '
        Me.TextBoxNombreApellido.Location = New System.Drawing.Point(140, 43)
        Me.TextBoxNombreApellido.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxNombreApellido.Name = "TextBoxNombreApellido"
        Me.TextBoxNombreApellido.ReadOnly = True
        Me.TextBoxNombreApellido.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxNombreApellido.TabIndex = 101
        '
        'TextBoxNombreUsuario
        '
        Me.TextBoxNombreUsuario.Location = New System.Drawing.Point(140, 19)
        Me.TextBoxNombreUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxNombreUsuario.Name = "TextBoxNombreUsuario"
        Me.TextBoxNombreUsuario.ReadOnly = True
        Me.TextBoxNombreUsuario.Size = New System.Drawing.Size(184, 20)
        Me.TextBoxNombreUsuario.TabIndex = 100
        '
        'LabelGuardarCambios
        '
        Me.LabelGuardarCambios.AutoSize = True
        Me.LabelGuardarCambios.BackColor = System.Drawing.Color.Moccasin
        Me.LabelGuardarCambios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGuardarCambios.Location = New System.Drawing.Point(742, 154)
        Me.LabelGuardarCambios.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelGuardarCambios.Name = "LabelGuardarCambios"
        Me.LabelGuardarCambios.Size = New System.Drawing.Size(365, 15)
        Me.LabelGuardarCambios.TabIndex = 140
        Me.LabelGuardarCambios.Text = "Los cambios serán aplicados al presionar el botón Guardar Datos"
        Me.LabelGuardarCambios.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(193, 311)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 17)
        Me.Label4.TabIndex = 175
        Me.Label4.Text = "Perfiles que tiene el Usuario:"
        '
        'DataGridViewPerfilesXUsuario
        '
        Me.DataGridViewPerfilesXUsuario.AllowUserToAddRows = False
        Me.DataGridViewPerfilesXUsuario.AllowUserToDeleteRows = False
        Me.DataGridViewPerfilesXUsuario.AllowUserToOrderColumns = True
        Me.DataGridViewPerfilesXUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewPerfilesXUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPerfilesXUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ButtonEliminar})
        Me.DataGridViewPerfilesXUsuario.Location = New System.Drawing.Point(196, 332)
        Me.DataGridViewPerfilesXUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewPerfilesXUsuario.Name = "DataGridViewPerfilesXUsuario"
        Me.DataGridViewPerfilesXUsuario.ReadOnly = True
        Me.DataGridViewPerfilesXUsuario.RowTemplate.Height = 24
        Me.DataGridViewPerfilesXUsuario.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPerfilesXUsuario.Size = New System.Drawing.Size(789, 232)
        Me.DataGridViewPerfilesXUsuario.TabIndex = 174
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Book Antiqua", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.NullValue = "Eliminar"
        Me.ButtonEliminar.DefaultCellStyle = DataGridViewCellStyle1
        Me.ButtonEliminar.DividerWidth = 2
        Me.ButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonEliminar.HeaderText = "Seleccionar"
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.ReadOnly = True
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.Width = 71
        '
        'ButtonAgregarComision
        '
        Me.ButtonAgregarComision.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonAgregarComision.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonAgregarComision.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonAgregarComision.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonAgregarComision.Location = New System.Drawing.Point(875, 290)
        Me.ButtonAgregarComision.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAgregarComision.Name = "ButtonAgregarComision"
        Me.ButtonAgregarComision.Size = New System.Drawing.Size(110, 38)
        Me.ButtonAgregarComision.TabIndex = 176
        Me.ButtonAgregarComision.Text = "Agregar Perfil"
        Me.ButtonAgregarComision.UseVisualStyleBackColor = False
        Me.ButtonAgregarComision.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxNombreUsuario)
        Me.GroupBox1.Controls.Add(Me.TextBoxNombreApellido)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxDNI)
        Me.GroupBox1.Controls.Add(Me.TextBoxLegajo)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(360, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(335, 123)
        Me.GroupBox1.TabIndex = 177
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Usuario"
        '
        'fotoAuxiliar
        '
        Me.fotoAuxiliar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.fotoAuxiliar.Image = CType(resources.GetObject("fotoAuxiliar.Image"), System.Drawing.Image)
        Me.fotoAuxiliar.InitialImage = CType(resources.GetObject("fotoAuxiliar.InitialImage"), System.Drawing.Image)
        Me.fotoAuxiliar.Location = New System.Drawing.Point(11, 383)
        Me.fotoAuxiliar.Margin = New System.Windows.Forms.Padding(2)
        Me.fotoAuxiliar.Name = "fotoAuxiliar"
        Me.fotoAuxiliar.Size = New System.Drawing.Size(130, 130)
        Me.fotoAuxiliar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fotoAuxiliar.TabIndex = 178
        Me.fotoAuxiliar.TabStop = False
        Me.fotoAuxiliar.Visible = False
        '
        'VerMasUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 568)
        Me.ControlBox = False
        Me.Controls.Add(Me.fotoAuxiliar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonAgregarComision)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridViewPerfilesXUsuario)
        Me.Controls.Add(Me.LabelGuardarCambios)
        Me.Controls.Add(Me.ButtonresetContraseña)
        Me.Controls.Add(Me.ButtonmodificarDatos)
        Me.Controls.Add(Me.ButtonGuardarDatos)
        Me.Controls.Add(Me.ButtonExaminarFoto)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "VerMasUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewPerfilesXUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.fotoAuxiliar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelEncabezado As Label
    Friend WithEvents ButtonExaminarFoto As Button
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonresetContraseña As Button
    Friend WithEvents ButtonmodificarDatos As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxLegajo As TextBox
    Friend WithEvents TextBoxDNI As TextBox
    Friend WithEvents ButtonGuardarDatos As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNombreApellido As TextBox
    Friend WithEvents TextBoxNombreUsuario As TextBox
    Friend WithEvents LabelGuardarCambios As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridViewPerfilesXUsuario As DataGridView
    Friend WithEvents ButtonEliminar As DataGridViewButtonColumn
    Friend WithEvents ButtonAgregarComision As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents fotoAuxiliar As PictureBox
End Class
