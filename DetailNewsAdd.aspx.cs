using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrangTinTucDonGian
{   
    
    public partial class DetailNews : System.Web.UI.Page
    {
        WebTinTucDataContext dt = new WebTinTucDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rpDanhMuc.DataTextField = "title";
                rpDanhMuc.DataValueField = "category_ID";
                rpDanhMuc.DataSource = dt.tblCategory_SelectAll();
                rpDanhMuc.DataBind();
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            dt.tblNews_Insert(TxtTieuDe.Text, txtNoiDung.Text, DateTime.Now, Convert.ToInt32(rpDanhMuc.SelectedValue));
        }
    }
}