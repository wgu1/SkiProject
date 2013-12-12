Imports System.Data.SqlClient
Partial Class Admin_Volunteer
    Inherits System.Web.UI.Page


    Protected Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim Fname As String
        Dim Lname As String
        Dim email As String
        Dim Committee As String
        Dim sql As String
        Dim strConnectionString As String
        Dim objCommand As SqlCommand

        Fname = FNameTextBox.Text.Trim
        Lname = LNameTextBox.Text.Trim
        email = EmailTextBox.Text.Trim
        Committee = CStr(ddlCommittee.SelectedValue)

        If FNameTextBox.Text = "" Then
            ResultLabel.Text = "Please enter a valid first name."
            Exit Sub
        End If
        If LNameTextBox.Text = "" Then
            ResultLabel.Text = "Please enter a valid last name."
            Exit Sub
        End If
        If EmailTextBox.Text = "" Then
            ResultLabel.Text = "Please enter a valid e-mail address."
            Exit Sub
        End If

        strConnectionString = ConfigurationManager.ConnectionStrings("fk185_ClassConnectionString").ConnectionString
        Dim sqlConn As New SqlConnection(strConnectionString)

        Try
            sql = "INSERT INTO Ski_Volunteer (Email, FirstName, LastName) Values (@email, @Fname, @Lname);"
            objCommand = New SqlCommand(sql, sqlConn)
            objCommand.Parameters.AddWithValue("@email", UCase(email))
            objCommand.Parameters.AddWithValue("@Fname", Fname)
            objCommand.Parameters.AddWithValue("@Lname", Lname)
            sqlConn.Open()
            objCommand.ExecuteNonQuery()
            sqlConn.Close()

            sql = "INSERT INTO Ski_CompletionCertificate (Email, CommitteeID) Values (@email, @CommitteeID);"
            objCommand = New SqlCommand(sql, sqlConn)
            objCommand.Parameters.AddWithValue("@email", UCase(email))
            objCommand.Parameters.AddWithValue("@CommitteeID", Committee.Trim)
            sqlConn.Open()
            objCommand.ExecuteNonQuery()
            Response.Redirect("~/Admin/Volunteer.aspx")
        Catch ex As Exception
            ResultLabel.Text = "There was a problem inserting into the database. Please verify your inputs and try again."
        End Try
    End Sub

    Protected Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim email As String
        Dim sql As String
        Dim strConnectionString As String
        Dim objCommand As SqlCommand

        email = DeleteTextBox.Text.Trim

        If DeleteTextBox.Text = "" Then
            ResultLabel2.Text = "Please enter a valid e-mail address."
            Exit Sub
        End If

        strConnectionString = ConfigurationManager.ConnectionStrings("fk185_ClassConnectionString").ConnectionString
        Dim sqlConn As New SqlConnection(strConnectionString)

        Try
            sql = "DELETE FROM Ski_CompletionCertificate WHERE email = @email;"
            objCommand = New SqlCommand(sql, sqlConn)
            objCommand.Parameters.AddWithValue("@email", UCase(email))
            sqlConn.Open()
            objCommand.ExecuteNonQuery()
            sqlConn.Close()

            sql = "DELETE FROM Ski_Volunteer WHERE email = @email;"
            objCommand = New SqlCommand(sql, sqlConn)
            objCommand.Parameters.AddWithValue("@email", UCase(email))
            sqlConn.Open()
            objCommand.ExecuteNonQuery()
            Response.Redirect("~/Admin/Volunteer.aspx")
        Catch ex As Exception
            ResultLabel2.Text = "There was a problem deleting from the database. Please verify your inputs and try again."
        End Try
    End Sub
End Class
