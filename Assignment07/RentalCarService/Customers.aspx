<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="RentalCarService.Customers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customers Page</title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        Cartwright&#39;s Car Service&nbsp;&nbsp;&nbsp; Customers</div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Phone" DataSourceID="SqlDataSource1" Width="946px">
            <AlternatingRowStyle BackColor="#99CCFF" />
            <Columns>
                <asp:BoundField DataField="LName" HeaderText="LName" SortExpression="LName" />
                <asp:BoundField DataField="FName" HeaderText="FName" SortExpression="FName" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" ReadOnly="True" SortExpression="Phone" />
                <asp:BoundField DataField="Street" HeaderText="Street" SortExpression="Street" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
                <asp:BoundField DataField="Zip" HeaderText="Zip" SortExpression="Zip" />
                <asp:BoundField DataField="Inv_ID" HeaderText="Inv_ID" SortExpression="Inv_ID" />
                <asp:BoundField DataField="Drivers_License" HeaderText="Drivers_License" SortExpression="Drivers_License" />
                <asp:BoundField DataField="RentalDate" HeaderText="RentalDate" SortExpression="RentalDate" />
            </Columns>
            <HeaderStyle BackColor="#000066" ForeColor="White" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Cars.mdf;Integrated Security=True;MultipleActiveResultSets=True;Connect Timeout=30;Application Name=EntityFramework" SelectCommand="SELECT * FROM [Customer]" ProviderName="System.Data.SqlClient"></asp:SqlDataSource>
    </form>
</body>
</html>
