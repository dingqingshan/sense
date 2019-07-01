<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeSearch.aspx.cs" Inherits="Employee.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="css/EmployeeCommon.css"/>
    <link rel="stylesheet" href="css/EmployeeSearch.css"/>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.0/jquery.min.js"></script>
    <script src="javascript/EmployeeSearch.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="main">
            <div id="title">従業員保守システム</div>
            <div id="left">
                <ul>
                    <li class="actived">従業員検索</li>
                    <li class="noActived"><a href="EmployeeRegister.aspx">従業員追加</a></li>
                    <li class="noActived"><a href="EmployeeModify.aspx">従業員編集</a></li>
                </ul>
            </div>
            <div id="right">
                <!--検索条件-->
                <div>
                    <asp:Panel ID="panelInput" runat="server" GroupingText="検索条件">
                        <table id="tableInput">
                            <tr>
                                <td><span>氏名</span></td>
                                <td>
                                    <asp:TextBox ID="txtUserName" runat="server" MaxLength="20"></asp:TextBox>
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
                <!--検索ボタン、クリアボタン-->
                <div id="buttonList">
                    <asp:Button ID="btnSearch" runat="server" Text="検索" OnClick="btnSearch_Click"/>
                    <asp:Button ID="btnClear" runat="server" Text="クリア" OnClick="btnClear_Click" />
                </div>
                <!--結果一覧-->
                <div>
                    <asp:GridView runat="server" id="GridView1" 
                            style ="width:98%;margin:10px;" AutoGenerateColumns="False"
                            AlternatingRowStyle-BackColor ="LightYellow"
                            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" EnableModelValidation="True">
                        <Columns>
                           <asp:TemplateField HeaderText="番号">
                                <ItemTemplate>
                                  <asp:Label runat="server" 
                                      Text ="<%# ((GridViewRow)Container).RowIndex + 1 %>" 
                                      Visible ='<%# Eval("Name") != DBNull.Value  %>' /> 
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="氏名">
                                <ItemTemplate>
                                    <a href="<%# "EmployeeModify.aspx?name1="+ Eval("Name") %>">
                                        <%# Eval("Name") %> 
                                    </a>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:BoundField DataField="Age" HeaderText="年齢" />
                            <asp:BoundField DataField="Country" HeaderText="国籍" />
                            <asp:BoundField DataField="Sex" HeaderText="性別" />
                        </Columns>
                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                        <RowStyle ForeColor="#000066" />
                    </asp:GridView>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
