<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RentalCars.aspx.cs" Inherits="RentalCars" %>

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
            Rental Cars</div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CarsConnectionString1 %>" DeleteCommand="DELETE FROM [Vehicle] WHERE [Inv_ID] = @Inv_ID" InsertCommand="INSERT INTO [Vehicle] ([Inv_ID], [Manuf_Name], [Model], [CarSize]) VALUES (@Inv_ID, @Manuf_Name, @Model, @CarSize)" ProviderName="<%$ ConnectionStrings:CarsConnectionString1.ProviderName %>" SelectCommand="SELECT [Inv_ID], [Manuf_Name], [Model], [CarSize] FROM [Vehicle]" UpdateCommand="UPDATE [Vehicle] SET [Manuf_Name] = @Manuf_Name, [Model] = @Model, [CarSize] = @CarSize WHERE [Inv_ID] = @Inv_ID">
            <DeleteParameters>
                <asp:Parameter Name="Inv_ID" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Inv_ID" Type="String" />
                <asp:Parameter Name="Manuf_Name" Type="String" />
                <asp:Parameter Name="Model" Type="String" />
                <asp:Parameter Name="CarSize" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Manuf_Name" Type="String" />
                <asp:Parameter Name="Model" Type="String" />
                <asp:Parameter Name="CarSize" Type="String" />
                <asp:Parameter Name="Inv_ID" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="CarSize" DataValueField="CarSize">
        </asp:DropDownList>
        <asp:GridView ID="RentalCarsGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="Inv_ID" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display.">
            <AlternatingRowStyle BackColor="#99CCFF" />
            <Columns>
                <asp:BoundField DataField="Inv_ID" HeaderText="Inv_ID" ReadOnly="True" SortExpression="Inv_ID" />
                <asp:BoundField DataField="Manuf_Name" HeaderText="Manuf_Name" SortExpression="Manuf_Name" />
                <asp:BoundField DataField="Model" HeaderText="Model" SortExpression="Model" />
                <asp:BoundField DataField="CarSize" HeaderText="CarSize" SortExpression="CarSize" />
            </Columns>
            <HeaderStyle BackColor="#000066" ForeColor="White" />
        </asp:GridView>
    </form>
</body>
</html>
