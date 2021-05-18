using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Umbral
    {
        public double Valor { get; set; }
        public double Error { get; set; }

        public Umbral()
        {

        }

        public Umbral(double Valor)
        {
            this.Valor = Valor;
        }

        public void Entrenar(double AnteriorValor, double Rata, double Entrada)
        {
            Valor = AnteriorValor + (Rata * Error * Entrada);
            //Valor = Valor > 1 ? Plataforma.Random() : Valor;
            //Valor = Valor < -1 ? Plataforma.Random() : Valor;
            Valor = Valor < -3 ? -3 : Valor;
            Valor = Valor > 3 ? 3 : Valor;
        }

    }

    
}
