using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class NegocioArticulo
    {

        public List<Articulo> Listar() 
        {
            List<Articulo> Listado = new List<Articulo>();
            SqlConnection Conexion = new SqlConnection();
            SqlCommand Comando = new SqlCommand();
            SqlDataReader Leer;

            try
            {
                
                ///// Cambiar ruta de conexion.

                Conexion.ConnectionString = "data source=DESKTOP-819VH7MF\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "select *from ARTICULOS";
                Comando.Connection = Conexion;
                Conexion.Open();

                Leer = Comando.ExecuteReader();

                while (Leer.Read())
                {
                    Articulo Aux = new Articulo();

                    Aux.Id = Leer.GetInt32(0);
                    Aux.Codigo = Leer.GetString(1);
                    Aux.Nombre = Leer.GetString(2);
                    Aux.Descripcion = Leer.GetString(3);
                    Aux.Marca = new Marca();
                    Aux.Marca.Nombre = Leer.GetString(4);
                    Aux.Categoria = new Categoria();
                    Aux.Categoria.Nombre = Leer.GetString(5);
                    Aux.UrlImagen = Leer.GetString(6);

                    Aux.Precio = (double)Leer.GetDecimal(7);

                    Listado.Add(Aux);

                }

                return Listado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.Close();
            }
         
        }
    }
}
