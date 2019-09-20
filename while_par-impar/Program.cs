using System;

namespace while_par_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
                        
            while (numero != 0) {
                
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
            
            }
        }
    }
}
