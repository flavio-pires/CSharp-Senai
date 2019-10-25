using System;

namespace Combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = 60;
            double d;
            double v;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Bem Vindo a sua calculadora de combústivel!");
            Console.ResetColor();
            System.Console.WriteLine();
            System.Console.WriteLine("Quantas horas você gastou na sua viagem?");
            h = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Qual foi a sua velocidade média em kilometros por hora?");
            v = double.Parse(Console.ReadLine());
            System.Console.WriteLine($"A sua distância percorrida foi de {d=h*v} kilometros");
            System.Console.WriteLine();
            System.Console.WriteLine($"A quantidade de combustível consumida foi de {d/12} litros");
        }
    }
}
