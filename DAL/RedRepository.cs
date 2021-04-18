using System;
using System.Collections.Generic;
using System.Xml;

using ENTITY;

namespace DAL
{
    public class RedRepository
    {

        private bool CheckRata(double Rata)
        {
            if (Rata > 0 && Rata <= 1)
                return false;
            return true;
        }

        private bool CheckPeso(double Peso)
        {
            if (Peso >= -1 && Peso <= 1)
                return false;
            return true;
        }

        private bool CheckUmbral(double Umbral)
        {
            if (Umbral >= -1 && Umbral <= 1)
                return false;
            return true;
        }

        public Red GetXML(string Path)
        {
            var Red = new Red();
            var Default = @"DS.xml";
            try
            {
                using (XmlReader Reader = XmlReader.Create(Path ?? Default))
                {
                    var W = 0; var U = 0;
                    while (Reader.Read())
                    {
                        if (Reader.IsStartElement())
                        {
                            switch (Reader.Name.ToString())
                            {
                                case "I":
                                    var Iteraciones = Reader.ReadString().Trim();
                                    if (!Int32.TryParse(Iteraciones, out _))
                                    {
                                        return null;
                                    }
                                    Red.Iteraciones = Int32.Parse(Iteraciones);
                                    break;
                                case "EN":
                                    var Entrenamientos = Reader.ReadString().Trim();
                                    if (!Int32.TryParse(Entrenamientos, out _))
                                    {
                                        return null;
                                    }
                                    Red.Entrenamientos = Int32.Parse(Entrenamientos.Trim());
                                    break;
                                case "R":
                                    var Rata = Reader.ReadString().Trim();
                                    if (!Double.TryParse(Rata, out _))
                                    {
                                        return null;
                                    }
                                    else if (CheckRata(Double.Parse(Rata)))
                                    {
                                        return null;
                                    }
                                    Red.Rata = Double.Parse(Rata.Trim());
                                    break;
                                case "E":
                                    var Error = Reader.ReadString().Trim();
                                    if (!Double.TryParse(Error, out _))
                                    {
                                        return null;
                                    }
                                    Red.Error = Double.Parse(Error);
                                    break;
                                case "EM":
                                    var ErrorMax = Reader.ReadString().Trim();
                                    if (!Double.TryParse(ErrorMax, out _))
                                    {
                                        return null;
                                    }
                                    Red.ErrorMaxPermitido = Double.Parse(ErrorMax);
                                    break;
                                case "C":
                                    var Capas = Reader.ReadString().Trim().Split(';');
                                    for (int i = 0; i < Capas.Length; i++)
                                    {
                                        if (!Int32.TryParse(Capas[i], out _))
                                        {
                                            return null;
                                        }
                                        Red.Capas.Add(new Capa());
                                        for (int j = 0; j < Int32.Parse(Capas[i]); j++)
                                        {
                                            Red.Capas[i].Neuronas.Add(new Neurona());
                                        }
                                    }
                                    break;
                                case "F":
                                    var Funciones = Reader.ReadString().Trim().Split(';');
                                    if (Red.Capas.Count != Funciones.Length)
                                        return null;
                                    for (int i = 0; i < Funciones.Length; i++)
                                    {
                                        if (!Int32.TryParse(Funciones[i], out _))
                                        {
                                            return null;
                                        }
                                        switch (Funciones[i])
                                        {
                                            case "0":
                                                Red.Capas[i].Activacion.Funcion = FUNCIONES.Lineal;
                                                break;
                                            case "1":
                                                Red.Capas[i].Activacion.Funcion = FUNCIONES.Sigmoide;
                                                break;
                                            case "2":
                                                Red.Capas[i].Activacion.Funcion = FUNCIONES.TangenteHip;
                                                break;
                                            case "3":
                                                Red.Capas[i].Activacion.Funcion = FUNCIONES.Gaussiana;
                                                break;
                                            default:
                                                Red.Capas[i].Activacion.Funcion = FUNCIONES.Lineal;
                                                break;
                                        }
                                    }
                                    break;
                                case "P":
                                    var Patrones = Reader.ReadString().Trim();
                                    var Split = Patrones.Split(' ');
                                    foreach (var item in Split)
                                    {
                                        var Entradas = item.Split(';');
                                        foreach (var Entrada in Entradas)
                                        {
                                            if (!Double.TryParse(Entrada, out _))
                                            {
                                                return null;
                                            }
                                        }
                                        Red.Patrones.Add(new Patron(item.Trim()));
                                    }
                                    break;
                                case "YD":
                                    var Salidas = Reader.ReadString().Trim().Split(' ');
                                    //VALIDAR QUE LAS SALIDAS CONCUERDEN CON LOS PATRONES Y EL # DE NEURONAS DE SALIDA
                                    for (int i = 0; i < Salidas.Length; i++)
                                    {
                                        var Salida = Salidas[i].Split(';');
                                        for (int j = 0; j < Salida.Length; j++)
                                        {
                                            if (!Double.TryParse(Salida[j], out _))
                                            {
                                                return null;
                                            }
                                            Red.Patrones[i].SalidasSupervisada.Add(new Salida());
                                            Red.Patrones[i].SalidasSupervisada[j].YD = Double.Parse(Salida[j]);
                                        }
                                    }
                                    break;
                                case "W":
                                    var Pesos = Reader.ReadString().Trim().Split(' ');
                                    foreach (var item in Pesos)
                                    {
                                        var Peso = item.Split(';');
                                        foreach (var _item in Peso)
                                        {
                                            if (!Double.TryParse(_item, out _))
                                            {
                                                return null;
                                            }
                                        }
                                        Red.Capas[W].Pesos.Add(new ENTITY.Pesos(item));
                                    }
                                    ++W;
                                    break;
                                case "U":
                                    var Umbrales = Reader.ReadString().Trim().Split(' ');
                                    foreach (var item in Umbrales)
                                    {
                                        var Peso = item.Split(';');
                                        for (int i = 0; i < Peso.Length; i++)
                                        {
                                            if (!Double.TryParse(Peso[i], out _))
                                            {
                                                return null;
                                            }
                                            Red.Capas[U].Neuronas[i].Umbral = new Umbral(Double.Parse(Peso[i]));
                                        }
                                    }
                                    ++W;
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception) { }
            return Red;
        }

        public List<Patron> GetDS(string Path)
        {
            var Patrones = new List<Patron>();
            try
            {
                using (XmlReader Reader = XmlReader.Create(Path))
                {
                    while (Reader.Read())
                    {
                        if (Reader.IsStartElement())
                        {
                            switch (Reader.Name.ToString())
                            {
                                case "P":
                                    var _Patrones = Reader.ReadString().Trim();
                                    var Split = _Patrones.Split(' ');
                                    foreach (var item in Split)
                                    {
                                        var Entradas = item.Split(';');
                                        foreach (var Entrada in Entradas)
                                        {
                                            if (!Double.TryParse(Entrada, out _))
                                            {
                                                return null;
                                            }
                                        }
                                        Patrones.Add(new Patron(item.Trim()));
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception) { }
            return Patrones;
        }

        private bool Patron_Salida(List<Salida> Salidas, List<Patron> Patrones)
        {
            if (Salidas.Count != Patrones.Count)
                return true;
            return false;
        }

        private bool Pesos_Entradas(List<Patron> Patrones, Pesos Pesos)
        {
            foreach (var Patron in Patrones)
            {
                if (Patron.Entradas.Count != Pesos.Valores.Count)
                    return true;
            }
            return false;
        }

        public void PostXML(Red R, string Path)
        {
            XmlDocument doc = new XmlDocument();

            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);

            XmlElement Red = doc.CreateElement(string.Empty, "Red", string.Empty);
            doc.AppendChild(Red);

            XmlElement Iteracion = doc.CreateElement(string.Empty, "I", string.Empty);
            Red.AppendChild(Iteracion);
            XmlText IteracionText = doc.CreateTextNode(" "+R.Iteraciones.ToString()+" ");
            Iteracion.AppendChild(IteracionText);

            XmlElement Funcion = doc.CreateElement(string.Empty, "F", string.Empty);
            Red.AppendChild(Funcion);
            //XmlText FuncionText = doc.CreateTextNode(" "+((int)R.Activacion.Funcion).ToString()+" ");
            //Funcion.AppendChild(FuncionText);

            XmlElement Rata = doc.CreateElement(string.Empty, "R", string.Empty);
            Red.AppendChild(Rata);
            XmlText RataText = doc.CreateTextNode(" "+R.Rata.ToString()+" ");
            Rata.AppendChild(RataText);

            XmlElement Error = doc.CreateElement(string.Empty, "E", string.Empty);
            Red.AppendChild(Error);
            XmlText ErrorText = doc.CreateTextNode(" "+R.Error.ToString()+" ");
            Error.AppendChild(ErrorText);

            XmlElement ErrorMax = doc.CreateElement(string.Empty, "EM", string.Empty);
            Red.AppendChild(ErrorMax);
            XmlText ErrorMaxText = doc.CreateTextNode(" "+R.ErrorMaxPermitido.ToString()+" ");
            ErrorMax.AppendChild(ErrorMaxText);

            XmlElement Entrenamiento = doc.CreateElement(string.Empty, "EN", string.Empty);
            Red.AppendChild(Entrenamiento);
            XmlText EntrenamientoText = doc.CreateTextNode(" "+R.Entrenamientos.ToString()+" ");
            Entrenamiento.AppendChild(EntrenamientoText);

            XmlElement Patrones = doc.CreateElement(string.Empty, "P", string.Empty);
            var i = 0;
            foreach (var item in R.Patrones)
            {
                XmlText Patron;
                if (i == 0)
                   Patron = doc.CreateTextNode(" " + item.GetPatron());
                else
                    Patron = doc.CreateTextNode(item.GetPatron());
                Patrones.AppendChild(Patron);
                ++i;
            }
            Red.AppendChild(Patrones);

            XmlElement Salidas = doc.CreateElement(string.Empty, "YD", string.Empty);
            var SalidasMap = " ";
            /*foreach (var item in R.Salidas)
            {
                SalidasMap += $"{item.YD};";
            }*/
            SalidasMap = SalidasMap.Substring(0, SalidasMap.Length - 1);
            SalidasMap += " ";
            XmlText SalidaText = doc.CreateTextNode(SalidasMap);
            Salidas.AppendChild(SalidaText);
            Red.AppendChild(Salidas);

            XmlElement Pesos = doc.CreateElement(string.Empty, "W", string.Empty);
            var PesosMap = " ";
            /*foreach (var item in R.Pesos.Valores)
            {
                PesosMap += $"{item.Valor};";
            }*/
            PesosMap = PesosMap.Substring(0, PesosMap.Length - 1);
            PesosMap += " ";
            XmlText PesosText = doc.CreateTextNode(PesosMap);
            Pesos.AppendChild(PesosText);
            Red.AppendChild(Pesos);

            XmlElement Umbrales = doc.CreateElement(string.Empty, "U", string.Empty);
            //XmlText UmbralText = doc.CreateTextNode($" {R.UmbralAnterior.Valor} ");
            //Umbrales.AppendChild(UmbralText);
            Red.AppendChild(Umbrales);

            var Default = @"DS.xml";
            doc.Save(Path??Default);
        }
    }
}
