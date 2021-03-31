using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ENTITY;
using DAL;

namespace BLL
{
    public class RedService
    {
        private RedRepository _Neurona { get; set; }

        public RedService()
        {
            _Neurona = new RedRepository();
        }

        public Red ReadXml(string Path)
        {
            return _Neurona.GetXML(Path);
        }

        public void WriteXML(Red R, string Path)
        {
            _Neurona.PostXML(R, Path);
        }

        public List<Patron> LoadPatrones(string Path)
        {
            return _Neurona.GetDS(Path);
        }

        public void EntrenarPausable()
        {
            var i = Plataforma.Red.Entrenamientos;
            if(Plataforma.Red.Error > Plataforma.Red.ErrorMaxPermitido)
            {
                while (i < Plataforma.Red.Iteraciones && Plataforma.Continuar)
                {
                    var ErrorIteracion = Plataforma.Red.Entrenar();
                    Plataforma.Red.Error = ErrorIteracion;
                    i++;
                    Plataforma.Red.Entrenamientos = i;
                    System.Threading.Thread.Sleep(200);
                    _Neurona.PostXML(Plataforma.Red, null);
                    if (Plataforma.Red.ErrorMaxPermitido >= ErrorIteracion) break;
                }
            }
        }

    }
}
