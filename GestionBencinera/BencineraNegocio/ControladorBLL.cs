using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BencineraDALC;
using BencineraEntidades;

namespace BencineraNegocio
{
    public class ControladorBLL
    {

        public UsuarioBEL getUsuarioPorEmail(string pEmail)
        {

            Usuario objUsuarioDALC = Conexion.ConexionBencinera.Usuario.FirstOrDefault(x => x.Email.Equals(pEmail));

            if (objUsuarioDALC == null)
            {
                return null;
            }
            UsuarioBEL objUsuarioBEL = new UsuarioBEL
            {
                Nombre = objUsuarioDALC.Nombre,
                Apellido = objUsuarioDALC.Apellido,
                Email = objUsuarioDALC.Email,
                Password = objUsuarioDALC.Password,
                Rut = objUsuarioDALC.Rut,
                Telefono = objUsuarioDALC.Telefono,
                Tipo_Usuario = objUsuarioDALC.Tipo_Usuario,
                Turno = objUsuarioDALC.Turno
            };
            return objUsuarioBEL;
        }

        public UsuarioBEL validarLogin(string pEmail, string pPassword)
        {
            Usuario objUsuarioDALC = Conexion.ConexionBencinera.Usuario.FirstOrDefault(x => x.Email.Equals(pEmail) && x.Password.Equals(pPassword));

            if (objUsuarioDALC == null)
            {
                // no hay concidencia password contrasenia
                return null;
            }

            UsuarioBEL objusuarioBEL = new UsuarioBEL
            {
                Nombre = objUsuarioDALC.Nombre,
                Apellido = objUsuarioDALC.Apellido,
                Email = objUsuarioDALC.Email,
                Password = objUsuarioDALC.Password,
                Rut = objUsuarioDALC.Rut,
                Telefono = objUsuarioDALC.Telefono,
                Tipo_Usuario = objUsuarioDALC.Tipo_Usuario,
                Turno = objUsuarioDALC.Turno
            };
            return objusuarioBEL;
        }

        public bool insertarUsuario(UsuarioBEL pObjUsuarioBEL)
        {



            UsuarioBEL objUsuarioBELInsertado = this.getUsuarioPorEmail(pObjUsuarioBEL.Email);
            if (objUsuarioBELInsertado != null)
            {
                //No se inserta ya que usuario ya existia con ese correo(unique constraint)
                return false;
            }
            Usuario objusuarioDALC = new Usuario
            {
                Nombre = pObjUsuarioBEL.Nombre,
                Apellido = pObjUsuarioBEL.Apellido,
                Email = pObjUsuarioBEL.Email,
                Password = pObjUsuarioBEL.Password,
                Rut = pObjUsuarioBEL.Rut,
                Telefono = pObjUsuarioBEL.Telefono,
                Tipo_Usuario = pObjUsuarioBEL.Tipo_Usuario,
                Turno = pObjUsuarioBEL.Turno
            };

            Conexion.ConexionBencinera.Usuario.Add(objusuarioDALC);
            Conexion.ConexionBencinera.SaveChanges();

            objUsuarioBELInsertado = this.getUsuarioPorEmail(pObjUsuarioBEL.Email);
            //valido que se haya insertado correctamente(osea que exista en la DB)
            return objUsuarioBELInsertado != null;
        }

        public bool editarUsuario(string emailInicial, UsuarioBEL pObjUsuarioBEL)
        {

            Usuario objUsuarioDALC = Conexion.ConexionBencinera.Usuario.FirstOrDefault(x => x.Email.Equals(emailInicial));
            if (objUsuarioDALC == null)
            {
                //No se edita ya que usuario no existe con ese correo en la DB
                return false;
            }

                objUsuarioDALC.Nombre = pObjUsuarioBEL.Nombre;
                objUsuarioDALC.Apellido = pObjUsuarioBEL.Apellido;
               // objUsuarioDALC.Email = pObjUsuarioBEL.Email;
                objUsuarioDALC.Password = pObjUsuarioBEL.Password;
                objUsuarioDALC.Rut = pObjUsuarioBEL.Rut;
                objUsuarioDALC.Telefono = pObjUsuarioBEL.Telefono;
                //objUsuarioDALC.Tipo_Usuario = pObjUsuarioBEL.Tipo_Usuario;
                objUsuarioDALC.Turno = pObjUsuarioBEL.Turno;
            
            Conexion.ConexionBencinera.SaveChanges();
            return true;
        }

        public bool eliminarUsuario(string pEmail)
        {

            Usuario objUsuarioDALC = Conexion.ConexionBencinera.Usuario.FirstOrDefault(x => x.Email.Equals(pEmail));
            if (objUsuarioDALC == null)
            {
                //No se elimina ya que usuario no existe con ese correo en la DB
                return false;
            }
            Conexion.ConexionBencinera.Usuario.Remove(objUsuarioDALC);
            Conexion.ConexionBencinera.SaveChanges();
            return true;
        }

        public List<UsuarioBEL> listarUsuarios()
        {
            List<UsuarioBEL> listadousuariosBEL = Conexion.ConexionBencinera.Usuario.Select(
                objUsuarioDALC => new UsuarioBEL   
                    {
                        Nombre = objUsuarioDALC.Nombre,
                        Apellido = objUsuarioDALC.Apellido,
                        Email = objUsuarioDALC.Email,
                        Password = objUsuarioDALC.Password,
                        Rut = objUsuarioDALC.Rut,
                        Telefono = objUsuarioDALC.Telefono,
                        Tipo_Usuario = objUsuarioDALC.Tipo_Usuario,
                        Turno = objUsuarioDALC.Turno
                    }
            ).ToList();
            //Obtuve un listado de DALCs con la query, pero use el select para devolverlos ya transformados a BEL
            return listadousuariosBEL;
        }







    }
}
