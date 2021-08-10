using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Composite
{
    public class DesenvolvedorJava : DesenvolvedorAbstrato
    {
        public override void ExibirLinguagemPrincipal()
        {
            Console.WriteLine("JAVA");
        }
    }
}
