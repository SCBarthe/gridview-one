using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gridview_one
{
    public partial class Autoform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlcolores.Items.Add("blue");
            ddlcolores.Items.Add("yellow");
            ddlcolores.Items.Add("grey");

        }
    }
}