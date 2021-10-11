<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1_Learning1_.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Text="Doctor" Selected="True" Value="1"></asp:ListItem>
                <asp:ListItem Text="Engineer" Value="2"></asp:ListItem>
                <asp:ListItem Text="Teacher" Value="3"></asp:ListItem>
                <asp:ListItem Text="Writer" Value="4"></asp:ListItem>

            </asp:CheckBoxList>
            <br />
             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" style="height: 26px" />
    
               <br />
                <asp:Button ID="Button2" runat="server" Text="SelectAll" OnClick="Button2_Click" />
               <br />
            <asp:Button ID="Button3" runat="server" Text="DeSelect All" OnClick="Button3_Click" />
        </div>
       
    </form>
</body>
</html>
