Imports System.Data.SqlClient
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Imports System.Drawing.Image

Public Class VerMasAlumno
    Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)

    Public Shared idAlumno As String = Alumnos.idASeleccionado
    Public Shared nomAlumno As String
    Public Shared apAlumno As String
    Public Shared dniAlumno As String
    Public Shared materiaSeleccionada As String
    Public Shared comisionMateriaSeleccionada As String
    Public Shared añoCursadaMateriaSeleccionada As String
    Public Shared estadoCursadaSeleccionada As String
    Public Shared carreraSeleccionada As String
    Public Shared imagenA As Image

    Public Sub BotonesDelParent()
        'BOTONES DEL PARENT
        Interfaz.botonVolver.Enabled = True
        Interfaz.botonImprimir.Visible = False
        Interfaz.botonPDF.Visible = True
    End Sub

    Public Sub ColorearLibres()
        'COLOREA LAS FILAS DE LOS QUE ESTAN LIBRES
        For Each fila As DataGridViewRow In DataGridViewDatosMaterias.Rows
            If fila.Cells(3).Value = "Libre" Then
                fila.DefaultCellStyle.BackColor = Color.Khaki
            End If
        Next
    End Sub

    '##### CARGA EL DATAGRID DE MATERIAS
    Public Sub LoadDataGrid()
        Dim dt As New DataTable

        Dim cargarMaterias As New SqlCommand("GetMateriasAlumno", con)
        cargarMaterias.CommandType = CommandType.StoredProcedure
        cargarMaterias.Parameters.Add("@legajo", SqlDbType.Int).Value = idAlumno
        cargarMaterias.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxCarreraAlumno.Text

        If RadioButtonAñoCursada.Checked Then
            If ComboBoxAñoCursada.Text = "" Then
                cargarMaterias.Parameters.Add("@añoCursada", SqlDbType.SmallInt).Value = 0
            Else
                cargarMaterias.Parameters.Add("@añoCursada", SqlDbType.SmallInt).Value = ComboBoxAñoCursada.Text
            End If
            cargarMaterias.Parameters.Add("@materia", SqlDbType.VarChar, 255).Value = ""
        Else
            cargarMaterias.Parameters.Add("@añoCursada", SqlDbType.SmallInt).Value = 0
            If ComboBoxMaterias.Text = "" Then
                cargarMaterias.Parameters.Add("@materia", SqlDbType.VarChar, 255).Value = ""
            Else
                cargarMaterias.Parameters.Add("@materia", SqlDbType.VarChar, 255).Value = ComboBoxMaterias.Text
            End If
        End If

        Try
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(cargarMaterias)
            adapter.Fill(dt)

            DataGridViewDatosMaterias.DataSource = dt
            DataGridViewDatosMaterias.Columns(1).HeaderText = "Materia"
            'ajusto SOLO el ancho de esta columna segun el contenido
            DataGridViewDatosMaterias.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewDatosMaterias.Columns(2).HeaderText = "Comisión"
            DataGridViewDatosMaterias.Columns(3).HeaderText = "Estado de Cursada"
            DataGridViewDatosMaterias.Columns(4).HeaderText = "Reincorporado"
            DataGridViewDatosMaterias.Columns(5).HeaderText = "Año de Cursada"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

        If dt.Rows.Count = 0 Then
            LabelInscripto.Visible = True
        Else
            LabelInscripto.Visible = False
            ColorearLibres()
        End If
    End Sub

    Private Sub CargarCarrerasAlumno()
        'carga las carreras que cursa el alumno
        ComboBoxCarreraAlumno.Items.Clear()

        Dim cargarCarreras As New SqlCommand("GetCarrerasAlumno", con)
        cargarCarreras.CommandType = CommandType.StoredProcedure
        cargarCarreras.Parameters.Add("@legajo", SqlDbType.Int).Value = idAlumno
        Try
            con.Open()
            Dim dt As New DataTable
            dt.Load(cargarCarreras.ExecuteReader)
            For Each Fila As DataRow In dt.Rows
                ComboBoxCarreraAlumno.Items.Add(Fila.Item(0))
            Next
            con.Close()
            If ComboBoxCarreraAlumno.Items.Count > 0 Then
                ComboBoxCarreraAlumno.SelectedIndex() = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ComboBoxCarreraAlumno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCarreraAlumno.SelectedIndexChanged
        carreraSeleccionada = ComboBoxCarreraAlumno.Text

        ComboBoxAñoCursada.Items.Clear()
        ComboBoxMaterias.Items.Clear()

        Dim cargarAñosCursada As New SqlCommand("GetAñosCursadaAlumno", con)
        cargarAñosCursada.CommandType = CommandType.StoredProcedure
        cargarAñosCursada.Parameters.Add("@legajo", SqlDbType.Int).Value = idAlumno
        cargarAñosCursada.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxCarreraAlumno.Text

        Dim cargarMateriasCursadas As New SqlCommand("GetMateriasCursadasAlumno", con)
        cargarMateriasCursadas.CommandType = CommandType.StoredProcedure
        cargarMateriasCursadas.Parameters.Add("@legajo", SqlDbType.Int).Value = idAlumno
        cargarMateriasCursadas.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxCarreraAlumno.Text

        Dim obtenerEstadoCarrera As New SqlCommand("GetEstadoCarreraAlumno", con)
        obtenerEstadoCarrera.CommandType = CommandType.StoredProcedure
        obtenerEstadoCarrera.Parameters.Add("@legajo", SqlDbType.Int).Value = idAlumno
        obtenerEstadoCarrera.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxCarreraAlumno.Text

        Try
            con.Open()
            Dim dt1 As New DataTable
            dt1.Load(cargarAñosCursada.ExecuteReader)
            For Each Fila As DataRow In dt1.Rows
                ComboBoxAñoCursada.Items.Add(Fila.Item(0))
            Next

            Dim dt2 As New DataTable
            dt2.Load(cargarMateriasCursadas.ExecuteReader)
            For Each Fila As DataRow In dt2.Rows
                ComboBoxMaterias.Items.Add(Fila.Item(0))
            Next

            EstadoRegularidad.Text = obtenerEstadoCarrera.ExecuteScalar()
            con.Close()

            If ComboBoxAñoCursada.Items.Count > 0 Then
                ComboBoxAñoCursada.SelectedIndex() = 0
            End If
            If ComboBoxMaterias.Items.Count > 0 Then
                ComboBoxMaterias.SelectedIndex() = 0
            End If

            LoadDataGrid()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub CargarDatosPersona()
        'cargar los datos del alumno
        Dim obtenerDatosA As New SqlCommand("GetDatosAlumno", con)
        obtenerDatosA.CommandType = CommandType.StoredProcedure
        obtenerDatosA.Parameters.Add("@legajo", SqlDbType.Int).Value = idAlumno
        Try
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(obtenerDatosA)
            Dim dt As New DataTable
            adapter.Fill(dt)

            con.Open()
            For Each Fila As DataRow In dt.Rows
                TextBoxNomAlumno.Text = Fila.Item(0).ToString()
                TextBoxApAlumno.Text = Fila.Item(1).ToString()
                TextBoxDNIAlumno.Text = Fila.Item(2).ToString()

                If Fila.Item(5).ToString() = "1" Then
                    EstadoRegularidad.Text = "Si"
                Else
                    EstadoRegularidad.Text = "No"
                End If

                If Not IsDBNull(Fila.Item(6)) Then
                    Dim imagen() As Byte = Fila.Item(6)
                    If imagen IsNot Nothing Then
                        Dim ms As MemoryStream = New MemoryStream(imagen)
                        PictureAlumno.Image = FromStream(ms)
                    End If
                End If
            Next
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub CargarHuellasPersona()
        'cargar las huellas del alumno
        Dim obtenerHuellas As New SqlCommand("GetDatosHuellas", con)
        obtenerHuellas.CommandType = CommandType.StoredProcedure
        obtenerHuellas.Parameters.Add("@legajo", SqlDbType.Int).Value = idAlumno
        obtenerHuellas.Parameters.Add("@tipoPersona", SqlDbType.VarChar, 8).Value = "Alumno"

        Try
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(obtenerHuellas)
            Dim dt As New DataTable
            adapter.Fill(dt)

            con.Open()
            For Each Fila As DataRow In dt.Rows
                LabelMano1.Text = "Mano: " + Fila.Item(0).ToString()
                LabelDedoMano1.Text = "Dedo: " + Fila.Item(1).ToString()
                LabelMano2.Text = "Mano: " + Fila.Item(2).ToString()
                LabelDedoMano2.Text = "Dedo: " + Fila.Item(3).ToString()
            Next
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub VerMasAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Interfaz.LabelTipoUsuarioActual.Text = "Bedel" Or Interfaz.LabelTipoUsuarioActual.Text = "Administrador" Then
            ButtonModificarHuellas.Visible = True
            ButtonReincorporar.Visible = True
        End If
        TextBoxLegajoAlumno.Text = idAlumno

        BotonesDelParent()
        CargarDatosPersona()
        CargarCarrerasAlumno()
        CargarHuellasPersona()
        LoadDataGrid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonVerPlanilla.Click
        If TextBoxSelectedMateria.Text = "" Then
            MsgBox("Para ver el detalle de las asistencias, debe seleccionar una materia de la grilla, haciendo click en el boton Elegir a la izquierda de la materia deseada.", MsgBoxStyle.Exclamation)
        Else
            Dim frm As AsistenciasAlumno = New AsistenciasAlumno()
            frm.MdiParent = Interfaz
            frm.Dock = DockStyle.Fill
            frm.Show()
            frm.ColorearFaltas()
        End If
    End Sub

    Private Sub ButtonModificarHuellas_Click(sender As Object, e As EventArgs) Handles ButtonModificarHuellas.Click
        Dim frm As ModificarPersona = New ModificarPersona()
        frm.MdiParent = Interfaz
        frm.Show()
    End Sub

    '##### GUARDA EL ID DE LA MATERIA SELECCIONADA CON EL BOTON ELEGIR
    Private Sub DataGridViewDatosMaterias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewDatosMaterias.CellContentClick
        'obtengo fila+columna para saber si se hizo click sobre el botón y no otra celda del datagrid
        Dim columna As Integer = e.ColumnIndex
        Dim fila As Integer = e.RowIndex

        If columna = 0 Then
            If fila > -1 Then
                TextBoxSelectedMateria.Text = DataGridViewDatosMaterias.CurrentRow.Cells(1).Value
                TextBoxEstadoCursada.Text = DataGridViewDatosMaterias.CurrentRow.Cells(3).Value
                materiaSeleccionada = DataGridViewDatosMaterias.CurrentRow.Cells(1).Value
                comisionMateriaSeleccionada = DataGridViewDatosMaterias.CurrentRow.Cells(2).Value
                estadoCursadaSeleccionada = DataGridViewDatosMaterias.CurrentRow.Cells(3).Value
                añoCursadaMateriaSeleccionada = DataGridViewDatosMaterias.CurrentRow.Cells(5).Value
            End If
        End If
        If Interfaz.LabelTipoUsuarioActual.Text = "Bedel" Or Interfaz.LabelTipoUsuarioActual.Text = "Administrador" Then
            If TextBoxEstadoCursada.Text = "Libre" Then
                ButtonReincorporar.Enabled = True
            Else
                ButtonReincorporar.Enabled = False
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonReincorporar.Click
        'pasamos el estado a regular, las inasistencias a 0 y el reincorporado en 'si'
        Dim reincorporarAlumnoAMateria As New SqlCommand("ReincorporarAlumno", con)
        reincorporarAlumnoAMateria.CommandType = CommandType.StoredProcedure
        reincorporarAlumnoAMateria.Parameters.Add("@legajo", SqlDbType.Int).Value = idAlumno
        reincorporarAlumnoAMateria.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxCarreraAlumno.Text
        reincorporarAlumnoAMateria.Parameters.Add("@materia", SqlDbType.VarChar, 255).Value = materiaSeleccionada
        reincorporarAlumnoAMateria.Parameters.Add("@comision", SqlDbType.SmallInt).Value = DataGridViewDatosMaterias.CurrentRow.Cells(2).Value
        reincorporarAlumnoAMateria.Parameters.Add("@añoCursada", SqlDbType.Int).Value = DataGridViewDatosMaterias.CurrentRow.Cells(5).Value
        Try
            con.Open()
            reincorporarAlumnoAMateria.ExecuteNonQuery()
            con.Close()

            TextBoxEstadoCursada.Text = "Regular"
            ButtonReincorporar.Enabled = False
            LoadDataGrid()
            MsgBox("El estado de la cursada ha sido actualizado exitosamente.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ButtonVerTodos_Click(sender As Object, e As EventArgs) Handles ButtonVerTodos.Click
        Dim cargarMaterias As New SqlCommand("GetMateriasAlumno", con)
        cargarMaterias.CommandType = CommandType.StoredProcedure
        cargarMaterias.Parameters.Add("@legajo", SqlDbType.Int).Value = idAlumno
        cargarMaterias.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxCarreraAlumno.Text
        cargarMaterias.Parameters.Add("@añoCursada", SqlDbType.SmallInt).Value = 0
        cargarMaterias.Parameters.Add("@materia", SqlDbType.VarChar, 255).Value = ""

        Dim adapter As SqlDataAdapter = New SqlDataAdapter(cargarMaterias)
        Dim dt As New DataTable
        adapter.Fill(dt)

        DataGridViewDatosMaterias.DataSource = dt
    End Sub

    Private Sub RadioButtonAñoCursada_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonAñoCursada.CheckedChanged
        If RadioButtonAñoCursada.Checked = True Then
            ComboBoxAñoCursada.Enabled = True
            ComboBoxMaterias.Enabled = False
        Else
            ComboBoxAñoCursada.Enabled = False
            ComboBoxMaterias.Enabled = True
        End If
    End Sub

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        LoadDataGrid()
    End Sub

    Public Sub GenerarPDF()
        Dim parrafo As New Paragraph 'nuevo parrafo
        Dim parrafo2 As New Paragraph 'nuevo parrafo
        Dim parrafo3 As New Paragraph 'nuevo parrafo

        Dim pdffile As New Document(PageSize.A4, 40, 40, 40, 20) 'tamaño de la hoja y margenes del pdf
        'pdffile.AddTitle(TextBoxNombreArchivo.Text) 'titulo del pdf
        pdffile.AddHeader("SiABi", "Reporte de Materia del Alumno")
        pdffile.AddCreationDate()

        Dim write As PdfWriter = PdfWriter.GetInstance(pdffile, New FileStream(Interfaz.direccionPDF, FileMode.Create))
        pdffile.Open()

        'fuentes que va a tener
        Dim fuenteTitulo As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLDITALIC, BaseColor.BLACK)
        Dim fuentedatos As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
        Dim fuenteTabla As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
        Dim fuenteColumnaTabla As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        'Dim fuentevariable As Font

        'insercion del encabezado en el pdf
        parrafo = New Paragraph(New Chunk("Reporte de Materias del Alumno - SiABi", fuenteTitulo)) 'titulo con el nombre del archivo
        parrafo.Alignment = Element.ALIGN_CENTER 'alineado al centro
        parrafo.SpacingAfter = 30.0F

        'agrego el encabezado en el pdf
        pdffile.Add(parrafo)

        'insercion de datos en el pdf
        parrafo2 = New Paragraph(New Chunk("Alumno: " + TextBoxApAlumno.Text + ", " + TextBoxNomAlumno.Text + " - DNI: " + TextBoxDNIAlumno.Text + " - Legajo: " + TextBoxLegajoAlumno.Text, fuentedatos)) 'titulo con el nombre del archivo
        parrafo2.Alignment = Element.ALIGN_CENTER 'alineado al centro
        parrafo2.SpacingAfter = 30.0F

        'agrego datos en el pdf
        pdffile.Add(parrafo2)

        'insercion de carrera en el pdf
        parrafo3 = New Paragraph(New Chunk("Carrera: " + ComboBoxCarreraAlumno.Text + " - Año de Cursda: " + ComboBoxAñoCursada.Text + " - Regularidad en la Carrera: " + EstadoRegularidad.Text, fuentedatos)) 'titulo con el nombre del archivo
        parrafo3.Alignment = Element.ALIGN_CENTER 'alineado al centro
        parrafo3.SpacingAfter = 30.0F

        'agrego carrera en el pdf
        pdffile.Add(parrafo3)


        'insercion del titulo en el pdf
        parrafo = New Paragraph(New Chunk(DataGridViewDatosMaterias.Text, fuenteTitulo)) 'titulo con el nombre del archivo
        parrafo.Alignment = Element.ALIGN_CENTER 'alineado al centro
        parrafo.SpacingAfter = 30.0F

        'agrego el titulo en el pdf
        pdffile.Add(parrafo)

        'pasamos el datagrid a una tabla
        Dim pdftable As New PdfPTable(DataGridViewDatosMaterias.Columns.Count - 1)
        pdftable.TotalWidth = 500.0F
        pdftable.LockedWidth = True
        Dim ancho(0 To DataGridViewDatosMaterias.Columns.Count - 2) As Single
        For i As Integer = 0 To DataGridViewDatosMaterias.Columns.Count - 2
            ancho(i) = 1.0F
        Next

        'tamaño de columnas
        pdftable.SetWidths(ancho)
        pdftable.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        pdftable.SpacingBefore = 5.0F

        'tamaño de celdas
        Dim pdfcelda As PdfPCell = New PdfPCell
        Dim pdfceldaB As PdfPCell = New PdfPCell

        'header del pdf
        For i As Integer = 1 To DataGridViewDatosMaterias.Columns.Count - 1
            pdfcelda = New PdfPCell(New Phrase(New Chunk(DataGridViewDatosMaterias.Columns(i).HeaderText, fuenteColumnaTabla)))
            pdfcelda.HorizontalAlignment = PdfPCell.ALIGN_CENTER 'alineado de los encabezados
            'añadimos las celdas en la pdftable
            pdftable.AddCell(pdfcelda)
        Next

        'añadir datos a la tabla
        For i As Integer = 0 To DataGridViewDatosMaterias.Rows.Count - 1 'aca son las rows no las columns
            For j As Integer = 1 To DataGridViewDatosMaterias.Columns.Count - 1
                pdfceldaB = New PdfPCell(New Phrase(DataGridViewDatosMaterias(j, i).Value.ToString(), fuenteTabla))
                pdftable.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                pdfceldaB.HorizontalAlignment = PdfPCell.ALIGN_CENTER 'alineado del resto de la tabla
                pdftable.AddCell(pdfceldaB)
            Next
        Next

        'añadir la tabla al pdf
        pdffile.Add(pdftable)
        pdffile.Close()

        'si llego hasta aca se exporto correctamente y mostramos mensaje...
        MsgBox("PDF generado exitosamente!!!", MsgBoxStyle.Information)

        'abre el pdf en lo que sea que el usuario tiene para ver pdf por defecto
        Process.Start(Interfaz.direccionPDF)
    End Sub
End Class