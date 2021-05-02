using System.Collections.Generic;
using System.Linq;

namespace ENTITY
{
    public class Capa
    {
        public List<Neurona> Neuronas { get; set; }
        public Activacion Activacion { get; set; }
        public int Indice { get; set; }
        public double ErrorPatron => GetErrorPatron();

        public Capa(int Indice)
        {
            this.Indice = Indice;
            Normalizar();
        }

        private void Normalizar()
        {
            Neuronas = new List<Neurona>();
            Activacion = new Activacion(FUNCIONES.Sigmoide);
        }

        private double GetErrorPatron()
        {
            var Error = 0.0;
            Neuronas.ForEach(x =>
            {
                Error += x.Salida.Error;
            });
            return Error / Neuronas.Count;
        }

    }
}
