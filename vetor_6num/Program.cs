using System;

namespace vetor_6num
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vetor = new int[6];
            int num = 0;

            for (num = 0; num < 6; num++){
                          
            Console.WriteLine("Digite um número inteiro");
            vetor[num] = int.Parse(Console.ReadLine());
            }

            if (num % 2 == 0) {
				Console.WriteLine("Este número é par!");
			} else {
                Console.WriteLine("Este número é ímpar!");
            }
            

        }    
    }
}
