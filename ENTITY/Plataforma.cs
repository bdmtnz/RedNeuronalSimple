using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public static class Plataforma
    {
        public static Red Red = new Red();
        public static bool Continuar = true;
        public static double Random()
        {
            var R = new Random();
            System.Threading.Thread.Sleep(1);
            var Negativo = Convert.ToBoolean(Math.Round(R.NextDouble()));
            System.Threading.Thread.Sleep(1);
            var Numero = R.NextDouble();
            return Negativo ? Numero * -1 : Numero;
        }
    }
}
