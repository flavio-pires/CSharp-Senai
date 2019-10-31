using System;

namespace Vetor_mm
{
    class Program
    {
        static void Main(string[] args)
        {
        int [] vetor = new int[10];
        int maior;
        int menor;
        for(int cont =0; cont <= 9; cont++){
            System.Console.WriteLine("Digite um número: ");
            vetor[cont] = int.Parse(Console.ReadLine());
        }
        maior = vetor > num;
        menor = vetor < num;
        foreach(int num in vetor)
        {
            if(maior){
                System.Console.WriteLine($"este é o maior{maior} numero");
            }else if (menor){
                System.Console.WriteLine($"este número é menor {menor}");
            }
        }
        
        }
    }
}
