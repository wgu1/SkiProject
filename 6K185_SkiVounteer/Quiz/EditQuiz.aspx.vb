Imports System.Data.SqlClient
Partial Class Quiz_EditQuiz
    Inherits System.Web.UI.Page

    Private answer(0 To 3) As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim sql As String
        Dim dr As SqlDataReader
        Dim strConnectionString As String
        Dim objCommand As SqlCommand
        Dim index As Integer
        index = 0


        strConnectionString = ConfigurationManager.ConnectionStrings("fk185_ClassConnectionString").ConnectionString
        Dim sqlConn As New SqlConnection(strConnectionString)
        sql = "select AnswerContent, QuestionContent from(SELECT skiQ.[QuestionCode], skiT.[QuestionType], skiQ.[QuestionContent], skiQ.[CurrentlyUse],SkiA.[Answer], skiA.[AnswerContent] FROM [Ski_Questions] skiq inner join [Ski_Question_Type] skit on skiq.QuestionTypeID = skit.QuestionTypeID inner join [Ski_Answers] SkiA on SkiA.QuestionID = SkiQ.QuestionID where SkiQ.QuestionCode" & ID

        objCommand = New SqlCommand(sql, sqlConn)
        sqlConn.Open()
        dr = objCommand.ExecuteReader()
        While dr.Read
            answer(index) = dr("AnswerContent")
            index = index + 1
        End While
        dr.Close()
        sqlConn.Close()
    End Sub



    Public Function TheContent(index As Integer) As String
        Return answer(index)
    End Function
End Class
