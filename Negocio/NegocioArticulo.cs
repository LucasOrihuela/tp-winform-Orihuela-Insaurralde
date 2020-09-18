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

            //// Cambiar Ruta de Conexion.
            /// Insaurralde 819VH7M


            SqlConnection Conexion = new SqlConnection("data source=DESKTOP-819VH7M\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi");
            List<Articulo> Listado = new List<Articulo>();
            SqlCommand Comando = new SqlCommand();
            SqlDataReader Leeme;

            try
            {
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "select P.Id, P.Codigo,P.Nombre, P.Descripcion, M.Descripcion[Marca], C.Descripcion[Categoria], P.ImagenUrl,P.Precio from ARTICULOS P, MARCAS M, CATEGORIAS C where P.IdMarca = m.Id AND P.IdCategoria = C.Id";
                Comando.Connection = Conexion;
                Conexion.Open();

                Leeme = Comando.ExecuteReader();

                while (Leeme.Read())
                {
                    Articulo Art = new Articulo();

                    Art.Id = Leeme.GetInt32(0);
                    Art.Codigo = Leeme.GetString(1);
                    Art.Nombre = Leeme.GetString(2);
                    Art.Descripcion = Leeme.GetString(3);

                    Art.Marca = new Marca();
                    Art.Marca.Nombre = Leeme.GetString(4);


                    Listado.Add(Art);
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

        public void agregar(Articulo nuevo)
        {
            SqlConnection conexion = new SqlConnection("data source = DESKTOP-819VH7M\\SQLEXPRESS;initial catalog = CATALOGO_DB;integrated security = sspi;");
            SqlCommand comando = new SqlCommand();

            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "insert into CATALOGO_DB (codigo,Descripcion,Imagen,Precio) values ('"+ nuevo.Codigo +"','"+nuevo.Descripcion +"','"+nuevo.UrlImagen+"','"+nuevo.Precio+"')";
            comando.Connection = conexion;

            conexion.Open();
        }
    }
}
