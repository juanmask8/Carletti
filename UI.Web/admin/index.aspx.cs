using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

public partial class admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Usuario user = (Usuario)Session["Usuario"];
        if (user == null)
        {        
            Response.Redirect("~/index.aspx");
        }
    }
    protected void btnAceptar_Click(object sender, EventArgs e)
    {

    }
}