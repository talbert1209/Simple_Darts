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
            Player Name:
            <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="startButton" runat="server" Text="Start Game" OnClick="startButton_Click" />
            <br />
            <asp:Label ID="messageLabel" runat="server" ForeColor="#CC3300"></asp:Label>
            <br />
            <br />
            <img alt="Dart Board" class="auto-style1" longdesc="Image Of Dart Board" src="Challenge%20Resources/DartBoard2.jpg" /><br />
            <br />
            <asp:Label ID="dart1Label" runat="server" Text="Dart 1:"></asp:Label>
&nbsp;<asp:Label ID="dart1ResultLabel" runat="server"></asp:Label>
&nbsp;<asp:Label ID="dart2Label" runat="server" Text="Dart 2:"></asp:Label>
&nbsp;<asp:Label ID="dart2ResultLabel" runat="server"></asp:Label>
&nbsp;<asp:Label ID="dart3Label" runat="server" Text="Dart 3:"></asp:Label>
&nbsp;<asp:Label ID="dart3ResultLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="humanScoreLabel" runat="server" Text="Player 1 Score:"></asp:Label>
&nbsp;<asp:Label ID="humanScoreResultLabel" runat="server"></asp:Label>
&nbsp;<asp:Label ID="computerScoreLabel" runat="server" Text="Computer Score:"></asp:Label>
&nbsp;<asp:Label ID="computerScoreResultLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:ImageButton ID="dart1Button" runat="server" Height="40px" ImageUrl="~/Challenge Resources/Dart.jpg" OnClick="dart1Button_Click" />
&nbsp;<br />
            <asp:ImageButton ID="dart2Button" runat="server" Height="40px" ImageUrl="~/Challenge Resources/Dart.jpg" OnClick="dart2Button_Click" />
&nbsp;<br />
            <asp:ImageButton ID="dart3Button" runat="server" Height="40px" ImageUrl="~/Challenge Resources/Dart.jpg" OnClick="dart3Button_Click" />
        </div>
    </form>
</body>
</html>
