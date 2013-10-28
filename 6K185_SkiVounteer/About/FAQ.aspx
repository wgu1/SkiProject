<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="FAQ.aspx.vb" Inherits="About_FAQ" %>

<script runat="server"></script>




<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="subMenu">
        <asp:Menu ID="AboutNavigation" runat="server" CssClass="aboutmenu" EnableViewState="false" IncludeStyleBlock="false" Orientation="vertical">
                    <Items>
                        <asp:MenuItem NavigateUrl="~/About/Default.aspx" Text="About"/>
                        <asp:MenuItem NavigateUrl="~/About/FAQ.aspx" Text="FAQ"/>             
                    </Items>
                </asp:Menu>
    </div>

    <div class="FAQcontent">
        <h2> FAQ </h2>
        <%= TheFAQ()%>

    </div>
</asp:Content>

