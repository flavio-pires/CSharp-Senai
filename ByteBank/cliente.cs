using System;

namespace ByteBank
{
    public class cliente
    {
        // Comando para editar em colunas Crtl + Shift + Alt
        public string Cpf {get;set;}
        public string Nome {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}

        public cliente (string Nome, string Cpf, string Email){
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Email = Email;
        }

        public bool TrocaSenha (string senha){
            if ((senha.Length > 6) && (senha.Length < 16)){
                this.Senha = senha;
                return true;
            } else {
                return false;
            }
        }

    }
}