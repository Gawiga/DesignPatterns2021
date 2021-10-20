using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Strategy
{
    /// <summary>
    /// Context
    /// </summary>
    public interface Pedido
    {
        public static void ProcessarOrder(Pagamento pagamento)
        {
            var sucesso = pagamento.Processar();
            
            if (sucesso)
            {
                Console.WriteLine("Pagamento efetudado com sucesso!");

            }
        }
    }
}
