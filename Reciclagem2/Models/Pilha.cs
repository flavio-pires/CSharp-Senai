using Reciclagem2.Interfaces;

namespace Reciclagem2.Models
{
    public class Pilha : Lixos, INaoReciclavel
    {
        public string NaoReciclavel()
        {
            
            System.Console.WriteLine("Este lixo não é reciclável e deve ser jogado na lixeira Cinza");
            
            return this.GetType().Name;
        }
    }
}