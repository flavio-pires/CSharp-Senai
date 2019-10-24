using System.Collections.Generic; // Primeiro inserir a classe ao lado para o Dicionário funcionar

namespace Reciclagem2.Models
{
    public class Lixeiras
    {
        //Para criar o dictionary, inserir o tipo de dado que vai ser capturado e as classes, depois inserir a variável para armazenar o que o usuario vai digitar
        public static Dictionary <int, Lixos> lixos = new Dictionary <int, Lixos>
        {
            {1, new CascaBanana()},
            {2, new Espelho()},
            {3, new GarrafaPET()},
            {4, new Parafuso()},
            {5, new Pilha()},
            {6, new Revistas()},
        };
    }
}