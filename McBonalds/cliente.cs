using System;

namespace McBonalds
{
    public class cliente
    {   //Atributos
        public string Nome {get;set;}
        public string Endereco {get;set;}
        public string Telefone {get;set;}
        public string Senha {get;set;}
        public string Email {get;set;}
        public DateTime DataNascimento {get;set;}

        //Construtor
        public cliente(string nome, string telefone, string email){
            this.Nome = nome;
            this.Telefone = telefone;
            this.Email = email;
        }
    }
}