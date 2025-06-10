<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Sessions.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Concert Booking"></asp:Label>
            <br />
        </div>
        <asp:Label ID="Label4" runat="server" Text="Name and surname:"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Number of tickets:"></asp:Label>
        <br />
        <asp:RadioButton ID="rdoOne" runat="server" GroupName="Ticket Numbers" Text="1" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="rdoTwo" runat="server" GroupName="Ticket Numbers" Text="2" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="rdoThree" runat="server" GroupName="Ticket Numbers" Text="3" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Select show time:"></asp:Label>
        <br />
        <asp:Button ID="btnMorning" runat="server" OnClick="btnMorning_Click" Text="11:00" />
&nbsp;
        <asp:Button ID="btnMidday" runat="server" OnClick="btnMidday_Click" Text="14:00" />
&nbsp;
        <asp:Button ID="btnEvening" runat="server" OnClick="btnEvening_Click" Text="17:00" />
        <br />
        <br />
        <br />
        <asp:Button ID="btnBook" runat="server" Height="44px" OnClick="btnBook_Click" Text="Book" Width="404px" />
        <br />
        <br />
        <asp:Label ID="lblDisplay" runat="server"></asp:Label>
    </form>
</body>
</html>
