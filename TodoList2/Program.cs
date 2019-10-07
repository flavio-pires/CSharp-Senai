using System;
using System.IO; //Primeiro passo incluir System.IO
using System.Collections.Generic; //Utilizar este using, pois será adicionado uma lista


namespace TodoList
{
    class Program
    {
        static int Main(string[] args) // trocado o tipo de aplicação de void pra int, pois o programa irá retornar um código de erro
        {
            List <TodoItem> todoList = new List <TodoItem>();
            string fileName = "todo.csv"; //variável para chamar o nome do arquivo
            string filePath = ".\\" + fileName; // caminho da pasta onde o arquivo está

            todoList = initList(@filePath);

            if(todoList == null){
                return -1;
            }
            
            int opcao = 0;

            do{
                Console.Clear();
                System.Console.WriteLine("Todo List");
                System.Console.WriteLine();
                ListaItens(todoList);
                System.Console.WriteLine();
                System.Console.WriteLine("Digite uma opção");
                System.Console.WriteLine("1 - Adicionar Item");
                System.Console.WriteLine("2 - Remover Item");
                System.Console.WriteLine("3 - Terminar");
                System.Console.Write("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao){
                    case 1:
                        AddItem(todoList);
                        break;
                    case 2:
                        RemoveItem(todoList);
                        break;
                    case 3:
                        System.Console.WriteLine("Tchau!");
                        break;
                    default:
                        System.Console.WriteLine("Opção Inválida");
                        Console.ReadLine();
                        break;
                }
                
            } while(opcao != 3);
            return 0;
            
        }

        static List<TodoItem> initList (string filePath)
        {
            List<TodoItem> todoList = new List<TodoItem>();

            try{ //para ler o arquivo
                string[] todoFile = File.ReadAllLines(@filePath); //ler o arquivo e quebrar em linhas

                foreach(string line in todoFile){ //vetor de string é lido no arquivo. Utilizado para adicionar e remover itens
                    string[] itens = line.Split(","); //procura o caractere virgula e quebra no meio... pega a string e quebra ela na virgula
                    string titulo = itens[0].Replace("\"","");
                    string nota = itens[1].Replace("\"","");
                    TodoItem todoItem = new TodoItem(titulo,nota);
                    todoList.Add(todoItem);
                }
                todoList.RemoveAt(0);
                return todoList;
            } catch(IOException e){ //utilizado para tratar a exceção
                System.Console.WriteLine("Erro de Acesso");
                System.Console.WriteLine(e.Message);
                return null; //é utilizado para abortar a aplicação. 0 termina a aplicação corretamente. -1 deu merda
            }
        }

        static void ListaItens(List<TodoItem> todoList){
            Console.Clear();
            
            int count = 1;
            System.Console.WriteLine("Todo List");
            System.Console.WriteLine();
            System.Console.WriteLine($"ID {"",2} Titulo {"",12} Notas"); //string para apresentar cabeçalho
            foreach(TodoItem item in todoList) { //utilizado para ler todos os itens da lista e imprimir na tela
                System.Console.WriteLine($"{count,3}: {item.Titulo,-15} - {item.Nota}");
                count++;
            }
        }

        static void AddItem(List<TodoItem> todoList){
            Console.Clear();
            System.Console.WriteLine("Novo Item");
            System.Console.WriteLine();
            System.Console.Write("Titulo: ");
            string titulo = Console.ReadLine();
            System.Console.Write("Nota: ");
            string nota = Console.ReadLine();
            TodoItem item = new TodoItem(titulo,nota);
            todoList.Add(item);
        }

        static void RemoveItem(List<TodoItem> todoList){
            int index = 0;

            do{
                Console.Clear();
                System.Console.WriteLine("Remove Item");
                System.Console.WriteLine();
                ListaItens(todoList);
                System.Console.WriteLine();
                System.Console.WriteLine("Digite o ID ou X para terminar");
                System.Console.WriteLine("ID: ");
                string id = Console.ReadLine();
                
                if(id.ToUpper()  == "X"){
                    break;
                } else {
                    index = int.Parse(id) -1;
                }

                if((index < 0) || (index > todoList.Count -1)){
                    System.Console.WriteLine("ID inválido");
                    System.Console.WriteLine("Pressione <enter> para ocntinuar");
                    Console.ReadLine();
                    
                } else {
                    todoList.RemoveAt(index);
                }

            } while(true);
        }
    }
}
