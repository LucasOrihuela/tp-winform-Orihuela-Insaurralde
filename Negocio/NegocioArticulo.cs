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

            //// Cambiar Ruta de Conexion en NegocioArticulo, NegocioCategoria y NegocioMarca.
            /// Insaurralde 819VH7M


            SqlConnection Conexion = new SqlConnection("data source = DESKTOP-OC9KSLQ\\SQLEXPRESSS; initial catalog=CATALOGO_DB; integrated security=sspi");
            List<Articulo> Listado = new List<Articulo>();
            SqlCommand Comando = new SqlCommand();
            SqlDataReader Leeme;

            try
            {
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "select P.Id, P.Codigo,P.Nombre, P.Descripcion, M.Descripcion[Marca], C.Descripcion[Categoria], P.ImagenUrl,P.Precio,M.Id, C.Id from ARTICULOS P, MARCAS M, CATEGORIAS C where P.IdMarca = m.Id AND P.IdCategoria = C.Id";
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
                    Art.Marca.NombreMarca = Leeme.GetString(4);

                    Art.Categoria = new Categoria();
                    Art.Categoria.NombreCategoria = Leeme.GetString(5);
                    

                    Art.UrlImagen = Leeme.GetString(6);

                    Art.Precio = (double)Leeme.GetDecimal(7);

                    Art.Marca.Id = Leeme.GetInt32(8);
                    Art.Categoria.Id = Leeme.GetInt32(9);

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

        public void modificar(Articulo articulo)
        {

            SqlConnection conexion = new SqlConnection("data source = DESKTOP-OC9KSLQ\\SQLEXPRESS;initial catalog = CATALOGO_DB;integrated security = sspi;");

            try
            {
                SqlCommand Comando = new SqlCommand();
                Comando.CommandType = System.Data.CommandType.Text;

                Comando.CommandText = "update ARTICULOS set Codigo=@codigo, Nombre=@nombre, Descripcion=@descripcion, IdMarca=@IdMarca, IdCategoria=@IdCategoria, ImagenUrl=@ImagenUrl, precio=@Precio where Id=@id)";
                Comando.Connection = conexion;

                Comando.Parameters.AddWithValue("@Codigo", articulo.Codigo);
                Comando.Parameters.AddWithValue("@Nombre", articulo.Nombre);
                Comando.Parameters.AddWithValue("@Descripcion", articulo.Descripcion);
                Comando.Parameters.AddWithValue("@IdMarca", articulo.Marca.Id);
                Comando.Parameters.AddWithValue("@IdCategoria", articulo.Categoria.Id);
                Comando.Parameters.AddWithValue("@ImagenUrl", articulo.UrlImagen);
                Comando.Parameters.AddWithValue("@Precio", articulo.Precio);

                conexion.Open();
                Comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void agregar(Articulo nuevo)
        {
            SqlConnection conexion = new SqlConnection("data source = DESKTOP-OC9KSLQ\\SQLEXPRESS;initial catalog = CATALOGO_DB;integrated security = sspi;");
            
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into articulos (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio) Values (@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@ImagenUrl,@Precio)";
                comando.Parameters.Clear();
                comando.Connection = conexion;

                
                comando.Parameters.AddWithValue("@Codigo",nuevo.Codigo);
                comando.Parameters.AddWithValue("@Nombre", nuevo.Nombre);
                comando.Parameters.AddWithValue("@Descripcion",nuevo.Descripcion);
                comando.Parameters.AddWithValue("@IdMarca", nuevo.Marca.Id);
                comando.Parameters.AddWithValue("@IdCategoria",nuevo.Categoria.Id);
                comando.Parameters.AddWithValue("@ImagenUrl", nuevo.UrlImagen);
                comando.Parameters.AddWithValue("@Precio" , nuevo.Precio);

                conexion.Open();

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                conexion.Close();
            }
            
            
        }

        public void eliminar(int id)
        {
            SqlConnection conexion = new SqlConnection("data source = DESKTOP - OC9KSLQ\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi; ");
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "delete from ARTICULOS where id=@id";
                comando.Parameters.Clear();
                comando.Connection = conexion;

                comando.Parameters.AddWithValue("@Id", id);


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
