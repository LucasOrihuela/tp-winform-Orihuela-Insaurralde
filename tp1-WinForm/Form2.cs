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
        private Articulo articulo = null;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Articulo Modificar)
        {

            InitializeComponent();

            articulo = Modificar;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            NegocioArticulo negocio = new NegocioArticulo();

            try
            {

                if (articulo == null) articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                articulo.UrlImagen = txtImagen.Text;
                articulo.Precio = double.Parse(txtPrecio.Text);

                if (articulo.Id == 0) negocio.agregar(articulo);

                else negocio.modificar(articulo);

                this.Close();
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
                cbMarca.ValueMember = "Id";
                cbMarca.DisplayMember = "NombreMarca";

               

                cbCategoria.DataSource = NegocioCategoria.Listar();
                cbCategoria.ValueMember = "Id";
                cbCategoria.DisplayMember = "NombreCategoria";


                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtImagen.Text = articulo.UrlImagen;
                    txtPrecio.Text = Convert.ToString(articulo.Precio);
                    cbMarca.SelectedValue = articulo.Marca.Id;
                    cbCategoria.SelectedValue = articulo.Categoria.Id;

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
