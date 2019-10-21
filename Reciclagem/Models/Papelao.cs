using System;
using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class Papelao : IPapel
    {
        public bool LixoAzul()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("Este lixo deve ser jogado na lixeira de cor Azul para Papéis");
            return true;
        }
    }
}