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

        public UsuarioBEL getUsuarioPorEmail(string pEmail){

          Usuario objUsuarioDALC =  Conexion.ConexionBencinera.Usuario.FirstOrDefault(x => x.Email.Equals(pEmail));

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
    }
}
