<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="AssignQuiz.aspx.vb" Inherits="Admin_AssignQuiz" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 72px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>
        <asp:DropDownList ID="CommunitteeDropDownList" runat="server" DataSourceID="communityDataSource" AutoPostBack="true" DataTextField="CommitteeName" DataValueField="CommitteeCode" Height="16px"></asp:DropDownList>
        <asp:SqlDataSource ID="communityDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:fk185_ClassConnectionString %>" SelectCommand="SELECT [CommitteeName], [CommitteeID] FROM [Ski_Committee]"></asp:SqlDataSource>
    </div>

    <div>
        <table>
            <tr>
                <td>

                </td>

                <td>
                   
                </td>

                <td>

                </td>
            </tr>


            <tr>
                <td class="auto-style1">
                     <asp:ListBox ID="currentQListbox" runat="server" ></asp:ListBox>
                </td>

                <td class="auto-style1">
                    <asp:Button ID="addButton" runat="server" Text="<--Add" />
                </td>
                <td class="auto-style1">
                     <asp:ListBox ID="SearchQuestion" runat="server"></asp:ListBox>
                     
                </td>
            </tr>


           <tr>
                <td>

                    <asp:Label ID="storeNewAddedQuiz" runat="server" Text=""></asp:Label>

                </td>

                <td>
                    
                </td>
                <td>

                </td>
            </tr>
        </table>
    </div>
</asp:Content>

