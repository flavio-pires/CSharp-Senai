using System;

namespace ByteBank4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine ("Cadastro de Clientes");
            System.Console.WriteLine ();
            System.Console.Write ("Nome: ");
            string nome = Console.ReadLine ();
            System.Console.Write ("CPF: ");
            string cpf = Console.ReadLine ();
            System.Console.Write ("Email: ");
            string email = Console.ReadLine ();

            Cliente cliente1 = new Cliente (nome, cpf, email);

            bool senhaOk = false;
            do {
                System.Console.Write ("Digite a Senha: ");
                string senha = Console.ReadLine ();
                senhaOk = cliente1.TrocaSenha (senha);
                if (!senhaOk) {
                    System.Console.WriteLine ("Senha não atende aos requisitos !");
                } else {
                    System.Console.WriteLine ("Senha trocada com sucesso !");
                }
            } while (!senhaOk);

            System.Console.WriteLine ("Cadastro de Conta Corrente");
            System.Console.WriteLine ();
            //System.Console.Write ("Nome do Titular: ");
            //string titular = Console.ReadLine ();
            System.Console.Write ("Agência: ");
            int agencia = int.Parse (Console.ReadLine ());
            System.Console.Write ("Número da conta: ");
            int numero = int.Parse (Console.ReadLine ());
            System.Console.WriteLine("Conta cadastrada!");
            Console.Clear();
            
            int opcao;
            do{
                System.Console.WriteLine("Digite uma opção");
                System.Console.WriteLine("1 - Depósito");
                System.Console.WriteLine("2 - Saque");
                System.Console.WriteLine("3 - Transferência");
                System.Console.WriteLine("4 - Encerrar");        
                System.Console.Write("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao){
                    case 1:
                        Deposito();
                        break;
                    case 2:
                        Saque();
                        break;
                    case 3:
                        Transferencia();
                        break;
                    case 4:
                        System.Console.WriteLine("Obrigado!");
                        break;
                    default:
                        Console.Clear();
                        System.Console.WriteLine("Opção Inválida!");
                        System.Console.WriteLine("Aperte <Enter> para continuar");
                        Console.ReadLine();
                        
                        break;
                }
                
            } while(opcao != 4);

        }
    
        static void Deposito(){
            bool saldoValido = false;
            double saldo;
            ContaCorrente contaCorrente = new ContaCorrente (agencia, numero, cliente1);
            contaCorrente.Deposito (saldo);
            System.Console.WriteLine("ByteBank - Depósito");
            Cliente usuario = contaCorrente.Titular;
            System.Console.WriteLine($"Bem vindo - {usuario.Nome}");
            System.Console.WriteLine($"Agencia: {contaCorrente.Agencia} Conta: {contaCorrente.Numero}");
            System.Console.WriteLine($"Saldo: {contaCorrente.Saldo}");
            Console.Write("Digite o valor do depósito: ");
            double valor = double.Parse(Console.ReadLine());
            saldo = contaCorrente.Deposito(valor);
            do {
                if (saldo >= 0) {
                    saldoValido = true;
                } else {
                    System.Console.WriteLine ("O saldo não pode ser negativo!");
                }
            } while (!saldoValido);
            System.Console.WriteLine($"Saldo atual: {saldo}");
        }

        static void Saque(){
            Console.WriteLine("ByteBank - Saque");
            Console.WriteLine($"Bem vindo - {usuario.Nome}");
            Console.WriteLine($"Agencia: {contaCorrente.Agencia}   Conta: {contaCorrente.Numero}");
            Console.WriteLine($"Saldo: {contaCorrente.Saldo}");
            Console.Write("Digite o valor do saque:  ");
            valor = double.Parse(Console.ReadLine());
            if(contaCorrente.Saque(valor)){
                Console.WriteLine("Saque realizado com sucesso. Retire as notas");
            } else {
                Console.WriteLine("Não foi possivel realizar a operação");

            }
            Console.WriteLine($"Saldo atual: {contaCorrente.Saldo}");
        }

        static void Transferencia(){
            Cliente cliente2 = new Cliente("Alexandre","123.321.123-12","a@a.com");
            ContaCorrente contaCorrente2 = new ContaCorrente(123,132,cliente2);
            Console.WriteLine("ByteBank - Transferencia");
            Console.WriteLine($"Bem vindo - {usuario.Nome}");
            Console.WriteLine($"Agencia: {contaCorrente.Agencia}   Conta: {contaCorrente.Numero}");
            Console.WriteLine($"Saldo origem: {contaCorrente.Saldo}");
            Console.WriteLine($"Saldo destino: {contaCorrente2.Saldo}");
            Console.Write("Digite o valor da tranferência: ");
            valor = double.Parse(Console.ReadLine());
        
            if (contaCorrente.Transferencia(contaCorrente2,valor)){
                Console.WriteLine("Tranferencia efetuada com sucesso.");
            } else {
                Console.WriteLine("Operação não pode ser realizada.");
            }
            Console.WriteLine($"Saldo origem: {contaCorrente.Saldo}");
            Console.WriteLine($"Saldo destino: {contaCorrente2.Saldo}");
        }
    }
}
