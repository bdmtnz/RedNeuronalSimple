using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Neurona
    {
        public int Entradas => Patrones.Count > 0 ? Patrones[0].Valores.Count : 0;
        public List<Patron> Patrones { get; set; }
        public List<Salida> Salidas { get; set; }
        public double Rata { get; set; }
        public int Iteraciones { get; set; }
        public int Entrenamientos { get; set; }
        public List<Pesos> Pesos { get; set; }
        public List<Pesos> PesosAnteriores { get; set; }
        public List<Umbrales> Umbrales { get; set; }
        public List<Umbrales> UmbralesAnteriores { get; set; }
        public Activacion Activacion { get; set; }
        public double Soma => GetSoma();
        public double Error { get; set; }
        public double ErrorMaxPermitido { get; set; }

        public Neurona()
        {
            Patrones = new List<Patron>();
            Pesos = new List<Pesos>();
            PesosAnteriores = new List<Pesos>();
            Umbrales = new List<Umbrales>();
            UmbralesAnteriores = new List<Umbrales>();
            Salidas = new List<Salida>();
            Activacion = new Activacion(FUNCION.Escalon);
        }

        private double GetSoma()
        {
            var Soma = 0.0;
            //RECORRE PATRONES
            foreach (var Patron in Patrones)
            {
                var Productos = 0.0;
                //RECORRE ENTRADAS DEL PATRON
                foreach (var Entrada in Patron.Valores)
                {
                    var Producto = 1.0;
                    foreach (var Peso in Pesos[0].Valores)
                    {
                        Producto *= Entrada * Peso.Valor;
                    }
                    Productos += Producto;
                }
                //RESTA DE UMBRALES
                foreach (var Umbral in Umbrales[0].Valores)
                {
                    Soma = Productos;
                    Soma -= Umbral.Valor;
                }
            }
            return Soma;
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
            if(Value != "")
            {
                Value = Value.Trim();
                var Split = Value.Split(';');
                Iteraciones = Int32.Parse(Split[0]);
                ErrorMaxPermitido = Double.Parse(Split[1]);
                switch (Split[2])
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
                Rata = Double.Parse(Split[3]);
                Entrenamientos = Int32.Parse(Split[4]);
            }
        }
    }
}
