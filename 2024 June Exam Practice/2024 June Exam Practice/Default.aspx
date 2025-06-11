<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_2024_June_Exam_Practice.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 172px;
            text-align: center;
        }
        .auto-style2 {
            width: 172px;
            text-align: right;
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style4 {
            width: 456px;
            text-align: left;
        }
        .auto-style5 {
            height: 26px;
            width: 429px;
        }
        .auto-style6 {
            width: 463px;
            text-align: center;
        }
        .auto-style7 {
            width: 429px;
            text-align: left;
        }
        .auto-style8 {
            width: 172px;
            text-align: right;
        }
        .auto-style9 {
            width: 282px;
        }
        .auto-style10 {
            height: 26px;
            width: 282px;
        }
        .auto-style11 {
            width: 172px;
            text-align: center;
            height: 57px;
        }
        .auto-style12 {
            width: 429px;
            text-align: left;
            height: 57px;
        }
        .auto-style13 {
            width: 282px;
            height: 57px;
        }
        .auto-style14 {
            height: 57px;
        }
        .auto-style15 {
            width: 172px;
            text-align: center;
            height: 56px;
        }
        .auto-style16 {
            width: 429px;
            text-align: left;
            height: 56px;
        }
        .auto-style17 {
            width: 282px;
            height: 56px;
        }
        .auto-style18 {
            height: 56px;
        }
        .auto-style19 {
            width: 172px;
            text-align: center;
            height: 58px;
        }
        .auto-style20 {
            width: 429px;
            text-align: left;
            height: 58px;
        }
        .auto-style21 {
            width: 282px;
            height: 58px;
        }
        .auto-style22 {
            height: 58px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center; width: 453px">
            <table style="width: 215%;">
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Pochefstroom Load Shedding Survival Guide"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:Image ID="Image1" runat="server" Height="97px" ImageUrl="~/images.jpeg-51.jpg" style="margin-left: 48px" Width="162px" />
                    </td>
                </tr>
            </table>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label2" runat="server" Text="Name:"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtName" runat="server" Height="32px" Width="253px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Name Required!" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style9">
                    <asp:RadioButton ID="rdoZone1" runat="server" Font-Bold="True" GroupName="Zone" Text="Zone1 - Cebtral Business District" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label3" runat="server" Text="Surname:"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtSurname" runat="server" Height="32px" Width="253px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSurname" ErrorMessage="Surname Required!" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style9">
                    <asp:RadioButton ID="rdoZone2" runat="server" Font-Bold="True" GroupName="Zone" Text="Zone 2 - Van Der Hoff Park" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="Email:"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtEmail" runat="server" Height="32px" Width="253px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email invalid!" SetFocusOnError="True" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"></asp:RegularExpressionValidator>
                </td>
                <td class="auto-style10">
                    <asp:RadioButton ID="rdoZone3" runat="server" Font-Bold="True" GroupName="Zone" Text="Zone 3 - Bult Area and University" />
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style11"></td>
                <td class="auto-style12"></td>
                <td class="auto-style13">
                    <asp:RadioButton ID="rdoZone4" runat="server" Font-Bold="True" GroupName="Zone" Text="Zone 4 - Grimbeek Park nad Baillie" />
                </td>
                <td class="auto-style14"></td>
            </tr>
            <tr>
                <td class="auto-style15"></td>
                <td class="auto-style16"></td>
                <td class="auto-style17">
                    <asp:RadioButton ID="rdoZone5" runat="server" Font-Bold="True" GroupName="Zone" Text="Zone 5 - Mohadin and Promosa" />
                </td>
                <td class="auto-style18"></td>
            </tr>
            <tr>
                <td class="auto-style19"></td>
                <td class="auto-style20"></td>
                <td class="auto-style21">
                    <asp:RadioButton ID="rdoZone6" runat="server" Font-Bold="True" GroupName="Zone" Text="Zone 6 - Ikageng" />
                </td>
                <td class="auto-style22"></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" BackColor="#3399FF" ForeColor="White" OnClick="btnSubmit_Click" Text="Submit" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
