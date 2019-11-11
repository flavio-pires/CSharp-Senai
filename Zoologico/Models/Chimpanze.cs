using ZooLogico.Interfaces;
namespace Zoologico.Models
{
    public class Chimpanze : Animal, IArboricula
    {
        public string EscalarArvores()
        {
            return this.GetType().Name + "sobe em árvore!";
        }
    }
}