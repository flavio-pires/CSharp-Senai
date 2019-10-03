using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Cadastro de Clientes");
            System.Console.WriteLine();
            System.Console.Write("Nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            System.Console.Write("Email: ");
            string email = Console.ReadLine();

            cliente cliente1 = new cliente(nome,cpf,email);

            bool senhaOk = false;
            do{
                System.Console.Write("Digite a Senha: ");
                string senha = Console.ReadLine();
                senhaOk = cliente1.TrocaSenha (senha);
                if (!senhaOk){
                    System.Console.WriteLine("Senha não atende aos requisitos !");
                } else {
                    System.Console.WriteLine("Senha trocada com sucesso !");
                }
            } while(!senhaOk);
            
        }
    }

    
}
