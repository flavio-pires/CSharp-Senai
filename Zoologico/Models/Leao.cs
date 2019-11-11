using ZooLogico.Interfaces;
namespace Zoologico.Models
{
    public class Leao : Animal, ITerrestre
    {
        public string Andar()
        {
            this.GetType().Name +
        }
    }
}