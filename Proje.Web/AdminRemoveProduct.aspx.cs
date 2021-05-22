using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class AdminRemoveProduct : System.Web.UI.Page
    {
        OnlineSiparisEntities product = new OnlineSiparisEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            var n = product.Product.Find(id);
            n.Active = false;
            product.SaveChanges();
            Response.Redirect("~/AdminProducts.aspx");
        }
    }
}