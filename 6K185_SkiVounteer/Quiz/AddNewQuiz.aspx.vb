
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

    End Sub
End Class
