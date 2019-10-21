using System;
using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class GuardaChuva : INaoReciclavel
    {
        public bool LixoCinza()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            System.Console.WriteLine("Este lixo deve ser jogado na lixeira de cor Cinza para materiais Não Recicláveis");
            return true;
        }
    }
}