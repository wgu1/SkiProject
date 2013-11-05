<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="ViewQuiz.aspx.vb" Inherits="Quiz_ViewQuiz" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" EnableModelValidation="True" ForeColor="#333333" GridLines="None" DataKeyNames="QuestionID">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="QuestionID" HeaderText="QuestionID" SortExpression="QuestionID" ReadOnly="True" Visible="false" />
            <asp:BoundField DataField="QuestionCode" HeaderText="QuestionCode" SortExpression="QuestionCode" />
            <asp:BoundField DataField="QuestionType" HeaderText="QuestionType" SortExpression="QuestionType" />
            <asp:BoundField DataField="QuestionContent" HeaderText="QuestionContent" SortExpression="QuestionContent" />
            <asp:BoundField DataField="CurrentlyUse" HeaderText="CurrentlyUse" SortExpression="CurrentlyUse" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    </asp:GridView>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:fk185_ClassConnectionString %>" SelectCommand="SELECT * FROM [vw_Ski_ViewQuestions]"></asp:SqlDataSource>
</asp:Content>

