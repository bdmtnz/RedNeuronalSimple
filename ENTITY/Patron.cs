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
        public List<Salida> SalidasSupervisada { get; set; }

        public Patron()
        {
            Entradas = new List<double>();
            SalidasSupervisada = new List<Salida>();
        }

        public Patron(string Values)
        {
            Entradas = new List<double>();
            SalidasSupervisada = new List<Salida>();
            if (Values != "")
            {
                Entradas = new List<double>();
                Values = Values.Trim();
                var Split = Values.Split(';');
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
                Patron += $"{item};";
            }
            Patron = Patron.Substring(0, Patron.Length-1);
            Patron += ' ';
            return Patron;
        }

    }
}
