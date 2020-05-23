Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Interfaz
    Public nombreCatDpto As String
    Public direccionPDF As String
    Public Shared tipoPersona As String = ""
    Public Shared legajoLogueado As String
    Public Shared legajoParaModificar As String = ""
    Public Shared idListadoAlumnoBD As String
    Public Shared idPlanillaBD As String
    Public Shared asistencia As String
    Public Shared comentarios As String
    Public Shared carrera As String
    Public Shared comision As String
    Public Shared catedra As String

    'Conexiones a la Base de datos 15-12-2017
    Public Shared conexionDBactual As New SqlConnection("Data Source = " + My.Settings.ServerDB + ";Initial Catalog=" + My.Settings.DatabaseDB + ";User ID=" + My.Settings.UserDB + ";Password=" + My.Settings.PassDB + ";ConnectRetryCount=3;ConnectRetryInterval=3")
    Public Shared conexionParaAulas As New SqlConnection("Data Source = " + My.Settings.ServerDB + ";Initial Catalog=" + My.Settings.DatabaseDB + ";User ID=" + My.Settings.UserDB + ";Password=" + My.Settings.PassDB + ";ConnectRetryCount=3;ConnectRetryInterval=3")
    Public Shared siabiDBConnectionAsistencias As New SqlConnection("Data Source = " + My.Settings.ServerDB + ";Initial Catalog=" + My.Settings.DatabaseDB + ";User ID=" + My.Settings.UserDB + ";Password=" + My.Settings.PassDB + ";ConnectRetryCount=3;ConnectRetryInterval=3")
    Public Shared siabiDBconectionAsistencias As New SqlConnection("Data Source = " + My.Settings.ServerDB + ";Initial Catalog=" + My.Settings.DatabaseDB + ";User ID=" + My.Settings.UserDB + ";Password=" + My.Settings.PassDB + ";ConnectRetryCount=3;ConnectRetryInterval=3")
    '######################################################################################

    Public Shared Function HashGen(nombre As String, contra As String) As String
        Dim sum As String = nombre + contra
        'create hash object
        Using hasher As SHA512 = SHA512.Create()
            'convert to byte array and get hash
            Dim dbytes As Byte() = hasher.ComputeHash(Encoding.UTF8.GetBytes(sum))
            'sb to create string from bytes
            Dim sBuilder As New StringBuilder()
            'convert byte data to hex string y le agrega siabi
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("siabi"))
            Next n
            Return Convert.ToBase64String(dbytes)
        End Using
    End Function

    'devuelve el nombre del dia del numero del dia seleccionado
    Public Function GetDiaSemana(ByVal nroDia As Integer) As String
        Dim nombreDia As String = ""
        Select Case nroDia
            Case "1"
                nombreDia = "Lunes"
            Case "2"
                nombreDia = "Martes"
            Case "3"
                nombreDia = "Miércoles"
            Case "4"
                nombreDia = "Jueves"
            Case "5"
                nombreDia = "Viernes"
        End Select
        GetDiaSemana = nombreDia
    End Function

    Public Sub CargarPrestada()
        'CERRAR EL CHILD ACTIVO (VISIBLE)
        'Me.ActiveMdiChild.Close()
        'EJECUTAR LA FUNCION DEL CHILD PARA SETEAR LOS BOTONES INFERIORES QUE USA DEL PARENT
        Dim FrmChild As Object
        FrmChild = Me.ActiveMdiChild
        FrmChild.CargarDatosPrestada()
    End Sub

    Public Sub CargarBarraSuperior()
        botonInicio.Visible = True
        separador1.Visible = True

        If LabelTipoUsuarioActual.Text = "Administrador" Then
            botonAltaUsuario.Visible = True
            separador2.Visible = True
        End If

        OtrasAcciones.Visible = True
        If LabelTipoUsuarioActual.Text = "Jefe de Cátedra" Or LabelTipoUsuarioActual.Text = "Jefe de Departamento" Then
            StrCambiarTolerancias.Visible = False
            StrSimular.Visible = False
            CambiarDB.Visible = False
        ElseIf LabelTipoUsuarioActual.Text = "Bedel" Then
            StrCambiarTolerancias.Visible = True
            StrSimular.Visible = False
            CambiarDB.Visible = False
        Else
            StrCambiarTolerancias.Visible = True
            StrSimular.Visible = True
            CambiarDB.Visible = True
        End If

        botonUsuarios.Visible = True
        botonProfesores.Visible = True
        botonAlumnos.Visible = True
        separador3.Visible = True
        botonAulas.Visible = True
        separador4.Visible = True
        botonAsistencias.Visible = True

        ToolStripSeparator2.Visible = True
        LabelTipoUsuarioActual.Visible = True
        ToolStripSeparator1.Visible = True
        LabelUsuarioActual.Visible = True
        ToolStripSeparator3.Visible = True
        botonCerrarS.Visible = True
        ToolStripSeparator4.Visible = True

        botonVolver.Visible = True
    End Sub

    Private Sub Interfaz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '##### solo se declara la variable de guardado de archivo, se ve en la funcion despues
        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Filter = "PDF (*.pdf) | *.pdf"

        Dim frm As Login = New Login()
        frm.MdiParent = Me
        frm.Show()
        frm.Visible = False

        Dim frmsplash As Splashscreen = New Splashscreen()
        frmsplash.MdiParent = Me
        frmsplash.Show()


    End Sub

    Public Sub VolverAInicio()
        botonVolver.Enabled = False
        botonImprimir.Visible = False
        botonPDF.Visible = False

        Dim frm As Inicio = New Inicio()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ToolStripButton18_Click(sender As Object, e As EventArgs) Handles botonInicio.Click
        'CERRAR TODOS LOS CHILDS ACTIVOS
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        botonVolver.Enabled = False
        botonImprimir.Visible = False
        botonPDF.Visible = False

        Dim frm As Inicio = New Inicio()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ToolStripButton14_Click(sender As Object, e As EventArgs) Handles botonAlumnos.Click
        'CERRAR TODOS LOS CHILDS ACTIVOS
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next

        Dim frm As Alumnos = New Alumnos()
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub ToolStripButton15_Click(sender As Object, e As EventArgs) Handles botonProfesores.Click
        'CERRAR TODOS LOS CHILDS ACTIVOS
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next

        Dim frm As Profesores = New Profesores()
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub ToolStripButton13_Click(sender As Object, e As EventArgs) Handles botonUsuarios.Click
        'CERRAR TODOS LOS CHILDS ACTIVOS
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next

        Dim frm As Usuarios = New Usuarios()
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub


    Private Sub ToolStripButton17_Click(sender As Object, e As EventArgs) Handles botonAsistencias.Click
        'CERRAR TODOS LOS CHILDS ACTIVOS
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next

        Dim frm As Asistencias = New Asistencias()
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub
    Public Sub botonVolver_Click(sender As Object, e As EventArgs) Handles botonVolver.Click
        'CERRAR EL CHILD ACTIVO (VISIBLE)
        Me.ActiveMdiChild.Close()
        'EJECUTAR LA FUNCION DEL CHILD PARA SETEAR LOS BOTONES INFERIORES QUE USA DEL PARENT
        Dim FrmChild As Object
        FrmChild = Me.ActiveMdiChild
        FrmChild.BotonesDelParent()
        FrmChild.LoadDataGrid()
    End Sub

    Private Sub BotonPDF_Click(sender As Object, e As EventArgs) Handles botonPDF.Click
        '##### EJECUTAR EL GENERAR_PDF DEL CHILD ACTIVO
        SaveFileDialog1.FileName = ""
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            direccionPDF = SaveFileDialog1.FileName
            Dim FrmChild As Object
            FrmChild = Me.ActiveMdiChild
            FrmChild.GenerarPDF()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Public Sub GuardarCambiosYRecargar()
        Dim FrmChild As Object
        FrmChild = Me.ActiveMdiChild
        FrmChild.GuardarCambiosAsistencia()
    End Sub

    Public Sub RecargarDataGrid()
        Dim FrmChild As Object
        FrmChild = Me.ActiveMdiChild
        FrmChild.LoadDataGrid()
    End Sub

    Private Sub botonSalir_Click(sender As Object, e As EventArgs) Handles botonCerrarS.Click
        If MsgBox("¿Está seguro que desea cerrar sesión?", MessageBoxButtons.OKCancel) = MsgBoxResult.Ok Then
            LabelTipoUsuarioActual.Text = ""
            LabelUsuarioActual.Text = ""

            'CERRAR TODOS LOS CHILDS ACTIVOS
            For Each f As Form In Me.MdiChildren
                f.Close()
            Next

            '##### ocultamos la barra de menus y botones
            botonInicio.Visible = False
            separador1.Visible = False
            botonAltaUsuario.Visible = False
            separador2.Visible = False

            botonUsuarios.Visible = False
            botonProfesores.Visible = False
            botonAlumnos.Visible = False
            separador3.Visible = False
            botonAulas.Visible = False
            separador4.Visible = False
            botonAsistencias.Visible = False

            LabelCarreraDeCat.Visible = False
            ToolStripSeparator2.Visible = False
            LabelTipoUsuarioActual.Visible = False
            ToolStripSeparator1.Visible = False
            LabelUsuarioActual.Visible = False
            ToolStripSeparator3.Visible = False
            botonCerrarS.Visible = False
            ToolStripSeparator4.Visible = False
            LabelCatDpto.Visible = False

            'volvemos al login
            Dim frm As Login = New Login()
            frm.MdiParent = Me
            frm.Show()
        End If
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If MsgBox("¿Está seguro que desea salir del programa?", MessageBoxButtons.OKCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Private Sub botonAulas_Click(sender As Object, e As EventArgs) Handles botonAulas.Click
        'CERRAR TODOS LOS CHILDS ACTIVOS
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next

        Dim frm As Aulas = New Aulas()
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub StrSimular_Click(sender As Object, e As EventArgs) Handles StrSimular.Click
        'CERRAR TODOS LOS CHILDS ACTIVOS
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next

        Dim frm As Simular = New Simular()
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub StrCambiarTolerancias_Click(sender As Object, e As EventArgs) Handles StrCambiarTolerancias.Click
        Dim frm As Tolerancia = New Tolerancia()
        frm.ShowDialog()
    End Sub

    Private Sub StrCalendario_Click(sender As Object, e As EventArgs) Handles StrCalendario.Click
        'CERRAR TODOS LOS CHILDS ACTIVOS
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next

        Dim frm As Feriados = New Feriados()
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub StrVerInformación_Click(sender As Object, e As EventArgs) Handles StrVerInformación.Click
        Dim frm As Informacion = New Informacion()
        frm.ShowDialog()
    End Sub

    Private Sub CambiarDBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarDB.Click
        Dim frm As CambiarBD = New CambiarBD()
        frm.MdiParent = Me
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub botonAltaUsuario_Click(sender As Object, e As EventArgs) Handles botonAltaUsuario.Click
        'CERRAR TODOS LOS CHILDS ACTIVOS
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next

        Dim frm As AltaUsuario = New AltaUsuario()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CambiarDePerfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarDePerfilToolStripMenuItem.Click
        'CERRAR TODOS LOS CHILDS ACTIVOS
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next

        Dim frm As CambiarPerfil = New CambiarPerfil()
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
