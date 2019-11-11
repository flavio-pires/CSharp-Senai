using ZooLogico.Interfaces;
namespace Zoologico.Models
{
    public class Golfinho: Animal, IAquatico
    {
        public string Nadar()
        {
            return this.GetType().Name + "sabe nadar!";
        }
    }
}