using Reciclagem2.Interfaces;

namespace Reciclagem2.Models
{
    public class Revistas : Lixos, IPapel
    {
        public string ReciclarPapel()
        {
            
            System.Console.WriteLine("Este lixo é um Papel e deve ser jogado na lixeira Azul");
            
            return this.GetType().Name;
        }
    }
}