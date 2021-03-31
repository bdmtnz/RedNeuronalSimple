﻿using System;
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
        }

        private void ValidarEntrenamiento(Red Red)
        {
            if (Red.Error>Red.ErrorMaxPermitido)
            {
                MessageBox.Show("La red aún no esta entrenada, por favor entrenela");
                Dispose();
            }
            else
                ShowDialog();
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
                    i++;
                }
                var _Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
                _Columna.HeaderText = "YR";
                _Columna.Name = _Columna.HeaderText;
                dataGridView1.Columns.Add(_Columna);
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
            var Result = OFD.ShowDialog();
            if (Result == DialogResult.OK)
            {
                try
                {
                    if (File.Exists(OFD.FileName))
                    {
                        var Ps = _Neurona.LoadPatrones(OFD.FileName);
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
                            foreach (var item in Ps)
                            {
                                Row.Clear();
                                foreach (var it2 in item.Entradas)
                                {
                                    Row.Add(it2.ToString());
                                }
                                var Yr = Red.Simular(item);
                                Row.Add(Yr.ToString());
                                dataGridView1.Rows.Add(Row.ToArray());
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
            Telefono.Red = Red;
            LbError.Text = "" + Telefono.Red.Error;
            LbIteraciones.Text = "" + Telefono.Red.Entrenamientos;
            LbPesos.Text = "" + Telefono.W;
            LbUmbral.Text = "" + Telefono.Red.Umbral.Valor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
