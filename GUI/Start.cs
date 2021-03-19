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

namespace GUI
{
    public partial class Start : Form
    {
        private NeuronaService _Neurona { get; set; }
        private Neurona Neurona { get; set; }
        public int X_Click { get; set; }
        public int Y_Click { get; set; }

        public Start()
        {
            _Neurona = new NeuronaService();
            InitializeComponent();
            Preload();
            Config();
        }

        private void Preload()
        {
            CbActivacion.Items.AddRange(new object[] { 
                FUNCION.Escalon.ToString(),
                FUNCION.Lineal.ToString(),
                FUNCION.Sigmoide.ToString()
            });
            CbActivacion.SelectedIndex = 0;  
        }

        private void Config()
        {
            Neurona = _Neurona.ReadXml();
            ShowInfo(Neurona);
        }

        private void ShowInfo(Neurona N)
        {
            LbEntradas.Text = N.Entradas.ToString();
            LbPatrones.Text = N.Patrones.Count.ToString();
            LbSalidas.Text = N.Salidas.Count.ToString();
            NbErrorMax.Value = (decimal)N.ErrorMaxPermitido;
            NbIteracion.Value = N.Iteraciones;
            CbActivacion.SelectedIndex = (int)N.Activacion.Funcion;
            NbRata.Value = (decimal)N.Rata;
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

        private void Close(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Minimize(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CambiarActivacion(object sender, EventArgs e)
        {
            var Cb = sender as ComboBox;
            if(Cb.SelectedIndex == (int)FUNCION.Escalon)
            {
                PbEscalon.Visible = true;
                PbLineal.Visible = false;
                PbSigmoide.Visible = false;
            }
            else if (Cb.SelectedIndex == (int)FUNCION.Lineal)
            {
                PbEscalon.Visible = false;
                PbLineal.Visible = true;
                PbSigmoide.Visible = false;
            }
            else
            {
                PbEscalon.Visible = false;
                PbLineal.Visible = false;
                PbSigmoide.Visible = true;
            }
        }

        private void Entrenar(object sender, EventArgs e)
        {
            PbCarga.Visible = true;
            Neurona = _Neurona.Entrenar(Neurona);
            PbCarga.Visible = false;
        }
    }
}
