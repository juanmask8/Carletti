using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_header_admin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void lnkSession_Click(object sender, EventArgs e)
    {
        Session["Usuario"] = null;
        Response.Redirect("~/index.aspx");
    }
}
