using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Login : Form
    {
        public int X_Click { get; set; }
        public int Y_Click { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                var window = new Dashboard(this);
                window.Show();
                textBox1.Text = "";
                textBox2.Text = "";
                Hide();
            }
            else if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                var window = new Dashboard(this);
                window.Show();
                textBox1.Text = "";
                textBox2.Text = "";
                Hide();
            }
            else if (textBox1.Text == "normal" && textBox2.Text == "normal")
            {
                var window = new Generalizador(this);
                window.Show();
                textBox1.Text = "";
                textBox2.Text = "";
                Hide();
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Usuario y/o contraseña incorrecta");
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
