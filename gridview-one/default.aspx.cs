using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using auto2; 

namespace gridview_one
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AutoNegocio negocio = new AutoNegocio();
            dgvauto.DataSource = negocio.listar();
            dgvauto.DataBind(); 


        }
    }
}