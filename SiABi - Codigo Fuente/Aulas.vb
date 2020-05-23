Imports System.Data.SqlClient
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO

Public Class Aulas
    Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)
    Public Shared idAulaSeleccionada As String

    Public Sub BotonesDelParent()
        'BOTONES DEL PARENT
        Interfaz.botonVolver.Enabled = False
        Interfaz.botonImprimir.Visible = False
        Interfaz.botonPDF.Visible = True
    End Sub

    Public Sub LoadDataGrid()
        Dim obtenerAulas As New SqlCommand("GetAulasSegunCriterio", con)
        obtenerAulas.CommandType = CommandType.StoredProcedure
        obtenerAulas.Parameters.Add("@criterio", SqlDbType.VarChar, 20).Value = ComboBoxAula.Text
        If ComboBoxAula.Text = "Edificio" Or ComboBoxAula.Text = "Estado del Lector" Or ComboBoxAula.Text = "Estado del Aula" Then
            obtenerAulas.Parameters.Add("@parametroBusqueda", SqlDbType.VarChar, 100).Value = ComboBoxEstado.Text
        Else
            obtenerAulas.Parameters.Add("@parametroBusqueda", SqlDbType.VarChar, 100).Value = TextBoxBusquedaAulas.Text
        End If

        Try
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(obtenerAulas)
            Dim dt As New DataTable
            adapter.Fill(dt)
            DataGridViewAulas.DataSource = dt

            If Me.DataGridViewAulas.Rows.Count() = 0 Then
                MsgBox("No se encontraron aulas con el criterio seleccionado", MsgBoxStyle.Information)
            Else
                'DataGridViewComisionesXAula.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                For Each fila As DataGridViewRow In DataGridViewAulas.Rows
                    If fila.Cells(4).Value = "OFFLINE" Then
                        fila.DefaultCellStyle.BackColor = Color.Khaki
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Aulas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BotonesDelParent()

        ComboBoxAula.SelectedIndex = 0
        ComboBoxEstado.SelectedIndex = 0
        If Interfaz.LabelTipoUsuarioActual.Text = "Administrador" Then
            ButtonNuevaAula.Visible = True
            ButtonEliminar.Visible = True
        End If

        'consulta vacia para que cargue los titulos
        Dim obtenerAulas As New SqlCommand("GetAulasSegunCriterio", con)
        obtenerAulas.CommandType = CommandType.StoredProcedure
        obtenerAulas.Parameters.Add("@criterio", SqlDbType.VarChar, 20).Value = ComboBoxAula.Text
        obtenerAulas.Parameters.Add("@parametroBusqueda", SqlDbType.VarChar, 100).Value = ""

        Try
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(obtenerAulas)
            Dim dt As New DataTable
            adapter.Fill(dt)
            DataGridViewAulas.DataSource = dt
            DataGridViewAulas.Columns(1).HeaderText = "Aula"
            DataGridViewAulas.Columns(2).HeaderText = "Edificio"
            DataGridViewAulas.Columns(3).HeaderText = "Estado Aula"
            DataGridViewAulas.Columns(4).HeaderText = "Estado Lector"
            DataGridViewAulas.Columns(5).HeaderText = "Serial Lector"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    '##### VERMAS
    Private Sub ButtonAlumnoVerMas_Click(sender As Object, e As EventArgs) Handles ButtonVerMas.Click
        If TextBoxSelectedAula.Text = "" Then
            MsgBox("Debe seleccionar un aula de la grilla. Haga click en el boton Elegir a la izquierda del aula a consultar.", MsgBoxStyle.Exclamation)
        Else
            Dim frm As VerMasAula = New VerMasAula()
            frm.MdiParent = Interfaz
            frm.Dock = DockStyle.Fill
            frm.Show()
        End If
    End Sub

    '##### CARGA EL USUARIO DEL ID SELECCIONADO EN EL DATAGRID
    Private Sub DataGridViewAulas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAulas.CellContentClick
        'obtengo fila+columna para saber si se hizo click sobre el botón y no otra celda del datagrid
        Dim columna As Integer = e.ColumnIndex
        Dim fila As Integer = e.RowIndex

        If columna = 0 Then
            If fila > -1 Then
                TextBoxSelectedAula.Text = DataGridViewAulas.CurrentRow.Cells(1).Value
                idAulaSeleccionada = DataGridViewAulas.CurrentRow.Cells(1).Value
            End If
        End If
    End Sub

    '##### GENERAR PDF
    Public Sub GenerarPDF()
        Dim parrafo As New Paragraph 'nuevo parrafo

        Dim pdffile As New Document(PageSize.A4, 40, 40, 40, 20) 'tamaño de la hoja y margenes del pdf

        pdffile.AddHeader("SiABi", "Reporte de Aulas")
        pdffile.AddCreationDate()

        Dim write As PdfWriter = PdfWriter.GetInstance(pdffile, New FileStream(Interfaz.direccionPDF, FileMode.Create))
        pdffile.Open()

        'fuentes que va a tener
        Dim fuenteTitulo As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLDITALIC, BaseColor.BLACK)
        Dim fuenteTabla As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
        Dim fuenteColumnaTabla As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        'Dim fuentevariable As Font

        'insercion del encabezado en el pdf
        parrafo = New Paragraph(New Chunk("Reporte de Aulas - SiABi", fuenteTitulo)) 'titulo con el nombre del archivo
        parrafo.Alignment = Element.ALIGN_CENTER 'alineado al centro
        parrafo.SpacingAfter = 30.0F

        'agrego el encabezado en el pdf
        pdffile.Add(parrafo)

        'insercion del titulo en el pdf
        parrafo = New Paragraph(New Chunk(DataGridViewAulas.Text, fuenteTitulo)) 'titulo con el nombre del archivo
        parrafo.Alignment = Element.ALIGN_CENTER 'alineado al centro
        parrafo.SpacingAfter = 30.0F

        'agrego el titulo en el pdf
        pdffile.Add(parrafo)

        'pasamos el datagrid a una tabla
        Dim pdftable As New PdfPTable(DataGridViewAulas.Columns.Count - 1)
        pdftable.TotalWidth = 500.0F
        pdftable.LockedWidth = True
        Dim ancho(0 To DataGridViewAulas.Columns.Count - 2) As Single
        For i As Integer = 0 To DataGridViewAulas.Columns.Count - 2
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
        For i As Integer = 1 To DataGridViewAulas.Columns.Count - 1
            pdfcelda = New PdfPCell(New Phrase(New Chunk(DataGridViewAulas.Columns(i).HeaderText, fuenteColumnaTabla)))
            pdfcelda.HorizontalAlignment = PdfPCell.ALIGN_CENTER 'alineado de los encabezados
            'añadimos las celdas en la pdftable
            pdftable.AddCell(pdfcelda)
        Next

        'añadir datos a la tabla
        For i As Integer = 1 To DataGridViewAulas.Rows.Count - 1 'aca son las rows no las columns
            For j As Integer = 2 To DataGridViewAulas.Columns.Count - 1
                pdfceldaB = New PdfPCell(New Phrase(DataGridViewAulas(j, i).Value.ToString(), fuenteTabla))
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

    Private Sub ButtonNuevaAula_Click(sender As Object, e As EventArgs) Handles ButtonNuevaAula.Click
        Dim frm As AltaAula = New AltaAula()
        frm.ShowDialog()
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        If TextBoxSelectedAula.Text = "" Then
            MsgBox("Debe seleccionar un aula para poder eliminarla.")
            Exit Sub
        End If
        If MsgBox("¿Está seguro que desea eliminar el aula: " + TextBoxSelectedAula.Text + "?", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            Dim eliminarAula As New SqlCommand("EliminarAula", con)
            eliminarAula.CommandType = CommandType.StoredProcedure
            eliminarAula.Parameters.Add("@aula", SqlDbType.SmallInt).Value = TextBoxSelectedAula.Text
            Try
                con.Open()
                eliminarAula.ExecuteNonQuery()
                con.Close()
                MsgBox("El aula fue eliminada exitosamente", MsgBoxStyle.Information)
                LoadDataGrid()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        Else
            MsgBox("El aula no fue eliminada.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        If TextBoxBusquedaAulas.Visible = True Then
            If TextBoxBusquedaAulas.Text = "" Then
                MsgBox("Debe agregar un valor de búsqueda", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If

        If ComboBoxAula.Text = "Aula" Then
            If IsNumeric(TextBoxBusquedaAulas.Text) = False Then
                MsgBox("El valor del criterio Aula debe ser un número", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If

        LoadDataGrid()
    End Sub

    Private Sub ComboBoxAula_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAula.SelectedIndexChanged
        Select Case ComboBoxAula.Text
            Case "Estado del Aula"
                ComboBoxEstado.Visible = True
                ComboBoxEstado.Items.Clear()
                ComboBoxEstado.Items.Add("Libre")
                ComboBoxEstado.Items.Add("Ocupada")
                ComboBoxEstado.SelectedIndex = 0
                TextBoxBusquedaAulas.Visible = False
            Case "Estado del Lector"
                ComboBoxEstado.Visible = True
                ComboBoxEstado.Items.Clear()
                ComboBoxEstado.Items.Add("Online")
                ComboBoxEstado.Items.Add("OFFLINE")
                ComboBoxEstado.SelectedIndex = 0
                TextBoxBusquedaAulas.Visible = False
            Case "Edificio"
                ComboBoxEstado.Visible = True
                ComboBoxEstado.Items.Clear()
                ComboBoxEstado.Items.Add("Sistemas")
                ComboBoxEstado.Items.Add("Industrial")
                ComboBoxEstado.Items.Add("Mecanica")
                ComboBoxEstado.Items.Add("Quimica")
                ComboBoxEstado.Items.Add("Electrica")
                ComboBoxEstado.Items.Add("Civil")
                ComboBoxEstado.SelectedIndex = 0
                TextBoxBusquedaAulas.Visible = False
            Case Else
                ComboBoxEstado.Visible = False
                TextBoxBusquedaAulas.Visible = True
        End Select
    End Sub
End Class