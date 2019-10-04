namespace ByteBank3
{
    public class ContaCorrente
    {
        //Atributos da classe
        public Cliente Titular {get;set;}
        public int Agencia {get;set;}
        public int Numero {get;set;}
        public double Saldo {get;set;}

        public ContaCorrente (int Agencia, int Numero, Cliente Titular) { // construtor
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;
            this.Saldo = 0.0;
        }

        public double Deposito (double valor){ // método Depósito recebe um dado double e retorna double
            this.Saldo += valor; //soma o valor do depósito com o saldo da conta
            return this.Saldo; //retorna valor do saldo atualizado
        }

        public bool Saque (double saque) { // método Saque retorna um booleano e recebe um double
            if(saque <= this.Saldo){ // verifica se o valor do saque é menor ou igual o saldo da conta, se for verdade
                this.Saldo -= saque; // reduz o valor do saque do saldo da conta corrente
                return true;
            } else {
                return false; // se não atender a condição, não realiza o saque
            }
        }

        public bool Transferencia (ContaCorrente destino, double valorTransf) { // o método Transferencia recebe todos os dados da (classe) ContaCorrente e um double com o valor a ser transferido e retorna um booleano
            if (this.Saque(valorTransf)){ // condição o método Saque vai verificar se o valor da transferencia é menor ou igual o saldo, se for verdade
                destino.Deposito(valorTransf); //vai enviar para conta de destino através do método Deposito o valor que foi sacado
                return true;
            } else {
                return false; // se não atender a condição, não faz a transferencia
            }
        }
    }
}