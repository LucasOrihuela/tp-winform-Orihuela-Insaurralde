using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class NegocioCategoria
    {
        SqlConnection conexion = new SqlConnection("data source = DESKTOP-OC9KSLQ\\SQLEXPRESS; initial catalog=CATALOG_DB;integrated security=sspi");
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;
       
        conexion.sqlconnection = "";
        comando.commandType = System.Data.CommandType.text;
        comando.commandtext = "select * from categorias";


    }
}
