Public Class ModificarAsistencia
    Public asistenciaModif As String

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub

    Private Sub ButtonGuardarCambios_Click(sender As Object, e As EventArgs) Handles ButtonGuardarCambios.Click
        Interfaz.asistencia = asistenciaModif
        Interfaz.comentarios = TextBoxComentarios.Text
        Me.Close()
        Interfaz.GuardarCambiosYRecargar()
    End Sub

    Private Sub ComboBoxAsistencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAsistencia.SelectedIndexChanged
        If ComboBoxAsistencia.Text = "Presente" Then
            asistenciaModif = "P"
        Else
            asistenciaModif = "A"
        End If
    End Sub

    Private Sub ModificarAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class