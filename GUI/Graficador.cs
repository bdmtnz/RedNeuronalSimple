using System;
using System.IO;
using System.Windows.Forms;
using ENTITY;
using System.Drawing;

namespace GUI
{
    public partial class Graficador : Form
    {

        public int X_Click { get; set; }
        public int Y_Click { get; set; }
        private int i { get; set; }
        public bool Crear { get; set; }

        private readonly Red Red;

        private readonly Dashboard Padre;
        private FileSystemWatcher Watcher { get; set; }
        private int Iteracion { get; set; }

        public Graficador(Red Red, Dashboard Padre)
        {
            this.Red = Red;
            this.Padre = Padre;
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
                //SERIES PARA LA GRÁFICA
                grafica2.Series.Add("YR " + i);
                grafica2.Series["YR " + i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                //CONTROLES PARA LOS ERRORES
                var Pn = new Panel();
                Pn.Dock = DockStyle.Top;
                Pn.Height = 50;
                Pn.Padding = new Padding(6);

                var TextName = new Label();
                TextName.Name = "LbYR0" + i;
                TextName.Text = "YR " + i + ":";
                TextName.AutoSize = false;
                TextName.Dock = DockStyle.Left;
                TextName.Width = 68;
                TextName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                TextName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
                Pn.Controls.Add(TextName);

                var TextError = new Label();
                TextError.Name = "LbError0" + i;
                TextError.Text = "#";
                TextError.AutoSize = false;
                TextError.Dock = DockStyle.Right;
                TextError.Width = 194;
                TextError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                TextError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
                Pn.Controls.Add(TextError);

                PnErrores.Controls.Add(Pn);
                i++;
            }
        }

        private void Config()
        {
            Watcher = new FileSystemWatcher(@".\");

            Watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            Watcher.Changed += OnChanged;
            Watcher.Filter = "*.xml";
            Watcher.IncludeSubdirectories = false;
            Watcher.EnableRaisingEvents = true;
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
                    if(Iteracion % 2 == 0)
                    {
                        //VALIDAR SI SE DEBE LIMPIAR LAS GRAFICAS
                        //if (grafica1.Series["ErrorIT"].Points.Count >= 1000)
                        //if(Plataforma.Red.Entrenamientos % 1000 == 0)
                        if (Plataforma.Red.Entrenamientos >= 400)
                        {
                            grafica1.Series["ErrorIT"].Points.RemoveAt(0);
                            var Salidas = Red.Capas[Red.Capas.Count - 1].Neuronas.Count;
                            for (int i = 0; i < Salidas; i++)
                            {
                                grafica2.Series["YR " + (i + 1)].Points.RemoveAt(0);
                            }
                        }

                        //GRAFICAR
                        var j = 1;
                        foreach (var item in Red.Capas[Red.Capas.Count - 1].Neuronas)
                        {
                            grafica2.Series["YR " + j].Points.Add(item.Error);
                            j++;
                        }
                        grafica1.Series["ErrorIT"].Points.Add(Plataforma.Red.Error);
                        CargarDatos();
                    }
                    Iteracion++;
                }));
            }
        }

        public void CargarDatos()
        {
            LbIteracion.Text = Plataforma.Red.Entrenamientos.ToString();
            //LbUmbral.Text = Plataforma.Red.Umbral.Valor.ToString();
            LbError.Text = Plataforma.Red.Error.ToString();
            //LbWs.Text = Plataforma.W;

            //ERRORES POR SALIDA
            var i = 0;
            foreach (Control item in PnErrores.Controls)
            {
                item.Controls[1].Text = Plataforma.Red.Capas[Plataforma.Red.Capas.Count - 1].Neuronas[i].Error.ToString();
                i++;
            }

            //ENTRENADO
            if(Plataforma.Red.ErrorMaxPermitido >= Plataforma.Red.Error)
            {
                LbEntrenado.Text = "Sí";
                LbEntrenado.ForeColor = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Close(object sender, EventArgs e)
        {
            Plataforma.Continuar = false;
            Hide();
        }
    }
}
