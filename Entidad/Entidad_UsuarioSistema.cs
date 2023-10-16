using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Entidad_UsuarioSistema
    {
        public String Nombre { get; set; }
        public String Password { get; set; }
        public String FechaRegistro { get; set; }
        public int Estado { get; set; } 
    }
}
