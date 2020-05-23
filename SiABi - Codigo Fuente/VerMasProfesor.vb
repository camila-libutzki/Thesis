Imports System.Data.SqlClient
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Imports System.Drawing.Image


Public Class VerMasProfesor
    Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)
    Dim idProfesor As String = Profesores.idPSeleccionado
    Public Shared materiaSeleccionada As String
    Public Shared comisionSeleccionada As String
    Public Shared cargoSeleccionado As String
    Public Shared carreraSeleccionada As String
    Public Shared suplente As String
    Public Shared diaPractica As String
    Public Shared diaTeoria As String

    Public Sub BotonesDelParent()
        'BOTONES DEL PARENT
        Interfaz.botonVolver.Enabled = True
        Interfaz.botonImprimir.Visible = False
        Interfaz.botonPDF.Visible = False
    End Sub

    '##### CARGA EL DATAGRID DE MATERIAS
    Public Sub LoadDataGrid()
        Dim cargarMaterias As New SqlCommand("GetMateriasProfesor", con)
        cargarMaterias.CommandType = CommandType.StoredProcedure
        cargarMaterias.Parameters.Add("@legajo", SqlDbType.Int).Value = idProfesor
        cargarMaterias.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxCarreraProf.Text

        Try
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(cargarMaterias)
            Dim dt As New DataTable
            adapter.Fill(dt)

            DataGridViewdatosProfe.DataSource = dt
            DataGridViewdatosProfe.Columns(1).HeaderText = "Materia"
            'ajusto SOLO el ancho de esta columna segun el contenido
            DataGridViewdatosProfe.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewdatosProfe.Columns(2).HeaderText = "Comisión"
            DataGridViewdatosProfe.Columns(3).HeaderText = "Cargo"
            DataGridViewdatosProfe.Columns(4).HeaderText = "Suplente"
            DataGridViewdatosProfe.Columns(5).HeaderText = "Día Práctica"
            DataGridViewdatosProfe.Columns(6).HeaderText = "Día Teoría"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    '##### GENERAR PDF
    Public Sub GenerarPDF()
        Dim parrafo As New Paragraph 'nuevo parrafo
        Dim parrafo2 As New Paragraph 'nuevo parrafo

        Dim pdffile As New Document(PageSize.A4, 40, 40, 40, 20) 'tamaño de la hoja y margenes del pdf
        pdffile.AddHeader("SiABi", "Reporte de Profesor")
        pdffile.AddCreationDate()

        Dim write As PdfWriter = PdfWriter.GetInstance(pdffile, New FileStream(Interfaz.direccionPDF, FileMode.Create))
        pdffile.Open()

        'fuentes que va a tener
        Dim fuenteTitulo As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLDITALIC, BaseColor.BLACK)
        Dim fuenteTabla As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
        Dim fuenteColumnaTabla As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        'Dim fuentevariable As Font

        'insercion del encabezado en el pdf
        parrafo = New Paragraph(New Chunk("Reporte de Profesor - SiABi", fuenteTitulo)) 'titulo con el nombre del archivo
        parrafo.Alignment = Element.ALIGN_CENTER 'alineado al centro
        parrafo.SpacingAfter = 30.0F

        'agrego el encabezado en el pdf
        pdffile.Add(parrafo)

        'insercion de descripción en el pdf
        parrafo2 = New Paragraph(New Chunk("Profesor: " + TextBoxApProf.Text + ", " + TextBoxNomProf.Text + "  -  DNI: " + TextBoxDNIProf.Text + "  -  Legajo: " + TextBoxLegajoProf.Text, fuenteTitulo)) 'titulo con el nombre del archivo
        parrafo2.Alignment = Element.ALIGN_CENTER 'alineado al centro
        parrafo2.SpacingAfter = 30.0F

        'agrego la descripcion en el pdf
        pdffile.Add(parrafo2)

        'insercion del titulo en el pdf
        parrafo = New Paragraph(New Chunk(DataGridViewdatosProfe.Text, fuenteTitulo)) 'titulo con el nombre del archivo
        parrafo.Alignment = Element.ALIGN_CENTER 'alineado al centro
        parrafo.SpacingAfter = 30.0F

        'agrego el titulo en el pdf
        pdffile.Add(parrafo)

        'pasamos el datagrid a una tabla
        Dim pdftable As New PdfPTable(DataGridViewdatosProfe.Columns.Count - 1)
        pdftable.TotalWidth = 500.0F
        pdftable.LockedWidth = True
        Dim ancho(0 To DataGridViewdatosProfe.Columns.Count - 2) As Single
        For i As Integer = 0 To DataGridViewdatosProfe.Columns.Count - 2
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
        For i As Integer = 1 To DataGridViewdatosProfe.Columns.Count - 1
            pdfcelda = New PdfPCell(New Phrase(New Chunk(DataGridViewdatosProfe.Columns(i).HeaderText, fuenteColumnaTabla)))
            pdfcelda.HorizontalAlignment = PdfPCell.ALIGN_CENTER 'alineado de los encabezados
            'añadimos las celdas en la pdftable
            pdftable.AddCell(pdfcelda)
        Next

        'añadir datos a la tabla
        For i As Integer = 1 To DataGridViewdatosProfe.Rows.Count - 1 'aca son las rows no las columns
            For j As Integer = 2 To DataGridViewdatosProfe.Columns.Count - 1
                pdfceldaB = New PdfPCell(New Phrase(DataGridViewdatosProfe(j, i).Value.ToString(), fuenteTabla))
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

    Public Sub CargarHuellasPersona()
        'cargar las huellas del profesor
        Dim obtenerHuellas As New SqlCommand("GetDatosHuellas", con)
        obtenerHuellas.CommandType = CommandType.StoredProcedure
        obtenerHuellas.Parameters.Add("@legajo", SqlDbType.Int).Value = idProfesor
        obtenerHuellas.Parameters.Add("@tipoPersona", SqlDbType.VarChar, 8).Value = "Profesor"

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

    Private Sub VerMasProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxLegajoProf.Text = idProfesor
        BotonesDelParent()
        CargarCarrerasProfesor()
        CargarHuellasPersona()
        LoadDataGrid()

        If Interfaz.LabelTipoUsuarioActual.Text = "Bedel" Or Interfaz.LabelTipoUsuarioActual.Text = "Administrador" Then
            ButtonModificarHuellas.Visible = True
        End If

        'cargar los datos del profesor
        Dim obtenerDatosA As New SqlCommand("GetDatosProfesor", con)
        obtenerDatosA.CommandType = CommandType.StoredProcedure
        obtenerDatosA.Parameters.Add("@legajo", SqlDbType.Int).Value = idProfesor
        Try
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(obtenerDatosA)
            Dim dt As New DataTable
            adapter.Fill(dt)

            con.Open()
            For Each Fila As DataRow In dt.Rows
                TextBoxNomProf.Text = Fila.Item(0).ToString()
                TextBoxApProf.Text = Fila.Item(1).ToString()
                TextBoxDNIProf.Text = Fila.Item(2).ToString()

                If Not IsDBNull(Fila.Item(5)) Then
                    Dim imagen() As Byte = Fila.Item(5)
                    If imagen IsNot Nothing Then
                        Dim ms As MemoryStream = New MemoryStream(imagen)
                        PictureProfesor.Image = FromStream(ms)
                    End If
                End If
            Next
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub


    Private Sub CargarCarrerasProfesor()
        'carga las carreras en las que dicta el profesor
        ComboBoxCarreraProf.Items.Clear()

        Dim cargarCarreras As New SqlCommand("GetCarrerasProfesor", con)
        cargarCarreras.CommandType = CommandType.StoredProcedure
        cargarCarreras.Parameters.Add("@legajo", SqlDbType.Int).Value = idProfesor
        Try
            con.Open()
            Dim dt As New DataTable
            dt.Load(cargarCarreras.ExecuteReader)
            For Each Fila As DataRow In dt.Rows
                ComboBoxCarreraProf.Items.Add(Fila.Item(0))
            Next
            con.Close()
            If ComboBoxCarreraProf.Items.Count > 0 Then
                ComboBoxCarreraProf.SelectedIndex() = 0
                ComboBoxCarreraProf.Enabled = True
                LabelCarrerasProfe.Visible = False
            Else
                LabelCarrerasProfe.Visible = True
                ComboBoxCarreraProf.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonVerPlanilla.Click
        If TextBoxSelectedMateria.Text = "" Then
            MsgBox("Para ver el detalle de las asistencias, debe seleccionar una materia de la grilla, haciendo click en el boton Elegir a la izquierda de la materia deseada.", MsgBoxStyle.Exclamation)
        Else
            Dim frm As AsistenciasProfesor = New AsistenciasProfesor()
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

    Private Sub DataGridViewDatosMaterias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewdatosProfe.CellContentClick
        'obtengo fila+columna para saber si se hizo click sobre el botón y no otra celda del datagrid
        Dim columna As Integer = e.ColumnIndex
        Dim fila As Integer = e.RowIndex

        If columna = 0 Then
            If fila > -1 Then
                TextBoxSelectedMateria.Text = DataGridViewdatosProfe.CurrentRow.Cells(1).Value
                materiaSeleccionada = DataGridViewdatosProfe.CurrentRow.Cells(1).Value
                comisionSeleccionada = DataGridViewdatosProfe.CurrentRow.Cells(2).Value
                cargoSeleccionado = DataGridViewdatosProfe.CurrentRow.Cells(3).Value
                suplente = DataGridViewdatosProfe.CurrentRow.Cells(4).Value.ToString()
                diaPractica = DataGridViewdatosProfe.CurrentRow.Cells(5).Value
                diaTeoria = DataGridViewdatosProfe.CurrentRow.Cells(6).Value
                carreraSeleccionada = ComboBoxCarreraProf.Text
            End If
        End If
    End Sub

    Private Sub ComboBoxCarreraProf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCarreraProf.SelectedIndexChanged
        LoadDataGrid()
    End Sub
End Class