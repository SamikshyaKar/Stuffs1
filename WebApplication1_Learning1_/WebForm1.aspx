<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1_Learning1_.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ListBox</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple">
            <asp:ListItem Text="Doctor" Value="1"></asp:ListItem>
            <asp:ListItem Text="Engineer" Value="2"></asp:ListItem>
            <asp:ListItem Text="Writer" Value="3"></asp:ListItem>
            <asp:ListItem Text="Teacher" Value="4"></asp:ListItem>                
            </asp:ListBox>
            <br />            <br />

            
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

            <br />
            <br />
                    <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
        </div>

    </form>
</body>
</html>
