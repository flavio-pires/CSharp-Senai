using System;
using System.IO; //Primeiro passo incluir System.IO
using System.Collections.Generic; //Utilizar este using, pois será adicionado uma lista


namespace TodoList
{
    class Program
    {
        static int Main(string[] args) // trocado o tipo de aplicação de void pra int, pois o programa irá retornar um código de erro
        {
            List <TodoItem> todoList = new List <TodoItem>(); // "TodoItem" é o tipo de dados que a lista vai armazenar
            string fileName = "todo.csv"; //variável para chamar o nome do arquivo
            string filePath = ".\\" + fileName; // caminho da pasta onde o arquivo está

            todoList = initList(@filePath);

            if(todoList == null){ // se a lista de afazeres for nula, significa que não carregou
                return -1; // encerra a aplicação
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
                        SaveList (todoList, @filePath); //o método SaveList não vai retornar nennhum valor e vai solicitar a variável todoList
                        break;
                    default:
                        Console.Clear();
                        System.Console.WriteLine("Opção Inválida!");
                        System.Console.WriteLine("Aperte <Enter> para continuar");
                        Console.ReadLine();
                        
                        break;
                }
                
            } while(opcao != 3);
            return 0;
            
        }
        //Inicializa a lista de itens
        static List<TodoItem> initList (string filePath) // criei um método initList, que chama a classe List que recebe o tipo de dado "TodoItem" e envia uma string para a variável filePath 
        {
            List<TodoItem> todoList = new List<TodoItem>();

            try{ //para ler o arquivo
                string[] todoFile = File.ReadAllLines(@filePath); //faz a leitura de todo o arquivo e joga dentro do vetor string -- ReadAllLines ler o arquivo e quebrar em linhas
                // foreach pega todos os itens 
                foreach(string line in todoFile){ //vetor de string é lido no arquivo. Utilizado para adicionar e remover itens.. lido linha por linha
                    string[] itens = line.Split(","); //procura dentro do vetor string o caractere virgula e quebra no meio... pega a string e quebra ela na virgula
                    string titulo = itens[0].Replace("\"",""); // retira todas as aspas que tem no arquivo e não coloca nada no lugar
                    string nota = itens[1].Replace("\"","");
                    TodoItem todoItem = new TodoItem(titulo,nota);
                    todoList.Add(todoItem); // .Add adiciona para a variável todolist o dado "todoItem" que possui as variáveis pedidas acima, "titulo,nota"
                }
                todoList.RemoveAt(0); // remove o cabeçalho do arquivo, indice 0
                return todoList; // após executar os passos acima retorna as informações inseridas no programa dentro da variável "todoList"
            } catch(IOException e){ //utilizado para tratar a exceção
                System.Console.WriteLine("Erro de Acesso");
                System.Console.WriteLine(e.Message); //dentro do objeto "e" é chamado o atributo "Message" para mostrar a mensagem.
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

        static void AddItem(List<TodoItem> todoList){ // todoList é o parametro enviado para o metodo
            Console.Clear();
            System.Console.WriteLine("Novo Item");
            System.Console.WriteLine();
            System.Console.Write("Titulo: ");
            string titulo = Console.ReadLine();
            System.Console.Write("Nota: ");
            string nota = Console.ReadLine();
            TodoItem item = new TodoItem(titulo,nota);
            todoList.Add(item); //.Add adiciona para a variável todolist o dado "todoItem" que possui as variáveis pedidas acima, "titulo,nota"
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
        //Gravar os dados inseridos na lista
        static void SaveList(List<TodoItem> lista, string path){
            List<string> linhas = new List<string>(); //linhas é uma variável da classe List que tem todos os itens de afazeres. é um método construtor pois possui parentes no final
            linhas.Add("Titulo, Nota");
            foreach(TodoItem item in lista){ //foreach para cada item dentro da lista ele vai executar o passo abaixo
                string titulo = "\"" + item.Titulo + "\"";
                string nota = "\"" + item.Nota + "\"";
                linhas.Add(titulo + "," + nota);
            }
            string tryAgain = "n";
            do{
                try{
                    File.WriteAllLines(@path,linhas); //método que vai gravar no disco
                    tryAgain = "n";
                } catch(IOException e){
                    System.Console.WriteLine("Erro na leitura do arquivo.");
                    System.Console.WriteLine(e.Message);
                    do{
                        System.Console.WriteLine("Deseja tentar novamente (S/N) ?");
                        tryAgain = Console.ReadLine().ToLower();
                        if ((tryAgain != "n") || (tryAgain != "s")){
                            System.Console.WriteLine("Opção inválida");
                        }
                    } while ((tryAgain == "s") || (tryAgain == "n"));

                    
                }
            } while(tryAgain != "n");
        }
    }
}
