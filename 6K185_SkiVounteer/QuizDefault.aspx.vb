Imports System.Data.SqlClient
Imports System.Data
Partial Class Quiz_Default
    Inherits System.Web.UI.Page

    Protected Sub emailSubmitBtn_Click(sender As Object, e As EventArgs) Handles emailSubmitBtn.Click
        'clean the label
        messageLb.Text = ""
        messageLb.BackColor = Drawing.Color.White
        'hide everything
        StartQuizBtn.Visible = False
        committeeListBox.Visible = False
        'make sure the page is validated        
        If (Page.IsValid) Then
            Dim conStr As New SqlConnection(ConfigurationManager.ConnectionStrings("fk185_ClassConnectionString").ConnectionString)
            Dim cmd As SqlCommand = New SqlCommand
            Dim dataReader As SqlDataReader
            Dim values As ArrayList = New ArrayList()
            Dim ct As Integer = 0 'this will be used as a count 

            With cmd
                .Connection = conStr
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Ski_Email_Select_Committee"
                .Parameters.AddWithValue("@email", emailTextBox.Text.ToString())
            End With
            conStr.Open()
            dataReader = cmd.ExecuteReader

            If dataReader.HasRows Then 'if the e-mail has the commitee ties back

                While dataReader.Read()
                    If dataReader.Item("CommitteeName").ToString() <> "All Finished" Then
                        'when users do not complete his/her quiz, the committee will show
                        values.Add(dataReader.Item("CommitteeName").ToString())
                    Else
                        'when user already complete the quiz
                        messageLb.Font.Bold = True
                        messageLb.Text = "You already finished your quiz"
                        messageLb.BackColor = Drawing.Color.Red
                        Exit Sub
                    End If
                    committeeListBox.Visible = True
                    committeeListBox.DataSource = values
                    committeeListBox.DataBind()
                    StartQuizBtn.Visible = True
                End While
            Else 'this e-mail does not have committees tie to it
                messageLb.Font.Bold = True
                messageLb.Text = "Please Provide a valid e-mail address"
                messageLb.BackColor = Drawing.Color.Red
            End If
        End If
    End Sub

    Protected Sub StartQuizBtn_Click(sender As Object, e As EventArgs) Handles StartQuizBtn.Click
        'has items
        Session("Email") = emailTextBox.Text.ToString()
        If committeeListBox.SelectedIndex >= 0 Then
            If Session("CommittName") Is Nothing Then Session("CommittName") = committeeListBox.SelectedValue
            Response.Redirect("Quiz.aspx")
        Else
            messageLb.Font.Bold = True
            messageLb.Text = "Please select a committee to continue"
            messageLb.BackColor = Drawing.Color.Red
        End If
    End Sub
End Class
