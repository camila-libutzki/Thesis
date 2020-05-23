Imports System.Data.SqlClient
Public Class PrimerInicio
    Private Sub PrimerInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxNombreUsuario.Text = Interfaz.LabelUsuarioActual.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonContinuar.Click

        If TextBoxnuevacontra.Text = TextBoxreingrese.Text Then
            'generamos el hash de esa contraseña... y guardamos en la variable nuevohash
            Dim nuevohash = Interfaz.HashGen(Interfaz.LabelUsuarioActual.Text, TextBoxnuevacontra.Text)
            Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)
            Try
                'construimos la query pasandole el nuevo hash... y poniendo la columna de cambiar contraseña en 'no'
                Dim actualizarContraseña As New SqlCommand("UpdateContraseñaUsuario", con)
                actualizarContraseña.CommandType = CommandType.StoredProcedure
                actualizarContraseña.Parameters.Add("@nombreU", SqlDbType.VarChar, 100).Value = TextBoxNombreUsuario.Text
                actualizarContraseña.Parameters.Add("@pass", SqlDbType.VarChar, 255).Value = nuevohash
                actualizarContraseña.Parameters.Add("@cambiarPass", SqlDbType.VarChar, 2).Value = "no"

                con.Open()
                actualizarContraseña.ExecuteNonQuery()
                con.Close()
                MsgBox("Contraseña actualizada exitosamente.", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try

            For Each f As Form In Me.MdiChildren
                f.Close()
            Next

            Interfaz.CargarBarraSuperior()

            Dim frm As Inicio = New Inicio()
            frm.MdiParent = Interfaz
            frm.Show()
        Else
            Labelcontraincorrecta.Visible = True
            TextBoxnuevacontra.Text = ""
            TextBoxreingrese.Text = ""
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonVolver.Click
        Dim frm As Login = New Login()
        frm.MdiParent = Interfaz
        frm.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub TextBoxnuevacontra_TextClick(sender As Object, e As EventArgs) Handles TextBoxnuevacontra.Click
        Labelcontraincorrecta.Visible = False
    End Sub
End Class