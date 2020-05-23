Imports System.Data.SqlClient
Imports System.IO
Public Class ModificarPersona
    Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)

    Private Sub ModificarPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BOTONES DEL PARENT
        Interfaz.botonVolver.Enabled = True
        Interfaz.botonImprimir.Visible = False
        Interfaz.botonPDF.Visible = False

        ComboBoxDedoMano1.SelectedIndex = 0
        ComboBoxDedoMano2.SelectedIndex = 0

        Dim dt As New DataTable
        If Interfaz.tipoPersona = "Alumno" Then
            Dim obtenerDatosA As New SqlCommand("GetDatosAlumno", con)
            obtenerDatosA.CommandType = CommandType.StoredProcedure
            obtenerDatosA.Parameters.Add("@legajo", SqlDbType.Int).Value = Alumnos.idASeleccionado
            Try
                Dim adapter As SqlDataAdapter = New SqlDataAdapter(obtenerDatosA)
                adapter.Fill(dt)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        Else
            Dim obtenerDatosP As New SqlCommand("GetDatosProfesor", con)
            obtenerDatosP.CommandType = CommandType.StoredProcedure
            obtenerDatosP.Parameters.Add("@legajo", SqlDbType.Int).Value = Profesores.idPSeleccionado
            Try
                Dim adapter As SqlDataAdapter = New SqlDataAdapter(obtenerDatosP)
                adapter.Fill(dt)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If

        For Each Fila As DataRow In dt.Rows
            TextBoxNombre.Text = Fila.Item(0).ToString()
            TextBoxApellido.Text = Fila.Item(1).ToString()
            TextBoxDNI.Text = Fila.Item(2).ToString()

            If Not IsDBNull(Fila.Item(6)) Then
                Dim imagen() As Byte = Fila.Item(6)
                If imagen IsNot Nothing Then
                    Dim ms As MemoryStream = New MemoryStream(imagen)
                    PictureAltaPersona.Image = Image.FromStream(ms)
                End If
            End If
        Next
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        Dim mano1selected As String = ""
        Dim mano2selected As String = ""
        Dim dedo1selected As String = ComboBoxDedoMano1.Text
        Dim dedo2selected As String = ComboBoxDedoMano2.Text

        If RadioButtonMano1D.Checked = True Then
            mano1selected = "Derecha"
        Else
            mano1selected = "Izquierda"
        End If

        If RadioButtonMano2D.Checked = True Then
            mano2selected = "Derecha"
        Else
            mano2selected = "Izquierda"
        End If

        Dim updateHuellas As New SqlCommand("UpdateHuellas", con)
        updateHuellas.CommandType = CommandType.StoredProcedure
        If Interfaz.tipoPersona = "Profesor" Then
            updateHuellas.Parameters.Add("@tipoPersona", SqlDbType.VarChar, 8).Value = "Profesor"
        Else
            updateHuellas.Parameters.Add("@tipoPersona", SqlDbType.VarChar, 8).Value = "Alumno"
        End If
        updateHuellas.Parameters.Add("@legajo", SqlDbType.Int).Value = TextBoxLegajo.Text
        updateHuellas.Parameters.Add("@mano1", SqlDbType.VarChar, 10).Value = mano1selected
        updateHuellas.Parameters.Add("@dedo1", SqlDbType.VarChar, 10).Value = ComboBoxDedoMano1.Text
        updateHuellas.Parameters.Add("@mano2", SqlDbType.VarChar, 10).Value = mano2selected
        updateHuellas.Parameters.Add("@dedo2", SqlDbType.VarChar, 10).Value = ComboBoxDedoMano2.Text
        Try
            con.Open()
            updateHuellas.ExecuteNonQuery()
            MsgBox("Huellas actualizadas correctamente en SiABi.", MsgBoxStyle.Information)
            con.Close()

            'CERRAR EL CHILD ACTIVO (VISIBLE)
            Interfaz.ActiveMdiChild.Close()
            'EJECUTAR LA FUNCION DEL CHILD PARA SETEAR LOS BOTONES INFERIORES QUE USA DEL PARENT
            Dim FrmChild As Object
            FrmChild = Interfaz.ActiveMdiChild
            FrmChild.BotonesDelParent()
            FrmChild.CargarHuellasPersona()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ButtonTomarHuella1_Click(sender As Object, e As EventArgs)
        MsgBox("Huella 1 tomada correctamente.", MsgBoxStyle.Information)
    End Sub

    Private Sub ButtonTomarHuella2_Click(sender As Object, e As EventArgs)
        MsgBox("Huella 2 tomada correctamente.", MsgBoxStyle.Information)
    End Sub
End Class