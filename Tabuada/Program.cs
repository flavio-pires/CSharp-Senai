using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Tabuada");
            for (int num = 1; num <= 10; num++){
                for (int num2 = 1; num2 <= 10; num2++){
                
                Console.Write($"\t{num2} * {num} = {num2*num} ");
            }

            Console.WriteLine();
            }

            for (int num = 1; num <= 10; num++){
                for (int num2 = 1; num2 <= 10; num2++){
                
                Console.Write($"{num2,-2} * {num,-2} = {num2*num,-3} ");
            }

            Console.WriteLine();
            }
                    

        }
    }
}
