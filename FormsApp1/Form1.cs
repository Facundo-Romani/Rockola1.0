using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bdd;
using dominio;

namespace FormsApp1
{
    public partial class Form1 : Form
    {
        private List<Rockola> listaRocckola;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BddRockola Rockola = new BddRockola();
            listaRocckola = Rockola.lista();
            DgvDiscos.DataSource = listaRocckola;
            DgvDiscos.Columns["Url"].Visible = false;
            cargarImagen(listaRocckola[0].Url);
        }

        private void DgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Rockola discoSeleccionado = (Rockola)DgvDiscos.CurrentRow.DataBoundItem;
            cargarImagen(discoSeleccionado.Url);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBox1.Load(imagen);
            }
            catch (Exception ex)
            {
                pictureBox1.Load("https://w7.pngwing.com/pngs/848/297/png-transparent-white-graphy-color-empty-banner-blue-angle-white.png");
                throw ex;
            }
        }
    }
}
