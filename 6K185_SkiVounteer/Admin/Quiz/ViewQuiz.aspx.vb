Imports System.Data.Sql
Imports System.Data.SqlClient
Partial Class Quiz_ViewQuiz
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub AddQuestion_Click(sender As Object, e As EventArgs) Handles AddQuestion.Click
        Response.Redirect(Page.ResolveClientUrl("AddNewQuiz.aspx"))
    End Sub
End Class
