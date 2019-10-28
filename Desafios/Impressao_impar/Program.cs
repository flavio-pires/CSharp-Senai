using System;

namespace Impressao_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====== Impressão de Ímpares ======");
            System.Console.WriteLine();
            for (int i=1; i<=10; i+=2){
                System.Console.Write($" {i} ");
            }
        }
    }
}
