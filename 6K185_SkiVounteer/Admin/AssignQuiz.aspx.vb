Imports System.Data.SqlClient
Imports System.Data
Partial Class Admin_AssignQuiz
    Inherits System.Web.UI.Page


    'Protected Sub CommunitteeDropDownList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CommunitteeDropDownList.SelectedIndexChanged
    '    Dim conStr As New SqlConnection(ConfigurationManager.ConnectionStrings("fk185_ClassConnectionString").ConnectionString)
    '    Dim cmd As SqlCommand = New SqlCommand
    '    Dim dr As SqlDataReader
    '    With cmd
    '        .Connection = conStr
    '        .CommandType = CommandType.StoredProcedure
    '        .CommandText = "Ski_Select_Committe"
    '        .Parameters.AddWithValue("@QuestionType", CommunitteeDropDownList.SelectedValue)
    '    End With
    '    dr = cmd.ExecuteReader

    '    currentQListbox.DataSource = dr
    '    currentQListbox.DataTextField = "question"
    '    currentQListbox.DataValueField = "QuestionID"
    '    currentQListbox.DataBind()
    'End Sub
End Class
