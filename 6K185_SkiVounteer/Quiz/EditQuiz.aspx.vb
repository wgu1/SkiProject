Imports System.Data.SqlClient
Partial Class Quiz_EditQuiz
    Inherits System.Web.UI.Page

    Private answer(0 To 3) As String
    Private question As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim dr As SqlDataReader
        Dim strConnectionString As String
        Dim objCommand As New SqlCommand
        Dim index As Integer
        Dim questionContent As String : questionContent = ""
        Dim questionTextbox As TextBox = EditFormView.FindControl("qContentTextbox")
        Dim answer1Textbox As TextBox = EditFormView.FindControl("ASWContentTextbox1")
        Dim answer2Textbox As TextBox = EditFormView.FindControl("ASWContentTextbox2")
        Dim answer3Textbox As TextBox = EditFormView.FindControl("ASWContentTextbox3")
        Dim answer4Textbox As TextBox = EditFormView.FindControl("ASWContentTextbox4")

        index = 0
        Dim questionID As String

        questionID = Right(Request.RawUrl, 3)


        strConnectionString = ConfigurationManager.ConnectionStrings("fk185_ClassConnectionString").ConnectionString
        Dim sqlConn As New SqlConnection(strConnectionString)
        sqlConn.Open()

        With objCommand
            .Connection = sqlConn
            .CommandType = Data.CommandType.StoredProcedure
            .Parameters.AddWithValue("@id", questionID)
            .CommandText = "Ski_PullingQuizByQuestionID"

        End With


        dr = objCommand.ExecuteReader

        While dr.Read
            answer(index) = dr("AnswerContent")
            If questionContent = "" Then questionContent = dr("QuestionContent").ToString()
            index = index + 1
        End While
        dr.Close()
        sqlConn.Close()

        ''assign the value to the question Textbox
        questionTextbox.Text = questionContent
        If index = 2 Then
            answer1Textbox.Text = answer(0)
            answer2Textbox.Text = answer(1)
            answer3Textbox.Visible = False
            answer4Textbox.Visible = False
        ElseIf index = 4 Then
            answer1Textbox.Text = answer(0)
            answer2Textbox.Text = answer(1)
            answer3Textbox.Text = answer(2)
            answer4Textbox.Text = answer(3)
        End If


    End Sub


End Class
