using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class NegocioMarca
    {
        public List<Marca> Listar()
        {

            SqlConnection conexion = new SqlConnection("data source = DESKTOP-819VH7M\\SQLEXPRESS;initial catalog = CATALOGO_DB;integrated security = sspi;");
            SqlCommand comando = new SqlCommand();
            List<Marca> Listado = new List<Marca>();
            SqlDataReader lector;

            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from Marcas";
            comando.Connection = conexion;

            conexion.Open();
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Marca aux = new Marca();
                aux.Nombre = lector.GetString(1);

                Listado.Add(aux);
            }

            conexion.Close();
            return Listado;

        }

    }
}
