using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Facade
{
    class Emprestimo
    {
        public bool NaoTemEmprestimo(Cliente cliente)
        {
            Console.WriteLine("Verificando se já existe empréstimos para " + cliente.Nome);
            return true;
        }
    }
}
