using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public enum FUNCION
    {
        Escalon,
        Lineal,
        Sigmoide
    }

    public class Activacion
    {
        public FUNCION Funcion { get; set; }

        public Activacion(FUNCION Funcion)
        {
            this.Funcion = Funcion;
        }

        public double Activar(double SalidaSoma)
        {
            if (Funcion == FUNCION.Escalon)
                return SalidaSoma >= 0 ? 1 : 0;
            else if (Funcion == FUNCION.Lineal)
                return SalidaSoma;
            else 
                return 1 / 1 + Math.Pow(Math.E, -1 * SalidaSoma);
        }

    }
}
