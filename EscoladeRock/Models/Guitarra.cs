using System;
using EscoladeRock.Interfaces;
using System.Collections.Generic;

namespace EscoladeRock.Models
{
    public class Guitarra : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes de Guitarra");
            return true;
        }

        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando solo de Guitarra");
            return true;
        }
    }
}