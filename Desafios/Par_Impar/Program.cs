using System;

namespace Par_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Par ou Ímpar?");
            System.Console.Write("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());
            
            {
            if (num % 2 == 0)
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                System.Console.WriteLine("Este número é par!");
                Console.ResetColor();

            } else if (num % 2 == 1)
            {
                System.Console.WriteLine("Este número é ímpar!");
            }
            }
        }
    }
}
