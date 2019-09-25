using System;

namespace teste_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=0;
            int y=1;

            Console.WriteLine("quantidade de triangulos");
            x=int.Parse(Console.ReadLine());
            Console.WriteLine("tamanho triangulo");
            y= int.Parse(Console.ReadLine());
            for (int q = 1; q<=x; q++){
            for(int i=1; i <=y; i++){
               for(int j=1; j <=i;j++){
                   Console.Write($"*");
                       }
                       Console.WriteLine("");
                }
            }
        }
    }
}
