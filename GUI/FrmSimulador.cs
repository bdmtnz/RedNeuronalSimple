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

namespace GUI
{
    public partial class FrmSimulador : Form
    {
        private readonly Red Red;

        public FrmSimulador(Red Red)
        {
            this.Red = Red;
            InitializeComponent();
            ValidarEntrenamiento(Red);
        }
        private void ValidarEntrenamiento(Red Red)
        {
            if (Red.Error>Red.ErrorMaxPermitido)
            {
                MessageBox.Show("La red aún no esta entrenada, por favor entrenela");
                Dispose();
            }
        }
        private void FrmSimulador_Load(object sender, EventArgs e)
        {

        }

        private void TbPatron_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {

            var Entradas = TbPatron.Text.Trim().Replace('.',',').Split(';');
            if (Entradas.Length != Red.Patrones[0].Entradas.Count)
            {
                MessageBox.Show("El patron ingresado es diferente a los patrones de entrenamiento, verifiquelos");
                Dispose();
                return;
            }
            double o;
            Patron Patron = new Patron();
            foreach (var Entrada in Entradas)
            {
                string entrada = Entrada.Trim();
                if (!Double.TryParse(entrada, out o))
                {
                    MessageBox.Show("Las entradas deben ser numericas, verifiquelas");
                    Dispose();
                    return;
                }
                Patron.Entradas.Add(Double.Parse(entrada));
            }
            LbResultado.Text = Red.Simular(Patron).ToString();          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
