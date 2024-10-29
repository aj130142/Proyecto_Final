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
        
        public buscarProductos()
        {
            InitializeComponent();
        }

        /*private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var index in listFiltros.CheckedIndices.Cast<int>())
                {

                    v.Add(index);


                }
                MessageBox.Show("" + v[0] + " " + v[1]);
            }
            catch
            {

            }
            
            
        }*/

        private void buscarProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ventasDataSet1.tbProducto' Puede moverla o quitarla según sea necesario.
            this.tbProductoTableAdapter.Fill(this.ventasDataSet1.tbProducto);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btStocklow_Click(object sender, EventArgs e)
        {

            this.tbProductoTableAdapter.FillByStockBajo(this.ventasDataSet1.tbProducto);

            dataGridView1.DataSource = this.ventasDataSet1.tbProducto;

            dataGridView1.Refresh();
        }
    }
}
