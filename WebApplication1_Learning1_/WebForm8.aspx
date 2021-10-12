<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="WebApplication1_Learning1_.WebForm8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal" 
                AutoPostBack="True" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
                <asp:ListItem Text="Diploma" Value="1"></asp:ListItem>
                <asp:ListItem Text="Btech" Value="2"></asp:ListItem>
                <asp:ListItem Text="Inter" Value="3"></asp:ListItem>
                <asp:ListItem Text="Stage" Value="4"></asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="78px" Width="127px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" SelectionMode="Multiple" ></asp:ListBox>
             <br />
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True"></asp:Label>
             <br />
            <br />

        </div>
    </form>
</body>
</html>
