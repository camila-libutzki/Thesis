Imports System.Data.SqlClient
Public Class Alumnos
    Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)
    Public Shared idASeleccionado As String

    Public Sub BotonesDelParent()
        'BOTONES DEL PARENT
        Interfaz.botonVolver.Enabled = False
        Interfaz.botonImprimir.Visible = False
        Interfaz.botonPDF.Visible = False
    End Sub

    Public Sub LoadDataGrid()
    End Sub

    Private Sub ComboBoxtipocriterio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTipoCriterio.SelectedIndexChanged
        If ComboBoxTipoCriterio.Text = "Legajo" Then
            TextoDeAyuda.Text = "Ingrese el legajo sin guiones ni espacios"
        End If
        If ComboBoxTipoCriterio.Text = "DNI" Then
            TextoDeAyuda.Text = "Ingrese el DNI sin puntos ni espacios"
        End If
        If ComboBoxTipoCriterio.Text = "Nombre" Then
            TextoDeAyuda.Text = "Ingrese los nombres del alumno"
        End If
        If ComboBoxTipoCriterio.Text = "Apellido" Then
            TextoDeAyuda.Text = "Ingrese los apellidos del alumno"
        End If
    End Sub

    Private Sub Alumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BotonesDelParent()
        ComboBoxTipoCriterio.SelectedIndex = 0
        Interfaz.tipoPersona = "Alumno"

        'consulta vacia para que muestre los titulos
        Dim obtenerAlumnos As New SqlCommand("GetAlumnosSegunCriterio", con)
        obtenerAlumnos.CommandType = CommandType.StoredProcedure
        obtenerAlumnos.Parameters.Add("@criterio", SqlDbType.VarChar, 20).Value = ComboBoxTipoCriterio.Text
        obtenerAlumnos.Parameters.Add("@parametroBusqueda", SqlDbType.VarChar, 100).Value = ""
        obtenerAlumnos.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ""
        obtenerAlumnos.Parameters.Add("@catedra", SqlDbType.VarChar, 255).Value = ""

        Try
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(obtenerAlumnos)
            Dim dt As New DataTable
            adapter.Fill(dt)
            DataGridViewAlumnos.DataSource = dt

            DataGridViewAlumnos.Columns(1).HeaderText = "Legajo"
            DataGridViewAlumnos.Columns(2).HeaderText = "Nombre"
            DataGridViewAlumnos.Columns(3).HeaderText = "Apellido"
            DataGridViewAlumnos.Columns(4).HeaderText = "DNI"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    '##### MUESTRA EN EL TEXT BOX EL ALUMNO SELECCIONADO Y LO GUARDA EN UNA VBLE LOCAL
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAlumnos.CellContentClick
        'obtengo fila+columna para saber si se hizo click sobre el botón y no otra celda del datagrid
        Dim columna As Integer = e.ColumnIndex
        Dim fila As Integer = e.RowIndex

        If columna = 0 Then
            If fila > -1 Then
                TextBoxSelectedAlumno.Text = DataGridViewAlumnos.CurrentRow.Cells(2).Value
                idASeleccionado = DataGridViewAlumnos.CurrentRow.Cells(1).Value
            End If
        End If
    End Sub

    '##### VERMAS
    Private Sub ButtonAlumnoVerMas_Click(sender As Object, e As EventArgs) Handles ButtonAlumnoVerMas.Click
        If TextBoxSelectedAlumno.Text = "" Then
            MsgBox("Debe seleccionar un alumno de la grilla, haciendo click en el boton Elegir a la izquierda de cada uno.", MsgBoxStyle.Exclamation)
        Else
            Dim existe As String = ""

            Dim obtenerHuellas As New SqlCommand("GetDatosHuellas", con)
            obtenerHuellas.CommandType = CommandType.StoredProcedure
            obtenerHuellas.Parameters.Add("@legajo", SqlDbType.Int).Value = idASeleccionado
            obtenerHuellas.Parameters.Add("@tipoPersona", SqlDbType.VarChar, 8).Value = "Alumno"
            Try
                con.Open()
                existe = obtenerHuellas.ExecuteScalar()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try

            '##### VER SI EL ALUMNO EXISTE EN SIABI
            If existe <> "" Then
                Dim frm As VerMasAlumno = New VerMasAlumno()
                frm.MdiParent = Interfaz
                frm.Dock = DockStyle.Fill
                frm.Show()
                frm.ColorearLibres()
            Else
                If MsgBox("El alumno no tiene sus huellas registradas en SiABi. ¿Desea registrarlas ahora?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    Dim frm As AltaPersona = New AltaPersona()
                    frm.MdiParent = Interfaz
                    frm.Dock = DockStyle.Fill
                    frm.Show()
                End If
            End If
        End If
    End Sub

    '##### BUSCAR SEGUN CRITERIO
    Private Sub ButtonBuscarxCriterio_Click(sender As Object, e As EventArgs) Handles ButtonBuscarxCriterio.Click
        If TextBoxCriterioDato.Text = "" Then
            MsgBox("Debe agregar un valor de búsqueda.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If ComboBoxTipoCriterio.Text = "Legajo" Then
            If IsNumeric(TextBoxCriterioDato.Text) = False Then
                MsgBox("El valor del Legajo debe ser un número.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If
        If ComboBoxTipoCriterio.Text = "DNI" Then
            If IsNumeric(TextBoxCriterioDato.Text) = False Then
                MsgBox("El valor del DNI debe ser un número.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If

        Dim obtenerAlumnos As New SqlCommand("GetAlumnosSegunCriterio", con)
        obtenerAlumnos.CommandType = CommandType.StoredProcedure
        obtenerAlumnos.Parameters.Add("@criterio", SqlDbType.VarChar, 20).Value = ComboBoxTipoCriterio.Text
        obtenerAlumnos.Parameters.Add("@parametroBusqueda", SqlDbType.VarChar, 100).Value = TextBoxCriterioDato.Text

        If Interfaz.LabelTipoUsuarioActual.Text = "Jefe de Cátedra" Then
            obtenerAlumnos.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = Interfaz.LabelCarreraDeCat.Text
            obtenerAlumnos.Parameters.Add("@catedra", SqlDbType.VarChar, 255).Value = Interfaz.LabelCatDpto.Text
        ElseIf Interfaz.LabelTipoUsuarioActual.Text = "Jefe de Departamento" Then
            obtenerAlumnos.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = Interfaz.LabelCatDpto.Text
            obtenerAlumnos.Parameters.Add("@catedra", SqlDbType.VarChar, 255).Value = ""
        Else
            obtenerAlumnos.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ""
            obtenerAlumnos.Parameters.Add("@catedra", SqlDbType.VarChar, 255).Value = ""
        End If

        Try
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(obtenerAlumnos)
            Dim dt As New DataTable
            adapter.Fill(dt)
            DataGridViewAlumnos.DataSource = dt

            DataGridViewAlumnos.Columns(1).HeaderText = "Legajo"
            DataGridViewAlumnos.Columns(2).HeaderText = "Nombre"
            DataGridViewAlumnos.Columns(3).HeaderText = "Apellido"
            DataGridViewAlumnos.Columns(4).HeaderText = "DNI"

            If DataGridViewAlumnos.Rows.Count() = 0 Then
                MsgBox("No se encontraron alumnos con el criterio seleccionado.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class