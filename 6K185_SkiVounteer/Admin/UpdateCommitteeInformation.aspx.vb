Imports System.Data.SqlClient

Partial Class Admin_UpdateCommitteeInformation
    Inherits System.Web.UI.Page

    Protected Sub videoButton_Click(sender As Object, e As EventArgs) Handles videoButton.Click
        Dim URL As String
        Dim UploadURL As String
        URL = Right(videoTextBox.Text.Trim, 11)
        UploadURL = "'//www.youtube.com/embed/" & URL & "'"

        Dim CommitteeID As String
        Dim sql As String
        Dim strConnectionString As String
        Dim objCommand As SqlCommand

        strConnectionString = ConfigurationManager.ConnectionStrings("fk185_ClassConnectionString").ConnectionString
        Dim sqlConn As New SqlConnection(strConnectionString)
        CommitteeID = ddlCommittee.SelectedValue

        sql = "Update Ski_Video Set VideoURL = @VideoURL Where CommitteeID = @CommitteeID"
        objCommand = New SqlCommand(sql, sqlConn)
        objCommand.Parameters.AddWithValue("@CommitteeID", CommitteeID)
        objCommand.Parameters.AddWithValue("@VideoURL", UploadURL)
        sqlConn.Open()
        objCommand.ExecuteNonQuery()

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack Then
            Dim path As String = Server.MapPath("~/CommitteeInformationDocuments/")
            Dim fileOK As Boolean = False
            If documentUpload.HasFile Then
                Dim fileExtension As String
                fileExtension = System.IO.Path. _
                    GetExtension(documentUpload.FileName).ToLower()
                Dim allowedExtensions As String() = _
                    {".doc", ".docx", ".pdf", ".rtf"}
                For i As Integer = 0 To allowedExtensions.Length - 1
                    If fileExtension = allowedExtensions(i) Then
                        fileOK = True
                    End If
                Next
                If fileOK Then
                    Try
                        documentUpload.PostedFile.SaveAs(path & _
                             documentUpload.FileName)
                        ResultLabel.Text = "File uploaded!"
                    Catch ex As Exception
                        ResultLabel.Text = "File could not be uploaded."
                    End Try
                Else
                    ResultLabel.Text = "Cannot accept files of this type."
                End If
            End If
        End If
    End Sub
End Class
