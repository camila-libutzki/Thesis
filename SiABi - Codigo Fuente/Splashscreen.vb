Public Class Splashscreen
    Private Sub Splashscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 4000
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Close()
        Login.Visible = True
    End Sub
End Class