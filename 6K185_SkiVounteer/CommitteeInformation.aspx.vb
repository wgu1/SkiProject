﻿Imports System.Data.SqlClient

Partial Class Video
    Inherits System.Web.UI.Page
    Private _VideoUrl As String
    Private _DocumentName As String
    Protected Property VideoURL As String
        Get
            Return _VideoURL
        End Get
        Set(value As String)
        End Set
    End Property
    Protected Property DocumentName As String
        Get
            Return _DocumentName
        End Get
        Set(value As String)
        End Set
    End Property
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim CommitteeID As Guid
        Dim sql As String
        Dim dr As SqlDataReader
        Dim strConnectionString As String
        Dim objCommand As SqlCommand

        strConnectionString = ConfigurationManager.ConnectionStrings("fk185_ClassConnectionString").ConnectionString
        Dim sqlConn As New SqlConnection(strConnectionString)
        sql = "Select Top 1 CommitteeID From Ski_Committee"
        objCommand = New SqlCommand(sql, sqlConn)
        sqlConn.Open()
        dr = objCommand.ExecuteReader()
        While dr.Read
            CommitteeID = dr("CommitteeID")
        End While
        dr.Close()

        sql = "Select VideoURL From Ski_Video Where CommitteeID = @CommitteeID"
        objCommand = New SqlCommand(sql, sqlConn)
        objCommand.Parameters.AddWithValue("@CommitteeID", CommitteeID)
        dr = objCommand.ExecuteReader()
        While dr.Read
            _VideoUrl = dr("VideoURL")
        End While
        dr.Close()

        sql = "Select FilePath, DocumentName From Ski_Committee Inner Join Ski_Document On Ski_Committee.DocumentID = Ski_Document.DocumentID Where CommitteeID = @CommitteeID"
        objCommand = New SqlCommand(sql, sqlConn)
        objCommand.Parameters.AddWithValue("@CommitteeID", CommitteeID)
        dr = objCommand.ExecuteReader()
        While dr.Read
            _DocumentName = dr("FilePath") & dr("DocumentName")
        End While
        dr.Close()
        sqlConn.Close()

    End Sub
    Protected Sub ddlCommittee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlCommittee.SelectedIndexChanged
        Dim CommitteeID As String
        Dim sql As String
        Dim dr As SqlDataReader
        Dim strConnectionString As String
        Dim objCommand As SqlCommand

        strConnectionString = ConfigurationManager.ConnectionStrings("fk185_ClassConnectionString").ConnectionString
        Dim sqlConn As New SqlConnection(strConnectionString)
        CommitteeID = ddlCommittee.SelectedValue

        sql = "Select VideoURL From Ski_Video Where CommitteeID = @CommitteeID"
        objCommand = New SqlCommand(sql, sqlConn)
        objCommand.Parameters.AddWithValue("@CommitteeID", CommitteeID)
        sqlConn.Open()
        dr = objCommand.ExecuteReader()
        While dr.Read
            _VideoUrl = dr("VideoURL")
        End While
        dr.Close()

        sql = "Select FilePath, DocumentName From Ski_Committee Inner Join Ski_Document On Ski_Committee.DocumentID = Ski_Document.DocumentID Where CommitteeID = @CommitteeID"
        objCommand = New SqlCommand(sql, sqlConn)
        objCommand.Parameters.AddWithValue("@CommitteeID", CommitteeID)
        dr = objCommand.ExecuteReader()
        While dr.Read
            _DocumentName = dr("FilePath") & dr("DocumentName")
        End While
        dr.Close()
        sqlConn.Close()

    End Sub
End Class
