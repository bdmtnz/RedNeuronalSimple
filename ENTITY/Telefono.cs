using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public static class Telefono
    {
        public static string W => Ws();
        public static Red Red = new Red();
        public static bool Continuar = true;
        public static double ErrorIteracion = 0;
        public static double Error = 0;
        public static double YR = 0;
        public static double YD = 0;
        public static List<string> Datos = new List<string>();

        private static string Ws()
        {
            var W = "";
            foreach (var item in Red.Pesos.Valores)
            {
                W += item.Valor + ";";
            }
            return W;
        }
    }
}
