<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="AssignQuiz.aspx.vb" Inherits="Admin_AssignQuiz" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 72px;
        }
        .auto-style2 {
            height: 18px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>
        <asp:DropDownList ID="CommunitteeDropDownList" runat="server" DataSourceID="communityDataSource" AutoPostBack="true" DataTextField="CommitteeName" DataValueField="CommitteeID" Height="16px"></asp:DropDownList>
        <asp:SqlDataSource ID="communityDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:fk185_ClassConnectionString %>" SelectCommand="SELECT [CommitteeName], [CommitteeID] FROM [Ski_Committee]"></asp:SqlDataSource>
    </div>

    <div>
        <table>
            <tr>
                <td class="auto-style2">

                </td>

                <td class="auto-style2">
                   
                </td>

                <td class="auto-style2">

                </td>
            </tr>


            <tr>
                <td class="auto-style1">
                     <asp:ListBox ID="currentQListbox" runat="server" DataSourceID="CommitteeQuestions" DataTextField="question" DataValueField="QuestionID" Height="114px" ></asp:ListBox>
                </td>

                <td class="auto-style1">
                    <asp:Button ID="addButton" runat="server" Text="<--Add" />
                    <asp:Button ID="removeButton" runat="server" Text="Remove-->" />
                </td>
                <td class="auto-style1">
                     <asp:ListBox ID="RestQListbox" runat="server" DataSourceID="CommitteeRestQuestions" DataTextField="question" DataValueField="QuestionID" Height="102px"></asp:ListBox>
                     
                </td>
            </tr>


           <tr>
                <td>

                    &nbsp;</td>

                <td>
                    
                </td>
                <td>

                </td>
            </tr>
        </table>
        <asp:SqlDataSource ID="CommitteeQuestions" runat="server" ConnectionString="<%$ ConnectionStrings:fk185_ClassConnectionString %>" SelectCommand="Ski_Admin_Assign_Quiz_By_CommitteeID" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="CommunitteeDropDownList" Name="commiteeID" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="CommitteeRestQuestions" runat="server" ConnectionString="<%$ ConnectionStrings:fk185_ClassConnectionString %>" SelectCommand="Ski_Admin_Assign_Rest_Quiz_By_CommitteeID" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="CommunitteeDropDownList" Name="commiteeID" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
</asp:Content>

