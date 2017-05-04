<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DonationPage.aspx.cs" Inherits="DonationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Donation Page</h1>
        <table>
            <tr>
                <td>Name </td>
                <td><asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Address </td>
                <td><asp:TextBox ID="AddressTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Email </td>
                <td><asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Donation Amount </td>
                <td><asp:TextBox ID="DonationTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" /></td>
            </tr>
            
        </table>
    

    </div>
    </form>
</body>
</html>
