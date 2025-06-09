<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArtClub.aspx.cs" Inherits="Validation_and_drop_down_lists.ArtClub" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 704px;
        }
        .auto-style5 {
            width: 60px;
        }
        .auto-style6 {
            width: 143px;
        }
        .auto-style7 {
            width: 211px;
            height: 72px;
            text-align: right;
        }
        .auto-style8 {
            width: 60px;
            height: 72px;
        }
        .auto-style9 {
            width: 143px;
            height: 72px;
        }
        .auto-style10 {
            width: 704px;
            height: 72px;
        }
        .auto-style11 {
            width: 211px;
            text-align: right;
        }
        .auto-style12 {
        }
        .auto-style13 {
            height: 68px;
        }
    </style>
</head>
<body style="background-color: #CCCCCC">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#0066FF" Text="Art Club Pen Order Form"></asp:Label>
        </div>
        <table style="width: 100%;">
            <tr>
                <td class="auto-style11">
                    <asp:Label ID="Label1" runat="server" Text="First Name:"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label2" runat="server" Text="Last Name:"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSurname" ErrorMessage="Required!"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">
                    <asp:Label ID="Label3" runat="server" Text="Phone Number:"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label5" runat="server" Text="Email Address:"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
&nbsp;&nbsp;
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Invalid email address" ValidationExpression="^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label4" runat="server" Text="Pen Selections for order:"></asp:Label>
                </td>
                <td class="auto-style8"></td>
                <td class="auto-style9">
                    <asp:Button ID="btnOrder" runat="server" Height="42px" OnClick="btnOrder_Click" Text="Place order" Width="143px" />
                </td>
                <td class="auto-style10"></td>
            </tr>
            <tr>
                <td class="auto-style11">
                    <asp:Label ID="Label6" runat="server" Text="Colour:"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:DropDownList ID="ddlColour" runat="server">
                        <asp:ListItem>Red</asp:ListItem>
                        <asp:ListItem>Black</asp:ListItem>
                        <asp:ListItem>Green</asp:ListItem>
                        <asp:ListItem>Blue</asp:ListItem>
                        <asp:ListItem>Rainbow</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label7" runat="server" Text="Amount:"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtAmount" runat="server" Width="40px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtAmount" ErrorMessage="Amount not valid" MaximumValue="9" MinimumValue="101"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style13" style="text-align: center">
                    <asp:Label ID="lblResult" runat="server" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style13" style="text-align: center">&nbsp;</td>
                <td class="auto-style13" style="text-align: center">&nbsp;</td>
                <td class="auto-style13" style="text-align: center">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12" style="text-align: left">
                    <asp:Label ID="lblAmount" runat="server" Font-Italic="True"></asp:Label>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:Label ID="lblTax" runat="server" Font-Italic="True"></asp:Label>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:Label ID="lblTotal" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
