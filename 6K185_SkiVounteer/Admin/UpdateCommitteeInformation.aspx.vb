Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Partial Class Admin_UpdateCommitteeInformation
    Inherits System.Web.UI.Page

    Protected Sub videoButton_Click(sender As Object, e As EventArgs) Handles videoButton.Click
        Dim URL As String
        Dim UploadURL As String
        URL = Right(videoTextBox.Text.Trim, 11)
        Dim VideoOk As Boolean = False
        If videoTextBox.Text <> "" Then
            If Left(videoTextBox.Text.Trim, 31) = "http://www.youtube.com/watch?v=" Then
                VideoOk = True
            End If
        End If
        If VideoOk = True Then
            Try
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
                videoResultLabel.Text = "Video was updated successfully!"
            Catch ex As Exception
                videoResultLabel.Text = "Video could not be uploaded. Verify video is exists and try again."
            End Try
        Else
            videoResultLabel.Text = "Invalid URL. Please verify the URL for the video."
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack Then
        End If
    End Sub

    Protected Sub documentButton_Click(sender As Object, e As EventArgs) Handles documentButton.Click
        If IsPostBack Then
            Dim path As String = Server.MapPath("~/CommitteeInformationDocuments/")
            Dim fileOK As Boolean = False

            'Dim WordApp As Word.Application
            ' WordApp = New Word.Application
            'WordApp.Visible = False
            'WordApp.Documents.Open(Server.MapPath("~/CommitteeInformationDocuments/" & documentUpload.FileName.ToString.Trim))
            'WordApp.ActiveDocument.SaveAs2(Server.MapPath("~/CommitteeInformationDocuments/" & Left(documentUpload.FileName.ToString.Trim, Len(documentUpload.FileName.ToString.Trim) - 3) & ".pdf", Word.WdSaveFormat.wdFormatPDF))
            If documentUpload.HasFile Then
                Dim fileExtension As String
                fileExtension = System.IO.Path. _
                    GetExtension(documentUpload.FileName).ToLower()
                Dim allowedExtensions As String() = _
                    {".doc", ".docx", ".pdf"}
                For i As Integer = 0 To allowedExtensions.Length - 1
                    If fileExtension = allowedExtensions(i) Then
                        fileOK = True
                    End If
                Next

                If fileOK Then
                    Try
                        documentUpload.PostedFile.SaveAs(path & _
                             documentUpload.FileName)
                        Dim Document As String
                        Document = documentUpload.FileName.ToString.Trim

                        Dim CommitteeID As String
                        Dim TypeID As Integer
                        Dim sql As String
                        Dim strConnectionString As String
                        Dim objCommand As SqlCommand

                        strConnectionString = ConfigurationManager.ConnectionStrings("fk185_ClassConnectionString").ConnectionString
                        Dim sqlConn As New SqlConnection(strConnectionString)
                        CommitteeID = ddlCommittee.SelectedValue
                        TypeID = ddlDocType.SelectedValue
                        sql = "Update Ski_Document Set DocumentName = @Document Where CommitteeID = @CommitteeID And TypeID = @TypeID"
                        objCommand = New SqlCommand(sql, sqlConn)
                        objCommand.Parameters.AddWithValue("@CommitteeID", CommitteeID)
                        objCommand.Parameters.AddWithValue("@TypeID", TypeID)
                        objCommand.Parameters.AddWithValue("@Document", Document)
                        sqlConn.Open()
                        objCommand.ExecuteNonQuery()
                        documentResultLabel.Text = "Document was updated successfully!"
                    Catch ex As Exception
                        documentResultLabel.Text = "Document could not be uploaded. Verify document is closed and properly saved and try again."
                    End Try
                Else
                    documentResultLabel.Text = "Cannot accept documents of this type. Upload only supports .doc, .docx, or .pdf"
                End If
            End If
        End If
    End Sub
End Class
