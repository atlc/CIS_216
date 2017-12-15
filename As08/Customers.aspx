<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Customers.aspx.cs" Inherits="Customers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Customers</div>
        <asp:GridView ID="CustomersGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="Phone" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display.">
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CarsConnectionString1 %>" DeleteCommand="DELETE FROM [Customer] WHERE [Phone] = @Phone" InsertCommand="INSERT INTO [Customer] ([LName], [FName], [Phone], [Street], [City], [State], [Zip], [Inv_ID], [Drivers_License], [RentalDate]) VALUES (@LName, @FName, @Phone, @Street, @City, @State, @Zip, @Inv_ID, @Drivers_License, @RentalDate)" ProviderName="<%$ ConnectionStrings:CarsConnectionString1.ProviderName %>" SelectCommand="SELECT [LName], [FName], [Phone], [Street], [City], [State], [Zip], [Inv_ID], [Drivers_License], [RentalDate] FROM [Customer]" UpdateCommand="UPDATE [Customer] SET [LName] = @LName, [FName] = @FName, [Street] = @Street, [City] = @City, [State] = @State, [Zip] = @Zip, [Inv_ID] = @Inv_ID, [Drivers_License] = @Drivers_License, [RentalDate] = @RentalDate WHERE [Phone] = @Phone">
            <DeleteParameters>
                <asp:Parameter Name="Phone" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="LName" Type="String" />
                <asp:Parameter Name="FName" Type="String" />
                <asp:Parameter Name="Phone" Type="String" />
                <asp:Parameter Name="Street" Type="String" />
                <asp:Parameter Name="City" Type="String" />
                <asp:Parameter Name="State" Type="String" />
                <asp:Parameter Name="Zip" Type="String" />
                <asp:Parameter Name="Inv_ID" Type="String" />
                <asp:Parameter Name="Drivers_License" Type="String" />
                <asp:Parameter Name="RentalDate" Type="DateTime" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="LName" Type="String" />
                <asp:Parameter Name="FName" Type="String" />
                <asp:Parameter Name="Street" Type="String" />
                <asp:Parameter Name="City" Type="String" />
                <asp:Parameter Name="State" Type="String" />
                <asp:Parameter Name="Zip" Type="String" />
                <asp:Parameter Name="Inv_ID" Type="String" />
                <asp:Parameter Name="Drivers_License" Type="String" />
                <asp:Parameter Name="RentalDate" Type="DateTime" />
                <asp:Parameter Name="Phone" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
