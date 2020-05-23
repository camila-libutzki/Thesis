Imports System.Data.SqlClient
Public Class AltaCatedraComision
    Dim idAula As String = Aulas.idAulaSeleccionada
    Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)

    Private Sub AltaCatedraComision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        ComboBoxCarrera.SelectedIndex = 0
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        con.Close()
        Me.Close()
    End Sub

    Private Sub ButtonDardeAlta_Click(sender As Object, e As EventArgs) Handles ButtonDardeAlta.Click
        Dim aulaExiste As String = ""
        Dim idMat As String = ""

        'obtener el id de una materia si existe en el aula
        Dim existeMatCom As New SqlCommand("ExisteMatComPorAula", con)
        existeMatCom.CommandType = CommandType.StoredProcedure
        existeMatCom.Parameters.Add("@aula", SqlDbType.SmallInt).Value = idAula
        existeMatCom.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxCarrera.Text
        existeMatCom.Parameters.Add("@nombre", SqlDbType.VarChar, 255).Value = ComboBoxCatedra.Text
        existeMatCom.Parameters.Add("@comision", SqlDbType.SmallInt).Value = ComboBoxComision.Text

        'obtener el id de la materia segun otros parametros
        Dim buscarIdMateria As New SqlCommand("GetIdMateriaDeMateria", con)
        buscarIdMateria.CommandType = CommandType.StoredProcedure
        buscarIdMateria.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxCarrera.Text
        buscarIdMateria.Parameters.Add("@nombre", SqlDbType.VarChar, 255).Value = ComboBoxCatedra.Text
        buscarIdMateria.Parameters.Add("@comision", SqlDbType.SmallInt).Value = ComboBoxComision.Text

        Try
            aulaExiste = existeMatCom.ExecuteScalar()

            '##### SI LA CAT+COM NO EXISTE PARA EL AULA LO DA DE ALTA
            If aulaExiste = "" Then
                Try
                    idMat = buscarIdMateria.ExecuteScalar()

                    'dar de alta una catedra+comision en el aula
                    Dim altaCatCom As New SqlCommand("AltaMatComPorAula", con)
                    altaCatCom.CommandType = CommandType.StoredProcedure
                    altaCatCom.Parameters.Add("@aula", SqlDbType.SmallInt).Value = idAula
                    altaCatCom.Parameters.Add("@idMateria", SqlDbType.Int).Value = idMat
                    altaCatCom.Parameters.Add("@comision", SqlDbType.SmallInt).Value = ComboBoxComision.Text
                    altaCatCom.ExecuteNonQuery()

                    MsgBox("Alta de Cátedra+Comisión generada correctamente", MsgBoxStyle.Information)
                    con.Close()
                    Me.Close()
                    Interfaz.RecargarDataGrid()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                End Try
            Else
                MsgBox("No se puede dar de alta. La Cátedra+Comisión de la Carrera ya existe en el aula.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ComboBoxCarrera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCarrera.SelectedIndexChanged
        ComboBoxCatedra.Items.Clear()
        Dim cargarMaterias As New SqlCommand("GetMateriasPorCarrera", con)
        cargarMaterias.CommandType = CommandType.StoredProcedure
        cargarMaterias.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxCarrera.Text

        Try
            Dim dt As New DataTable
            dt.Load(cargarMaterias.ExecuteReader)
            For Each Fila As DataRow In dt.Rows
                ComboBoxCatedra.Items.Add(Fila.Item(0))
            Next
            If cargarMaterias.ExecuteScalar() <> "" Then
                ComboBoxCatedra.SelectedIndex() = 0
            Else
                ComboBoxComision.Items.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub ComboBoxCatedra1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCatedra.SelectedIndexChanged
        ComboBoxComision.Items.Clear()

        Dim cargarComisiones As New SqlCommand("GetComisionesPorMateriaYCarrera", con)
        cargarComisiones.CommandType = CommandType.StoredProcedure
        cargarComisiones.Parameters.Add("@carrera", SqlDbType.VarChar, 255).Value = ComboBoxCarrera.Text
        cargarComisiones.Parameters.Add("@materia", SqlDbType.VarChar, 255).Value = ComboBoxCatedra.Text

        Try
            Dim strComision As String = ""
            Dim dt As New DataTable
            dt.Load(cargarComisiones.ExecuteReader)

            For Each Fila As DataRow In dt.Rows
                strComision = Fila.Item(0).ToString()
                ComboBoxComision.Items.Add(strComision)
            Next
            ComboBoxComision.SelectedIndex() = 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class