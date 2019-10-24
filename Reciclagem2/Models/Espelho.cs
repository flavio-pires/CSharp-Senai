using Reciclagem2.Interfaces;

namespace Reciclagem2.Models
{
    public class Espelho : Lixos, IVidro
    {
        public string ReciclarVidro()
        {
            
            System.Console.WriteLine("Este lixo é um Vidro e deve ser jogado na lixeira Verde.");
            
            return this.GetType().Name;
        }
        
    }
}