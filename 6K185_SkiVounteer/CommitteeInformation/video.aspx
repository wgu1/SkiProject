<%@ Page Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false"  CodeFile="video.aspx.vb" Inherits="CommitteeInformation_video" %>


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
    <iframe width="810px" height="607px" src=<%=VideoURL%> frameborder="0" allowfullscreen></iframe>    
    </center>
    </div>
    <br />
 



    </div>
    </div>

</asp:Content>

