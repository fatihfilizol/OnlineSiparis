using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace Proje.Web
{
    public partial class DefaultSelectedTable : System.Web.UI.Page
    {
        OnlineSiparisEntities table = new OnlineSiparisEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var tbl = table.Tables.ToList();
            Repeater1.DataSource = tbl;
            Repeater1.DataBind();
        }
    }
}