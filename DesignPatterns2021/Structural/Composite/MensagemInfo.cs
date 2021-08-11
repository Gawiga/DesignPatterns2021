using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Composite
{
    /// <summary>
    /// Leaf
    /// </summary>
    public class MensagemInfo : IMensagem
    {
        public string Texto { get; set; }

        public MensagemInfo(string texto)
        {
            Texto = texto;
        }

        public void ExibirListaNivelada(int nivel)
        {
            Console.WriteLine(new string('-', nivel) + Texto);
        }
    }
}
