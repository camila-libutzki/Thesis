Imports System.Data.SqlClient
Imports System.Text
Imports System.IO
Public Class AgregarFotoPersona

    Dim tipoPersona As String

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
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim direccionFoto As String
    Private Sub AgregarFotoPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox.ImageLocation = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If PictureBox.ImageLocation = "" Then
            MsgBox("Debe agregar una foto para poder agregarla a la persona")
            Exit Sub
        End If

        If TextBoxLegajo.Text <> "" Then
            If IsNumeric(TextBoxLegajo.Text) = False Then
                MsgBox("El valor del campo Legajo debe ser un número")
                Exit Sub
            End If
        Else
            MsgBox("Debe completar el Legajo para dar de alta la foto de la persona")
            Exit Sub
        End If

        Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)

        Dim usuarioExiste As String = ""
        Dim sqlselectnomyap As String = ""
        sqlselectnomyap = "SELECT dni FROM " + tipoPersona + " WHERE legajo = '" + TextBoxLegajo.Text + "'"

        Dim cmdSelectexiste As New SqlCommand(sqlselectnomyap, con)
        Try
            con.Open()
            usuarioExiste = cmdSelectexiste.ExecuteScalar()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If usuarioExiste = "" Then
            MsgBox("La persona con el legajo seleccionado no existe en la BD")
        Else
            Try
                Dim fs As FileStream = New FileStream(direccionFoto, FileMode.Open, FileAccess.Read)
                Dim br As BinaryReader = New BinaryReader(fs)
                Dim asInt As Integer = fs.Length
                Dim image(asInt) As Byte
                image = br.ReadBytes(asInt)
                Try
                    Dim sqlaltausuario As String = "UPDATE " + tipoPersona + " SET foto = @img WHERE legajo = '" + TextBoxLegajo.Text + "'"
                    Dim cmdalta As New SqlCommand(sqlaltausuario, con)
                    cmdalta.Parameters.Add("@img", SqlDbType.Image).Value = image
                    con.Open()
                    cmdalta.ExecuteNonQuery()
                    con.Close()

                    MsgBox("Foto agregada existosamente")

                    Dim resultDlg As Integer
                    resultDlg = MsgBox("¿Desea agregar otra foto?", MsgBoxStyle.OkCancel)
                    If resultDlg = 1 Then
                        RadioButtonAlumno.Checked = True
                        PictureBox.ImageLocation = ""
                        PictureBox.Image = Nothing
                        TextBoxLegajo.Text = ""
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub RadioButtonAlumno_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonAlumno.CheckedChanged
        tipoPersona = "Alumnos"
    End Sub

    Private Sub RadioButtonProfesor_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonProfesor.CheckedChanged
        tipoPersona = "Profesores"
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonUsuario.CheckedChanged
        tipoPersona = "Usuarios"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class