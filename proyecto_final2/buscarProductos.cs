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
        bool stockbajo;
        bool precioresult;
        bool cantidadresult;
        bool predeter;
        bool antigue;
        bool recient;
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
            // TODO: esta línea de código carga datos en la tabla 'ventasDataSet.tbMovimientosStock' Puede moverla o quitarla según sea necesario.
            this.tbMovimientosStockTableAdapter.Fill(this.ventasDataSet.tbMovimientosStock);
            // TODO: esta línea de código carga datos en la tabla 'ventasDataSet1.tbProducto' Puede moverla o quitarla según sea necesario.
            this.tbProductoTableAdapter.Fill(this.ventasDataSet1.tbProducto);
            IdCheck.CheckedChanged += checkBox_CheckedChanged;
            StockdownCheck.CheckedChanged += checkBox_CheckedChanged;
            CantidadCheck.CheckedChanged += checkBox_CheckedChanged;
            PrecioCheck.CheckedChanged += checkBox_CheckedChanged;
            predeCheck.CheckedChanged += checkBox_CheckedChanged;
            recienteCheck.CheckedChanged += checkBox_CheckedChanged;    
            antiguedadCheck.CheckedChanged += checkBox_CheckedChanged;

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
                
            }
            if(CantidadCheck.Checked == false)
            {
                txtCantidad.Visible = false;
                
            }
            if(IdCheck.Checked == false)
            {
                txtID.Visible = false;
                
            }
            if (predeCheck.Checked == false)
            {
                textBox1.Visible=false;
            }
            if(StockdownCheck.Checked == false)
            {
                txtstockmenor.Visible=false;
            }
            if (textBox1.Text==null)
            {
                dataGridView1.Rows.Clear();
            }
            if (antiguedadCheck.Checked==false)
            {
                timeAntiguedad.Visible=false;
                timeAntiguedad2.Visible=false;
            }
            if (recienteCheck.Checked==false)
            {
                timeventas.Visible=false;
                timeventasF.Visible=false;
            }
        }

        public void FuncionAutomatica(System.Windows.Forms.CheckBox selectedCheckBox)
        {
            string id= "IdCheck"; 
            string precio = "PrecioCheck";
            string cantidad = "CantidadCheck";
            string prede = "predeCheck";
            string stockmenor = "StockdownCheck";
            string antiguedad = "antiguedadCheck";
            string reciente = "recienteCheck";
            
            idresult = id.Contains(selectedCheckBox.Name); 
            precioresult = precio.Contains(selectedCheckBox.Name);
            cantidadresult = cantidad.Contains(selectedCheckBox.Name);
            predeter = prede.Contains(selectedCheckBox.Name);
            stockbajo = stockmenor.Contains(selectedCheckBox.Name);
            antigue= antiguedad.Contains(selectedCheckBox.Name);    
            recient= reciente.Contains(selectedCheckBox.Name);

            if (precioresult==true)
            {
                txtPrecio.Visible = true;
                
            }
            if (cantidadresult)
            {
                txtCantidad.Visible = true;
                
            }

            if (idresult == true) 
            { 
                txtID.Visible = true;
                
            }
            if (predeter == true) { 
                textBox1.Visible=true;
            }
            if (antigue)
            {
                timeAntiguedad.Visible = true;  
                timeAntiguedad2.Visible = true;
            }
            if (recient) 
            {
                timeventas.Visible = true;
                timeventasF.Visible = true;
            }
            if (stockbajo)
            {
                txtstockmenor.Visible=true;
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
                dataGridView1.DataSource = tbProductoTableAdapter.GetDataByStockBajo(texto);
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

        private void stockCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtstock_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int texto = Convert.ToInt32(txtstockmenor.Text);
                dataGridView1.DataSource = tbProductoTableAdapter.GetDataByStockBajo(texto);
            }
            catch
            {

            }
        }

        private void PrecioCheck_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void timeAntiguedad_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionadaI = timeAntiguedad.Value;
            DateTime fechaSeleccionadaF = timeAntiguedad2.Value;
            int diaI = fechaSeleccionadaI.Day;
            int mesI = fechaSeleccionadaI.Month;
            int añoI = fechaSeleccionadaI.Year;
            string fechaI = Convert.ToString(añoI)+"-"+Convert.ToString(mesI)+"-"+Convert.ToString(diaI);
            DateTime fechaDateI = DateTime.Parse(fechaI);

            int diaF = fechaSeleccionadaF.Day;
            int mesF = fechaSeleccionadaF.Month;
            int añoF = fechaSeleccionadaF.Year;
            string fechaF = Convert.ToString(añoF) + "-" + Convert.ToString(mesF) + "-" + Convert.ToString(diaF);
            DateTime fechaDateF = DateTime.Parse(fechaF);


            dataGridView1.DataSource = tbMovimientosStockTableAdapter.GetDataByMovFecha(fechaI,fechaF);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timeAntiguedad2_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionadaI = timeAntiguedad.Value;
            DateTime fechaSeleccionadaF = timeAntiguedad2.Value;
            int diaI = fechaSeleccionadaI.Day;
            int mesI = fechaSeleccionadaI.Month;
            int añoI = fechaSeleccionadaI.Year;
            string fechaI = Convert.ToString(añoI) + "-" + Convert.ToString(mesI) + "-" + Convert.ToString(diaI);
            DateTime fechaDateI = DateTime.Parse(fechaI);

            int diaF = fechaSeleccionadaF.Day;
            int mesF = fechaSeleccionadaF.Month;
            int añoF = fechaSeleccionadaF.Year;
            string fechaF = Convert.ToString(añoF) + "-" + Convert.ToString(mesF) + "-" + Convert.ToString(diaF);
            DateTime fechaDateF = DateTime.Parse(fechaF);


            dataGridView1.DataSource = tbMovimientosStockTableAdapter.GetDataByMovFecha(fechaI, fechaF);    
        }

        private void recienteCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timeventas_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionadaI = timeventas.Value;
            DateTime fechaSeleccionadaF = timeventasF.Value;
            int diaI = fechaSeleccionadaI.Day;
            int mesI = fechaSeleccionadaI.Month;
            int añoI = fechaSeleccionadaI.Year;
            string fechaI = Convert.ToString(añoI) + "-" + Convert.ToString(mesI) + "-" + Convert.ToString(diaI);
            DateTime fechaDateI = DateTime.Parse(fechaI);

            int diaF = fechaSeleccionadaF.Day;
            int mesF = fechaSeleccionadaF.Month;
            int añoF = fechaSeleccionadaF.Year;
            string fechaF = Convert.ToString(añoF) + "-" + Convert.ToString(mesF) + "-" + Convert.ToString(diaF);
            DateTime fechaDateF = DateTime.Parse(fechaF);


            dataGridView1.DataSource = tbMovimientosStockTableAdapter.GetDataMovFechaSalida(fechaI, fechaF);
        
    }

        private void timeventasF_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionadaI = timeventas.Value;
            DateTime fechaSeleccionadaF = timeventasF.Value;
            int diaI = fechaSeleccionadaI.Day;
            int mesI = fechaSeleccionadaI.Month;
            int añoI = fechaSeleccionadaI.Year;
            string fechaI = Convert.ToString(añoI) + "-" + Convert.ToString(mesI) + "-" + Convert.ToString(diaI);
            DateTime fechaDateI = DateTime.Parse(fechaI);

            int diaF = fechaSeleccionadaF.Day;
            int mesF = fechaSeleccionadaF.Month;
            int añoF = fechaSeleccionadaF.Year;
            string fechaF = Convert.ToString(añoF) + "-" + Convert.ToString(mesF) + "-" + Convert.ToString(diaF);
            DateTime fechaDateF = DateTime.Parse(fechaF);


            dataGridView1.DataSource = tbMovimientosStockTableAdapter.GetDataMovFechaSalida(fechaI, fechaF);
        }
    }
}
