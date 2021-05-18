using System;

namespace ENTITY
{
    public class Salida
    {
        public double YD { get; set; }
        public double YR { get; set; }
        public double Activado { get; set; }


        public Salida()
        {

        }

        public Salida(string Value)
        {
            YD = Double.Parse(Value);
        }

        
    }

}
