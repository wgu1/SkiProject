<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="Quiz_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Panel ID="Panel1" runat="server">
         
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
         <div>
        <p id="P1">This is question 1</p>
        <asp:RadioButton ID="RadioButton5" Text ="This is Anser A" runat="server" GroupName ="haha"/> 
        <asp:RadioButton ID="RadioButton6" Text ="This is Anser A" runat="server" GroupName ="haha"/> 
        <asp:RadioButton ID="RadioButton7" Text ="This is Anser A" runat="server" GroupName ="haha"/> 
        <asp:RadioButton ID="RadioButton8" Text ="This is Anser A" runat="server" GroupName ="haha"/> 
        </div>
    </asp:Panel>
</asp:Content>

