using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;

namespace Negocio
{
    public class Negocio_UsuarioSistema
    {
        Datos.Datos_UsuarioSistema objd = new Datos.Datos_UsuarioSistema();

        public int N_Login(Entidad.Entidad_UsuarioSistema obje)
        {
            return objd.D_Login(obje);
        }
    }
}
