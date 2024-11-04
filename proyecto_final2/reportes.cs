using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;



namespace proyecto_final2
{
    public partial class reportes : Form
    {
        private Timer timer;
        
        string folderPath;
        public reportes()
        {
            InitializeComponent();

   



            // Inicializar el Timer
            timer = new Timer();
            timer.Interval = 1000; // 30 segundos
            timer.Tick += Timer_Tick; // Asignar el evento Tick
            timer.Start(); // Iniciar el Timer

        }



        private void Timer_Tick(object sender, EventArgs e)
        {
            string programDirectory = AppDomain.CurrentDomain.BaseDirectory;
            folderPath = Path.Combine(programDirectory, "Reporte");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            // Recargar la URL en el ChromiumWebBrowser
            
        }




        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Detener el Timer
            timer.Stop();

            
        }

        private void reportes_Load(object sender, EventArgs e)
        {
            //reportViewer1.LocalReport.ReportPath = @"C:\Users\chino\source\repos\proyecto_final2\proyecto_final2\reportes\Report1.rdlc";

            // TODO: esta línea de código carga datos en la tabla 'ventasDataSet1.tbProducto' Puede moverla o quitarla según sea necesario.
            
            try
            {
                this.tbProductoTableAdapter.Fill(this.ventasDataSet1.tbProducto);
                this.tbVentasTableAdapter.Fill(this.ventasDataSet1.tbVentas);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", (DataTable)ventasDataSet1.tbVentas));

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }



            this.reportViewer1.RefreshReport();
            
            this.reportViewer1.RefreshReport();
        }
    }
}
