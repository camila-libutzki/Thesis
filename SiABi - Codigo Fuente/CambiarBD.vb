Public Class CambiarBD
    Private Sub CambiarBD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Interfaz.botonVolver.Visible = True
        Interfaz.botonVolver.Enabled = True

        TextBoxServerDB.Text = My.Settings.ServerDB
        TextBoxDatabaseDB.Text = My.Settings.DatabaseDB
        TextBoxUserDB.Text = My.Settings.UserDB
        TextBoxPasswordDB.Text = My.Settings.PassDB
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.ServerDB = TextBoxServerDB.Text
        My.Settings.DatabaseDB = TextBoxDatabaseDB.Text
        My.Settings.UserDB = TextBoxUserDB.Text
        My.Settings.PassDB = TextBoxPasswordDB.Text
        My.Settings.Save()
        Interfaz.conexionDBactual.ConnectionString = "Data Source = " + TextBoxServerDB.Text + ";Initial Catalog=" + TextBoxDatabaseDB.Text + ";User ID=" + TextBoxUserDB.Text + ";Password=" + TextBoxPasswordDB.Text + ";ConnectRetryCount=3;ConnectRetryInterval=3"
        MsgBox("Conexion a la base de datos actualizada.", MsgBoxStyle.Information)

        For Each f As Form In Interfaz.MdiChildren
            f.Close()
        Next

        Dim frm As Login = New Login()
        frm.MdiParent = Interfaz
        frm.Show()

        Application.Restart()
    End Sub

    Private Sub ButtonDBcami_Click(sender As Object, e As EventArgs) Handles ButtonDBcami.Click
        My.Settings.ServerDB = "DESKTOP-O2B4705\SQLEXPRESS"
        My.Settings.DatabaseDB = "siabiDB"
        My.Settings.UserDB = "siabiadmin"
        My.Settings.PassDB = "siabi2017"
        My.Settings.Save()
        Interfaz.conexionDBactual.ConnectionString = "Data Source = " + TextBoxServerDB.Text + ";Initial Catalog=" + TextBoxDatabaseDB.Text + ";User ID=" + TextBoxUserDB.Text + ";Password=" + TextBoxPasswordDB.Text + ";ConnectRetryCount=3;ConnectRetryInterval=3"
        MsgBox("Conexion a la base de datos actualizada.", MsgBoxStyle.Information)

        For Each f As Form In Interfaz.MdiChildren
            f.Close()
        Next

        Dim frm As Login = New Login()
        frm.MdiParent = Interfaz
        frm.Show()

        Application.Restart()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.ServerDB = "Lenovo-F\SQLEXPRESSLENOVO"
        My.Settings.DatabaseDB = "siabiDB"
        My.Settings.UserDB = "siabiadmin"
        My.Settings.PassDB = "siabi2017"
        My.Settings.Save()
        Interfaz.conexionDBactual.ConnectionString = "Data Source = " + TextBoxServerDB.Text + ";Initial Catalog=" + TextBoxDatabaseDB.Text + ";User ID=" + TextBoxUserDB.Text + ";Password=" + TextBoxPasswordDB.Text + ";ConnectRetryCount=3;ConnectRetryInterval=3"
        MsgBox("Conexion a la base de datos actualizada.", MsgBoxStyle.Information)

        For Each f As Form In Interfaz.MdiChildren
            f.Close()
        Next

        Dim frm As Login = New Login()
        frm.MdiParent = Interfaz
        frm.Show()

        Application.Restart()
    End Sub
End Class