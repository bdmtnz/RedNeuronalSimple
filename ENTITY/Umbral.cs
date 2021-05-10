﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Umbral
    {
        public double Valor { get; set; }
        public double ValorTemp { get; set; }
        public Umbral()
        {

        }

        public Umbral(double Valor)
        {
            this.Valor = Valor;
        }

        public void Entrenar(double AnteriorValor, double Rata, double ErrorSalida, double Entrada)
        {
            Valor = AnteriorValor + (Rata * ErrorSalida * Entrada);
            Valor = Valor > 1 ? Plataforma.Random() : Valor;
            Valor = Valor < -1 ? Plataforma.Random() : Valor;
        }
        public void EntrenarTemp(double AnteriorValor, double Rata, double ErrorSalida, double Entrada)
        {
            ValorTemp = AnteriorValor + (Rata * ErrorSalida * Entrada);
            ValorTemp = ValorTemp > 1 ? Plataforma.Random() : ValorTemp;
            ValorTemp = ValorTemp < -1 ? Plataforma.Random() : ValorTemp;
        }
    }

    
}
