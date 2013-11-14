Imports System.Data.SqlClient

Partial Class Video
    Inherits System.Web.UI.Page
    Private _VideoUrl As String
    Private _IntroDoc As String
    Private _BodyDoc As String
    Private _ContactInfo As String

    Protected Property VideoURL As String
        Get
            Return _VideoURL
        End Get
        Set(value As String)
        End Set
    End Property

    Protected Property IntroDoc As String
        Get
            Return _IntroDoc
        End Get
        Set(value As String)
        End Set
    End Property

    Protected Property BodyDoc As String
        Get
            Return _BodyDoc
        End Get
        Set(value As String)
        End Set
    End Property
    Protected Property ContactInfo As String
        Get
            Return _ContactInfo
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

        sql = "Select FilePath, DocumentName From Ski_Document Where CommitteeID = @CommitteeID And TypeID = 1"
        objCommand = New SqlCommand(sql, sqlConn)
        objCommand.Parameters.AddWithValue("@CommitteeID", CommitteeID)
        dr = objCommand.ExecuteReader()
        While dr.Read
            _IntroDoc = dr("FilePath") & dr("DocumentName")
        End While
        dr.Close()

        sql = "Select FilePath, DocumentName From Ski_Document Where CommitteeID = @CommitteeID And TypeID = 2"
        objCommand = New SqlCommand(sql, sqlConn)
        objCommand.Parameters.AddWithValue("@CommitteeID", CommitteeID)
        dr = objCommand.ExecuteReader()
        While dr.Read
            _BodyDoc = dr("FilePath") & dr("DocumentName")
        End While
        dr.Close()

        sql = "Select FilePath, DocumentName From Ski_Document Where CommitteeID = @CommitteeID And TypeID = 3"
        objCommand = New SqlCommand(sql, sqlConn)
        objCommand.Parameters.AddWithValue("@CommitteeID", CommitteeID)
        dr = objCommand.ExecuteReader()
        While dr.Read
            _ContactInfo = dr("FilePath") & dr("DocumentName")
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

        sql = "Select FilePath, DocumentName From Ski_Document Where CommitteeID = @CommitteeID And TypeID = 1"
        objCommand = New SqlCommand(sql, sqlConn)
        objCommand.Parameters.AddWithValue("@CommitteeID", CommitteeID)
        dr = objCommand.ExecuteReader()
        While dr.Read
            _IntroDoc = dr("FilePath") & dr("DocumentName")
        End While
        dr.Close()

        sql = "Select FilePath, DocumentName From Ski_Document Where CommitteeID = @CommitteeID And TypeID = 2"
        objCommand = New SqlCommand(sql, sqlConn)
        objCommand.Parameters.AddWithValue("@CommitteeID", CommitteeID)
        dr = objCommand.ExecuteReader()
        While dr.Read
            _BodyDoc = dr("FilePath") & dr("DocumentName")
        End While
        dr.Close()

        sql = "Select FilePath, DocumentName From Ski_Document Where CommitteeID = @CommitteeID And TypeID = 3"
        objCommand = New SqlCommand(sql, sqlConn)
        objCommand.Parameters.AddWithValue("@CommitteeID", CommitteeID)
        dr = objCommand.ExecuteReader()
        While dr.Read
            _ContactInfo = dr("FilePath") & dr("DocumentName")
        End While
        dr.Close()
        sqlConn.Close()

    End Sub
End Class
