' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409
Imports Windows.UI.Popups
''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Private Async Sub btnHelloWorld_Click(sender As Object, e As RoutedEventArgs)
        txtHelloWorld.Text = "Windows Universal App, Hello World."
        Dim message As MessageDialog = New MessageDialog("Windows Universal App with Vb, Like it ? ")
        message.Title = "Hello World"
        message.Commands.Add(New UICommand("Yes"))
        message.Commands.Add(New UICommand("No"))

        Dim result = Await message.ShowAsync()
        If result.Label = "Yes" Then
            Dim msg As MessageDialog = New MessageDialog("Thank you very much :) ")
            msg.Title = "Thanks"
            msg.Commands.Add(New UICommand("Ok"))
            Await msg.ShowAsync()
        End If
    End Sub
End Class
