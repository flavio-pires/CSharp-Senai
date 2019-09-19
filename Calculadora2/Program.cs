using System;

namespace Calculadora2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            string oper;

            Console.WriteLine("Digite o 1º Número:");
            num1 = int.Parse(Console.ReadLine ());
            Console.WriteLine("Digite o 2º Número:");
            num2 = int.Parse(Console.ReadLine ());
            Console.WriteLine("Qual o operador desejado?");
            oper = Console.ReadLine();
            
            switch(oper) {
                case "+":
                Console.WriteLine("Resultado: " + $"{num1} + {num2} = {num1 + num2}");
                break;
                case "-":
                Console.WriteLine("Resultado: " + $"{num1} - {num2} = {num1 - num2}");
                break;
                case "*":
                Console.WriteLine("Resultado: " + $"{num1} * {num2} = {num1 * num2}");
                break;
                case "/":
                Console.WriteLine("Resultado: " + $"{num1} / {num2} = {num1 / num2}");
                break;
                case "%":
                Console.WriteLine("Resultado: " + $"{num1} % {num2} = {num1 % num2}");
                break;
                default:
                Console.WriteLine("Operação inválida");
                break;
            }
            
        }
    }
}
