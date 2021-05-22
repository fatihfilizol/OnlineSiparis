using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    
    public partial class DefaultAddCart : System.Web.UI.Page
    {
        
        public void Page_Load(object sender, EventArgs e)
        {
            
                Cart c = new Cart();
                OnlineSiparisEntities order = new OnlineSiparisEntities();
                int id = Convert.ToInt32(Request.QueryString["Id"]);
                var n = order.Product.Find(id);
                c.ProductId = n.Id;
                c.TableId = Convert.ToInt32(Session["tn"]);
                c.Count = 1;
                order.Cart.Add(c);
                order.SaveChanges();
                

                Response.Redirect("~/DefaultFilterProduct.aspx?Id=" + n.CategoryId);
            
                


        }
    }
}