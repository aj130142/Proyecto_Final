using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Windows.Forms.DataVisualization.Charting;


namespace proyecto_final2
{
    public partial class Graficas : Form
    {
        public Graficas()
        {
            InitializeComponent();
            
            ConfigurarGrafica();
            ConfigurarGraficaTorta();

        }
        
private void Graficas_Load(object sender, EventArgs e)
        {

        }

        private void ConfigurarGrafica()
        {
            this.tbProductoTableAdapter.Fill(this.ventasDataSet1.tbProducto);
            // Limpia la gráfica de series anteriores
            chart1.Series.Clear();

            // Crea y configura la serie de la gráfica de líneas
            Series serieLineas = new Series("Cantidad por Categoría")
            {
                ChartType = SeriesChartType.Line, // Gráfica de líneas
                XValueType = ChartValueType.String, // Eje X muestra categorías como texto
                YValueType = ChartValueType.Int32 // Eje Y muestra cantidades como enteros
            };

            // Obtén los datos agrupados de tu tabla
            var datosPorCategoria = ventasDataSet1.tbProducto
                .GroupBy(p => p.Categoria)
                .Select(g => new
                {
                    Categoria = g.Key,
                    CantidadTotal = g.Sum(p => p.Cantidad)
                })
                .ToList();

            // Agrega los puntos a la serie
            foreach (var dato in datosPorCategoria)
            {
                serieLineas.Points.AddXY(dato.Categoria, dato.CantidadTotal);
            }

            // Agrega la serie al Chart
            chart1.Series.Add(serieLineas);

            // Configura el eje X
            chart1.ChartAreas[0].AxisX.Title = "Categoría";
            chart1.ChartAreas[0].AxisX.Interval = 1; // Asegura que todas las categorías se muestren
            chart1.ChartAreas[0].AxisX.LabelStyle.IsEndLabelVisible = true;

            // Configura el eje Y
            chart1.ChartAreas[0].AxisY.Title = "Cantidad";
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "N0"; // Formato entero sin decimales

            // Opcional: Configuración de apariencia
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
        }
        private void ConfigurarGraficaTorta()
        {


            // Llenar el DataSet antes de usarlo
            this.tbProductoTableAdapter.Fill(this.ventasDataSet1.tbProducto);

            if (ventasDataSet1.tbProducto.Rows.Count == 0)
{
    MessageBox.Show("No hay datos en tbProducto.");
    return;
}

            // Limpia series anteriores si existen
            chart2.Series.Clear();

            // Crea y configura la serie de la gráfica de torta
            Series serieTorta = new Series("Cantidad por Categoría")
            {
                ChartType = SeriesChartType.Pie, // Gráfica de torta
                XValueType = ChartValueType.String, // Eje X muestra categorías como texto
                YValueType = ChartValueType.Int32 // Eje Y muestra cantidades como enteros
            };

            // Obtén los datos agrupados de tu tabla
            var datosPorCategoria = ventasDataSet1.tbProducto
                .GroupBy(p => p.Categoria)
                .Select(g => new
                {
                    Categoria = g.Key,
                    CantidadTotal = g.Sum(p => p.Cantidad)
                })
                .ToList();

            // Agrega los puntos a la serie (cada punto es una "rebanada" de la torta)
            foreach (var dato in datosPorCategoria)
            {
                DataPoint punto = new DataPoint
                {
                    AxisLabel = dato.Categoria,
                    YValues = new double[] { dato.CantidadTotal }
                };
                serieTorta.Points.Add(punto);
            }

            // Agrega la serie al Chart
            chart2.Series.Add(serieTorta);

            // Configuración adicional para la gráfica de torta
            chart2.Legends.Add(new Legend("Leyenda"));
            serieTorta.IsValueShownAsLabel = true; // Muestra valores en las rebanadas
            serieTorta.LabelFormat = "#,##0"; // Formato de etiqueta sin decimales
        }

    }
}
