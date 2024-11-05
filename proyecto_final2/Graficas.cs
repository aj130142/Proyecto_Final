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
        Timer timer;
        public Graficas()
        {
            InitializeComponent();
            ConfigurarGraficaTorta();


            timer = new Timer();
            timer.Interval = 100; // Cada 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ConfigurarGrafica();
            ConfigurarGraficaTorta();
        }

        private void Graficas_Load(object sender, EventArgs e)
        {

        }

        private void ConfigurarGrafica()
        {
            this.tbProductoTableAdapter.Fill(this.ventasDataSet1.tbProducto);

            // Verifica que haya datos

            // Limpia series anteriores
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add(new ChartArea());

            // Crea y configura la serie de la gráfica de líneas
            Series serieLineas = new Series("Cantidad por Categoría")
            {
                ChartType = SeriesChartType.Line,
                IsValueShownAsLabel = true // Muestra valores en los puntos
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

            // Verifica si hay datos agrupados
            if (!datosPorCategoria.Any())
            {
                MessageBox.Show("No hay datos agrupados para mostrar.");
                return;
            }

            // Agrega los puntos a la serie
            foreach (var dato in datosPorCategoria)
            {
                serieLineas.Points.AddXY(dato.Categoria, dato.CantidadTotal);
            }

            // Agrega la serie al Chart
            chart1.Series.Add(serieLineas);

            // Configura la leyenda si no existe
            if (!chart1.Legends.Any(l => l.Name == "Leyenda"))
            {
                Legend legend = new Legend("Leyenda");
                legend.Docking = Docking.Right; // Posiciona la leyenda
                chart1.Legends.Add(legend);
            }
        }
        private void ConfigurarGraficaTorta()
        {

            // Llenar el DataSet antes de usarlo
            this.tbProductoTableAdapter.Fill(this.ventasDataSet1.tbProducto);



            // Limpia series anteriores
            chart2.Series.Clear();
            chart2.ChartAreas.Clear();
            chart2.ChartAreas.Add(new ChartArea());

            // Crea y configura la serie de la gráfica de torta
            Series serieTorta = new Series("Cantidad por Categoría")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true // Muestra valores en las rebanadas
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

            // Verifica si hay datos agrupados
            if (!datosPorCategoria.Any())
            {
                MessageBox.Show("No hay datos agrupados para mostrar.");
                return;
            }

            // Agrega los puntos a la serie
            foreach (var dato in datosPorCategoria)
            {
                serieTorta.Points.AddXY(dato.Categoria, dato.CantidadTotal);
            }

            // Agrega la serie al Chart
            chart2.Series.Add(serieTorta);

            if (!chart1.Legends.Any(l => l.Name == "Leyenda"))
            {
                Legend legend = new Legend("Leyenda");
                legend.Docking = Docking.Right; // Posiciona la leyenda
                chart1.Legends.Add(legend);
            }

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            timer.Stop(); // Detiene el Timer
            base.OnFormClosing(e);
        }
    }
}
