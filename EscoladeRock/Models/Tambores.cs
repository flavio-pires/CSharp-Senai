using System;
using EscoladeRock.Interfaces;

namespace EscoladeRock.Models
{
    class Tambores : InstrumentoMusical, IPercussao
    {
    public bool ManterRitmo()
    {
        System.Console.WriteLine("Manter ritmo dos tambores");
        return true;
        
    }

    }
}