using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Patron
    {
        public List<double> Valores { get; set; }
        public double Error { get; set; }

        public Patron()
        {
            Valores = new List<double>();
        }

        public Patron(string Values)
        {
            if(Values != "")
            {
                Valores = new List<double>();
                Values = Values.Trim();
                var Split = Values.Split(';');
                foreach (var item in Split)
                {
                    Valores.Add(Double.Parse(item));
                }
            }
        }

        public void SetError(List<Salida> Salidas)
        {
            this.Error = 0;
            foreach (var item in Salidas)
            {
                this.Error += item.Error;
            }
            this.Error = this.Error / Salidas.Count;
        }
    }
}
