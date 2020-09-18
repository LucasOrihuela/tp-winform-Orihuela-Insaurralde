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
            NegocioArticulo negocio = new NegocioArticulo();

            try
            {
                nuevo.Codigo = txtCodigo.Text;
                nuevo.Nombre = txtNombre.Text;
                nuevo.Descripcion = txtDescripcion.Text;
                //nuevo.Marca = (Marca)cbMarca.SelectedItem;
                //nuevo.Categoria = (Categoria)cbCategoria.SelectedItem;
                nuevo.UrlImagen = txtImagen.Text;
                nuevo.Precio = double.Parse(txtPrecio.Text);

                negocio.agregar(nuevo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            NegocioCategoria NegocioCategoria = new NegocioCategoria();
            NegocioMarca NegocioMarca = new NegocioMarca();

            try
            {
                cbMarca.DataSource = NegocioMarca.Listar();
                cbMarca.ValueMember = "IdMarca";
                cbMarca.DisplayMember = "Nombre";

                cbCategoria.DataSource = NegocioCategoria.Listar();
                cbCategoria.ValueMember = "IdCategoria";
                cbCategoria.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
