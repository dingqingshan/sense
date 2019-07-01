<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Employee.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>ログイン</title>
    <link rel="stylesheet" href="css/Login.css"/>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.0/jquery.min.js"></script>
    <script src="javascript/Login.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="divMain">
            <span id="spanTitle">従業員保守システム</span>
            <table id="tableMain">
                <tr>
                    <td>UserName:</td>
                    <td><asp:TextBox ID="txtUser" runat="server" MaxLength="20"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Password:</td>
                    <td><asp:TextBox ID="txtPassword" runat="server" MaxLength="10" TextMode="Password"></asp:TextBox></td>
                </tr>
            </table>

            <asp:Button ID="btnLogin" runat="server" Text="ログイン" OnClientClick="return loginClick();" OnClick="btnLogin_Click" />
            <asp:HiddenField ID="hdnErrorMsg" runat="server" Value="" />
        </div>
    </form>
</body>
</html>
