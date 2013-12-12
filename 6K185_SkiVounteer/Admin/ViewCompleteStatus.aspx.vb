
Partial Class Admin_ViewCompleteStatus
    Inherits System.Web.UI.Page



    Protected Sub searchStatusButton_Click(sender As Object, e As EventArgs) Handles searchStatusButton.Click
        hiddenSneakySearchLabel.Text = searchStatusTextbox.Text
    End Sub

    Protected Sub cleanStatusButton_Click(sender As Object, e As EventArgs) Handles cleanStatusButton.Click
        hiddenSneakySearchLabel.Text = " "
        searchStatusTextbox.Text = " "
        CommunitteeDropDownList.SelectedIndex = -1
        CompleteStatusDropdownlist.SelectedIndex = -1
    End Sub
End Class
