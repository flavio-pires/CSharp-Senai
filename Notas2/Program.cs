using System;

namespace Notas2
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;
           Console.WriteLine("Calculando a Média dos alunos!");
           Console.WriteLine("Coloque a primeira nota do aluno:");
           nota1 = double.Parse(Console.ReadLine());
           Console.WriteLine("Coloque a segunda nota do aluno:");
           nota2 = double.Parse(Console.ReadLine());
           Console.WriteLine("Coloque a terceira nota do aluno:");
           nota3 = double.Parse(Console.ReadLine());
           Console.WriteLine("Coloque a quarta nota do aluno:");
           nota4 = double.Parse(Console.ReadLine());
           media = (nota1 + nota2 + nota3 + nota4) / 4;

           Console.WriteLine("A média do aluno é: {0}", media);

            if (media >= 7.0) {
               Console.WriteLine("Parabéns você passou!"); 
            } else {
                Console.WriteLine("Que pena, não foi dessa vez!");
            } 

        }
    }
}
