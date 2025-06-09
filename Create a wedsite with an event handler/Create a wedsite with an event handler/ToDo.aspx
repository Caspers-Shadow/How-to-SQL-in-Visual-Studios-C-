<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ToDo.aspx.cs" Inherits="Create_a_wedsite_with_an_event_handler.ToDo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            background-color: #999999;
        }
        .auto-style2 {
            text-align: center;
            background-color: #999999;
        }
        .auto-style5 {
            width: 592px;
            background-color: #999999;
        }
        .auto-style6 {
            text-align: center;
            width: 592px;
            background-color: #999999;
        }
        .auto-style7 {
            text-align: left;
            background-color: #999999;
        }
    </style>
</head>
<body style="text-align: left; background-color: #808080">
    <form id="form1" runat="server">
        <div style="background-color: #CCCCCC">
            <table style="width:100%;">
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" ForeColor="White" Text="Grocery List Creator"></asp:Label>
                    </td>
                    <td class="auto-style1">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label3" runat="server" ForeColor="Aqua" Text="Enter your name to create your own personalized GROCERY list!!!!!!!!!"></asp:Label>
                    </td>
                    <td class="auto-style1">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label2" runat="server" Font-Size="X-Large" ForeColor="White" Text="Name:"></asp:Label>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style1">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label4" runat="server" ForeColor="Aqua" Text="Item needed from the store:"></asp:Label>
                        <asp:TextBox ID="txtItems" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style1">
                        <asp:Button ID="btnAdd" runat="server" Font-Size="X-Small" OnClick="Button1_Click" Text="Add to list" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label5" runat="server" ForeColor="#66FF66" Text="Grocery List"></asp:Label>
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6" rowspan="3">
                        <asp:ListBox ID="lstList" runat="server" Height="124px" OnSelectedIndexChanged="lstList_SelectedIndexChanged" style="text-align: center" Width="255px"></asp:ListBox>
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label6" runat="server" Font-Italic="True" ForeColor="#FF0066" Text="Select items from the list to remove them"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Message" runat="server" Font-Size="X-Large" ForeColor="White"></asp:Label>
                    </td>
                    <td class="auto-style1">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
