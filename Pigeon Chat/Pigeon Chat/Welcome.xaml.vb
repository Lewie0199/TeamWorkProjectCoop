Public Class Window1

    Public username As String



    Private Sub WelcomeWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles WelcomeWindow.Loaded
        lblName.Content = "Welcome " & username
    End Sub
End Class
