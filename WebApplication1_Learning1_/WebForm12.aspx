<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm12.aspx.cs" Inherits="WebApplication1_Learning1_.WebForm12" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="Calendar1" runat="server" Caption="Calender Supra"
                CaptionAlign="Top" DayHeaderStyle-BackColor="#FF6666" 
                DayHeaderStyle-ForeColor="White" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>


        </div>
    </form>
</body>
</html>
