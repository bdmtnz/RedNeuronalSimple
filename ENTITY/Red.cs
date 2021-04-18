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
        public List<Capa> Capas { get; set; }
        public int Entradas => Patrones.Count > 0 ? Patrones[0].Entradas.Count : 0;
        public double Rata { get; set; }
        public int Iteraciones { get; set; }
        public int Entrenamientos { get; set; }
        public double Error { get; set; }
        public double ErrorMaxPermitido { get; set; }

        public Red()
        {
            Capas = new List<Capa>();
            Patrones = new List<Patron>();
            Normalizar();
        }

        private void Normalizar()
        {
            Rata = 1;
            Error = 1;
            ErrorMaxPermitido = 0.1;
            Patrones = new List<Patron>();
        }

        public double Entrenar()
        {
            //SE ITERA POR CAPAS
            CargarYDs();
            var ErrorIteracion = 0.0;
            for (int i = 0; i < Patrones.Count; i++)
            {
                var j = 0;
                for (j = 0; j < Capas.Count ; j++)
                {
                    Capas[j].Entrenar(Patrones[i], Rata, Xo);
                }
                foreach (var item in Capas[j-1].Neuronas)
                {
                    ErrorIteracion += item.Salida.Error;
                }
            }
            ErrorIteracion = ErrorIteracion / Patrones.Count;
            return ErrorIteracion;
        }

        private void CargarYDs()
        {
            for (int i = 0; i < Capas[Capas.Count-1].Neuronas.Count; i++)
            {
                //Capas[Capas.Count - 1].Neuronas[i].Salida.YD = Patrones[i].SalidaEspe.YD;
            }
        }

        public double Generalizar(Patron Patron)
        {
            //SE ITERA POR CAPAS
            var YR = 0.0; 
            return YR;
        }
    }
    

}
