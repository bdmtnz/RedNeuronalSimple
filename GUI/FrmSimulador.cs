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
using System.IO;

namespace GUI
{
    public partial class FrmSimulador : Form
    {
        private readonly Red Red;

        private readonly NeuronaService _Neurona;

        public FrmSimulador(Red Red, NeuronaService Neurona)
        {
            _Neurona = Neurona;
            this.Red = Red;
            InitializeComponent();
            ValidarEntrenamiento(Red);
            Open1.Filter = "Archivo TXT (*.TXT)|*.TXT";
        }
        private void ValidarEntrenamiento(Red Red)
        {
            if (Red.Error > Red.ErrorMaxPermitido)
            {
                MessageBox.Show("La red aún no esta entrenada, por favor entrenela");
                Dispose();
            }
            else
                ShowDialog();
        }
        private void FrmSimulador_Load(object sender, EventArgs e)
        {

        }

        private void TbPatron_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            Patron Patron = new Patron();
            LbResultado.Text = Red.Simular(Patron).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Result = Open1.ShowDialog();
            if (Result == DialogResult.OK)
            {
                try
                {
                    if (File.Exists(Open1.FileName))
                    {
                        var Ps = _Neurona.DataSimulacion(Open1.FileName);
                        if (Ps != null)
                        {
                            CrearColumnas(Ps);
                            var Row = new List<string>();
                            foreach (var item in Ps)
                            {
                                Row.Clear();
                                foreach (var it2 in item.Entradas)
                                {
                                    Row.Add(it2.ToString());
                                }
                                var Yr = Red.Simular(item);
                                Row.Add(Yr.ToString());
                                DGV1.Rows.Add(Row.ToArray());
                            }
                        }
                        else
                            MessageBox.Show("El dataset está corrupto o está mal configurado");
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

        private void CrearColumnas(List<Patron> Patrones)
        {
            var i = 1;
            DGV1.Columns.Clear();
            if (Patrones.Count > 0)
            {
                foreach (var item in Red.Patrones[0].Entradas)
                {
                    var Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    Columna.HeaderText = "E" + i;
                    Columna.Name = Columna.HeaderText;
                    DGV1.Columns.Add(Columna);
                    i++;
                }
                var _Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
                _Columna.HeaderText = "YR";
                _Columna.Name = _Columna.HeaderText;
                DGV1.Columns.Add(_Columna);
            }
        }

    }
}
