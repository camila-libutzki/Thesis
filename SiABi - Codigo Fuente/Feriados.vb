Imports System.Data.SqlClient
Public Class Feriados
    Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)
    Dim fechaDesde As String = ""
    Dim fechaHasta As String = ""
    Dim diaDesde As String = ""
    Dim diaHasta As String = ""

    Public Sub BotonesDelParent()
        'BOTONES DEL PARENT
        Interfaz.botonVolver.Enabled = False
        Interfaz.botonImprimir.Visible = True
        Interfaz.botonPDF.Visible = True
    End Sub

    Private Sub buscarDesde_ValueChanged(sender As Object, e As EventArgs) Handles buscarDesde.ValueChanged
        If buscarDesde.Value.DayOfWeek = DayOfWeek.Saturday Then
            buscarDesde.Value = buscarDesde.Value.AddDays(-1)
            MsgBox("No se puede buscar por el día Sábado")
            Exit Sub
        End If
        If buscarDesde.Value.DayOfWeek = DayOfWeek.Sunday Then
            buscarDesde.Value = buscarDesde.Value.AddDays(-2)
            MsgBox("No se puede buscar por el día Domingo")
            Exit Sub
        End If
    End Sub

    Private Sub buscarHasta_ValueChanged(sender As Object, e As EventArgs) Handles buscarHasta.ValueChanged
        fechaHasta = ""
        If buscarHasta.Value.DayOfWeek = DayOfWeek.Saturday Then
            buscarHasta.Value = buscarHasta.Value.AddDays(-1)
            MsgBox("No se puede buscar por el día Sábado")
            Exit Sub
        End If
        If buscarHasta.Value.DayOfWeek = DayOfWeek.Sunday Then
            buscarHasta.Value = buscarHasta.Value.AddDays(-2)
            MsgBox("No se puede buscar por el día Domingo")
            Exit Sub
        End If
        'obtiene el número de la fecha
        fechaHasta = buscarHasta.Value.Date
        'obtiene el número del día de la semana
        diaHasta = buscarHasta.Value.DayOfWeek
    End Sub

    Private Sub dateDesde_ValueChanged_1(sender As Object, e As EventArgs) Handles dateDesde.ValueChanged
        If dateDesde.Value.DayOfWeek = DayOfWeek.Saturday Then
            dateDesde.Value = dateDesde.Value.AddDays(-1)
            MsgBox("No se puede marcar el día Sábado")
            Exit Sub
        End If
        If dateDesde.Value.DayOfWeek = DayOfWeek.Sunday Then
            dateDesde.Value = dateDesde.Value.AddDays(-2)
            MsgBox("No se puede marcar el día Domingo")
            Exit Sub
        End If
    End Sub

    Private Sub dateHasta_ValueChanged(sender As Object, e As EventArgs) Handles dateHasta.ValueChanged
        fechaHasta = ""
        If dateHasta.Value.DayOfWeek = DayOfWeek.Saturday Then
            dateHasta.Value = dateHasta.Value.AddDays(-1)
            MsgBox("No se puede marcar el día Sábado")
            Exit Sub
        End If
        If dateHasta.Value.DayOfWeek = DayOfWeek.Sunday Then
            dateHasta.Value = dateHasta.Value.AddDays(-2)
            MsgBox("No se puede marcar el día Domingo")
            Exit Sub
        End If
        'obtiene el número de la fecha
        fechaHasta = dateHasta.Value.Date
        'obtiene el número del día de la semana
        diaHasta = dateHasta.Value.DayOfWeek
    End Sub
    Private Sub Feriados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'que por defecto aparza seleccionado el primer valor del combobox
        ComboBoxTipoDia.SelectedIndex = 0
        ComboBoxCriterioBusqueda.SelectedIndex = 0
        ComboBoxBuscarTipoDia.SelectedIndex = 0

        'si el dia actual es sabado o domingo se para sobre la fecha del lunes siguiente
        Dim diaActual As DateTime = DateTime.Now
        If diaActual.DayOfWeek = 6 Then
            dateDesde.Value = diaActual.AddDays(2)
            dateHasta.Value = diaActual.AddDays(2)
            buscarDesde.Value = diaActual.AddDays(2)
            buscarHasta.Value = diaActual.AddDays(2)
        End If
        If diaActual.DayOfWeek = 7 Then
            dateDesde.Value = diaActual.AddDays(1)
            dateHasta.Value = diaActual.AddDays(1)
            buscarDesde.Value = diaActual.AddDays(1)
            buscarHasta.Value = diaActual.AddDays(1)
        End If

        If Interfaz.LabelTipoUsuarioActual.Text = "Jefe de Cátedra" Or Interfaz.LabelTipoUsuarioActual.Text = "Jefe de Departamento" Then
            GroupBoxMarcar.Visible = False
            ButtonMarcarDias.Visible = False
        End If

        BotonesDelParent()
    End Sub

    Private Sub CheckBoxHasta_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxHasta.CheckedChanged
        If CheckBoxHasta.Checked = True Then
            dateHasta.Enabled = True
        Else
            dateHasta.Enabled = False
        End If
    End Sub

    Private Sub ComboBoxTipoDia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTipoDia.SelectedIndexChanged
        If ComboBoxTipoDia.Text = "Feriado" Then
            TextBoxDescripcion.ReadOnly = False
        Else
            TextBoxDescripcion.ReadOnly = True
            TextBoxDescripcion.Text = ""
        End If
    End Sub

    Private Sub dateDesde_ValueChanged(sender As Object, e As EventArgs)
        If dateDesde.Value.DayOfWeek = DayOfWeek.Saturday Then
            dateDesde.Value = dateDesde.Value.AddDays(-1)
            MsgBox("No se puede marcar el día Sábado")
            Exit Sub
        End If
        If dateDesde.Value.DayOfWeek = DayOfWeek.Sunday Then
            dateDesde.Value = dateDesde.Value.AddDays(-2)
            MsgBox("No se puede marcar el día Domingo")
            Exit Sub
        End If
    End Sub

    Private Sub ButtonMostrarTodos_Click(sender As Object, e As EventArgs) Handles ButtonMostrarTodos.Click
        Try
            Dim cargarCalendario As New SqlCommand("GetDiasMarcadosCalendario", con)

            Dim adapter As SqlDataAdapter = New SqlDataAdapter(cargarCalendario)
            Dim dt As New DataTable
            adapter.Fill(dt)

            DataGridViewCalendario.DataSource = dt
            DataGridViewCalendario.Columns(1).HeaderText = "Fecha"
            DataGridViewCalendario.Columns(2).HeaderText = "Dia"
            DataGridViewCalendario.Columns(3).HeaderText = "Tipo"
            DataGridViewCalendario.Columns(4).HeaderText = "Descripción"
            'ajusto SOLO el ancho de esta columna segun el contenido
            DataGridViewCalendario.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            If dt.Rows.Count = 0 Then
                MsgBox("No hay días marcados como no cursables.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ButtonMarcarDias_Click(sender As Object, e As EventArgs) Handles ButtonMarcarDias.Click
        fechaDesde = ""
        Dim nombreDia As String

        'obtiene el número de la fecha
        fechaDesde = dateDesde.Value.Date
        'obtiene el número del día de la semana
        diaDesde = dateDesde.Value.DayOfWeek

        Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)

        Dim fechaExiste As String = ""
        Dim sqlselectFecha As String = ""
        Dim cmd As New SqlCommand

        If CheckBoxHasta.Checked Then
            '##### da de alta un rango

            Dim fechaHasta As String = dateHasta.Value.Date
            If DateTime.Compare(fechaHasta, fechaDesde) > 0 Then
                '##### si la fecha 'desde' es menor que la fecha 'hasta'
                Dim primerDia As Date = dateDesde.Value.Date
                Dim diaSemana As Integer
                Dim ultimoDia As Date = dateHasta.Value.Date
                Dim flagExiste As Boolean = False

                Try
                    con.Open()
                    Do While primerDia <= ultimoDia
                        diaSemana = primerDia.DayOfWeek
                        If diaSemana = 6 Then 'si es sabado salteo 2 dias
                            primerDia = primerDia.AddDays(2)
                            Continue Do 'salteo el bucle
                        End If

                        fechaExiste = ""
                        sqlselectFecha = "SELECT fecha FROM diasNoCursables WHERE fecha = '" + primerDia + "'"

                        Dim cmdSelectFecha As New SqlCommand(sqlselectFecha, con) '''''''como hago para ejecutar el sqlcommand si defino la vble mas arriba?
                        Try
                            fechaExiste = cmdSelectFecha.ExecuteScalar()

                            '##### SI LA FECHA NO EXISTE EN LA BD LO DA DE ALTA
                            If fechaExiste = "" Then
                                nombreDia = Interfaz.GetDiaSemana(diaSemana)
                                Try
                                    cmd.Connection = con
                                    cmd.CommandText = "INSERT INTO diasNoCursables (fecha, dia, tipo, descripcion) VALUES ('" + primerDia + "' , '" + nombreDia + "', '" + ComboBoxTipoDia.Text + "', '" + TextBoxDescripcion.Text + "')"
                                    cmd.ExecuteNonQuery()
                                Catch ex As Exception
                                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                                End Try
                            Else
                                flagExiste = True
                            End If
                        Catch ex As Exception
                            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                        End Try

                        primerDia = primerDia.AddDays(1)
                    Loop
                    If flagExiste = True Then
                        MsgBox("No se agregó alguna de las fechas seleccionadas porque ya existía en la Base de Datos. Revise el listado de fechas agregadas al rango seleccionado.", MsgBoxStyle.Exclamation)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                    con.Close()
                End Try
                con.Close()
            Else
                MsgBox("La fecha seleccionada en 'Hasta' debe ser mayor a la fecha seleccionada en 'Desde'", MsgBoxStyle.Exclamation)
            End If
        Else
            '##### da de alta una fecha
            sqlselectFecha = "SELECT fecha FROM diasNoCursables WHERE fecha = '" + fechaDesde + "'"

            Dim cmdSelectFecha As New SqlCommand(sqlselectFecha, con)
            Try
                con.Open()
                fechaExiste = cmdSelectFecha.ExecuteScalar()
                con.Close()

                '##### SI LA FECHA NO EXISTE EN LA BD LO DA DE ALTA
                If fechaExiste = "" Then
                    Try
                        nombreDia = Interfaz.GetDiaSemana(diaDesde)
                        MsgBox(nombreDia)

                        con.Open()
                        cmd.Connection = con
                        cmd.CommandText = "INSERT INTO diasNoCursables (fecha, dia, tipo, descripcion) VALUES ('" + fechaDesde + "' , '" + nombreDia + "', '" + ComboBoxTipoDia.Text + "', '" + TextBoxDescripcion.Text + "')"
                        cmd.ExecuteNonQuery()
                        con.Close()

                        MsgBox("Fecha agregada correctamente", MsgBoxStyle.Information)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                    End Try
                Else
                    MsgBox("No se puede agregar la fecha, ya existe en la base de datos", MsgBoxStyle.Exclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub DataGridViewCalendario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCalendario.CellContentClick
        'obtengo fila+columna para saber si se hizo click sobre el botón y no otra celda del datagrid
        Dim columna As Integer = e.ColumnIndex
        Dim fila As Integer = e.RowIndex

        If columna = 0 Then
            If fila > -1 Then
                If MsgBox("¿Está seguro que desea eliminar la fecha seleccionada?", MessageBoxButtons.OKCancel) = MsgBoxResult.Ok Then
                    Dim eliminarFecha As Date = DataGridViewCalendario.CurrentRow.Cells(1).Value

                    Try
                        Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)
                        Dim sqldeleteFecha As String = "DELETE FROM diasNoCursables WHERE fecha = '" + eliminarFecha + "'"
                        Dim cmdSelect As New SqlCommand(sqldeleteFecha, con)
                        con.Open()
                        cmdSelect.ExecuteNonQuery()
                        con.Close()

                        MsgBox("La fecha fue eliminada exitosamente", MsgBoxStyle.Information)
                        'recargar datagrid?
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                    End Try
                Else
                    MsgBox("La fecha no fue eliminada", MsgBoxStyle.Information)
                End If
            End If
        End If
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)
        Dim cmd As New SqlCommand

        If ComboBoxCriterioBusqueda.Text = "Tipo de día" Then
            Dim sqlselectusuarios As String = "SELECT fecha AS Fecha, dia AS Día, tipo AS Tipo, descripcion AS Descripción FROM diasNoCursables WHERE tipo = '" + ComboBoxBuscarTipoDia.Text + "'"
            Dim cmdSelect As New SqlCommand(sqlselectusuarios, con)
            Try
                Dim da As New SqlDataAdapter(cmdSelect)
                Dim ds As New DataTable
                da.Fill(ds)

                Me.DataGridViewCalendario.DataSource = ds

                'si no encuentra fechas con el criterio de busqueda avisa
                If Me.DataGridViewCalendario.Rows.Count() = 0 Then
                    MsgBox("No se encontraron fechas cargadas con el criterio seleccionado", MsgBoxStyle.Information)
                End If
                Exit Sub
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
            Exit Sub
        End If

        If CheckBoxBuscarHasta.Checked = False Then
            Try
                Dim sqlselectfechas As String = "SELECT fecha AS Fecha, dia AS Día, tipo AS Tipo, descripcion AS Descripción FROM diasNoCursables WHERE fecha = @fecha"
                Dim cmdSelectFechas As New SqlCommand(sqlselectfechas, con)
                cmdSelectFechas.Parameters.Add("@fecha", SqlDbType.Date).Value = buscarDesde.Value.Date

                Dim da As New SqlDataAdapter(cmdSelectFechas)
                Dim ds As New DataTable
                da.Fill(ds)

                Me.DataGridViewCalendario.DataSource = ds

                'si no encuentra fechas con el criterio de busqueda avisa
                If Me.DataGridViewCalendario.Rows.Count() = 0 Then
                    MsgBox("No se encontraron fechas cargadas con el criterio seleccionado", MsgBoxStyle.Information)
                End If
                Exit Sub
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        Else
            Try
                Dim sqlselectfechas As String = "SELECT fecha AS Fecha, dia AS Día, tipo AS Tipo, descripcion AS Descripción FROM diasNoCursables WHERE fecha BETWEEN @startDate AND @endDate"
                Dim cmdSelectFechas As New SqlCommand(sqlselectfechas, con)

                cmdSelectFechas.Parameters.Add("@startDate", SqlDbType.Date).Value = buscarDesde.Value.Date
                cmdSelectFechas.Parameters.Add("@endDate", SqlDbType.Date).Value = buscarHasta.Value.Date

                Dim da As New SqlDataAdapter(cmdSelectFechas)
                Dim ds As New DataTable
                da.Fill(ds)
                ds.DefaultView.Sort = "Fecha"

                Me.DataGridViewCalendario.DataSource = ds

                'si no encuentra fechas con el criterio de busqueda avisa
                If Me.DataGridViewCalendario.Rows.Count() = 0 Then
                    MsgBox("No se encontraron fechas cargadas con el criterio seleccionado", MsgBoxStyle.Information)
                End If
                Exit Sub
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub CheckBoxBuscarHasta_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBuscarHasta.CheckedChanged
        If CheckBoxBuscarHasta.Checked = True Then
            buscarHasta.Enabled = True
        Else
            buscarHasta.Enabled = False
        End If
    End Sub

    Private Sub ComboBoxCriterioBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCriterioBusqueda.SelectedIndexChanged
        If ComboBoxCriterioBusqueda.Text = "Fecha" Then
            GroupBoxFecha.Enabled = True
            GroupBoxTipoDia.Enabled = False
        Else
            GroupBoxFecha.Enabled = False
            GroupBoxTipoDia.Enabled = True
        End If
    End Sub
End Class