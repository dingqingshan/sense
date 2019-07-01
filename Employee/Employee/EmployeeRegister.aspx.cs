using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Employee
{
    public partial class EmployeeRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //国籍の初期値設定
                this.drpCountry.Items.Add("");
                this.drpCountry.Items.Add("Anhui");
                this.drpCountry.Items.Add("BeiJing");
                this.drpCountry.Items.Add("LiaoNing");
                this.drpCountry.Items.Add("JiLin");
                this.drpCountry.Items.Add("ShangHai");
                this.drpCountry.Items.Add("ShanDong");

                //ListItem item1 = new ListItem("AnhuiXXX","123");
                //this.drpCountry.Items.Add(item1);
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            InitPageAAAAA();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable dt = ((DataTable)Session["GridViewData"]);

            DataRow dr = dt.NewRow();
            dr["Name"] = this.txtUserName.Text; //氏名
            dr["Age"] = this.txtAge.Text;       //年齢
            dr["Country"] = this.drpCountry.Text;//国籍
            if(this.rdoMan.Checked)             //性別
            {
                dr["Sex"] = "男性";
            }
            else if(this.rdoWoman.Checked)
            {
                dr["Sex"] = "女性";
            }
            //dr["Sex"] = this.rdoMan.Checked ? "男性" : "女性";

            //新規行追加
            dt.Rows.Add(dr);

            InitPageAAAAA();

            //アラート
            Response.Write("<script>alert('成功に追加しました。');</script>");
        }

        private void InitPageAAAAA()
        {
            this.txtUserName.Text = "";     //氏名
            this.txtAge.Text = "";          //年齢
            this.drpCountry.SelectedIndex = 0;//国籍

            this.rdoMan.Checked = false;    //性別（男性）
            this.rdoWoman.Checked = false;  //性別（女性）
        }
    }
}