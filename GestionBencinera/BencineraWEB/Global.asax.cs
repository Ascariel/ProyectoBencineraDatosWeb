using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace BencineraWEB
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            //Controlador objControlador = new Controlador();
            //Session["controlador"] = objControlador;
            //Session["estadoLogin"] = "DESLOGUEADO";

            //if (objControlador.buscarPorEmail("admin") == null)
            //{
            //    Usuario objUsu = new Usuario("Admin", "Apellido", "Fono", "rut", "Turno", "Jefe", "admin", "passpass");
            //    objControlador.addUsuario(objUsu);
            //}


        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}