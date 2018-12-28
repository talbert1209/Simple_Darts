<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Simple_Darts.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 352px;
            height: 351px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Tim&#39;s Dart Parlor</h1>
            <img alt="Dart Board" class="auto-style1" longdesc="Image Of Dart Board" src="Challenge%20Resources/DartBoard2.jpg" /><br />
            <br />
            <asp:Label ID="throwResultLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" Height="60px" ImageUrl="~/Challenge Resources/Dart.jpg" />
&nbsp;<br />
            <asp:ImageButton ID="ImageButton2" runat="server" Height="60px" ImageUrl="~/Challenge Resources/Dart.jpg" />
&nbsp;<br />
            <asp:ImageButton ID="ImageButton3" runat="server" Height="60px" ImageUrl="~/Challenge Resources/Dart.jpg" />
            <br />
            <br />
            <asp:Button ID="throwButton" runat="server" OnClick="throwButton_Click" Text="Throw" />
        </div>
    </form>
</body>
</html>
