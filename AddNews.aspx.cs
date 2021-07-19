using System;
using System.Collections.Generic;
using System.Data;
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

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string strInsert = "INSERT INTO tblNews (category_ID,author_ID,title,body) Values" +
             "(" + drDanhMuc.SelectedValue.ToString() + "," + drNguoiDang.SelectedValue.ToString() + ",'" + TxtTitle.Text + "','" + txtBody.Text + "') ";
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