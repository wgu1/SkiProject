<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="Quiz_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 155px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
        <table>
            <tr>
                <td>
                    <p>Please type you e-mail address</p>
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
                    <asp:Button ID="emailSubmitBtn" runat="server" Text="Button" />
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
</asp:Content>

