using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class Admin : System.Web.UI.Page
    {
        OnlineSiparisEntities order = new OnlineSiparisEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var ordr = (from x in order.Orders
                         where x.Active == true
                         select new
                         {
                             x.Id,
                             x.Product.ProductName,
                             x.Tables.TableNumber,
                             x.Price,
                             x.Status.StatusName
                             
                         }).ToList();

            Repeater1.DataSource = ordr;
            Repeater1.DataBind();
        }
    }
}