
Partial Class Admin_updateFAQ
    Inherits System.Web.UI.Page

    Protected Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        lbAnswer.Visible = True
        lbQuestion.Visible = True
        btAdd.Visible = False
        btInsert.Visible = True
        tbNewA.Visible = True
        tbNewQ.Visible = True
        btCancel.Visible = True

    End Sub

    Protected Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        lbAnswer.Visible = False
        lbQuestion.Visible = False
        btAdd.Visible = True
        btInsert.Visible = False
        tbNewA.Visible = False
        tbNewQ.Visible = False
        tbNewA.Text = ""
        tbNewQ.Text = ""
        btCancel.Visible = False
    End Sub
End Class
