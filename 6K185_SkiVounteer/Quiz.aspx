<%@ Page Title="Quiz" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Quiz.aspx.vb" Inherits="Quiz_Quiz" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div id="adminholder">
    
    <asp:PlaceHolder ID="QuizPlace" runat="server"></asp:PlaceHolder>
    <asp:Panel ID="MessagePanel" runat="server">
        <asp:Label ID="messagelabel" runat="server" Text=""></asp:Label>
    </asp:Panel>
    <asp:Button ID="SubmitBtn" runat="server" Text="Button" />
    </div>
</asp:Content>