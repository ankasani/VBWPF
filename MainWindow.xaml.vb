Imports System.IO
Imports Microsoft.AppCenter.Analytics
Imports Microsoft.AppCenter.Crashes


Class MainWindow
    Inherits Window

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Crashes.GenerateTestCrash()
    End Sub

    Private Sub Button_Click_1(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Analytics.TrackEvent("VB Time event", New Dictionary(Of String, String) From {
            {"Time", DateTime.Now.ToString()}
        })
    End Sub

    Private Sub Button_Click_2(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Try

            Using reader As StreamReader = New StreamReader("not-there.txt")
                reader.ReadToEnd()
            End Using

        Catch ex As FileNotFoundException
            Crashes.TrackError(ex)
        End Try
    End Sub

End Class
