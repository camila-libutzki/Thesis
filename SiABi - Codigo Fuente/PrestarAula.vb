Imports System.Data.SqlClient
Public Class PrestarAula
    Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)
    Dim antesE As String = ""

    Private Sub PrestarAula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        ComboBoxCarrera.SelectedIndex = 0
        ComboBoxHora.SelectedIndex = 0
        ComboBoxMin.SelectedIndex = 0

        Dim antesEntrada As New SqlCommand("GetAntesETolerancia", con)
        antesEntrada.CommandType = CommandType.StoredProcedure
        Try
            antesE = antesEntrada.ExecuteScalar()
            LabelTitulo.Text = "Las aulas se pueden prestar " + antesE + " minutos antes de la Hora de Inicio Oficial"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        con.Close()
        Me.Close()
    End Sub

    Private Sub ButtonGuardarCambios_Click(sender As Object, e As EventArgs) Handles ButtonGuardarCambios.Click
        Dim idMat As String = ""
        Dim esCorrecto As String = ""

        'obtener el id de la materia segun carrera+catedra+comision
        Dim buscarIdMateria As New SqlCommand("GetIdMateriaDeMateria", con)
        buscarIdMateria.CommandType = CommandType.StoredProcedure
        buscarIdMateria.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxCarrera.Text
        buscarIdMateria.Parameters.Add("@nombre", SqlDbType.VarChar, 255).Value = ComboBoxCatedra.Text
        buscarIdMateria.Parameters.Add("@comision", SqlDbType.SmallInt).Value = ComboBoxComision.Text

        Try
            idMat = buscarIdMateria.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

        If TextBoxHoraFinal.Text = "" Then
            MsgBox("Debe seleccionar una hora para poder seguir.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        'obtener el id de la planilla si se cursa en la fecha seleccionada
        Dim buscarIdPlanilla As New SqlCommand("ExistePlanillaPrestarAula", con)
            buscarIdPlanilla.CommandType = CommandType.StoredProcedure
            buscarIdPlanilla.Parameters.Add("@fecha", SqlDbType.Date).Value = datePrestarAula.Value.Date
            buscarIdPlanilla.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxCarrera.Text
            buscarIdPlanilla.Parameters.Add("@materia", SqlDbType.VarChar, 255).Value = ComboBoxCatedra.Text
            buscarIdPlanilla.Parameters.Add("@comision", SqlDbType.SmallInt).Value = ComboBoxComision.Text

        '### BUSCAR SI EXISTE UNA PLANILLA GENERADA EN EL DIA PARA EL ID MATERIA ENCONTRADO, Y VALIDAR SI LA HORA ACTUAL <= HoraInicioOficial
        Dim idPlanilla As String = ""
        Try
            idPlanilla = buscarIdPlanilla.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

        If idPlanilla <> "" Then
            Dim diaActual As Integer = datePrestarAula.Value.DayOfWeek
            Dim nombreDiaActual As String = Interfaz.GetDiaSemana(diaActual)

            Dim horaActualValida As New SqlCommand("ValidarHoraParaPrestarAula", con)
            horaActualValida.CommandType = CommandType.StoredProcedure
            horaActualValida.Parameters.Add("@nomDiaActual", SqlDbType.VarChar, 255).Value = nombreDiaActual
            horaActualValida.Parameters.Add("@horaActual", SqlDbType.VarChar, 255).Value = TextBoxHoraFinal.Text
            horaActualValida.Parameters.Add("@margen", SqlDbType.SmallInt).Value = antesE
            horaActualValida.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxCarrera.Text
            horaActualValida.Parameters.Add("@materia", SqlDbType.VarChar, 255).Value = ComboBoxCatedra.Text
            horaActualValida.Parameters.Add("@comision", SqlDbType.SmallInt).Value = ComboBoxComision.Text

            Try
                esCorrecto = horaActualValida.ExecuteScalar()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try

            If esCorrecto <> "" Then
                'que haga lo q tiene q hacerr
                Dim prestarAula As New SqlCommand("PrestarAula", con)
                prestarAula.CommandType = CommandType.StoredProcedure
                prestarAula.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = idPlanilla
                prestarAula.Parameters.Add("@aula", SqlDbType.SmallInt).Value = Aulas.idAulaSeleccionada
                Try
                    prestarAula.ExecuteScalar()
                    MsgBox("Aula prestada. Se encuentra asignada a la Carrera+Cátedra+Comisión elegidos.", MsgBoxStyle.Information)
                    Interfaz.carrera = ComboBoxCarrera.Text
                    Interfaz.comision = ComboBoxComision.Text
                    Interfaz.catedra = ComboBoxCatedra.Text
                    Me.Close()
                    Interfaz.CargarPrestada()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                End Try
            Else
                MsgBox("El horario seleccionado está fuera del rango permitido para prestar el aula.", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("La materia no se dicta en el día seleccionado.", MsgBoxStyle.Information)
        End If


    End Sub

    Private Sub ComboBoxCatedra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCatedra.SelectedIndexChanged
        ComboBoxComision.Items.Clear()
        Dim cargarComisiones As New SqlCommand("GetComisionesPorMateriaYCarrera", con)
        cargarComisiones.CommandType = CommandType.StoredProcedure
        cargarComisiones.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxCarrera.Text
        cargarComisiones.Parameters.Add("@materia", SqlDbType.VarChar, 255).Value = ComboBoxCatedra.Text

        Try
            Dim strComision As String = ""
            Dim dt As New DataTable
            dt.Load(cargarComisiones.ExecuteReader)

            For Each Fila As DataRow In dt.Rows
                strComision = Fila.Item(0).ToString()
                ComboBoxComision.Items.Add(strComision)
            Next
            ComboBoxComision.SelectedIndex() = 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ComboBoxCarrera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCarrera.SelectedIndexChanged
        ComboBoxCatedra.Items.Clear()
        Dim cargarMaterias As New SqlCommand("GetMateriasPorCarrera", con)
        cargarMaterias.CommandType = CommandType.StoredProcedure
        cargarMaterias.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxCarrera.Text

        Try
            Dim dt As New DataTable
            dt.Load(cargarMaterias.ExecuteReader)
            For Each Fila As DataRow In dt.Rows
                ComboBoxCatedra.Items.Add(Fila.Item(0))
            Next
            If cargarMaterias.ExecuteScalar() <> "" Then
                ComboBoxCatedra.SelectedIndex() = 0
            Else
                ComboBoxComision.Items.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub datePrestarAula_ValueChanged(sender As Object, e As EventArgs) Handles datePrestarAula.ValueChanged
        If datePrestarAula.Value.DayOfWeek = DayOfWeek.Saturday Then
            datePrestarAula.Value = datePrestarAula.Value.AddDays(-1)
            MsgBox("No se puede seleccionar el día Sábado")
            Exit Sub
        End If
        If datePrestarAula.Value.DayOfWeek = DayOfWeek.Sunday Then
            datePrestarAula.Value = datePrestarAula.Value.AddDays(-2)
            MsgBox("No se puede seleccionar el día Domingo")
            Exit Sub
        End If
    End Sub

    Private Sub ComboBoxHora_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxHora.SelectedIndexChanged
        TextBoxHoraFinal.Text = (ComboBoxHora.Text + ":" + ComboBoxMin.Text + " ")
    End Sub

    Private Sub ComboBoxMin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMin.SelectedIndexChanged
        TextBoxHoraFinal.Text = (ComboBoxHora.Text + ":" + ComboBoxMin.Text + " ")
    End Sub
End Class