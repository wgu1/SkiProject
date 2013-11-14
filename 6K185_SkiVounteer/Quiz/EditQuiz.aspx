<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="EditQuiz.aspx.vb" Inherits="Quiz_EditQuiz" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
   
    <asp:FormView runat = "server" DefaultMode="Edit"  DataSourceID="SqlDataSource1" OnDataBound="changeType">
        <EditItemTemplate>
          <table>
                  <tr>
                      <td colspan="2">
                          <asp:Label ID="QuestionLabel" runat="server" Text="Question Number"></asp:Label>
                      </td>
                      
                      <td colspan="8">
                          <asp:Label ID="QcontentLabel" runat="server" Text='<%# Eval("QuestionCode") %>'></asp:Label>
                      </td>
                  </tr>


                  <tr>
                      <td colspan="2">
                          <asp:Label ID="questionTlabel" runat="server" Text="Question Type"></asp:Label>
                      </td>

                      <td colspan="8">
                          <asp:Label ID="questionTypeLabel" runat="server" Text='<%# Eval("QuestionType") %>'></asp:Label>
                      </td>
                  </tr>

                  <tr>
                      <td colspan="2">
                          <asp:Label ID="contentLabel" runat="server" Text="Question"></asp:Label>
                      </td>
                      <td colspan="8">
                          <asp:TextBox ID="qContentTextbox" runat="server" Text='<%# Eval("QuestionContent") %>'></asp:TextBox>
                      </td>
                  </tr>
          </table>
        </EditItemTemplate>
    </asp:FormView>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:fk185_ClassConnectionString %>" SelectCommand="Ski_PullingQuizByQuestionID" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:QueryStringParameter Name="ID" QueryStringField="ID" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>

