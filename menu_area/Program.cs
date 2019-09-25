using System;

namespace menu_area
{
    class Program
    {
        static void Main(string[] args)
        {
            string geo;
            float l1,l2,b,h,r,D,d,B;
            double pi= 3.14f;
            
            do {                      

            Console.WriteLine("Escolha a forma geométrica que você deseja saber a área: ");
            Console.WriteLine("1 - Quadrado");
            Console.WriteLine("2 - Triângulo");
            Console.WriteLine("3 - Círculo");
            Console.WriteLine("4 - Trapézio");
            Console.WriteLine("5 - Retângulo");
            Console.WriteLine("6 - Losango");
            geo = Console.ReadLine();

            
            switch(geo) {
                case "1":
                Console.Write("Digite o valor do lado 1: ");
                l1 = float.Parse(Console.ReadLine());
                Console.Write("Digite o valor do lado 2: ");
                l2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Área = " + l1*l2);
                break;
                case "2":
                Console.Write("Digite o valor da base: ");
                b = float.Parse(Console.ReadLine());
                Console.Write("Digite o valor da altura: ");
                h = float.Parse(Console.ReadLine());
                Console.WriteLine("Área = " + b*h/2);
                break;
                case "3":
                Console.Write("Digite o valor do raio: ");
                r = float.Parse(Console.ReadLine());
                Console.WriteLine("Área = " + pi*(r*r));
                break;
                case "4":
                Console.Write("Digite o valor da base maior: ");
                B = float.Parse(Console.ReadLine());
                Console.Write("Digite o valor da base menor: ");
                b = float.Parse(Console.ReadLine());
                Console.Write("Digite o valor da altura: ");
                h = float.Parse(Console.ReadLine());
                Console.WriteLine("Área = " + (B+b)*h/2);
                break;
                case "5":
                Console.Write("Digite o valor da base: ");
                b = float.Parse(Console.ReadLine());
                Console.Write("Digite o valor da altura: ");
                h = float.Parse(Console.ReadLine());
                Console.WriteLine("Área = " + b*h);
                break;
                case "6":
                Console.Write("Digite o valor da diagonal maior: ");
                D = float.Parse(Console.ReadLine());
                Console.Write("Digite o valor da diagonal menor: ");
                d = float.Parse(Console.ReadLine());
                Console.WriteLine("Área = " + D*d/2);
                break;
                default:
                Console.WriteLine("Forma geométrica não disponível!");
                break;
            }

            } while (geo != "0");

            
            
        }
    }
}
