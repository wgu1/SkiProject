Imports System.Data.SqlClient
Imports System.Data
Partial Class Quiz_AddNewQuiz
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        ''when the page is first load
        If (IsPostBack = False) Then
            QuestionFormView.Visible = False
            AnswerFormView.Visible = False
            __submitButton.Visible = False
        End If
    End Sub

    Protected Sub questionTypeDropDownList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles questionTypeDropDownList.SelectedIndexChanged
        ''find the answer dropdownlist
        Dim _answerDropdown As New DropDownList

        ''make the submit button unvisiable
        __submitButton.Visible = False
        _answerDropdown = QuestionFormView.FindControl("answerDropDownList")
        _answerDropdown.Items.Clear() ''clean all the items
        If questionTypeDropDownList.SelectedValue = "1" Then  ''true/false
            QuestionFormView.Visible = True
            AnswerFormView.Visible = False
            ''add items
            _answerDropdown.Items.Add(New ListItem("T", "1"))
            _answerDropdown.Items.Add(New ListItem("F", "2"))
            __submitButton.Visible = True
        ElseIf questionTypeDropDownList.SelectedValue = "2" Then '' this is the multiple choices
            _answerDropdown.Items.Add(New ListItem("A", "1"))
            _answerDropdown.Items.Add(New ListItem("B", "2"))
            _answerDropdown.Items.Add(New ListItem("C", "3"))
            _answerDropdown.Items.Add(New ListItem("D", "4"))
            QuestionFormView.Visible = True
            AnswerFormView.Visible = True
            __submitButton.Visible = True
        Else
            QuestionFormView.Visible = False
            AnswerFormView.Visible = False

        End If
    End Sub

    Protected Sub __submitButton_Click(sender As Object, e As EventArgs) Handles __submitButton.Click
        Dim conStr As New SqlConnection(ConfigurationManager.ConnectionStrings("fk185_ClassConnectionString").ConnectionString)
        Dim cmd As SqlCommand = New SqlCommand
        ''find control 
        Dim questionTextbox As TextBox = QuestionFormView.FindControl("qContentTextbox")
        Dim correctDrop As DropDownList = QuestionFormView.FindControl("answerDropDownList")
        Dim answer1Textbox As TextBox = AnswerFormView.FindControl("AanswerTextbox")
        Dim answer2Textbox As TextBox = AnswerFormView.FindControl("BanswerTextbox")
        Dim answer3Textbox As TextBox = AnswerFormView.FindControl("CanswerTextbox")
        Dim answer4Textbox As TextBox = AnswerFormView.FindControl("DContentTextbox")
        Dim ct As Integer = 0 'this will be used as a count 
        With cmd
            .Connection = conStr
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Ski_Insert_New_Quiz"
            .Parameters.AddWithValue("@QuestionType", questionTypeDropDownList.SelectedValue)
            .Parameters.AddWithValue("@QuestinContent", questionTextbox.Text)
            .Parameters.AddWithValue("@CorrentAnswer", correctDrop.Text)
            ''if this is multiple choice
            If questionTypeDropDownList.SelectedValue = "2" Then
                .Parameters.AddWithValue("@AnswerA", answer1Textbox.Text)
                .Parameters.AddWithValue("@AnswerB", answer2Textbox.Text)
                .Parameters.AddWithValue("@AnswerC", answer3Textbox.Text)
                .Parameters.AddWithValue("@AnswerD", answer4Textbox.Text)
            End If
        End With
        conStr.Open()
        ''excute the add function
        cmd.ExecuteNonQuery()
        ''redirect
        Response.Redirect("~\Admin\Quiz\ViewQuiz.aspx")
    End Sub
End Class
