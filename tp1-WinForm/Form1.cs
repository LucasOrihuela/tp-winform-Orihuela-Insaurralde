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
            NegocioArticulo Negocio = new NegocioArticulo();
            DgvArticulos.DataSource = Negocio.Listar();

        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Form AbrirForm2 = new Form2();

            AbrirForm2.ShowDialog();
        }
    }
}
