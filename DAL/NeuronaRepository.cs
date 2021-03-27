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

        public Red ReadXml(string Path)
        {
            var Red = new Red();
            var Default = @"data.xml"; 
            using (XmlReader Reader = XmlReader.Create(Path??Default))
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
                                var Split = Patrones.Split(' ');
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

        public void WriteXml(Red R, string Path)
        {
            XmlDocument doc = new XmlDocument();

            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);

            XmlElement Neurona = doc.CreateElement(string.Empty, "Neurona", string.Empty);
            doc.AppendChild(Neurona);
            XmlElement Config = doc.CreateElement(string.Empty, "Config", string.Empty);
            Neurona.AppendChild(Config);
            XmlText ConfigText = doc.CreateTextNode(R.GetConfig());
            Config.AppendChild(ConfigText);

            XmlElement Patrones = doc.CreateElement(string.Empty, "Patrones", string.Empty);
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
            Neurona.AppendChild(Patrones);

            XmlElement Salidas = doc.CreateElement(string.Empty, "Salidas", string.Empty);
            var SalidasMap = " ";
            foreach (var item in R.Salidas)
            {
                SalidasMap += $"{item.Esperada};";
            }
            SalidasMap = SalidasMap.Substring(0, SalidasMap.Length - 1);
            SalidasMap += " ";
            XmlText SalidaText = doc.CreateTextNode(SalidasMap);
            Salidas.AppendChild(SalidaText);
            Neurona.AppendChild(Salidas);

            XmlElement Previo = doc.CreateElement(string.Empty, "Previo", string.Empty);
            XmlElement Umbrales = doc.CreateElement(string.Empty, "Umbrales", string.Empty);
            XmlText UmbralText = doc.CreateTextNode($" {R.UmbralAnterior.Valor} ");
            Umbrales.AppendChild(UmbralText);

            XmlElement Pesos = doc.CreateElement(string.Empty, "Pesos", string.Empty);
            var PesosMap = " ";
            foreach (var item in R.Pesos.Valores)
            {
                PesosMap += $"{item.Valor};";
            }
            PesosMap = PesosMap.Substring(0, PesosMap.Length - 1);
            PesosMap += " ";
            XmlText PesosText = doc.CreateTextNode(PesosMap);
            Pesos.AppendChild(PesosText);

            Previo.AppendChild(Umbrales);
            Previo.AppendChild(Pesos);
            Neurona.AppendChild(Previo);

            var Default = @"data.xml";
            doc.Save(Path??Default);
        }
    }
}
