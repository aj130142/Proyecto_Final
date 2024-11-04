using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace proyecto_final2
{
    public partial class buscarProductos : Form
    {
        List<int> v = new List<int>();
        Timer timer;
        bool idresult;
        bool codigoresult;
        bool precioresult;
        bool cantidadresult;
        public buscarProductos()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 100; // Cada 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }



        private void buscarProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ventasDataSet1.tbProducto' Puede moverla o quitarla según sea necesario.
            this.tbProductoTableAdapter.Fill(this.ventasDataSet1.tbProducto);
            IdCheck.CheckedChanged += checkBox_CheckedChanged;
            
            CantidadCheck.CheckedChanged += checkBox_CheckedChanged;
            PrecioCheck.CheckedChanged += checkBox_CheckedChanged;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
            string texto= textBox1.Text;
            
                dataGridView1.DataSource= tbProductoTableAdapter.GeneralorCategoria(texto);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            // Obtén el CheckBox que disparó el evento
            System.Windows.Forms.CheckBox selectedCheckBox = sender as System.Windows.Forms.CheckBox;

            // Si el CheckBox está marcado, desmarca los otros
            if (selectedCheckBox.Checked)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox != selectedCheckBox)
                    {
                        checkBox.Checked = false;
                    }
                }
            }


            if (selectedCheckBox != null && selectedCheckBox.Checked)
            {
                // Desmarca todos los otros CheckBox
                foreach (Control control in this.Controls)
                {
                    if (control is System.Windows.Forms.CheckBox checkBox && checkBox != selectedCheckBox)
                    {
                        checkBox.Checked = false;
                    }
                }

                // Llama a la función automática
                FuncionAutomatica(selectedCheckBox);
            }



        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (PrecioCheck.Checked == false)
            {
                txtPrecio.Visible = false;
                textBox1.Visible = true;
            }
            if(CantidadCheck.Checked == false)
            {
                txtCantidad.Visible = false;
                textBox1.Visible = true;
            }
            if(IdCheck.Checked == false)
            {
                txtID.Visible = false;
                textBox1.Visible = true;
            }
            if (textBox1.Text==null)
            {
                dataGridView1.Rows.Clear();
            }
        }

        public void FuncionAutomatica(System.Windows.Forms.CheckBox selectedCheckBox)
        {
            string id= "IdCheck"; 
            string precio = "PrecioCheck";
            string cantidad = "CantidadCheck";
            idresult = id.Contains(selectedCheckBox.Name); 
            precioresult = precio.Contains(selectedCheckBox.Name);
            cantidadresult = cantidad.Contains(selectedCheckBox.Name);

            MessageBox.Show(""+precioresult);
            if (precioresult==true)
            {
                txtPrecio.Visible = true;
                textBox1 .Visible = false;
            }
            if (cantidadresult)
            {
                txtCantidad.Visible = true;
                textBox1.Visible = false;
            }

            if (idresult == true) 
            { 
                txtID.Visible = true;
                textBox1.Visible = false;
            }
            
        }

        private void txtID_KeyUp(object sender, KeyEventArgs e)
        {
            
            try
            {
                int texto = Convert.ToInt32(txtID.Text);
                dataGridView1.DataSource = tbProductoTableAdapter.BuscarId(texto);
            }
            catch
            {

            }
            
        }

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            
            try
            {
                int texto = Convert.ToInt32(txtCantidad.Text);
                dataGridView1.DataSource = tbProductoTableAdapter.BuscarCantidadExacta(texto);
            }
            catch
            {

            }
        }

        private void txtPrecio_KeyUp(object sender, KeyEventArgs e)
        {
            
            try
            {
                decimal texto = Convert.ToInt32(txtPrecio.Text);
                dataGridView1.DataSource = tbProductoTableAdapter.BuscarPrecio(texto);
            }
            catch
            {

            }
        }
    }
}
