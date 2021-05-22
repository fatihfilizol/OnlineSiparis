using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class AdminAddCategory : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
           
            
        }

        protected void BtnAddCategory_Click(object sender, EventArgs e)
        {   OnlineSiparisEntities category = new OnlineSiparisEntities();
            Category c = new Category();
            c.CategoryName = TextBox1.Text;
            c.CreateDate = DateTime.Now;
            c.Active = true;
            category.Category.Add(c);
            category.SaveChanges();
        }
    }
}