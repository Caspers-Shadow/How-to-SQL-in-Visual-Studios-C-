<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Scheduler.aspx.cs" Inherits="Calender_Control.Scheduler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        #form1 {
            text-align: center;
        }
    </style>
</head>
<body style="background-color: #66FFFF">
    <form id="form1" runat="server">
        <div style="text-align: center">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Study scheduler"></asp:Label>
        </div>
        <table style="width:100%;">
            <tr>
                <td style="text-align: right">
                    <asp:Label ID="Label2" runat="server" Text="Module:"></asp:Label>
                </td>
                <td style="text-align: left">&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtModule" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <p class="auto-style1">
            <asp:Label ID="Label3" runat="server" Text="Select the date from the calender for when you plan to study for a module"></asp:Label>
        </p>
        <asp:Calendar ID="theCal" runat="server" OnSelectionChanged="theCal_SelectionChanged" style="text-align: center" Width="423px"></asp:Calendar>
        <asp:Label ID="lblError" runat="server" Font-Italic="True" ForeColor="Red" Text="Please select an upcoming date - in the future"></asp:Label>
        <br />
        <br />
        <asp:ListBox ID="lstOutput" runat="server" Width="370px"></asp:ListBox>
        <br />
    </form>
</body>
</html>
