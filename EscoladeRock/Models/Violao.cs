using System;
using EscoladeRock.Interfaces;

namespace EscoladeRock.Models
{
    public class Violao : InstrumentoMusical, IMelodia, IHarmonia, IPercussao
    {
        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando solo do Violão");
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes do Violão");
            return true;
        }

        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo ritmo do Violão");
            return true;
        }
    }
}