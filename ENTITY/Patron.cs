using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Patron
    {
        public List<double> Entradas { get; set; }
        public double Error { get; set; }

        public Patron()
        {
            Entradas = new List<double>();
        }

        public Patron(string Values)
        {
            if(Values != "")
            {
                Entradas = new List<double>();
                Values = Values.Trim();
                var Split = Values.Split(' ');
                foreach (var item in Split)
                {
                    Entradas.Add(Double.Parse(item));
                }
            }
        }

        public string GetPatron()
        {
            var Patron = "";
            foreach (var item in Entradas)
            {
                Patron += $"{item} ";
            }
            Patron = Patron.Trim();
            Patron += ';';
            return Patron;
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
