<%@ Page Title="" Language="VB" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="false" CodeFile="Volunteer.aspx.vb" Inherits="Admin_Volunteer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

    <div id="adminholder">
    <h1>Add Volunteer</h1>
    <br />  
    <asp:Label ID="FNameLabel" runat="server" Text="First Name:" Width ="70px"></asp:Label>
    <asp:TextBox ID="FNameTextBox" runat="server" Width="300px"></asp:TextBox>
    <br />
    <asp:Label ID="LNameLabel" runat="server" Text="Last Name:" Width="70px"></asp:Label>
    <asp:TextBox ID="LNameTextBox" runat="server" Width="300px"></asp:TextBox>
    <br />
    <asp:Label ID="EmailLabel" runat="server" Text="E-mail:" Width="70px"></asp:Label>
    <asp:TextBox ID="EmailTextBox" runat="server" Width="300px"></asp:TextBox>
    <br />
    <asp:Label ID="CommitteeLabel" runat="server" Text="Committee: " Width ="70px"></asp:Label>   
    <asp:DropDownList ID="ddlCommittee" runat="server" AutoPostBack="True" DataTextField="CommitteeName" DataValueField="CommitteeID" DataSourceID="SqlDataSource1" Width="307px">
    </asp:DropDownList>
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:fk185_ClassConnectionString %>" SelectCommand="SELECT * FROM [Ski_Committee]"></asp:SqlDataSource>
    <br />
    <asp:Button ID="SubmitButton" runat="server" Text="Submit" />
    <br />
    <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label>
        <br />
        <h1>Delete Volunteer</h1>
        <asp:Label ID="EmailLabel2" runat="server" Text="E-mail:"></asp:Label>
        <asp:TextBox ID="DeleteTextBox" runat="server" Width="300px"></asp:TextBox>
        <asp:Button ID="DeleteButton" runat="server" Text="Delete" />
        <br />
        <asp:Label ID="ResultLabel2" runat="server" Text=""></asp:Label>
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Email" DataSourceID="SqlDataSource2" EnableModelValidation="True" ForeColor="#333333" CellPadding="4">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Email" HeaderText="E-mail" ReadOnly="True" SortExpression="Email" />
                <asp:BoundField DataField="FirstName" HeaderText="First Name" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="Last Name" SortExpression="LastName" />
                <asp:BoundField DataField="CommitteeName" HeaderText="Committee Name" SortExpression="CommitteeName" />
            </Columns>
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
        </asp:GridView>
        <br />
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:fk185_ClassConnectionString %>" SelectCommand="SELECT Ski_Volunteer.Email, Ski_Volunteer.FirstName, Ski_Volunteer.LastName, CommitteeName
FROM (Ski_Volunteer INNER JOIN Ski_CompletionCertificate ON Ski_Volunteer.Email = Ski_CompletionCertificate.Email) INNER JOIN Ski_Committee ON Ski_CompletionCertificate.CommitteeID = Ski_Committee.CommitteeID;">
        </asp:SqlDataSource>
    </div>

</asp:Content>

