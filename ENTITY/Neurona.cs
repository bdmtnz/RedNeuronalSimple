using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Neurona
    {
        
        
        

        public Neurona()
        {
            
        }

        public double CalcularSoma(Pesos Pesos, Umbral Umbral, Patron Patron)
        {
            var Productos = 0.0;
            for (int i = 0; i < Patron.Entradas.Count; i++)
                Productos += Patron.Entradas[i] * Pesos.Valores[i].Valor;
            var Soma = Productos - Umbral.Valor;
            return Soma;
        }       
    }

    public enum FUNCIONES
    {
        Escalon,
        Lineal,
        Sigmoide
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
            if (Funcion == FUNCIONES.Escalon)
                return SalidaSoma >= 0 ? 1 : 0;
            else if (Funcion == FUNCIONES.Lineal)
                return SalidaSoma;
            else
                return 1 / 1 + Math.Pow(Math.E, -1 * SalidaSoma);
        }

    }

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

    }

}
