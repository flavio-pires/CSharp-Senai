using Reciclagem2.Interfaces;

namespace Reciclagem2.Models
{
    public class GarrafaPET : Lixos, IPlastico
    {
        public string ReciclarPlastico()
        {
            
            System.Console.WriteLine("Este lixo é um plástico e deve ser jogado na lixeira Vermelha.");
            
            return this.GetType().Name;
        }
    }
}