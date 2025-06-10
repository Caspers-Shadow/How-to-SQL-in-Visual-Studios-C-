<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kennel.aspx.cs" Inherits="Adding_a_database__WebApps_.Kennel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 48px;
        }
    </style>
</head>
<body style="background-color: #66CCFF">
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" ForeColor="#CC33FF" Text="Happy Pet Kennel"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td rowspan="3">
                        <asp:GridView ID="gvView" runat="server" BackColor="#33CC33" ForeColor="White">
                        </asp:GridView>
                    </td>
                    <td>
                        <asp:Button ID="btnAll" runat="server" Font-Bold="True" OnClick="btnAll_Click" Text="Show all the pets" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="btnLarge" runat="server" Font-Bold="True" OnClick="btnLarge_Click" Text="Show all large pets" />
                    </td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblError" runat="server"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
