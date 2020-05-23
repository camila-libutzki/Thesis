<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarAsistenciaProfe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarAsistenciaProfe))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxClaseDictada = New System.Windows.Forms.TextBox()
        Me.ButtonGuardarCambios = New System.Windows.Forms.Button()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.TextBoxComentarios = New System.Windows.Forms.RichTextBox()
        Me.ComboBoxAsistencia = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxFechaCursada = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(125, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 179
        Me.Label1.Text = "Clase dictada"
        '
        'TextBoxClaseDictada
        '
        Me.TextBoxClaseDictada.Location = New System.Drawing.Point(222, 59)
        Me.TextBoxClaseDictada.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxClaseDictada.Name = "TextBoxClaseDictada"
        Me.TextBoxClaseDictada.ReadOnly = True
        Me.TextBoxClaseDictada.Size = New System.Drawing.Size(109, 20)
        Me.TextBoxClaseDictada.TabIndex = 178
        '
        'ButtonGuardarCambios
        '
        Me.ButtonGuardarCambios.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonGuardarCambios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGuardarCambios.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonGuardarCambios.Location = New System.Drawing.Point(335, 237)
        Me.ButtonGuardarCambios.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonGuardarCambios.Name = "ButtonGuardarCambios"
        Me.ButtonGuardarCambios.Size = New System.Drawing.Size(117, 38)
        Me.ButtonGuardarCambios.TabIndex = 177
        Me.ButtonGuardarCambios.Text = "Guardar Cambios"
        Me.ButtonGuardarCambios.UseVisualStyleBackColor = False
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCancelar.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonCancelar.Location = New System.Drawing.Point(63, 237)
        Me.ButtonCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(86, 38)
        Me.ButtonCancelar.TabIndex = 176
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = False
        '
        'TextBoxComentarios
        '
        Me.TextBoxComentarios.Location = New System.Drawing.Point(222, 130)
        Me.TextBoxComentarios.Name = "TextBoxComentarios"
        Me.TextBoxComentarios.Size = New System.Drawing.Size(230, 102)
        Me.TextBoxComentarios.TabIndex = 175
        Me.TextBoxComentarios.Text = ""
        '
        'ComboBoxAsistencia
        '
        Me.ComboBoxAsistencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAsistencia.FormattingEnabled = True
        Me.ComboBoxAsistencia.Items.AddRange(New Object() {"Ausente", "Presente"})
        Me.ComboBoxAsistencia.Location = New System.Drawing.Point(222, 103)
        Me.ComboBoxAsistencia.Name = "ComboBoxAsistencia"
        Me.ComboBoxAsistencia.Size = New System.Drawing.Size(109, 21)
        Me.ComboBoxAsistencia.TabIndex = 174
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 108)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 173
        Me.Label3.Text = "Asistencia"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(81, 36)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 17)
        Me.Label7.TabIndex = 172
        Me.Label7.Text = "Fecha de la cursada"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(60, 132)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 17)
        Me.Label8.TabIndex = 171
        Me.Label8.Text = "Comentarios"
        '
        'TextBoxFechaCursada
        '
        Me.TextBoxFechaCursada.Location = New System.Drawing.Point(222, 35)
        Me.TextBoxFechaCursada.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxFechaCursada.Name = "TextBoxFechaCursada"
        Me.TextBoxFechaCursada.ReadOnly = True
        Me.TextBoxFechaCursada.Size = New System.Drawing.Size(109, 20)
        Me.TextBoxFechaCursada.TabIndex = 170
        '
        'ModificarAsistenciaProfe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(513, 311)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxClaseDictada)
        Me.Controls.Add(Me.ButtonGuardarCambios)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.TextBoxComentarios)
        Me.Controls.Add(Me.ComboBoxAsistencia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxFechaCursada)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModificarAsistenciaProfe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxClaseDictada As TextBox
    Friend WithEvents ButtonGuardarCambios As Button
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents TextBoxComentarios As RichTextBox
    Friend WithEvents ComboBoxAsistencia As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxFechaCursada As TextBox
End Class
