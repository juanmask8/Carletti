using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;
public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        if (ControladorUsuarios.validarUsuarioContraseña(user.Text, pass.Text))
        {
            Usuario usuarioActual = ControladorUsuarios.getUsuario(user.Text);
            if (usuarioActual != null)
            {
                Session["Usuario"] = usuarioActual;
                Response.Redirect("~/index.aspx");
            }
            else
            {
                Response.Redirect("~/login.aspx");
            }
        }
    }
}