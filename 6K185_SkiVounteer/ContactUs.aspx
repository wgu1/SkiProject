<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="ContactUs.aspx.vb" Inherits="ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    
    <div class="background" align="center">
    <div class="transbox">
    
    
    <p>
        Please feel free to send us any comments or questions using the form below:</p>
    <br />
    <asp:Label ID="EmailLabel" runat="server" Text="Your E-mail:"></asp:Label>
    <br />
    <asp:TextBox ID="EmailTextBox" runat="server" Width="360px"></asp:TextBox>
    <br />
    <asp:Label ID="SubjectLabel" runat="server" Text="Subject:"></asp:Label>
    <br />
    <asp:TextBox ID="SubjectTextBox" runat="server" Width="360px"></asp:TextBox>
    <br />
    <asp:Label ID="MessageLabel" runat="server" Text="Message:"></asp:Label>
    <br />
    <asp:TextBox ID="MessageTextBox" textmode="MultiLine" runat="server" Height="200px" Width="720px"></asp:TextBox>
    <br />
    <asp:Button ID="SubmitButton" runat="server" Text="Submit" />

    </div>
    </div>
</asp:Content>

