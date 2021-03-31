using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public static class Plataforma
    {
        public static string W => ToString();
        public static Red Red = new Red();
        public static bool Continuar = true;

        private new static string ToString()
        {
            var Peso = "";
            foreach (var item in Red.Pesos.Valores)
            {
                Peso += item.Valor + ";";
            }
            return Peso.Substring(0, Peso.Length - 1);
        }
    }
}
