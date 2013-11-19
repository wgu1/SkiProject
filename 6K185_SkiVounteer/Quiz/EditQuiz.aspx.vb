Imports System.Data.SqlClient
Partial Class Quiz_EditQuiz
    Inherits System.Web.UI.Page

    Private answer(0 To 3) As String
    Private question As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim sql As String
        Dim dr As SqlDataReader
        Dim strConnectionString As String
        Dim objCommand As SqlCommand
        Dim index As Integer
        Dim questionTextbox As TextBox = EditFormView.FindControl("tbQuestion")

        index = 0
        Dim questionID As String

        questionID = Right(Request.RawUrl, 3)


        strConnectionString = ConfigurationManager.ConnectionStrings("fk185_ClassConnectionString").ConnectionString
        Dim sqlConn As New SqlConnection(strConnectionString)
        sql = "select AnswerContent, QuestionContent from(SELECT skiQ.[QuestionCode], skiT.[QuestionType], skiQ.[QuestionContent], skiQ.[CurrentlyUse],SkiA.[Answer], skiA.[AnswerContent] FROM [Ski_Questions] skiq inner join [Ski_Question_Type] skit on skiq.QuestionTypeID = skit.QuestionTypeID inner join [Ski_Answers] SkiA on SkiA.QuestionID = SkiQ.QuestionID where SkiQ.QuestionCode = '" & questionID & "'"

        objCommand = New SqlCommand(sql, sqlConn)
        sqlConn.Open()
        dr = objCommand.ExecuteReader()
        While dr.Read
            answer(index) = dr("AnswerContent")
            questionTextbox.Text = dr("QuestionContent")
            index = index + 1
        End While
        dr.Close()
        sqlConn.Close()

    End Sub


End Class
