<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Interfaz
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Interfaz))
        Me.BarradeMenuSuperior = New System.Windows.Forms.MenuStrip()
        Me.botonInicio = New System.Windows.Forms.ToolStripButton()
        Me.separador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.botonAltaUsuario = New System.Windows.Forms.ToolStripButton()
        Me.separador2 = New System.Windows.Forms.ToolStripSeparator()
        Me.botonUsuarios = New System.Windows.Forms.ToolStripButton()
        Me.botonProfesores = New System.Windows.Forms.ToolStripButton()
        Me.botonAlumnos = New System.Windows.Forms.ToolStripButton()
        Me.separador3 = New System.Windows.Forms.ToolStripSeparator()
        Me.botonAulas = New System.Windows.Forms.ToolStripButton()
        Me.separador4 = New System.Windows.Forms.ToolStripSeparator()
        Me.botonAsistencias = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.botonCerrarS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.LabelUsuarioActual = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LabelCatDpto = New System.Windows.Forms.ToolStripTextBox()
        Me.LabelTipoUsuarioActual = New System.Windows.Forms.ToolStripTextBox()
        Me.LabelCarreraDeCat = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OtrasAcciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarDePerfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StrCalendario = New System.Windows.Forms.ToolStripMenuItem()
        Me.StrSimular = New System.Windows.Forms.ToolStripMenuItem()
        Me.StrCambiarTolerancias = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarDB = New System.Windows.Forms.ToolStripMenuItem()
        Me.StrVerInformación = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarradeMenuInferior = New System.Windows.Forms.MenuStrip()
        Me.botonPDF = New System.Windows.Forms.ToolStripMenuItem()
        Me.botonImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.botonVolver = New System.Windows.Forms.ToolStripButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.BarradeMenuSuperior.SuspendLayout()
        Me.BarradeMenuInferior.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarradeMenuSuperior
        '
        Me.BarradeMenuSuperior.BackColor = System.Drawing.Color.AliceBlue
        Me.BarradeMenuSuperior.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.botonInicio, Me.separador1, Me.botonAltaUsuario, Me.separador2, Me.botonUsuarios, Me.botonProfesores, Me.botonAlumnos, Me.separador3, Me.botonAulas, Me.separador4, Me.botonAsistencias, Me.ToolStripButton1, Me.ToolStripSeparator4, Me.botonCerrarS, Me.ToolStripSeparator3, Me.LabelUsuarioActual, Me.ToolStripSeparator1, Me.LabelCatDpto, Me.LabelTipoUsuarioActual, Me.LabelCarreraDeCat, Me.ToolStripSeparator2, Me.OtrasAcciones})
        Me.BarradeMenuSuperior.Location = New System.Drawing.Point(0, 0)
        Me.BarradeMenuSuperior.Name = "BarradeMenuSuperior"
        Me.BarradeMenuSuperior.Size = New System.Drawing.Size(1198, 27)
        Me.BarradeMenuSuperior.TabIndex = 5
        Me.BarradeMenuSuperior.Text = "MenuStrip"
        '
        'botonInicio
        '
        Me.botonInicio.Image = CType(resources.GetObject("botonInicio.Image"), System.Drawing.Image)
        Me.botonInicio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.botonInicio.Name = "botonInicio"
        Me.botonInicio.Size = New System.Drawing.Size(40, 35)
        Me.botonInicio.Text = "Inicio"
        Me.botonInicio.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.botonInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.botonInicio.Visible = False
        '
        'separador1
        '
        Me.separador1.Name = "separador1"
        Me.separador1.Size = New System.Drawing.Size(6, 38)
        Me.separador1.Visible = False
        '
        'botonAltaUsuario
        '
        Me.botonAltaUsuario.Image = CType(resources.GetObject("botonAltaUsuario.Image"), System.Drawing.Image)
        Me.botonAltaUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.botonAltaUsuario.Name = "botonAltaUsuario"
        Me.botonAltaUsuario.Size = New System.Drawing.Size(75, 35)
        Me.botonAltaUsuario.Text = "Alta Usuario"
        Me.botonAltaUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.botonAltaUsuario.Visible = False
        '
        'separador2
        '
        Me.separador2.Name = "separador2"
        Me.separador2.Size = New System.Drawing.Size(6, 38)
        Me.separador2.Visible = False
        '
        'botonUsuarios
        '
        Me.botonUsuarios.Image = CType(resources.GetObject("botonUsuarios.Image"), System.Drawing.Image)
        Me.botonUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.botonUsuarios.Name = "botonUsuarios"
        Me.botonUsuarios.Size = New System.Drawing.Size(56, 35)
        Me.botonUsuarios.Text = "Usuarios"
        Me.botonUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.botonUsuarios.Visible = False
        '
        'botonProfesores
        '
        Me.botonProfesores.Image = CType(resources.GetObject("botonProfesores.Image"), System.Drawing.Image)
        Me.botonProfesores.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.botonProfesores.Name = "botonProfesores"
        Me.botonProfesores.Size = New System.Drawing.Size(66, 35)
        Me.botonProfesores.Text = "Profesores"
        Me.botonProfesores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.botonProfesores.Visible = False
        '
        'botonAlumnos
        '
        Me.botonAlumnos.Image = CType(resources.GetObject("botonAlumnos.Image"), System.Drawing.Image)
        Me.botonAlumnos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.botonAlumnos.Name = "botonAlumnos"
        Me.botonAlumnos.Size = New System.Drawing.Size(59, 35)
        Me.botonAlumnos.Text = "Alumnos"
        Me.botonAlumnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.botonAlumnos.Visible = False
        '
        'separador3
        '
        Me.separador3.Name = "separador3"
        Me.separador3.Size = New System.Drawing.Size(6, 38)
        Me.separador3.Visible = False
        '
        'botonAulas
        '
        Me.botonAulas.Image = CType(resources.GetObject("botonAulas.Image"), System.Drawing.Image)
        Me.botonAulas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.botonAulas.Name = "botonAulas"
        Me.botonAulas.Size = New System.Drawing.Size(40, 35)
        Me.botonAulas.Text = "Aulas"
        Me.botonAulas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.botonAulas.Visible = False
        '
        'separador4
        '
        Me.separador4.Name = "separador4"
        Me.separador4.Size = New System.Drawing.Size(6, 23)
        Me.separador4.Visible = False
        '
        'botonAsistencias
        '
        Me.botonAsistencias.Image = CType(resources.GetObject("botonAsistencias.Image"), System.Drawing.Image)
        Me.botonAsistencias.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.botonAsistencias.Name = "botonAsistencias"
        Me.botonAsistencias.Size = New System.Drawing.Size(85, 20)
        Me.botonAsistencias.Text = "Asistencias"
        Me.botonAsistencias.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.BackColor = System.Drawing.Color.Khaki
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(49, 20)
        Me.ToolStripButton1.Text = "Salir"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 23)
        Me.ToolStripSeparator4.Visible = False
        '
        'botonCerrarS
        '
        Me.botonCerrarS.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.botonCerrarS.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.botonCerrarS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.botonCerrarS.Name = "botonCerrarS"
        Me.botonCerrarS.Size = New System.Drawing.Size(80, 20)
        Me.botonCerrarS.Text = "Cerrar Sesión"
        Me.botonCerrarS.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 23)
        Me.ToolStripSeparator3.Visible = False
        '
        'LabelUsuarioActual
        '
        Me.LabelUsuarioActual.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LabelUsuarioActual.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabelUsuarioActual.Name = "LabelUsuarioActual"
        Me.LabelUsuarioActual.ReadOnly = True
        Me.LabelUsuarioActual.Size = New System.Drawing.Size(92, 23)
        Me.LabelUsuarioActual.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.LabelUsuarioActual.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        Me.ToolStripSeparator1.Visible = False
        '
        'LabelCatDpto
        '
        Me.LabelCatDpto.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LabelCatDpto.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabelCatDpto.Name = "LabelCatDpto"
        Me.LabelCatDpto.ReadOnly = True
        Me.LabelCatDpto.Size = New System.Drawing.Size(86, 23)
        Me.LabelCatDpto.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.LabelCatDpto.Visible = False
        '
        'LabelTipoUsuarioActual
        '
        Me.LabelTipoUsuarioActual.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LabelTipoUsuarioActual.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabelTipoUsuarioActual.Name = "LabelTipoUsuarioActual"
        Me.LabelTipoUsuarioActual.ReadOnly = True
        Me.LabelTipoUsuarioActual.Size = New System.Drawing.Size(90, 23)
        Me.LabelTipoUsuarioActual.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.LabelTipoUsuarioActual.Visible = False
        '
        'LabelCarreraDeCat
        '
        Me.LabelCarreraDeCat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LabelCarreraDeCat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabelCarreraDeCat.Name = "LabelCarreraDeCat"
        Me.LabelCarreraDeCat.ReadOnly = True
        Me.LabelCarreraDeCat.Size = New System.Drawing.Size(86, 23)
        Me.LabelCarreraDeCat.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.LabelCarreraDeCat.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 23)
        Me.ToolStripSeparator2.Visible = False
        '
        'OtrasAcciones
        '
        Me.OtrasAcciones.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.OtrasAcciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarDePerfilToolStripMenuItem, Me.StrCalendario, Me.StrSimular, Me.StrCambiarTolerancias, Me.CambiarDB, Me.StrVerInformación})
        Me.OtrasAcciones.Image = CType(resources.GetObject("OtrasAcciones.Image"), System.Drawing.Image)
        Me.OtrasAcciones.Name = "OtrasAcciones"
        Me.OtrasAcciones.Size = New System.Drawing.Size(112, 23)
        Me.OtrasAcciones.Text = "Otras acciones"
        Me.OtrasAcciones.Visible = False
        '
        'CambiarDePerfilToolStripMenuItem
        '
        Me.CambiarDePerfilToolStripMenuItem.Image = CType(resources.GetObject("CambiarDePerfilToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CambiarDePerfilToolStripMenuItem.Name = "CambiarDePerfilToolStripMenuItem"
        Me.CambiarDePerfilToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.CambiarDePerfilToolStripMenuItem.Text = "Cambiar de perfil"
        '
        'StrCalendario
        '
        Me.StrCalendario.Image = CType(resources.GetObject("StrCalendario.Image"), System.Drawing.Image)
        Me.StrCalendario.Name = "StrCalendario"
        Me.StrCalendario.Size = New System.Drawing.Size(204, 22)
        Me.StrCalendario.Text = "Calendario"
        '
        'StrSimular
        '
        Me.StrSimular.Image = CType(resources.GetObject("StrSimular.Image"), System.Drawing.Image)
        Me.StrSimular.Name = "StrSimular"
        Me.StrSimular.Size = New System.Drawing.Size(204, 22)
        Me.StrSimular.Text = "Simular"
        '
        'StrCambiarTolerancias
        '
        Me.StrCambiarTolerancias.Image = CType(resources.GetObject("StrCambiarTolerancias.Image"), System.Drawing.Image)
        Me.StrCambiarTolerancias.Name = "StrCambiarTolerancias"
        Me.StrCambiarTolerancias.Size = New System.Drawing.Size(204, 22)
        Me.StrCambiarTolerancias.Text = "Ajustar tolerancias"
        '
        'CambiarDB
        '
        Me.CambiarDB.Image = CType(resources.GetObject("CambiarDB.Image"), System.Drawing.Image)
        Me.CambiarDB.Name = "CambiarDB"
        Me.CambiarDB.Size = New System.Drawing.Size(204, 22)
        Me.CambiarDB.Text = "Cambiar conexión de BD"
        '
        'StrVerInformación
        '
        Me.StrVerInformación.Image = CType(resources.GetObject("StrVerInformación.Image"), System.Drawing.Image)
        Me.StrVerInformación.Name = "StrVerInformación"
        Me.StrVerInformación.Size = New System.Drawing.Size(204, 22)
        Me.StrVerInformación.Text = "Ver información"
        '
        'BarradeMenuInferior
        '
        Me.BarradeMenuInferior.BackColor = System.Drawing.Color.AliceBlue
        Me.BarradeMenuInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarradeMenuInferior.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.botonPDF, Me.botonImprimir, Me.botonVolver})
        Me.BarradeMenuInferior.Location = New System.Drawing.Point(0, 656)
        Me.BarradeMenuInferior.Name = "BarradeMenuInferior"
        Me.BarradeMenuInferior.Size = New System.Drawing.Size(1198, 42)
        Me.BarradeMenuInferior.TabIndex = 9
        Me.BarradeMenuInferior.Text = "MenuStrip1"
        '
        'botonPDF
        '
        Me.botonPDF.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.botonPDF.Image = CType(resources.GetObject("botonPDF.Image"), System.Drawing.Image)
        Me.botonPDF.Name = "botonPDF"
        Me.botonPDF.Size = New System.Drawing.Size(111, 38)
        Me.botonPDF.Text = "Descargar PDF"
        Me.botonPDF.Visible = False
        '
        'botonImprimir
        '
        Me.botonImprimir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.botonImprimir.Image = CType(resources.GetObject("botonImprimir.Image"), System.Drawing.Image)
        Me.botonImprimir.Name = "botonImprimir"
        Me.botonImprimir.Size = New System.Drawing.Size(81, 38)
        Me.botonImprimir.Text = "Imprimir"
        Me.botonImprimir.Visible = False
        '
        'botonVolver
        '
        Me.botonVolver.Enabled = False
        Me.botonVolver.Image = CType(resources.GetObject("botonVolver.Image"), System.Drawing.Image)
        Me.botonVolver.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.botonVolver.Name = "botonVolver"
        Me.botonVolver.Size = New System.Drawing.Size(43, 35)
        Me.botonVolver.Text = "Volver"
        Me.botonVolver.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.botonVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Interfaz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 698)
        Me.ControlBox = False
        Me.Controls.Add(Me.BarradeMenuInferior)
        Me.Controls.Add(Me.BarradeMenuSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.BarradeMenuSuperior
        Me.Name = "Interfaz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Asistencia Biométrico"
        Me.BarradeMenuSuperior.ResumeLayout(False)
        Me.BarradeMenuSuperior.PerformLayout()
        Me.BarradeMenuInferior.ResumeLayout(False)
        Me.BarradeMenuInferior.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarradeMenuSuperior As System.Windows.Forms.MenuStrip
    Friend WithEvents LabelUsuarioActual As ToolStripTextBox
    Friend WithEvents LabelTipoUsuarioActual As ToolStripTextBox
    Friend WithEvents separador1 As ToolStripSeparator
    Friend WithEvents botonProfesores As ToolStripButton
    Friend WithEvents botonAlumnos As ToolStripButton
    Friend WithEvents botonAsistencias As ToolStripButton
    Friend WithEvents BarradeMenuInferior As MenuStrip
    Friend WithEvents botonPDF As ToolStripMenuItem
    Friend WithEvents botonImprimir As ToolStripMenuItem
    Friend WithEvents botonVolver As ToolStripButton
    Friend WithEvents botonInicio As ToolStripButton
    Friend WithEvents separador2 As ToolStripSeparator
    Friend WithEvents botonUsuarios As ToolStripButton
    Friend WithEvents separador3 As ToolStripSeparator
    Friend WithEvents separador4 As ToolStripSeparator
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents botonCerrarS As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents botonAulas As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents LabelCatDpto As ToolStripTextBox
    Friend WithEvents OtrasAcciones As ToolStripMenuItem
    Friend WithEvents StrSimular As ToolStripMenuItem
    Friend WithEvents StrCambiarTolerancias As ToolStripMenuItem
    Friend WithEvents StrVerInformación As ToolStripMenuItem
    Friend WithEvents StrCalendario As ToolStripMenuItem
    Friend WithEvents CambiarDePerfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CambiarDB As ToolStripMenuItem
    Friend WithEvents LabelCarreraDeCat As ToolStripTextBox
    Friend WithEvents botonAltaUsuario As ToolStripButton
End Class
