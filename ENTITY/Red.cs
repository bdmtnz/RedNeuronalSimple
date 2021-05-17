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
        public int PatronIndex { get; set; }

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
            ErrorMaxPermitido = 0.01;
            Patrones = new List<Patron>();
        }

        private void CargarYD(Patron patron)
        {
            for (int i = 0; i < patron.SalidasSupervisada.Count; i++)
            {
                Capas[Capas.Count - 1].Neuronas[i].Salida.YD = patron.SalidasSupervisada[i].YD;
            }
        }

        public double Entrenar()
        {            
            var ErrorIteracion = 0.0;
           
            //SE ITERA POR PATRÓN
            for (int i = 0; i < Patrones.Count; i++)
            {
                CargarYD(Patrones[i]);
                PatronIndex = i;
                var ErrorPatron = 0.0;
                //SE ITERA POR CAPAS
                for (int c = 0; c < Capas.Count; c++)
                {
                    //SE ITERA POR NEURONAS
                    for (int n = 0; n < Capas[c].Neuronas.Count; n++)
                    {
                        //SE ENTRENAN LA NEURONAS
                        if (c == 0)
                        {
                            //SE ENTRENA CON LAS ENTRADAS DE CADA PATRON
                            Capas[c].Neuronas[n].Activar(
                                Capas[c].Activacion,
                                Patrones[i].Entradas
                            );
                            //Capas[j].Entrenar(Patrones[i], Rata, Xo);
                        }
                        else 
                        {
                            //SE ENTRENA CON LAS SALIDAS DE LA ANTERIOR CAPA
                            Capas[c].Neuronas[n].Activar( 
                                Capas[c].Activacion,
                                Capas[c - 1].Neuronas.Select( x => x.Salida.YR).ToList()
                            );
                        }
                        
                    }
                    
                }
                
                //CALCULAR EL ERROR EN LA SALIDA CON PARCIALES

                
                //BACK PROPAGATION
                RecurrenteCapa(Capas[Capas.Count - 1], this, ErrorPatron);
               
            }
            ErrorIteracion = ErrorIteracion / Patrones.Count;
            Console.WriteLine(ErrorIteracion);
            Console.WriteLine("_______________");
            return ErrorIteracion;
        }        
        
        private void RecurrenteCapa(Capa Capa, Red Red,double ErrorPatron)
        {
            //CRITERIO DE PARO
            if (Capa.Indice > 0)
                RecurrenteCapa(Capas[Capa.Indice - 1], Red, ErrorPatron);
            //APLICAR LAS PARCIALES

        }       
        
        
        public List<double> Generalizar(Patron Patron)
        {
            //SE ITERA POR PATRÓN
            for (int i = 0; i < Patrones.Count; i++)
            {
                PatronIndex = i;
                //SE ITERA POR CAPAS
                for (int c = 0; c < Capas.Count; c++)
                {
                    //SE ITERA POR NEURONAS
                    for (int n = 0; n < Capas[c].Neuronas.Count; n++)
                    {
                        //SE ENTRENAN LA NEURONAS
                        if (c == 0)
                        {
                            //SE ENTRENA CON LAS ENTRADAS DE CADA PATRON
                            Capas[c].Neuronas[n].Activar(
                                Capas[c].Activacion,
                                Patrones[i].Entradas
                            );
                        }
                        else
                        {
                            //SE ENTRENA CON LAS SALIDAS DE LA ANTERIOR CAPA
                            Capas[c].Neuronas[n].Activar(
                                Capas[c].Activacion,
                                Capas[c - 1].Neuronas.Select(x => x.Salida.YR).ToList()
                            );
                        }
                    }
                }                
            }
            return Capas[Capas.Count - 1].Neuronas.Select(n => n.Salida.YR).ToList();
        }

        public void ReiniciarRed()
        {
            Entrenamientos = 0;
            Error = 10;
            //GENERAR ALEATORIAMENTE LOS PESOS Y UMBRALES DE CADA NEURONA DE CADA CAPA
            //RESPETANDO LOS LIMITES EN CADA CASO
            for (int i = 0; i < Capas.Count; i++)
            {
                //SE RECORRE LAS NEURONAS DE CADA CAPA
                for (int j = 0; j < Capas[i].Neuronas.Count; j++)
                {
                    //GENERAMOS ALEATORIAMENTE LOS PESOS
                    Capas[i].Neuronas[j].Pesos.Valores = Capas[i].Neuronas[j].Pesos.Valores.Select(x => new Peso(Plataforma.Random())).ToList();
                    //GENERAMOS ALEATORIAMENTE LOS UMBRALES
                    Capas[i].Neuronas[j].Umbral.Valor = Plataforma.Random();
                }
            }
        }

        public void ReiniciarCapas(List<int> Neuronas, List<Activacion> Funciones)
        {
            Capas.Clear();
            for (int i = 0; i < Neuronas.Count; i++)
            {
                Capas.Add(new Capa(i));
                Capas[i].Activacion = Funciones[i];
                for (int j = 0; j < Neuronas[i]; j++)
                {
                    Capas[i].Neuronas.Add(new Neurona(j));
                    if (i == 0)
                    {
                        for (int p = 0; p < Patrones[0].Entradas.Count; p++)
                        {
                            Capas[i].Neuronas[j].Pesos.Valores.Add(new Peso(Plataforma.Random()));
                        }
                    }
                    else
                    {
                        for (int p = 0; p < Capas[i - 1].Neuronas.Count; p++)
                        {
                            Capas[i].Neuronas[j].Pesos.Valores.Add(new Peso(Plataforma.Random()));
                        }
                    }
                }
            }
            ReiniciarRed();
        }


    }
    
    
}
