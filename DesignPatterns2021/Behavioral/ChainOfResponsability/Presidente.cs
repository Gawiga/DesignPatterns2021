using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.ChainOfResponsability
{
    public class Presidente : Aprovador
    {
        public override void ProcessarSolicitacao(Compra compra)
        {
            if (compra.Total < 25000.0)
            {
                Console.WriteLine("{0} solicitação de compra {1} aprovada!", GetType().Name, compra.Numero);
            }
            else
            {
                Console.WriteLine("Compra {0} necessita de uma reunião com o conselho para ser aprovada.", compra.Numero);
            }
        }
    }
}
