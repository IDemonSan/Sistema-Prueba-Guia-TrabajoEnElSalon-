using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Entidad_Cliente
    {
        string Dni { get; set; }
        string Nombres { get; set; }
        string Apellidos {get; set; }
        DateTime FechaNacimiento { get; set; }
        int Edad { get; set; }
        string Correo { get; set; }
        string Distrito { get; set; }
    }
}
