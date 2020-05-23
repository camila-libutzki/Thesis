Imports System.Security.Cryptography
Imports System.Data.SqlClient
Imports System.Text
Public Class Login

    Dim nomUsuario As String
    Dim passUsuario As String
    Dim hashTraido As String
    'Dim tipoUsr As String
    Dim nuevoHash
    Dim primerinicio As String
    'Dim dptoUsuario As String
    'Dim catUsuario As String
    Dim usuarioActual As String = ""
    Dim outro As String

    Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        If TextBoxNombreUsuario.Text = "" Then
            MsgBox("Debe ingresar un nombre de usuario.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        'outro = ""
        nomUsuario = TextBoxNombreUsuario.Text
        passUsuario = TextBoxContraseña.Text
        'calcula la contraseña ingresada con el nombre del usuario y la contraseña
        nuevoHash = Interfaz.HashGen(nomUsuario, passUsuario)

        Dim obtenerLegajo As New SqlCommand("GetLegajoLogueado", con)
        obtenerLegajo.CommandType = CommandType.StoredProcedure
        obtenerLegajo.Parameters.Add("@nombreU", SqlDbType.VarChar, 100).Value = TextBoxNombreUsuario.Text

        Dim obtenerContraseña As New SqlCommand("GetContraseñaLogueado", con)
        obtenerContraseña.CommandType = CommandType.StoredProcedure
        obtenerContraseña.Parameters.Add("@nombreU", SqlDbType.VarChar, 100).Value = TextBoxNombreUsuario.Text

        Try
            con.Open()
            usuarioActual = obtenerLegajo.ExecuteScalar()
            'almacena lo que trae de la BD
            hashTraido = obtenerContraseña.ExecuteScalar()
            con.Close()

            If usuarioActual = "" Then
                MsgBox("La persona no tiene un usuario con los criterios seleccionados.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            'verifica si lo que escribieron en el textbox es igual a lo consultado en la DB
            If hashTraido = nuevoHash Then
                'guarda en interfaz el legajo del usuario logueado
                Interfaz.legajoLogueado = usuarioActual

                '#### ASIGNA TIPO Y NOMBRE DE USUARIO AL MDI PARENT: INTERFAZ
                '### label usuario
                Dim textoU As String = nomUsuario
                Dim fontU As New Font("Segoe UI", 9)
                Interfaz.LabelUsuarioActual.Text = nomUsuario
                Interfaz.LabelUsuarioActual.Size = TextRenderer.MeasureText(textoU, fontU)
                '### label tipo usuario
                Dim textoUA As String = ComboBoxTipoUsuario.Text
                Dim fontUA As New Font("Segoe UI", 9)
                Interfaz.LabelTipoUsuarioActual.Text = ComboBoxTipoUsuario.Text
                Interfaz.LabelTipoUsuarioActual.Size = TextRenderer.MeasureText(textoUA, fontUA)

                If ComboBoxTipoUsuario.Text = "Jefe de Departamento" Then
                    Interfaz.LabelCatDpto.Text = ComboBoxDpto.Text
                    Dim textoCD As String = Interfaz.LabelCatDpto.Text
                    Dim fontCD As New Font("Segoe UI", 9)
                    Interfaz.LabelCatDpto.Size = TextRenderer.MeasureText(textoCD, fontCD)
                    Interfaz.LabelCatDpto.Visible = True
                ElseIf ComboBoxTipoUsuario.Text = "Jefe de Cátedra" Then
                    Dim textoCD As String = ComboBoxCatedra.Text
                    Dim fontCD As New Font("Segoe UI", 9)
                    Interfaz.LabelCatDpto.Text = ComboBoxCatedra.Text
                    Interfaz.LabelCatDpto.Size = TextRenderer.MeasureText(textoCD, fontCD)
                    Interfaz.LabelCatDpto.Visible = True

                    Dim textoCC As String = ComboBoxDpto.Text
                    Dim fontCC As New Font("Segoe UI", 9)
                    Interfaz.LabelCarreraDeCat.Text = ComboBoxDpto.Text
                    Interfaz.LabelCarreraDeCat.Size = TextRenderer.MeasureText(textoCC, fontCC)
                    Interfaz.LabelCarreraDeCat.Visible = True
                End If

                'vuelve a esconder la leyenda de usuario y contraseña incorrectos, por si se quieren volver a loguear
                LabelUsrPassIncorrecto.Visible = False
                'pasamos a la ventana de incio borrando antes los textbox por si alguien quiere volver que no encuentre todo escrito'
                TextBoxNombreUsuario.Text = ""
                TextBoxContraseña.Text = ""

                'verificar a ver si este usuario tiene que cambiar la contraseña por primera vez
                Dim obtenerCambioPass As New SqlCommand("GetCambiarContraseñaLogueado", con)
                obtenerCambioPass.CommandType = CommandType.StoredProcedure
                obtenerCambioPass.Parameters.Add("@nombreU", SqlDbType.VarChar, 100).Value = TextBoxNombreUsuario.Text

                con.Open()
                primerinicio = obtenerCambioPass.ExecuteScalar()
                con.Close()

                If primerinicio = "si" Then
                    Dim frm As PrimerInicio = New PrimerInicio()
                    frm.MdiParent = Interfaz
                    frm.Show()
                Else
                    For Each f As Form In Me.MdiChildren
                        f.Close()
                    Next
                    'mostramos los botones
                    Interfaz.CargarBarraSuperior()

                    Dim frm As Inicio = New Inicio()
                    frm.MdiParent = Interfaz
                    frm.Show()
                End If
                Me.Close()
            Else
                LabelUsrPassIncorrecto.Visible = True
                TextBoxNombreUsuario.Text = ""
                TextBoxContraseña.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub TextBoxnombreusuario_TextClick(sender As Object, e As EventArgs) Handles TextBoxNombreUsuario.Click
        LabelUsrPassIncorrecto.Visible = False
    End Sub

    Private Sub ComboBoxTipoUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTipoUsuario.SelectedIndexChanged
        If ComboBoxTipoUsuario.Text = "Jefe de Cátedra" Then
            ComboBoxDpto.Enabled = True
            ComboBoxDpto.SelectedIndex() = 0
            ComboBoxCatedra.Enabled = True

            ComboBoxCatedra.Items.Clear()
            Dim cargarMaterias As New SqlCommand("GetMateriasPorCarrera", con)
            cargarMaterias.CommandType = CommandType.StoredProcedure
            cargarMaterias.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxDpto.Text

            Try
                con.Open()
                Dim dt As New DataTable
                dt.Load(cargarMaterias.ExecuteReader)
                For Each Fila As DataRow In dt.Rows
                    ComboBoxCatedra.Items.Add(Fila.Item(0))
                Next
                con.Close()
                If ComboBoxCatedra.Items.Count > 0 Then
                    ComboBoxCatedra.SelectedIndex() = 0
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
            Exit Sub
        End If

        If ComboBoxTipoUsuario.Text = "Jefe de Departamento" Then
            ComboBoxDpto.Enabled = True
            ComboBoxDpto.SelectedIndex() = 0
            ComboBoxCatedra.Enabled = False
            ComboBoxCatedra.Items.Clear()
            Exit Sub
        End If
        ComboBoxDpto.Enabled = False
        ComboBoxDpto.SelectedIndex = 0
        ComboBoxCatedra.Enabled = False
        ComboBoxCatedra.Items.Clear()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxTipoUsuario.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each f As Form In Interfaz.MdiChildren
            f.Close()
        Next
        Dim frm As CambiarBD = New CambiarBD()
        frm.MdiParent = Interfaz
        frm.Show()
    End Sub

    Private Sub ComboBoxDpto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDpto.SelectedIndexChanged
        If ComboBoxTipoUsuario.Text = "Jefe de Cátedra" Then
            ComboBoxCatedra.Items.Clear()
            Dim cargarMaterias As New SqlCommand("GetMateriasPorCarrera", con)
            cargarMaterias.CommandType = CommandType.StoredProcedure
            cargarMaterias.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxDpto.Text

            Try
                con.Open()
                Dim dt As New DataTable
                dt.Load(cargarMaterias.ExecuteReader)
                For Each Fila As DataRow In dt.Rows
                    ComboBoxCatedra.Items.Add(Fila.Item(0))
                Next
                con.Close()
                If ComboBoxCatedra.Items.Count > 0 Then
                    ComboBoxCatedra.SelectedIndex() = 0
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub
End Class