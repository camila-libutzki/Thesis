Imports System.Data.SqlClient
Public Class AgregarPerfilUsuario
    Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)
    Dim legajoUsuario As String = Usuarios.legajoSeleccionado

    Private Sub AgregarPerfilUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxTipo.SelectedIndex = 0
        ComboBoxDpto.SelectedIndex = 0
    End Sub

    Private Sub ComboBoxDpto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDpto.SelectedIndexChanged
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
    End Sub
    Private Sub ComboBoxTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTipo.SelectedIndexChanged
        If ComboBoxTipo.Text = "Jefe de Cátedra" Then
            'seccion Departamento
            ComboBoxDpto.SelectedIndex() = 0
            ComboBoxDpto.Enabled = True
            'seccion Catedra
            ComboBoxCatedra.Enabled = True
            Exit Sub
        End If

        If ComboBoxTipo.Text = "Jefe de Departamento" Then
            'seccion Departamento
            ComboBoxDpto.SelectedIndex() = 0
            ComboBoxDpto.Enabled = True
            'seccion Catedra
            ComboBoxCatedra.Enabled = False
            Exit Sub
        End If

        'si es admin o bedel oculta los campos
        ComboBoxDpto.Enabled = False
        ComboBoxCatedra.Enabled = False
    End Sub

    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub

    Private Sub ButtonAgregarComision_Click(sender As Object, e As EventArgs) Handles ButtonAgregarComision.Click
        'primero valido que el perfil no existe en la BD
        Dim existePerfil As New SqlCommand("ExistePerfilUsuario", con)
        existePerfil.CommandType = CommandType.StoredProcedure
        existePerfil.Parameters.Add("@legajo", SqlDbType.VarChar, 255).Value = legajoUsuario
        existePerfil.Parameters.Add("@tipo", SqlDbType.VarChar, 255).Value = ComboBoxTipo.Text
        If ComboBoxTipo.Text = "Administrador" Or ComboBoxTipo.Text = "Bedel" Then
            existePerfil.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = "N/A"
            existePerfil.Parameters.Add("@catedra", SqlDbType.VarChar, 255).Value = "N/A"
        ElseIf ComboBoxTipo.Text = "Jefe de Departamento" Then
            existePerfil.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxDpto.Text
            existePerfil.Parameters.Add("@catedra", SqlDbType.VarChar, 255).Value = "N/A"
        Else
            existePerfil.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxDpto.Text
            existePerfil.Parameters.Add("@catedra", SqlDbType.VarChar, 255).Value = ComboBoxCatedra.Text
        End If

        Try
            con.Open()
            Dim existe As String = existePerfil.ExecuteScalar()
            con.Close()
            If existe = "" Then
                If MsgBox("¿Desea proseguir con el alta del perfil seleccionado?", MessageBoxButtons.OKCancel) = MsgBoxResult.Ok Then
                    Dim altaPerfil As New SqlCommand("AltaPerfilUsuario", con)
                    altaPerfil.CommandType = CommandType.StoredProcedure
                    altaPerfil.Parameters.Add("@legajo", SqlDbType.Int).Value = legajoUsuario
                    altaPerfil.Parameters.Add("@tipo", SqlDbType.VarChar, 100).Value = ComboBoxTipo.Text
                    If ComboBoxTipo.Text = "Administrador" Or ComboBoxTipo.Text = "Bedel" Then
                        altaPerfil.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = "N/A"
                        altaPerfil.Parameters.Add("@catedra", SqlDbType.VarChar, 255).Value = "N/A"
                    ElseIf ComboBoxTipo.Text = "Jefe de Departamento" Then
                        altaPerfil.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxDpto.Text
                        altaPerfil.Parameters.Add("@catedra", SqlDbType.VarChar, 255).Value = "N/A"
                    Else
                        altaPerfil.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxDpto.Text
                        altaPerfil.Parameters.Add("@catedra", SqlDbType.VarChar, 255).Value = ComboBoxCatedra.Text
                    End If

                    con.Open()
                    altaPerfil.ExecuteNonQuery()
                    MsgBox("Perfil agregado exitosamente.", MsgBoxStyle.Exclamation)
                    con.Close()
                    Me.Close()
                    Interfaz.RecargarDataGrid()
                Else
                    MsgBox("El perfil no se dió de alta.", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("El perfil ya existe para el usuario seleccionado.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class