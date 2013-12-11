<%@ Page Title="" Language="VB" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="false" CodeFile="AssignQuiz.aspx.vb" Inherits="Admin_AssignQuiz" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
   <div id="adminholder2">
    
     <style type="text/css">
        .auto-style1 {
            height: 72px;
        }
        .auto-style2 {
            height: 18px;
        }
        .auto-style3 {
            height: 18px;
            width: 243px;
        }
        .auto-style4 {
            height: 72px;
            width: 243px;
        }
        .auto-style5 {
            width: 243px;
            height: 20px;
        }
        .auto-style6 {
            height: 18px;
            width: 246px;
        }
        .auto-style7 {
            height: 72px;
            width: 246px;
        }
        .auto-style8 {
            width: 246px;
            height: 20px;
        }
        .auto-style9 {
            height: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>
        <asp:label runat="server" Text="Select a Community to assign quizzes:" />
        <asp:DropDownList ID="CommunitteeDropDownList" runat="server" DataSourceID="communityDataSource" AutoPostBack="true" DataTextField="CommitteeName" DataValueField="CommitteeID" Height="16px"></asp:DropDownList>
        <asp:SqlDataSource ID="communityDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:fk185_ClassConnectionString %>" SelectCommand="SELECT [CommitteeName], [CommitteeID] FROM [Ski_Committee]"></asp:SqlDataSource>
    </div>

    <div>
        <table>
            <tr>
                <td class="auto-style3">

                </td>

                <td class="auto-style2">
                   
                </td>

                <td class="auto-style6">

                    <asp:Label ID="SearchLabel" runat="server" Text="Search Question Content:"></asp:Label>
                    <asp:TextBox ID="searchTextbox" runat="server"></asp:TextBox>
                    <asp:Button ID="searchButton" runat="server" Text="Search" />
                    <br />
                    <asp:Label ID="QuestionTypeLabel" runat="server" Text="QuestionType"></asp:Label>
                    <asp:DropDownList ID="QuestionTypeDropdownlist"  AutoPostBack="true" runat="server" >
                            <asp:ListItem value="0">Select Value</asp:ListItem>
                            <asp:ListItem value="1">True/False</asp:ListItem>
                            <asp:ListItem value="2">Multiple Choice</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>


            <tr>
                <td class="auto-style4">
                    <asp:Label runat="server" Text="Current Quizzes"></asp:Label>
                     <br />
                     <asp:ListBox ID="currentQListbox" runat="server" DataSourceID="CommitteeQuestions" DataTextField="question" DataValueField="QuestionID" Height="114px" ></asp:ListBox>
                </td>

                <td class="auto-style1">
                    <asp:Button ID="addButton" runat="server" Text="<--Add" />
                    <asp:Button ID="removeButton" runat="server" Text="Remove-->" />
                </td>
                <td class="auto-style7">
                    <asp:Label runat="server" Text="Quiz Poll:"/>
                     <br />
                     <asp:ListBox ID="RestQListbox" runat="server" DataSourceID="CommitteeRestQuestions" DataTextField="question" DataValueField="QuestionID" Height="102px"></asp:ListBox>
                     
                </td>
            </tr>


           <tr>
                <td class="auto-style5">
                    <asp:Label ID="hiddenSearchLabel" runat="server" Text=" " Visible="false"></asp:Label>
                </td>

                <td class="auto-style9">
                    
                </td>
                <td class="auto-style8">

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
                <asp:ControlParameter ControlID="QuestionTypeDropdownlist" Name="questionType" ConvertEmptyStringToNull ="true" PropertyName="SelectedValue" Type="Int32" />
                <asp:ControlParameter ControlID="hiddenSearchLabel" Name="searchValue" ConvertEmptyStringToNull ="true" DefaultValue="" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    </div>
   

</asp:Content>

