<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarPerfilUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarPerfilUsuario))
        Me.ButtonAgregarComision = New System.Windows.Forms.Button()
        Me.ButtonCerrar = New System.Windows.Forms.Button()
        Me.LabelCat = New System.Windows.Forms.Label()
        Me.ComboBoxDpto = New System.Windows.Forms.ComboBox()
        Me.LabelDpto = New System.Windows.Forms.Label()
        Me.ComboBoxCatedra = New System.Windows.Forms.ComboBox()
        Me.ComboBoxTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonAgregarComision
        '
        Me.ButtonAgregarComision.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonAgregarComision.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonAgregarComision.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonAgregarComision.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonAgregarComision.Location = New System.Drawing.Point(284, 189)
        Me.ButtonAgregarComision.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAgregarComision.Name = "ButtonAgregarComision"
        Me.ButtonAgregarComision.Size = New System.Drawing.Size(110, 38)
        Me.ButtonAgregarComision.TabIndex = 172
        Me.ButtonAgregarComision.Text = "Agregar Perfil"
        Me.ButtonAgregarComision.UseVisualStyleBackColor = False
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonCerrar.Location = New System.Drawing.Point(72, 221)
        Me.ButtonCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(82, 38)
        Me.ButtonCerrar.TabIndex = 175
        Me.ButtonCerrar.Text = "Cerrar"
        Me.ButtonCerrar.UseVisualStyleBackColor = False
        '
        'LabelCat
        '
        Me.LabelCat.AutoSize = True
        Me.LabelCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelCat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelCat.Location = New System.Drawing.Point(120, 136)
        Me.LabelCat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelCat.Name = "LabelCat"
        Me.LabelCat.Size = New System.Drawing.Size(58, 17)
        Me.LabelCat.TabIndex = 181
        Me.LabelCat.Text = "Cátedra"
        '
        'ComboBoxDpto
        '
        Me.ComboBoxDpto.AccessibleDescription = ""
        Me.ComboBoxDpto.AccessibleName = ""
        Me.ComboBoxDpto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDpto.FormattingEnabled = True
        Me.ComboBoxDpto.Items.AddRange(New Object() {"Sistemas", "Industrial", "Mecanica", "Quimica", "Electrica"})
        Me.ComboBoxDpto.Location = New System.Drawing.Point(182, 110)
        Me.ComboBoxDpto.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxDpto.Name = "ComboBoxDpto"
        Me.ComboBoxDpto.Size = New System.Drawing.Size(212, 21)
        Me.ComboBoxDpto.TabIndex = 180
        '
        'LabelDpto
        '
        Me.LabelDpto.AutoSize = True
        Me.LabelDpto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelDpto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelDpto.Location = New System.Drawing.Point(80, 111)
        Me.LabelDpto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDpto.Name = "LabelDpto"
        Me.LabelDpto.Size = New System.Drawing.Size(98, 17)
        Me.LabelDpto.TabIndex = 179
        Me.LabelDpto.Text = "Departamento"
        '
        'ComboBoxCatedra
        '
        Me.ComboBoxCatedra.AccessibleDescription = ""
        Me.ComboBoxCatedra.AccessibleName = ""
        Me.ComboBoxCatedra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCatedra.FormattingEnabled = True
        Me.ComboBoxCatedra.Location = New System.Drawing.Point(182, 135)
        Me.ComboBoxCatedra.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxCatedra.Name = "ComboBoxCatedra"
        Me.ComboBoxCatedra.Size = New System.Drawing.Size(212, 21)
        Me.ComboBoxCatedra.TabIndex = 178
        '
        'ComboBoxTipo
        '
        Me.ComboBoxTipo.AccessibleDescription = ""
        Me.ComboBoxTipo.AccessibleName = ""
        Me.ComboBoxTipo.Cursor = System.Windows.Forms.Cursors.Default
        Me.ComboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTipo.FormattingEnabled = True
        Me.ComboBoxTipo.Items.AddRange(New Object() {"Administrador", "Bedel", "Jefe de Cátedra", "Jefe de Departamento"})
        Me.ComboBoxTipo.Location = New System.Drawing.Point(182, 85)
        Me.ComboBoxTipo.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxTipo.Name = "ComboBoxTipo"
        Me.ComboBoxTipo.Size = New System.Drawing.Size(212, 21)
        Me.ComboBoxTipo.TabIndex = 177
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(69, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 176
        Me.Label2.Text = "Tipo de Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(69, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 17)
        Me.Label1.TabIndex = 182
        Me.Label1.Text = "Seleccione la combinación deseada para el nuevo perfil"
        '
        'AgregarPerfilUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(500, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelCat)
        Me.Controls.Add(Me.ComboBoxDpto)
        Me.Controls.Add(Me.LabelDpto)
        Me.Controls.Add(Me.ComboBoxCatedra)
        Me.Controls.Add(Me.ComboBoxTipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonCerrar)
        Me.Controls.Add(Me.ButtonAgregarComision)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AgregarPerfilUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonAgregarComision As Button
    Friend WithEvents ButtonCerrar As Button
    Friend WithEvents LabelCat As Label
    Friend WithEvents ComboBoxDpto As ComboBox
    Friend WithEvents LabelDpto As Label
    Friend WithEvents ComboBoxCatedra As ComboBox
    Friend WithEvents ComboBoxTipo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
