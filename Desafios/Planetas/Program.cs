using System;

namespace Planetas
{
    class Program
    {
        static void Main(string[] args)
        {
            int Planeta;
            do
            {            
            double Pterra;
            Console.WriteLine("===== Peso nos planetas =====");
            System.Console.WriteLine();
            System.Console.Write("Digite o seu peso na Terra: ");
            Pterra = double.Parse(Console.ReadLine());
            Console.Clear();
            
            System.Console.WriteLine("Escolha um planeta para saber o seu peso nele:");
            System.Console.WriteLine("1 - Mercúrio");
            System.Console.WriteLine("2 - Vênus");
            System.Console.WriteLine("3 - Marte");
            System.Console.WriteLine("4 - Júpiter");
            System.Console.WriteLine("5 - Saturno");
            System.Console.WriteLine("6 - Urano");
            System.Console.WriteLine("0 - Encerrar programa");
            Planeta = int.Parse(Console.ReadLine());
            Console.Clear();
            

            switch (Planeta)
            {
                case 1:
                System.Console.WriteLine($"O seu peso no planeta Mercúrio é: {(Pterra/10) * 0.37}");
                break;
                case 2:
                System.Console.WriteLine($"O seu peso no planeta Vênus é: {(Pterra/10) * 0.88}");
                break;
                case 3:
                System.Console.WriteLine($"O seu peso no planeta Marte é: {(Pterra/10) * 0.38}");
                break;
                case 4:
                System.Console.WriteLine($"O seu peso no planeta Júpiter é: {(Pterra/10) * 2.64}");
                break;
                case 5:
                System.Console.WriteLine($"O seu peso no planeta Saturno é: {(Pterra/10) * 1.15}");
                break;
                case 6:
                System.Console.WriteLine($"O seu peso no planeta Urano é: {(Pterra/10) * 1.17}");
                break;
                default:
                System.Console.WriteLine("Planeta não encontrado!");
                break;
                

            }
            
            }while (Planeta != 0);
            Console.Clear();
            

        }
    }
}
