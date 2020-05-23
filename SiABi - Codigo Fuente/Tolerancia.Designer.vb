<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tolerancia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tolerancia))
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.ButtonDardeAlta = New System.Windows.Forms.Button()
        Me.ComboBoxMargen = New System.Windows.Forms.ComboBox()
        Me.ComboBoxTolerancia = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxSalida = New System.Windows.Forms.ComboBox()
        Me.margenEntrada = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.toleranciaEntrada = New System.Windows.Forms.RichTextBox()
        Me.margenSalida = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCancelar.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonCancelar.Location = New System.Drawing.Point(37, 265)
        Me.ButtonCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(80, 38)
        Me.ButtonCancelar.TabIndex = 179
        Me.ButtonCancelar.Text = "Cerrar"
        Me.ButtonCancelar.UseVisualStyleBackColor = False
        '
        'ButtonDardeAlta
        '
        Me.ButtonDardeAlta.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ButtonDardeAlta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDardeAlta.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonDardeAlta.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonDardeAlta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonDardeAlta.Location = New System.Drawing.Point(441, 223)
        Me.ButtonDardeAlta.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonDardeAlta.Name = "ButtonDardeAlta"
        Me.ButtonDardeAlta.Size = New System.Drawing.Size(86, 38)
        Me.ButtonDardeAlta.TabIndex = 178
        Me.ButtonDardeAlta.Text = "Actualizar"
        Me.ButtonDardeAlta.UseVisualStyleBackColor = False
        '
        'ComboBoxMargen
        '
        Me.ComboBoxMargen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMargen.FormattingEnabled = True
        Me.ComboBoxMargen.Items.AddRange(New Object() {"5", "10", "15", "20", "25"})
        Me.ComboBoxMargen.Location = New System.Drawing.Point(437, 3)
        Me.ComboBoxMargen.Name = "ComboBoxMargen"
        Me.ComboBoxMargen.Size = New System.Drawing.Size(44, 21)
        Me.ComboBoxMargen.TabIndex = 214
        '
        'ComboBoxTolerancia
        '
        Me.ComboBoxTolerancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTolerancia.FormattingEnabled = True
        Me.ComboBoxTolerancia.Items.AddRange(New Object() {"5", "10", "15", "20", "25", "30", "35", "40"})
        Me.ComboBoxTolerancia.Location = New System.Drawing.Point(437, 50)
        Me.ComboBoxTolerancia.Name = "ComboBoxTolerancia"
        Me.ComboBoxTolerancia.Size = New System.Drawing.Size(44, 21)
        Me.ComboBoxTolerancia.TabIndex = 216
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(110, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(341, 16)
        Me.Label7.TabIndex = 218
        Me.Label7.Text = "Actualizar los márgenes de entrada y salida a una clase"
        '
        'ComboBoxSalida
        '
        Me.ComboBoxSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSalida.FormattingEnabled = True
        Me.ComboBoxSalida.Items.AddRange(New Object() {"0", "5", "10", "15", "20", "25", "30", "35", "40"})
        Me.ComboBoxSalida.Location = New System.Drawing.Point(437, 97)
        Me.ComboBoxSalida.Name = "ComboBoxSalida"
        Me.ComboBoxSalida.Size = New System.Drawing.Size(44, 21)
        Me.ComboBoxSalida.TabIndex = 221
        '
        'margenEntrada
        '
        Me.margenEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.margenEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.margenEntrada.Location = New System.Drawing.Point(3, 3)
        Me.margenEntrada.Name = "margenEntrada"
        Me.margenEntrada.ReadOnly = True
        Me.margenEntrada.Size = New System.Drawing.Size(428, 41)
        Me.margenEntrada.TabIndex = 223
        Me.margenEntrada.Text = "Ingrese los minutos de margen de inicio que tiene el profesor para ingresar a la " &
    "clase antes de la hora de inicio oficial:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.97595!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.02405!))
        Me.TableLayoutPanel1.Controls.Add(Me.margenEntrada, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.toleranciaEntrada, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.margenSalida, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBoxSalida, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBoxMargen, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBoxTolerancia, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(46, 75)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(494, 143)
        Me.TableLayoutPanel1.TabIndex = 224
        '
        'toleranciaEntrada
        '
        Me.toleranciaEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.toleranciaEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.toleranciaEntrada.Location = New System.Drawing.Point(3, 50)
        Me.toleranciaEntrada.Name = "toleranciaEntrada"
        Me.toleranciaEntrada.ReadOnly = True
        Me.toleranciaEntrada.Size = New System.Drawing.Size(428, 41)
        Me.toleranciaEntrada.TabIndex = 224
        Me.toleranciaEntrada.Text = "Ingrese los minutos de tolerancia que se permite esperar al profesor para dar ini" &
    "cio a la clase:"
        '
        'margenSalida
        '
        Me.margenSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.margenSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.margenSalida.Location = New System.Drawing.Point(3, 97)
        Me.margenSalida.Name = "margenSalida"
        Me.margenSalida.ReadOnly = True
        Me.margenSalida.Size = New System.Drawing.Size(428, 43)
        Me.margenSalida.TabIndex = 225
        Me.margenSalida.Text = "Ingrese los minutos de margen de fin que tiene el profesor para marcar la salida " &
    "antes que la clase se cierre automáticamente:"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Tolerancia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(580, 316)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.ButtonDardeAlta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tolerancia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents ButtonDardeAlta As Button
    Friend WithEvents ComboBoxMargen As ComboBox
    Friend WithEvents ComboBoxTolerancia As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxSalida As ComboBox
    Friend WithEvents margenEntrada As RichTextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents toleranciaEntrada As RichTextBox
    Friend WithEvents margenSalida As RichTextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
