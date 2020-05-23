Imports System.Data.SqlClient
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO

Public Class VerMasAula
    '##### el estado del aula se actualiza de libre a ocupado cuando el profesor marca la entrada al aula con la huella
    '##### el estado del aula se actualiza de ocupado a libre cuando el profesor marca la salida al aula con la huella

    Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)

    Public Sub LoadDataGrid()
        '##### CARGA EL DATAGRID DE COMISIONES
        Dim obtenerComisiones As New SqlCommand("GetCarrCatComPorAula", con)
        obtenerComisiones.CommandType = CommandType.StoredProcedure
        obtenerComisiones.Parameters.Add("@aula", SqlDbType.Int).Value = Aulas.idAulaSeleccionada

        Dim adapter As SqlDataAdapter = New SqlDataAdapter(obtenerComisiones)
        Dim dt As New DataTable
        adapter.Fill(dt)

        DataGridViewComisionesXAula.DataSource = dt
        DataGridViewComisionesXAula.Columns(1).HeaderText = "Carrera"
        DataGridViewComisionesXAula.Columns(2).HeaderText = "Cátedra"
        DataGridViewComisionesXAula.Columns(3).HeaderText = "Comisión"
    End Sub

    Private Sub CargarDatosAula()
        'cargar los datos del aula
        Dim obtenerDatosAula As New SqlCommand("GetDatosAula", con)
        obtenerDatosAula.CommandType = CommandType.StoredProcedure
        obtenerDatosAula.Parameters.Add("@aula", SqlDbType.SmallInt).Value = Aulas.idAulaSeleccionada
        Try
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(obtenerDatosAula)
            Dim dat As New DataTable
            adapter.Fill(dat)

            For Each Fila As DataRow In dat.Rows
                TextBoxSerialLector.Text = Fila.Item(0).ToString()
                TextBoxEdificio.Text = Fila.Item(1).ToString()
                If Fila.Item(2).ToString() = "Online" Then
                    RadioButtonOnline.Checked = True
                    RadioButtonOnline.BackColor = Color.YellowGreen
                    RadioButtonOffline.BackColor = Color.LightGray
                Else
                    RadioButtonOffline.Checked = True
                    RadioButtonOffline.BackColor = Color.LightCoral
                    RadioButtonOnline.BackColor = Color.LightGray
                End If
                If Fila.Item(3).ToString() = "Libre" Then
                    RadioButtonLibre.Checked = True
                    RadioButtonLibre.BackColor = Color.YellowGreen
                    RadioButtonOcupado.BackColor = Color.LightGray
                Else
                    RadioButtonOcupado.Checked = True
                    RadioButtonOcupado.BackColor = Color.LightCoral
                    RadioButtonLibre.BackColor = Color.LightGray
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Sub ValidarPrestamoAula()
        'validar si el aula está prestada y cargar los datos
        Dim validarPrestada As New SqlCommand("ValidarAulaPrestada", con)
        validarPrestada.CommandType = CommandType.StoredProcedure
        validarPrestada.Parameters.Add("@aula", SqlDbType.VarChar, 255).Value = TextBoxNroAula.Text
        Try
            con.Open()
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(validarPrestada)
            Dim dt As New DataTable
            adapter.Fill(dt)
            con.Close()

            If dt.Rows.Count() > 0 Then
                TextBoxPrestada.Text = "Si"
                ButtonPrestarAula.Enabled = False
                ButtonDevolver.Enabled = True
                TextBoxPrestada.BackColor = Color.LightCoral
                For Each Fila As DataRow In dt.Rows
                    TextBoxCarrera.Text = Fila.Item(0).ToString()
                    TextBoxCatedra.Text = Fila.Item(1).ToString()
                    TextBoxComision.Text = Fila.Item(2).ToString()
                Next
            Else
                TextBoxPrestada.Text = "No"
                ButtonPrestarAula.Enabled = True
                ButtonDevolver.Enabled = False
                TextBoxPrestada.BackColor = Color.YellowGreen
                TextBoxCarrera.Text = ""
                TextBoxCatedra.Text = ""
                TextBoxComision.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    '##### GENERAR PDF
    Public Sub GenerarPDF()
        Dim parrafo As New Paragraph 'nuevo parrafo
        Dim parrafo2 As New Paragraph 'nuevo parrafo

        Dim pdffile As New Document(PageSize.A4, 40, 40, 40, 20) 'tamaño de la hoja y margenes del pdf
        pdffile.AddHeader("SiABi", "Reporte del Aula " + TextBoxNroAula.Text + ".")
        pdffile.AddCreationDate()

        Dim write As PdfWriter = PdfWriter.GetInstance(pdffile, New FileStream(Interfaz.direccionPDF, FileMode.Create))
        pdffile.Open()

        'fuentes que va a tener
        Dim fuenteTitulo As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLDITALIC, BaseColor.BLACK)
        Dim fuenteTabla As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
        Dim fuenteColumnaTabla As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        'Dim fuentevariable As Font

        'insercion del encabezado en el pdf
        parrafo = New Paragraph(New Chunk("Reporte del Aula " + TextBoxNroAula.Text + " - SiABi", fuenteTitulo)) 'titulo con el nombre del archivo
        parrafo.Alignment = Element.ALIGN_CENTER 'alineado al centro
        parrafo.SpacingAfter = 30.0F

        'agrego el encabezado en el pdf
        pdffile.Add(parrafo)

        'insercion de descripción en el pdf
        parrafo2 = New Paragraph(New Chunk("Edificio: " + TextBoxEdificio.Text + "  -  Serial: " + TextBoxSerialLector.Text, fuenteTitulo)) 'titulo con el nombre del archivo
        parrafo2.Alignment = Element.ALIGN_CENTER 'alineado al centro
        parrafo2.SpacingAfter = 30.0F

        'agrego la descripcion en el pdf
        pdffile.Add(parrafo2)

        If TextBoxPrestada.Text = "Si" Then

            Dim parrafo3 As New Paragraph 'nuevo parrafo
            'insercion de descripción en el pdf
            parrafo3 = New Paragraph(New Chunk("Aula prestada a la Cátedra: " + TextBoxCatedra.Text + "  -  Comisión: " + TextBoxComision.Text + " - Carrera: " + TextBoxCarrera.Text, fuenteTitulo)) 'titulo con el nombre del archivo
            parrafo3.Alignment = Element.ALIGN_CENTER 'alineado al centro
            parrafo3.SpacingAfter = 30.0F

            'agrego la descripcion en el pdf
            pdffile.Add(parrafo3)
        End If

        Dim botonAula As String
        Dim botonLector As String

        If RadioButtonLibre.Checked Then
            botonAula = "Libre"
        Else
            botonAula = "Ocupada"
        End If
        If RadioButtonOnline.Checked Then
            botonLector = "Online"
        Else
            botonLector = "OFFLINE"
        End If

        Dim parrafo4 As New Paragraph 'nuevo parrafo
        'insercion de descripción en el pdf
        parrafo4 = New Paragraph(New Chunk("Estado del Aula: " + botonAula + "  -  Lector de Huellas: " + botonLector, fuenteTitulo)) 'titulo con el nombre del archivo
        parrafo4.Alignment = Element.ALIGN_CENTER 'alineado al centro
        parrafo4.SpacingAfter = 30.0F

        'agrego la descripcion en el pdf
        pdffile.Add(parrafo4)

        'insercion del titulo en el pdf
        parrafo = New Paragraph(New Chunk(DataGridViewComisionesXAula.Text, fuenteTitulo)) 'titulo con el nombre del archivo
        parrafo.Alignment = Element.ALIGN_CENTER 'alineado al centro
        parrafo.SpacingAfter = 30.0F

        'agrego el titulo en el pdf
        pdffile.Add(parrafo)

        'pasamos el datagrid a una tabla
        Dim pdftable As New PdfPTable(DataGridViewComisionesXAula.Columns.Count - 1)
        pdftable.TotalWidth = 500.0F
        pdftable.LockedWidth = True
        Dim ancho(0 To DataGridViewComisionesXAula.Columns.Count - 2) As Single
        For i As Integer = 0 To DataGridViewComisionesXAula.Columns.Count - 2
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
        For i As Integer = 1 To DataGridViewComisionesXAula.Columns.Count - 1
            pdfcelda = New PdfPCell(New Phrase(New Chunk(DataGridViewComisionesXAula.Columns(i).HeaderText, fuenteColumnaTabla)))
            pdfcelda.HorizontalAlignment = PdfPCell.ALIGN_CENTER 'alineado de los encabezados
            'añadimos las celdas en la pdftable
            pdftable.AddCell(pdfcelda)
        Next

        'añadir datos a la tabla
        For i As Integer = 1 To DataGridViewComisionesXAula.Rows.Count - 1 'aca son las rows no las columns
            For j As Integer = 1 To DataGridViewComisionesXAula.Columns.Count - 1
                pdfceldaB = New PdfPCell(New Phrase(DataGridViewComisionesXAula(j, i).Value.ToString(), fuenteTabla))
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

    Private Sub VerMasAula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BOTONES DEL PARENT
        Interfaz.botonVolver.Enabled = True
        Interfaz.botonImprimir.Visible = False
        Interfaz.botonPDF.Visible = True

        If Interfaz.LabelTipoUsuarioActual.Text = "Administrador" Or Interfaz.LabelTipoUsuarioActual.Text = "Bedel" Then
            ButtonmodificarDatos.Visible = True
            ButtonGuardarDatos.Visible = True
            ButtonPrestarAula.Visible = True
            ButtonDevolver.Visible = True
            ButtonAgregarComision.Visible = True
        End If

        If Interfaz.LabelTipoUsuarioActual.Text <> "Administrador" Then
            ButtonEliminar.Visible = False
        End If
        TextBoxNroAula.Text = Aulas.idAulaSeleccionada
        CargarDatosAula()
        LoadDataGrid()
        ValidarPrestamoAula()
    End Sub

    Private Sub ButtonmodificarDatos_Click(sender As Object, e As EventArgs) Handles ButtonmodificarDatos.Click
        If ButtonmodificarDatos.Text = "Modificar Datos" Then
            LabelGuardarCambios.Visible = True
            'HABILITA LOS CAMPOS PARA SU EDICION
            'TextBoxEdificio.ReadOnly = True
            TextBoxSerialLector.ReadOnly = False
            'RadioButtonLibre.Enabled = True
            'RadioButtonOcupado.Enabled = True
            RadioButtonOnline.Enabled = True
            RadioButtonOffline.Enabled = True

            ButtonmodificarDatos.Text = "Cancelar cambios"
            ButtonGuardarDatos.Enabled = True
        Else
            DesabilitarCampos()
            CargarDatosAula()
        End If
    End Sub

    Private Sub DesabilitarCampos()
        'DESHABILITA LOS CAMPOS
        LabelGuardarCambios.Visible = False
        'HABILITA LOS CAMPOS PARA SU EDICION
        'TextBoxEdificio.ReadOnly = False
        TextBoxSerialLector.ReadOnly = True
        'RadioButtonLibre.Enabled = False
        'RadioButtonOcupado.Enabled = False
        RadioButtonOnline.Enabled = False
        RadioButtonOffline.Enabled = False

        ButtonmodificarDatos.Text = "Modificar Datos"
        ButtonGuardarDatos.Enabled = False
    End Sub

    Private Sub ButtonGuardarDatos_Click(sender As Object, e As EventArgs) Handles ButtonGuardarDatos.Click
        If TextBoxEdificio.Text = "" Then
            MsgBox("El campo Edificio no puede estar vacío")
        End If
        If TextBoxSerialLector.Text = "" Then
            MsgBox("El campo Lector no puede estar vacío")
        End If

        Dim botonAula As String
        Dim botonLector As String

        If RadioButtonLibre.Checked Then
            botonAula = "Libre"
        Else
            botonAula = "Ocupada"
        End If
        If RadioButtonOnline.Checked Then
            botonLector = "Online"
        Else
            botonLector = "OFFLINE"
        End If

        Dim updateAula As New SqlCommand("UpdateDatosAula", con)
        updateAula.CommandType = CommandType.StoredProcedure
        updateAula.Parameters.Add("@aula", SqlDbType.SmallInt).Value = TextBoxNroAula.Text
        updateAula.Parameters.Add("@edificio", SqlDbType.VarChar, 100).Value = TextBoxEdificio.Text
        updateAula.Parameters.Add("@ocupada", SqlDbType.VarChar, 7).Value = botonAula
        updateAula.Parameters.Add("@estado", SqlDbType.VarChar, 10).Value = botonLector
        updateAula.Parameters.Add("@serial", SqlDbType.VarChar, 255).Value = TextBoxSerialLector.Text

        Try
            con.Open()
            updateAula.ExecuteNonQuery()
            MsgBox("El aula fue actualizada correctamente", MsgBoxStyle.Information)
            DesabilitarCampos()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Public Shared idAulaSeleccionada As String
    Private Sub DataGridViewComisionesXAula_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewComisionesXAula.CellContentClick
        'obtengo fila+columna para saber si se hizo click sobre el botón y no otra celda del datagrid
        Dim columna As Integer = e.ColumnIndex
        Dim fila As Integer = e.RowIndex
        Dim idMat As String = ""

        If columna = 0 Then
            If fila > -1 Then
                If MsgBox("¿Está seguro que desea eliminar la Carrera+Cátedra+Comisión seleccionado?", MessageBoxButtons.OKCancel) = MsgBoxResult.Ok Then
                    'obtener el id de la materia segun carrera+catedra+comision
                    Dim buscarIdMateria As New SqlCommand("GetIdMateriaDeMateria", con)
                    buscarIdMateria.CommandType = CommandType.StoredProcedure
                    buscarIdMateria.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = DataGridViewComisionesXAula.CurrentRow.Cells(1).Value
                    buscarIdMateria.Parameters.Add("@nombre", SqlDbType.VarChar, 255).Value = DataGridViewComisionesXAula.CurrentRow.Cells(2).Value
                    buscarIdMateria.Parameters.Add("@comision", SqlDbType.SmallInt).Value = DataGridViewComisionesXAula.CurrentRow.Cells(3).Value
                    Try
                        con.Open()
                        idMat = buscarIdMateria.ExecuteScalar()
                        con.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                    End Try

                    Dim eliminarAula As New SqlCommand("EliminarCatComDelAula", con)
                    eliminarAula.CommandType = CommandType.StoredProcedure
                    eliminarAula.Parameters.Add("@aula", SqlDbType.Int).Value = TextBoxNroAula.Text
                    eliminarAula.Parameters.Add("@idMat", SqlDbType.Int).Value = idMat
                    eliminarAula.Parameters.Add("@comision", SqlDbType.SmallInt).Value = DataGridViewComisionesXAula.CurrentRow.Cells(3).Value
                    Try
                        con.Open()
                        eliminarAula.ExecuteNonQuery()
                        con.Close()
                        MsgBox("La Carrera+Cátedra+Comisión fue eliminada exitosamente", MsgBoxStyle.Information)

                        'Recarga el datagrid donde ahora no se ve el eliminado
                        Interfaz.RecargarDataGrid()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                    End Try
                Else
                    MsgBox("La Carrera+Cátedra+Comisión del aula no fue eliminada", MsgBoxStyle.Information)
                End If
            End If
        End If
    End Sub

    Public Sub CargarDatosPrestada()
        TextBoxPrestada.Text = "Si"
        TextBoxPrestada.BackColor = Color.LightCoral
        ButtonPrestarAula.Enabled = False
        ButtonDevolver.Enabled = True

        TextBoxCarrera.Text = Interfaz.carrera
        TextBoxCatedra.Text = Interfaz.catedra
        TextBoxComision.Text = Interfaz.comision
    End Sub

    Private Sub ButtonPrestarAula_Click(sender As Object, e As EventArgs) Handles ButtonPrestarAula.Click
        If RadioButtonOffline.Checked Then
            MsgBox("No puede prestar el Aula, el lector se encuentra OFFLINE")
            Exit Sub
        End If

        '##### trae la info de la tabla Materias
        Dim frm As PrestarAula = New PrestarAula()
        frm.ShowDialog()
    End Sub

    Private Sub ButtonDevolver_Click(sender As Object, e As EventArgs) Handles ButtonDevolver.Click
        If MsgBox("¿Está seguro que desea devolver el préstamo del aula?", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            Try
                Dim devolverAula As New SqlCommand("DevolverAula", con)
                devolverAula.CommandType = CommandType.StoredProcedure
                devolverAula.Parameters.Add("@aula", SqlDbType.Int).Value = TextBoxNroAula.Text
                Dim existe As String = ""
                Try
                    con.Open()
                    existe = devolverAula.ExecuteScalar()
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                End Try

                If existe = "" Then
                    'si el aula está siendo utilizada se devuelve cuando el profesor marca salida. 'aula prestada' sería = no y no se valida acá
                    MsgBox("No se puede devolver el aula porque está siendo utilizada por la materia que figura en 'Préstamo de Aula'", MsgBoxStyle.Exclamation)
                Else
                    'si la clase aún no empezó se puede devolver
                    TextBoxPrestada.Text = "No"
                    ButtonPrestarAula.Enabled = True
                    ButtonDevolver.Enabled = False
                    TextBoxPrestada.BackColor = Color.YellowGreen
                    TextBoxCarrera.Text = ""
                    TextBoxCatedra.Text = ""
                    TextBoxComision.Text = ""
                    MsgBox("El Aula fue devuelta exitosamente", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        Else
            MsgBox("El Aula no fue devuelta", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub ButtonAgregarComision_Click(sender As Object, e As EventArgs) Handles ButtonAgregarComision.Click
        Dim frm As AltaCatedraComision = New AltaCatedraComision()
        frm.ShowDialog()
    End Sub

    Private Sub RadioButtonLibre_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonLibre.CheckedChanged
        If RadioButtonLibre.Checked Then
            RadioButtonLibre.BackColor = Color.YellowGreen
            'RadioButtonLibre.Font = FontStyle.Bold
            RadioButtonOcupado.BackColor = Color.LightGray
        Else
            RadioButtonLibre.BackColor = Color.LightGray
            'RadioButtonLibre.Font = FontStyle.Bold
            RadioButtonOcupado.BackColor = Color.LightCoral
            'RadioButtonOcupado.Font = FontStyle.Bold
        End If
    End Sub

    Private Sub RadioButtonOnline_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOnline.CheckedChanged
        If RadioButtonOnline.Checked Then
            RadioButtonOnline.BackColor = Color.YellowGreen
            RadioButtonOffline.BackColor = Color.LightGray
        Else
            RadioButtonOffline.BackColor = Color.LightCoral
            RadioButtonOnline.BackColor = Color.LightGray
        End If
    End Sub


End Class