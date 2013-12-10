Imports System.Data.SqlClient
Partial Class Quiz_EditQuiz
    Inherits System.Web.UI.Page

    Private answer(0 To 3) As String
    Private question As String
    Private QuestionCode As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
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
            Dim correctAnswerTextbox As TextBox = EditFormView.FindControl("correctASWTextbox")

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
            Dim sql As String

            sql = "Select QAnswer, CurrentlyUse From Ski_Questions where QuestionCode = @QuestionCode"
            objCommand = New SqlCommand(sql, sqlConn)
            objCommand.Parameters.AddWithValue("@QuestionCode", QuestionCode)
            dr = objCommand.ExecuteReader
            While dr.Read
                correctAnswerTextbox.Text = dr("QAnswer")
                If dr("CurrentlyUse") = "Y" Then
                    useCheckbox.Checked = True
                Else
                    useCheckbox.Checked = False
                End If
            End While
            dr.Close()
            sqlConn.Close()
        End If
    End Sub
    Protected Sub EditFormView_ItemCommand(sender As Object, e As FormViewCommandEventArgs) Handles EditFormView.ItemCommand
        If e.CommandName = "cancel" Then
            'redirect to view quiz page
            Response.Redirect("~/Admin/Quiz/ViewQuiz.aspx")

        ElseIf e.CommandName = "update" Then

            Dim strConnectionString As String
            Dim objCommand As SqlCommand
            Dim sql As String
            Dim sql_1 As String 'for update question content, correct answer and current used
            Dim dr As SqlDataReader
            Dim questionID As Guid
            Dim currentUse As String
            Dim sqlSource As New SqlDataSource()

            QuestionCode = Right(Request.RawUrl, 3)

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
            sqlConn.Open()
            dr = objCommand.ExecuteReader()
            While dr.Read
                questionID = dr("QuestionID")
            End While
            dr.Close()
            sqlConn.Close()




            ''update question content, correct answer and current used
            sql_1 = "Update Ski_Questions Set QuestionContent = @QuesitonContent, QAnswer = @QAswer, CurrentlyUse = @CurrentlyUse where QuestionCode = @QuestionCode"
            objCommand = New SqlCommand(sql_1, sqlConn)
            objCommand.Parameters.AddWithValue("@QuestionCode", QuestionCode)
            objCommand.Parameters.AddWithValue("@QuesitonContent", questionTextbox.Text)
            objCommand.Parameters.AddWithValue("@QAswer", correctASWTextbox.Text)
            objCommand.Parameters.AddWithValue("@CurrentlyUse", currentUse)
            sqlConn.Open()
            objCommand.ExecuteNonQuery()
            sqlConn.Close()

            'sql about updating
            sql = "Update Ski_Answers Set AnswerContent=@Answer where QuestionID = @QuestionID AND AnswerOrder = @AnswerOrder"
            'find control
            Dim answer1Textbox As TextBox = EditFormView.FindControl("ASWContentTextbox1")
            Dim answer2Textbox As TextBox = EditFormView.FindControl("ASWContentTextbox2")
            Dim answer3Textbox As TextBox = EditFormView.FindControl("ASWContentTextbox3")
            Dim answer4Textbox As TextBox = EditFormView.FindControl("ASWContentTextbox4")
            'for multi-choice update (no update for T/F)
            If answer3Textbox.Visible = True Then
                objCommand = New SqlCommand(sql, sqlConn)
                sqlConn.Open()
                objCommand.Parameters.AddWithValue("@QuestionID", questionID)
                objCommand.Parameters.AddWithValue("@AnswerOrder", "1")
                objCommand.Parameters.AddWithValue("@Answer", answer1Textbox.Text)
                objCommand.ExecuteNonQuery()

                objCommand.Parameters.Clear()
                objCommand.Parameters.AddWithValue("@QuestionID", questionID)
                objCommand.Parameters.AddWithValue("@AnswerOrder", "2")
                objCommand.Parameters.AddWithValue("@Answer", answer2Textbox.Text)
                objCommand.ExecuteNonQuery()

                objCommand.Parameters.Clear()
                objCommand.Parameters.AddWithValue("@QuestionID", questionID)
                objCommand.Parameters.AddWithValue("@AnswerOrder", "3")
                objCommand.Parameters.AddWithValue("@Answer", answer3Textbox.Text)
                objCommand.ExecuteNonQuery()

                objCommand.Parameters.Clear()
                objCommand.Parameters.AddWithValue("@QuestionID", questionID)
                objCommand.Parameters.AddWithValue("@AnswerOrder", "3")
                objCommand.Parameters.AddWithValue("@Answer", answer3Textbox.Text)
                objCommand.ExecuteNonQuery()

                sqlConn.Close()

            End If

            'redirect to view quiz page
            Response.Redirect("~/Admin/Quiz/ViewQuiz.aspx")
        End If


    End Sub

End Class