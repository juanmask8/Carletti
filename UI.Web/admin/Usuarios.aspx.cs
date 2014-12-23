using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;

public partial class admin_Usuarios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String editar = "<button class='btn btn-warning'><i class='glyphicon glyphicon-pencil'></i></button>";
        String eliminar = "<button class='btn btn-danger'><i class='glyphicon glyphicon-trash'></i></button>";
        Usuario user = (Usuario)Session["Usuario"];
        if (user == null)
        {
            Response.Redirect("~/index.aspx");
        }
    }
    protected void dgvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}