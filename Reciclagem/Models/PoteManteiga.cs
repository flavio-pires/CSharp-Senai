using System;
using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class PoteManteiga
    {
        public bool LixoVermelho()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine("Este lixo deve ser jogado na lixeira de cor Vermelha para Plásticos");
            return true;
        }
    }
}