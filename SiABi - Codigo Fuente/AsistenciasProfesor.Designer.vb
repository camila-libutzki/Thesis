<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsistenciasProfesor
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
        Me.DataGridViewProfesor = New System.Windows.Forms.DataGridView()
        Me.ButtonModifAsistencia = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxCarrera = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxComision = New System.Windows.Forms.TextBox()
        Me.TextBoxMateria = New System.Windows.Forms.TextBox()
        Me.LabelConsultaAlumnos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxCargo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.inicioPractica = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.finPractica = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxDiaPractica = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxDiaTeoria = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.finTeoria = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.inicioTeoria = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxSuplente = New System.Windows.Forms.TextBox()
        Me.LabelHistorial = New System.Windows.Forms.Label()
        CType(Me.DataGridViewProfesor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        'DataGridViewProfesor
        '
        Me.DataGridViewProfesor.AllowUserToAddRows = False
        Me.DataGridViewProfesor.AllowUserToDeleteRows = False
        Me.DataGridViewProfesor.AllowUserToOrderColumns = True
        Me.DataGridViewProfesor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewProfesor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProfesor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ButtonModifAsistencia})
        Me.DataGridViewProfesor.Location = New System.Drawing.Point(11, 187)
        Me.DataGridViewProfesor.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewProfesor.Name = "DataGridViewProfesor"
        Me.DataGridViewProfesor.ReadOnly = True
        Me.DataGridViewProfesor.RowTemplate.Height = 24
        Me.DataGridViewProfesor.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewProfesor.Size = New System.Drawing.Size(1166, 382)
        Me.DataGridViewProfesor.TabIndex = 148
        '
        'ButtonModifAsistencia
        '
        Me.ButtonModifAsistencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Book Antiqua", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.NullValue = "Elegir"
        Me.ButtonModifAsistencia.DefaultCellStyle = DataGridViewCellStyle2
        Me.ButtonModifAsistencia.DividerWidth = 2
        Me.ButtonModifAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonModifAsistencia.HeaderText = "Seleccionar"
        Me.ButtonModifAsistencia.Name = "ButtonModifAsistencia"
        Me.ButtonModifAsistencia.ReadOnly = True
        Me.ButtonModifAsistencia.Text = "Elegir"
        Me.ButtonModifAsistencia.Width = 82
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 93)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 17)
        Me.Label10.TabIndex = 145
        Me.Label10.Text = "Carrera"
        '
        'TextBoxCarrera
        '
        Me.TextBoxCarrera.Location = New System.Drawing.Point(83, 92)
        Me.TextBoxCarrera.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxCarrera.Name = "TextBoxCarrera"
        Me.TextBoxCarrera.ReadOnly = True
        Me.TextBoxCarrera.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxCarrera.TabIndex = 144
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 141)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "Comisión"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "Materia"
        '
        'TextBoxComision
        '
        Me.TextBoxComision.Location = New System.Drawing.Point(83, 140)
        Me.TextBoxComision.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxComision.Name = "TextBoxComision"
        Me.TextBoxComision.ReadOnly = True
        Me.TextBoxComision.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxComision.TabIndex = 141
        '
        'TextBoxMateria
        '
        Me.TextBoxMateria.Location = New System.Drawing.Point(83, 116)
        Me.TextBoxMateria.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxMateria.Name = "TextBoxMateria"
        Me.TextBoxMateria.ReadOnly = True
        Me.TextBoxMateria.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxMateria.TabIndex = 140
        '
        'LabelConsultaAlumnos
        '
        Me.LabelConsultaAlumnos.AutoSize = True
        Me.LabelConsultaAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelConsultaAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LabelConsultaAlumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConsultaAlumnos.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelConsultaAlumnos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LabelConsultaAlumnos.Location = New System.Drawing.Point(11, 45)
        Me.LabelConsultaAlumnos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelConsultaAlumnos.Name = "LabelConsultaAlumnos"
        Me.LabelConsultaAlumnos.Size = New System.Drawing.Size(217, 26)
        Me.LabelConsultaAlumnos.TabIndex = 139
        Me.LabelConsultaAlumnos.Text = "Detalle de Asistencias"
        Me.LabelConsultaAlumnos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(825, 165)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 17)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "Cargo del Profesor"
        '
        'TextBoxCargo
        '
        Me.TextBoxCargo.Location = New System.Drawing.Point(956, 164)
        Me.TextBoxCargo.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxCargo.Name = "TextBoxCargo"
        Me.TextBoxCargo.ReadOnly = True
        Me.TextBoxCargo.Size = New System.Drawing.Size(113, 20)
        Me.TextBoxCargo.TabIndex = 149
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(8, 41)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 15)
        Me.Label4.TabIndex = 152
        Me.Label4.Text = "Hora Inicio Clase"
        '
        'inicioPractica
        '
        Me.inicioPractica.Location = New System.Drawing.Point(113, 40)
        Me.inicioPractica.Margin = New System.Windows.Forms.Padding(2)
        Me.inicioPractica.Name = "inicioPractica"
        Me.inicioPractica.ReadOnly = True
        Me.inicioPractica.Size = New System.Drawing.Size(59, 20)
        Me.inicioPractica.TabIndex = 151
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(21, 65)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 15)
        Me.Label5.TabIndex = 154
        Me.Label5.Text = "Hora Fin Clase"
        '
        'finPractica
        '
        Me.finPractica.Location = New System.Drawing.Point(113, 64)
        Me.finPractica.Margin = New System.Windows.Forms.Padding(2)
        Me.finPractica.Name = "finPractica"
        Me.finPractica.ReadOnly = True
        Me.finPractica.Size = New System.Drawing.Size(59, 20)
        Me.finPractica.TabIndex = 153
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBoxDiaPractica)
        Me.GroupBox1.Controls.Add(Me.finPractica)
        Me.GroupBox1.Controls.Add(Me.inicioPractica)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(302, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(177, 89)
        Me.GroupBox1.TabIndex = 155
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Horario Práctica"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(36, 18)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 15)
        Me.Label8.TabIndex = 156
        Me.Label8.Text = "Día cursada"
        '
        'TextBoxDiaPractica
        '
        Me.TextBoxDiaPractica.Location = New System.Drawing.Point(113, 16)
        Me.TextBoxDiaPractica.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxDiaPractica.Name = "TextBoxDiaPractica"
        Me.TextBoxDiaPractica.ReadOnly = True
        Me.TextBoxDiaPractica.Size = New System.Drawing.Size(59, 20)
        Me.TextBoxDiaPractica.TabIndex = 155
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBoxDiaTeoria)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.finTeoria)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.inicioTeoria)
        Me.GroupBox2.Location = New System.Drawing.Point(485, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(177, 89)
        Me.GroupBox2.TabIndex = 156
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Horario Teoría"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(8, 41)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 15)
        Me.Label6.TabIndex = 152
        Me.Label6.Text = "Hora Inicio Clase"
        '
        'TextBoxDiaTeoria
        '
        Me.TextBoxDiaTeoria.Location = New System.Drawing.Point(113, 16)
        Me.TextBoxDiaTeoria.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxDiaTeoria.Name = "TextBoxDiaTeoria"
        Me.TextBoxDiaTeoria.ReadOnly = True
        Me.TextBoxDiaTeoria.Size = New System.Drawing.Size(59, 20)
        Me.TextBoxDiaTeoria.TabIndex = 157
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(36, 18)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 15)
        Me.Label9.TabIndex = 158
        Me.Label9.Text = "Día cursada"
        '
        'finTeoria
        '
        Me.finTeoria.Location = New System.Drawing.Point(113, 64)
        Me.finTeoria.Margin = New System.Windows.Forms.Padding(2)
        Me.finTeoria.Name = "finTeoria"
        Me.finTeoria.ReadOnly = True
        Me.finTeoria.Size = New System.Drawing.Size(59, 20)
        Me.finTeoria.TabIndex = 153
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(21, 65)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 15)
        Me.Label7.TabIndex = 154
        Me.Label7.Text = "Hora Fin Clase"
        '
        'inicioTeoria
        '
        Me.inicioTeoria.Location = New System.Drawing.Point(113, 40)
        Me.inicioTeoria.Margin = New System.Windows.Forms.Padding(2)
        Me.inicioTeoria.Name = "inicioTeoria"
        Me.inicioTeoria.ReadOnly = True
        Me.inicioTeoria.Size = New System.Drawing.Size(59, 20)
        Me.inicioTeoria.TabIndex = 151
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1073, 164)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 17)
        Me.Label11.TabIndex = 158
        Me.Label11.Text = "Suplente"
        '
        'TextBoxSuplente
        '
        Me.TextBoxSuplente.Location = New System.Drawing.Point(1141, 163)
        Me.TextBoxSuplente.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxSuplente.Name = "TextBoxSuplente"
        Me.TextBoxSuplente.ReadOnly = True
        Me.TextBoxSuplente.Size = New System.Drawing.Size(36, 20)
        Me.TextBoxSuplente.TabIndex = 157
        '
        'LabelHistorial
        '
        Me.LabelHistorial.AutoSize = True
        Me.LabelHistorial.BackColor = System.Drawing.Color.Moccasin
        Me.LabelHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelHistorial.Location = New System.Drawing.Point(13, 168)
        Me.LabelHistorial.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelHistorial.Name = "LabelHistorial"
        Me.LabelHistorial.Size = New System.Drawing.Size(440, 17)
        Me.LabelHistorial.TabIndex = 171
        Me.LabelHistorial.Text = "La materia no tiene historial de asistencias para el año seleccionado"
        Me.LabelHistorial.Visible = False
        '
        'AsistenciasProfesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 568)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelHistorial)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBoxSuplente)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxCargo)
        Me.Controls.Add(Me.DataGridViewProfesor)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBoxCarrera)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxComision)
        Me.Controls.Add(Me.TextBoxMateria)
        Me.Controls.Add(Me.LabelConsultaAlumnos)
        Me.Controls.Add(Me.LabelEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AsistenciasProfesor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.DataGridViewProfesor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelEncabezado As Label
    Friend WithEvents DataGridViewProfesor As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxCarrera As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxComision As TextBox
    Friend WithEvents TextBoxMateria As TextBox
    Friend WithEvents LabelConsultaAlumnos As Label
    Friend WithEvents ButtonModifAsistencia As DataGridViewButtonColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxCargo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents inicioPractica As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents finPractica As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents inicioTeoria As TextBox
    Friend WithEvents finTeoria As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxDiaPractica As TextBox
    Friend WithEvents TextBoxDiaTeoria As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBoxSuplente As TextBox
    Friend WithEvents LabelHistorial As Label
End Class
