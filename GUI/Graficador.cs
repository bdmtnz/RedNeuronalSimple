using System;
using System.IO;
using System.Windows.Forms;
using ENTITY;

namespace GUI
{
    public partial class Graficador : Form
    {

        public int X_Click { get; set; }
        public int Y_Click { get; set; }
        private int i { get; set; }
        public bool Crear { get; set; }

        private readonly Red Red;

        public Graficador(Red Red)
        {
            this.Red = Red;
            Crear = true;
            InitializeComponent();
            Config();
            Config(Red);
        }

        private void Config(Red Red)
        {
            grafica2.Series.Clear();
            grafica1.Series.Clear();
            grafica1.Series.Add("ErrorIT");
            grafica1.Series["ErrorIT"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            var i = 1;
            foreach (var item in Red.Capas[Red.Capas.Count - 1].Neuronas)
            {
                grafica2.Series.Add("YR " + i);
                grafica2.Series["YR " + i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                i++;
            }
        }

        private void Config()
        {
            var watcher = new FileSystemWatcher(@".\");

            watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            watcher.Changed += OnChanged;
            watcher.Filter = "*.xml";
            watcher.IncludeSubdirectories = false;
            watcher.EnableRaisingEvents = true;
        }

        private void MoveWindow(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                X_Click = e.X; Y_Click = e.Y;
            }
            else
            {
                Left += (e.X - X_Click);
                Top += (e.Y - Y_Click);
            }
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    //VALIDAR SI SE DEBE LIMPIAR LAS GRAFICAS
                    if(grafica1.Series["ErrorIT"].Points.Count > 500)
                    {
                        grafica1.Series["ErrorIT"].Points.Clear();
                        var Salidas = Red.Capas[Red.Capas.Count - 1].Neuronas.Count;
                        for (int i = 0; i < Salidas; i++)
                        {
                            grafica2.Series["YR " + (i+1)].Points.Clear();
                        }
                    }

                    //GRAFICAR
                    grafica1.Series["ErrorIT"].Points.Add(Plataforma.Red.Error);
                    var j = 1;
                    foreach (var item in Red.Capas[Red.Capas.Count - 1].Neuronas)
                    {
                        grafica2.Series["YR " + j].Points.Add(item.Error);
                        j++;
                    }
                    CargarDatos();
                }));
            }
        }

        public void CargarDatos()
        {
            LbIteracion.Text = Plataforma.Red.Entrenamientos.ToString();
            //LbUmbral.Text = Plataforma.Red.Umbral.Valor.ToString();
            LbError.Text = Plataforma.Red.Error.ToString();
            //LbWs.Text = Plataforma.W;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnPausa_Click(object sender, EventArgs e)
        {
            BtnPausa.Visible = false;
            BtnIniciar.Visible = true;
            Plataforma.Continuar = false;
            CargarDatos();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            BtnPausa.Visible = true;
            BtnIniciar.Visible = false;
            Plataforma.Continuar = true;
            CargarDatos();
        }

        private void CloseWindow(object sender, FormClosingEventArgs e)
        {
            Plataforma.Continuar = false;
        }
    }
}
