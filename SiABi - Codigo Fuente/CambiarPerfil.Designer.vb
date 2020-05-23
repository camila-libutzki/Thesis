<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambiarPerfil
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridViewPerfilesXUsuario = New System.Windows.Forms.DataGridView()
        Me.ButtonElegir = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ButtonCerrar = New System.Windows.Forms.Button()
        CType(Me.DataGridViewPerfilesXUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(36, 37)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 17)
        Me.Label4.TabIndex = 178
        Me.Label4.Text = "Perfiles disponibles para usar:"
        '
        'DataGridViewPerfilesXUsuario
        '
        Me.DataGridViewPerfilesXUsuario.AllowUserToAddRows = False
        Me.DataGridViewPerfilesXUsuario.AllowUserToDeleteRows = False
        Me.DataGridViewPerfilesXUsuario.AllowUserToOrderColumns = True
        Me.DataGridViewPerfilesXUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPerfilesXUsuario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewPerfilesXUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPerfilesXUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ButtonElegir})
        Me.DataGridViewPerfilesXUsuario.Location = New System.Drawing.Point(39, 60)
        Me.DataGridViewPerfilesXUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewPerfilesXUsuario.Name = "DataGridViewPerfilesXUsuario"
        Me.DataGridViewPerfilesXUsuario.ReadOnly = True
        Me.DataGridViewPerfilesXUsuario.RowTemplate.Height = 24
        Me.DataGridViewPerfilesXUsuario.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPerfilesXUsuario.Size = New System.Drawing.Size(668, 237)
        Me.DataGridViewPerfilesXUsuario.TabIndex = 177
        '
        'ButtonElegir
        '
        Me.ButtonElegir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Book Antiqua", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.NullValue = "Elegir"
        Me.ButtonElegir.DefaultCellStyle = DataGridViewCellStyle2
        Me.ButtonElegir.DividerWidth = 2
        Me.ButtonElegir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonElegir.HeaderText = "Seleccionar"
        Me.ButtonElegir.Name = "ButtonElegir"
        Me.ButtonElegir.ReadOnly = True
        Me.ButtonElegir.Text = "Elegir"
        Me.ButtonElegir.Width = 82
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonCerrar.Location = New System.Drawing.Point(39, 301)
        Me.ButtonCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(100, 38)
        Me.ButtonCerrar.TabIndex = 180
        Me.ButtonCerrar.Text = "Cerrar"
        Me.ButtonCerrar.UseVisualStyleBackColor = False
        '
        'CambiarPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(741, 361)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonCerrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridViewPerfilesXUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CambiarPerfil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridViewPerfilesXUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridViewPerfilesXUsuario As DataGridView
    Friend WithEvents ButtonElegir As DataGridViewButtonColumn
    Friend WithEvents ButtonCerrar As Button
End Class
