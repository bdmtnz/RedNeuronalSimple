using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Capa
    {
        public List<Neurona> Neuronas { get; set; }
        public List<Pesos> Pesos { get; set; }
        public List<Pesos> PesosTemp { get; set; }
        public Activacion Activacion { get; set; }

        public Capa()
        {
            Normalizar();
        }

        private void Normalizar()
        {
            Pesos = new List<Pesos>();
            PesosTemp = new List<Pesos>();
            Neuronas = new List<Neurona>();
            Activacion = new Activacion(FUNCIONES.Sigmoide);
        }

        public void Entrenar(Patron Patron, double Rata, double Xo)
        {
            for (int i = 0; i < Neuronas.Count; i++)
            {
                Neuronas[i].CalcularSoma(Pesos[i], Patron);
                Neuronas[i].Salida.YR = Activacion.Activar(Neuronas[i].Soma);

                EntrenarPesos(i, Patron, Rata);

                //OJO CON EL ERROR DEL PATRON
                Neuronas[i].UmbralTemp = Neuronas[i].Umbral;
                Neuronas[i].Umbral.Entrenar(Neuronas[i].UmbralTemp.Valor, Rata, Patron.Error, Xo);
            }
        }

        private void EntrenarPesos(int Fila, Patron Patron, double Rata)
        {
            for (int j = 0; j < Pesos[Fila].Valores.Count; j++)
            {
                PesosTemp[Fila].Valores.Clear();
                foreach (var item in Pesos[Fila].Valores)
                {
                    PesosTemp[Fila].Valores.Add(new Peso(item.Valor));
                }

                //OJO CON EL ERROR DEL PATRON
                Pesos[Fila].Valores[j].Entrenar(
                    PesosTemp[Fila].Valores[j].Valor, 
                    Rata, 
                    Patron.Error, 
                    Patron.Entradas[j]
                );
            }
        }

        public double Generalizar(Patron Patron)
        {
            /*var Soma = Neurona.CalcularSoma(Pesos, Umbral, Patron);
            var YR = Activacion.Activar(Soma);
            return YR;*/
            return 0.0;
        }

    }
}
