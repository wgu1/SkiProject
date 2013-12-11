
Partial Class Admin_ViewCompleteStatus
    Inherits System.Web.UI.Page

    Protected Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        hiddenSneakySearchLabel.Text = searchTextbox.Text
    End Sub

    Protected Sub cleanButton_Click(sender As Object, e As EventArgs) Handles cleanButton.Click
        'clean search
        hiddenSneakySearchLabel.Text = " "
        CommunitteeDropDownList.SelectedIndex = -1
        CompleteStatusDropdownlist.SelectedIndex = -1
    End Sub


End Class
