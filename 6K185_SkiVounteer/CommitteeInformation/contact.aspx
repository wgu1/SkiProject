<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="contact.aspx.vb" Inherits="CommitteeInformation_contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    
     <div class="background" align="center">
    <div class="transbox">
    <br />
        <div id="subMenu">
        <a href="default.aspx">Introduction</a>
        <a href="video.aspx">Video</a>
        <a href="doc.aspx">Detail Information</a>
        <a href="contact.aspx">Contact</a>
    </div>
    <br />
    
    <asp:Label ID="Label1" runat="server" Text="Please select a committe to learn more: "></asp:Label>   
    <asp:DropDownList ID="ddlCommittee" runat="server" AutoPostBack="True" 
                             DataTextField="CommitteeName" DataValueField="CommitteeID" DataSourceID="SqlDataSource1">
                        </asp:DropDownList>
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:fk185_ClassConnectionString %>" SelectCommand="SELECT * FROM [Ski_Committee]"></asp:SqlDataSource>
    
    <br />
    <br />

    <div style="margin-left:auto;margin-right:auto;">
    <center>
    <iframe src=<%=ContactInfo%> width="810px" height="600px" scrolling="auto" frameborder="1"></iframe>
    </center>
    </div>



    </div>
    </div>

</asp:Content>



