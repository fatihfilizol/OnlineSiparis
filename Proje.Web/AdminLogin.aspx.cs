using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        OnlineSiparisEntities login = new OnlineSiparisEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in login.Users where x.RankId == 1 && x.UserName == TxtUserName.Text && x.Password == TxtPassword.Text && x.Active==true select x;
            if (sorgu.Any())
            {
                Response.Redirect("AdminOrders.aspx");
            }
            else
            {
                Response.Write("Hatalı Giriş Yaptınız");
            }
        }
    }
}