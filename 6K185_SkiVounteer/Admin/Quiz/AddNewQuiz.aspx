<%@ Page Title="" Language="VB" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="false" CodeFile="AddNewQuiz.aspx.vb" Inherits="Quiz_AddNewQuiz" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
 <%-- the dropdownlist --%>
<<div id="adminholder">

   <asp:Label runat="server" ForeColor="BurlyWood" Text="Select the quiz type you want to add" />



<asp:DropDownList ID="questionTypeDropDownList" runat="server" AutoPostBack="true">
    <asp:ListItem value="0">Select Question Type to add</asp:ListItem>
    <asp:ListItem value="1">True/False</asp:ListItem>
    <asp:ListItem value="2">Multiple Choice</asp:ListItem>
</asp:DropDownList>
 <asp:Panel ID="questionPanel" runat="server" Width ="100%">
<asp:FormView ID="QuestionFormView" runat = "server" DefaultMode="Insert"  Width="100%" EnableModelValidation="True">
        <InsertItemTemplate>
          <table id="questionPart">
                  <tr>
                      <td colspan="2">
                          <asp:Label ID="contentLabel" runat="server" Text="Question"></asp:Label>
                      </td>
                      <td colspan="8">
                          <asp:TextBox ID="qContentTextbox" runat="server" ></asp:TextBox>
                      </td>
                  </tr>
                  

                  <tr>
                    <td colspan="2">
                          <asp:Label ID="ASWLabel" runat="server" Text="Right Answer"></asp:Label>
                      </td>
                      <td colspan="2">
                          <asp:DropDownList ID="answerDropDownList" runat="server">
                           
                          </asp:DropDownList>
                      </td>
                  </tr> 
         </table>
        </InsertItemTemplate>
    </asp:FormView> 
<asp:FormView ID="AnswerFormView" runat = "server" DefaultMode="Insert" Width="100%" EnableModelValidation="True">
       <InsertItemTemplate>
         <table >
                  <tr>
                      <td colspan="2">
                          <asp:Label ID="AanswerLabel" runat="server" Text="A."></asp:Label>
                      </td>
                      <td colspan="8">
                          <asp:TextBox ID="AanswerTextbox" runat="server" ></asp:TextBox>
                       </td> 
                 </tr>

                   <tr>
                        <td colspan="2">
                            <asp:Label ID="BanswerLabel" runat="server" Text="B."></asp:Label>
                        </td>
                        <td colspan="8">
                          <asp:TextBox ID="BanswerTextbox" runat="server" ></asp:TextBox>
                        </td>
                    </tr>

                     <tr>
                        <td colspan="2">
                            <asp:Label ID="CanswerLabel" runat="server" Text="C."></asp:Label>
                        </td>
                        <td colspan="8">
                          <asp:TextBox ID="CanswerTextbox" runat="server" ></asp:TextBox>
                        </td>
                    </tr>
                    

                  <tr>
                        <td colspan="2">
                            <asp:Label ID="DanswerLabel" runat="server" Text="D."></asp:Label>
                        </td>
                        <td colspan="8">
                            <asp:TextBox ID="DContentTextbox" runat="server" ></asp:TextBox>
                        </td>
                    </tr>
          </table>
       </InsertItemTemplate>
     </asp:FormView> 
</asp:Panel>
    <asp:Button ID="__submitButton" runat="server" Text="Submit" />
</div>
</asp:Content>

