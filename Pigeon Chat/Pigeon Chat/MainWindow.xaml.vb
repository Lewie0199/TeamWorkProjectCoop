Class MainWindow 

    Private Sub btnLogIn_Click(sender As Object, e As RoutedEventArgs) Handles btnLogIn.Click

        Dim formWelcome As New Window1


        formWelcome.username = txtUsername.Text.Trim

        If txtUsername.Text.Trim = "" Then
            MsgBox("Invalid Username")
        Else
            formWelcome.Show()
        End If



    End Sub


    Private Sub btnCreateCoop_Click(sender As Object, e As RoutedEventArgs) Handles btnLaunchServer.Click



    End Sub
End Class
