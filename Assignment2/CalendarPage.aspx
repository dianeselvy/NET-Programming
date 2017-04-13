<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CalendarPage.aspx.cs" Inherits="CalendarPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="AssignmentTwoStyles.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Welcome to Diane's calendar!</h1><br />
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" CssClass="Calendar">
            <TitleStyle BackColor="white" ForeColor="#CC1188"></TitleStyle>
        </asp:Calendar>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Holiday #1" CssClass="result1"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Holiday #2" CssClass="result2"></asp:Label>
    </div>
    </form>
</body>
</html>
