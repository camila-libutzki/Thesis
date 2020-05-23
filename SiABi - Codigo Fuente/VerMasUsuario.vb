Imports System.Data.SqlClient
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Imports System.Drawing.Image

Public Class VerMasUsuario
    Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)
    Dim direccionFoto As String = ""
    Dim auxNombreUsuario As String = ""

    Public Sub LoadDataGrid()
        'cargar el datagrid de perfiles
        Dim obtenerPerfiles As New SqlCommand("GetPerfilesUsuario", con)
        obtenerPerfiles.CommandType = CommandType.StoredProcedure
        obtenerPerfiles.Parameters.Add("@legajo", SqlDbType.VarChar, 10).Value = TextBoxLegajo.Text

        Dim adapter As SqlDataAdapter = New SqlDataAdapter(obtenerPerfiles)
        Dim dt As New DataTable
        adapter.Fill(dt)

        DataGridViewPerfilesXUsuario.DataSource = dt
        DataGridViewPerfilesXUsuario.Columns(1).HeaderText = "Tipo"
        DataGridViewPerfilesXUsuario.Columns(2).HeaderText = "Departamento"
        DataGridViewPerfilesXUsuario.Columns(3).HeaderText = "Cátedra"
    End Sub

    Private Sub CargarDatosUsuario()
        'cargar los datos del usuario
        Dim obtenerDatosU As New SqlCommand("GetDatosUsuario", con)
        obtenerDatosU.CommandType = CommandType.StoredProcedure
        obtenerDatosU.Parameters.Add("@legajo", SqlDbType.VarChar, 10).Value = TextBoxLegajo.Text
        Try
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(obtenerDatosU)
            Dim dat As New DataTable
            adapter.Fill(dat)

            For Each Fila As DataRow In dat.Rows
                TextBoxNombreUsuario.Text = Fila.Item(0).ToString()
                TextBoxNombreApellido.Text = Fila.Item(1).ToString()
                TextBoxDNI.Text = Fila.Item(2).ToString()

                If Not IsDBNull(Fila.Item(3)) Then
                    Dim imagen() As Byte = Fila.Item(3)
                    If imagen IsNot Nothing Then
                        Dim ms As MemoryStream = New MemoryStream(imagen)
                        PictureBox.Image = FromStream(ms)
                    End If
                Else
                    PictureBox.Image = fotoAuxiliar.Image
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub VerMasUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BOTONES DEL PARENT
        Interfaz.botonVolver.Enabled = True
        Interfaz.botonImprimir.Visible = False
        Interfaz.botonPDF.Visible = False

        If Interfaz.LabelTipoUsuarioActual.Text = "Administrador" Or Interfaz.LabelTipoUsuarioActual.Text = "Bedel" Then
            ButtonresetContraseña.Visible = True
            LabelGuardarCambios.Visible = True
            ButtonmodificarDatos.Visible = True
            ButtonGuardarDatos.Visible = True
            ButtonExaminarFoto.Visible = True
            ButtonAgregarComision.Visible = True
        Else
            ButtonEliminar.Visible = False
        End If

        'este es el id de usuario que traemos desde la ventana modificar usuario
        TextBoxLegajo.Text = Usuarios.legajoSeleccionado

        CargarDatosUsuario()
        LoadDataGrid()
    End Sub

    '##### GENERAR PDF
    Public Sub GenerarPDF()
        Dim parrafo As New Paragraph 'nuevo parrafo
        Dim parrafo2 As New Paragraph 'nuevo parrafo

        Dim pdffile As New Document(PageSize.A4, 40, 40, 40, 20) 'tamaño de la hoja y margenes del pdf
        pdffile.AddHeader("SiABi", "Reporte de Usuario")
        pdffile.AddCreationDate()

        Dim write As PdfWriter = PdfWriter.GetInstance(pdffile, New FileStream(Interfaz.direccionPDF, FileMode.Create))
        pdffile.Open()

        'fuentes que va a tener
        Dim fuenteTitulo As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLDITALIC, BaseColor.BLACK)
        Dim fuenteTabla As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
        Dim fuenteColumnaTabla As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        'Dim fuentevariable As Font

        'insercion del encabezado en el pdf
        parrafo = New Paragraph(New Chunk("Reporte de Usuario - SiABi", fuenteTitulo)) 'titulo con el nombre del archivo
        parrafo.Alignment = Element.ALIGN_CENTER 'alineado al centro
        parrafo.SpacingAfter = 30.0F

        'agrego el encabezado en el pdf
        pdffile.Add(parrafo)

        'insercion de descripción en el pdf
        parrafo2 = New Paragraph(New Chunk("Nombre: " + TextBoxNombreApellido.Text + "  -  Usuario: " + TextBoxNombreUsuario.Text + "  -  Legajo: " + TextBoxLegajo.Text + "- DNI: " + TextBoxDNI.Text, fuenteTitulo)) 'titulo con el nombre del archivo
        parrafo2.Alignment = Element.ALIGN_CENTER 'alineado al centro
        parrafo2.SpacingAfter = 30.0F

        'agrego la descripcion en el pdf
        pdffile.Add(parrafo2)

        'insercion del titulo en el pdf
        parrafo = New Paragraph(New Chunk(DataGridViewPerfilesXUsuario.Text, fuenteTitulo)) 'titulo con el nombre del archivo
        parrafo.Alignment = Element.ALIGN_CENTER 'alineado al centro
        parrafo.SpacingAfter = 30.0F

        'agrego el titulo en el pdf
        pdffile.Add(parrafo)

        'pasamos el datagrid a una tabla
        Dim pdftable As New PdfPTable(DataGridViewPerfilesXUsuario.Columns.Count - 1)
        pdftable.TotalWidth = 500.0F
        pdftable.LockedWidth = True
        Dim ancho(0 To DataGridViewPerfilesXUsuario.Columns.Count - 2) As Single
        For i As Integer = 0 To DataGridViewPerfilesXUsuario.Columns.Count - 2
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
        For i As Integer = 1 To DataGridViewPerfilesXUsuario.Columns.Count - 1
            pdfcelda = New PdfPCell(New Phrase(New Chunk(DataGridViewPerfilesXUsuario.Columns(i).HeaderText, fuenteColumnaTabla)))
            pdfcelda.HorizontalAlignment = PdfPCell.ALIGN_CENTER 'alineado de los encabezados
            'añadimos las celdas en la pdftable
            pdftable.AddCell(pdfcelda)
        Next

        'añadir datos a la tabla
        For i As Integer = 1 To DataGridViewPerfilesXUsuario.Rows.Count - 1 'aca son las rows no las columns
            For j As Integer = 2 To DataGridViewPerfilesXUsuario.Columns.Count - 1
                pdfceldaB = New PdfPCell(New Phrase(DataGridViewPerfilesXUsuario(j, i).Value.ToString(), fuenteTabla))
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

    Private Sub ButtonmodificarDatos_Click(sender As Object, e As EventArgs) Handles ButtonmodificarDatos.Click
        If ButtonmodificarDatos.Text = "Modificar Datos" Then
            'HABILITA LOS CAMPOS PARA SU EDICION
            auxNombreUsuario = TextBoxNombreUsuario.Text

            ButtonExaminarFoto.Enabled = True
            TextBoxNombreUsuario.ReadOnly = False
            TextBoxNombreApellido.ReadOnly = False
            TextBoxDNI.ReadOnly = False
            'TextBoxLegajo.ReadOnly = False

            ButtonmodificarDatos.Text = "Cancelar cambios"
            ButtonGuardarDatos.Enabled = True
        Else
            DesabilitarCampos()
            CargarDatosUsuario()
        End If
    End Sub

    Public Sub DesabilitarCampos()
        ButtonExaminarFoto.Enabled = False
        TextBoxNombreUsuario.ReadOnly = True
        TextBoxNombreApellido.ReadOnly = True
        TextBoxDNI.ReadOnly = True
        'TextBoxLegajo.ReadOnly = True
        ButtonmodificarDatos.Text = "Modificar Datos"
        ButtonGuardarDatos.Enabled = False
    End Sub


    Private Sub ButtonGuardarDatos_Click(sender As Object, e As EventArgs) Handles ButtonGuardarDatos.Click
        '######### hay que actualizar la contraseña por si se cambia el nombre de usuario, sino desp no puede ingresar
        'también sirve como método de control y seguridad para ver que el usuario pidió hacer cambios. pone cambiarContraseña = si
        '##### PRIMERO VERIFICA QUE ESTEN BIEN TODOS LOS CAMPOS. SI HAY ALGO MAL SALE DE LA RUTINA
        If TextBoxNombreUsuario.Text = "" Then
            MsgBox("El campo Nombre de Usuario no puede estar vacío")
            Exit Sub
        End If
        If TextBoxNombreApellido.Text = "" Then
            MsgBox("El campo Nombre y Apellido no puede estar vacío")
            Exit Sub
        End If
        If TextBoxDNI.Text <> "" Then
            If IsNumeric(TextBoxDNI.Text) = False Then
                MsgBox("El valor del campo DNI debe ser un número")
                Exit Sub
            End If
        Else
            MsgBox("El campo DNI no puede estar vacío")
            Exit Sub
        End If

        Dim existe As String = ""
        If TextBoxNombreUsuario.Text <> auxNombreUsuario Then
            Dim obtenerLegajo As New SqlCommand("GetLegajoLogueado", con)
            obtenerLegajo.CommandType = CommandType.StoredProcedure
            obtenerLegajo.Parameters.Add("@nombreU", SqlDbType.VarChar, 100).Value = TextBoxNombreUsuario.Text
            Try
                con.Open()
                existe = obtenerLegajo.ExecuteScalar()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If

        If existe <> "" Then
            MsgBox("El nombre de usuario ya existe en la base de datos. Por favor elija otro.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim updateUsuario As New SqlCommand("UpdateDatosUsuario", con)
        updateUsuario.CommandType = CommandType.StoredProcedure
        updateUsuario.Parameters.Add("@legajo", SqlDbType.Int).Value = TextBoxLegajo.Text
        updateUsuario.Parameters.Add("@nombreU", SqlDbType.VarChar, 100).Value = TextBoxNombreUsuario.Text
        updateUsuario.Parameters.Add("@nomyap", SqlDbType.VarChar, 255).Value = TextBoxNombreApellido.Text
        updateUsuario.Parameters.Add("@dni", SqlDbType.Int).Value = TextBoxDNI.Text

        Dim nuevohash = Interfaz.HashGen(TextBoxNombreUsuario.Text, TextBoxDNI.Text)
        updateUsuario.Parameters.Add("@pass", SqlDbType.VarChar, 255).Value = nuevohash

        If PictureBox.ImageLocation = "" Then
            'paso null al parámetro de la foto si no se agregó una foto
            updateUsuario.Parameters.Add("@foto", SqlDbType.Image).Value = DBNull.Value
        Else
            Dim fs As FileStream = New FileStream(direccionFoto, FileMode.Open, FileAccess.Read)
            Dim br As BinaryReader = New BinaryReader(fs)
            Dim asInt As Integer = fs.Length
            Dim imagenU(asInt) As Byte
            imagenU = br.ReadBytes(asInt)
            updateUsuario.Parameters.Add("@foto", SqlDbType.Image).Value = imagenU
        End If

        Try
            con.Open()
            updateUsuario.ExecuteNonQuery()
            con.Close()
            MsgBox("Datos guardados exitosamente", MsgBoxStyle.Information)
            DesabilitarCampos()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ButtonresetContraseña_Click(sender As Object, e As EventArgs) Handles ButtonresetContraseña.Click
        'RESETEA LA CONTRASEÑA. ES INDEPENDIENTE DE OTROS CAMBIOS
        'SE PUEDE RESETEAR SIN PRESIONAR 'MODIFICAR DATOS'
        Try
            Dim nuevohash = Interfaz.HashGen(TextBoxNombreUsuario.Text, TextBoxDNI.Text)

            Dim actualizarContraseña As New SqlCommand("UpdateContraseñaUsuario", con)
            actualizarContraseña.CommandType = CommandType.StoredProcedure
            actualizarContraseña.Parameters.Add("@nombreU", SqlDbType.VarChar, 100).Value = TextBoxNombreUsuario.Text
            actualizarContraseña.Parameters.Add("@pass", SqlDbType.VarChar, 255).Value = nuevohash
            actualizarContraseña.Parameters.Add("@cambiarPass", SqlDbType.VarChar, 2).Value = "si"

            con.Open()
            actualizarContraseña.ExecuteNonQuery()
            con.Close()

            MsgBox("La contraseña del usuario ahora es su DNI. Deberá cambiarla en el próximo inicio de sesión.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ButtonExaminarFoto_Click(sender As Object, e As EventArgs) Handles ButtonExaminarFoto.Click
        Try
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.Title = "Elija la imagen del usuario"
            OpenFileDialog1.Filter = "PNG Files (*.png) | *.png|JPG (*.jpg) | *.jpg"
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                direccionFoto = OpenFileDialog1.FileName.ToString()
                PictureBox.ImageLocation = direccionFoto
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonAgregarComision_Click(sender As Object, e As EventArgs) Handles ButtonAgregarComision.Click
        Dim frm As AgregarPerfilUsuario = New AgregarPerfilUsuario()
        frm.ShowDialog()
    End Sub

    Private Sub DataGridViewPerfilesXUsuario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPerfilesXUsuario.CellContentClick
        'obtengo fila+columna para saber si se hizo click sobre el botón y no otra celda del datagrid
        Dim columna As Integer = e.ColumnIndex
        Dim fila As Integer = e.RowIndex

        If columna = 0 Then
            If fila > -1 Then
                If MsgBox("¿Está seguro que desea eliminar el perfil seleccionado?", MessageBoxButtons.OKCancel) = MsgBoxResult.Ok Then
                    Dim eliminarPerfil As New SqlCommand("EliminarPerfilUsuario", con)
                    eliminarPerfil.CommandType = CommandType.StoredProcedure
                    eliminarPerfil.Parameters.Add("@legajo", SqlDbType.VarChar, 10).Value = Usuarios.legajoSeleccionado
                    eliminarPerfil.Parameters.Add("@tipo", SqlDbType.VarChar, 255).Value = DataGridViewPerfilesXUsuario.CurrentRow.Cells(1).Value
                    eliminarPerfil.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = DataGridViewPerfilesXUsuario.CurrentRow.Cells(2).Value
                    eliminarPerfil.Parameters.Add("@catedra", SqlDbType.VarChar, 255).Value = DataGridViewPerfilesXUsuario.CurrentRow.Cells(3).Value

                    Try
                        con.Open()
                        eliminarPerfil.ExecuteNonQuery()
                        con.Close()
                        MsgBox("El usuario fue eliminado exitosamente.", MsgBoxStyle.Information)
                        LoadDataGrid()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                    End Try
                Else
                    MsgBox("El perfil no fue eliminado.", MessageBoxButtons.OK, MsgBoxStyle.Information)
                End If
            End If
        End If
    End Sub
End Class