using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;

using ENTITY;

namespace DAL
{
    public class NeuronaRepository
    {

        public NeuronaRepository()
        {
        }

        public Neurona ReadXml()
        {
            var Neurona = new Neurona();
            using (XmlReader Reader = XmlReader.Create(@"data.xml"))
            {
                while (Reader.Read())
                {
                    if (Reader.IsStartElement())
                    {
                        switch (Reader.Name.ToString())
                        {
                            case "Config":
                                var Config = Reader.ReadString().Trim();
                                Console.WriteLine(Config);
                                Neurona.SetConfig(Config);
                                break;
                            case "Patrones":
                                var Patrones = Reader.ReadString().Trim();
                                Console.WriteLine(Patrones);
                                var Split = Patrones.Split('\n');
                                foreach (var item in Split)
                                {
                                    Neurona.Patrones.Add(new Patron(item.Trim()));
                                }
                                break;
                            case "Salidas":
                                var Salidas = Reader.ReadString().Trim();
                                Console.WriteLine(Salidas);
                                Split = Salidas.Split(';');
                                foreach (var item in Split)
                                {
                                    Neurona.Salidas.Add(new Salida(item.Trim()));
                                }
                                break;
                            case "Umbrales":
                                var Umbrales = Reader.ReadString().Trim();
                                Console.WriteLine(Umbrales);
                                Split = Umbrales.Split(';');
                                foreach (var item in Split)
                                {
                                    Neurona.Umbrales.Add(new Umbrales(item.Trim()));
                                }
                                break;
                            case "Pesos":
                                var Pesos = Reader.ReadString().Trim();
                                Console.WriteLine(Pesos);
                                Split = Pesos.Split(',');
                                foreach (var item in Split)
                                {
                                    Neurona.Pesos.Add(new Pesos(item.Trim()));
                                }
                                break;
                        }
                    }
                }
            }
            return Neurona;
        }
    }
}
