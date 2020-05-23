Imports System.Data.SqlClient
Public Class AltaAula
    Private Sub AltaAula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxEdificio.SelectedIndex = 0
        ComboBoxEstadoLector.SelectedIndex = 0
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonDardeAlta.Click
        If TextBoxNumeroAula.Text <> "" Then
            If IsNumeric(TextBoxNumeroAula.Text) = False Then
                MsgBox("El valor del campo Número de Aula debe ser un número", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Else
            MsgBox("Debe completar el Número de Aula para darla de alta.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If ComboBoxEdificio.Text = "" Then
            MsgBox("Debe completar el Edificio para dar de alta el aula", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If TextBoxSerialLector.Text = "" Then
            MsgBox("Debe completar el Serial del Lector para dar de alta el aula", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)

        Dim existe As String = ""
        'ver si existe el usuario y devuelve el nombre real
        Dim buscarAula As New SqlCommand("ExisteAula", con)
        buscarAula.CommandType = CommandType.StoredProcedure
        buscarAula.Parameters.Add("@aula", SqlDbType.SmallInt).Value = TextBoxNumeroAula.Text
        Try
            con.Open()
            existe = buscarAula.ExecuteScalar()
            con.Close()

            '##### SI EL AULA NO EXISTE EN LA BD LO DA DE ALTA
            If existe = "" Then
                Dim cmd As New SqlCommand
                Try
                    Dim altaAula As New SqlCommand("AltaAula", con)
                    altaAula.CommandType = CommandType.StoredProcedure
                    altaAula.Parameters.Add("@aula", SqlDbType.SmallInt).Value = TextBoxNumeroAula.Text
                    altaAula.Parameters.Add("@edificio", SqlDbType.VarChar, 100).Value = ComboBoxEdificio.Text
                    altaAula.Parameters.Add("@estado", SqlDbType.VarChar, 10).Value = ComboBoxEstadoLector.Text
                    altaAula.Parameters.Add("@serial", SqlDbType.VarChar, 255).Value = TextBoxSerialLector.Text

                    con.Open()
                    altaAula.ExecuteNonQuery()
                    MsgBox("Alta de Aula generada correctamente", MsgBoxStyle.Information)
                    con.Close()

                    Me.Close()
                    Interfaz.RecargarDataGrid()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                End Try
            Else
                MsgBox("No se puede dar de alta. El aula ya existe en la base de datos.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub
End Class