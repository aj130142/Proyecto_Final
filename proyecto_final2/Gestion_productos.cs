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
    public partial class Gestion_productos : Form
    {
        public Gestion_productos()
        {
            InitializeComponent();
        }

        private void Gestion_porductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ventasDataSet1.tbProducto' Puede moverla o quitarla según sea necesario.
            this.tbProductoTableAdapter.Fill(this.ventasDataSet1.tbProducto);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            //int ano = dateTimePicker1.Value.Year;
            //int mes = dateTimePicker1.Value.Month;
            //int dia = dateTimePicker1.Value.Day;
            //string fechas = ""+ano+"-"+mes+"-"+"-"+dia ;
            this.tbProductoTableAdapter.InsertarProducto(txtCodigo.Text,txtNombre.Text,Convert.ToDecimal(txtPrecio.Text),txtCategoria.Text,txtDescripcion.Text,Convert.ToInt32(txtCantida.Text));
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.tbProductoTableAdapter.EliminarProducto(txtdeleteCodigo.Text,txtdeleteNombre.Text);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void insertaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActulizarPanel.Visible = false;
            eliminiPanel.Visible = false;
            insertarPanel.Visible = true;
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActulizarPanel.Visible = true;
            eliminiPanel.Visible = false;
            insertarPanel.Visible = false;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActulizarPanel.Visible = false;
            eliminiPanel.Visible = true;
            insertarPanel.Visible = false;
        }

        private void eliminiPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
