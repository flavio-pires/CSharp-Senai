using Reciclagem2.Interfaces;

namespace Reciclagem2.Models
{
    public class Parafuso : Lixos, IMetal
    {
        public string ReciclarMetal()
        {
            
            System.Console.WriteLine("Este lixo é um Metal e deve ser jogado na lixeira Amarela.");
            
            return this.GetType().Name;
        }
    }
}