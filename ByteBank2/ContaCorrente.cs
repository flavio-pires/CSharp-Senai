namespace ByteBank2
{
    public class ContaCorrente
    {
        public string Titular {get;set;}
        public int Agencia {get;set;}
        public int Numero {get;set;}
        public double Saldo {get;set;}

        public ContaCorrente (int Agencia, int Numero, string Titular) {
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;
            this.Saldo = 0.0;
        }

        

    }
}