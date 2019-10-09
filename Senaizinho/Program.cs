using System;
using System.Collections.Generic;
using System.IO;

namespace Senaizinho {
    class Program {
        static void Main (string[] args) {
            List<Aluno> todoList = new List<Aluno> ();
            string fileName = "alunos.csv";
            string filePath = ".\\" + fileName;
            todoList = initList (@filePath);
            int opcao = 0;

            do {
                System.Console.WriteLine ("Escola Senaizinho");
                System.Console.WriteLine ();
                Console.WriteLine ("Digite a opção desejada");
                Console.WriteLine ("1 - Cadastrar Aluno");
                Console.WriteLine ("2 - Alocar Aluno");
                Console.WriteLine ("3 - Remover Aluno");
                Console.WriteLine ("4 - Verificar Salas");
                Console.WriteLine ("5 - Verificar Alunos");
                Console.WriteLine ("0 - Sair");
                Console.Write ("Opção: ");
                opcao = int.Parse (Console.ReadLine ());
                Console.Clear ();

                switch (opcao) {
                    case 1:
                        CadastrarAluno (todoList);
                        break;
                    case 2:
                        System.Console.WriteLine ("Alocar Aluno");
                        System.Console.WriteLine ();
                        System.Console.Write ("Digite o número da sala que deseja inserir o aluno: ");
                        string sala = Console.ReadLine ();

                        if (sala <= 10) {
                            System.Console.WriteLine ($"A sala possui atualmente {capacidadeAtual}");
                        }

                }
            } while (opcao != 0);

        }

        static Aluno CadastrarAluno () {
            Aluno alunos = new Aluno ();
            System.Console.WriteLine ("Cadastrar Aluno");
            System.Console.WriteLine ();
            System.Console.Write ("Nome: ");
            string nome = Console.ReadLine ();
            System.Console.Write ("Data de Nascimento: ");
            DateTime dataNascimento = DateTime.Parse (Console.ReadLine ());
            System.Console.Write ("Curso: ");
            string curso = Console.ReadLine ();

            
            return alunos;
        }
    }

}