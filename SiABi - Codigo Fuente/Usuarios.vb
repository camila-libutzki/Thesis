Imports System.Data.SqlClient
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO

Public Class Usuarios
    Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)
    Public Shared legajoSeleccionado As String
    Public Shared nombreUSeleccionado As String
    Public Shared nomyapSeleccionado As String
    Public Shared dniSeleccionado As String

    Public Sub BotonesDelParent()
        'BOTONES DEL PARENT
        Interfaz.botonVolver.Enabled = False
        Interfaz.botonImprimir.Visible = True
        Interfaz.botonPDF.Visible = True
    End Sub

    Public Sub LoadDataGrid()
        Dim obtenerUsuarios As New SqlCommand("GetUsuariosSegunCriterio", con)
        obtenerUsuarios.CommandType = CommandType.StoredProcedure
        obtenerUsuarios.Parameters.Add("@criterio", SqlDbType.VarChar, 20).Value = ComboBoxCriterio.Text
        If ComboBoxCriterio.Text = "Tipo" Then
            obtenerUsuarios.Parameters.Add("@parametroBusqueda", SqlDbType.VarChar, 100).Value = ComboBoxTipoUsuario.Text
        Else
            obtenerUsuarios.Parameters.Add("@parametroBusqueda", SqlDbType.VarChar, 100).Value = TextBoxBusquedaXCriterio.Text
        End If

        Try
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(obtenerUsuarios)
            Dim dt As New DataTable
            adapter.Fill(dt)
            DataGridViewUsuarios.DataSource = dt

            If Me.DataGridViewUsuarios.Rows.Count() = 0 Then
                MsgBox("No se encontraron usuarios con el criterio seleccionado", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BotonesDelParent()
        ComboBoxCriterio.SelectedIndex = 0
        ComboBoxTipoUsuario.SelectedIndex = 0

        'consulta vacia para cargar los titulos
        Dim obtenerUsuarios As New SqlCommand("GetUsuariosSegunCriterio", con)
        obtenerUsuarios.CommandType = CommandType.StoredProcedure
        obtenerUsuarios.Parameters.Add("@criterio", SqlDbType.VarChar, 20).Value = ComboBoxCriterio.Text
        obtenerUsuarios.Parameters.Add("@parametroBusqueda", SqlDbType.VarChar, 100).Value = ""

        Dim adapter As SqlDataAdapter = New SqlDataAdapter(obtenerUsuarios)
        Dim dt As New DataTable
        adapter.Fill(dt)
        DataGridViewUsuarios.DataSource = dt
        DataGridViewUsuarios.Columns(1).HeaderText = "Nombre y Apellido"
        DataGridViewUsuarios.Columns(2).HeaderText = "Legajo"
        DataGridViewUsuarios.Columns(3).HeaderText = "DNI"
        DataGridViewUsuarios.Columns(4).HeaderText = "Nombre Usuario"
        DataGridViewUsuarios.Columns(5).HeaderText = "Tipo"

        If Interfaz.LabelTipoUsuarioActual.Text = "Administrador" Then
            ButtonEliminar.Visible = True
        End If
    End Sub

    '##### VERMAS
    Private Sub ButtonVerMas_Click(sender As Object, e As EventArgs) Handles ButtonVerMas.Click
        'VER MAS INFORMACION DEL USUARIO SELECCIONADO
        If TextBoxUsuarioSeleccionado.Text = "" Then
            MsgBox("Debe seleccionar un usuario de la grilla, haciendo click en el boton Elegir a la izquierda de cada uno.", MsgBoxStyle.Exclamation)
        Else
            Dim frm As VerMasUsuario = New VerMasUsuario()
            frm.MdiParent = Interfaz
            frm.Dock = DockStyle.Fill
            frm.Show()
        End If
    End Sub

    '##### BUSCAR SEGUN CRITERIO
    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        If ComboBoxCriterio.Text = "Legajo" Then
            If TextBoxBusquedaXCriterio.Text <> "" Then
                If IsNumeric(TextBoxBusquedaXCriterio.Text) = False Then
                    MsgBox("El valor del Legajo debe ser un número", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            Else
                MsgBox("Debe completar el Legajo para poder buscar el usuario.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If
        If ComboBoxCriterio.Text <> "Tipo" Then
            If TextBoxBusquedaXCriterio.Text = "" Then
                MsgBox("Debe completar el campo de búsqueda para poder buscar el usuario.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If

        LoadDataGrid()
    End Sub

    '##### MUESTRA EN EL TEXT BOX EL USUARIO SELECCIONADO
    Private Sub DataGridViewUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewUsuarios.CellContentClick
        'obtengo fila+columna para saber si se hizo click sobre el botón y no otra celda del datagrid
        Dim columna As Integer = e.ColumnIndex
        Dim fila As Integer = e.RowIndex

        If columna = 0 Then
            If fila > -1 Then
                TextBoxUsuarioSeleccionado.Text = DataGridViewUsuarios.CurrentRow.Cells(1).Value
                legajoSeleccionado = DataGridViewUsuarios.CurrentRow.Cells(2).Value
                nombreUSeleccionado = DataGridViewUsuarios.CurrentRow.Cells(4).Value
                nomyapSeleccionado = DataGridViewUsuarios.CurrentRow.Cells(1).Value
                dniSeleccionado = DataGridViewUsuarios.CurrentRow.Cells(3).Value
            End If
        End If
    End Sub

    '##### ELIMINAR
    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        If TextBoxUsuarioSeleccionado.Text = "" Then
            MsgBox("Debe seleccionar un usuario para poder eliminarlo.")
            Exit Sub
        End If
        If MsgBox("¿Está seguro que desea eliminar al usuario: " + TextBoxUsuarioSeleccionado.Text + "?" & vbCrLf & "Se eliminarán también los perfiles asociado al usuario.", MessageBoxButtons.OKCancel) = MsgBoxResult.Ok Then
            Dim eliminarUsuario As New SqlCommand("EliminarUsuario", con)
            eliminarUsuario.CommandType = CommandType.StoredProcedure
            eliminarUsuario.Parameters.Add("@legajo", SqlDbType.VarChar, 10).Value = legajoSeleccionado

            Try
                con.Open()
                eliminarUsuario.ExecuteNonQuery()
                con.Close()

                MsgBox("El usuario fue eliminado exitosamente", MsgBoxStyle.Information)
                LoadDataGrid()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        Else
            MsgBox("El usuario no fue eliminado.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ComboBoxcriterio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCriterio.SelectedIndexChanged
        If ComboBoxCriterio.Text = "Tipo" Then
            TextBoxBusquedaXCriterio.Visible = False
            ComboBoxTipoUsuario.Visible = True
        Else
            TextBoxBusquedaXCriterio.Visible = True
            ComboBoxTipoUsuario.Visible = False
        End If
    End Sub

    '##### GENERAR PDF
    Public Sub GenerarPDF()
        Dim parrafo As New Paragraph 'nuevo parrafo
        Dim pdffile As New Document(PageSize.A4, 40, 40, 40, 20) 'tamaño de la hoja y margenes del pdf
        'pdffile.AddTitle(TextBoxNombreArchivo.Text) 'titulo del pdf
        pdffile.AddHeader("SiABi", "Reporte de Usuarios")
        pdffile.AddCreationDate()

        Dim write As PdfWriter = PdfWriter.GetInstance(pdffile, New FileStream(Interfaz.direccionPDF, FileMode.Create))
        pdffile.Open()

        'fuentes que va a tener
        Dim fuenteTitulo As New Font(itextsharp.text.Font.FontFamily.HELVETICA, 14, itextsharp.text.Font.BOLDITALIC, BaseColor.BLACK)
        Dim fuenteTabla As New Font(itextsharp.text.Font.FontFamily.HELVETICA, 12, itextsharp.text.Font.NORMAL, BaseColor.BLACK)
        Dim fuenteColumnaTabla As New Font(itextsharp.text.Font.FontFamily.HELVETICA, 13, itextsharp.text.Font.BOLD, BaseColor.BLACK)
        'Dim fuentevariable As Font

        'insercion del encabezado en el pdf
        parrafo = New Paragraph(New Chunk("Reporte de Usuarios - SiABi", fuenteTitulo)) 'titulo con el nombre del archivo
        parrafo.Alignment = Element.ALIGN_CENTER 'alineado al centro
        parrafo.SpacingAfter = 30.0F

        'agrego el encabezado en el pdf
        pdffile.Add(parrafo)

        'insercion del titulo en el pdf
        parrafo = New Paragraph(New Chunk(DataGridViewUsuarios.Text, fuenteTitulo)) 'titulo con el nombre del archivo
        parrafo.Alignment = Element.ALIGN_CENTER 'alineado al centro
        parrafo.SpacingAfter = 30.0F

        'agrego el titulo en el pdf
        pdffile.Add(parrafo)

        'pasamos el datagrid a una tabla
        Dim pdftable As New PdfPTable(DataGridViewUsuarios.Columns.Count - 1)
        pdftable.TotalWidth = 500.0F
        pdftable.LockedWidth = True
        Dim ancho(0 To DataGridViewUsuarios.Columns.Count - 2) As Single
        For i As Integer = 0 To DataGridViewUsuarios.Columns.Count - 2
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
        For i As Integer = 1 To DataGridViewUsuarios.Columns.Count - 1
            pdfcelda = New PdfPCell(New Phrase(New Chunk(DataGridViewUsuarios.Columns(i).HeaderText, fuenteColumnaTabla)))
            pdfcelda.HorizontalAlignment = PdfPCell.ALIGN_CENTER 'alineado de los encabezados
            'añadimos las celdas en la pdftable
            pdftable.AddCell(pdfcelda)
        Next

        'añadir datos a la tabla
        For i As Integer = 0 To DataGridViewUsuarios.Rows.Count - 1 'aca son las rows no las columns
            For j As Integer = 1 To DataGridViewUsuarios.Columns.Count - 1
                pdfceldaB = New PdfPCell(New Phrase(DataGridViewUsuarios(j, i).Value.ToString(), fuenteTabla))
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