using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class DefaultAddOrder : System.Web.UI.Page
    {
        Cart cart = new Cart();
        Orders ordr = new Orders();
        OnlineSiparisEntities order = new OnlineSiparisEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var k = Convert.ToInt32(Session["tn"]);

            
            ordr.StatusId = 1;
            var z = (from x in order.Cart
                     where x.TableId == k
                     select new
                     {
                         x.Id,
                         x.TableId,
                         x.ProductId,
                         x.Product.Price,
                         x.Count

                     }).ToList();
            
            for (int i = 0; i < z.Count ; i++)
            {
                var p = z[i];
                ordr.ProductId = Convert.ToInt32(p.ProductId);
                ordr.Price = Convert.ToDecimal(p.Price);
                ordr.Count = Convert.ToInt32(p.Count);
                ordr.TableId = Convert.ToInt32(p.TableId);
                ordr.Active = true;
                ordr.CreateDate = DateTime.Now;
                order.Orders.Add(ordr);
                cart.Id = Convert.ToInt32(p.Id);
                var a = order.Cart.Find(cart.Id);
                order.Cart.Remove(a);
            }
           
            order.SaveChanges();


            var table = (from x in order.Tables
                     where x.Id == k
                     select new
                     {
                         x.Id

                     }).ToList();
            Repeater1.DataSource = table;
            Repeater1.DataBind();


        }
    }
}