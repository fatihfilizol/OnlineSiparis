using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class DefaultRemoveProductInCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OnlineSiparisEntities cart = new OnlineSiparisEntities();
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            var p = cart.Cart.Find(id);
            var s = p.Product.CategoryId;
            cart.Cart.Remove(p);
            cart.SaveChanges();
            Response.Redirect("~/DefaultFilterProduct.aspx?Id=" + s);
        }
    }
}