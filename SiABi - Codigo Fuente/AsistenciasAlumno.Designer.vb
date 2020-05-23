<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AsistenciasAlumno
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LabelEncabezado = New System.Windows.Forms.Label()
        Me.DataGridAsistenciasAlumno = New System.Windows.Forms.DataGridView()
        Me.ButtonEditarAsistencias = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxInasistenciasAlumno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxInasistenciasPermitidas = New System.Windows.Forms.TextBox()
        Me.TextBoxEstadoCursada = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxCarreraA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxComisionA = New System.Windows.Forms.TextBox()
        Me.TextBoxMateriaA = New System.Windows.Forms.TextBox()
        Me.LabelConsultaAlumnos = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxHsFaltasTeoria = New System.Windows.Forms.TextBox()
        Me.LabelHistorial = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxHsFaltasPractica = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxAñoCursada = New System.Windows.Forms.TextBox()
        CType(Me.DataGridAsistenciasAlumno, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LabelEncabezado.TabIndex = 89
        Me.LabelEncabezado.Text = "UTN - FRLP - Sistema de Asistencia Biométrico"
        Me.LabelEncabezado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataGridAsistenciasAlumno
        '
        Me.DataGridAsistenciasAlumno.AllowUserToAddRows = False
        Me.DataGridAsistenciasAlumno.AllowUserToDeleteRows = False
        Me.DataGridAsistenciasAlumno.AllowUserToOrderColumns = True
        Me.DataGridAsistenciasAlumno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridAsistenciasAlumno.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridAsistenciasAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridAsistenciasAlumno.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ButtonEditarAsistencias})
        Me.DataGridAsistenciasAlumno.Location = New System.Drawing.Point(316, 117)
        Me.DataGridAsistenciasAlumno.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridAsistenciasAlumno.Name = "DataGridAsistenciasAlumno"
        Me.DataGridAsistenciasAlumno.ReadOnly = True
        Me.DataGridAsistenciasAlumno.RowTemplate.Height = 24
        Me.DataGridAsistenciasAlumno.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridAsistenciasAlumno.Size = New System.Drawing.Size(861, 451)
        Me.DataGridAsistenciasAlumno.TabIndex = 137
        '
        'ButtonEditarAsistencias
        '
        Me.ButtonEditarAsistencias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Book Antiqua", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.NullValue = "Editar"
        Me.ButtonEditarAsistencias.DefaultCellStyle = DataGridViewCellStyle2
        Me.ButtonEditarAsistencias.DividerWidth = 2
        Me.ButtonEditarAsistencias.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonEditarAsistencias.HeaderText = "Seleccionar"
        Me.ButtonEditarAsistencias.Name = "ButtonEditarAsistencias"
        Me.ButtonEditarAsistencias.ReadOnly = True
        Me.ButtonEditarAsistencias.Text = "Editar"
        Me.ButtonEditarAsistencias.Width = 82
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 19)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 17)
        Me.Label6.TabIndex = 136
        Me.Label6.Text = "Inasistencias del alumno"
        '
        'TextBoxInasistenciasAlumno
        '
        Me.TextBoxInasistenciasAlumno.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxInasistenciasAlumno.Location = New System.Drawing.Point(171, 18)
        Me.TextBoxInasistenciasAlumno.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxInasistenciasAlumno.Name = "TextBoxInasistenciasAlumno"
        Me.TextBoxInasistenciasAlumno.ReadOnly = True
        Me.TextBoxInasistenciasAlumno.Size = New System.Drawing.Size(82, 20)
        Me.TextBoxInasistenciasAlumno.TabIndex = 135
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 19)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 17)
        Me.Label4.TabIndex = 132
        Me.Label4.Text = "Inasistencias permitidas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 43)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 17)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "Estado de cursada"
        '
        'TextBoxInasistenciasPermitidas
        '
        Me.TextBoxInasistenciasPermitidas.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxInasistenciasPermitidas.Location = New System.Drawing.Point(164, 18)
        Me.TextBoxInasistenciasPermitidas.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxInasistenciasPermitidas.Name = "TextBoxInasistenciasPermitidas"
        Me.TextBoxInasistenciasPermitidas.ReadOnly = True
        Me.TextBoxInasistenciasPermitidas.Size = New System.Drawing.Size(82, 20)
        Me.TextBoxInasistenciasPermitidas.TabIndex = 130
        '
        'TextBoxEstadoCursada
        '
        Me.TextBoxEstadoCursada.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxEstadoCursada.Location = New System.Drawing.Point(171, 42)
        Me.TextBoxEstadoCursada.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxEstadoCursada.Name = "TextBoxEstadoCursada"
        Me.TextBoxEstadoCursada.ReadOnly = True
        Me.TextBoxEstadoCursada.Size = New System.Drawing.Size(82, 20)
        Me.TextBoxEstadoCursada.TabIndex = 129
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(25, 118)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 17)
        Me.Label10.TabIndex = 128
        Me.Label10.Text = "Carrera"
        '
        'TextBoxCarreraA
        '
        Me.TextBoxCarreraA.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxCarreraA.Location = New System.Drawing.Point(84, 117)
        Me.TextBoxCarreraA.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxCarreraA.Name = "TextBoxCarreraA"
        Me.TextBoxCarreraA.ReadOnly = True
        Me.TextBoxCarreraA.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxCarreraA.TabIndex = 127
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 166)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "Comisión"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 142)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "Materia"
        '
        'TextBoxComisionA
        '
        Me.TextBoxComisionA.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxComisionA.Location = New System.Drawing.Point(84, 165)
        Me.TextBoxComisionA.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxComisionA.Name = "TextBoxComisionA"
        Me.TextBoxComisionA.ReadOnly = True
        Me.TextBoxComisionA.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxComisionA.TabIndex = 124
        '
        'TextBoxMateriaA
        '
        Me.TextBoxMateriaA.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxMateriaA.Location = New System.Drawing.Point(84, 141)
        Me.TextBoxMateriaA.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxMateriaA.Name = "TextBoxMateriaA"
        Me.TextBoxMateriaA.ReadOnly = True
        Me.TextBoxMateriaA.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxMateriaA.TabIndex = 123
        '
        'LabelConsultaAlumnos
        '
        Me.LabelConsultaAlumnos.AutoSize = True
        Me.LabelConsultaAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelConsultaAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LabelConsultaAlumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConsultaAlumnos.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelConsultaAlumnos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LabelConsultaAlumnos.Location = New System.Drawing.Point(11, 65)
        Me.LabelConsultaAlumnos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelConsultaAlumnos.Name = "LabelConsultaAlumnos"
        Me.LabelConsultaAlumnos.Size = New System.Drawing.Size(211, 26)
        Me.LabelConsultaAlumnos.TabIndex = 122
        Me.LabelConsultaAlumnos.Text = "Estado de la Cursada"
        Me.LabelConsultaAlumnos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(51, 67)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 17)
        Me.Label7.TabIndex = 169
        Me.Label7.Text = "Clase de Teoría"
        '
        'TextBoxHsFaltasTeoria
        '
        Me.TextBoxHsFaltasTeoria.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxHsFaltasTeoria.Location = New System.Drawing.Point(164, 66)
        Me.TextBoxHsFaltasTeoria.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxHsFaltasTeoria.Name = "TextBoxHsFaltasTeoria"
        Me.TextBoxHsFaltasTeoria.ReadOnly = True
        Me.TextBoxHsFaltasTeoria.Size = New System.Drawing.Size(82, 20)
        Me.TextBoxHsFaltasTeoria.TabIndex = 168
        '
        'LabelHistorial
        '
        Me.LabelHistorial.AutoSize = True
        Me.LabelHistorial.BackColor = System.Drawing.Color.Moccasin
        Me.LabelHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelHistorial.Location = New System.Drawing.Point(324, 92)
        Me.LabelHistorial.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelHistorial.Name = "LabelHistorial"
        Me.LabelHistorial.Size = New System.Drawing.Size(440, 17)
        Me.LabelHistorial.TabIndex = 170
        Me.LabelHistorial.Text = "La materia no tiene historial de asistencias para el año seleccionado"
        Me.LabelHistorial.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 17)
        Me.Label1.TabIndex = 172
        Me.Label1.Text = "Clase de Práctica"
        '
        'TextBoxHsFaltasPractica
        '
        Me.TextBoxHsFaltasPractica.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxHsFaltasPractica.Location = New System.Drawing.Point(164, 42)
        Me.TextBoxHsFaltasPractica.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxHsFaltasPractica.Name = "TextBoxHsFaltasPractica"
        Me.TextBoxHsFaltasPractica.ReadOnly = True
        Me.TextBoxHsFaltasPractica.Size = New System.Drawing.Size(82, 20)
        Me.TextBoxHsFaltasPractica.TabIndex = 171
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBoxHsFaltasTeoria)
        Me.GroupBox1.Controls.Add(Me.TextBoxHsFaltasPractica)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxInasistenciasPermitidas)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 333)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 94)
        Me.GroupBox1.TabIndex = 177
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inasistencias permitidas (en horas)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBoxEstadoCursada)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBoxInasistenciasAlumno)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 239)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(259, 71)
        Me.GroupBox2.TabIndex = 178
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estado de la cursada"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 190)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 17)
        Me.Label8.TabIndex = 179
        Me.Label8.Text = "Año de Cursada"
        '
        'TextBoxAñoCursada
        '
        Me.TextBoxAñoCursada.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxAñoCursada.Location = New System.Drawing.Point(161, 189)
        Me.TextBoxAñoCursada.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxAñoCursada.Name = "TextBoxAñoCursada"
        Me.TextBoxAñoCursada.ReadOnly = True
        Me.TextBoxAñoCursada.Size = New System.Drawing.Size(109, 20)
        Me.TextBoxAñoCursada.TabIndex = 180
        '
        'AsistenciasAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 568)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBoxAñoCursada)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LabelHistorial)
        Me.Controls.Add(Me.DataGridAsistenciasAlumno)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBoxCarreraA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxComisionA)
        Me.Controls.Add(Me.TextBoxMateriaA)
        Me.Controls.Add(Me.LabelConsultaAlumnos)
        Me.Controls.Add(Me.LabelEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AsistenciasAlumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.DataGridAsistenciasAlumno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelEncabezado As Label
    Friend WithEvents DataGridAsistenciasAlumno As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxInasistenciasAlumno As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxInasistenciasPermitidas As TextBox
    Friend WithEvents TextBoxEstadoCursada As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxCarreraA As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxComisionA As TextBox
    Friend WithEvents TextBoxMateriaA As TextBox
    Friend WithEvents LabelConsultaAlumnos As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ButtonEditarAsistencias As DataGridViewButtonColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxHsFaltasTeoria As TextBox
    Friend WithEvents LabelHistorial As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxHsFaltasPractica As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxAñoCursada As TextBox
End Class
