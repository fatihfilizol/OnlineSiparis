using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;


namespace Proje.Web
{
    public partial class AdminProducts : System.Web.UI.Page
    {
        OnlineSiparisEntities product = new OnlineSiparisEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //var prdct = product.Product.Where(i=>i.Active==true).ToList();
            var prdct = (from x in product.Product
                         where x.Active==true
                         select new
                         {
                             x.Id,
                             x.ProductName,
                             x.Category.CategoryName,
                             x.Explanation,
                             x.Price,
                             x.Code,
                             x.Photo

                         }).ToList();

            Repeater1.DataSource = prdct;
            Repeater1.DataBind();
        }
    }
}