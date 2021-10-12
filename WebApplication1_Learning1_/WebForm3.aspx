<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1_Learning1_.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlContinents" Width="200px" runat="server" 
                OnSelectedIndexChanged="ddlContinents_SelectedIndexChanged" DataTextField="ContinentName"
                DatavalueField="ContinentId" AutoPostBack="True" >                
            </asp:DropDownList>

            <br />    <br />
            <asp:DropDownList ID="ddlCountries" Width="200px" runat="server" 
                DataTextfield="CountryName" DataValueField="CountryId"
                OnSelectedIndexChanged="ddlCountries_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            <br />    <br />
            <asp:DropDownList ID="ddlCities" Width="200px" runat="server"
                DataTextfield="CityName" DataValueField="CityId"
                OnSelectedIndexChanged="ddlCities_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
