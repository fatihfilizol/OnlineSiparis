using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;
using Proje.Business;
using Proje.Web;

namespace Proje.Web
{
    public partial class Default : System.Web.UI.Page
    {

        Cart c = new Cart();
        OnlineSiparisEntities db = new OnlineSiparisEntities();
        public void Page_Load(object sender, EventArgs e)
        {


           
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            var n = db.Tables.Find(id);
            Session.Add("tn", n.Id);

            //Masa numarasının çekilmesi
            
            Label1.Text = Session["tn"].ToString();
            
            

            //Kategorilerin listelenmesi

            var categories = db.Category.ToList();
            Repeater1.DataSource = categories;
            Repeater1.DataBind();
            
            //Ürünlerin listelenmesi
            var product = db.Product.ToList();
            Repeater2.DataSource = product;
            Repeater2.DataBind();

            //Sepet Listeleme

            int k = Convert.ToInt32(Session["tn"]);
            var cart = (from x in db.Cart
                        where x.TableId == k
                        select new
                        {
                            x.Id,
                            x.ProductId,
                            x.Product.ProductName,
                            x.Product.Price,
                            x.Count,
                        }).ToList();

           
            Repeater3.DataSource = cart;
            Repeater3.DataBind();








        }
        
    }
}