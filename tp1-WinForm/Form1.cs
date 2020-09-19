using System;
using Negocio;
using Dominio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;

namespace tp1_WinForm
{
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }


        private void CargarDatos()
        {
            NegocioArticulo Negocio = new NegocioArticulo();
            DgvArticulos.DataSource = Negocio.Listar();

            DgvArticulos.Columns[0].Visible = false;
            DgvArticulos.Columns[6].Visible = false;


        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Form AbrirForm2 = new Form2();

            AbrirForm2.ShowDialog();

            CargarDatos();
        }

        private void DgvArticulos_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Articulo MostrarFoto;

                MostrarFoto = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;

                PicArticulo.Load(MostrarFoto.UrlImagen);

            }
            catch (Exception)
            {
                PicArticulo.Load("https://serv3.raiolanetworks.es/blog/wp-content/uploads/error-500-768x499.png");

            }

         
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo Cambiar;

            Cambiar = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;

            Form2 Modificar = new Form2(Cambiar);
            Modificar.Text = "Modificar";
            Modificar.ShowDialog();

            CargarDatos();

        }
    }
}
