Imports System.Data.SqlClient
Public Class Tolerancia
    Dim con As New SqlConnection(Interfaz.conexionDBactual.ConnectionString)
    Private Sub Tolerancia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        margenEntrada.SelectionAlignment = HorizontalAlignment.Center
        toleranciaEntrada.SelectionAlignment = HorizontalAlignment.Center
        margenSalida.SelectionAlignment = HorizontalAlignment.Center

        Dim getAntesEntrada As New SqlCommand("GetAntesETolerancia", con)
        getAntesEntrada.CommandType = CommandType.StoredProcedure
        Dim getDespuesEntrada As New SqlCommand("GetDespuesETolerancia", con)
        getDespuesEntrada.CommandType = CommandType.StoredProcedure
        Dim getDespuesSalida As New SqlCommand("GetDespuesSTolerancia", con)
        getDespuesSalida.CommandType = CommandType.StoredProcedure

        Try
            con.Open()
            ComboBoxMargen.Text = getAntesEntrada.ExecuteScalar().ToString()
            ComboBoxTolerancia.Text = getDespuesEntrada.ExecuteScalar().ToString()
            ComboBoxSalida.Text = getDespuesSalida.ExecuteScalar().ToString()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub ButtonDardeAlta_Click(sender As Object, e As EventArgs) Handles ButtonDardeAlta.Click
        Dim updateTolerancias As New SqlCommand("UpdateTolerancias", con)
        updateTolerancias.CommandType = CommandType.StoredProcedure
        updateTolerancias.Parameters.Add("@antesE", SqlDbType.Int).Value = ComboBoxMargen.Text
        updateTolerancias.Parameters.Add("@despE", SqlDbType.Int).Value = ComboBoxTolerancia.Text
        updateTolerancias.Parameters.Add("@despS", SqlDbType.Int).Value = ComboBoxSalida.Text
        Try
            con.Open()
            updateTolerancias.ExecuteNonQuery()
            con.Close()
            MsgBox("Tolerancias actualizadas correctamente.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub
End Class