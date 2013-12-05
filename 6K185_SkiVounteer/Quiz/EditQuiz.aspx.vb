Imports System.Data.SqlClient
Partial Class Quiz_EditQuiz
    Inherits System.Web.UI.Page

    Private answer(0 To 3) As String
    Private question As String
    Private QuestionCode As String
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
        Dim useCheckbox As CheckBox = EditFormView.FindControl("useCheckbox")

        index = 0

        QuestionCode = Right(Request.RawUrl, 3)


        strConnectionString = ConfigurationManager.ConnectionStrings("fk185_ClassConnectionString").ConnectionString
        Dim sqlConn As New SqlConnection(strConnectionString)
        sqlConn.Open()

        With objCommand
            .Connection = sqlConn
            .CommandType = Data.CommandType.StoredProcedure
            .Parameters.AddWithValue("@id", QuestionCode)
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
            answer1Textbox.Enabled = False
            answer2Textbox.Enabled = False
            answer3Textbox.Visible = False
            answer4Textbox.Visible = False
        ElseIf index = 4 Then
            answer1Textbox.Text = answer(0)
            answer2Textbox.Text = answer(1)
            answer3Textbox.Text = answer(2)
            answer4Textbox.Text = answer(3)
        End If

        'adding current use or not and which is the current answer

    End Sub
    Protected Sub EditFormView_ItemCommand(sender As Object, e As FormViewCommandEventArgs) Handles EditFormView.ItemCommand
        If e.CommandName = "cancel" Then
            'redirect to view quiz page
            Response.Redirect("~/ViewQuiz.aspx")

        ElseIf e.CommandName = "Update" Then
            Dim strConnectionString As String
            Dim objCommand As SqlCommand
            Dim sql As String
            Dim sql_1 As String 'for update question content, correct answer and current used
            Dim dr As SqlDataReader
            Dim questionID As String
            Dim currentUse As String

            'find control
            Dim questionTextbox As TextBox = EditFormView.FindControl("qContentTextbox")
            Dim useCheckbox As CheckBox = EditFormView.FindControl("useCheckbox")
            Dim correctASWTextbox As TextBox = EditFormView.FindControl("correctASWTextbox")

            'record current user
            If useCheckbox.Checked = True Then
                currentUse = "Y"
            Else
                currentUse = "N"
            End If

            strConnectionString = ConfigurationManager.ConnectionStrings("fk185_ClassConnectionString").ConnectionString
            Dim sqlConn As New SqlConnection(strConnectionString)
            'find questionID with questionCode
            sql = "select QuestionID from Ski_Questions where QuestionCode = @QuestionCode"
            objCommand = New SqlCommand(sql, sqlConn)
            objCommand.Parameters.AddWithValue("@QuestionCode", QuestionCode)
            dr = objCommand.ExecuteReader()
            While dr.Read
                questionID = dr("QuestionID")
            End While
            dr.Close()

            'update question content, correct answer and current used
            sql_1 = "Update Ski_Questions Set QuestionContent = @QuesitonContent AND QAnswer = @QAswer AND CurrentlyUse = @CurrentlyUse where QuestionCode = @QuestionCode"
            objCommand = New SqlCommand(sql_1, sqlConn)
            objCommand.Parameters.AddWithValue("@QuestionCode", QuestionCode)
            objCommand.Parameters.AddWithValue("@QuesitonContent", questionTextbox.Text)
            objCommand.Parameters.AddWithValue("@QAswer", correctASWTextbox.Text)
            objCommand.Parameters.AddWithValue("@CurrentlyUse", currentUse)
            sqlConn.Open()
            objCommand.ExecuteNonQuery()
            sqlConn.Close()

            'sql about updating
            sql = "Update Ski_Answers Set AnswerContent = @Answer where QuestionID = @QuestionID AND AnswerOrder = @AnswerOrder"
            'find control
            Dim answer1Textbox As TextBox = EditFormView.FindControl("ASWContentTextbox1")
            Dim answer2Textbox As TextBox = EditFormView.FindControl("ASWContentTextbox2")
            Dim answer3Textbox As TextBox = EditFormView.FindControl("ASWContentTextbox3")
            Dim answer4Textbox As TextBox = EditFormView.FindControl("ASWContentTextbox4")
            'for multi-choice update (no update for T/F)
            If answer3Textbox.Visible = True Then





            End If

        End If
    End Sub

End Class
