<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="FAQ.aspx.vb" Inherits="About_FAQ" %>

<script runat="server"></script>




<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
<div id="adminholder"> 
   

    <div class="FAQcontent">
        <h3> Frequent Ask Questions </h3>
        <%= TheFAQ()%>

    </div>
    </div>
    </div>
</asp:Content>

