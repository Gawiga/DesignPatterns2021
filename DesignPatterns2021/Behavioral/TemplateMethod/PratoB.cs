using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.TemplateMethod
{
    public class PratoB : Prato
    {
        protected override void CozinharComida()
        {
            Console.WriteLine("Cozinhando prato B!");
        }

        protected override void MontarPrato()
        {
            Console.WriteLine("Montando prato B!");
        }

        /// <summary>
        /// Sobreescrevendo o Hook
        /// </summary>
        protected override void Sobremesa()
        {
            Console.WriteLine("Servindo a sobremesa do prato B!");
        }
    }
}
