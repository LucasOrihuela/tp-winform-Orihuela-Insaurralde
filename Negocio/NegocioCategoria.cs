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
        public List<Categoria> Listar()
        {

        SqlConnection conexion = new SqlConnection("data source = DESKTOP-819VH7M\\SQLEXPRESS;initial catalog = CATALOGO_DB;integrated security = sspi;");
        SqlCommand comando = new SqlCommand();
        List<Categoria> Listado = new List<Categoria> ();
        SqlDataReader lector;
       
        comando.CommandType = System.Data.CommandType.Text;
        comando.CommandText = "select * from categorias";
        comando.Connection = conexion;

        conexion.Open();
        lector = comando.ExecuteReader();
        while(lector.Read())
            {
                Categoria aux = new Categoria();
                aux.Nombre = lector.GetString(1);

                Listado.Add(aux);
            }
            
        conexion.Close();
        return Listado;

        }


    }
}
