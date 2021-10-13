<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm13.aspx.cs" Inherits="WebApplication1_Learning1_.WebForm13" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="HiddenField1" runat="server" />
            <table>
                <tr>
               <td><b>Name:</b></td>
                    <td>
                        
                    <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
                    </td>

                </tr>

                 <tr>
               <td>Gender:</td>
                    <td>

                        
                    <asp:TextBox ID="TxtGender" runat="server"></asp:TextBox>
                    </td>

                </tr>
                 <tr>
               <td>Department</td>
                    <td>
                    <asp:TextBox ID="TxtDept" runat="server"></asp:TextBox>

                    </td>

                </tr>

            </table>
            <asp:Button ID="UploadEmp"  runat="server" Text="Upload Emp" OnClick="Button1_Click" Width="108px" /> 

            
            <asp:Button ID="UpdateEmp"  runat="server" Text="Update Emp" OnClick="Button2_Click" style="margin-left: 23px" Width="133px" />

        </div>
    </form>
</body>
</html>
