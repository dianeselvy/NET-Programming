<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GetGrants.aspx.cs" Inherits="GetGrants" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="UserDropDownList" runat="server" AutoPostBack="True" 
            OnSelectedIndexChanged="UserDropDownList_SelectedIndexChanged"></asp:DropDownList>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>

