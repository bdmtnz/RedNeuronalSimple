using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Peso
    {
        public double Valor { get; set; }
        public double Error { get; private set; }

        public Peso(double Valor)
        {
            this.Valor = Valor;
        }

        public void Entrenar(double Rata, double ErrorNeurona, double ErrorLinealPatron, double Entrada)
        {
            Valor = Valor + (2 * Rata * ErrorNeurona * ErrorLinealPatron * Entrada);
            //Valor = Valor > 1 ? Plataforma.Random() * 1 : Valor;
            //Valor = Valor < -1 ? Plataforma.Random() * 1 : Valor;
            //Valor = Valor > 1 ? 1 : Valor;
            //Valor = Valor < -1 ? -1 : Valor;
        }

        public double CalcularError(double ErrorNeurona, double ActivacionNeurona)
        {
            this.Error = ErrorNeurona * ActivacionNeurona;
            return this.Error;
        }

    }
    
    public class Pesos
    {
        public List<Peso> Valores { get; set; }

        public Pesos()
        {
            Valores = new List<Peso>();
        }

        public Pesos(List<Peso> Valores)
        {
            this.Valores = new List<Peso>();
            Valores.ForEach( x => {
                this.Valores.Add(x);
            });
        }

        public Pesos(string Values)
        {
            if(Values != "")
            {
                Valores = new List<Peso>();
                Values = Values.Trim();
                var Split = Values.Split(';');
                foreach (var item in Split)
                {
                    Valores.Add(new Peso(Double.Parse(item)));
                }
            }
        }
    }
}
