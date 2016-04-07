<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstAndLastName.aspx.cs" Inherits="FirstAndLastName.FirstAndLastName" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>First and Last Name</title>
</head>
<body>
    <form id="form1" runat="server">
        <p>Please enter your first and last name:</p>
        <p>
            First Name:
            <asp:TextBox ID="tbFirst" runat="server"></asp:TextBox>
        </p>
        <p>
            Last Name:
            <asp:TextBox ID="tbLast" runat="server"></asp:TextBox>
        </p>
        <div id="right">
        <asp:Button ID="btnFinish" runat="server" Text="Finish!" OnClick="btnFinish_Click" />
        
        </div>    
        <asp:Label ID="lblChangeMe" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
