using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Facade
{
    class Banco
    {
        public bool TemSaldoSuficiente(Cliente cliente, int total)
        {
            Console.WriteLine("Verificando o saldo do cliente " + cliente.Nome);
            return true;
        }
    }
}
