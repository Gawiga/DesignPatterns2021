using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.ChainOfResponsability
{
    /// <summary>
    /// ConcreteHandler
    /// </summary>
    public class Diretor : Aprovador
    {
        public override void ProcessarSolicitacao(Compra compra)
        {
            if (compra.Total < 1000.0)
            {
                Console.WriteLine("{0} solicitação de compra {1} aprovada!", GetType().Name, compra.Numero);
            }
            else if (sucessor != null)
            {
                sucessor.ProcessarSolicitacao(compra);
            }
        }
    }
}
