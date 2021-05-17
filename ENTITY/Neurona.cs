using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Neurona
    {
        public Salida Salida { get; set; }
        public Pesos Pesos { get; set; }
        public Umbral Umbral { get; set; }
        public int Indice { get; set; }

        public Neurona()
        {
            Pesos = new Pesos();
            Salida = new Salida();
            Umbral = new Umbral();
        }

        public Neurona(int Indice)
        {
            Pesos = new Pesos();
            Salida = new Salida();
            Umbral = new Umbral();
            this.Indice = Indice;
        }

        private double CalcularSoma(List<double> Entradas)
        {
            var Productos = 0.0;
            for (int i = 0; i < Entradas.Count; i++) {
                Productos += Entradas[i] * Pesos.Valores[i].Valor;
            }
                
            return Productos - Umbral.Valor;
        }

        public void Activar(Activacion Activacion, List<double> Entradas)
        {            
            Salida.YR = Activacion.Activar(CalcularSoma(Entradas));
        }

        public void EntrenarPesos(List<double> Entradas, double Rata, double ErrorPatron)
        {
            for (int j = 0; j < Pesos.Valores.Count; j++)
            {
                Pesos.Valores[j].Entrenar(
                    Pesos.Valores[j].Valor,
                    Rata,
                    ErrorPatron,
                    Entradas[j]
                );
            }
        }

        public void CalcularError(List<double> Pesos, List<double> Errores)
        {
            var Error = 0.0;
            for (int i = 0; i < Pesos.Count; i++)
            {
                Error += Pesos[i] * Errores[i];
            }
            Salida.Error = Error;
        }

    }

}
