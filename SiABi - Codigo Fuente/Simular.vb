Imports System.Data.SqlClient
Public Class Simular
    Dim fechaActual As Date
    Dim diaActual As Integer
    Dim nombreDiaActual As String
    Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)
    Dim cmd As New SqlCommand

    Dim legajo As String
    Dim idAula As String
    Dim horario As String
    Dim horaOficial As String

    Dim materiaActual As String = ""
    Dim comisionActual As String = ""
    Dim tipodeClase As String
    Dim cargoProf As String

    'para seleccionar la primera fila de las tablas
    Dim getTopIdAuxMateriaCom As New SqlCommand("SimularGetTopIdAuxMateriaCom", con)
    Dim getTopComAuxMateriaCom As New SqlCommand("SimularGetTopComAuxMateriaCom", con)
    Dim getTopIdAuxProfXMateria As New SqlCommand("SimularGetTopIdAuxProfXMateria", con)

    'para eliminar la primera fila de las tablas
    Dim borrarTopAuxProfXMateria As New SqlCommand("SimularDeleteTopAuxProfXMateria", con)
    Dim borrarTopAuxMateriaCom As New SqlCommand("SimularDeleteTopAuxMateriaCom", con)

    Private Sub ColorearCierreForzados()
        'COLOREA LAS FILAS DE LOS Cierres forzados
        For Each fila As DataGridViewRow In DataGridViewPlanillas.Rows
            If fila.Cells("estadoCursada").Value.ToString() = "Cierre forzado" Then
                fila.DefaultCellStyle.BackColor = Color.Orange
            End If
        Next
    End Sub

    Private Sub Simular_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BOTONES DEL PARENT
        Interfaz.botonVolver.Enabled = False
        Interfaz.botonImprimir.Visible = True
        Interfaz.botonPDF.Visible = True
        ButtonVerMas.Visible = False

        ComboBoxHora.SelectedIndex = 0
        ComboBoxMin.SelectedIndex = 0
        ComboBoxHoraA.SelectedIndex = 0
        ComboBoxMinA.SelectedIndex = 0
        ComboBoxhoraSimCierre.SelectedIndex = 0
        ComboBoxminutosSimCierre.SelectedIndex = 0

        TextBoxHoraFinal.Text = (ComboBoxHora.Text + ":" + ComboBoxMin.Text + " ")
        TextBoxHoraFinalA.Text = (ComboBoxHoraA.Text + ":" + ComboBoxMinA.Text + " ")
        TextBoxhoraFinalCierre.Text = (ComboBoxhoraSimCierre.Text + ":" + ComboBoxminutosSimCierre.Text + " ")

        Dim buscarPlanillasFecha As New SqlCommand("SimularBuscarPlanillasFecha", con)
        buscarPlanillasFecha.CommandType = CommandType.StoredProcedure
        buscarPlanillasFecha.Parameters.Add("@fecha", SqlDbType.Date).Value = "13/1/1901"


        Dim da As New SqlDataAdapter(buscarPlanillasFecha)
        Dim ds As New DataTable
        da.Fill(ds)
        DataGridViewPlanillas.DataSource = ds

        DataGridViewPlanillas.Columns("fecha").HeaderText = "Fecha"
        DataGridViewPlanillas.Columns("nombre").HeaderText = "Materia"
        DataGridViewPlanillas.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewPlanillas.Columns("comisión").HeaderText = "Comisión"
        DataGridViewPlanillas.Columns("horaInicioReal").HeaderText = "Hora Inicio Real"
        DataGridViewPlanillas.Columns("horaFinReal").HeaderText = "Hora Fin Real"
        DataGridViewPlanillas.Columns("estadoCursada").HeaderText = "Estado Cursada"

        'para seleccionar la primera fila de las tablas
        getTopIdAuxMateriaCom.CommandType = CommandType.StoredProcedure
        getTopComAuxMateriaCom.CommandType = CommandType.StoredProcedure
        getTopIdAuxProfXMateria.CommandType = CommandType.StoredProcedure

        'para eliminar la primera fila de las tablas
        borrarTopAuxProfXMateria.CommandType = CommandType.StoredProcedure
        borrarTopAuxMateriaCom.CommandType = CommandType.StoredProcedure

        aulaProfesor.Items.Clear()
        aulaAlumno.Items.Clear()
        Dim cargarAulas As New SqlCommand("GetAulas", con)
        cargarAulas.CommandType = CommandType.StoredProcedure

        Try
            con.Open()
            Dim dt As New DataTable
            dt.Load(cargarAulas.ExecuteReader)
            For Each Fila As DataRow In dt.Rows
                aulaProfesor.Items.Add(Fila.Item(0))
                aulaAlumno.Items.Add(Fila.Item(0))
            Next
            con.Close()
            If aulaProfesor.Items.Count > 0 Then
                aulaProfesor.SelectedIndex() = 0
                aulaAlumno.SelectedIndex() = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ButtonModificarHuellas_Click(sender As Object, e As EventArgs) Handles ButtonGenerarPlanillas.Click
        fechaActual = datePlanillas.Value.Date
        Dim fechaExiste As String = ""

        Dim validarDia As New SqlCommand("SimularValidarDiaNoCursable", con)
        validarDia.CommandType = CommandType.StoredProcedure
        validarDia.Parameters.Add("@fecha", SqlDbType.Date).Value = fechaActual

        Try
            con.Open()
            fechaExiste = validarDia.ExecuteScalar()

            '##### SI LA FECHA NO EXISTE EN LA BD GENERA LAS PLANILLAS
            If fechaExiste = "" Then
                diaActual = datePlanillas.Value.DayOfWeek
                nombreDiaActual = Interfaz.GetDiaSemana(diaActual)

                'cargo en una tabla auxiliar las catedra+comision que se dictan en el dia
                Dim cargarMatComAuxiliar As New SqlCommand("SimularCargarAuxMatCom", con)
                cargarMatComAuxiliar.CommandType = CommandType.StoredProcedure
                cargarMatComAuxiliar.Parameters.Add("@diaActual", SqlDbType.VarChar, 9).Value = nombreDiaActual

                Dim cantPlanillas As Integer = cargarMatComAuxiliar.ExecuteNonQuery()

                If cantPlanillas = 0 Then
                    MsgBox("No se generaron planillas. Ninguna materia coincide con el criterio ingresado.")
                Else
                    Dim cantRegistros As Integer = cantPlanillas
                    Dim legajoActual As Integer

                    'obtener el id del ultimo registro insertado en la tabla de Planillas
                    Dim getMaxIdPlanilla As New SqlCommand("SimularGetMaxIdPlanilla", con)
                    getMaxIdPlanilla.CommandType = CommandType.StoredProcedure
                    Dim maxIDPlanilla As Integer

                    'contar la cantidad de registros insertados en la tabla auxiliar
                    Dim getCantProfesXMat As New SqlCommand("SimularGetCantProfesXMat", con)
                    getCantProfesXMat.CommandType = CommandType.StoredProcedure
                    Dim cantRegistrosProf As Integer

                    Dim insertPlanilla As New SqlCommand("SimularInsertPlanilla", con)
                    insertPlanilla.CommandType = CommandType.StoredProcedure
                    'defino los parámetros a pasar al registro de planilla que se genera
                    insertPlanilla.Parameters.Add("@materia", SqlDbType.Int)
                    insertPlanilla.Parameters.Add("@comision", SqlDbType.SmallInt)
                    insertPlanilla.Parameters.Add("@fecha", SqlDbType.Date)
                    insertPlanilla.Parameters.Add("@estado", SqlDbType.VarChar, 12)
                    insertPlanilla.Parameters.Add("@aulaPrestada", SqlDbType.SmallInt)
                    insertPlanilla.Parameters.Add("@tipoClase", SqlDbType.VarChar, 8)

                    Dim insertProfesAux As New SqlCommand("SimularCargarAuxProfeMatCom", con)
                    insertProfesAux.CommandType = CommandType.StoredProcedure
                    'para cargar en una tabla auxiliar los profesores que dictan la clase para la catedra+comision seleccionada
                    insertProfesAux.Parameters.Add("@materiaAct", SqlDbType.VarChar, 255)
                    insertProfesAux.Parameters.Add("@comisionAct", SqlDbType.SmallInt)

                    Dim insertProfePlanilla As New SqlCommand("SimularInsertProfePlanilla", con)
                    insertProfePlanilla.CommandType = CommandType.StoredProcedure
                    'defino los parámetros a pasar al registro de profesor que se genera
                    insertProfePlanilla.Parameters.Add("@idPPlanilla", SqlDbType.Int)
                    insertProfePlanilla.Parameters.Add("@legajo", SqlDbType.Int)
                    insertProfePlanilla.Parameters.Add("@asistencia", SqlDbType.Char, 1)

                    Dim getNombreDia As New SqlCommand("SimularGetDiaPractica", con)
                    getNombreDia.CommandType = CommandType.StoredProcedure
                    'para cargar en una tabla auxiliar los profesores que dictan la clase para la catedra+comision seleccionada
                    getNombreDia.Parameters.Add("@materia", SqlDbType.Int)
                    getNombreDia.Parameters.Add("@comision", SqlDbType.Int)
                    getNombreDia.Parameters.Add("@nombreDia", SqlDbType.VarChar, 9)

                    'recorrer la tabla filtrada auxMateriaCom
                    While (cantRegistros > 0)
                        'gestionamos la primera fila de la tabla auxiliar auxMateriaCom
                        materiaActual = getTopIdAuxMateriaCom.ExecuteScalar()
                        comisionActual = getTopComAuxMateriaCom.ExecuteScalar()

                        'vemos si devuelve un diaPractica, sino que recargue el query y devuelva el valor de diaTeoria
                        getNombreDia.Parameters("@materia").Value = materiaActual
                        getNombreDia.Parameters("@comision").Value = comisionActual
                        getNombreDia.Parameters("@nombreDia").Value = nombreDiaActual

                        'dar de alta una planilla
                        insertPlanilla.Parameters("@materia").Value = materiaActual
                        insertPlanilla.Parameters("@comision").Value = comisionActual
                        insertPlanilla.Parameters("@fecha").Value = fechaActual
                        insertPlanilla.Parameters("@estado").Value = "No iniciada"
                        insertPlanilla.Parameters("@aulaPrestada").Value = 0

                        Dim auxDia As String = getNombreDia.ExecuteScalar()
                        If auxDia = nombreDiaActual Then
                            insertPlanilla.Parameters("@tipoClase").Value = "Practica"
                        Else
                            insertPlanilla.Parameters("@tipoClase").Value = "Teoria"
                        End If
                        insertPlanilla.ExecuteNonQuery()

                        'obtener el id del registro anterior insertado en la tabla de Planillas
                        maxIDPlanilla = getMaxIdPlanilla.ExecuteScalar()

                        'cargo en una tabla auxiliar los profesores que dictan la clase para la catedra+comision seleccionada
                        insertProfesAux.Parameters("@materiaAct").Value = materiaActual
                        insertProfesAux.Parameters("@comisionAct").Value = comisionActual
                        insertProfesAux.ExecuteNonQuery()

                        'obtener la cant de registros de la tabla auxProfXMateria
                        cantRegistrosProf = getCantProfesXMat.ExecuteScalar()

                        'recorrer la tabla filtrada auxProfXMateria
                        While (cantRegistrosProf > 0)
                            'gestionamos la primera fila
                            legajoActual = getTopIdAuxProfXMateria.ExecuteScalar()

                            'agregar un profesor que dicta la clase al ListadoProfesoresPlanilla
                            insertProfePlanilla.Parameters("@idPPlanilla").Value = maxIDPlanilla.ToString()
                            insertProfePlanilla.Parameters("@legajo").Value = legajoActual
                            insertProfePlanilla.Parameters("@asistencia").Value = "A"
                            insertProfePlanilla.ExecuteNonQuery()

                            'eliminamos la primera fila ya utilizada de auxProfXMateria
                            borrarTopAuxProfXMateria.ExecuteNonQuery()

                            cantRegistrosProf = cantRegistrosProf - 1
                        End While
                        'eliminamos la primera fila ya utilizada de auxMateriaCom
                        borrarTopAuxMateriaCom.ExecuteNonQuery()

                        cantRegistros = cantRegistros - 1
                    End While
                    MsgBox("Cantidad de planillas generadas: " + cantPlanillas.ToString)
                End If

            Else '##### AVISA QUE NO SE CURSA Y POR QUÉ
                Dim obtenerTipo As New SqlCommand("SimularGetTipoDiaNoCursable", con)
                obtenerTipo.CommandType = CommandType.StoredProcedure
                obtenerTipo.Parameters.Add("@fecha", SqlDbType.Date)
                obtenerTipo.Parameters("@fecha").Value = fechaActual

                Dim obtenerDescripcion As New SqlCommand("SimularGetDescDiaNoCursable", con)
                obtenerDescripcion.CommandType = CommandType.StoredProcedure
                obtenerDescripcion.Parameters.Add("@fecha", SqlDbType.Date)
                obtenerDescripcion.Parameters("@fecha").Value = fechaActual

                Dim tipo As String = obtenerTipo.ExecuteScalar()
                Dim descr As String = ""
                descr = obtenerDescripcion.ExecuteScalar()

                If descr = "" Then
                    MsgBox("No se generan planillas por ser un día no cursable." & vbNewLine & tipo)
                Else
                    MsgBox("No se generan planillas por ser un día no cursable." & vbNewLine & "Tipo: " + tipo + " - " + descr)
                End If
            End If
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ButtonHuellaProfe_Click(sender As Object, e As EventArgs) Handles ButtonHuellaProfe.Click

        Dim materiaAux As String
        Dim comisionAux As String
        Dim añoAux As Integer

        If legajoProfesor.Text <> "" Then
            If IsNumeric(legajoProfesor.Text) = False Then
                MsgBox("El valor del campo Legajo debe ser un número.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Else
            MsgBox("Debe completar el Legajo para poder marcar la asistencia.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If TextBoxHoraFinal.Text = "" Then
            MsgBox("Debe completar un horario para poder marcar la asistencia.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        'PARA ENTRADAS#################################################################
        If ButtonHEntrada.Checked Then
            Try
                con.Open()
                fechaActual = dateProfesor.Value.Date

                Dim obtenerIdProfe As New SqlCommand("SimularGetIdPlanillaProfe", con)
                obtenerIdProfe.CommandType = CommandType.StoredProcedure
                obtenerIdProfe.Parameters.Add("@legajo", SqlDbType.Int).Value = legajoProfesor.Text
                obtenerIdProfe.Parameters.Add("@aula", SqlDbType.SmallInt).Value = aulaProfesor.Text
                obtenerIdProfe.Parameters.Add("@fechaActual", SqlDbType.Date).Value = fechaActual
                obtenerIdProfe.Parameters.Add("@horaActual", SqlDbType.VarChar, 255).Value = TextBoxHoraFinal.Text

                Dim idplanillaObtenida As String = obtenerIdProfe.ExecuteScalar()

                If idplanillaObtenida = "" Then
                    MsgBox("El profesor está intentando marcar asistencia fuera del rango permitido o no está habilitado para dictar la clase.", MsgBoxStyle.Exclamation)
                Else
                    'obtenemos el idMateria
                    Dim getIdMateria As New SqlCommand("SimularGetIdMateria", con)
                    getIdMateria.CommandType = CommandType.StoredProcedure
                    getIdMateria.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = idplanillaObtenida
                    materiaAux = getIdMateria.ExecuteScalar()
                    'obtenemos la comision
                    Dim getComision As New SqlCommand("SimularGetComision", con)
                    getComision.CommandType = CommandType.StoredProcedure
                    getComision.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = idplanillaObtenida
                    comisionAux = getComision.ExecuteScalar().ToString()

                    'obtenemos que tipo de clase es (teoria o practica)
                    Dim getTipoClase As New SqlCommand("SimularGetTipoClasePlanilla", con)
                    getTipoClase.CommandType = CommandType.StoredProcedure
                    getTipoClase.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = idplanillaObtenida
                    tipodeClase = getTipoClase.ExecuteScalar()
                    'obtenemos el cargo de esa materia del profesor que marco
                    Dim getCargoProfesor As New SqlCommand("SimularGetCargoProfesor", con)
                    getCargoProfesor.CommandType = CommandType.StoredProcedure
                    getCargoProfesor.Parameters.Add("@legajo", SqlDbType.Int).Value = legajoProfesor.Text
                    getCargoProfesor.Parameters.Add("@idMateria", SqlDbType.Int).Value = materiaAux
                    getCargoProfesor.Parameters.Add("@comision", SqlDbType.Int).Value = comisionAux
                    cargoProf = getCargoProfesor.ExecuteScalar()

                    'vemos si es el primero que marca, cambiamos el tipo de clase a teoria o practica segun le corresponda a ese profesor
                    Select Case tipodeClase
                        Case "Teoria"
                            If cargoProf <> "Jefe de Cátedra" Then
                                Dim updateTipoClase As New SqlCommand("SimularUpdateTipoClase", con)
                                updateTipoClase.CommandType = CommandType.StoredProcedure
                                updateTipoClase.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = idplanillaObtenida
                                updateTipoClase.Parameters.Add("@tipoClase", SqlDbType.VarChar, 8).Value = "Practica"
                                updateTipoClase.ExecuteNonQuery()
                                MsgBox("Se ha detectado un profesor de otro tipo de clase. Clase cambiada a 'Practica'")
                            End If
                        Case "Practica"
                            If cargoProf = "Jefe de Cátedra" Then
                                Dim updateTipoClase As New SqlCommand("SimularUpdateTipoClase", con)
                                updateTipoClase.CommandType = CommandType.StoredProcedure
                                updateTipoClase.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = idplanillaObtenida
                                updateTipoClase.Parameters.Add("@tipoClase", SqlDbType.VarChar, 8).Value = "Teoria"
                                updateTipoClase.ExecuteNonQuery()
                                MsgBox("Se ha detectado un profesor de otro tipo de clase. Clase cambiada a 'Teoria'")
                                MsgBox("ACA 3", MsgBoxStyle.Information)

                            End If
                    End Select

                    'vemos si el aula es prestada
                    Dim esPrestada As Integer = 0
                    Dim getAulaPrestada As New SqlCommand("SimularGetAulaPrestada", con)
                    getAulaPrestada.CommandType = CommandType.StoredProcedure
                    getAulaPrestada.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = idplanillaObtenida
                    esPrestada = getAulaPrestada.ExecuteScalar()

                    If esPrestada <> 0 Then
                        MsgBox("Se detectó que el Aula es Prestada.", MsgBoxStyle.Information)
                    End If

                    Dim updateEntradaProfe As New SqlCommand("SimularEntradaProfesor", con)
                    updateEntradaProfe.CommandType = CommandType.StoredProcedure
                    updateEntradaProfe.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = idplanillaObtenida
                    updateEntradaProfe.Parameters.Add("@legajo", SqlDbType.Int).Value = legajoProfesor.Text.ToString()
                    updateEntradaProfe.Parameters.Add("@horaInicio", SqlDbType.VarChar, 255).Value = TextBoxHoraFinal.Text
                    updateEntradaProfe.ExecuteNonQuery()
                    MsgBox("Update de Asistencia correcto: Entrada marcada.", MsgBoxStyle.Information)
                    'el anterior además pone la hora de inicio del aula con el primer profesor que llega, sino no entra por el WHERE

                    'Ocupamos el Aula
                    Dim updateAula As New SqlCommand("SimularUpdateAula", con)
                    updateAula.CommandType = CommandType.StoredProcedure
                    If esPrestada <> -1 Then
                        updateAula.Parameters.Add("@aula", SqlDbType.Int).Value = esPrestada
                    Else
                        updateAula.Parameters.Add("@aula", SqlDbType.Int).Value = aulaProfesor.Text
                    End If
                    updateAula.Parameters.Add("@estadoAula", SqlDbType.VarChar, 7).Value = "Ocupada"
                    updateAula.ExecuteNonQuery()
                    MsgBox("Update del aula correcto.", MsgBoxStyle.Information)

                    'Generamos el listado de alumnos
                    'Ponemos el 'A' en la asistencia de listado de los alumnos de esa planilla
                    Dim insertarAlumnosPlanilla As New SqlCommand("SimularInsertAlumnosPlanilla", con)
                    insertarAlumnosPlanilla.CommandType = CommandType.StoredProcedure
                    insertarAlumnosPlanilla.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = idplanillaObtenida
                    insertarAlumnosPlanilla.ExecuteNonQuery()
                    MsgBox("Update de planillas de alumnos correcto.")
                End If
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
        'PARA SALIDAS DE PROFESOR ################################################################################################
        If ButtonHSalida.Checked Then
            Try
                MsgBox("ACA -2", MsgBoxStyle.Information)

                con.Open()
                fechaActual = dateProfesor.Value.Date
                MsgBox("ACA -1", MsgBoxStyle.Information)

                Dim cmdobtenerSalidaplanilla As New SqlCommand
                cmdobtenerSalidaplanilla.Connection = con
                cmdobtenerSalidaplanilla.CommandText = "Select Pl.idPlanilla from ListadoProfesoresPlanilla L INNER JOIN Profesores Prof on L.legajo = Prof.legajo INNER JOIN Planillas Pl on Pl.idPlanilla = L.idplanilla INNER JOIN Materia M on M.idMateria = Pl.idMateria INNER JOIN comisionesXaula A on A.idMateria = M.idMateria AND A.comision = M.comision WHERE (L.legajo = '" + legajoProfesor.Text + "' AND A.aula = " + aulaProfesor.Text + " AND Pl.fecha = '" + fechaActual + "' AND '" + TextBoxHoraFinal.Text + "' BETWEEN (DATEADD(minute,-30,M.horaOficialFinTeoria)) AND DATEADD(minute,15,M.horaOficialFinTeoria)) OR (L.legajo = '" + legajoProfesor.Text + "' AND A.aula = " + aulaProfesor.Text + " AND Pl.fecha = '" + fechaActual + "' AND '" + TextBoxHoraFinal.Text + "' BETWEEN (DATEADD(minute,-30,M.horaOficialFinPractica)) AND DATEADD(minute,15,M.horaOficialFinPractica))"
                Dim idplanillaObtenida As String = cmdobtenerSalidaplanilla.ExecuteScalar().ToString()

                MsgBox("ACA 0", MsgBoxStyle.Information)

                If idplanillaObtenida = "" Then
                    MsgBox("El profesor está intentando marcar asistencia fuera del rango permitido o no está habilitado para dictar la clase.", MsgBoxStyle.Exclamation)
                Else
                    'Si hay planillas...
                    'obtenemos la materia
                    Dim getIdMateria As New SqlCommand("SimularGetIdMateria", con)
                    getIdMateria.CommandType = CommandType.StoredProcedure
                    getIdMateria.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = idplanillaObtenida
                    materiaAux = getIdMateria.ExecuteScalar()

                    MsgBox("ACA 1", MsgBoxStyle.Information)
                    'obtenemos la comision
                    Dim getComision As New SqlCommand("SimularGetComision", con)
                    getComision.CommandType = CommandType.StoredProcedure
                    getComision.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = idplanillaObtenida
                    comisionAux = getComision.ExecuteScalar().ToString()
                    'obetenemos el año - devuelve solo el año de la fecha registrada en la planilla en INTEGER, es el año de la cursada
                    MsgBox("ACA 2", MsgBoxStyle.Information)

                    Dim cmdSelectAñoAux As New SqlCommand
                    cmdSelectAñoAux.Connection = con
                    cmdSelectAñoAux.CommandText = "Select DATEPART(year,fecha) FROM Planillas WHERE idPlanilla =" + idplanillaObtenida
                    añoAux = cmdSelectAñoAux.ExecuteScalar()
                    MsgBox("ACA 3", MsgBoxStyle.Information)

                    'vemos si el aula es prestada
                    Dim esPrestada As Integer = 0
                    Dim getAulaPrestada As New SqlCommand("SimularGetAulaPrestada", con)
                    getAulaPrestada.CommandType = CommandType.StoredProcedure
                    getAulaPrestada.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = idplanillaObtenida
                    esPrestada = getAulaPrestada.ExecuteScalar()
                    MsgBox("ACA 4", MsgBoxStyle.Information)

                    If esPrestada <> 0 Then
                        MsgBox("Se detectó que el Aula es Prestada.", MsgBoxStyle.Information)
                    End If
                    MsgBox("ACA 5", MsgBoxStyle.Information)

                    'Obtenemos si la clase es de teoria o de practica
                    Dim tipodeClase As String
                    Dim getTipoClase As New SqlCommand("SimularGetTipoClasePlanilla", con)
                    getTipoClase.CommandType = CommandType.StoredProcedure
                    getTipoClase.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = idplanillaObtenida
                    tipodeClase = getTipoClase.ExecuteScalar()

                    Dim hsInasistencia As Integer
                    MsgBox("ACA 6", MsgBoxStyle.Information)

                    'este reemplaza la palabra en el query de la columna de la tabla alumnoXmateria para obtener las horas de practica o de teoria segun corresponda
                    Dim auxColumnainasistencia As String = "hsXinasistenciaTeoria"
                    If tipodeClase = "Practica" Then
                        auxColumnainasistencia = "hsXinasistenciaPractica"
                    End If
                    MsgBox("ACA 7", MsgBoxStyle.Information)

                    'obtenemos la cantidad de hs que cuesta una ---INasistencia--- a esa clase, por ende tambien suma hs de ---Asistencia---
                    Dim cmdobtenerHS As New SqlCommand
                    Dim cmdsumarInasistencias As New SqlCommand
                    Dim cmdsumarAsistencias As New SqlCommand
                    cmdobtenerHS.Connection = con
                    cmdsumarInasistencias.Connection = con
                    cmdsumarAsistencias.Connection = con
                    MsgBox("ACA A", MsgBoxStyle.Information)

                    'Usa hsXinasistenciaTeoria/Practica segun corresponda con la variable auxColumnaInasistencia para obetener las horas que representa esa clase
                    cmdobtenerHS.CommandText = "Select " + auxColumnainasistencia + " FROM Materia M INNER JOIN Planillas P on M.idMateria = P.idMateria and M.comision = P.Comisión WHERE idPlanilla =" + idplanillaObtenida
                    hsInasistencia = cmdobtenerHS.ExecuteScalar()
                    MsgBox("ACA B", MsgBoxStyle.Information)

                    'sumamos la cant de hs obtenidas de INasistencias en la tabla alumno x materia segun idMateria, comison y año e cursada que ya obtuvimos anterioremte 
                    cmdsumarInasistencias.CommandText = "UPDATE alumnoXmateria SET inasistencias += " + hsInasistencia.ToString() + " FROM alumnoXmateria axm INNER JOIN ListadoAlumnosPlanilla L on axm.legajo = L.legajo WHERE axm.idMateria = " + materiaAux + " AND axm.comision = " + comisionAux + " AND axm.añoCursada = " + añoAux.ToString() + " AND L.asistencia = 'A'"
                    cmdsumarInasistencias.ExecuteNonQuery()
                    MsgBox("ACA C", MsgBoxStyle.Information)

                    'sumamos las Asistencias del mismo modo, las que son P les suma las horas a la columna asistencias
                    cmdsumarAsistencias.CommandText = "UPDATE alumnoXmateria SET asistencias += " + hsInasistencia.ToString() + " FROM alumnoXmateria axm INNER JOIN ListadoAlumnosPlanilla L on axm.legajo = L.legajo WHERE axm.idMateria = " + materiaAux + " AND axm.comision = " + comisionAux + " AND axm.añoCursada = " + añoAux.ToString() + " AND L.asistencia = 'P'"
                    cmdsumarAsistencias.ExecuteNonQuery()
                    MsgBox("ACA 8", MsgBoxStyle.Information)

                    'ponemos la hora de fin de la clase para el profesor
                    Dim updateSalidaProfe As New SqlCommand("SimularSalidaProfesor", con)
                    updateSalidaProfe.CommandType = CommandType.StoredProcedure
                    updateSalidaProfe.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = idplanillaObtenida
                    updateSalidaProfe.Parameters.Add("@legajo", SqlDbType.Int).Value = legajoProfesor.Text
                    updateSalidaProfe.Parameters.Add("@horaFin", SqlDbType.VarChar, 8).Value = TextBoxHoraFinal.Text
                    updateSalidaProfe.ExecuteNonQuery()
                    MsgBox("Update de Asistencia - Hora de Fin correcto.", MsgBoxStyle.Information)

                    'ponemos hora de fin de la clase con el ultimo profe que salio del aula
                    'MsgBox("Update de planillas - Hora de Finalizacion correcto.")
                    MsgBox("ACA 9", MsgBoxStyle.Information)

                    'ACA CONTAMOS SI NO QUEDARON MAS NULL EN ListadoPlanillaProfesores, si es 0 entonces ya marcaron la salida todos los profesores.
                    Dim cmdcontarnull As New SqlCommand
                    Dim auxNull As Integer
                    cmdcontarnull.Connection = con
                    'buscamos los de la planilla donde tienen la hora de inicio marcada, osea, que hayan ido a dar clase (is not null) y que no tengan marcada la hora de fin (is null)
                    cmdcontarnull.CommandText = "Select COUNT(*) FROM ListadoProfesoresPlanilla WHERE idplanilla = " + idplanillaObtenida + " And horaFin Is null AND horaInicio is not null"
                    auxNull = cmdcontarnull.ExecuteScalar()
                    MsgBox("Ultimo profesor registrando su salida.")

                    'como era el ultimo, ponemos el estado en la planilla
                    If auxNull = 0 Then
                        Dim cmdFinalizarPlanilla As New SqlCommand
                        cmdFinalizarPlanilla.Connection = con
                        cmdFinalizarPlanilla.CommandText = "Update Planillas SET estadoCursada = 'Finalizada' WHERE idPlanilla = " + idplanillaObtenida
                        cmdFinalizarPlanilla.ExecuteNonQuery()
                        MsgBox("Planilla cerrada correctamente.")

                        'Y desocupamos el aula
                        Dim updateAula As New SqlCommand("SimularUpdateAula", con)
                        updateAula.CommandType = CommandType.StoredProcedure
                        If esPrestada <> -1 Then
                            updateAula.Parameters.Add("@aula", SqlDbType.Int).Value = esPrestada
                        Else
                            updateAula.Parameters.Add("@aula", SqlDbType.Int).Value = aulaProfesor.Text
                        End If
                        updateAula.Parameters.Add("@estadoAula", SqlDbType.VarChar, 7).Value = "Libre"
                        updateAula.ExecuteNonQuery()
                        MsgBox("Update de aula desocupada correcto.", MsgBoxStyle.Information)

                        'Le sumamos la cantidad de hs de asistencias o inasitencias segun sea teoria o practica
                    End If
                End If
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If

    End Sub

    Private Sub dateProfesor_ValueChanged(sender As Object, e As EventArgs) Handles dateProfesor.ValueChanged
        If dateProfesor.Value.DayOfWeek = DayOfWeek.Saturday Then
            dateProfesor.Value = dateProfesor.Value.AddDays(-1)
            MsgBox("No se puede seleccionar el día Sábado")
            Exit Sub
        End If
        If dateProfesor.Value.DayOfWeek = DayOfWeek.Sunday Then
            dateProfesor.Value = dateProfesor.Value.AddDays(-2)
            MsgBox("No se puede seleccionar el día Domingo")
            Exit Sub
        End If
    End Sub

    Private Sub dateAlumno_ValueChanged(sender As Object, e As EventArgs) Handles dateAlumno.ValueChanged
        If dateAlumno.Value.DayOfWeek = DayOfWeek.Saturday Then
            dateAlumno.Value = dateAlumno.Value.AddDays(-1)
            MsgBox("No se puede seleccionar el día Sábado")
            Exit Sub
        End If
        If dateAlumno.Value.DayOfWeek = DayOfWeek.Sunday Then
            dateAlumno.Value = dateAlumno.Value.AddDays(-2)
            MsgBox("No se puede seleccionar el día Domingo")
            Exit Sub
        End If
    End Sub
    Private Sub datePlanillas_ValueChanged(sender As Object, e As EventArgs) Handles datePlanillas.ValueChanged
        If datePlanillas.Value.DayOfWeek = DayOfWeek.Saturday Then
            datePlanillas.Value = datePlanillas.Value.AddDays(-1)
            MsgBox("No se puede seleccionar el día Sábado")
            Exit Sub
        End If
        If datePlanillas.Value.DayOfWeek = DayOfWeek.Sunday Then
            datePlanillas.Value = datePlanillas.Value.AddDays(-2)
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

    Private Sub ComboBoxAMPM_SelectedIndexChanged(sender As Object, e As EventArgs)
        TextBoxHoraFinal.Text = (ComboBoxHora.Text + ":" + ComboBoxMin.Text + " ")
    End Sub

    Private Sub ComboBoxHoraA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxHoraA.SelectedIndexChanged
        TextBoxHoraFinalA.Text = (ComboBoxHoraA.Text + ":" + ComboBoxMinA.Text + " ")
    End Sub

    Private Sub ComboBoxMinA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMinA.SelectedIndexChanged
        TextBoxHoraFinalA.Text = (ComboBoxHoraA.Text + ":" + ComboBoxMinA.Text + " ")
    End Sub

    Private Sub ComboBoxAMPMA_SelectedIndexChanged(sender As Object, e As EventArgs)
        TextBoxHoraFinalA.Text = (ComboBoxHoraA.Text + ":" + ComboBoxMinA.Text + " ")
    End Sub

    Private Sub ButtonVerPlanilla_Click(sender As Object, e As EventArgs) Handles ButtonVerTodosPlanilla.Click
        Dim buscarPlanillasFecha As New SqlCommand("SimularBuscarPlanillasFecha", con)
        buscarPlanillasFecha.CommandType = CommandType.StoredProcedure
        buscarPlanillasFecha.Parameters.Add("@fecha", SqlDbType.Date).Value = "13/1/1900"

        Try
            Dim da As New SqlDataAdapter(buscarPlanillasFecha)
            Dim ds As New DataTable
            da.Fill(ds)
            DataGridViewPlanillas.DataSource = ds

            For Each fila As DataGridViewRow In DataGridViewPlanillas.Rows
                If fila.Cells("estadoCursada").Value.ToString() = "En Curso" Then
                    fila.DefaultCellStyle.BackColor = Color.Khaki
                End If
            Next
            If ds.Rows.Count() = 0 Then
                MsgBox("No hay planilllas cargadas.", MsgBoxStyle.Information)
            Else
                ColorearCierreForzados()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ButtonHuellaAlumno_Click(sender As Object, e As EventArgs) Handles ButtonHuellaAlumno.Click
        '##################################
        'Verificaciones antes de actualizar la asistencia
        If legajoAlumno.Text <> "" Then
            If IsNumeric(legajoAlumno.Text) = False Then
                MsgBox("El valor del campo Legajo debe ser un número.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        Else
            MsgBox("Debe completar el Legajo para poder marcar la asistencia.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If TextBoxHoraFinalA.Text = "" Then
            MsgBox("Debe completar un horario para poder marcar la asistencia.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        '####################################################
        Try
            con.Open()

            'Obtenemos el id de planilla al que esta intentando acceder el alumno
            Dim obtenerIdPlanillaA As New SqlCommand("SimularGetIdListadoAlumnosPlanilla", con)
            obtenerIdPlanillaA.CommandType = CommandType.StoredProcedure
            obtenerIdPlanillaA.Parameters.Add("@legajo", SqlDbType.Int).Value = legajoAlumno.Text
            obtenerIdPlanillaA.Parameters.Add("@aula", SqlDbType.SmallInt).Value = aulaAlumno.Text
            obtenerIdPlanillaA.Parameters.Add("@fecha", SqlDbType.Date).Value = dateAlumno.Value.Date
            obtenerIdPlanillaA.Parameters.Add("@horaFinal", SqlDbType.Time, 0).Value = TextBoxHoraFinalA.Text

            Dim idPlanillaObtenida As String = obtenerIdPlanillaA.ExecuteScalar()

            If idPlanillaObtenida = "" Then
                MsgBox("El alumno está intentando marcar asistencia fuera del rango horario permitido o no está habilitado para cursar.", MsgBoxStyle.Exclamation)
            Else
                Dim validarAlumno As New SqlCommand("SimularVerificarAlumnoLibre", con)
                validarAlumno.CommandType = CommandType.StoredProcedure
                validarAlumno.Parameters.Add("@legajo", SqlDbType.Int).Value = legajoAlumno.Text
                validarAlumno.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = idPlanillaObtenida

                Dim estadoDelAlumno As String = validarAlumno.ExecuteScalar()

                If estadoDelAlumno = "Libre" Then
                    MsgBox("El Alumno se encuentra en condición 'LIBRE' para este curso.", MsgBoxStyle.Information)
                    'Seguiremos contando las asistencias por si cambia su situacion academica en una instancia posterior o se encuentra en trámite.
                End If
                'Ponemos el presente en ListadoAlumnosPlanilla

                Dim updateAsistenciaAlumno As New SqlCommand("SimularUpdateAsistenciaAlumno", con)
                updateAsistenciaAlumno.CommandType = CommandType.StoredProcedure
                updateAsistenciaAlumno.Parameters.Add("@legajo", SqlDbType.Int).Value = legajoAlumno.Text
                updateAsistenciaAlumno.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = idPlanillaObtenida

                updateAsistenciaAlumno.ExecuteNonQuery()
                MsgBox("Asistencia del Alumno marcada correctamente.", MsgBoxStyle.Information)
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonBuscarFecha.Click
        Dim buscarPlanillasFecha As New SqlCommand("SimularBuscarPlanillasFecha", con)
        buscarPlanillasFecha.CommandType = CommandType.StoredProcedure
        buscarPlanillasFecha.Parameters.Add("@fecha", SqlDbType.Date).Value = dateBuscarPlanillas.Value.Date

        Try
            Dim da As New SqlDataAdapter(buscarPlanillasFecha)
            Dim ds As New DataTable
            da.Fill(ds)
            DataGridViewPlanillas.DataSource = ds

            For Each fila As DataGridViewRow In DataGridViewPlanillas.Rows
                If fila.Cells("estadoCursada").Value = "En Curso" Then
                    fila.DefaultCellStyle.BackColor = Color.Khaki
                End If
            Next
            If ds.Rows.Count() = 0 Then
                MsgBox("No hay planilllas generadas para la fecha seleccionada.", MsgBoxStyle.Information)
            Else
                ColorearCierreForzados()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonSimularCierre.Click
        Dim auxPlanilla As String
        Dim auxMateria As Integer
        Dim auxComision As Integer
        Dim auxAula As Integer = -1
        Dim auxhoraFin As String
        Dim toleranciaFin As String
        Dim tipoClase As String

        Try
            con.Open()
            'Obtenemos la tolerancia permitida de cada clase despues de suhora de cierre oficial.
            Dim getDespuesSalida As New SqlCommand("GetDespuesSTolerancia", con)
            getDespuesSalida.CommandType = CommandType.StoredProcedure
            toleranciaFin = getDespuesSalida.ExecuteScalar()

            'Obtenemos las planillas en curso y las analizamos todas con el reader
            Dim getPlanillasEnCurso As New SqlCommand("SimularGetPlanillasEnCurso", con)
            getPlanillasEnCurso.CommandType = CommandType.StoredProcedure
            getPlanillasEnCurso.Parameters.Add("@fecha", SqlDbType.Date).Value = dateCierreCursada.Value.Date

            Dim dt As New DataTable
            dt.Load(getPlanillasEnCurso.ExecuteReader)
            For Each Fila As DataRow In dt.Rows
                auxPlanilla = Fila.Item(0)
                MsgBox("Aca llegamo 4: " + auxPlanilla + ".", MsgBoxStyle.Information)

                'Obtenemos el tipo de clase en curso
                Dim getTipoClase As New SqlCommand("SimularGetTipoClasePlanilla", con)
                getTipoClase.CommandType = CommandType.StoredProcedure
                getTipoClase.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = auxPlanilla

                tipoClase = getTipoClase.ExecuteScalar()
                MsgBox("Aca llegamo 5:" + tipoClase + ".", MsgBoxStyle.Information)

                'Segun el tipo de clase obtenemos su hora de Fin y le agreamos la tolerancia guardando en auxhoraFin
                Dim getHoraFinClase As New SqlCommand("SimularGetHoraFinClase", con)
                getHoraFinClase.CommandType = CommandType.StoredProcedure
                getHoraFinClase.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = auxPlanilla
                getHoraFinClase.Parameters.Add("@tipoClase", SqlDbType.VarChar, 8).Value = tipoClase

                auxhoraFin = getHoraFinClase.ExecuteScalar().ToString()

                MsgBox("Aca llegamo 6 hora de fin : " + auxhoraFin + " antes del if.", MsgBoxStyle.Information)

                'Si la hora oficial de fin de la materia MAS su tolerancia son menores que la hora actual (simulada)... La materia sigue cerrada despues de su hora de tolerancia...
                If auxhoraFin < TextBoxhoraFinalCierre.Text Then
                    MsgBox("Aca llegamo 7 Entramos al IF", MsgBoxStyle.Information)

                    'La pasamos a estado Cierre Forzado y le ponemos la hora actual a la que corrio el servicio
                    Dim forzarCierrePlanillas As New SqlCommand("SimularForzarCierrePlanillas", con)
                    forzarCierrePlanillas.CommandType = CommandType.StoredProcedure
                    forzarCierrePlanillas.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = auxPlanilla
                    forzarCierrePlanillas.Parameters.Add("@horaFinal", SqlDbType.Time, 0).Value = TextBoxhoraFinalCierre.Text
                    forzarCierrePlanillas.ExecuteNonQuery()
                    MsgBox("Aca llegamo 8 primer update", MsgBoxStyle.Information)

                    'Obtenemos el id del Aula prestada si es que hay
                    Dim getAulaPrestada As New SqlCommand("SimularGetAulaPrestada", con)
                    getAulaPrestada.CommandType = CommandType.StoredProcedure
                    getAulaPrestada.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = auxPlanilla
                    auxAula = getAulaPrestada.ExecuteScalar()
                    MsgBox("Aca llegamo 9 aula prestada: " + auxAula.ToString(), MsgBoxStyle.Information)

                    'Obtenemos su materia
                    Dim getIdMateria As New SqlCommand("SimularGetIdMateria", con)
                    getIdMateria.CommandType = CommandType.StoredProcedure
                    getIdMateria.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = auxPlanilla
                    auxMateria = getIdMateria.ExecuteScalar()
                    MsgBox("Aca llegamo 10 materia: " + auxMateria.ToString(), MsgBoxStyle.Information)

                    'Obtenemos la comision
                    Dim getComision As New SqlCommand("SimularGetComision", con)
                    getComision.CommandType = CommandType.StoredProcedure
                    getComision.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = auxPlanilla
                    auxComision = getComision.ExecuteScalar()
                    MsgBox("Aca llegamo 11 comision: " + auxComision.ToString(), MsgBoxStyle.Information)

                    'Ponemos la hora de fin actual en el Listado de Profesores a cada profesor QUE ASISTIO - is not null
                    Dim updateProfesoresForzado As New SqlCommand("SimularMarcarSalidaForzadaProfes", con)
                    updateProfesoresForzado.CommandType = CommandType.StoredProcedure
                    updateProfesoresForzado.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = auxPlanilla
                    updateProfesoresForzado.Parameters.Add("@horaFinal", SqlDbType.VarChar, 8).Value = TextBoxhoraFinalCierre.Text

                    updateProfesoresForzado.ExecuteNonQuery()
                    MsgBox("Asistencia del Profesor actualizada en Planilla.", MsgBoxStyle.Information)
                    'Desocupamos el aula mirando si se usaba una Prestada o la normal (si no es prestada auxAula devuelve vacio, y se usa la normal).

                    Dim devolverAula As New SqlCommand("SimularLiberarAulaUsada", con)
                    devolverAula.CommandType = CommandType.StoredProcedure
                    devolverAula.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = auxPlanilla
                    devolverAula.Parameters.Add("@auxAula", SqlDbType.SmallInt).Value = auxAula
                    devolverAula.Parameters.Add("@materia", SqlDbType.VarChar, 255).Value = auxMateria
                    devolverAula.Parameters.Add("@comision", SqlDbType.SmallInt).Value = auxComision
                    devolverAula.ExecuteNonQuery()

                    If auxAula = -1 Or auxAula = 0 Then
                        MsgBox("Aula de cursada normal desocupada correctamente.", MsgBoxStyle.Information)
                    Else
                        MsgBox("Aula de cursada PRESTADA desocupada correctamente", MsgBoxStyle.Information)
                    End If
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        MsgBox("Fin de verificación de aulas no Cerradas.", MsgBoxStyle.Information)

        con.Close()
        con.Open()
        'Recargamos el Datagrid
        Dim buscarPlanillasFecha As New SqlCommand("SimularBuscarPlanillasFecha", con)
        buscarPlanillasFecha.CommandType = CommandType.StoredProcedure
        buscarPlanillasFecha.Parameters.Add("@fecha", SqlDbType.Date).Value = dateBuscarPlanillas.Value.Date
        Try
            Dim da As New SqlDataAdapter(buscarPlanillasFecha)
            Dim ds As New DataTable
            da.Fill(ds)
            DataGridViewPlanillas.DataSource = ds

            For Each fila As DataGridViewRow In DataGridViewPlanillas.Rows
                If fila.Cells("estadoCursada").Value = "En Curso" Then
                    fila.DefaultCellStyle.BackColor = Color.Khaki
                End If
            Next

            'Coloreamos los cierres detectados en el datagrid
            ColorearCierreForzados()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        con.Close()
    End Sub

    Private Sub ComboBoxhoraSimCierre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxhoraSimCierre.SelectedIndexChanged
        TextBoxhoraFinalCierre.Text = (ComboBoxhoraSimCierre.Text + ":" + ComboBoxminutosSimCierre.Text + " ")
    End Sub

    Private Sub ComboBoxminutosSimCierre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxminutosSimCierre.SelectedIndexChanged
        TextBoxhoraFinalCierre.Text = (ComboBoxhoraSimCierre.Text + ":" + ComboBoxminutosSimCierre.Text + " ")
    End Sub
End Class