<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Labb1._default" %>

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
            <asp:Label ID="outputData" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="countButton" runat="server" Text="Button" OnClick="countButton_Click" />
        </p>
    </form>
</body>
</html>
