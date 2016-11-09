using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BencineraNegocio;
using BencineraEntidades;


namespace BencineraWEB
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ControladorBLL controlador = new ControladorBLL();
            UsuarioBEL objUsuarioBEL = controlador.getUsuarioPorEmail("admin");
            Session["objUsuarioBEL"] = objUsuarioBEL;

            if (objUsuarioBEL != null)
            {
                Session["Nombre"] = "Bienvenido " + objUsuarioBEL.Nombre + " " + objUsuarioBEL.Apellido;
            }
            else {
                Session["Nombre"] ="Usuario no encontrado";
            }

            lblMensaje.Text = Session["Nombre"].ToString();

        }
    }
}