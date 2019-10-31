using System;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Digite a quantidade de números que será impresso na tela: ");
            n = int.Parse(Console.ReadLine());
            int[] dados = new int[n];
            for(int cont = 0; cont<n; cont++){
            Console.Write($"Digite um número: ");
            dados[cont] = int.Parse(Console.ReadLine());
            }
            foreach(int num in dados){
                System.Console.Write($"{num} ");
            }
            
        }
    }
}
