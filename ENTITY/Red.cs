using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Red
    {
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

        private const double Xo = 1;
        public Red()
        {
            Patrones = new List<Patron>();
            Pesos = new Pesos();
            PesosAnteriores = new Pesos();
            Umbral = new Umbral();
            UmbralAnterior = new Umbral();
            Salidas = new List<Salida>();
            Activacion = new Activacion(FUNCION.Escalon);
            Neurona = new Neurona();
        }
        public void SetError(List<Patron> Patrones)
        {
            Error = 0;
            foreach (var item in Patrones)
            {
                Error += item.Error;
            }
            Error = Error / Patrones.Count;
        }

        public void SetConfig(string Value)
        {
            if (Value != "")
            {
                Value = Value.Trim();
                var Split = Value.Split(';');
                Iteraciones = Int32.Parse(Split[0]);
                Error = Double.Parse(Split[1]);
                ErrorMaxPermitido = Double.Parse(Split[2]);
                switch (Split[3])
                {
                    case "0":
                        Activacion.Funcion = FUNCION.Escalon;
                        break;
                    case "1":
                        Activacion.Funcion = FUNCION.Lineal;
                        break;
                    case "2":
                        Activacion.Funcion = FUNCION.Sigmoide;
                        break;
                    default:
                        Activacion.Funcion = FUNCION.Escalon;
                        break;
                }
                Rata = Double.Parse(Split[4]);
                Entrenamientos = Int32.Parse(Split[5]);
            }
        }

        public string GetConfig()
        {
            return $" {Iteraciones};{Error};{ErrorMaxPermitido};{(int)Activacion.Funcion};{Rata};{Entrenamientos} ";
        }

        public double Entrenar()
        {
            var ErrorIteracion = 0.0;
            var Soma = 0.0;
            for (int i = 0; i < Patrones.Count; i++)
            {
                var YR = 0.0;
                Soma = Neurona.GetSoma(Pesos, Umbral, Patrones[i]);
                YR = Activacion.Activar(Soma);
                Salidas[i].Obtenida = YR;
                Patrones[i].Error = Salidas[i].Error;
                //MODIFICACION DE PESOS Y UMBRALES
                for (int j = 0; j < Pesos.Valores.Count; j++)
                {
                    //SE GUARDAN LOS ANTERIORES PESOS
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
                //CALCULA ERROR DE LA ITERACION
                ErrorIteracion += Patrones[i].Error;
            }
            ErrorIteracion = ErrorIteracion / Patrones.Count;
            //GRAFICAR EIT Vs ITERACIÓN
            //GRAFICAR YD VS YR
            return ErrorIteracion;
        }

        public double EntrenarFragmentada(int i)
        {
            var YR = 0.0;
            var Soma = Neurona.GetSoma(Pesos, Umbral, Patrones[i]);
            YR = Activacion.Activar(Soma);
            Salidas[i].Obtenida = YR;
            Patrones[i].Error = Salidas[i].Error;
            //MODIFICACION DE PESOS Y UMBRALES
            for (int j = 0; j < Pesos.Valores.Count; j++)
            {
                //SE GUARDAN LOS ANTERIORES PESOS
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
            //CALCULA ERROR DE LA ITERACION
            return Patrones[i].Error;
        }

        public double Simular(Patron Patron)
        {

            var Soma = Neurona.GetSoma(Pesos, Umbral, Patron); 
            var YR = Activacion.Activar(Soma); 
            //GRAFICAR EIT Vs ITERACIÓN
            //GRAFICAR YD VS YR
            return YR;
        }
    }
    

}
