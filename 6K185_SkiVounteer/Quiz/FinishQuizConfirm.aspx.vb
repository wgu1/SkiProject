
Partial Class Quiz_FinishQuizConfirm
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        'clean the session variable
        Session("CommittName") = Nothing

        'set the user's complete status
    End Sub
End Class
