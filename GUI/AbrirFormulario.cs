using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class AbrirFormulario
    {
        Form Formulario;
        Panel panel;
        public AbrirFormulario(Panel Panel, Form formulario)
        {
            Formulario = formulario;
            panel = Panel;
        }
        public void Abrir()
        {
            this.panel.Controls.Clear();
            Form formulario = Formulario as Form;
            formulario.TopLevel = false;
            
            this.panel.Controls.Add(formulario);
            formulario.Dock = DockStyle.Fill;
            this.panel.Tag = formulario;
            formulario.Show();
        }
    }
}
