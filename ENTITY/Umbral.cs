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

        public Umbral()
        {

        }

        public Umbral(double Valor)
        {
            this.Valor = Valor;
        }

        public void Entrenar(double AnteriorValor, double Rata, double ErrorSalida, double Entrada)
        {
            Valor = AnteriorValor + Rata * ErrorSalida * Entrada;
        }
    }

    public class Umbrales
    {
        public List<Umbral> Valores { get; set; }

        public Umbrales()
        {
            Valores = new List<Umbral>();
        }

        public Umbrales(string Values)
        {
            if(Values != "")
            {
                Valores = new List<Umbral>();
                Values = Values.Trim();
                var Split = Values.Split(';');
                foreach (var item in Split)
                {
                    Valores.Add(new Umbral(Double.Parse(item)));
                }
            }
        }
    }
}
