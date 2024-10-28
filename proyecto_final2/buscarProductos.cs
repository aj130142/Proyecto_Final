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
    public partial class buscarProductos : Form
    {
        List<int> v = new List<int>();
        int contador=0;
        public buscarProductos()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            foreach (var index in listFiltros.CheckedIndices.Cast<int>())
            {
                
                v.Add(index);
                
                
            }
            MessageBox.Show(""+v[0]+" " + v[1]);
            
        }

        private void buscarProductos_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
