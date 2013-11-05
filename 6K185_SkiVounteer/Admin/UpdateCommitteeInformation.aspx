<%@ Page Title="" Language="VB" MasterPageFile="~/Admin/admin.master" AutoEventWireup="false" CodeFile="UpdateCommitteeInformation.aspx.vb" Inherits="Admin_UpdateCommitteeInformation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
    <br />
    <asp:Label ID="documentLabel" runat="server" Text="Please upload a new document:"></asp:Label>
    <br />
    <asp:FileUpload ID="documentUpload" runat="server" Width="600px" />
    <br />
    <asp:Label ID="ResultLabel" runat="server" Text="Label"></asp:Label>
</asp:Content>

