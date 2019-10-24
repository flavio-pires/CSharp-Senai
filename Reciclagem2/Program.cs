using System;
using Reciclagem2.Enum;
using Reciclagem2.Interfaces;
using Reciclagem2.Models;

namespace Reciclagem2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = false; // criado variavel boleana para sair da aplicação
            string barraMenu = "===============================";
            var itensMenu = Enum.GetNames(typeof(LixosEnum));
            int codigo = ;
            do
            {
                System.Console.WriteLine(barraMenu);
                System.Console.WriteLine("Bem Vindo a Lixeira Virtual!");
                System.Console.WriteLine("      Selecione o lixo");



            } while (!querSair);
        }
    

    }
}
