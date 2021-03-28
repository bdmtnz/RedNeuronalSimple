using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using BLL;
using System.Threading;

namespace GUI
{
    public partial class Graficar2 : Form
    {
        private readonly Red Red;
        //private readonly Red red;MetodoGrafica
        MetodoGrafica grafica;

        public Graficar2(Red Red)
        {
            this.Red = Red;
            InitializeComponent();
            Config(Red);
            grafica = new MetodoGrafica();
            grafica.working += new MetodoGrafica.work(notificar);
            Thread t = new Thread(grafica.Trabajando);
            t.Start();
        }

        private void Config(Red Red)
        {
            chart1.Series.Clear();
            var i = 1;
            foreach (var item in Red.Salidas)
            {
                chart1.Series.Add("Salida " + i);
                chart1.Series["Salida " + i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                i++;
            }
        }
        

        public void notificar(Red Red)
        {
            //chart1.Series["Series1"].Points.Add(lista);
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    chart1.Series["Salida " + 1].Points.Add(Red.Error);
                    var i = 1;
                    foreach (var item in Red.Salidas)
                    {
                        chart1.Series["Salida " + i].Points.Add(item.Esperada);
                        i++;
                    }
                }));
                Thread.Sleep(100);
            }
        }






        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
}
