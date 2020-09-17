using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp1_WinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            NegocioArticulo negocio = new NegocioArticulo;
            nuevo.Codigo = txtCodigo.Text;
            nuevo.Nombre = txtNombre.Text;
            nuevo.Descripcion = txtDescripcion.Text;
            nuevo.Marca = cbMarca;
            nuevo.Categoria = cbCategoria;
            nuevo.UrlImagen = txtImagen.Text;
            nuevo.Precio = txtPrecio.Text;

            negocio.agregar(nuevo);
        }
    }
}
