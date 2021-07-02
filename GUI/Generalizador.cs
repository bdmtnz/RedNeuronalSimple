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
    public partial class Generalizador : Form
    {
        private Red Red { get; set; }

        private readonly RedService _Neurona;

        private readonly Login Padre;


        public Generalizador(Login padre)
        {
            Padre = padre;
            _Neurona = new RedService();
            this.Red = _Neurona.GetXML(null);
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.Sizable;
            comboBox1.SelectedIndex = 0;
        }

        public Generalizador(Red Red, RedService Neurona)
        {
            _Neurona = Neurona;
            this.Red = Red;
            InitializeComponent();
            label3.Visible = false;
            comboBox1.SelectedIndex = 0;
        }

        private void CrearColumnas(List<Patron> Patrones)
        {
            var i = 1;
            dataGridView1.Columns.Clear();
            if (Patrones.Count > 0)
            {
                foreach (var item in Red.Patrones[0].Entradas)
                {
                    var Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    Columna.HeaderText = "E" + i;
                    Columna.Name = Columna.HeaderText;
                    dataGridView1.Columns.Add(Columna);
                    dataGridView1.Columns[i - 1].Width = 40;
                    i++;
                }
                for (int s = 0; s < Red.Capas[Red.Capas.Count - 1].Neuronas.Count; s++)
                {
                    var _Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    _Columna.HeaderText = "YR"+(s+1);
                    _Columna.Name = _Columna.HeaderText;
                    dataGridView1.Columns.Add(_Columna);
                }
            }
        }

        private bool ValidarDS(List<Patron> Patrones, Red Red)
        {
            if (Red.Patrones.Count <= 0 || Patrones.Count <= 0)
                return true;
            else if (Patrones[0].Entradas.Count == Red.Patrones[0].Entradas.Count)
                return false;
            else
                return true;
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            ShowInfo(Red); 
            LbRiesgo.Text = "Sin riesgo";
            LbRiesgo.ForeColor = Color.Green;
            var Result = OFD.ShowDialog();
            if (Result == DialogResult.OK)
            {
                try
                {
                    if (File.Exists(OFD.FileName))
                    {
                        var Ps = _Neurona.GetDS(OFD.FileName);
                        if (Ps != null)
                        {
                            if(ValidarDS(Ps, Red))
                            {
                                MessageBox.Show("El dataset no cuenta con las caracteristicas de la red entrenada");
                                return;
                            }
                            LbPath.Text = OFD.FileName;
                            LbPatrones.Text = "" + Ps.Count();
                            CrearColumnas(Ps);
                            var Row = new List<string>();
                            var Indice = 0;
                            var Atacado = 0;
                            foreach (var item in Ps)
                            {
                                Row.Clear();
                                foreach (var it2 in item.Entradas)
                                {
                                    Row.Add(it2.ToString());
                                }
                                var Yrs = Red.Generalizar(item);
                                var Rojo = false;
                                Yrs.ForEach(x =>
                                {
                                    if (Padre != null)
                                        Row.Add(Math.Abs(Math.Round((x + .1)*100,2)).ToString()+" %");
                                    else
                                        Row.Add((x + .1).ToString());

                                    if(comboBox1.SelectedIndex == 0)
                                        Rojo = (x + .1) > .7 ? true : Rojo;
                                    if (comboBox1.SelectedIndex == 1)
                                        Rojo = (x + .1) > .5 ? true : Rojo;
                                });
                                dataGridView1.Rows.Add(Row.ToArray());
                                if (Rojo)
                                {
                                    var CeldaRoja = new DataGridViewCellStyle();
                                    CeldaRoja.ForeColor = Color.Red;
                                    dataGridView1.Rows[Indice].DefaultCellStyle = CeldaRoja;
                                    ++Atacado;
                                }
                                ++Indice;
                            }
                            //Validamos el ataque
                            if(Atacado > (Ps.Count * .30))
                            {
                                LbRiesgo.Text = "Se encuentra bajo ataque";
                                LbRiesgo.ForeColor = Color.Red;
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

        private void ShowInfo(Red Red)
        {
            Plataforma.Red = Red;
            LbError.Text = "" + Plataforma.Red.Error;
            //LbIteraciones.Text = "" + Plataforma.Red.Entrenamientos;
            //LbPesos.Text = "" + Plataforma.Red.Capas.Count;
            //LbUmbral.Text = "" + Plataforma.Red.Capas.Count;
        }

        private void Generalizador_FormClosing(object sender, FormClosingEventArgs e)
        {
            Padre.Show();
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
                        var Rd = _Neurona.GetXML(OFD.FileName);
                        if (Rd != null)
                            Red = Plataforma.Red = Rd;
                        else
                            MessageBox.Show("El dataset está corrupto o está mal configurado");
                        ShowInfo(Red);
                        _Neurona.PostXML(Red, null);
                        MessageBox.Show("Se ha cargado la configuración de la red");
                        //Abrir(new Home(Red));
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
    }
}
