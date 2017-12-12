<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCustomer.aspx.cs" Inherits="RentalCarService.AddCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Customer</title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style2 {
            width: 123px;
        }
        .auto-style3 {
            width: 381px;
        }
        </style>
</head>
<body style="height: 45px">
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        Cartwright&#39;s Car Service&nbsp;&nbsp;&nbsp; Add Customer<br />
        <br />
    
    </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style2">Last Name:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="LastNameTextBox" ErrorMessage="This field is required."></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">First Name:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="FirstNameTextBox" ErrorMessage="This field is required."></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Phone:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="PhoneNumberTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="PhoneNumberTextBox" ErrorMessage="This field is required."></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Street Address:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="StreetAddressTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="StreetAddressTextBox" ErrorMessage="This field is required."></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">City:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="CityTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="CityTextBox" ErrorMessage="This field is required."></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">State:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="StateTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="StateTextBox" ErrorMessage="This field is required."></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Zip:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="ZIPCodeTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="ZIPCodeTextBox" ErrorMessage="This field is required."></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Driver&#39;s License:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="DriversLicenseTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="DriversLicenseTextBox" ErrorMessage="This field is required."></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;
                    <asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click" Text="Submit" />
&nbsp;&nbsp;
                    <asp:Button ID="ClearButton" runat="server" OnClick="ClearButton_Click" Text="Clear" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
