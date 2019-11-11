using System;

namespace Kahoot_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = 
            {
                {10,15,48},
                {56,97,77},
                {2,100,33}
            };

            int soma = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    soma += matrix[i,j];
                }
            }

            //foreach (var item in matrix)
            //{
                // soma += item;
            //}
            
            System.Console.WriteLine(soma);
        }
    }
}
