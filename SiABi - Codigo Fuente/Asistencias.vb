Imports System.Data.SqlClient
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Imports System.Text

Public Class Asistencias
    Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)

    Private Sub IniciarCriterios()
        ComboBoxTipoPersona.SelectedIndex = 0
        CheckBoxCarrera.CheckState = CheckState.Unchecked
        CheckBoxCatedra.CheckState = CheckState.Unchecked
        CheckBoxComision.CheckState = CheckState.Unchecked
        CheckBoxFecha.CheckState = CheckState.Unchecked

        If Interfaz.LabelTipoUsuarioActual.Text = "Jefe de Departamento" Then
            CheckBoxCarrera.Enabled = False
            ComboBoxCarrera.Enabled = False
            ComboBoxCarrera.Text = Interfaz.LabelCatDpto.Text
            Exit Sub
        End If

        If Interfaz.LabelTipoUsuarioActual.Text = "Jefe de Cátedra" Then
            CheckBoxCarrera.Checked = False
            CheckBoxCarrera.Enabled = False
            ComboBoxCarrera.Enabled = False
            ComboBoxCarrera.Text = Interfaz.LabelCarreraDeCat.Text
            CheckBoxCatedra.Checked = False
            CheckBoxCatedra.Enabled = False
            ComboBoxCatedra.Enabled = False
            ComboBoxCatedra.Text = Interfaz.LabelCatDpto.Text
            Exit Sub
        End If

        ComboBoxCarrera.Enabled = True
        ComboBoxCarrera.SelectedIndex = 0
        ComboBoxCatedra.Enabled = True
        If ComboBoxCatedra.Items.Count() > 0 Then
            ComboBoxCatedra.SelectedIndex = 0
        End If
    End Sub
    Private Sub Asistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BOTONES DEL PARENT
        Interfaz.botonVolver.Enabled = False
        Interfaz.botonImprimir.Visible = False
        Interfaz.botonPDF.Visible = True

        'si el dia actual es sabado o domingo se para sobre la fecha del lunes siguiente
        Dim diaActual As DateTime = DateTime.Now
        If diaActual.DayOfWeek = 6 Then
            DateAsistencias.Value = diaActual.AddDays(2)
        End If
        If diaActual.DayOfWeek = 7 Then
            DateAsistencias.Value = diaActual.AddDays(1)
        End If

        IniciarCriterios()
    End Sub

    Private Sub ColorearLibres()
        'COLOREA LAS FILAS DE LOS QUE ESTAN LIBRES
        For Each fila As DataGridViewRow In DataGridViewAsistencias.Rows
            If fila.Cells(12).Value = "Libre" Then
                fila.DefaultCellStyle.BackColor = Color.Orange
            End If
        Next
    End Sub

    Private Sub ColorearFaltas()
        'COLOREA LAS FILAS DE LOS QUE ESTAN LIBRES CUAK
        For Each fila As DataGridViewRow In DataGridViewAsistencias.Rows
            If fila.Cells("Asistencia").Value = "A" Then
                fila.DefaultCellStyle.BackColor = Color.Khaki
            End If
        Next
    End Sub

    Public Sub GenerarPDF()
        Dim parrafo As New Paragraph 'nuevo parrafo
        Dim parrafo2 As New Paragraph 'nuevo parrafo
        Dim parrafo3 As New Paragraph 'nuevo parrafo

        Dim pdffile As New Document(PageSize.A4, 8, 8, 40, 20) 'tamaño de la hoja y margenes del pdf
        pdffile.AddHeader("SiABi", "Reporte de Asistencias")
        pdffile.AddCreationDate()

        Dim write As PdfWriter = PdfWriter.GetInstance(pdffile, New FileStream(Interfaz.direccionPDF, FileMode.Create))
        pdffile.Open()

        'fuentes que va a tener
        Dim fuenteTitulo As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLDITALIC, BaseColor.BLACK)
        Dim fuentedatos As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
        Dim fuenteTabla As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 7, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
        Dim fuenteColumnaTabla As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 7, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        'Dim fuentevariable As Font

        'insercion del encabezado en el pdf
        parrafo = New Paragraph(New Chunk("Reporte de Asistencias - SiABi", fuenteTitulo)) 'titulo con el nombre del archivo
        parrafo.Alignment = Element.ALIGN_CENTER 'alineado al centro
        parrafo.SpacingAfter = 30.0F

        'agrego el encabezado en el pdf
        pdffile.Add(parrafo)

        'insercion del titulo en el pdf
        parrafo = New Paragraph(New Chunk(DataGridViewAsistencias.Text, fuenteTitulo)) 'titulo con el nombre del archivo
        parrafo.Alignment = Element.ALIGN_CENTER 'alineado al centro
        parrafo.SpacingAfter = 30.0F

        'agrego el titulo en el pdf
        pdffile.Add(parrafo)

        'pasamos el datagrid a una tabla
        Dim pdftable As New PdfPTable(DataGridViewAsistencias.Columns.Count - 1)
        pdftable.TotalWidth = 500.0F
        pdftable.LockedWidth = True
        Dim ancho(0 To DataGridViewAsistencias.Columns.Count - 2) As Single
        For i As Integer = 0 To DataGridViewAsistencias.Columns.Count - 2
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
        For i As Integer = 1 To DataGridViewAsistencias.Columns.Count - 1
            pdfcelda = New PdfPCell(New Phrase(New Chunk(DataGridViewAsistencias.Columns(i).HeaderText, fuenteColumnaTabla)))
            pdfcelda.HorizontalAlignment = PdfPCell.ALIGN_CENTER 'alineado de los encabezados
            'añadimos las celdas en la pdftable
            pdftable.AddCell(pdfcelda)
        Next

        'añadir datos a la tabla
        For i As Integer = 0 To DataGridViewAsistencias.Rows.Count - 1 'aca son las rows no las columns
            For j As Integer = 1 To DataGridViewAsistencias.Columns.Count - 1
                pdfceldaB = New PdfPCell(New Phrase(DataGridViewAsistencias(j, i).Value.ToString(), fuenteTabla))
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

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Dim obtenerAsistencias As New SqlCommand("GetAsistenciasTest", con)
        obtenerAsistencias.CommandType = CommandType.StoredProcedure
        obtenerAsistencias.Parameters.Add("@tipoPersona", SqlDbType.VarChar, 10).Value = ComboBoxTipoPersona.Text

        If CheckBoxCarrera.Checked Then
            obtenerAsistencias.Parameters.Add("@carrera", SqlDbType.VarChar, 100).Value = ""
        Else
            obtenerAsistencias.Parameters.Add("@carrera", SqlDbType.VarChar, 100).Value = " AND M.carrera = '" + ComboBoxCarrera.Text + "'"
        End If
        If CheckBoxCatedra.Checked Then
            obtenerAsistencias.Parameters.Add("@materia", SqlDbType.VarChar, 100).Value = ""
            obtenerAsistencias.Parameters.Add("@comision", SqlDbType.VarChar, 100).Value = ""
        Else
            obtenerAsistencias.Parameters.Add("@materia", SqlDbType.VarChar, 100).Value = " AND M.nombre = '" + ComboBoxCatedra.Text + "'"
            If CheckBoxComision.Checked Then
                obtenerAsistencias.Parameters.Add("@comision", SqlDbType.VarChar, 100).Value = ""
            Else
                obtenerAsistencias.Parameters.Add("@comision", SqlDbType.VarChar, 100).Value = " AND M.comision = '" + ComboBoxComision.Text + "'"
            End If
        End If
        If CheckBoxFecha.Checked Then
            obtenerAsistencias.Parameters.Add("@fecha", SqlDbType.VarChar, 100).Value = ""
        Else
            obtenerAsistencias.Parameters.Add("@fecha", SqlDbType.VarChar, 100).Value = " AND P.fecha = '" + DateAsistencias.Value.Date + "'"
        End If

        Try
            Dim da As New SqlDataAdapter(obtenerAsistencias)
            Dim ds As New DataTable
            da.Fill(ds)
            DataGridViewAsistencias.DataSource = ds

            DataGridViewAsistencias.Columns("idplanilla").Visible = False
            DataGridViewAsistencias.Columns("catedra").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            If ComboBoxTipoPersona.Text = "Profesores" Then
                    DataGridViewAsistencias.Columns("cargo").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                ColorearFaltas()
                DataGridViewAsistencias.Columns("fecha").HeaderText = "Fecha"
                    DataGridViewAsistencias.Columns("legajo").HeaderText = "Legajo"
                    DataGridViewAsistencias.Columns("nombre").HeaderText = "Nombre"
                    DataGridViewAsistencias.Columns("apellido").HeaderText = "Apellido"
                    DataGridViewAsistencias.Columns("carrera").HeaderText = "Carrera"
                    DataGridViewAsistencias.Columns("catedra").HeaderText = "Materia"
                    DataGridViewAsistencias.Columns("comision").HeaderText = "Comisión" '-->8
                    DataGridViewAsistencias.Columns("cargo").HeaderText = "Cargo"
                    DataGridViewAsistencias.Columns("asistencia").HeaderText = "Asistencia"

                    DataGridViewAsistencias.Columns("horaOficialInicioTeoria").HeaderText = "Inicio Oficial"
                    DataGridViewAsistencias.Columns("horaOficialFinTeoria").HeaderText = "Fin Oficial"

                    DataGridViewAsistencias.Columns("horaInicioReal").HeaderText = "Inicio Real"
                    DataGridViewAsistencias.Columns("horaFinReal").HeaderText = "Fin Real"
                Else
                    DataGridViewAsistencias.Columns("reincorporado").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    ColorearLibres()
                    ColorearFaltas()

                    DataGridViewAsistencias.Columns("fecha").HeaderText = "Fecha"
                    DataGridViewAsistencias.Columns("tipoClase").HeaderText = "Tipo Clase"
                    DataGridViewAsistencias.Columns("legajo").HeaderText = "Legajo"
                    DataGridViewAsistencias.Columns("nombre").HeaderText = "Nombre"
                    DataGridViewAsistencias.Columns("apellido").HeaderText = "Apellido"
                    DataGridViewAsistencias.Columns("carrera").HeaderText = "Carrera"
                    DataGridViewAsistencias.Columns("catedra").HeaderText = "Materia"
                    DataGridViewAsistencias.Columns("comision").HeaderText = "Comisión"
                    DataGridViewAsistencias.Columns("asistencia").HeaderText = "Asistencia"
                    DataGridViewAsistencias.Columns("faltasPermitidas").HeaderText = "Faltas Permitidas"
                    DataGridViewAsistencias.Columns("inasistencias").HeaderText = "Faltas Alumno"
                    DataGridViewAsistencias.Columns("estadoCursada").HeaderText = "Estado Cursada"
                    DataGridViewAsistencias.Columns("reincorporado").HeaderText = "Reincorporado"
                End If

            If ds.Rows.Count() = 0 Then
                MsgBox("No se encontraron resultados para la combinación seleccionada.", MsgBoxStyle.Information)
            End If

            'ColorearFaltas()
            'If ComboBoxTipoPersona.Text = "Alumnos" Then
            '    ColorearLibres()
            'End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ButtonresetParametros_Click(sender As Object, e As EventArgs) Handles ButtonResetParametros.Click
        IniciarCriterios()
    End Sub

    Private Sub DataGridViewAsistencias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAsistencias.CellContentClick
        'obtengo fila+columna para saber si se hizo click sobre el botón y no otra celda del datagrid
        Dim columna As Integer = e.ColumnIndex
        Dim fila As Integer = e.RowIndex

        If columna = 0 Then
            If fila > -1 Then
                Dim comentarioTraido As String

                If DataGridViewAsistencias.CurrentRow.Cells("Asistencia").Value = "A" Then

                    Dim obtenerComentario As New SqlCommand("GetComentarioAsistencia", con)
                    obtenerComentario.CommandType = CommandType.StoredProcedure
                    obtenerComentario.Parameters.Add("@tipoPersona", SqlDbType.VarChar, 10).Value = ComboBoxTipoPersona.Text
                    obtenerComentario.Parameters.Add("@idPlanilla", SqlDbType.Int).Value = DataGridViewAsistencias.CurrentRow.Cells("idplanilla").Value
                    obtenerComentario.Parameters.Add("@legajo", SqlDbType.Int).Value = DataGridViewAsistencias.CurrentRow.Cells("Legajo").Value

                    Try
                        con.Open()
                        comentarioTraido = obtenerComentario.ExecuteScalar().ToString()
                        con.Close()

                        If comentarioTraido = "" Then
                            MsgBox("No hay comentarios sobre la inasistencia seleccionada.", MsgBoxStyle.Information)
                        Else
                            MsgBox("Información acerca de la Inasistencia: " + comentarioTraido + ".", MsgBoxStyle.Information)
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                    End Try
                Else
                    MsgBox("Descripción disponible solo en Inasistencias.", MsgBoxStyle.Exclamation)
                End If
            End If
        End If
    End Sub

    Private Sub DataGridViewAsistencias_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewAsistencias.ColumnHeaderMouseClick
        ColorearFaltas()

        If ComboBoxTipoPersona.Text = "Alumnos" Then
            ColorearLibres()

        End If
    End Sub

    Private Sub CheckBoxfecha_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxFecha.CheckedChanged
        If CheckBoxFecha.Checked Then
            DateAsistencias.Enabled = False
        Else
            DateAsistencias.Enabled = True
        End If
    End Sub

    Private Sub CheckBoxcomision_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxComision.CheckedChanged
        If CheckBoxComision.Checked Then
            ComboBoxComision.Enabled = False
        Else
            ComboBoxComision.Enabled = True
        End If
    End Sub

    Private Sub CheckBoxCarrera_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCarrera.CheckedChanged
        If CheckBoxCarrera.Checked Then
            ComboBoxCarrera.Enabled = False
        Else
            ComboBoxCarrera.Enabled = True
        End If
    End Sub

    Private Sub CheckBoxCatedra_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCatedra.CheckedChanged
        If CheckBoxCatedra.Checked Then
            ComboBoxCatedra.Enabled = False
            CheckBoxComision.Enabled = False
            ComboBoxComision.Enabled = False
        Else
            ComboBoxCatedra.Enabled = True
            CheckBoxComision.Enabled = True
            ComboBoxComision.Enabled = True
        End If
    End Sub

    Private Sub ComboBoxCarrera_SelectedIndexChanged(sender As Object, e As EventArgs)
        ComboBoxCatedra.Items.Clear()
        Dim cargarMaterias As New SqlCommand("GetMateriasPorCarrera", con)
        cargarMaterias.CommandType = CommandType.StoredProcedure
        cargarMaterias.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxCarrera.Text

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

    Private Sub ComboBoxCatedra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCatedra.SelectedIndexChanged
        ComboBoxComision.Items.Clear()

        Dim cargarComisiones As New SqlCommand("GetComisionesPorMateriaYCarrera", con)
        cargarComisiones.CommandType = CommandType.StoredProcedure
        cargarComisiones.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxCarrera.Text
        cargarComisiones.Parameters.Add("@materia", SqlDbType.VarChar, 255).Value = ComboBoxCatedra.Text

        Try
            con.Open()
            Dim strComision As String = ""
            Dim dt As New DataTable
            dt.Load(cargarComisiones.ExecuteReader)
            con.Close()
            For Each Fila As DataRow In dt.Rows
                strComision = Fila.Item(0).ToString()
                ComboBoxComision.Items.Add(strComision)
            Next
            ComboBoxComision.SelectedIndex() = 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub DateAsistencias_ValueChanged(sender As Object, e As EventArgs) Handles DateAsistencias.ValueChanged
        If DateAsistencias.Value.DayOfWeek = DayOfWeek.Saturday Then
            DateAsistencias.Value = DateAsistencias.Value.AddDays(2)
            MsgBox("No se puede buscar por el día Sábado")
            Exit Sub
        End If
        If DateAsistencias.Value.DayOfWeek = DayOfWeek.Sunday Then
            DateAsistencias.Value = DateAsistencias.Value.AddDays(1)
            MsgBox("No se puede buscar por el día Domingo")
            Exit Sub
        End If
    End Sub

    Private Sub ComboBoxCarrera_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBoxCarrera.SelectedIndexChanged
        ComboBoxCatedra.Items.Clear()
        Dim cargarMaterias As New SqlCommand("GetMateriasPorCarrera", con)
        cargarMaterias.CommandType = CommandType.StoredProcedure
        cargarMaterias.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxCarrera.Text

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
End Class