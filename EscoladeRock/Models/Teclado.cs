using System;
using EscoladeRock.Interfaces;

namespace EscoladeRock.Models
{
    public class Teclado : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando solo do Teclado");
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes do Teclado");
            return true;
        }
    }
}