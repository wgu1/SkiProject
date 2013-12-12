<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="ViewCompleteStatus.aspx.vb" Inherits="Admin_ViewCompleteStatus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
       <div>
        <asp:label ID="Label1" runat="server" Text="Select a Community:" />
        <asp:DropDownList ID="CommunitteeDropDownList" runat="server" DataSourceID="communityDataSource" AutoPostBack="true" DataTextField="CommitteeName" DataValueField="CommitteeID" Height="16px"></asp:DropDownList>
        <asp:SqlDataSource ID="communityDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:fk185_ClassConnectionString %>" SelectCommand="SELECT [CommitteeName], [CommitteeID] FROM [Ski_Committee]"></asp:SqlDataSource>
           <br />
    </div>

    <div>
        <table>
            <tr>
                <td class="auto-style3">

                </td>

                <td class="auto-style2">               
                   <asp:Label runat="server" ID="statementLabel" Text="View complete status by differnt communities"></asp:Label> 
                 </td>

                <td class="auto-style6">

                    &nbsp;</td>
            </tr>


            <tr>
                <td class="auto-style4">
                   
                     <br />
                </td>

                <td class="auto-style1">
                   
                    <asp:Label ID="SearchLabel" runat="server" Text="Search by volunteer name or E-mail address"></asp:Label>
                    <asp:TextBox ID="searchTextbox" runat="server"></asp:TextBox>
                    <asp:Button ID="searchButton" runat="server" Text="Search" />
                    <br />
                    <asp:Label ID="CompleteStatusLabel" runat="server" Text="Complete Status"></asp:Label>
                    <asp:DropDownList ID="CompleteStatusDropdownlist"  AutoPostBack="true" runat="server" >
                            <asp:ListItem value=" ">All People</asp:ListItem>
                            <asp:ListItem value="Y">Finished</asp:ListItem>
                            <asp:ListItem value="N">Not Finished</asp:ListItem>
                    </asp:DropDownList>
                   
                    <br />
                    <asp:Button ID="cleanButton" runat="server" Text="Clear" />
                   
                    </td>
                <td class="auto-style7">
                     <br />
                     
                </td>
            </tr>


           <tr>
                <td class="auto-style1">
                    <asp:Label ID="hiddenSneakySearchLabel" runat="server" Text=" " Visible="False" ></asp:Label>
                </td>

                <td class="auto-style1">
                    
            
                    
                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" DataSourceID="SearchReportSqlDataSource">
                        <AlternatingRowStyle BackColor="White" />
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    </asp:GridView>
                    
            
                    
                </td>
                <td class="auto-style1">

                </td>
            </tr>
        </table>
    
    </div>

            <asp:SqlDataSource ID="SearchReportSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:fk185_ClassConnectionString %>" SelectCommand="Ski_Search_Completion_Status" SelectCommandType="StoredProcedure">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="hiddenSneakySearchLabel" Name="searchValue" ConvertEmptyStringToNull="true" PropertyName="Text" Type="String" />
                            <asp:ControlParameter ControlID="CommunitteeDropDownList" Name="committeeID" ConvertEmptyStringToNull ="true" PropertyName="SelectedValue" Type="String" />
                            <asp:ControlParameter ControlID="CompleteStatusDropdownlist" Name="completeStatus" ConvertEmptyStringToNull="true" PropertyName="SelectedValue" Type="String" />
                           
                        </SelectParameters>
                    </asp:SqlDataSource>
</asp:Content>

