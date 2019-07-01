<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeModify.aspx.cs" Inherits="Employee.EmployeeModify" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="css/EmployeeCommon.css"/>
    <link rel="stylesheet" href="css/EmployeeModify.css"/>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.0/jquery.min.js"></script>
    <script src="javascript/EmployeeModify.js"></script>
</head>
<body>
    <form id="form1" runat="server">
       <div id="main">
            <div id="title">従業員保守システム</div>
            <div id="left">
                <ul>
                    <li class="noActived"><a href="EmployeeSearch.aspx">従業員検索</a></li>
                    <li class="noActived"><a href="EmployeeRegister.aspx">従業員追加</a></li>
                    <li class="actived">従業員編集</li>
                </ul>
            </div>
            <div id="right">
                <!--入力情報-->
                <div>
                    <asp:Panel ID="panelInput" runat="server" GroupingText="入力情報">
                        <table id="tableInput">
                            <tr>
                                <td><span>氏名</span></td>
                                <td>
                                    <asp:TextBox ID="txtUserName" runat="server" MaxLength="20" Enabled="False"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td><span>年齢</span></td>
                                <td>
                                    <asp:TextBox ID="txtAge" runat="server" MaxLength="2"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td><span>国籍</span></td>
                                <td>
                                    <asp:DropDownList ID="drpCountry" runat="server" Enabled="True"></asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td><span>性別</span></td>
                                <td>
                                    <asp:RadioButton ID="rdoMan" runat="server"  Text="男性" GroupName="rdoSex"　/>
                                    <asp:RadioButton ID="rdoWoman" runat="server"  Text="女性" GroupName="rdoSex"　/>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </div>
                <!--編集ボタン、クリアボタン-->
                <div id="buttonList">
                    <asp:Button ID="btnModify" runat="server" Text="編集"  OnClick="btnModify_Click"　/>
                    <asp:Button ID="btnClear" runat="server" Text="クリア" OnClick="btnClear_Click" />
                </div>
                <!--結果一覧-->
                <div></div>
            </div>
        </div>
    </form>
</body>
</html>
