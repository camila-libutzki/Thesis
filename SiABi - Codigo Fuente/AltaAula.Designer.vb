<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaAula
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltaAula))
        Me.ComboBoxEstadoLector = New System.Windows.Forms.ComboBox()
        Me.TextBoxSerialLector = New System.Windows.Forms.TextBox()
        Me.TextBoxNumeroAula = New System.Windows.Forms.TextBox()
        Me.ComboBoxEdificio = New System.Windows.Forms.ComboBox()
        Me.LabelEstado = New System.Windows.Forms.Label()
        Me.LabelEdificio = New System.Windows.Forms.Label()
        Me.LabelSerial = New System.Windows.Forms.Label()
        Me.LabelAula = New System.Windows.Forms.Label()
        Me.ButtonDardeAlta = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MateriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        CType(Me.MateriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxEstadoLector
        '
        Me.ComboBoxEstadoLector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEstadoLector.FormattingEnabled = True
        Me.ComboBoxEstadoLector.Items.AddRange(New Object() {"Online", "OFFLINE"})
        Me.ComboBoxEstadoLector.Location = New System.Drawing.Point(209, 135)
        Me.ComboBoxEstadoLector.Name = "ComboBoxEstadoLector"
        Me.ComboBoxEstadoLector.Size = New System.Drawing.Size(166, 21)
        Me.ComboBoxEstadoLector.TabIndex = 113
        '
        'TextBoxSerialLector
        '
        Me.TextBoxSerialLector.Location = New System.Drawing.Point(209, 162)
        Me.TextBoxSerialLector.Name = "TextBoxSerialLector"
        Me.TextBoxSerialLector.Size = New System.Drawing.Size(166, 20)
        Me.TextBoxSerialLector.TabIndex = 111
        '
        'TextBoxNumeroAula
        '
        Me.TextBoxNumeroAula.Location = New System.Drawing.Point(209, 83)
        Me.TextBoxNumeroAula.Name = "TextBoxNumeroAula"
        Me.TextBoxNumeroAula.Size = New System.Drawing.Size(166, 20)
        Me.TextBoxNumeroAula.TabIndex = 110
        '
        'ComboBoxEdificio
        '
        Me.ComboBoxEdificio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEdificio.FormattingEnabled = True
        Me.ComboBoxEdificio.Items.AddRange(New Object() {"Sistemas", "Industrial", "Mecanica", "Quimica", "Electrica", "Civil"})
        Me.ComboBoxEdificio.Location = New System.Drawing.Point(209, 108)
        Me.ComboBoxEdificio.Name = "ComboBoxEdificio"
        Me.ComboBoxEdificio.Size = New System.Drawing.Size(166, 21)
        Me.ComboBoxEdificio.TabIndex = 109
        '
        'LabelEstado
        '
        Me.LabelEstado.AutoSize = True
        Me.LabelEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.LabelEstado.Location = New System.Drawing.Point(90, 136)
        Me.LabelEstado.Name = "LabelEstado"
        Me.LabelEstado.Size = New System.Drawing.Size(113, 16)
        Me.LabelEstado.TabIndex = 108
        Me.LabelEstado.Text = "Estado del Lector"
        '
        'LabelEdificio
        '
        Me.LabelEdificio.AutoSize = True
        Me.LabelEdificio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.LabelEdificio.Location = New System.Drawing.Point(151, 109)
        Me.LabelEdificio.Name = "LabelEdificio"
        Me.LabelEdificio.Size = New System.Drawing.Size(52, 16)
        Me.LabelEdificio.TabIndex = 107
        Me.LabelEdificio.Text = "Edificio"
        '
        'LabelSerial
        '
        Me.LabelSerial.AutoSize = True
        Me.LabelSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSerial.Location = New System.Drawing.Point(98, 163)
        Me.LabelSerial.Name = "LabelSerial"
        Me.LabelSerial.Size = New System.Drawing.Size(105, 16)
        Me.LabelSerial.TabIndex = 105
        Me.LabelSerial.Text = "Serial del Lector"
        '
        'LabelAula
        '
        Me.LabelAula.AutoSize = True
        Me.LabelAula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAula.Location = New System.Drawing.Point(98, 84)
        Me.LabelAula.Name = "LabelAula"
        Me.LabelAula.Size = New System.Drawing.Size(105, 16)
        Me.LabelAula.TabIndex = 104
        Me.LabelAula.Text = "Número de Aula"
        '
        'ButtonDardeAlta
        '
        Me.ButtonDardeAlta.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonDardeAlta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDardeAlta.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonDardeAlta.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonDardeAlta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonDardeAlta.Location = New System.Drawing.Point(303, 196)
        Me.ButtonDardeAlta.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonDardeAlta.Name = "ButtonDardeAlta"
        Me.ButtonDardeAlta.Size = New System.Drawing.Size(86, 38)
        Me.ButtonDardeAlta.TabIndex = 158
        Me.ButtonDardeAlta.Text = "Dar de Alta"
        Me.ButtonDardeAlta.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 16)
        Me.Label2.TabIndex = 166
        Me.Label2.Text = "Complete los siguientes campos"
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCancelar.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonCancelar.Location = New System.Drawing.Point(101, 226)
        Me.ButtonCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(86, 38)
        Me.ButtonCancelar.TabIndex = 176
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = False
        '
        'AltaAula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(500, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonDardeAlta)
        Me.Controls.Add(Me.ComboBoxEstadoLector)
        Me.Controls.Add(Me.TextBoxSerialLector)
        Me.Controls.Add(Me.TextBoxNumeroAula)
        Me.Controls.Add(Me.ComboBoxEdificio)
        Me.Controls.Add(Me.LabelEstado)
        Me.Controls.Add(Me.LabelEdificio)
        Me.Controls.Add(Me.LabelSerial)
        Me.Controls.Add(Me.LabelAula)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AltaAula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.MateriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxEstadoLector As ComboBox
    Friend WithEvents TextBoxSerialLector As TextBox
    Friend WithEvents TextBoxNumeroAula As TextBox
    Friend WithEvents ComboBoxEdificio As ComboBox
    Friend WithEvents LabelEstado As Label
    Friend WithEvents LabelEdificio As Label
    Friend WithEvents LabelSerial As Label
    Friend WithEvents LabelAula As Label
    Friend WithEvents ButtonDardeAlta As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents MateriaBindingSource As BindingSource
    Friend WithEvents ButtonCancelar As Button
End Class
