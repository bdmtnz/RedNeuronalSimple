using System;
using System.Collections.Generic;
using System.IO;

using ENTITY;

namespace DAL
{
    public class NeuronaRepository
    {

        public NeuronaRepository()
        {

        }


        public Red LeerArchivo(string Ruta)
        {
            var Red = new Red();
            using (var Lector = new StreamReader(Ruta??@".\DataSet.txt"))
            {
                var Data = Lector.ReadToEnd();
                var Split = Data.Split('\n');

                
                
                var config = Split[0].Split(' ');
                foreach (var item in config)
                {
                    if (!Double.TryParse(item,out _))
                    {
                        return null;   
                    }
                }

                if (ValidarRata(Double.Parse(config[4])))
                {
                    return null;
                }

                
                Red.SetConfig(Split[0]);


                var Patrones = Split[1].Split(';');
                foreach (var item in Patrones)
                {
                    var Entradas = item.Split(' ');
                    foreach (var Entrada in Entradas)
                    {
                        if (!Double.TryParse(Entrada, out _))
                        {
                            return null;
                        }
                    }
                    Red.Patrones.Add(new Patron(item));
                }

                var Salidas = Split[2].Split(' ');
                foreach (var item in Salidas)
                {
                    if(Double.TryParse(item,out _))
                    {
                        Red.Salidas.Add(new Salida(item));
                    }
                    else
                    {
                        return null;
                    }
                }

                if(Double.TryParse(Split[3],out _))
                {
                    if (ValidarUmbral(Double.Parse(Split[3])))
                        return null;
                    Red.Umbral.Valor = Double.Parse(Split[3]);
                }
                else
                {
                    return null;
                }

                var Pesos = Split[4].Split(' ');
                foreach (var item in Pesos)
                {

                    if (Double.TryParse(item, out _))
                    {
                        if (ValidarPeso(Double.Parse(item)))
                            return null;
                        Red.Pesos.Valores.Add(new Peso(Double.Parse(item)));
                    }
                    else
                    {
                        return null;
                    }    
                }
                if(EntradasVsPesos(Red.Patrones, Red.Pesos))
                    return null;

                if (PatronesVsSalidas(Red.Salidas, Red.Patrones))
                    return null;
            }
            return Red;
        }

        public void EscribirArchivo(Red Red, string Ruta)
        {
            //File.Delete(@".\DataSet.txt");
            //File.CreateText(@".\DataSet.txt");

            using (StreamWriter Escritor = new StreamWriter(Ruta??@".\DataSet.txt"))
            {
                Escritor.WriteLine(Red.GetConfig());
                var Patrones = "";
                foreach (var item in Red.Patrones)
                {
                    Patrones += item.GetPatron();
                }
                Escritor.WriteLine(Patrones.Substring(0,Patrones.Length-1));

                var salidas = "";
                foreach (var item in Red.Salidas)
                {
                    salidas += item.Esperada+" ";
                }
                Escritor.WriteLine(salidas.Substring(0,salidas.Length-1));

                Escritor.WriteLine(Red.Umbral.Valor);

                var pesos = "";
                foreach (var item in Red.Pesos.Valores)
                {
                    pesos += item.Valor + " ";
                }
                Escritor.WriteLine(pesos.Substring(0,pesos.Length-1));
            }
        }

        private bool ValidarRata(double Rata)
        {
            if (Rata > 0 && Rata <= 1)
                return false;
            return true;
        }

        private bool ValidarPeso(double Peso)
        {
            if (Peso >= -1 && Peso <= 1)
                return false;
            return true;
        }

        private bool ValidarUmbral(double Umbral)
        {
            if (Umbral >= -1 && Umbral <= 1)
                return false;
            return true;
        }

        private bool PatronesVsSalidas(List<Salida> Salidas, List<Patron> Patrones)
        {
            if (Salidas.Count != Patrones.Count)
                return true;
            return false;
        }

        private bool EntradasVsPesos(List<Patron> Patrones, Pesos Pesos)
        {
            foreach (var Patron in Patrones)
            {
                if (Patron.Entradas.Count != Pesos.Valores.Count)
                    return true;
            }
            return false;
        }

        
    }
}
