using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Employee
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dtSession = (DataTable)Session["GridViewData"];
                if (dtSession == null)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Name");
                    dt.Columns.Add("Age");
                    dt.Columns.Add("Country");
                    dt.Columns.Add("Sex");

                    DataRow dr = dt.NewRow();
                    dr["Name"] = "Wang 1";
                    dr["Age"] = "20";
                    dr["Country"] = "Anhui";
                    dr["Sex"] = "男性";
                    //新規行追加
                    dt.Rows.Add(dr);

                    dr = dt.NewRow();
                    dr["Name"] = "Li";
                    dr["Age"] = "35";
                    dr["Country"] = "BeiJing";
                    dr["Sex"] = "女性";
                    //新規行追加
                    dt.Rows.Add(dr);

                    dr = dt.NewRow();
                    dr["Name"] = "Wang 2";
                    dr["Age"] = "10";
                    dr["Country"] = "ShangHai";
                    dr["Sex"] = "男性";
                    //新規行追加
                    dt.Rows.Add(dr);

                    dr = dt.NewRow();
                    dr["Name"] = "Liu";
                    dr["Age"] = "53";
                    dr["Country"] = "Anhui";
                    dr["Sex"] = "女性";
                    //新規行追加
                    dt.Rows.Add(dr);

                    //セッションに格納する
                    Session["GridViewData"] = dt;

                    //データバインド
                    this.GridView1.DataSource = dt;
                    this.GridView1.DataBind();
                }
                else
                {
                    //データバインド
                    this.GridView1.DataSource = dtSession;
                    this.GridView1.DataBind();
                }

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
            this.txtUserName.Text = "";     //氏名
            this.txtAge.Text = "";          //年齢
            this.drpCountry.SelectedIndex = 0;//国籍

            this.rdoMan.Checked = false;    //性別（男性）
            this.rdoWoman.Checked = false;  //性別（女性）
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = ((DataTable)Session["GridViewData"]).Copy();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                //氏名
                string name = dr["Name"].ToString();

                if (this.txtUserName.Text != "" && 
                    !name.ToUpper().StartsWith(this.txtUserName.Text.ToUpper()))
                {
                    dt.Rows.RemoveAt(i);
                    i--;

                    continue;
                }

                //年齢
                string age = dr["Age"].ToString();
                if (this.txtAge.Text != "" && 
                    age != this.txtAge.Text)
                {
                    dt.Rows.RemoveAt(i);
                    i--;

                    continue;
                }
                //国籍
                string country = dr["Country"].ToString();
                if(this.drpCountry.Text != "" && 
                    country.ToUpper() != this.drpCountry.Text.ToUpper())
                {
                    dt.Rows.RemoveAt(i);
                    i--;

                    continue;
                }
                //性別
                string sex = dr["Sex"].ToString();
                if (this.rdoMan.Checked || this.rdoWoman.Checked)
                {
                    if (this.rdoMan.Checked)    //男性選択中
                    {
                        if (sex != "男性")
                        {
                            dt.Rows.RemoveAt(i);
                            i--;

                            continue;
                        }
                    }
                    else if (this.rdoWoman.Checked)//女性選択中
                    {
                        if (sex != "女性")
                        {
                            dt.Rows.RemoveAt(i);
                            i--;

                            continue;
                        }
                    }
                }
            }

            //0件の場合のみ、空行を新規追加する
            if(dt.Rows.Count == 0)
            {
                DataRow dr = dt.NewRow();
                dt.Rows.Add(dr);
            }

            //データバインド
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }
    }
}