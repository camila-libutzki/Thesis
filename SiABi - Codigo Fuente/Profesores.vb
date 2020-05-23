Imports System.Data.SqlClient
Public Class Profesores
    Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)
    Public Shared idPSeleccionado As String

    Public Sub BotonesDelParent()
        'BOTONES DEL PARENT
        Interfaz.botonVolver.Enabled = False
        Interfaz.botonImprimir.Visible = False
        Interfaz.botonPDF.Visible = False
    End Sub

    Public Sub LoadDataGrid()
    End Sub

    Private Sub Profesores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BotonesDelParent()
        ComboBoxCriterio.SelectedIndex = 0
        Interfaz.tipoPersona = "Profesor"

        'consulta vacia para cargar los titulos
        Dim obtenerProfesores As New SqlCommand("GetProfesoresSegunCriterio", con)
        obtenerProfesores.CommandType = CommandType.StoredProcedure
        obtenerProfesores.Parameters.Add("@criterio", SqlDbType.VarChar, 20).Value = ComboBoxCriterio.Text
        obtenerProfesores.Parameters.Add("@parametroBusqueda", SqlDbType.VarChar, 100).Value = ""
        obtenerProfesores.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ""
        obtenerProfesores.Parameters.Add("@catedra", SqlDbType.VarChar, 255).Value = ""

        Dim adapter As SqlDataAdapter = New SqlDataAdapter(obtenerProfesores)
        Dim dt As New DataTable
        adapter.Fill(dt)
        DataGridViewProfesores.DataSource = dt
        DataGridViewProfesores.Columns(1).HeaderText = "Legajo"
        DataGridViewProfesores.Columns(2).HeaderText = "Nombre"
        DataGridViewProfesores.Columns(3).HeaderText = "Apellido"
        DataGridViewProfesores.Columns(4).HeaderText = "DNI"
    End Sub

    '##### VERMAS
    Private Sub ButtonProfesorVerMas_Click(sender As Object, e As EventArgs) Handles ButtonProfesorVerMas.Click
        Dim existe As String = ""

        Dim obtenerHuellas As New SqlCommand("GetDatosHuellas", con)
        obtenerHuellas.CommandType = CommandType.StoredProcedure
        obtenerHuellas.Parameters.Add("@legajo", SqlDbType.Int).Value = idPSeleccionado
        obtenerHuellas.Parameters.Add("@tipoPersona", SqlDbType.VarChar, 8).Value = "Profesor"
        Try
            con.Open()
            existe = obtenerHuellas.ExecuteScalar()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

        If TextBoxSelectedProfesor.Text = "" Then
            MsgBox("Debe seleccionar un profesor de la grilla, haciendo click en el boton Elegir a la izquierda de cada uno.", MsgBoxStyle.Exclamation)
        Else
            '########## VER SI EL PROFESOR EXISTE EN SIABI
            If existe <> "" Then
                Dim frm As VerMasProfesor = New VerMasProfesor()
                frm.MdiParent = Interfaz
                frm.Dock = DockStyle.Fill
                frm.Show()
            Else
                If MsgBox("El profesor no tiene sus huellas registradas en SiABi. ¿Desea registrarlas ahora?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    Dim frm As AltaPersona = New AltaPersona()
                    frm.MdiParent = Interfaz
                    frm.Dock = DockStyle.Fill
                    frm.Show()
                End If
            End If
        End If
    End Sub

    Private Sub ComboBoxCriterio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCriterio.SelectedIndexChanged
        If ComboBoxCriterio.Text = "Legajo" Then
            TextoDeAyuda.Text = "Ingrese el legajo sin guiones ni espacios"
        End If
        If ComboBoxCriterio.Text = "DNI" Then
            TextoDeAyuda.Text = "Ingrese el DNI sin puntos ni espacios"
        End If
        If ComboBoxCriterio.Text = "Nombre" Then
            TextoDeAyuda.Text = "Ingrese los nombres del profesor"
        End If
        If ComboBoxCriterio.Text = "Apellido" Then
            TextoDeAyuda.Text = "Ingrese los apellidos del profesor"
        End If
    End Sub

    '##### BUSCAR SEGUN CRITERIO
    Private Sub ButtonBuscarProfesores_Click(sender As Object, e As EventArgs) Handles ButtonBuscarProfesores.Click
        If TextBoxBusqueda.Text = "" Then
            MsgBox("Debe agregar un valor de búsqueda.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If ComboBoxCriterio.Text = "Legajo" Then
            If IsNumeric(TextBoxBusqueda.Text) = False Then
                MsgBox("El valor del Legajo debe ser un número.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If
        If ComboBoxCriterio.Text = "DNI" Then
            If IsNumeric(TextBoxBusqueda.Text) = False Then
                MsgBox("El valor del DNI debe ser un número.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If

        Dim obtenerProfesores As New SqlCommand("GetProfesoresSegunCriterio", con)
        obtenerProfesores.CommandType = CommandType.StoredProcedure
        obtenerProfesores.Parameters.Add("@criterio", SqlDbType.VarChar, 20).Value = ComboBoxCriterio.Text
        obtenerProfesores.Parameters.Add("@parametroBusqueda", SqlDbType.VarChar, 100).Value = TextBoxBusqueda.Text

        If Interfaz.LabelTipoUsuarioActual.Text = "Jefe de Cátedra" Then
            obtenerProfesores.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = Interfaz.LabelCarreraDeCat.Text
            obtenerProfesores.Parameters.Add("@catedra", SqlDbType.VarChar, 255).Value = Interfaz.LabelCatDpto.Text
        ElseIf Interfaz.LabelTipoUsuarioActual.Text = "Jefe de Departamento" Then
            obtenerProfesores.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = Interfaz.LabelCatDpto.Text
            obtenerProfesores.Parameters.Add("@catedra", SqlDbType.VarChar, 255).Value = ""
        Else
            obtenerProfesores.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ""
            obtenerProfesores.Parameters.Add("@catedra", SqlDbType.VarChar, 255).Value = ""
        End If

        Try
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(obtenerProfesores)
            Dim dt As New DataTable
            adapter.Fill(dt)
            DataGridViewProfesores.DataSource = dt

            If DataGridViewProfesores.Rows.Count() = 0 Then
                MsgBox("No se encontraron profesores con el criterio seleccionado.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    '##### MUESTRA EN EL TEXT BOX EL ALUMNO SELECCIONADO Y LO GUARDA EN UNA VBLE LOCAL
    Private Sub DataGridViewProfesores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewProfesores.CellContentClick
        'obtengo fila+columna para saber si se hizo click sobre el botón y no otra celda del datagrid
        Dim columna As Integer = e.ColumnIndex
        Dim fila As Integer = e.RowIndex

        If columna = 0 Then
            If fila > -1 Then
                TextBoxSelectedProfesor.Text = DataGridViewProfesores.CurrentRow.Cells(2).Value
                idPSeleccionado = DataGridViewProfesores.CurrentRow.Cells(1).Value
            End If
        End If
    End Sub
End Class