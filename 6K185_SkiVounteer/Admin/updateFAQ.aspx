<%@ Page Title="" Language="VB" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="false" CodeFile="updateFAQ.aspx.vb" Inherits="Admin_updateFAQ" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    
    <div id="adminholder">
    <h3>Frequent Ask Questions</h3>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:fk185_ClassConnectionString %>" SelectCommand="SELECT [Question], [Answer], [ID] FROM [Ski_FAQ]" DeleteCommand="DELETE FROM [Ski_FAQ] WHERE [ID] = @ID" InsertCommand="INSERT INTO [Ski_FAQ] ([Question], [Answer], [ID]) VALUES (@Question, @Answer, @ID)" UpdateCommand="UPDATE [Ski_FAQ] SET [Question] = @Question, [Answer] = @Answer WHERE [ID] = @ID">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Question" Type="String" />
                <asp:Parameter Name="Answer" Type="String" />
                <asp:Parameter Name="ID" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Question" Type="String" />
                <asp:Parameter Name="Answer" Type="String" />
                <asp:Parameter Name="ID" Type="String" />
            </UpdateParameters>
    </asp:SqlDataSource>
    

    <asp:GridView ID="GridView1" runat="server"  AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" EnableModelValidation="True" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="80%" PageSize="5">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
            <asp:TemplateField HeaderText="Question" SortExpression="Question">
                <EditItemTemplate>
                    <asp:TextBox ID="tbQuestion" TextMode ="MultiLine" Width="99%" Height="80px" runat="server" Text='<%# Bind("Question") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("Question") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Answer" SortExpression="Answer">
                <EditItemTemplate>
                    <asp:TextBox ID="tbAnswer" TextMode ="MultiLine" Width="99%" Height="80px" runat="server" Text='<%# Bind("Answer") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Answer") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        </Columns>
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="center" />
        <RowStyle BackColor="White" ForeColor="#003399" />
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
    </asp:GridView>
    

    <asp:Button ID="btAdd" runat="server" Text="Add new question" />
    <br />
    <asp:Label ID="lbQuestion" runat="server" Text="Question: " Visible="False"></asp:Label>
    <asp:TextBox ID="tbNewQ" runat="server" TextMode="MultiLine" Visible="False" Width="70%" Height="40px"></asp:TextBox>
    <br />
    <asp:Label ID="lbAnswer" runat="server" Text="Answer: " Visible="False"></asp:Label>
    <asp:TextBox ID="tbNewA" runat="server" TextMode="MultiLine" Visible="False" Width="70%" Height="40px"></asp:TextBox>
    <br />
    <asp:Button ID="btInsert" runat="server" Text="Insert" Visible="False" />
    <asp:Button ID="btCancel" runat="server" Text="Cancel" Visible="False" />
</div>
</asp:Content>

