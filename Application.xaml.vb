Imports System.Text
Imports Microsoft.AppCenter
Imports Microsoft.AppCenter.Analytics
Imports Microsoft.AppCenter.Crashes
Class Application
    Inherits System.Windows.Application
    Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
        MyBase.OnStartup(e)

        AppCenter.LogLevel = LogLevel.Verbose
        AppCenter.Start("b11df179-5b62-45a9-afc2-311e0ffed838", GetType(Analytics), GetType(Crashes))
        AppCenter.SetUserId("mskasani@VBwpf")
        Crashes.GetErrorAttachments = Function(ByVal report As ErrorReport) New ErrorAttachmentLog() {ErrorAttachmentLog.AttachmentWithText("<!DOCTYPE html><html><body><h2>HTML Links</h2><p><a href=""https://www.w3schools.com/html/"">VB Visit our HTML tutorial</a></p></body></html>", "data.html"), ErrorAttachmentLog.AttachmentWithBinary(Encoding.UTF8.GetBytes("VB Fake image"), "fake_image.jpeg", "image/jpeg")}
    End Sub
End Class
