using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Composite
{
    public class MensagemErro : IMensagem
    {
        public string Texto { get; set; }

        public MensagemErro(string texto)
        {
            Texto = texto;
        }

        public void ExibirListaNivelada(int nivel)
        {
            Console.WriteLine(new string('-', nivel) + Texto);
        }
    }
}
