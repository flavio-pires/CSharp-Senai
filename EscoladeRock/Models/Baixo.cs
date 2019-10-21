using System;
using EscoladeRock.Interfaces;

namespace EscoladeRock.Models
{
    class Baixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo do Baixo");
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes do Baixo");
            return true;
        }
    }
}