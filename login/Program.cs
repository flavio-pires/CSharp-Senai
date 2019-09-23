using System;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            string senha;

            Console.WriteLine("Digite seu login");
            login = Console.ReadLine();
            Console.WriteLine("Digite sua senha");
            senha = Console.ReadLine();

            if ((login == "admin") && (senha == "admin")) {
                Console.WriteLine("Seja bem vindo Administrador!");
            } else {
                Console.WriteLine("Seja bem vindo!");
            }

        }
    }
}
