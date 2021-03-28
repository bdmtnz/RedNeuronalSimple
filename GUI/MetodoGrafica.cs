using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;


namespace GUI
{

    public class MetodoGrafica
    {
        

        public delegate void work(Red Red);
        public event work working;

        public void Trabajando()
        {
            foreach(var item in Telefono.Red.Salidas )
            {
                working(Telefono.Red);               
            }
        }

    }
}
