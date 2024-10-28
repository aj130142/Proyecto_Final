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
            webBrowser1.Navigate(folderPath + "/index.html");
            //hoka
        }




        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Detener el Timer
            timer.Stop();

            webBrowser1.Stop();
            
        }
    }
}
