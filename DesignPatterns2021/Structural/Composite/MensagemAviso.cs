using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Composite
{
    public class MensagemAviso : IMensagem
    {
        public string Texto { get; set; }

        public MensagemAviso(string texto)
        {
            Texto = texto;
        }

        public void ExibirListaNivelada(int nivel)
        {
            Console.WriteLine(new string('-', nivel) + Texto);
        }
    }
}
