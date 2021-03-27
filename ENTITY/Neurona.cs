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
            foreach (var Entrada in Patron.Entradas)
            {
                var Producto = 1.0;
                foreach (var Peso in Pesos.Valores)
                {
                    Producto *= Entrada * Peso.Valor;
                }
                Productos += Producto;
            }
            //RESTA DE UMBRALES
            Soma = Productos;
            Soma -= Umbral.Valor;
            return Soma;
        }

       
    }
}
