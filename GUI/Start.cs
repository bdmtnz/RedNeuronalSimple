using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using ENTITY;
using BLL;

namespace GUI
{
    public partial class Start : Form
    {
        private NeuronaService _Neurona { get; set; }
        private Red Red { get; set; }
        public int X_Click { get; set; }
        public int Y_Click { get; set; }
        private FrmSimulador FrmSimulador { get; set; }
        private Grafica Grafica { get; set; }

        public Start()
        {
            _Neurona = new NeuronaService();
            //Grafica = new Grafica();
            Red = new Red();
            InitializeComponent();
            BtnPausa.Visible = false;
            BtnIniciar.Visible = true;
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
            OFD.Filter = "Archivo TXT (*.TXT)|*.TXT";
            SFD.Filter = "Archivo TXT (*.TXT)|*.TXT";
            var Rd = _Neurona.DataSet(null);
            if (Rd != null)
                Red = Telefono.Red = Rd;
            else
                MessageBox.Show("El dataset está corrupto o está mal configurado");
            ShowInfo(Red);
        }

        private void ShowInfo(Red N)
        {
            LbEntradas.Text = N.Entradas.ToString();
            LbPatrones.Text = N.Patrones.Count.ToString();
            LbSalidas.Text = ""+1;
            LbEntrenado.Text = N.Entrenamientos.ToString();
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
                Red.Activacion.Funcion = FUNCION.Escalon;
            }
            else if (Cb.SelectedIndex == (int)FUNCION.Lineal)
            {
                PbEscalon.Visible = false;
                PbLineal.Visible = true;
                PbSigmoide.Visible = false;
                Red.Activacion.Funcion = FUNCION.Lineal;
            }
            else
            {
                PbEscalon.Visible = false;
                PbLineal.Visible = false;
                PbSigmoide.Visible = true;
                Red.Activacion.Funcion = FUNCION.Sigmoide;
            }
            Telefono.Red = Red;
        }

        private void Entrenar(object sender, EventArgs e)
        {
            if(Red.Error <= Red.ErrorMaxPermitido)
            {
                MessageBox.Show("Esta red ya se encuentra entrenada, proceda a simular");
                return;
            }
            else if (Red.Patrones.Count <= 0)
            {
                MessageBox.Show("Esta red está vacia, llenela y entrenela");
                return;
            }
            else if(Red.Iteraciones <= 0)
            {
                MessageBox.Show("Por favor ingrese un número de iteraciones valido");
                return;
            }
            BtnIniciar.Visible = false;
            BtnPausa.Visible = true;
            RunTask();
            Grafica = new Grafica(Red);
            Grafica.Show();
        }

        private async void RunTask()
        {
            PbCarga.Visible = true;
            Telefono.Continuar = true;
            Telefono.Red = Red;
            var T = new Task(_Neurona.EntrenarPausable);
            T.Start();
            await T;
            Red = Telefono.Red;
            ShowInfo(Red);
            PbCarga.Visible = false;
            BtnPausa.Visible = false;
            BtnIniciar.Visible = true;
        }

        private void Simular(object sender, EventArgs e)
        {
            if(Red.Patrones.Count <= 0)
            {
                MessageBox.Show("Esta red está vacia, llenela y entrenela");
                return;
            }
            FrmSimulador = new FrmSimulador(Red);
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            var Result = OFD.ShowDialog();
            if (Result == DialogResult.OK)
            {
                try
                {
                    if (File.Exists(OFD.FileName))
                    {
                        var Rd =  _Neurona.DataSet(OFD.FileName);
                        if (Rd != null)
                            Red = Telefono.Red = Rd;
                        else
                            MessageBox.Show("El dataset está corrupto o está mal configurado");
                        ShowInfo(Red);
                    }
                    else
                        MessageBox.Show("Se ha eliminado o movido el archivo");
                }
                catch (Exception er)
                {
                    MessageBox.Show("Error al abrir el archivo => " + er.Message, "Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (Result == DialogResult.Cancel)
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SFD.FileName = $"DataSet.txt";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                _Neurona.DataSet(Red, SFD.FileName);
            }
        }

        private void BtnPausa_Click(object sender, EventArgs e)
        {
            BtnPausa.Visible = false;
            BtnIniciar.Visible = true;
            Red = Telefono.Red;
            Telefono.Continuar = false;
            ShowInfo(Red);
            
        }

        private void ItChange(object sender, EventArgs e)
        {
            Red.Iteraciones = (int)NbIteracion.Value;
            Telefono.Red = Red;
        }

        private void EmChange(object sender, EventArgs e)
        {
            Red.ErrorMaxPermitido = (double)NbErrorMax.Value;
            Telefono.Red = Red;
        }

        private void RaChange(object sender, EventArgs e)
        {
            Red.Rata = (double)NbRata.Value;
            Telefono.Red = Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Red = Telefono.Red = new Red();
            ShowInfo(Red);
        }
    }
}
