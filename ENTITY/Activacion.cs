using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public enum FUNCIONES
    {
        Lineal,
        Sigmoide,
        TangenteHip,
        Gaussiana
    }

    public class Activacion
    {
        public FUNCIONES Funcion { get; set; }

        public Activacion(FUNCIONES Funcion)
        {
            this.Funcion = Funcion;
        }

        public double Activar(double SalidaSoma)
        {
            if (Funcion == FUNCIONES.Lineal)
            {
                return SalidaSoma;
                //return SalidaSoma < 0 ? 0 : SalidaSoma;
            }
            else if (Funcion == FUNCIONES.Sigmoide)
                return 1 / (1 + Math.Pow(Math.E, -1 * SalidaSoma));
            else if (Funcion == FUNCIONES.TangenteHip)
            {
                return 1 / (1 + Math.Pow(Math.E, -1 * SalidaSoma));
                //return Math.Tanh(SalidaSoma);
                var Numerador = Math.Pow(Math.E, SalidaSoma) - Math.Pow(Math.E, -1 * SalidaSoma);
                var Denominador = Math.Pow(Math.E, SalidaSoma) + Math.Pow(Math.E, -1 * SalidaSoma);
                return Numerador / Denominador;
            }
            else if (Funcion == FUNCIONES.Gaussiana)
            {
                return 1 / (1 + Math.Pow(Math.E, -1 * SalidaSoma));
                //return Math.Tanh(SalidaSoma);
                var Numerador = Math.Pow(Math.E, SalidaSoma) - Math.Pow(Math.E, -1 * SalidaSoma);
                var Denominador = Math.Pow(Math.E, SalidaSoma) + Math.Pow(Math.E, -1 * SalidaSoma);
                return Numerador / Denominador;
            }
            else
                return 1 / (1 + Math.Pow(Math.E, -1 * SalidaSoma));
        }
    }
}
