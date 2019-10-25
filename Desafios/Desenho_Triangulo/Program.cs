using System;

namespace Desenho_Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desenho do Triângulo");
            System.Console.WriteLine();
            System.Console.Write("Digite a altura do seu triângulo: ");
            int h = int.Parse(Console.ReadLine());

            for (int i=0;i<=h;i++){
                for (int j=i; j<h; j++){
                    System.Console.Write("*");
                }
                System.Console.WriteLine("");
            }
            string estrelas = " ";
            int altura = 7;
            for (int x = 0; x < altura; x++){
                estrelas += "*";
                System.Console.WriteLine(estrelas);
            }
        }
    }
}
