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
            ConfigurarGrafica();
            
            dispercion();

            timer = new Timer();
            timer.Interval = 100; // Cada 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ConfigurarGrafica();
            ConfigurarGraficaTorta();
            dispercion();
            
        }

        private void Graficas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ventasDataSet1.tbMovimientosStock' Puede moverla o quitarla según sea necesario.
            this.tbMovimientosStockTableAdapter.Fill(this.ventasDataSet1.tbMovimientosStock);

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

            if (!chart2.Legends.Any(l => l.Name == "Leyenda"))
            {
                Legend legend = new Legend("Leyenda");
                legend.Docking = Docking.Right; // Posiciona la leyenda
                chart2.Legends.Add(legend);
            }

        }





        // Método para configurar el gráfico con los datos procesados
        private void ConfigurarGrafico(List<(string Nombre, int CantidadMesActual)> datosPorProducto)
        {
            // Limpia series y áreas previas
            chart4.Series.Clear();
            chart4.ChartAreas.Clear();
            chart4.ChartAreas.Add(new ChartArea("MainArea"));

            // Configura la serie de líneas
            Series serieLineas = new Series("Cantidad de Salidas (Mes Actual)")
            {
                ChartType = SeriesChartType.Line,
                IsValueShownAsLabel = true // Muestra valores en los puntos
            };

            // Agrega puntos a la serie
            foreach (var dato in datosPorProducto)
            {
                serieLineas.Points.AddXY(dato.Nombre, dato.CantidadMesActual);
            }

            chart4.Series.Add(serieLineas);

            // Configura los títulos de los ejes
            chart4.ChartAreas[0].AxisX.Title = "Productos";
            chart4.ChartAreas[0].AxisY.Title = "Cantidad Salida";

            // Configura la leyenda
            if (!chart4.Legends.Any(l => l.Name == "Leyenda"))
            {
                Legend legend = new Legend("Leyenda")
                {
                    Docking = Docking.Right
                };
                chart4.Legends.Add(legend);
            }

            chart4.Invalidate(); // Redibuja el gráfico
        }




        public void dispercion()
        {
            // Limpia series anteriores
            chart3.Series.Clear();
            chart3.ChartAreas.Clear();
            chart3.ChartAreas.Add(new ChartArea());

            // Crea y configura la serie de la gráfica de dispersión
            Series serieDispercion = new Series("Datos de Productos")
            {
                ChartType = SeriesChartType.Point,
                IsValueShownAsLabel = true // Muestra los valores en los puntos
            };

            // Obtén los datos de tu tabla
            var datosPorProducto = ventasDataSet1.tbProducto
                .AsEnumerable()
                .Select(p => new
                {
                    Precio = p.Field<decimal>("Precio"), // Asegúrate de que el tipo sea correcto
                    Cantidad = p.Field<int>("Cantidad"),
                    Categoria = p.Field<string>("Categoria")
                })
                .ToList();

            // Verifica si hay datos para graficar


            // Lista de colores predefinidos en el orden deseado
            var coloresPredefinidos = new List<Color>
{
    Color.Red,      // 0
    Color.Purple,   // 1
    Color.Blue,     // 2
    Color.Green,    // 3
    Color.Yellow,   // 4
    Color.Orange,   // 5
    Color.Brown     // 6
    // Puedes agregar más colores si es necesario
};

            // Diccionario para guardar los colores de las categorías
            var coloresPorCategoria = new Dictionary<string, Color>();
            int colorIndex = 0; // Índice para colores

            // Obtén categorías únicas
            var categoriasUnicas = datosPorProducto
                .Select(d => d.Categoria)
                .Distinct()
                .ToList();

            // Limpiar el diccionario de colores
            coloresPorCategoria.Clear();
            colorIndex = 0; // Reiniciar índice de color para nueva asignación

            // Asignar colores a las categorías
            foreach (var categoria in categoriasUnicas)
            {
                // Si la categoría no tiene color asignado, asígnale uno nuevo
                if (!coloresPorCategoria.ContainsKey(categoria))
                {
                    coloresPorCategoria[categoria] = coloresPredefinidos[colorIndex % coloresPredefinidos.Count];
                    colorIndex++; // Incrementa el índice de color
                }
            }

            // Limpiar los puntos de la serie
            serieDispercion.Points.Clear();

            // Asignar los puntos a la serie con sus colores
            foreach (var dato in datosPorProducto)
            {
                serieDispercion.Points.AddXY(dato.Precio, dato.Cantidad);

                // Asigna el color correspondiente
                serieDispercion.Points.Last().Color = coloresPorCategoria[dato.Categoria];
            }

            // Agrega la serie al Chart
            chart3.Series.Add(serieDispercion);

            // Configura la leyenda si no existe
            if (!chart3.Legends.Any(l => l.Name == "Leyenda"))
            {
                Legend legend = new Legend("Leyenda");
                legend.Docking = Docking.Right; // Posiciona la leyenda
                chart3.Legends.Add(legend);
            }

            // Limpiar la leyenda existente
            chart3.Legends[0].CustomItems.Clear();

            // Agregar leyenda para las categorías
            foreach (var categoria in coloresPorCategoria.Keys)
            {
                LegendItem item = new LegendItem
                {
                    Name = categoria,
                    Color = coloresPorCategoria[categoria]
                };
                chart3.Legends[0].CustomItems.Add(item);
            }

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            timer.Stop(); // Detiene el Timer
            base.OnFormClosing(e);
        }
    }
}
