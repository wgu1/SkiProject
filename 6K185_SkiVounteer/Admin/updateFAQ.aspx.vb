Imports System.Data.SqlClient

Partial Class Admin_updateFAQ
    Inherits System.Web.UI.Page

    Protected Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        lbAnswer.Visible = True
        lbQuestion.Visible = True
        btAdd.Visible = False
        btInsert.Visible = True
        tbNewA.Visible = True
        tbNewQ.Visible = True
        btCancel.Visible = True

    End Sub

    Protected Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        lbAnswer.Visible = False
        lbQuestion.Visible = False
        btAdd.Visible = True
        btInsert.Visible = False
        tbNewA.Visible = False
        tbNewQ.Visible = False
        tbNewA.Text = ""
        tbNewQ.Text = ""
        btCancel.Visible = False
    End Sub

    Protected Sub btInsert_Click(sender As Object, e As EventArgs) Handles btInsert.Click
        Dim id As Integer
        Dim question As String
        Dim answer As String
        Dim sql As String
        Dim dr As SqlDataReader

        question = tbNewQ.Text
        answer = tbNewA.Text

        Dim strConnectionString As String
        Dim objCommand As SqlCommand
        strConnectionString = ConfigurationManager.ConnectionStrings("fk185_ClassConnectionString").ConnectionString
        Dim sqlConn As New SqlConnection(strConnectionString)
        sql = "SELECT COUNT(*) FROM Ski_FAQ"
        objCommand = New SqlCommand(sql, sqlConn)
        sqlConn.Open()

        dr = objCommand.ExecuteReader()
        dr.Read()
        id = Int(dr(0))
        id = id + 1
        dr.Close()

        sql = "INSERT INTO Ski_FAQ(ID, Question, Answer) VALUES (@ID,@Question,@Answer)"
        objCommand = New SqlCommand(sql, sqlConn)
        objCommand.Parameters.AddWithValue("@ID", id)
        objCommand.Parameters.AddWithValue("@Question", question)
        objCommand.Parameters.AddWithValue("@Answer", answer)

        objCommand.ExecuteNonQuery()
        
        sqlConn.Close()
        MsgBox("New question has been successfully insert!", , "Complete")

        Response.Redirect("~\Admin\updateFAQ.aspx")


    End Sub
End Class
