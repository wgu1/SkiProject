<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="CommitteeInformation.aspx.vb" Inherits="Video" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
       <asp:DropDownList ID="ddlCommittee" runat="server" AutoPostBack="True" 
                             DataTextField="CommitteeName" DataValueField="CommitteeID" DataSourceID="SqlDataSource1">
                        </asp:DropDownList>
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:fk185_ClassConnectionString %>" SelectCommand="SELECT * FROM [Ski_Committee]"></asp:SqlDataSource>
    
    <br />
    <iframe src=<%=DocumentName%> width="810px" height="500px" scrolling="yes" frameborder="0"></iframe>
    <br />
    <iframe width="420" height="315" src=<%=VideoURL%> frameborder="0" allowfullscreen></iframe>
 
</asp:Content>

