using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BencineraNegocio;
using BencineraEntidades;

namespace BencineraWEB.vistas
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblMsg.Text = "";
                lblMsg.Visible = false;
            }
        }

        protected void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = this.txtNombre.Text;
                string ape = this.txtApellido.Text;
                string fono = this.txtTelefono.Text;
                string rut = this.txtRut.Text;
                string turno = this.txtTurno.Text;
                string tipoUsuario = this.ddlTipoUsuario.SelectedItem.Text;
                string emial = this.txtEmail.Text;
                string pass = txtPass.Text;

                if (nom == string.Empty || ape == string.Empty || fono == string.Empty ||
                    rut == string.Empty || turno == string.Empty || emial == string.Empty || pass == string.Empty)
                {
                    lblMsg.Text = "*No puede haber campos vacíos!";
                    lblMsg.Visible = true;
                    return;
                }

                
                UsuarioBEL objUsu = new UsuarioBEL{
                    Nombre = nom,
                    Apellido = ape,
                    Telefono = fono,
                    Rut = rut,
                    Turno = turno,
                    Tipo_Usuario = tipoUsuario,
                    Email = emial,
                    Password = pass,
                };

                ControladorBLL objControl = new ControladorBLL();

                bool creacionExitosa = objControl.insertarUsuario(objUsu);

                if (!creacionExitosa)
                {
                    Response.Redirect("SignUp.aspx?alert=usuario_ya_existe");
                }

                Session["ControladorBLL"] = objControl;

                Response.Redirect("Login.aspx?alert=usuario_creado");

            }
            catch (Exception ex)
            {
                this.lblMsg.Text = string.Format("Error al crear UsuarioBEL {0} ", ex.Message);
                return;
            }
        }
    }
}