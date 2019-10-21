using System;
using EscoladeRock.Interfaces;

namespace EscoladeRock.Models
{
    public class Bateria : InstrumentoMusical, IPercussao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Manter ritmo da bateria.");
            return true;
        }
    }
}