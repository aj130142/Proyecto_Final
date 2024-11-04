using proyecto_final2.ventasDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final2
{
    public partial class GestionarStock : Form
    {
        public GestionarStock()
        {
            InitializeComponent();
        }

        private void GestionarStock_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ventasDataSet.tbMovimientosStock' Puede moverla o quitarla según sea necesario.
            //this.tbMovimientosStockTableAdapter.Fill(this.ventasDataSet.tbMovimientosStock);

            try
            {
                // Obtener los productos de la base de datos y llenar el combo box
                DataTable productos = tbProductoTableAdapter1.GetData();  // Asegúrate de tener un TableAdapter configurado
                cBoxIdProducto.DataSource = productos;
                cBoxIdProducto.DisplayMember = "Codigo";   // Mostrar el campo Código de los productos
                cBoxIdProducto.ValueMember = "Id_Producto"; // Usar Id_Producto como valor asociado

                // Permitir que el usuario escriba texto
                cBoxIdProducto.DropDownStyle = ComboBoxStyle.DropDown;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtener los valores ingresados
                string codigoProducto = cBoxIdProducto.Text;  // Captura el texto escrito en el combo box
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                string tipoMovimiento = cBoxTipoMov.SelectedItem.ToString();
                DateTime fechaMovimiento = dateTimePicker1.Value;
                string observaciones = txtObservaciones.Text;

                // 2. Validar datos
                if (string.IsNullOrWhiteSpace(codigoProducto) || cantidad <= 0 || string.IsNullOrWhiteSpace(tipoMovimiento))
                {
                    MessageBox.Show("Por favor, complete los campos correctamente.");
                    return;
                }

                // 3. Insertar datos en la tabla de movimientos de stock
                tbMovimientosStockTableAdapter.Insert(
                    Convert.ToInt32(codigoProducto),  // Aquí asumimos que el código es un número. Ajusta si es necesario.
                    cantidad,
                    tipoMovimiento,
                    fechaMovimiento,
                    observaciones
                );

                // 4. Actualizar la base de datos y refrescar el dataset
                tbMovimientosStockTableAdapter.Update(ventasDataSet.tbMovimientosStock);
                ventasDataSet.tbMovimientosStock.AcceptChanges();

                // 5. Confirmación
                MessageBox.Show("Movimiento registrado con éxito.");
                // Recargar los datos en el DataGridView para reflejar los cambios
                this.tbMovimientosStockTableAdapter.Fill(this.ventasDataSet.tbMovimientosStock);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el movimiento: " + ex.Message);
            }

        }

        private void cBoxTipoMov_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Text = cBoxTipoMov.Text;
        }
    }
}
