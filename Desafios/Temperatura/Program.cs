using System;

namespace Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double C;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Conversão de Temperatura");
            Console.ResetColor();
            System.Console.WriteLine();
            System.Console.Write("Digite a temperatura em graus Celsius: ");
            C = double.Parse(Console.ReadLine());
            System.Console.WriteLine($"Veja a temperatura convertida para Fahrenheit: {(9*C + 160)/5}");
            
        }
    }
}
