<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication1_Learning1_.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>




            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Width="200px">
                <asp:ListItem Value="1">Male</asp:ListItem>
                <asp:ListItem Value="2">Female</asp:ListItem>
            </asp:DropDownList>

            <br />
            <br />

            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" Width="200px">
                <asp:ListItem Value="1">Male</asp:ListItem>
                <asp:ListItem Value="2" Selected="True">Female</asp:ListItem>
            </asp:DropDownList>




        </div>
    </form>
</body>
</html>
