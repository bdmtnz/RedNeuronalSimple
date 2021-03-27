﻿using System;
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

        public Red ReadXml(string Path)
        {
            return _Neurona.ReadXml(Path);
        }

        public void WriteXML(Red R, string Path)
        {
            _Neurona.WriteXml(R, Path);
        }

        public Red Entrenar(Red R)
        {
            var i = 0;
            
            while (i < R.Iteraciones)
            {
                var ErrorIteracion = R.Entrenar();
                R.Error = ErrorIteracion;
                i++;
                R.Entrenamientos = i;
                //AQUI SE GUARDA LOS PESOS Y UMBRALES
                _Neurona.WriteXml(R, null);
                if (R.ErrorMaxPermitido >= ErrorIteracion) break; 
            }

            return R;
        }
     

    }
}
