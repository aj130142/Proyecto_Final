using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void gestionDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_productos gestion = new Gestion_productos();
            gestion.Show();
        }

        private void buscarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarProductos buscar = new buscarProductos();
            buscar.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportes ventana = new reportes();
            ventana.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void gestonarStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionarStock gestionarStock = new GestionarStock();
            gestionarStock.Show();
        }

        private void graficasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graficas graficas = new Graficas();
            graficas.Show();
        }
    }
}
