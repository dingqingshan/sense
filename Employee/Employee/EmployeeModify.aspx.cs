using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Employee
{
    public partial class EmployeeModify : System.Web.UI.Page
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

                //Urlパラメータ取得
                //string url = Page.Request.RawUrl;
                string query1 = Page.Request.QueryString["name1"];

                //Urlの氏名より、画面初期化を行う
                DataTable dt = ((DataTable)Session["GridViewData"]);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    //氏名
                    string name = dr["Name"].ToString();
                    if (name == query1)
                    {
                        //氏名
                        this.txtUserName.Text = name;//  dr["Name"].ToString();
                        //年齢
                        this.txtAge.Text = dr["Age"].ToString();
                        //国籍
                        this.drpCountry.Text = dr["Country"].ToString();
                        //性別
                        if (dr["Sex"].ToString() == "男性")
                        {
                            this.rdoMan.Checked = true;
                        }
                        else if(dr["Sex"].ToString() == "女性")
                        {
                            this.rdoWoman.Checked = true;
                        }
                    }
                }
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUserName.Text = "";     //氏名
            this.txtAge.Text = "";          //年齢
            this.drpCountry.SelectedIndex = 0;//国籍

            this.rdoMan.Checked = false;    //性別（男性）
            this.rdoWoman.Checked = false;  //性別（女性）
        }

        protected void btnModify_Click(object sender, EventArgs e)
        {
            DataTable dt = ((DataTable)Session["GridViewData"]);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                //氏名
                string name = dr["Name"].ToString();
                if (name == this.txtUserName.Text)
                {
                    dr["Age"] = this.txtAge.Text;       //年齢
                    dr["Country"] = this.drpCountry.Text;//国籍
                    if (this.rdoMan.Checked)             //性別
                    {
                        dr["Sex"] = "男性";
                    }
                    else if (this.rdoWoman.Checked)
                    {
                        dr["Sex"] = "女性";
                    }
                }
            }
            //dr["Sex"] = this.rdoMan.Checked ? "男性" : "女性";

            //アラート
            Response.Write("<script>alert('成功に更新しました。');</script>");

        }
    }
}