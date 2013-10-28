Imports System.Data.SqlClient

Partial Class About_FAQ
    Inherits System.Web.UI.Page
    Private FAQContext As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim sql As String
        Dim dr As SqlDataReader
        Dim strConnectionString As String
        Dim objCommand As SqlCommand


        strConnectionString = ConfigurationManager.ConnectionStrings("fk185_ClassConnectionString").ConnectionString
        Dim sqlConn As New SqlConnection(strConnectionString)
        sql = "Select Question, Answer FROM Ski_FAQ"
        objCommand = New SqlCommand(sql, sqlConn)
        sqlConn.Open()
        dr = objCommand.ExecuteReader()
        While dr.Read
            FAQContext += "<P><b> "
            FAQContext += dr("Question") & "</b></p><br />"
            FAQContext += " <p> " & dr("Answer") & "</p><br />"
        End While
        dr.Close()
        sqlConn.Close()
    End Sub

    Public Function TheFAQ() As String
        Return FAQContext
    End Function
End Class
