Imports System.Data.SqlClient
Imports System.Data
Partial Class Admin_AssignQuiz
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ''check session (the page is refresh when add/remove quizs from polls)
            If Session("CommitteeGuid") IsNot Nothing Then
                CommunitteeDropDownList.SelectedValue = Session("CommitteeGuid")
                ''clean the seesion
                Session("CommitteeGuid") = Nothing
            End If
        End If
    End Sub
    Protected Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        ''page value to the procedure
        If RestQListbox.SelectedIndex <> -1 Then 'if something is selected 
            Dim committeeGuid As Guid = New Guid(CommunitteeDropDownList.SelectedValue.ToString())
            Dim questionGuid As Guid = New Guid(RestQListbox.SelectedValue.ToString())
            'call the sub
            passingvalue(committeeGuid, questionGuid, "Ski_Assigned_Quiz_To_Committee_Poll")
        End If
    End Sub

    Protected Sub removeButton_Click(sender As Object, e As EventArgs) Handles removeButton.Click
        'passing value to the procedure 
        If currentQListbox.SelectedIndex <> -1 Then 'if something is selected 
            Dim committeeGuid As Guid = New Guid(CommunitteeDropDownList.SelectedValue.ToString())
            Dim questionGuid As Guid = New Guid(currentQListbox.SelectedValue.ToString())
            'call the sub
            passingvalue(committeeGuid, questionGuid, "Ski_Remove_Assigned_Quiz_From_Committee")
        End If
    End Sub
    'public function
    Public Sub passingvalue(committeeGuid As Guid, questionGuid As Guid, procedureName As String)
        Dim conStr As New SqlConnection(ConfigurationManager.ConnectionStrings("fk185_ClassConnectionString").ConnectionString)
        Dim cmd As SqlCommand = New SqlCommand

        With cmd
            .Connection = conStr
            .CommandType = CommandType.StoredProcedure
            .CommandText = procedureName
            .Parameters.Add("@committeeID", SqlDbType.UniqueIdentifier, 16).Value = committeeGuid
            .Parameters.Add("@QuestionID", SqlDbType.UniqueIdentifier, 16).Value = questionGuid
        End With
        conStr.Open()
        ''excuete the query
        cmd.ExecuteNonQuery()
        ''remember the session
        Session("CommitteeGuid") = committeeGuid.ToString()
        ''refresh the page
        Response.Redirect(Request.RawUrl)
    End Sub

    Protected Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        hiddenSearchLabel.Text = searchTextbox.Text
    End Sub
End Class
