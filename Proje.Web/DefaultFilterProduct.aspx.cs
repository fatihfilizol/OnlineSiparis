using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class DefaultFilterProduct : System.Web.UI.Page
    {
        Cart c = new Cart();
        OnlineSiparisEntities db = new OnlineSiparisEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(Request.QueryString["Id"]);
            var n = db.Product.Find(id);
            

            //Masa numarasının çekilmesi

            Label1.Text = Session["tn"].ToString();



            //Kategorilerin listelenmesi

            var categories = db.Category.ToList();
            Repeater1.DataSource = categories;
            Repeater1.DataBind();

            //Ürünlerin listelenmesi
            var product = (from x in db.Product
                        where x.CategoryId == id
                        select new
                        {
                            x.Id,
                            x.Photo,
                            x.Price,
                            x.ProductName,
                        }).ToList();
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