Imports System.Data.SqlClient
Imports System.Data
Partial Class Quiz_FinishQuizConfirm
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        

        'set the user's complete status
        Dim conStr As New SqlConnection(ConfigurationManager.ConnectionStrings("fk185_ClassConnectionString").ConnectionString)
        Dim cmd As SqlCommand = New SqlCommand

        With cmd
            .Connection = conStr
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Ski_change_complete_status_after_quiz_completion"
            .Parameters.AddWithValue("@committeeName", Session("CommittName"))
            .Parameters.AddWithValue("@email", Session("Email"))
        End With
        conStr.Open()
        ''excuete the query
        cmd.ExecuteNonQuery()

        'clean the session variable
        Session("CommittName") = Nothing
        Session("Email") = Nothing

        'redirect to QuizDefault page 
        Response.AddHeader("REFRESH", "5;URL=QuizDefault.aspx")
    End Sub


End Class
