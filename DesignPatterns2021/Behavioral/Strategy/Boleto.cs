using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Strategy
{
    public class Boleto : Pagamento
    {
        public bool Processar()
        {
            Console.WriteLine("Boleto indisponível, escolha outra forma de pagamento!");
            return false;
        }
    }
}
