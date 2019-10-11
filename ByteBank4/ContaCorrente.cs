namespace ByteBank4
{
    public class ContaCorrente
    {
         //Atributos da classe
        public Cliente Titular {get;set;}
        public int Agencia {get;set;}
        public int Numero {get;set;}
        private double _saldo {get;set;}
        public double Saldo
        { 
            get {return _saldo;}
        }

        //atalho = mudar todas as palavras iguais/ selecione a palavra, aperte F2 e digite a palavra

        public ContaCorrente (int Agencia, int Numero, Cliente Titular) { // construtor
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;
            this._saldo = 0.0;
        }

        public double Deposito (double valor){ // método Depósito recebe um dado double e retorna double
            this._saldo += valor; //soma o valor do depósito com o saldo da conta
            return this._saldo; //retorna valor do saldo atualizado
        }

        public bool Saque (double saque) { // método Saque retorna um booleano e recebe um double
            if(saque <= this._saldo){ // verifica se o valor do saque é menor ou igual o saldo da conta, se for verdade
                this._saldo -= saque; // reduz o valor do saque do saldo da conta corrente
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