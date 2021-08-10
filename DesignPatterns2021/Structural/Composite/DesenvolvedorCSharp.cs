using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Composite
{
    public class DesenvolvedorCSharp : DesenvolvedorAbstrato
    {
        public override void ExibirLinguagemPrincipal()
        {
            Console.WriteLine("C#");
        }
    }
}
