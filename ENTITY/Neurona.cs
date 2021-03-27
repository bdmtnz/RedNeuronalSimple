using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Neurona
    {
        
        
        

        public Neurona()
        {
            
        }

        public double GetSoma(Pesos Pesos, Umbral Umbral, Patron Patron)
        {
            var Soma = 0.0;
          
            var Productos = 0.0;
            //RECORRE ENTRADAS DEL PATRON
            for (int i = 0; i < Patron.Entradas.Count; i++)
            {
                Productos += Patron.Entradas[i] * Pesos.Valores[i].Valor;

            }

            Soma = Productos - Umbral.Valor;
            return Soma;
        }

       
    }
}
