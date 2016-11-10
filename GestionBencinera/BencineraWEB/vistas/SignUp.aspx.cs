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

                this.txtEmail.Enabled = true;
                // es get
                lblMsg.Text = "";
                lblMsg.Visible = false;
                string email = Request.Params["email"];

                if (email != null && email.Length > 0)
                {
                    //Asumo que estoy editando al usuario, lleno todos los datos previamente
                    ControladorBLL controlador = new ControladorBLL();
                    UsuarioBEL objUsuarioBEL = controlador.getUsuarioPorEmail(email);

                    if (objUsuarioBEL != null)
                    {
                        //rellener el formulario
                        this.txtNombre.Text = objUsuarioBEL.Nombre;
                        this.txtApellido.Text = objUsuarioBEL.Apellido;
                        this.txtTelefono.Text = objUsuarioBEL.Telefono;
                        this.txtRut.Text = objUsuarioBEL.Rut;
                        this.txtTurno.Text = objUsuarioBEL.Turno;
                        this.txtEmail.Text = objUsuarioBEL.Email;
                        this.txtPass.Text = objUsuarioBEL.Password;
                        this.txtEmail.Enabled = false;
                    }
                }
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

                Response.Redirect("Login.aspx?alert=usuario_creado");

            }
            catch (Exception ex)
            {
                this.lblMsg.Text = string.Format("Error al crear UsuarioBEL {0} ", ex.Message);
                return;
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
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


            UsuarioBEL objUsu = new UsuarioBEL
            {
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

            string emailInicial = Request.Params["email"];
            bool actualizacionExitosa = objControl.editarUsuario(emailInicial, objUsu);
            if (actualizacionExitosa)
            {
                Response.Redirect("/vistas/ListadoUsuarios.aspx?alert=usuario_editado");
            }
            else {
                Response.Redirect("/vistas/ListadoUsuarios.aspx?alert=usuario_no_editado");
            }

            
        }
    }
}