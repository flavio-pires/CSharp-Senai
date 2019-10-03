using System;

namespace ByteBank2
{
    class Program
    {
        static void Main(string[] args)
        {            
            System.Console.WriteLine("Conta Corrente");
            System.Console.WriteLine();
            System.Console.Write("Nome do Titular: ");
            string titular = Console.ReadLine();
            System.Console.Write("Agência: ");
            int agencia = int.Parse(Console.ReadLine());
            System.Console.Write("Número da conta: ");
            int numero = int.Parse(Console.ReadLine());
        
            bool saldoValido = false;
            do{
                System.Console.Write("Digite o Saldo: ");
                double saldo = double.Parse(Console.ReadLine());
                if (saldo >= 0){
                    saldoValido = true;
                } else {
                    System.Console.WriteLine("O saldo não pode ser negativo!");
                }
            } while(!saldoValido);

            ContaCorrente contaCorrente = new ContaCorrente (agencia,numero,titular);
            contaCorrente.Saldo = saldo;

        }
    }
}
