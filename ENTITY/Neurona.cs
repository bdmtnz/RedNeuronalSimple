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
        public double Error { get; set; }

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

        public void EntrenarPesos(List<double> Entradas, double Rata, double ErrorNeurona)
        {
            for (int j = 0; j < Pesos.Valores.Count; j++)
            {
                Pesos.Valores[j].CalcularError(ErrorNeurona, Entradas[j]);
                Pesos.Valores[j].Entrenar(
                    Pesos.Valores[j].Valor,
                    Rata,
                    Entradas[j]
                );
            }
        }

        public double ErrorOculto(List<double> Pesos, List<double> Errores, double DerivadaActivacion)
        {
            var Error = 0.0;
            for (int i = 0; i < Pesos.Count; i++)
            {
                Error += Pesos[i] * Errores[i];
            }
            this.Error = Error * DerivadaActivacion;
            Umbral.Valor = this.Error;
            return this.Error;
        }

        public double ErrorSalida(double DerivadaActivacion)
        {
            Error = (Salida.Activado - Salida.YD) * DerivadaActivacion;
            Umbral.Valor = this.Error;
            return Error;
        }

    }

}
