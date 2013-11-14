<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="QuizDefault.aspx.vb" Inherits="Quiz_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
  
    <div class="background" align="center">
    <div class="transbox">
    
    
    
    <table>
            <tr>
                <td>
                    <h3>Please type you e-mail address</h3>
                </td>
                <td>
                    <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="emailVlidator" runat="server" ErrorMessage="Please enter your e-mail" ControlToValidate ="emailTextBox"></asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
      <table>
             <tr>
                 <td class="auto-style1">
                      
                 </td>
                <td>
                    <asp:label ID="messageLb" runat="server" Text=""  />
                </td>
            </tr>
    </table> 

    <table>
             <tr>
                 <td class="auto-style1">
                      
                 </td>
                <td>
                    <asp:Button ID="emailSubmitBtn" runat="server" Text="Submit" />
                </td>
            </tr>
    </table>
        <table>
             <tr>
                 <td class="auto-style1">
                      
                 </td>
                <td>
                    <asp:ListBox ID="committeeListBox" runat="server" Visible ="false"></asp:ListBox>
                </td>
            </tr>
    </table>

  
        <table>
             <tr>
                 <td class="auto-style1">
                      
                 </td>
                <td>
                     <asp:button ID="StartQuizBtn" runat="server" Text ="Start!" Visible="false"></asp:button>
                </td>
            </tr>
    </table>

    </div>
        </div>
</asp:Content>

