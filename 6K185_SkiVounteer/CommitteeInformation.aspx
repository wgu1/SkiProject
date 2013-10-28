<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="CommitteeInformation.aspx.vb" Inherits="Video" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Please select a committe to learn more: "></asp:Label>   
    <asp:DropDownList ID="ddlCommittee" runat="server" AutoPostBack="True" 
                             DataTextField="CommitteeName" DataValueField="CommitteeID" DataSourceID="SqlDataSource1">
                        </asp:DropDownList>
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:fk185_ClassConnectionString %>" SelectCommand="SELECT * FROM [Ski_Committee]"></asp:SqlDataSource>
    
    <br />
    <br />
    <div style="margin-left:auto;margin-right:auto;">
    <center>
    <iframe src=<%=DocumentName%> width="810px" height="400px" scrolling="auto" frameborder="1"></iframe>
    </center>
    </div>
    <br />
    <br />
    <div style="margin-left:auto;margin-right:auto;">
    <center>
    <object id="Player" width="600px" height="450px" classid="CLSID:6BF52A52-394A-11d3-B153-00C04F79FAA6">
        <param name="autoStart" value="False" />
        <param name="URL" value="http://localhost:64069/6K185_SkiVounteer/Wildlife.wmv" />
    </object>     
    </center>
    </div>
</asp:Content>

