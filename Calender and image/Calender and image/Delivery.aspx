<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delivery.aspx.cs" Inherits="Calender_and_image.Delivery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 344px;
        }
        .auto-style2 {
            width: 56px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Speedy Delivery"></asp:Label>
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                    <td style="text-align: left">
                        <asp:Image ID="imgPic" runat="server" Height="135px" ImageUrl="~/eaf8ae05a76fd1c639c22e924025326e.jpg" Width="241px" />
                    </td>
                </tr>
            </table>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Select the dropoff date:"></asp:Label>
            &nbsp;</p>
        <p>
            <asp:Calendar ID="theCal" runat="server" OnSelectionChanged="theCal_SelectionChanged"></asp:Calendar>
        </p>
        <p>
            <asp:Label ID="lblOut" runat="server" Font-Bold="True" Text="The item will be delivered:"></asp:Label>
        </p>
    </form>
</body>
</html>
