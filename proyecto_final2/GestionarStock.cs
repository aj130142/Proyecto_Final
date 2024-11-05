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
            this.tbMovimientosStockTableAdapter.Fill(this.ventasDataSet.tbMovimientosStock);

            // Llenar el ComboBox cuando el formulario se cargue
            ActualizarComboBoxProductos();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtener los valores ingresados
                string codigoProducto = cBoxIdProducto.Text;  // Captura el texto escrito en el combo box
                int cantidadMovimiento = Convert.ToInt32(txtCantidad.Text);
                string tipoMovimiento = cBoxTipoMov.SelectedItem.ToString();
                DateTime fechaMovimiento = dateTimePicker1.Value;
                string observaciones = txtObservaciones.Text;

                // 2. Validar datos
                if (string.IsNullOrWhiteSpace(codigoProducto) || cantidadMovimiento <= 0 || string.IsNullOrWhiteSpace(tipoMovimiento))
                {
                    MessageBox.Show("Por favor, complete los campos correctamente.");
                    return;
                }

                // 3. Obtener la cantidad actual del producto desde tbProducto
                int cantidadActual = (int)tbProductoTableAdapter1.ObtenerCantidadProductoPorCodigo(Convert.ToString(codigoProducto));

                // 4. Validar si es una salida y si hay suficiente stock
                if (tipoMovimiento == "Salida" && cantidadMovimiento > cantidadActual)
                {
                    MessageBox.Show("No hay suficiente stock disponible.");
                    return;  // No realiza ninguna acción más
                }

                // 5. Insertar el movimiento en tbMovimientosStock
                tbMovimientosStockTableAdapter.Insert(
                    Convert.ToInt32(codigoProducto),  // Asumimos que Id_Producto es un número. Ajusta si es necesario.
                    cantidadMovimiento,
                    tipoMovimiento,
                    fechaMovimiento,
                    observaciones
                );
                // 6. Actualizar la cantidad en tbProducto según el tipo de movimiento
                if (tipoMovimiento == "Entrada")
                {
                    // Sumar cantidad en caso de entrada
                    cantidadActual += cantidadMovimiento;
                }
                else if (tipoMovimiento == "Salida")
                {
                    // Restar cantidad en caso de salida
                    cantidadActual -= cantidadMovimiento;

                    // Validar que no se pueda reducir más de la cantidad disponible
                    if (cantidadActual < 0)
                    {
                        MessageBox.Show("No hay suficiente stock disponible.");
                        return;
                    }
                }

                // 7. Actualizar la cantidad del producto en tbProducto
                tbProductoTableAdapter1.ActualizarCantidadProducto(cantidadActual, Convert.ToString(codigoProducto));

                // 8. Actualizar la base de datos y refrescar el dataset
                tbMovimientosStockTableAdapter.Update(ventasDataSet.tbMovimientosStock);
                ventasDataSet.tbMovimientosStock.AcceptChanges();

                // 9. Actualizar el ComboBox con los nuevos productos
                ActualizarComboBoxProductos();

                // 10. Confirmación
                MessageBox.Show("Movimiento registrado con éxito.");
                RecargarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el movimiento: " + ex.Message);
            }

        }

        private void cBoxTipoMov_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ActualizarComboBoxProductos()
        {
            try
            {
                // Obtener los productos de la base de datos y llenar el combo box
                DataTable productos = tbProductoTableAdapter1.GetData();  // Asegúrate de tener el TableAdapter configurado
                cBoxIdProducto.DataSource = productos;
                cBoxIdProducto.DisplayMember = "Codigo";   // Mostrar el campo Código de los productos
                cBoxIdProducto.ValueMember = "Codigo"; // Usar Id_Producto como valor asociado

                // Permitir que el usuario escriba texto
                cBoxIdProducto.DropDownStyle = ComboBoxStyle.DropDown;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
        }

        // Método para recargar los datos en el DataGridView
        private void RecargarDataGridView()
        {
            // Vuelve a llenar el DataGridView con los datos más recientes
            this.tbMovimientosStockTableAdapter.Fill(this.ventasDataSet.tbMovimientosStock);
            dataGridView1.Refresh();  // Asegúrate de refrescar el DataGridView después de llenar los datos
        }

    }
}
