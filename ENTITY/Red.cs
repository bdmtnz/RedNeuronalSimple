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
            ErrorMaxPermitido = 0.1;
            Patrones = new List<Patron>();
        }

        public double Entrenar()
        {
            var ErrorIteracion = 0.0;
            var ErrorPatron = 0.0;
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
                
                //SE CALCULA LOS ERRORES NO LINEALES DE LAS CAPAS
                for (int t = Capas.Count - 2; t >=0 ; t--)
                {
                    for (int k = 0; k < Capas[t].Neuronas.Count; k++)
                    {
                        Capas[t].Neuronas[k].CalcularError(Capas[t].Neuronas[k].Pesos.Valores.Select(x=>x.Valor).ToList(),
                            Capas[t+1].Neuronas.Select(x=>x.Salida.Error).ToList());
                    }
                }
                //MODIFICAR PESOS Y UMBRALES
                for (int j = 0; j < Capas.Count-1; j++)
                {

                }
                //BACK FOWARD
                RecurrenteCapa(Capas[Capas.Count - 1], this);

                //SUMA DE ERROR DE PATRON
                ErrorPatron = 0;
                var Errores = 0.0;
                Capas[Capas.Count - 1].Neuronas.ForEach(x =>
                {
                    Errores += x.Salida.Error;
                });
                ErrorPatron += Errores / Capas[Capas.Count - 1].Neuronas.Count;
            }
            ErrorIteracion = ErrorPatron / Patrones.Count;
            return ErrorIteracion;
        }
        public double ReEntrenar()
        {
            var ErrorIteracion = 0.0;
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
                        Capas[c].Neuronas[n].ActivarTemp(
                            Capas[c].Activacion,
                            Patrones[PatronIndex].Entradas
                        );
                        //Capas[j].Entrenar(Patrones[i], Rata, Xo);
                    }
                    else
                    {
                        //SE ENTRENA CON LAS SALIDAS DE LA ANTERIOR CAPA
                        Capas[c].Neuronas[n].ActivarTemp(
                            Capas[c].Activacion,
                            Capas[c - 1].Neuronas.Select(x => x.Salida.YR).ToList()
                        );
                    }
                }
            }

            //SUMA DE ERROR DE PATRON
            ErrorPatron = 0;
            var Errores = 0.0;
            Capas[Capas.Count - 1].Neuronas.ForEach(x =>
            {
                Errores += x.Salida.Error;
            });
            ErrorPatron += Errores / Capas[Capas.Count - 1].Neuronas.Count;
            ErrorIteracion = ErrorPatron / Patrones.Count;
            return ErrorIteracion;
        }
        private void RecurrenteCapa(Capa Capa, Red Red)
        {

            //var Siguiente = Red.Capas[Capa.Indice + 1];
            //for (int i = 0; i < Capa.Neuronas.Count; i++)
            //{
            //    Capa.Neuronas[i].CalcularError(
            //        Siguiente.Neuronas.Select(S => S.Pesos.Valores[i].Valor).ToList(),
            //        Siguiente.Neuronas.Select(x => x.Salida.Error).ToList()
            //    );
            //}
            BuscarNeurona(1, Capa);
            for (int i = 0; i < Capa.Neuronas.Count; i++)
            {
                //SI ES LA PRIMERA CAPA LAS ENTRADAS SERAN LAS OFRECIDAS POR EL PATRON
                var Entradas = new List<double>();
                if (Capa.Indice == 0)
                    Entradas = Red.Patrones[PatronIndex].Entradas;
                else
                    Entradas = Red.Capas[Capa.Indice - 1].Neuronas.Select(x => x.Salida.YR).ToList();
                //SINO SERÁN LAS OFRECIDAS POR AL CAPA INMEDIATAMENTE ANTERIOR

                //RECARCULAMOS LOS PESOS
                Capa.Neuronas[i].EntrenarPesos(Entradas, Rata, Red.Capas[Red.Capas.Count - 1].ErrorPatron);

                //RECALCULAMOS UMBRALES
                Capa.Neuronas[i].UmbralTemp.Entrenar(Capa.Neuronas[i].UmbralTemp.Valor, Rata, Red.Capas[Red.Capas.Count - 1].ErrorPatron, Xo);
            }

            //RECORRER LAS NEURONAS Y BUSCAR LAS ALLEGADAS A CERO
            if (Capa.Indice == 0)
                RecurrenteNeuronas(Capa, Patrones[PatronIndex].Entradas, Red.Capas[Red.Capas.Count - 1].ErrorPatron);
            else
                RecurrenteNeuronas(Capa, Red.Capas[Capa.Indice - 1].Neuronas.Select( x => x.Salida.Error).ToList(), Red.Capas[Red.Capas.Count - 1].ErrorPatron);

            //CRITERIO DE PARADA (PRIMERA CAPA)
            if (Capa.Indice > 0)
                RecurrenteCapa(Capas[Capa.Indice - 1], Red);
        }
        public void BuscarNeurona(int buscar, Capa capa)
        {
            List<double> salidasTem = new List<double>();
            
            int cantidad = capa.Neuronas.Count;
            List<int> indices = new List<int>();
            int index = 0;
            double errormin = 0.0;
            bool encontro = false;
            for (int i = 0; i < buscar; i++)
            {
                errormin = 9999.9999;
                encontro = false;
                for (int j = 0; j < cantidad; j++)
                {
                    if (capa.Neuronas[j].Salida.Error <= errormin && capa.Neuronas[j].Habilitada == true)
                    {
                        errormin = capa.Neuronas[j].Salida.Error;
                        index = j;
                        encontro = true;
                    }
                }
                if (encontro == false)
                {
                    break;
                }
                else
                {
                    indices.Add(index);
                    capa.Neuronas[index].Habilitada = false;
                }
            }
            for (int i = 0; i < indices.Count; i++)
            {
                //Aqui es donde se entrenan los pesos y umbrales nuevamente
                List<double> entradas;
                if (capa.Indice == 0)
                {
                    entradas = Patrones[PatronIndex].Entradas;
                }
                else
                {
                    entradas = Capas[capa.Indice - 1].Neuronas.Select(x => x.Salida.YR).ToList();
                }
                salidasTem.Add(CompararErrores(capa.Neuronas[i], capa.ErrorPatron, capa.Activacion, entradas));
            }
            //Aqui se reentrena las salidas

            ReEntrenar();
            //Se aceptan o rechazan los pesos y umbrales
            for (int i = 0; i < indices.Count; i++)
            {
                List<double> entradas;
                double ErrorAnt = capa.Neuronas[indices[i]].Salida.Error;
                if (salidasTem[i]< ErrorAnt)
                {
                    if (capa.Indice == 0)
                    {
                        entradas = Patrones[PatronIndex].Entradas;
                    }
                    else
                    {
                        entradas = Capas[capa.Indice - 1].Neuronas.Select(x => x.Salida.YR).ToList();
                    }
                    capa.Neuronas[indices[i]].AceptarPesos();
                    capa.Neuronas[indices[i]].Activar(capa.Activacion, entradas);
                    //Min.Habilitada = false;
                }

            }
            buscar++;
            if (encontro == true && buscar < cantidad)
            {
                BuscarNeurona(buscar, capa);
            }
        }

        private void RecurrenteNeuronas(Capa Capa, List<double> Entradas, double ErrorPatron)
        {
            //OBTENEMOS LA MÁS CERCANA A CERO
            var Min = Capa.Neuronas[0];
            Capa.Neuronas.ForEach(x =>
            {
                Min = x.Salida.Error > Min.Salida.Error ? Min : x;
            });

            CompararErrores(Min, ErrorPatron, Capa.Activacion, Entradas);

            //BUSCAMOS LAS ADYACENTES
            var Seguir = true;
            var Cantidad = 2;
            var Disponible = Capa.Neuronas.Count - 1;
            var Habilitadas = 0;
            Neurona Menor = null;
            while (Seguir && Disponible > 0)
            {
                //SE ITERA PARA BUSCAR EL NÚMERO DE NEURONAS NECESARIAS MÁS CERCANAS A CERO
                var Cont = 1;
                while(Cont <= Cantidad)
                {
                    for (int i = 0; i < Capa.Neuronas.Count; i++)
                    {
                        if (Menor == null && !Capa.Neuronas[i].Usada)
                            Menor = Capa.Neuronas[i];
                        else
                        {
                            if (!Capa.Neuronas[i].Usada && Menor.Salida.Error > Capa.Neuronas[i].Salida.Error)
                                Menor = Capa.Neuronas[i];
                            else if(Disponible == 0 && Capa.Neuronas[i].Habilitada)
                            {
                                Menor = Capa.Neuronas[i];
                            }
                            else
                            {
                                Menor = Capa.Neuronas[i];
                            }
                        }
                    }
                    Cont++;
                    if(Disponible <= 0 && Habilitadas <= 0)
                    {
                        Seguir = false;
                        break;
                    }
                    //SE UTILIZA EL MENOR QUE SE HA ENCONTRADO, ACTUALZIANDO SUS PESOS
                    CompararErrores(Menor, ErrorPatron, Capa.Activacion, Entradas);
                    //CALCULAMOS LA DISPONIBILIDAD
                    Disponible = 0;
                    Habilitadas = 0;
                    Capa.Neuronas.ForEach(x =>
                    {
                        if (!x.Usada)
                            Disponible++;
                        if (x.Habilitada)
                            Habilitadas++;
                    });
                }
                //VALIDAR SI HAY NEURONAS PENDIENTES Y RESTAN CANTIDADES
                Cantidad++;
            }
        }

        private double CompararErrores(Neurona Min, double ErrorPatron, Activacion Activacion, List<double> Entradas)
        {
            //RECALCULAMOS PESOS DE LA SELECCIONADA
            var ErrorAnt = Min.Salida.Error;
            Min.EntrenarPesosTemp(Entradas, Rata, ErrorPatron);
            var ErrorTemp = Min.ActivarTemp(Activacion, Entradas);
            Min.Usada = true;
            return ErrorTemp.Error;
            //COMPARAMOS PARA HACER PERMANENTE O NO
            
            /*else
            {
                Min.Habilitada = true;
            }*/
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
        
    }
    
    
}
