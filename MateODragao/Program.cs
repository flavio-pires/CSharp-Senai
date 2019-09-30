using System;
using MateODragao.Models;

namespace MateODragao {
    class Program {
        static void Main (string[] args) {
            bool JogadorNaoDesistiu = true;
            do {

                System.Console.WriteLine ("******************************");
                System.Console.WriteLine ("        Mate o Dragão!");
                System.Console.WriteLine ("******************************");

                System.Console.WriteLine (" 1 - Iniciar jogo");
                System.Console.WriteLine (" 0 - Sair do jogo");

                string opcaojogador = Console.ReadLine ();

                switch (opcaojogador) {
                    case "1":
                        Console.Clear ();
                        Guerreiro guerreiro = new Guerreiro ();
                        guerreiro.Nome = "Ragnar";
                        guerreiro.Sobrenome = "Décimus";
                        guerreiro.CidadeNatal = "Sparta";
                        guerreiro.DataNascimento = DateTime.Parse ("11/09/1303");
                        guerreiro.FerramentaAtaque = "Lança e Besta";
                        guerreiro.FerramentaProtecao = "Armadura e escudo de ferro";
                        guerreiro.Forca = 2;
                        guerreiro.Destreza = 3;
                        guerreiro.Inteligencia = 3;
                        guerreiro.Vida = 20;

                        Dragao dragao = new Dragao ();
                        dragao.Nome = "Dragonelson";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;

                        /* INICIO - Primeiro Diálogo*/
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: {dragao.Nome}, seu louco! Vim-lhe derrotar-te-lhe");

                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Kkkkkk! Humano tolinho. Quem pensas que és?");

                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Aperte ENTER para prosseguir");
                        Console.ReadLine ();

                        /* FIM - Primeiro Diálogo*/

                        /* INICIO - Segundo Diálogo*/
                        Console.Clear ();
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Eu sou {guerreiro.Nome}! Da casa {guerreiro.Sobrenome}, ó criatura morfética!");
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Vim de {guerreiro.CidadeNatal} para derrotar-te e mostra meu valor!");

                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: QUEM? DE ONDE? Bom, que seja... fritar-te-ei e devorar-te-ei, primata insolente!");

                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Aperte ENTER para prosseguir");
                        Console.ReadLine ();

                        /* FIM - Segundo Diálogo*/

                        Console.Clear ();
                        /*Operador ternário */
                        bool JogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;

                        bool JogadorNaoCorreu = true;

                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;

                        /* INICIO - da TRETA */
                        if (JogadorAtacaPrimeiro) {
                            Console.Clear ();

                            System.Console.WriteLine ("*** Turno do Jogador ***");
                            System.Console.WriteLine ("Escolha sua ação:");
                            System.Console.WriteLine (" 1 - Atacar");
                            System.Console.WriteLine (" 2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine ();

                            switch (opcaoBatalhaJogador) {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random ();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);

                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Toma essa lagarto MALDJEEETO!");
                                        dragao.Vida -= poderAtaqueGuerreiro + 5;
                                        //dragao.Vida = dragao.Vida - poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine ("----------------");
                                        System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                    } else {
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Errrrooouu, humanóide tosco!");
                                    }
                                    break;
                                case "2":
                                    JogadorNaoCorreu = false;
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Simbora fii! FLW, VLW!");
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: GG EZ!");
                                    break;
                            }
                            System.Console.WriteLine ();
                            System.Console.WriteLine ("Aperte ENTER para prosseguir");
                            Console.ReadLine ();

                            while (dragao.Vida > 0 && guerreiro.Vida > 0 && JogadorNaoCorreu) {
                                Console.Clear ();
                                System.Console.WriteLine ("*** Turno do Dragão ***");
                                Random geradorNumeroAleatorio = new Random ();
                                int numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                int numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);

                                int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                if (dragaoDestrezaTotal > guerreiroDestrezaTotal) {
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Chamuscou o fiofó? Foi?");
                                    guerreiro.Vida -= dragao.Forca;
                                    //dragao.Vida = dragao.Vida - poderAtaqueGuerreiro + 5;
                                    System.Console.WriteLine ("----------------");
                                    System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                    System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                    
                                } else {
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Vem tranquilo, não se afoba não!");
                                }
                                System.Console.WriteLine ();
                                System.Console.WriteLine ("Aperte ENTER para prosseguir");
                                Console.ReadLine ();

                                /* INICIO - Turno Jogador */
                                Console.Clear ();
                                System.Console.WriteLine ("*** Turno do Jogador ***");
                                System.Console.WriteLine ("Escolha sua ação:");
                                System.Console.WriteLine (" 1 - Atacar");
                                System.Console.WriteLine (" 2 - Fugir");

                                opcaoBatalhaJogador = Console.ReadLine ();

                                switch (opcaoBatalhaJogador) {
                                    case "1":
                                        geradorNumeroAleatorio = new Random ();
                                        numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                        numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);

                                        guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                        dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                        if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                            System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Toma essa lagarto MALDJEEETO!");
                                            dragao.Vida -= poderAtaqueGuerreiro + 5;
                                            //dragao.Vida = dragao.Vida - poderAtaqueGuerreiro + 5;
                                            System.Console.WriteLine ("----------------");
                                            System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                            System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                        } else {
                                            System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Errrrooouu, humanóide tosco!");
                                        }

                                        if (guerreiro.Vida <= 0) {
                                            System.Console.WriteLine ("Jogador Mureeeeeeuuu!");
                                        }
                                        if (dragao.Vida <= 0) {
                                            System.Console.WriteLine ("El dragón murió!");
                                        }
                                        System.Console.WriteLine ();
                                        System.Console.WriteLine ("Aperte ENTER para prosseguir");
                                        Console.ReadLine ();
                                        break;
                                    case "2":
                                        JogadorNaoCorreu = false;
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Simbora fii! FLW, VLW!");
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: GG EZ!");
                                        break;
                                }
                                System.Console.WriteLine ();
                                System.Console.WriteLine ("Aperte ENTER para prosseguir");
                                Console.ReadLine ();
                                /* FIM - Turno Jogador */

                            }
                        }
                        /* FIM - da TRETA */

                        break;
                    case "0":
                        JogadorNaoDesistiu = false;
                        break;
                    default:
                        System.Console.WriteLine ("Comando inválido!");
                        break;
                }
            } while (JogadorNaoDesistiu);

        }
    }
}