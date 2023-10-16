using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Entidad;
using System.Diagnostics.SymbolStore;

namespace Datos
{
    public class Datos_UsuarioSistema
    {
        SqlConnection cn = new SqlConnection(
            ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        public int D_Login(Entidad.Entidad_UsuarioSistema obje)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_Validar_Usuario_Sistema", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nom", obje.Nombre);
            cmd.Parameters.AddWithValue("@pwd", obje.Password);

            SqlParameter usuarioValidoParam = new SqlParameter("@resultado", SqlDbType.Int);
            usuarioValidoParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(usuarioValidoParam);

            cmd.ExecuteNonQuery();
            cn.Close();

            return (int)cmd.Parameters["@resultado"].Value;
        }
    }
}
