Public Class Form1
    Dim main As New clMain()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        main.sFirstname = "Florian"
        main.iRandomNumber = 123
        main.dRandomNumber = 12.19

        Try
            BindingSource1.DataSource = main

            txtFirstName.DataBindings.Add(New Binding("Text", BindingSource1, "sFirstname", True, DataSourceUpdateMode.OnPropertyChanged))
            txtRandomNumber.DataBindings.Add(New Binding("Text", BindingSource1, "iRandomNumber", True, DataSourceUpdateMode.OnPropertyChanged))
            txtDoubleNumber.DataBindings.Add(New Binding("Text", BindingSource1, "dRandomNumber", True, DataSourceUpdateMode.OnPropertyChanged))

        Catch ex As Exception
            MessageBox.Show("Binding failed!")
        End Try
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Start()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim rnd As New Random()
        main.iRandomNumber = rnd.Next()
    End Sub
End Class
