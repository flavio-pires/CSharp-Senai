using System;
namespace IMC
{
    public class Paciente
    {
        public string Nome {get;set;}
        public double Peso {get;set;}
        public double Altura {get;set;}

        public Paciente (string Nome, double Peso, double Altura)
        {
            this.Nome = Nome;
            this.Peso = Peso;
            this.Altura = Altura;
        }
    }
}