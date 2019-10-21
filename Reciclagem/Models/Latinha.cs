using System;
using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class Latinha : IMetal
    {
        public bool LixoAmarelo()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("Este lixo deve ser jogado na lixeira de cor Amarela para Metais");
            return true;
        }
    }
}