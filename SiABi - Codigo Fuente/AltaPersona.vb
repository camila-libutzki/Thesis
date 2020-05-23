Imports System.Data.SqlClient
Imports System.IO

Public Class AltaPersona
    Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)

    Private Sub AltaPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BOTONES DEL PARENT
        Interfaz.botonVolver.Enabled = True
        Interfaz.botonImprimir.Visible = False
        Interfaz.botonPDF.Visible = False

        ComboBoxDedoMano1.SelectedIndex = 0
        ComboBoxDedoMano2.SelectedIndex = 0

        Dim dt As New DataTable
        If Interfaz.tipoPersona = "Alumno" Then
            TextBoxLegajo.Text = Alumnos.idASeleccionado
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
            TextBoxLegajo.Text = Profesores.idPSeleccionado
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

    Private Sub ButtonAltaHuellas_Click(sender As Object, e As EventArgs) Handles ButtonAltaHuellas.Click
        If FotoHuella1.Visible = False Or FotoHuella2.Visible = False Then
            MsgBox("Debe tomar ambas huellas para poder dar el alta.", MsgBoxStyle.Exclamation)
        Else
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

            Dim altaHuellas As New SqlCommand("AltaHuellas", con)
            altaHuellas.CommandType = CommandType.StoredProcedure
            If Interfaz.tipoPersona = "Profesor" Then
                altaHuellas.Parameters.Add("@tipoPersona", SqlDbType.VarChar, 8).Value = "Profesor"
            Else
                altaHuellas.Parameters.Add("@tipoPersona", SqlDbType.VarChar, 8).Value = "Alumno"
            End If
            altaHuellas.Parameters.Add("@legajo", SqlDbType.Int).Value = TextBoxLegajo.Text
            altaHuellas.Parameters.Add("@mano1", SqlDbType.VarChar, 10).Value = mano1selected
            altaHuellas.Parameters.Add("@dedo1", SqlDbType.VarChar, 10).Value = ComboBoxDedoMano1.Text
            altaHuellas.Parameters.Add("@mano2", SqlDbType.VarChar, 10).Value = mano2selected
            altaHuellas.Parameters.Add("@dedo2", SqlDbType.VarChar, 10).Value = ComboBoxDedoMano2.Text
            Try
                con.Open()
                altaHuellas.ExecuteNonQuery()
                MsgBox("Alta de huellas generada correctamente en SiABi.", MsgBoxStyle.Information)
                con.Close()
                Interfaz.ActiveMdiChild.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub ButtonTomarHuella1_Click(sender As Object, e As EventArgs) Handles ButtonTomarHuella1.Click
        FotoHuella1.Visible = True
        MsgBox("Huella 1 registrada correctamente.", MsgBoxStyle.Information)
    End Sub

    Private Sub ButtonTomarHuella2_Click(sender As Object, e As EventArgs) Handles ButtonTomarHuella2.Click
        FotoHuella2.Visible = True
        MsgBox("Huella 2 registrada correctamente.", MsgBoxStyle.Information)
    End Sub
End Class