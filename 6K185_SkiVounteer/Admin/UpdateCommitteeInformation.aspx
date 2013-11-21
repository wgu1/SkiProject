<%@ Page Title="" Language="VB" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="false" CodeFile="UpdateCommitteeInformation.aspx.vb" Inherits="Admin_UpdateCommitteeInformation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Label ID="CommitteeLabel" runat="server" Text="Please select a committe to modify: "></asp:Label>   
    <asp:DropDownList ID="ddlCommittee" runat="server" AutoPostBack="True" 
                       DataTextField="CommitteeName" DataValueField="CommitteeID" DataSourceID="SqlDataSource1">
                        </asp:DropDownList>
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:fk185_ClassConnectionString %>" SelectCommand="SELECT * FROM [Ski_Committee]"></asp:SqlDataSource>
    <br />
    <asp:Label ID="videoLabel" runat="server" Text="Enter URL to Youtube video:"></asp:Label>
    <br />
    <asp:TextBox ID="videoTextBox" runat="server" Width="300px"></asp:TextBox>
    <asp:Button ID="videoButton" runat="server" Text="Upload" />
    <br />
    <asp:Label ID="videoResultLabel" runat="server" Text=""></asp:Label>
    <br />
    <br />
        <asp:DropDownList ID="ddlDocType" runat="server" AutoPostBack="True" 
                       DataTextField="Description" DataValueField="TypeID" DataSourceID="SqlDataSource2">
                        </asp:DropDownList>
    
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:fk185_ClassConnectionString %>" SelectCommand="SELECT * FROM [Ski_DocumentType]"></asp:SqlDataSource>
    <br />
    <asp:Label ID="documentLabel" runat="server" Text="Please upload a new document:"></asp:Label>
    <br />
    <asp:FileUpload ID="documentUpload" runat="server" Width="600px" />
    <asp:Button ID="documentButton" runat="server" Text="Upload" />
    <br />
    <asp:Label ID="documentResultLabel" runat="server" Text=""></asp:Label>
</asp:Content>

