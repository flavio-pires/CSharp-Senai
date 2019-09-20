using System;

namespace Par_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
                        
            do {
                
            Console.WriteLine("Digite um número inteiro");
            numero = int.Parse(Console.ReadLine());

            if (numero == 0) {
                Console.WriteLine("Fim do programa!");
            } else
            if (numero % 2 == 0) {
				Console.WriteLine("Este número é par!");
			} else {
                Console.WriteLine("Este número é ímpar!");
            }
            
            } while (numero != 0);
            

        }
    }
}
