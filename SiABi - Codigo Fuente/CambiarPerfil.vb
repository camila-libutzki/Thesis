Imports System.Data.SqlClient
Public Class CambiarPerfil
    Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)

    Private Sub CambiarPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cargar el datagrid de perfiles
        Dim obtenerPerfiles As New SqlCommand("GetPerfilesUsuario", con)
        obtenerPerfiles.CommandType = CommandType.StoredProcedure
        obtenerPerfiles.Parameters.Add("@legajo", SqlDbType.VarChar, 10).Value = Interfaz.legajoLogueado

        Dim adapter As SqlDataAdapter = New SqlDataAdapter(obtenerPerfiles)
        Dim dt As New DataTable
        adapter.Fill(dt)

        DataGridViewPerfilesXUsuario.DataSource = dt
        DataGridViewPerfilesXUsuario.Columns(1).HeaderText = "Tipo"
        DataGridViewPerfilesXUsuario.Columns(2).HeaderText = "Departamento"
        DataGridViewPerfilesXUsuario.Columns(3).HeaderText = "Cátedra"
    End Sub

    Private Sub DataGridViewPerfilesXUsuario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPerfilesXUsuario.CellContentClick
        'obtengo fila+columna para saber si se hizo click sobre el botón y no otra celda del datagrid
        Dim columna As Integer = e.ColumnIndex
        Dim fila As Integer = e.RowIndex

        If columna = 0 Then
            If fila > -1 Then
                If MsgBox("¿Está seguro que desea cambiar al el perfil seleccionado?", MessageBoxButtons.OKCancel) = MsgBoxResult.Ok Then
                    '#### ASIGNA TIPO Y NOMBRE DE USUARIO AL MDI PARENT: INTERFAZ
                    If DataGridViewPerfilesXUsuario.CurrentRow.Cells(1).Value = "Administrador" Or DataGridViewPerfilesXUsuario.CurrentRow.Cells(1).Value = "Bedel" Then
                        Interfaz.LabelCarreraDeCat.Visible = False
                        Interfaz.LabelCatDpto.Visible = False
                    ElseIf DataGridViewPerfilesXUsuario.CurrentRow.Cells(1).Value = "Jefe de Departamento" Then
                        Dim textoCD As String = DataGridViewPerfilesXUsuario.CurrentRow.Cells(2).Value
                        Dim fontCD As New Font("Segoe UI", 9)
                        Interfaz.LabelCatDpto.Visible = True
                        Interfaz.LabelCatDpto.Text = DataGridViewPerfilesXUsuario.CurrentRow.Cells(2).Value
                        Interfaz.LabelCatDpto.Size = TextRenderer.MeasureText(textoCD, fontCD)
                        Interfaz.LabelCarreraDeCat.Visible = False
                    Else
                        Dim textoCC As String = DataGridViewPerfilesXUsuario.CurrentRow.Cells(2).Value
                        Dim fontCC As New Font("Segoe UI", 9)
                        Interfaz.LabelCarreraDeCat.Visible = True
                        Interfaz.LabelCarreraDeCat.Text = DataGridViewPerfilesXUsuario.CurrentRow.Cells(2).Value
                        Interfaz.LabelCarreraDeCat.Size = TextRenderer.MeasureText(textoCC, fontCC)

                        Dim textoCD As String = DataGridViewPerfilesXUsuario.CurrentRow.Cells(3).Value
                        Dim fontCD As New Font("Segoe UI", 9)
                        Interfaz.LabelCatDpto.Visible = True
                        Interfaz.LabelCatDpto.Text = DataGridViewPerfilesXUsuario.CurrentRow.Cells(3).Value
                        Interfaz.LabelCatDpto.Size = TextRenderer.MeasureText(textoCD, fontCD)
                    End If
                    '### label tipo usuario
                    Dim textoUA As String = DataGridViewPerfilesXUsuario.CurrentRow.Cells(1).Value
                    Dim fontUA As New Font("Segoe UI", 9)
                    Interfaz.LabelTipoUsuarioActual.Text = DataGridViewPerfilesXUsuario.CurrentRow.Cells(1).Value
                    Interfaz.LabelTipoUsuarioActual.Size = TextRenderer.MeasureText(textoUA, fontUA)

                    Me.Close()
                    Interfaz.CargarBarraSuperior()

                    'CERRAR TODOS LOS CHILDS ACTIVOS
                    For Each f As Form In Me.MdiChildren
                        f.Close()
                    Next
                    Interfaz.botonVolver.Enabled = False
                    Interfaz.botonImprimir.Visible = False
                    Interfaz.botonPDF.Visible = False

                    Dim frm As Inicio = New Inicio()
                    frm.MdiParent = Interfaz
                    frm.Show()
                Else
                    MsgBox("No se cambió de perfil.", MsgBoxStyle.Information)
                End If
            End If
        End If
    End Sub

    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Me.Close()
        Interfaz.VolverAInicio()
    End Sub
End Class