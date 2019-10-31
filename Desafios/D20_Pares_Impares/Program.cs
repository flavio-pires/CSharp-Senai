using System;

namespace D20_Pares_Impares
{
    class Program
    {
        static void Main(string[] args)
        {
        int [] vetor = new int[10];
        int pares = 0;
        int impares = 0;
        for(int cont =0; cont <= 9; cont++){
            System.Console.WriteLine("Digite um número: ");
            vetor[cont] = int.Parse(Console.ReadLine());
        }
        foreach(int num in vetor)
        {
            if(num%2 == 0){
                pares++;
            }else{
                impares++;
            }
        }
        System.Console.WriteLine($"Você tem {pares} números pares e {impares} números impares.");
        }
    }
}
