Imports System.Data.SqlClient
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO

Public Class AsistenciasProfesor
    Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)
    Dim idProfesor As String = Profesores.idPSeleccionado
    Dim idPlanilla As String = ""
    Dim tipoClase As String = ""

    Public Sub ColorearFaltas()
        'COLOREA LAS FILAS DE LOS QUE ESTAN LIBRES CUAK
        For Each fila As DataGridViewRow In DataGridViewProfesor.Rows
            If fila.Cells("Asistencia").Value = "A" Then
                fila.DefaultCellStyle.BackColor = Color.Khaki
            End If
        Next
    End Sub

    Private Sub LoadDataGrid()
        Dim cargarAsistencias As New SqlCommand("GetAsistenciasProfesor", con)
        cargarAsistencias.CommandType = CommandType.StoredProcedure
        cargarAsistencias.Parameters.Add("@legajo", SqlDbType.Int).Value = idProfesor
        cargarAsistencias.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = TextBoxCarrera.Text
        cargarAsistencias.Parameters.Add("@materia", SqlDbType.VarChar, 255).Value = TextBoxMateria.Text
        cargarAsistencias.Parameters.Add("@comision", SqlDbType.SmallInt).Value = TextBoxComision.Text
        cargarAsistencias.Parameters.Add("@cargo", SqlDbType.VarChar, 100).Value = TextBoxCargo.Text

        Try
            Dim adapterP As SqlDataAdapter = New SqlDataAdapter(cargarAsistencias)
            Dim dt As New DataTable
            adapterP.Fill(dt)

            DataGridViewProfesor.DataSource = dt
            DataGridViewProfesor.Columns(1).HeaderText = "idPlanilla"
            DataGridViewProfesor.Columns(1).Visible = False
            DataGridViewProfesor.Columns(2).HeaderText = "Fecha"
            DataGridViewProfesor.Columns(3).HeaderText = "Comentario Clase"
            DataGridViewProfesor.Columns(4).HeaderText = "Asistencia"
            DataGridViewProfesor.Columns(5).HeaderText = "Comentario"
            DataGridViewProfesor.Columns(6).HeaderText = "Hora Entrada"
            DataGridViewProfesor.Columns(7).HeaderText = "Hora Salida"

            If dt.Rows.Count > 0 Then
                ColorearFaltas()
                LabelHistorial.Visible = False
            Else
                LabelHistorial.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub GuardarCambiosAsistencia()
        Dim actualizarAsistencia As New SqlCommand("UpdateAsistenciaProfesor", con)
        actualizarAsistencia.CommandType = CommandType.StoredProcedure
        actualizarAsistencia.Parameters.Add("@legajo", SqlDbType.Int).Value = idProfesor
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
        LoadDataGrid()
    End Sub

    Private Sub AsistenciasProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BOTONES DEL PARENT
        Interfaz.botonVolver.Enabled = True
        Interfaz.botonImprimir.Visible = False
        Interfaz.botonPDF.Visible = True

        If Interfaz.LabelTipoUsuarioActual.Text = "Jefe de Cátedra" Or Interfaz.LabelTipoUsuarioActual.Text = "Jefe de Departamento" Then
            ButtonModifAsistencia.Visible = False
        End If

        TextBoxCarrera.Text = VerMasProfesor.carreraSeleccionada
        TextBoxMateria.Text = VerMasProfesor.materiaSeleccionada
        TextBoxComision.Text = VerMasProfesor.comisionSeleccionada
        TextBoxCargo.Text = VerMasProfesor.cargoSeleccionado
        TextBoxDiaPractica.Text = VerMasProfesor.diaPractica
        TextBoxDiaTeoria.Text = VerMasProfesor.diaTeoria
        TextBoxSuplente.Text = VerMasProfesor.suplente

        'cargar los datos de la materia
        Dim obtenerHorarios As New SqlCommand("GetHorariosClase", con)
        obtenerHorarios.CommandType = CommandType.StoredProcedure
        obtenerHorarios.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = TextBoxCarrera.Text
        obtenerHorarios.Parameters.Add("@materia", SqlDbType.VarChar, 255).Value = TextBoxMateria.Text
        obtenerHorarios.Parameters.Add("@comision", SqlDbType.SmallInt).Value = TextBoxComision.Text
        Try
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(obtenerHorarios)
            Dim dt As New DataTable
            adapter.Fill(dt)

            con.Open()
            For Each Fila As DataRow In dt.Rows
                inicioPractica.Text = Fila.Item(0).ToString()
                finPractica.Text = Fila.Item(1).ToString()
                inicioTeoria.Text = Fila.Item(2).ToString()
                finTeoria.Text = Fila.Item(3).ToString()
            Next
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

        LoadDataGrid()
    End Sub

    Private Sub DataGridViewAlumnos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewProfesor.CellContentClick
        'obtengo fila+columna para saber si se hizo click sobre el botón y no otra celda del datagrid
        Dim columna As Integer = e.ColumnIndex
        Dim fila As Integer = e.RowIndex

        If columna = 0 Then
            If fila > -1 Then
                idPlanilla = DataGridViewProfesor.CurrentRow.Cells("idPlanilla").Value

                Dim frm As ModificarAsistenciaProfe = New ModificarAsistenciaProfe()
                frm.TextBoxFechaCursada.Text = DataGridViewProfesor.CurrentRow.Cells("Fecha").Value

                If DataGridViewProfesor.CurrentRow.Cells(3).Value.ToString() = "T" Then
                    tipoClase = "T"
                    frm.TextBoxClaseDictada.Text = "Teoría"
                ElseIf DataGridViewProfesor.CurrentRow.Cells(3).Value.ToString() = "P" Then
                    tipoClase = "T"
                    frm.TextBoxClaseDictada.Text = "Práctica"
                Else
                    tipoClase = ""
                    frm.TextBoxClaseDictada.Text = ""
                End If

                Interfaz.asistencia = DataGridViewProfesor.CurrentRow.Cells("Asistencia").Value

                If Interfaz.asistencia = "P" Then
                    frm.ComboBoxAsistencia.Text = "Presente"
                    ModificarAsistencia.asistenciaModif = "P"
                Else
                    frm.ComboBoxAsistencia.Text = "Ausente"
                    ModificarAsistencia.asistenciaModif = "A"
                End If
                frm.TextBoxComentarios.Text = DataGridViewProfesor.CurrentRow.Cells("Comentario").Value.ToString
                frm.ShowDialog()
            End If
        End If
    End Sub

    '##### GENERAR PDF
    Public Sub GenerarPDF()
        Dim parrafo As New Paragraph 'nuevo parrafo
        Dim parrafo2 As New Paragraph 'nuevo parrafo

        Dim pdffile As New Document(PageSize.A4, 40, 40, 40, 20) 'tamaño de la hoja y margenes del pdf

        pdffile.AddHeader("SiABi", "Reporte de Asistencias del Profesor")
        pdffile.AddCreationDate()

        Dim write As PdfWriter = PdfWriter.GetInstance(pdffile, New FileStream(Interfaz.direccionPDF, FileMode.Create))
        pdffile.Open()

        'fuentes que va a tener
        Dim fuenteTitulo As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLDITALIC, BaseColor.BLACK)
        Dim fuenteTabla As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
        Dim fuenteColumnaTabla As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        'Dim fuentevariable As Font

        'insercion del encabezado en el pdf
        parrafo = New Paragraph(New Chunk("Reporte de Asistencias del Profesor - SiABi", fuenteTitulo)) 'titulo con el nombre del archivo
        parrafo.Alignment = Element.ALIGN_CENTER 'alineado al centro
        parrafo.SpacingAfter = 30.0F

        'agrego el encabezado en el pdf
        pdffile.Add(parrafo)

        'insercion de descripción en el pdf
        parrafo2 = New Paragraph(New Chunk("Materia: " + TextBoxMateria.Text + "  -  Comisión: " + TextBoxComision.Text + "  -  Cargo: " + TextBoxCargo.Text + " - Carrera: " + TextBoxCarrera.Text, fuenteTitulo)) 'titulo con el nombre del archivo
        parrafo2.Alignment = Element.ALIGN_CENTER 'alineado al centro
        parrafo2.SpacingAfter = 30.0F

        'agrego la descripcion en el pdf
        pdffile.Add(parrafo2)

        'insercion del titulo en el pdf
        parrafo = New Paragraph(New Chunk(DataGridViewProfesor.Text, fuenteTitulo)) 'titulo con el nombre del archivo
        parrafo.Alignment = Element.ALIGN_CENTER 'alineado al centro
        parrafo.SpacingAfter = 30.0F

        'agrego el titulo en el pdf
        pdffile.Add(parrafo)

        'pasamos el datagrid a una tabla
        Dim pdftable As New PdfPTable(DataGridViewProfesor.Columns.Count - 1)
        pdftable.TotalWidth = 500.0F
        pdftable.LockedWidth = True
        Dim ancho(0 To DataGridViewProfesor.Columns.Count - 2) As Single
        For i As Integer = 0 To DataGridViewProfesor.Columns.Count - 2
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
        For i As Integer = 1 To DataGridViewProfesor.Columns.Count - 1
            pdfcelda = New PdfPCell(New Phrase(New Chunk(DataGridViewProfesor.Columns(i).HeaderText, fuenteColumnaTabla)))
            pdfcelda.HorizontalAlignment = PdfPCell.ALIGN_CENTER 'alineado de los encabezados
            'añadimos las celdas en la pdftable
            pdftable.AddCell(pdfcelda)
        Next

        'añadir datos a la tabla
        For i As Integer = 1 To DataGridViewProfesor.Rows.Count - 1 'aca son las rows no las columns
            For j As Integer = 2 To DataGridViewProfesor.Columns.Count - 1
                pdfceldaB = New PdfPCell(New Phrase(DataGridViewProfesor(j, i).Value.ToString(), fuenteTabla))
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