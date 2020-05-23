<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AltaCatedraComision
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltaCatedraComision))
        Me.ComboBoxCatedra = New System.Windows.Forms.ComboBox()
        Me.LabeCatedra = New System.Windows.Forms.Label()
        Me.ButtonDardeAlta = New System.Windows.Forms.Button()
        Me.LabelComision = New System.Windows.Forms.Label()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.ComboBoxComision = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxCarrera = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBoxCatedra
        '
        Me.ComboBoxCatedra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCatedra.FormattingEnabled = True
        Me.ComboBoxCatedra.Location = New System.Drawing.Point(167, 117)
        Me.ComboBoxCatedra.Name = "ComboBoxCatedra"
        Me.ComboBoxCatedra.Size = New System.Drawing.Size(229, 21)
        Me.ComboBoxCatedra.TabIndex = 174
        '
        'LabeCatedra
        '
        Me.LabeCatedra.AutoSize = True
        Me.LabeCatedra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.LabeCatedra.Location = New System.Drawing.Point(105, 118)
        Me.LabeCatedra.Name = "LabeCatedra"
        Me.LabeCatedra.Size = New System.Drawing.Size(56, 16)
        Me.LabeCatedra.TabIndex = 173
        Me.LabeCatedra.Text = "Cátedra"
        '
        'ButtonDardeAlta
        '
        Me.ButtonDardeAlta.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonDardeAlta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDardeAlta.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonDardeAlta.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonDardeAlta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonDardeAlta.Location = New System.Drawing.Point(310, 176)
        Me.ButtonDardeAlta.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonDardeAlta.Name = "ButtonDardeAlta"
        Me.ButtonDardeAlta.Size = New System.Drawing.Size(86, 38)
        Me.ButtonDardeAlta.TabIndex = 172
        Me.ButtonDardeAlta.Text = "Dar de Alta"
        Me.ButtonDardeAlta.UseVisualStyleBackColor = False
        '
        'LabelComision
        '
        Me.LabelComision.AutoSize = True
        Me.LabelComision.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.LabelComision.Location = New System.Drawing.Point(97, 145)
        Me.LabelComision.Name = "LabelComision"
        Me.LabelComision.Size = New System.Drawing.Size(64, 16)
        Me.LabelComision.TabIndex = 168
        Me.LabelComision.Text = "Comisión"
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCancelar.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonCancelar.Location = New System.Drawing.Point(98, 222)
        Me.ButtonCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(86, 38)
        Me.ButtonCancelar.TabIndex = 175
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = False
        '
        'ComboBoxComision
        '
        Me.ComboBoxComision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxComision.FormattingEnabled = True
        Me.ComboBoxComision.Location = New System.Drawing.Point(167, 144)
        Me.ComboBoxComision.Name = "ComboBoxComision"
        Me.ComboBoxComision.Size = New System.Drawing.Size(131, 21)
        Me.ComboBoxComision.TabIndex = 176
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(95, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 16)
        Me.Label2.TabIndex = 177
        Me.Label2.Text = "Complete los siguientes campos"
        '
        'ComboBoxCarrera
        '
        Me.ComboBoxCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCarrera.FormattingEnabled = True
        Me.ComboBoxCarrera.Items.AddRange(New Object() {"Sistemas", "Industrial", "Mecanica", "Quimica", "Electrica"})
        Me.ComboBoxCarrera.Location = New System.Drawing.Point(167, 90)
        Me.ComboBoxCarrera.Name = "ComboBoxCarrera"
        Me.ComboBoxCarrera.Size = New System.Drawing.Size(131, 21)
        Me.ComboBoxCarrera.TabIndex = 179
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(108, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 178
        Me.Label1.Text = "Carrera"
        '
        'AltaCatedraComision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(500, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.ComboBoxCarrera)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxComision)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.ComboBoxCatedra)
        Me.Controls.Add(Me.LabeCatedra)
        Me.Controls.Add(Me.ButtonDardeAlta)
        Me.Controls.Add(Me.LabelComision)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AltaCatedraComision"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxCatedra As ComboBox
    Friend WithEvents LabeCatedra As Label
    Friend WithEvents ButtonDardeAlta As Button
    Friend WithEvents LabelComision As Label
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents ComboBoxComision As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxCarrera As ComboBox
    Friend WithEvents Label1 As Label
End Class
