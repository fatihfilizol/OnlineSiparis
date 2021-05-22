using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class AdminUpdateCategory : System.Web.UI.Page
    {
        OnlineSiparisEntities category = new OnlineSiparisEntities();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                int id = Convert.ToInt32(Request.QueryString["Id"]);
                TxtId.Text = id.ToString();
                var n = category.Category.Find(id);
                TxtName.Text = n.CategoryName;
            }
            
        }

        protected void BtnUpdateCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            var n = category.Category.Find(id);
            n.CategoryName = TxtName.Text;
            category.SaveChanges();
            Response.Redirect("AdminCategories.aspx");
        }
    }
}