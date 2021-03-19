using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ENTITY;
using DAL;

namespace BLL
{
    public class NeuronaService
    {
        private NeuronaRepository _Neurona { get; set; }

        public NeuronaService()
        {
            _Neurona = new NeuronaRepository();
        }

        public Neurona ReadXml()
        {
            return _Neurona.ReadXml();
        }

        public Neurona Entrenar(Neurona N)
        {
            var i = 0;
            while(i < N.Iteraciones)
            {
                foreach (var Patrones in N.Patrones)
                {
                    foreach (var Patron in Patrones.Valores)
                    {
                        //ENTRENAR PESOS
                        N.PesosAnteriores = N.Pesos;
                        var q = 0; 
                        foreach (var Pesos in N.Pesos)
                        {
                            var j = 0;
                            foreach (var Peso in Pesos.Valores)
                            {
                                Peso.Entrenar(N.PesosAnteriores[q].Valores[j].Valor, N.Rata, N.Salidas[0].Error, Patron);
                                ++j;
                            }
                            ++q;
                        }

                        //ENTRENAR UMBRALES
                        N.UmbralesAnteriores = N.Umbrales;
                        q = 0;
                        foreach (var Umbrales in N.Umbrales)
                        {
                            var j = 0;
                            foreach (var Umbral in Umbrales.Valores)
                            {
                                Umbral.Entrenar(N.UmbralesAnteriores[q].Valores[j].Valor, N.Rata, N.Salidas[0].Error, Patron);
                                ++j;
                            }
                            ++q;
                        }
                    }

                    //FUNCION SOMA, ACTIVACION Y SALIDA
                    var Salida = N.Activacion.Activar(N.Soma);
                    N.Salidas[0].Obtenida = Salida;

                    //ERROR DEL PATRON
                    var ErroresSalida = 0.0;
                    foreach (var item in N.Salidas)
                    {
                        ErroresSalida += item.Error;
                    }
                    Patrones.Error = ErroresSalida / N.Salidas.Count;
                }

                //ERROR DE LA ITERACION
                var ErroresPatrones = 0.0;
                foreach (var item in N.Patrones)
                {
                    ErroresPatrones += item.Error;
                }
                N.Error = ErroresPatrones / N.Patrones.Count;

                ++i;
                N.Entrenamientos = i;

                //CONDICIONES DE PARO
                if (N.Error <= N.ErrorMaxPermitido)
                    break;
            }
            return N;
        }

    }
}
