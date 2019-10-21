using System;
using EscoladeRock.Interfaces;

namespace EscoladeRock.Models
{
    public class InstrumentoMusical
    {
        string[] notas = {"Dó", "Ré", "Mi", "Fá", "Sol", "Lá", "Si"};

        protected string TocarMusica()
        {
            int nota = new Random().Next(notas.Length -1);
            return notas[nota];
        }
    }
}