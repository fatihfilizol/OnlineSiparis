using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class AdminCancelOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OnlineSiparisEntities order = new OnlineSiparisEntities();
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            var ctg = order.Orders.Find(id);
            ctg.Active = false;
            order.SaveChanges();
            Response.Redirect("AdminOrders.aspx");
        }
    }
}