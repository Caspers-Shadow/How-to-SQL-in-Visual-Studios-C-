<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Multiple_pages_and_cookies.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body style="background-color: #66FFFF">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="University Info"></asp:Label>
        </div>
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Name:"></asp:Label>
&nbsp;
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Required!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Email:"></asp:Label>
&nbsp;
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEmail" ErrorMessage="Required!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label4" runat="server" Text="Universities"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:RadioButton ID="rdoNWU" runat="server" GroupName="University" OnCheckedChanged="rdoNWU_CheckedChanged" Text="NWU" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:RadioButton ID="rdoUJ" runat="server" GroupName="University" OnCheckedChanged="rdoNWU_CheckedChanged" Text="UJ" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:RadioButton ID="rdoUCT" runat="server" GroupName="University" OnCheckedChanged="rdoNWU_CheckedChanged" Text="UCT" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:RadioButton ID="rdoUP" runat="server" GroupName="University" OnCheckedChanged="rdoNWU_CheckedChanged" Text="UP" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:RadioButton ID="rdoUOFS" runat="server" GroupName="University" OnCheckedChanged="rdoNWU_CheckedChanged" Text="UOFS" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
