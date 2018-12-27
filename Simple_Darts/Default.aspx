<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Simple_Darts.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 425px;
            height: 421px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Tim&#39;s Dart Parlor</h1>
            <br />
            <br />
            <img alt="Dart Board" class="auto-style1" longdesc="Image Of Dart Board" src="Challenge%20Resources/DartBoard2.jpg" /><br />
            <br />
            <asp:Label ID="throwResultLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="throwButton" runat="server" OnClick="throwButton_Click" Text="Throw" />
        </div>
    </form>
</body>
</html>
