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
    public partial class Home : Form
    {
        public Home(Red Red)
        {
            InitializeComponent();
            ShowInfo(Red);
        }

        private void ShowInfo(Red Red)
        {
            LbPath.Text = "/DS.XML";
            LbPatrones.Text = Red.Patrones.Count.ToString();
            LbPesos.Text = Red.Capas.Count.ToString();
            LbError.Text = Red.Error.ToString();
            LbIteraciones.Text = Red.Iteraciones.ToString();
            LbEntrenamiento.Text = Red.Entrenamientos.ToString();
            LbErrorMax.Text = Red.ErrorMaxPermitido.ToString();
            LbUmbral.Text = Red.Capas.Count.ToString();
        }

    }
}
