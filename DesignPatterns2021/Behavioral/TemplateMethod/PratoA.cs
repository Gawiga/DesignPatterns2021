using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.TemplateMethod
{
    public class PratoA : Prato
    {
        protected override void CozinharComida()
        {
            Console.WriteLine("Cozinhando prato A!");
        }

        protected override void MontarPrato()
        {
            Console.WriteLine("Montando prato A!");
        }
    }
}
