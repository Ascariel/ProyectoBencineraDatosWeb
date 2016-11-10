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
            //ControladorBLL controlador = new ControladorBLL();
            //UsuarioBEL objUsuarioBEL = controlador.getUsuarioPorEmail("admin");
            //Session["objUsuarioBEL"] = objUsuarioBEL;

            //if (objUsuarioBEL != null)
            //{
            //    Session["Nombre"] = "Bienvenido " + objUsuarioBEL.Nombre + " " + objUsuarioBEL.Apellido;
            //}
            //else {
            //    Session["Nombre"] ="Usuario no encontrado";
            //}

            //lblMensaje.Text = Session["Nombre"].ToString();

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string email = txtUsername.Text;
            string password = txtPassword.Text;
            ControladorBLL controlador = new ControladorBLL();

            UsuarioBEL objUsuarioBEL = controlador.validarLogin(email, password);

            if (email.Length == 0 || password.Length == 0)
            {
                Response.Redirect("/vistas/Login.aspx?alert=empty_fields", false);
            }
            else if (objUsuarioBEL == null)
            {
                Response.Redirect("/vistas/Login.aspx?alert=wrong_credentials", false);
            }
            else
            {
                Session["estadoLogin"] = "LOGUEADO";
                Response.Redirect("/vistas/ListadoUsuarios.aspx?alert=success");
            }
        }
    }
}