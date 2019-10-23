using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Garrafa : Lixo, IVidro
    {
        public string ReciclarFeitoVidro()
        {
            return this.GetType().Name; // GetType . Name recupera o nome da classe, no caso Garrafa ... type é o tipo do objeto, se é srting ou int, etc
        }
    }
}