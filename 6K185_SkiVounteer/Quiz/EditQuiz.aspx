<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="EditQuiz.aspx.vb" Inherits="Quiz_EditQuiz" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:DetailsView ID="QuizDetailsView" runat="server" Height="50px" Width="125px" DataSourceID="SqlDataSource1" EnableModelValidation="True"></asp:DetailsView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:fk185_ClassConnectionString %>" SelectCommand="Ski_PullingQuizByQuestionID" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:QueryStringParameter Name="QuestionID" QueryStringField="@QuestionID" Type="Object" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>

