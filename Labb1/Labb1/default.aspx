<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Labb1._default" ViewStateMode="Disabled"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Labb 1</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="boxWithText" runat="server" Height="353px" TextMode="MultiLine" Width="893px"></asp:TextBox>
    </div>
        <p>
            <asp:Label ID="outputData" runat="server" Text="0"></asp:Label>
        <asp:Button ID="countButton" runat="server" Text="count" OnClick="countButton_Click" ViewStateMode="Enabled" />
        </p>
    </form>
</body>
</html>
