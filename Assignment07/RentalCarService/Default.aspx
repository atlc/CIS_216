<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RentalCarService.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cartwright's Car Service</title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style2 {
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        Cartwright&#39;s Car Service</div>
        <div class="auto-style2">
            <br />
            <asp:HyperLink ID="CustomersHyperLink" runat="server" NavigateUrl="~/Customers.aspx">Customers</asp:HyperLink>
            <br />
            <asp:HyperLink ID="AddCustomerHyperLink" runat="server" NavigateUrl="~/AddCustomer.aspx">Add Customer</asp:HyperLink>
            <br />
            <asp:HyperLink ID="RentalCarsHyperLink" runat="server" NavigateUrl="~/RentalCars.aspx">Rental Cars</asp:HyperLink>
        </div>
        <br />
        <br />
    </form>
</body>
</html>
