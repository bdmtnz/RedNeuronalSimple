using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Salida
    {
        public double Esperada { get; set; }
        public double Obtenida { get; set; }
        public double Error => Esperada - Obtenida;

        public Salida()
        {
                
        }

        public Salida(string Value)
        {
            Esperada = Double.Parse(Value);
        }
    }
}
