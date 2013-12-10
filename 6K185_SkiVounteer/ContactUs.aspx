<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="ContactUs.aspx.vb" Inherits="ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    
    <div class="background" align="center">
    <div class="transbox">
    
    
    <p>
    <asp:Label ID="EmailLabel" runat="server" Text="Your E-mail:"></asp:Label>
        <asp:TextBox ID="EmailTextBox" runat="server" Width="160px"></asp:TextBox>
        &nbsp;
    <asp:Label ID="SubjectLabel" runat="server" Text="Subject:"></asp:Label>
    <asp:TextBox ID="SubjectTextBox" runat="server" Width="241px"></asp:TextBox>
        </p>
    <asp:Label ID="MessageLabel" runat="server" Text="Questions Regarding the Training Project"></asp:Label>
    <br />
        <br />
    <br />
   

    <asp:TextBox ID="MessageTextBox" textmode="MultiLine" runat="server" Height="170px" Width="720px"></asp:TextBox>
    <br />
    <br />
    <br />

    <asp:Button ID="SubmitButton" runat="server" Text="Submit" />

    </div>
    </div>
</asp:Content>

