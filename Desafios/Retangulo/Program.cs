using System;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("*Calcule os dados de um retângulo*");
            Console.ResetColor();
            double b,h;
            
            System.Console.Write("Digite a base do retângulo: ");
            b = double.Parse(Console.ReadLine());
            System.Console.Write("Digite a altura do retângulo: ");
            h = double.Parse(Console.ReadLine());
            System.Console.WriteLine();
            System.Console.WriteLine($"Perímetro: {2*(b+h)}");
            System.Console.WriteLine($"Área: {b*h}");
            System.Console.WriteLine($"Diagonal: {(Math.Sqrt((b*b)+(h*h)))}"); // raiz quadrada = math.sqrt
            


        }
    }
}
