
Partial Class Account_Login
    Inherits System.Web.UI.Page



    Protected Sub LoginButton_Click(sender As Object, e As EventArgs)
        Response.Redirect(Page.ResolveClientUrl("../Admin/AdminHomePage.aspx"))
    End Sub
End Class