using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Red
    {
        private const double Xo = 1;
        public List<Patron> Patrones { get; set; }
        public Neurona Neurona { get; set; }
        public List<Salida> Salidas { get; set; }
        public Pesos Pesos { get; set; }
        public Umbral Umbral { get; set; }
        public int Entradas => Patrones.Count > 0 ? Patrones[0].Entradas.Count : 0;
        public double Rata { get; set; }
        public int Iteraciones { get; set; }
        public int Entrenamientos { get; set; }
        public Pesos PesosAnteriores { get; set; }
        public Umbral UmbralAnterior { get; set; }
        public Activacion Activacion { get; set; }
        public double Error { get; set; }
        public double ErrorMaxPermitido { get; set; }


        public Red()
        {
            Normalizar();
        }

        private void Normalizar()
        {
            Rata = 1;
            Error = 1;
            ErrorMaxPermitido = 0.1;
            Patrones = new List<Patron>();
            Pesos = new Pesos();
            PesosAnteriores = new Pesos();
            Umbral = new Umbral();
            UmbralAnterior = new Umbral();
            Salidas = new List<Salida>();
            Activacion = new Activacion(FUNCIONES.Escalon);
            Neurona = new Neurona();
        }

        public double Entrenar()
        {
            var ErrorIteracion = 0.0;
            var Soma = 0.0;
            for (int i = 0; i < Patrones.Count; i++)
            {
                var YR = 0.0;
                Soma = Neurona.CalcularSoma(Pesos, Umbral, Patrones[i]);
                YR = Activacion.Activar(Soma);
                Salidas[i].YR = YR;
                Patrones[i].Error = Salidas[i].Error;

                for (int j = 0; j < Pesos.Valores.Count; j++)
                {
                    PesosAnteriores.Valores.Clear();
                    foreach (var item in Pesos.Valores)
                    {
                        PesosAnteriores.Valores.Add(new Peso(item.Valor));
                    }
                    Pesos.Valores[j].Entrenar(PesosAnteriores.Valores[j].
                        Valor, Rata, Patrones[i].Error, Patrones[i].
                        Entradas[j]);
                }
               
                UmbralAnterior.Valor = Umbral.Valor;
                Umbral.Entrenar(UmbralAnterior.Valor, Rata, Patrones[i].Error, Xo);
                ErrorIteracion += Patrones[i].Error;
            }
            ErrorIteracion = ErrorIteracion / Patrones.Count;
            return ErrorIteracion;
        }

        public double Generalizar(Patron Patron)
        {
            var Soma = Neurona.CalcularSoma(Pesos, Umbral, Patron); 
            var YR = Activacion.Activar(Soma); 
            return YR;
        }
    }
    

}
