using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using ENTITY;
using BLL;

namespace GUI
{
    public partial class Grafica : Form
    {

        //private readonly Red red;

        private List<string> Datos { get; set; }
        public bool Crear { get; set; }

        public Grafica()
        {
            Crear = true;
            Datos = new List<string>();
            InitializeComponent();
            Config();
        }

        private void Config()
        {
            var watcher = new FileSystemWatcher(@"C:\Users\jhean\Documents\2021-1\Inteligencia artificial\Neurona\GUI\bin\Debug");

            watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            watcher.Filter = "*.xml";
            watcher.IncludeSubdirectories = false;
            watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            chart2_Click(sender, e);
            Console.WriteLine($"Changed: {e.FullPath} -> {Telefono.Red.Error}");
            //grafica1.Series["Series1"].Points.AddXY(Telefono.Red.Salidas[0].);
            var j = 1;
            foreach (var item in Telefono.Red.Salidas)
            {
                grafica1.Series["Salida "+j].Points.Add(item.Error);
                ++j;
            }
            
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
        }

        public void CargarDatos()
        {
            grafica1.Series.Add("Prueba");
            grafica1.Series["Prueba"].Points.Add(10);
            grafica1.Series["Prueba"].Points[0].ToolTip = "$ " + 10;
        }

        private void Grafica_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {
            if (Crear)
            {
                var i = 1;
                foreach (var item in Telefono.Red.Salidas)
                {
                    grafica1.Series.Clear();
                    grafica1.Series.Add("Salida " + i);
                    ++i;
                }
                Crear = false;
            }
        }
    }
}
