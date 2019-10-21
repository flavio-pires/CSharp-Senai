using System;
using Reciclagem.Interfaces;
using Reciclagem.Models;
using System.Collections.Generic;

namespace Reciclagem
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuBar = "===================================";

            do
            {
                Console.Clear();

                System.Console.WriteLine(menuBar);
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.Black;
                System.Console.WriteLine("     Seja bem-vindo a Lixeira Digital      ");
                System.Console.WriteLine("        Selecione o lixo:      ");
                Console.ResetColor();
                System.Console.WriteLine(menuBar);
                Console.WriteLine("1 - Garrafa");
                Console.WriteLine("2 - Garrafa PET");
                Console.WriteLine("3 - Guarda Chuva");
                Console.WriteLine("4 - Latinha");
                Console.WriteLine("5 - Papelao");
                Console.WriteLine("6 - Pote de Manteiga");
                int lixo = int.Parse(Console.ReadLine());

                switch(lixo) {
                case "1":
                Garrafa;
                break;
                case "2":
                GarrafaPET;
                break;
                case "3":
                GuardaChuva;
                break;
                case "4":
                Latinha;
                break;
                case "5":
                Papelao;
                break;
                case "6":
                PoteManteiga;
                break;
                default:
                Console.WriteLine("Lixo não encontrado!");
                break;
            }
            }while (!lixo);
        }
    }
}
