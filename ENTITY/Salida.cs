using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Salida
    {
        public double YD { get; set; }
        public double YR { get; set; }
        public double Error => YD - YR;

        public Salida()
        {

        }

        public Salida(string Value)
        {
            YD = Double.Parse(Value);
        }

        public void SetError(double Error)
        {
            YD = (Error + YR);
        }

    }

}
