<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Video.aspx.vb" Inherits="Video" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <iframe width="420" height="315" src="//www.youtube.com/embed/rjOhRqB-KHk" frameborder="0" allowfullscreen></iframe>

    <p>Here is some code on how to embed a flash movie file: <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://stackoverflow.com/questions/668846/how-to-embed-a-flash-swf-file-into-asp-net">StackFlow for embeddding flash videos</asp:HyperLink></p>
</asp:Content>

