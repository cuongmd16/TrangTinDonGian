using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrangTinTucDonGian
{
    public partial class AddNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                drDanhMuc.DataTextField = "title";
                drDanhMuc.DataValueField = "category_ID";
                drDanhMuc.DataSource = (new DataProvider()).excuteQuery("select * from tblcategory");
                drDanhMuc.DataBind();
                drUser.DataTextField = "username";
                drUser.DataValueField = "user_ID";
                drUser.DataSource = (new DataProvider()).excuteQuery("select username,user_ID from tblUser");
                drUser.DataBind();

            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string strInsert = "INSERT INTO tblNews (category_ID,author_ID,title,body,date) Values " +
                 "(" + Convert.ToInt32(drDanhMuc.SelectedValue) + ","+ Convert.ToInt32(drUser.SelectedValue) + "," + TxtTitle.Text + "," + txtBody.Text + "," + DateTime.Now +") ";
            if ((new DataProvider()).excuteNonQuery(strInsert))
            {
                Response.Write("<script>alert('INSERT successful!')</script>");

            }
            else
            {
                Response.Write("<script>alert('INSERT fail!')</script>");
            }
        }
    }
}