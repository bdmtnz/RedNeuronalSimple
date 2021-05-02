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
        public Pesos PesosTemp { get; set; }
        public Umbral Umbral { get; set; }
        public Umbral UmbralTemp { get; set; }

        public Neurona()
        {
            Pesos = new Pesos();
            PesosTemp = new Pesos();
            Salida = new Salida();
            Umbral = new Umbral();
            UmbralTemp = new Umbral();
        }

        //public void CalcularSoma(Pesos Pesos, Patron Patron)
        private double CalcularSoma(List<double> Entradas)
        {
            var Productos = 0.0;
            for (int i = 0; i < Entradas.Count; i++)
                Productos += Entradas[i] * PesosTemp.Valores[i].Valor;
            return Productos - Umbral.Valor;
        }

        public void Activar(Activacion Activacion, List<double> Entradas)
        {            
            Salida.YR = CalcularSoma(Entradas);
        }

        //private void EntrenarPesos(int Fila, Patron Patron, double Rata)
        //public void Entrenar(double AnteriorValor, double Rata, double ErrorSalida, double Entrada)
        public void EntrenarPesos(List<double> Entradas, double Rata, double ErrorIteracion)
        {
            for (int j = 0; j < PesosTemp.Valores.Count; j++)
            {
                PesosTemp.Valores[j].Entrenar(
                    PesosTemp.Valores[j].Valor,
                    Rata,
                    ErrorIteracion,
                    Entradas[j]
                );
            }
        }

        public void AceptarPesos()
        {
            //SOBREESCRIBIR PESOS TEMP EN PESOS
            Pesos.Valores = PesosTemp.Valores.Select(i => new Peso(i.Valor)).ToList();
            PesosTemp.Valores.Clear();
        }

    }

}
