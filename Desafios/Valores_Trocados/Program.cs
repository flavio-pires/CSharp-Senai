using System;

namespace Valores_Trocados
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            Console.WriteLine("=====Valores Trocados=====");
            System.Console.WriteLine();
            System.Console.Write("Digite um valor para A: ");
            A = double.Parse(Console.ReadLine());
            System.Console.Write("Digite um valor para B: ");
            B = double.Parse(Console.ReadLine());
            
            System.Console.WriteLine($"Os valores digitados são A = {A} e B = {B}");
            System.Console.WriteLine($"Fazendo a mágica o valor de A se torna {B} e o valor de B fica {A}");

        }
    }
}
