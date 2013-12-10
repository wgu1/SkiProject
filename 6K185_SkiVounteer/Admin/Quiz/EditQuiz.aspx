<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="EditQuiz.aspx.vb" Inherits="Quiz_EditQuiz" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
   
    <asp:FormView ID="EditFormView" runat = "server" DefaultMode="Edit"  databound="changetype" DataSourceID="SqlDataSource1"  EnableModelValidation="True">
        <EditItemTemplate>
          <table>
                  <%--<tr>
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
                      </td>--%>
                  </tr>

                  <tr>
                      <td colspan="2">
                          <asp:Label ID="contentLabel" runat="server" Text="Question"></asp:Label>
                      </td>
                      <td colspan="8">
                          <asp:TextBox ID="qContentTextbox" runat="server" ></asp:TextBox>
                      </td>
                  </tr>
                  
              <%--<tr>
                      <td colspan="2">
                          <asp:Label ID="ASWLabel" runat="server" Text="Answer"></asp:Label>
                      </td>
                      <td colspan="2">
                          <asp:TextBox ID="ASWLabel1" runat="server" Text='<%# Eval("Answer")%>'></asp:TextBox>
                      </td>
                  </tr> --%>
                  <tr>
                      <td colspan="2">
                          <asp:Label ID="ASWContentLabel" runat="server" Text="AnswerText"></asp:Label>
                      </td>
                      <td colspan="8">
                          <asp:TextBox ID="ASWContentTextbox1" runat="server" ></asp:TextBox>
                          <asp:TextBox ID="ASWContentTextbox2" runat="server" ></asp:TextBox>
                          <asp:TextBox ID="ASWContentTextbox3" runat="server" ></asp:TextBox>
                          <asp:TextBox ID="ASWContentTextbox4" runat="server" ></asp:TextBox>
                          </td>
                      
                  </tr>
              <tr>
                  <td colspan="4">
                          <asp:Label ID="correctASWLabel" runat="server" Text="Correct Answer"></asp:Label>
                            <asp:TextBox ID="correctASWTextbox" runat="server"></asp:TextBox>
                    </td>
              </tr>
              <tr>
                  <td colspan="4">
                          <asp:Label ID="useLabel" runat="server" Text="Use this question "></asp:Label>
                            <asp:CheckBox ID="useCheckbox" runat="server"></asp:CheckBox>
                    </td>
                </tr>
                   
          </table>
                <asp:Button ID="btUpdate" runat="server" CommandName="update" Text="Update"/>
                <asp:Button ID="btCancel" runat="server" CommandName="cancel" Text="Cancel"/>


        </EditItemTemplate>
    </asp:FormView>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:fk185_ClassConnectionString %>" SelectCommand="Ski_PullingQuizByQuestionID" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:QueryStringParameter Name="ID" QueryStringField="ID" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>

