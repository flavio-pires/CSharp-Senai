using System;

namespace Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade_anos = 0;
            
            Console.WriteLine("Digite a sua idade em anos");
            idade_anos = int.Parse(Console.ReadLine ());

            Console.WriteLine("Sua idade em meses é " + idade_anos * 12);
            
            Console.WriteLine("Sua idade em dias é " + idade_anos * 365);
            
            Console.WriteLine("Sua idade em horas é " + idade_anos * 8760);
            
            Console.WriteLine("Sua idade em minutos é " + idade_anos * 525600);
            

        }
    }
}
