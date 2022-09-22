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
            if (Session["listaAutos"] == null)
            {

                AutoNegocio negocio = new AutoNegocio();
                Session.Add("listaAutos", negocio.listar());
            }

            dgvauto.DataSource = Session["listaAutos"];
            dgvauto.DataBind();


        }
    }
}