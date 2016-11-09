using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BencineraDALC;

namespace BencineraNegocio
{
    public class Conexion
    {
        public static DefaultConnection _conexion;

        public static DefaultConnection ConexionBencinera {

            get {
                if (_conexion == null)
                {
                    _conexion = new DefaultConnection();
                }
                return _conexion;
            }
        }
    }


}
