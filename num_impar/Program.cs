using System;

namespace num_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que mostra os números ímpares entre 1 a 100 !");
            for (int i = 1; i <= 100; i+=2){
                Console.Write(i + " ");
            }
        }
    }
}
