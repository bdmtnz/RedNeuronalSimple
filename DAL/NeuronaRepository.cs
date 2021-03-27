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

        public Red ReadXml()
        {
            var Red = new Red();
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
                                Red.SetConfig(Config);
                                break;
                            case "Patrones":
                                var Patrones = Reader.ReadString().Trim();
                                Console.WriteLine(Patrones);
                                var Split = Patrones.Split('\n');
                                foreach (var item in Split)
                                {
                                    Red.Patrones.Add(new Patron(item.Trim()));
                                }
                                break;
                            case "Salidas":
                                var Salidas = Reader.ReadString().Trim();
                                Console.WriteLine(Salidas);
                                Split = Salidas.Split(';');
                                foreach (var item in Split)
                                {
                                    Red.Salidas.Add(new Salida(item.Trim()));
                                }
                                break;
                            case "Umbrales":
                                var Umbrales = Reader.ReadString().Trim();
                                Console.WriteLine(Umbrales);
                                Split = Umbrales.Split(';');
                                foreach (var item in Split)
                                {
                                    Red.Umbral.Valor = Double.Parse(item.Trim());
                                }
                                break;
                            case "Pesos":
                                var Pesos = Reader.ReadString().Trim();
                                Console.WriteLine(Pesos);
                                Split = Pesos.Split(';');
                                foreach (var item in Split)
                                {
                                    Red.Pesos.Valores.Add(new Peso(Double.Parse(item.Trim())));
                                }
                                break;
                        }
                    }
                }
            }
            return Red;
        }
    }
}
