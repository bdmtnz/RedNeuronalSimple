using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Neurona
    {
        public Salida Salida { get; set; }
        public double Soma { get; set; }
        public Umbral Umbral { get; set; }
        public Umbral UmbralTemp { get; set; }

        public Neurona()
        {
            Salida = new Salida();
            Umbral = UmbralTemp = new Umbral();
        }

        public void CalcularSoma(Pesos Pesos, Patron Patron)
        {
            var Productos = 0.0;
            for (int i = 0; i < Patron.Entradas.Count; i++)
                Productos += Patron.Entradas[i] * Pesos.Valores[i].Valor;
            Soma = Productos - Umbral.Valor;
        }       
    }

}
