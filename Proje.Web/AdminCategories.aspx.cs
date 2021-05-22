using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class AdminCategories : System.Web.UI.Page
    {
        OnlineSiparisEntities category = new OnlineSiparisEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var ctg = category.Category.Where(i => i.Active == true).ToList();
            Repeater1.DataSource = ctg;
            Repeater1.DataBind();
        }
    }
}