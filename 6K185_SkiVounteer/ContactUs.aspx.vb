Imports System.Net.Mail

Partial Class ContactUs
    Inherits System.Web.UI.Page
    Sub SendSimpleMail()

        Dim Message As New System.Net.Mail.MailMessage()
        Message.To.Add("6k185skivolunteersystemalert@gmail.com")
        Message.CC.Add(EmailTextBox.Text.Trim)
        Message.Subject = SubjectTextBox.Text.Trim
        Message.Body = MessageTextBox.Text.Trim
        '"From: " & EmailTextBox.Text.Trim & vbCrLf & "Message: " & 
        Dim client As New SmtpClient()
        client.EnableSsl = client.Port = 587 Or client.Port = 465

        Try
            client.Send(Message)
        Catch ex As Exception
            ' ...
        End Try

    End Sub

    Protected Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Call SendSimpleMail()
        Response.Redirect("~/Default.aspx")
    End Sub
End Class
