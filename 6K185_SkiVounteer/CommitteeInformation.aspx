<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="CommitteeInformation.aspx.vb" Inherits="Video" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:DropDownList ID="CommitteeDropDownList" runat="server" DataSourceID="SqlDataSource1" DataValueField="CommitteeName"></asp:DropDownList>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:fk185_ClassConnectionString %>" SelectCommand="SELECT [CommitteeID], [CommitteeName] FROM [Ski_Committee]"></asp:SqlDataSource>

    <br />
    <iframe width="420" height="315" src="//www.youtube.com/embed/rjOhRqB-KHk" frameborder="0" allowfullscreen></iframe>

    <p>Here is some code on how to embed a flash movie file: <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://stackoverflow.com/questions/668846/how-to-embed-a-flash-swf-file-into-asp-net">StackFlow for embeddding flash videos</asp:HyperLink></p>
</asp:Content>

