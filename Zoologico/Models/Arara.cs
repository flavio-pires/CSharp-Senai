using ZooLogico.Interfaces;
namespace Zoologico.Models
{
    public class Arara : Animal, IVoador
    {
        public string Voar()
        {
            return this.GetType().Name + "consegue voar!";
        }
    }
}