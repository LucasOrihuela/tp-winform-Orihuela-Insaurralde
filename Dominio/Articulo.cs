using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Articulo
    {
        private int id;
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public string UrlImagen { get; set; }
        public int Precio { get; set; }
    }
}
