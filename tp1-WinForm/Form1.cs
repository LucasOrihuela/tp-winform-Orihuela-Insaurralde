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
            CargarDrigView();
        }

        private void CargarDrigView()
        {
            NegocioArticulo Negocio = new NegocioArticulo();

            try
            {
               
                //DgvArticulos.DataSource = Negocio.Listar();
                

                
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
