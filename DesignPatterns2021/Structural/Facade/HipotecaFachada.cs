using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Facade
{
    /// <summary>
    /// Classe Facade 
    /// </summary>
    public class HipotecaFachada
    {
        Banco banco = new Banco();
        Emprestimo emprestimo = new Emprestimo();
        Credito credito = new Credito();

        public bool clienteEhElegivelParaHipoteca(Cliente cliente, int total)
        {
            Console.WriteLine("{0} está pedido {1:C} como empréstimo", cliente.Nome, total);

            bool elegivel = true;

            if (!banco.TemSaldoSuficiente(cliente, total))
            {
                elegivel = false;
            }
            else if (!emprestimo.NaoTemEmprestimo(cliente))
            {
                elegivel = false;
            }
            else if (!credito.TemBomCredito(cliente))
            {
                elegivel = false;
            }

            return elegivel;
        }
    }
}
