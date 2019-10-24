using Reciclagem2.Interfaces;

namespace Reciclagem2.Models
{
    public class CascaBanana : Lixos, IOrganico
    {
        public string ReciclarOrganico()
        {
            
            System.Console.WriteLine("Este lixo é Orgânico e deve ser jogado na lixeira Marrom.");
            
            return this.GetType().Name;
        }
    }
}