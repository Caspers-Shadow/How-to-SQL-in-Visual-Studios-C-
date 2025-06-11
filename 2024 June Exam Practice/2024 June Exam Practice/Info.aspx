<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Info.aspx.cs" Inherits="_2024_June_Exam_Practice.Info" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 477px;
            text-align: left;
        }
        .auto-style3 {
            text-align: right;
        }
        .auto-style5 {
            width: 477px;
            text-align: right;
        }
        .auto-style6 {
            width: 41px;
        }
        .auto-style7 {
            text-align: right;
            width: 41px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Pochefstroom Load Shedding Survival Guide"></asp:Label>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lblWelcome" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lblZone" runat="server" Font-Bold="False" Font-Size="Medium"></asp:Label>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td>
                    <asp:Label ID="label" runat="server" Font-Bold="False" Font-Size="Medium">Select date to see future forecast:</asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="label2" runat="server" Font-Bold="False" Font-Size="Medium">Today&#39;s load shedding forecast:</asp:Label>
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="label3" runat="server" Font-Bold="False" Font-Size="Medium">There is load shedding today at the following times</asp:Label>
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblTimes" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td>
                    <asp:Calendar ID="theCal" runat="server" BackColor="#3399FF" ForeColor="White" OnSelectionChanged="theCal_SelectionChanged"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Button ID="btnHome" runat="server" BackColor="#3399FF" ForeColor="White" Height="39px" OnClick="btnHome_Click" Text="Home" Width="85px" />
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
