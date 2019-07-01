using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employee
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //网址会发生变化
            if (this.txtUser.Text == "999" && this.txtPassword.Text == "123")
            {
                Response.Redirect("EmployeeSearch.aspx");
            }
            else
            {
                this.hdnErrorMsg.Value = "パスワードが間違っているようです。もう一度入力してください。";
            }
        }
    }
}