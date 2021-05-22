using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class AdminPaymentOrder : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {
            OnlineSiparisEntities status = new OnlineSiparisEntities();
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            var ordr = status.Orders.Find(id);
            if (ordr.StatusId == 3)
            {
                ordr.StatusId = ordr.StatusId + 1;

            }

            status.SaveChanges();
            Response.Redirect("AdminOrders.aspx");
        }
    }
}