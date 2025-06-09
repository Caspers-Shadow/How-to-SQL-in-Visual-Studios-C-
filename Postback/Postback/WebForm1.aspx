<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Postback.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Concert Booking"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Name and Surname:"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Number of tickets:"></asp:Label>
            <br />
            <asp:RadioButton ID="rdoOne" runat="server" GroupName="Ticket amount" Text="1" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="rdoTwo" runat="server" GroupName="Ticket amount" Text="2" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="rdoThree" runat="server" GroupName="Ticket amount" Text="3" />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Select show tjme:"></asp:Label>
            <br />
            <asp:Button ID="btnMorning" runat="server" CausesValidation="False" OnClick="btnMorning_Click" Text="11:00" />
&nbsp;<asp:Button ID="btnMidday" runat="server" CausesValidation="False" OnClick="btnMidday_Click" Text="14:00" />
&nbsp;<asp:Button ID="btnEvening" runat="server" CausesValidation="False" OnClick="btnEvening_Click" Text="17:00" />
            <br />
            <br />
            <br />
            <asp:Button ID="btnBook" runat="server" Height="50px" OnClick="btnBook_Click" Text="Book" Width="354px" />
            <br />
            <asp:Label ID="lblDisplay" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
