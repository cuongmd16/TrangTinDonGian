using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TrangTinTucDonGian.Admin
{
    public partial class QuanLyBaiViet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                showGrid("");
                GetCode();
               
            }
        }
        void GetCode()
        {
            string news_ID = "0";
            string author_ID = "0";
            string category_ID = "0";
            string str = "SELECT [title],[picture],[date]FROM[dbo].[tblNews] WHERE news_ID= '" + news_ID + "',author_ID = '" + author_ID + "',category_ID'"+ category_ID + "'";
            DataTable tb = new DataProvider().excuteQuery(str);

            foreach (DataRow row in tb.Rows)
            {
                string title = row["title"].ToString();
                string picture = row["picture"].ToString();
                string date = row["date"].ToString();
                txtTitle.Text = title;
                txtImage.Text = picture;
                txtDate.Text = date;
            }
        }
        private void loadDataByNewID(string s)
        {
           /* string str = "select * from tblNews where news_ID like '%" + s + "%';";
            string strs = "where news_ID like '%" + s + "%';";
            DataTable dt = new DataProvider().excuteQuery(str);
            if (dt.Rows.Count > 0)
            {
                showGrid(strs);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Don't have data');location.href='/QuanLyBaiViet.aspx';", true);
                showGrid("");
            }*/
        }
        void getListNewID()
        {
          /*  string str = "SELECT news_ID FROM tblNews";
            ddlNewsID.DataSource = new DataProvider().excuteQuery(str);
            ddlNewsID.DataBind();*/
        }
        void getListCategoryID()
        {
           /* string str = "SELECT [category_ID]FROM[dbo].[tblNews]";
            ddlCategory.DataSource = new DataProvider().excuteQuery(str);
            ddlCategory.DataBind();*/
        }
        void getListAuthorID()
        {
        /*    string str = "SELECT [author_ID]FROM[dbo].[tblNews]";
            ddlAuthor.DataSource = new DataProvider().excuteQuery(str);
            ddlAuthor.DataBind();*/
        }
        private void showGrid(string str)
        {
            gvNews.DataSource = (new DataProvider()).excuteQuery("select * from tblNews" +str);
            gvNews.DataBind();
        }
        SqlConnection cnn;
        protected void btnInsert_Click(object sender, EventArgs e)
        {
         /*   string sqlInsert = "INSERT INTO tblNews Value title='" + + "',picture='" + txtImage.Text + "'," +
                 "date='" +  + "'where news_ID ='"+  + "',author_ID ='" +  + "'";*/
            string strInsert = "INSERT INTO tblNews (category_ID,author_ID,title,body,picture,date) Values" +
                "("+ ddlCategory.SelectedValue.ToString() + ","+ ddlAuthor.SelectedValue.ToString() + ",'"+ txtTitle.Text + "','','','"+ txtDate.Text + "') ";
            if ((new DataProvider()).excuteNonQuery(strInsert))
            {
                Response.Write("<script>alert('INSERT successful!')</script>");
                showGrid("");
            }
            else
            {
                Response.Write("<script>alert('INSERT fail!')</script>");
            }
        }

/*        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string strUpdate = "update tblNews set title='" + txtTitle.Text + "',picture='" + txtImage.Text + "'," +
                 "date='" + txtDate.Text + "'where category_ID = '"+ddlCategory.SelectedValue.ToString()+"',author_ID ='"+ ddlAuthor.SelectedValue.ToString()+ "'";
            if ((new DataProvider()).excuteNonQuery(strUpdate))
            {
                Response.Write("<script>alert('Update successful!')</script>");
                showGrid("");
            }
            else
            {
                Response.Write("<script>alert('Update fail!')</script>");
            }
        }*/

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            /*string strDelete = "delete form tblNews Where news_ID = '" + ddlNewsID.SelectedValue.ToString() + "'";
            if ((new DataProvider()).excuteNonQuery(strDelete))
            {
                Response.Write("<script>alert('Update successful!')</script>");
                showGrid("");
            }
            else
            {
                Response.Write("<script>alert('Update fail!')</script>");
            }*/
        }

        protected void btnSearch0_Click(object sender, EventArgs e)
        {

        }

        protected void gvNews_SelectedIndexChanged(object sender, EventArgs e)
        {
            showGrid("");
            getListNewID();
            getListCategoryID();
            getListAuthorID();
        }

        protected void ddlNewsID_SelectedIndexChanged(object sender, EventArgs e)
        {
           /**//* string news_ID = ddlNewsID.SelectedValue;
            string str = "SELECT [news_ID],[title],[picture],[date]FROM[dbo].[tblNews] WHERE news_ID= '" + ddlNewsID.SelectedValue + "'";
            DataTable tb = new DataProvider().excuteQuery(str);
            foreach (DataRow row in tb.Rows)
            {
                string title = row["title"].ToString();
                string picture = row["picture"].ToString();
                string date = row["date"].ToString();
                txtTitle.Text = title;
                txtImage.Text = picture;
                txtDate.Text = date;
            }
            gvNews.DataSource = tb;
            gvNews.DataBind();*/
        }

        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
          /*  *//*string category_ID = ddlCategory.SelectedValue;
            string str = "SELECT [category_ID],[title],[picture],[date]FROM[dbo].[tblNews] WHERE category_ID= '" + ddlCategory.SelectedValue + "'";
            DataTable tb = new DataProvider().excuteQuery(str);
            foreach (DataRow row in tb.Rows)
            {
                string title = row["title"].ToString();
                string picture = row["picture"].ToString();
                string date = row["date"].ToString();
                txtTitle.Text = title;
                txtImage.Text = picture;
                txtDate.Text = date;
            }
            gvNews.DataSource = tb;
            gvNews.DataBind();*//**/
        }

        protected void ddlAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
           /**//* string author_ID = ddlAuthor.SelectedValue;
            string str = "SELECT [author_ID],[title],[picture],[date]FROM[dbo].[tblNews] WHERE author_ID= '" + ddlAuthor.SelectedValue + "'";
            DataTable tb = new DataProvider().excuteQuery(str);
            foreach (DataRow row in tb.Rows)
            {
                string title = row["title"].ToString();
                string picture = row["picture"].ToString();
                string date = row["date"].ToString();
                txtTitle.Text = title;
                txtImage.Text = picture;
                txtDate.Text = date;
            }
            gvNews.DataSource = tb;
            gvNews.DataBind();*//**/
        }
    }
}