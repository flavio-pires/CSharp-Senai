using System;
using EscoladeRock.Interfaces;

namespace EscoladeRock.Models
{
    class ContraBaixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo do Contra Baixo");
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes do Contra Baixo");
            return true;
        }
    }
}