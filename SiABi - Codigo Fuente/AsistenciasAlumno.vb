Imports System.Data.SqlClient
Imports itextsharp.text.pdf
Imports itextsharp.text
Imports System.IO

Public Class AsistenciasAlumno
    Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)

    Dim idAlumno As String = Alumnos.idASeleccionado
    Dim idPlanilla As String = ""
    Dim tipoClase As String = ""

    Dim inasistenciasPermitidas As Integer
    Dim horasFaltaTeoria As Integer
    Dim horasFaltaPractica As Integer
    Dim inasistenciasAlumno As Integer
    Dim restaTotales As Integer

    Public Sub ColorearFaltas()
        'COLOREA LAS FILAS DE LOS QUE ESTAN LIBRES CUAK
        For Each fila As DataGridViewRow In DataGridAsistenciasAlumno.Rows
            If fila.Cells("Asistencia").Value = "A" Then
                fila.DefaultCellStyle.BackColor = Color.Khaki
            End If
        Next
    End Sub

    'CARGA DEL DATAGRID
    Private Sub LoadDataGrid()
        Dim cargarAsistencias As New SqlCommand("GetAsistenciasAlumno", con)
        cargarAsistencias.CommandType = CommandType.StoredProcedure
        cargarAsistencias.Parameters.Add("@legajo", SqlDbType.Int).Value = idAlumno.ToString()
        cargarAsistencias.Parameters.Add("@materia", SqlDbType.VarChar, 255).Value = TextBoxMateriaA.Text
        cargarAsistencias.Parameters.Add("@comision", SqlDbType.SmallInt).Value = TextBoxComisionA.Text
        cargarAsistencias.Parameters.Add("@añoCursada", SqlDbType.SmallInt).Value = TextBoxAñoCursada.Text

        Try
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(cargarAsistencias)
            Dim dt As New DataTable
            adapter.Fill(dt)

            DataGridAsistenciasAlumno.DataSource = dt

            DataGridAsistenciasAlumno.Columns(1).HeaderText = "idPlanilla"
            DataGridAsistenciasAlumno.Columns(1).Visible = False
            DataGridAsistenciasAlumno.Columns(2).HeaderText = "Fecha"
            DataGridAsistenciasAlumno.Columns(3).HeaderText = "Clase Dictada"
            DataGridAsistenciasAlumno.Columns(4).HeaderText = "Asistencia"
            DataGridAsistenciasAlumno.Columns(5).HeaderText = "Comentario"

            If dt.Rows.Count = 0 Then
                LabelHistorial.Visible = True
            Else
                LabelHistorial.Visible = False
                ColorearFaltas()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub AsistenciasAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BOTONES DEL PARENT
        Interfaz.botonVolver.Enabled = True
        Interfaz.botonImprimir.Visible = False
        Interfaz.botonPDF.Visible = True

        '##### CARGAR INFORMACION DE LA MATERIA SELECCIONADA EN VER-MAS-ALUMNO
        TextBoxCarreraA.Text = VerMasAlumno.carreraSeleccionada
        TextBoxMateriaA.Text = VerMasAlumno.materiaSeleccionada
        TextBoxComisionA.Text = VerMasAlumno.comisionMateriaSeleccionada
        TextBoxEstadoCursada.Text = VerMasAlumno.estadoCursadaSeleccionada
        TextBoxAñoCursada.Text = VerMasAlumno.añoCursadaMateriaSeleccionada

        If Interfaz.LabelTipoUsuarioActual.Text = "Jefe de Cátedra" Or Interfaz.LabelTipoUsuarioActual.Text = "Jefe de Departamento" Then
            ButtonEditarAsistencias.Visible = False
        End If

        Dim datosAlumnoPorMateria As New SqlCommand("GetInformacionInasistencias", con)
        datosAlumnoPorMateria.CommandType = CommandType.StoredProcedure
        datosAlumnoPorMateria.Parameters.Add("@legajo", SqlDbType.Int).Value = idAlumno.ToString()
        datosAlumnoPorMateria.Parameters.Add("@materia", SqlDbType.VarChar, 255).Value = TextBoxMateriaA.Text
        datosAlumnoPorMateria.Parameters.Add("@comision", SqlDbType.SmallInt).Value = TextBoxComisionA.Text
        datosAlumnoPorMateria.Parameters.Add("@añoCursada", SqlDbType.SmallInt).Value = TextBoxAñoCursada.Text

        Try
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(datosAlumnoPorMateria)
            Dim dt As New DataTable
            adapter.Fill(dt)

            con.Open()
            For Each Fila As DataRow In dt.Rows
                TextBoxInasistenciasAlumno.Text = Fila.Item(0).ToString()
                TextBoxInasistenciasPermitidas.Text = Fila.Item(1).ToString()
                TextBoxHsFaltasPractica.Text = Fila.Item(2).ToString()
                TextBoxHsFaltasTeoria.Text = Fila.Item(3).ToString()
            Next
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

        LoadDataGrid()
    End Sub

    Public Sub GuardarCambiosAsistencia()
        Dim actualizarAsistencia As New SqlCommand("UpdateAsistenciaAlumno", con)
        actualizarAsistencia.CommandType = CommandType.StoredProcedure
        actualizarAsistencia.Parameters.Add("@legajo", SqlDbType.Int).Value = idAlumno
        actualizarAsistencia.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = idPlanilla
        actualizarAsistencia.Parameters.Add("@estadoAsistencia", SqlDbType.VarChar, 1).Value = Interfaz.asistencia
        actualizarAsistencia.Parameters.Add("@coment", SqlDbType.VarChar, 255).Value = Interfaz.comentarios

        Try
            con.Open()
            actualizarAsistencia.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        horasFaltaTeoria = Convert.ToInt16(TextBoxHsFaltasTeoria.Text)
            horasFaltaPractica = Convert.ToInt16(TextBoxHsFaltasPractica.Text)
            inasistenciasPermitidas = Convert.ToInt16(TextBoxInasistenciasPermitidas.Text)
            inasistenciasAlumno = Convert.ToInt16(TextBoxInasistenciasAlumno.Text)

            If Interfaz.asistencia = "A" Then
                'si está ausente sumo horas
                If tipoClase = "P" Then
                    restaTotales = inasistenciasAlumno + horasFaltaPractica
                Else
                    restaTotales = inasistenciasAlumno + horasFaltaTeoria
                End If
            Else
                If tipoClase = "P" Then
                    restaTotales = inasistenciasAlumno - horasFaltaPractica
                Else
                    restaTotales = inasistenciasAlumno - horasFaltaTeoria
                End If
            End If
            TextBoxInasistenciasAlumno.Text = restaTotales

            If restaTotales <= inasistenciasPermitidas Then
                TextBoxEstadoCursada.Text = "Regular"
            Else
                TextBoxEstadoCursada.Text = "Libre"
                MsgBox("El alumno ha quedado libre", MsgBoxStyle.Information)
            End If

            Dim actualizarHoras As New SqlCommand("UpdateHorasAsistenciaAlumno", con)
            actualizarHoras.CommandType = CommandType.StoredProcedure
            actualizarHoras.Parameters.Add("@legajo", SqlDbType.Int).Value = idAlumno
            actualizarHoras.Parameters.Add("@cursada", SqlDbType.VarChar, 7).Value = TextBoxEstadoCursada.Text
            actualizarHoras.Parameters.Add("@faltasTotales", SqlDbType.SmallInt).Value = restaTotales
            actualizarHoras.Parameters.Add("@comision", SqlDbType.SmallInt).Value = TextBoxComisionA.Text
            actualizarHoras.Parameters.Add("@materia", SqlDbType.VarChar, 255).Value = TextBoxMateriaA.Text

        Try
            con.Open()
            actualizarHoras.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        LoadDataGrid()
    End Sub

    Private Sub DataGridAsistenciasAlumno_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridAsistenciasAlumno.CellContentClick
        'obtengo fila+columna para saber si se hizo click sobre el botón y no otra celda del datagrid
        Dim columna As Integer = e.ColumnIndex
        Dim fila As Integer = e.RowIndex

        If columna = 0 Then
            If fila > -1 Then
                idPlanilla = DataGridAsistenciasAlumno.CurrentRow.Cells("idPlanilla").Value

                Dim frm As ModificarAsistencia = New ModificarAsistencia()
                frm.TextBoxFechaCursada.Text = DataGridAsistenciasAlumno.CurrentRow.Cells("Fecha").Value

                If DataGridAsistenciasAlumno.CurrentRow.Cells(3).Value.ToString() = "T" Then
                    tipoClase = "T"
                    frm.TextBoxClaseDictada.Text = "Teoría"
                ElseIf DataGridAsistenciasAlumno.CurrentRow.Cells(3).Value.ToString() = "P" Then
                    tipoClase = "T"
                    frm.TextBoxClaseDictada.Text = "Práctica"
                Else
                    tipoClase = ""
                    frm.TextBoxClaseDictada.Text = ""
                End If

                Interfaz.asistencia = DataGridAsistenciasAlumno.CurrentRow.Cells("Asistencia").Value

                If Interfaz.asistencia = "P" Then
                    frm.ComboBoxAsistencia.Text = "Presente"
                    ModificarAsistencia.asistenciaModif = "P"
                Else
                    frm.ComboBoxAsistencia.Text = "Ausente"
                    ModificarAsistencia.asistenciaModif = "A"
                End If
                frm.TextBoxComentarios.Text = DataGridAsistenciasAlumno.CurrentRow.Cells("Comentario").Value.ToString
                frm.ShowDialog()
            End If
        End If
    End Sub

    '##### GENERAR PDF
    Public Sub GenerarPDF()
        Dim parrafo As New Paragraph 'nuevo parrafo
        Dim parrafo2 As New Paragraph 'nuevo parrafo

        Dim pdffile As New Document(PageSize.A4, 40, 40, 40, 20) 'tamaño de la hoja y margenes del pdf
        pdffile.AddHeader(TextBoxMateriaA.Text, " " + TextBoxComisionA.Text) 'titulo del pdf
        pdffile.AddHeader("SiABi", "Reporte de Asistencias del Alumno por Materia")
        pdffile.AddCreationDate()

        Dim write As PdfWriter = PdfWriter.GetInstance(pdffile, New FileStream(Interfaz.direccionPDF, FileMode.Create))
        pdffile.Open()

        'fuentes que va a tener
        Dim fuenteTitulo As New Font(itextsharp.text.Font.FontFamily.HELVETICA, 14, itextsharp.text.Font.BOLDITALIC, BaseColor.BLACK)
        Dim fuenteTabla As New Font(itextsharp.text.Font.FontFamily.HELVETICA, 12, itextsharp.text.Font.NORMAL, BaseColor.BLACK)
        Dim fuenteColumnaTabla As New Font(itextsharp.text.Font.FontFamily.HELVETICA, 13, itextsharp.text.Font.BOLD, BaseColor.BLACK)
        'Dim fuentevariable As Font

        'insercion del encabezado en el pdf
        parrafo = New Paragraph(New Chunk("Reporte de Asistencias del Alumno - SiABi", fuenteTitulo)) 'titulo con el nombre del archivo
        parrafo.Alignment = Element.ALIGN_CENTER 'alineado al centro
        parrafo.SpacingAfter = 30.0F

        'agrego el encabezado en el pdf
        pdffile.Add(parrafo)

        'insercion de descripción en el pdf
        parrafo2 = New Paragraph(New Chunk(TextBoxMateriaA.Text + "  -  Comisión: " + TextBoxComisionA.Text + "  -  Legajo: " + idAlumno, fuenteTitulo)) 'titulo con el nombre del archivo
        parrafo2.Alignment = Element.ALIGN_CENTER 'alineado al centro
        parrafo2.SpacingAfter = 30.0F

        'agrego la descripcion en el pdf
        pdffile.Add(parrafo2)

        'insercion del titulo en el pdf
        parrafo = New Paragraph(New Chunk(DataGridAsistenciasAlumno.Text, fuenteTitulo)) 'titulo con el nombre del archivo
        parrafo.Alignment = Element.ALIGN_CENTER 'alineado al centro
        parrafo.SpacingAfter = 30.0F

        'agrego el titulo en el pdf
        pdffile.Add(parrafo)

        'pasamos el datagrid a una tabla
        Dim pdftable As New PdfPTable(DataGridAsistenciasAlumno.Columns.Count - 1)
        pdftable.TotalWidth = 500.0F
        pdftable.LockedWidth = True
        Dim ancho(0 To DataGridAsistenciasAlumno.Columns.Count - 2) As Single
        For i As Integer = 0 To DataGridAsistenciasAlumno.Columns.Count - 2
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
        For i As Integer = 1 To DataGridAsistenciasAlumno.Columns.Count - 1
            pdfcelda = New PdfPCell(New Phrase(New Chunk(DataGridAsistenciasAlumno.Columns(i).HeaderText, fuenteColumnaTabla)))
            pdfcelda.HorizontalAlignment = PdfPCell.ALIGN_CENTER 'alineado de los encabezados
            'añadimos las celdas en la pdftable
            pdftable.AddCell(pdfcelda)
        Next

        'añadir datos a la tabla
        For i As Integer = 1 To DataGridAsistenciasAlumno.Rows.Count - 1 'aca son las rows no las columns
            For j As Integer = 1 To DataGridAsistenciasAlumno.Columns.Count - 1
                pdfceldaB = New PdfPCell(New Phrase(DataGridAsistenciasAlumno(j, i).Value.ToString(), fuenteTabla))
                pdftable.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                pdfceldaB.HorizontalAlignment = PdfPCell.ALIGN_CENTER 'alineado del resto de la tabla
                pdftable.AddCell(pdfceldaB)
            Next
        Next

        'añadir la tabla al pdf
        pdffile.Add(pdftable)
        pdffile.Close()

        'si llego hasta aca se exporto correctamente y mostramos mensaje...
        MsgBox("PDF generado exitosamente!!!", MessageBoxButtons.OK, MsgBoxStyle.Information)

        'abre el pdf en lo que sea que el usuario tiene para ver pdf por defecto
        Process.Start(Interfaz.direccionPDF)
    End Sub
End Class