Imports System.Data.SqlClient
Imports System.IO
Public Class AltaUsuario

    Dim direccionFoto As String
    Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)
    Dim testVar As Object
    Dim numericCheck As Boolean

    Private Sub AltaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BOTONES DEL PARENT
        Interfaz.botonVolver.Enabled = False
        Interfaz.botonImprimir.Visible = False
        Interfaz.botonPDF.Visible = False

        ComboBoxTipo.SelectedIndex = 0
        PictureBox.ImageLocation = ""

        'para que al presionar tab se mueva en los textbox en este orden
        TextBoxNombreUsuario.TabIndex = 0
        TextBoxNombreApellido.TabIndex = 1
        TextBoxDNI.TabIndex = 2
        TextBoxLegajo.TabIndex = 3
    End Sub

    'desabilitar todos los botones y textBox
    Public Sub DesabilitarCampos()
        Button1.Enabled = False
        Button5.Enabled = False
        TextBoxNombreUsuario.ReadOnly = True
        ComboBoxTipo.Enabled = False
        TextBoxNombreApellido.ReadOnly = True
        TextBoxDNI.ReadOnly = True
        TextBoxLegajo.ReadOnly = True
        ComboBoxCatedra.Enabled = False
        ComboBoxDpto.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '##### PRIMERO VERIFICA QUE ESTEN BIEN TODOS LOS CAMPOS. SI HAY ALGO MAS SALE DE LA RUTINA
        If TextBoxNombreUsuario.Text = "" Then
            MsgBox("Debe completar el Nombre de Usuario para dar de alta al usuario", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If TextBoxNombreApellido.Text = "" Then
            MsgBox("Debe completar el Nombre y Apellido para dar de alta al usuario", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If TextBoxDNI.Text <> "" Then
            If IsNumeric(TextBoxDNI.Text) = False Then
                MsgBox("El valor del campo DNI debe ser un número", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Else
            MsgBox("Debe completar el DNI para dar de alta al usuario", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If TextBoxLegajo.Text <> "" Then
            If IsNumeric(TextBoxLegajo.Text) = False Then
                MsgBox("El valor del campo Legajo debe ser un número", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Else
            MsgBox("Debe completar el Legajo para dar de alta al usuario", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        '##### si es todo valido procede a intentar dar el alta con los valores ingresados
        Dim usuarioExiste As String = ""
        'ver si existe el usuario y devuelve el nombre real
        Dim buscarUsuario As New SqlCommand("ExisteUsuario", con)
        buscarUsuario.CommandType = CommandType.StoredProcedure
        buscarUsuario.Parameters.Add("@legajo", SqlDbType.Int).Value = TextBoxLegajo.Text

        Try
            con.Open()
            usuarioExiste = buscarUsuario.ExecuteScalar()
            con.Close()

            '##### SI EL USUARIO NO EXISTE EN LA BD LO DA DE ALTA
            If usuarioExiste = "" Then
                'ver si existe el usuario y devuelve el nombre real
                Dim buscarNombreU As New SqlCommand("ExisteNombreUsuario", con)
                buscarNombreU.CommandType = CommandType.StoredProcedure
                buscarNombreU.Parameters.Add("@nombreU", SqlDbType.VarChar, 100).Value = TextBoxNombreUsuario.Text
                con.Open()
                usuarioExiste = buscarNombreU.ExecuteScalar()
                con.Close()

                If usuarioExiste = "" Then
                    Dim nuevohash
                    nuevohash = Interfaz.HashGen(TextBoxNombreUsuario.Text, TextBoxDNI.Text)

                    Dim altaUsuario As New SqlCommand("AltaUsuario", con)
                    altaUsuario.CommandType = CommandType.StoredProcedure
                    altaUsuario.Parameters.Add("@nombreU", SqlDbType.VarChar, 100).Value = TextBoxNombreUsuario.Text
                    altaUsuario.Parameters.Add("@nomyap", SqlDbType.VarChar, 255).Value = TextBoxNombreApellido.Text
                    altaUsuario.Parameters.Add("@dni", SqlDbType.Int).Value = TextBoxDNI.Text
                    altaUsuario.Parameters.Add("@legajo", SqlDbType.Int).Value = TextBoxLegajo.Text
                    altaUsuario.Parameters.Add("@tipo", SqlDbType.VarChar, 100).Value = ComboBoxTipo.Text
                    altaUsuario.Parameters.Add("@pass", SqlDbType.VarChar, 255).Value = nuevohash

                    If ComboBoxTipo.Text = "Administrador" Or ComboBoxTipo.Text = "Bedel" Then
                        altaUsuario.Parameters.Add("@carrera", SqlDbType.VarChar, 20).Value = "N/A"
                        altaUsuario.Parameters.Add("@materia", SqlDbType.VarChar, 255).Value = "N/A"
                    ElseIf ComboBoxTipo.Text = "Jefe de Departamento" Then
                        altaUsuario.Parameters.Add("@carrera", SqlDbType.VarChar, 20).Value = ComboBoxDpto.Text
                        altaUsuario.Parameters.Add("@materia", SqlDbType.VarChar, 255).Value = "N/A"
                    Else
                        altaUsuario.Parameters.Add("@carrera", SqlDbType.VarChar, 20).Value = ComboBoxDpto.Text
                        altaUsuario.Parameters.Add("@materia", SqlDbType.VarChar, 255).Value = ComboBoxCatedra.Text
                    End If

                    If PictureBox.ImageLocation = "" Then
                        'paso null al parámetro de la foto si no se agregó una foto
                        altaUsuario.Parameters.Add("@foto", SqlDbType.Image).Value = DBNull.Value
                    Else
                        Dim fs As FileStream = New FileStream(direccionFoto, FileMode.Open, FileAccess.Read)
                        Dim br As BinaryReader = New BinaryReader(fs)
                        Dim asInt As Integer = fs.Length
                        Dim imagenU(asInt) As Byte
                        imagenU = br.ReadBytes(asInt)
                        altaUsuario.Parameters.Add("@foto", SqlDbType.Image).Value = imagenU
                    End If

                    Try
                        con.Open()
                        altaUsuario.ExecuteNonQuery()
                        con.Close()
                        MsgBox("El usuario se dió de alta exitosamente.", MsgBoxStyle.Information)
                        DesabilitarCampos()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                    End Try
                Else
                    MsgBox("Ya existe un usuario con el nombre de usuario ingresado. Seleccione otro nombre para seguir con el alta.", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("La persona ya tiene un usuario creado en el sistema con el legajo ingresado." & vbCrLf & "Si desea agregar un perfil nuevo al usuario debe ingresar a 'Usuarios' y buscar el usuario al que desea agregar el perfil.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ComboBoxtipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTipo.SelectedIndexChanged
        If ComboBoxTipo.Text = "Jefe de Cátedra" Then
            ComboBoxDpto.SelectedIndex() = 0
            ComboBoxDpto.Enabled = True
            ComboBoxCatedra.Enabled = True

            ComboBoxCatedra.Items.Clear()
            Dim cargarMaterias As New SqlCommand("GetMateriasPorCarrera", con)
            cargarMaterias.CommandType = CommandType.StoredProcedure
            cargarMaterias.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxDpto.Text

            Try
                Dim dt As New DataTable
                con.Open()
                dt.Load(cargarMaterias.ExecuteReader)
                con.Close()

                For Each Fila As DataRow In dt.Rows
                    ComboBoxCatedra.Items.Add(Fila.Item(0))
                Next
                If ComboBoxCatedra.Items.Count > 0 Then
                    ComboBoxCatedra.SelectedIndex() = 0
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
            Exit Sub
        End If

        If ComboBoxTipo.Text = "Jefe de Departamento" Then
            ComboBoxDpto.Enabled = True
            ComboBoxDpto.SelectedIndex() = 0
            ComboBoxCatedra.Enabled = False
            ComboBoxCatedra.Items.Clear()
            Exit Sub
        End If

        'si es admin o bedel oculta los campos
        ComboBoxDpto.Enabled = False
        ComboBoxDpto.SelectedIndex = 0
        ComboBoxCatedra.Enabled = False
        ComboBoxCatedra.Items.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.Title = "Eliga la imagen del usuario"
            OpenFileDialog1.Filter = "PNG Files (*.png) | *.png|JPG (*.jpg) | *.jpg"
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                direccionFoto = OpenFileDialog1.FileName.ToString()
                PictureBox.ImageLocation = direccionFoto
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ComboBoxDpto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDpto.SelectedIndexChanged
        ComboBoxCatedra.Items.Clear()
        Dim cargarMaterias As New SqlCommand("GetMateriasPorCarrera", con)
        cargarMaterias.CommandType = CommandType.StoredProcedure
        cargarMaterias.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxDpto.Text

        Try
            Dim dt As New DataTable
            con.Open()
            dt.Load(cargarMaterias.ExecuteReader)
            con.Close()

            For Each Fila As DataRow In dt.Rows
                ComboBoxCatedra.Items.Add(Fila.Item(0))
            Next
            If ComboBoxCatedra.Items.Count > 0 Then
                ComboBoxCatedra.SelectedIndex() = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class