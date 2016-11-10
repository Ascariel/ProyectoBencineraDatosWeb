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
    public partial class ListadoUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGrillaUsuarios();
            }
        }

        private void cargarGrillaUsuarios()
        {
            ControladorBLL objControlador = new ControladorBLL();
            grdListadoUsuarios.DataSource = objControlador.listarUsuarios();
            grdListadoUsuarios.DataBind();
        }

        protected void grdListadoUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            ControladorBLL objControlador = new ControladorBLL();

            string email = e.CommandArgument.ToString();
            string accion = e.CommandName.ToString();

            UsuarioBEL objUsuarioBEL = objControlador.getUsuarioPorEmail(email); 

            switch (accion)
            {
                case "Modificar":
                    Response.Redirect("/vistas/SignUp.aspx?email="+ objUsuarioBEL.Email);
                    break;
                case "Eliminar":
                    bool eliminado = objControlador.eliminarUsuario(email);

                    if (eliminado)
                    {
                        Response.Redirect("/vistas/ListadoUsuarios.aspx?alert=usuario_eliminado");
                    }

                    break;
                default:
                    return;
            }
        }
    }
}