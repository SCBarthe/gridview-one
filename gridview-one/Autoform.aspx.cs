using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using auto2;

namespace gridview_one
{
    public partial class Autoform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlcolores.Items.Add("blue");
                ddlcolores.Items.Add("yellow");
                ddlcolores.Items.Add("grey");
            }

        }

        protected void btnaceptar_Click(object sender, EventArgs e)
        {
            auto5 a = new auto5();
            a.ID = int.Parse(txtid.Text);
            a.Modelo = txtmodelo.Text;
            a.Descripcion = txtdescripcion.Text;
            a.Color = ddlcolores.SelectedValue;
            a.Fecha = DateTime.Parse(Txtfecha.Text);
            a.Usado = chkUsado.Checked;

            if (RdbImportado.Checked)
                a.Importado = true;
            else if (RdbNacional.Checked)
                a.Importado = false;





            //((List<auto5>)Session["listaAutos"]).Add(a); 

           List<auto5> temporal = (List<auto5>)Session["listaAutos"];
           temporal.Add(a);

            Response.Redirect("defaul");



        }

        protected void RdbNacional_CheckedChanged(object sender, EventArgs e)
        {

        }

        
        

        
    }
}