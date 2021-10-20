using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Strategy
{
    public class CartaoDeCredito : Pagamento
    {
        public bool Processar()
        {
            Console.WriteLine("Processando Cartão de Crédito...");
            return true;
        }
    }
}
