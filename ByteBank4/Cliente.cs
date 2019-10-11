namespace ByteBank4
{
    public class Cliente
    {
        // Comando para editar em colunas Crtl + Shift + Alt
        private string _cpf;
        public string Cpf
        { 
            get {return _cpf;}
        }
        private string _nome;
        public string Nome
        { 
            get {return _nome;}
        }
        private string _email;
        public string Email
        { 
            get {return _email;}
        }
        private string _senha;
        public string Senha
        { 
            get {return _senha;}
        }

        public Cliente (string Nome, string Cpf, string Email){
            this._nome = Nome;
            this._cpf = Cpf;
            this._email = Email;
        }

        public bool TrocaSenha (string senha){
            if ((senha.Length > 6) && (senha.Length < 16)){
                this._senha = senha;
                return true;
            } else {
                return false;
            }
        }
    }
}