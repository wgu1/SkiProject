
Partial Class Quiz_AddNewQuiz
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        ''when the page is first load
        If (IsPostBack = False) Then
            QuestionFormView.Visible = False
            AnswerFormView.Visible = False
        End If
    End Sub

    Protected Sub questionTypeDropDownList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles questionTypeDropDownList.SelectedIndexChanged
        ''find the answer dropdownlist
        Dim _answerDropdown As New DropDownList
        _answerDropdown = QuestionFormView.FindControl("answerDropDownList")
        _answerDropdown.Items.Clear() ''clean all the items
        If questionTypeDropDownList.SelectedValue = "1" Then  ''true/false
            QuestionFormView.Visible = True
            AnswerFormView.Visible = False
            ''add items
            _answerDropdown.Items.Add(New ListItem("1", "1"))
            _answerDropdown.Items.Add(New ListItem("2", "2"))
        ElseIf questionTypeDropDownList.SelectedValue = "2" Then '' this is the multiple choices
            QuestionFormView.Visible = True
            AnswerFormView.Visible = True
        Else
            QuestionFormView.Visible = False
            AnswerFormView.Visible = False

        End If
    End Sub
End Class
