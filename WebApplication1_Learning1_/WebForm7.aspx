<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="WebApplication1_Learning1_.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="PrintBtn" runat="server"  oncommand="CommandBtn_Click" CommandName="Print" Text="Print" Width="186px" />
            <asp:Button ID="DeleteBtn" runat="server" oncommand="CommandBtn_Click" CommandName="Delete"
                Text="Delete" Width="245px" />

            <br />
            <asp:Button ID="Showtop10Btn" runat="server" oncommand="CommandBtn_Click" CommandName="Show" CommandArgument="Top10"
                Text="ShowTop10" Width="186px" />
            <asp:Button ID="ShowBottomBtn" runat="server" oncommand="CommandBtn_Click" CommandName="Show" CommandArgument="Bottom10"
                Text="ShowBottom10" Width="245px" />
            <br />  <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>


        </div>
        
    </form>
</body>
</html>
