using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BencineraWEB
{
    public partial class MasterLayout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["estadoLogin"] = "DESLOGUEADO";
            Response.Redirect("/Home.aspx");
        }
    }
}