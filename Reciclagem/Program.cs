using Reciclagem.Enums; // using serve para chamar outros namespace
using Reciclagem.Interfaces;
using Reciclagem.Models;
using Reciclagem.View;
using System;
using System.Linq;

namespace Reciclagem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = false;
            do // primeiro laço imprimi uma mensagem e chama o menu
            {
                System.Console.WriteLine("Estas são as coisas descartadas por você até agora:");
                int codigo = MenuUtils<LixosEnum>.ExibirMenuPadrao(); // a variavel codigo chama o Menu que esta dentro de Reciclagem.view... para chamar o menuutils ele vai trazer os dados que estão dentro de LixosEnum
                Reciclar(Lixeira.lixos[codigo]);

            } while (!querSair);
        }

        public static void Reciclar(Lixo lixo) // Lixo é a superclasse (classe pai) para as outras classes herdarem dele e entrarem no dicionario
        {

            Type tipoLixo = lixo.GetType().GetInterfaces().FirstOrDefault(); // a variavel tipolixo verifica qual o tipo do lixo informado pelo usuario, atraves do Get.Type.. GetInterfaces serve pa

            if (tipoLixo.Equals(typeof(IPapel))) // typeof compara com o type tipolixo com o valor de Ipapel.. Equals serve para verificar se o tipolixo é igual o tipo dentro da interface IPapel
            {
                IPapel lixoConvertido = (IPapel)lixo; // tecnica casting.. a variavel lixo é inserida dentro da interface IPapel para afirmar que o lixo é um papel e use o método ReciclarFeitoPapel
                Console.BackgroundColor = ConsoleColor.Blue;
                System.Console.WriteLine($"{lixoConvertido.ReciclarFeitoPapel()} deve ir para a lixeira Azul");
                Console.ResetColor();

            }
            else if (tipoLixo.Equals(typeof(IMetal)))
            {
                IMetal lixoConvertido = (IMetal)lixo;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                System.Console.WriteLine($"{lixoConvertido.ReciclarFeitoMetal()} deve ir para a lixeira Amarela");
                Console.ResetColor();
            }
            else if (tipoLixo.Equals(typeof(IPlastico)))
            {
                IPlastico lixoConvertido = (IPlastico)lixo;
                Console.BackgroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"{lixoConvertido.ReciclarFeitoPlastico()} deve ir para a lixeira Vermelha");
                Console.ResetColor();
            }
            else if (tipoLixo.Equals(typeof(IVidro)))
            {
                IVidro lixoConvertido = (IVidro)lixo;
                Console.BackgroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"{lixoConvertido.ReciclarFeitoVidro()} deve ir para a lixeira Verde");
                Console.ResetColor();
            }
            else if (tipoLixo.Equals(typeof(IOrganico)))
            {
                IOrganico lixoConvertido = (IOrganico)lixo;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Black;
                System.Console.WriteLine($"{lixoConvertido.JogarNaComposteira()} deve ir para a Composteira");
                Console.ResetColor();
            }
            else if (tipoLixo.Equals(typeof(IIndefinido)))
            {
                IIndefinido lixoConvertido = (IIndefinido)lixo;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Gray;
                System.Console.WriteLine($"{lixoConvertido.ProcurarOQueFazer()} deve ir para o descarte especial");
                Console.ResetColor();
            }
            else
            {
                System.Console.WriteLine("Tipo não identificado!");
            }
            System.Console.WriteLine("Aperte ENTER para voltar ao menu principal");
            Console.ReadLine();
        }

    }
}