using System;
using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class Garrafa : IVidro
    {
        public bool LixoVerde()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("Este lixo deve ser jogado na lixeira de cor Verde para Vidros");
            return true;
        }
    }
}