using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidad;

namespace Negocio
{
    public class Negocio_Cliente
    {
        Datos_Cliente dCliente = new Datos_Cliente();
        
        public DataTable VistaCliente()
        {
            return dCliente.VistaCliente();
        }
        
        public DataTable BuscarCliente (string Distrito)
        {
            return dCliente.BuscarClienteDistrito(Distrito);
        }
    }
}
