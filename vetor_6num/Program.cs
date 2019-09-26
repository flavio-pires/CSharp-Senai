using System;

namespace vetor_6num
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vetor = new int[6];
            int cont = 0;
            int pares = 0;
            int impares = 0;

            for (cont = 0; cont < 6; cont++){
                          
            Console.Write("Digite um número: ");
            vetor[cont] = int.Parse(Console.ReadLine());
            }
            // Estrutura de laço para ler todos os números e identificar quais são pares e ímpares

            foreach(int num in vetor){
                if (num % 2 == 0) {
				pares += 1;
                } else {
                impares ++;
            }
            }
            //int num;
            //for(int cont = 0; cont <= 5; cont++){
                //num = vetor[cont];
                //if(num % 2 == 0){
                    //pares++;
                //} else {
                    //impares++;
                //}
            //}

            Console.WriteLine($"Você tem {pares} números pares e {impares} números impares");         
			
            

        }    
    }
}
