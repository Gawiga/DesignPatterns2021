using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Facade
{
    class Credito
    {
        public bool TemBomCredito(Cliente cliente)
        {
            Console.WriteLine("Verificando o crédito para " + cliente.Nome);
            return true;
        }
    }
}
