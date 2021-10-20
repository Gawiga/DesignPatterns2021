using DesignPatterns2021.Behavioral.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExecutavel
{
    class BehavioralStrategy
    {
        public static void Execute()
        {
            var opcao = "";
            while (opcao != "9")
            {
                Console.WriteLine("Selecione uma forma de pagamento\n1 - Cartão de Crédito\n2 - Boleto\n3 - PIX\n9 - SAIR");
                opcao = Console.ReadLine();
                if (opcao == "1")
                {
                    RealizarPedido.ProcessarOrder(new CartaoDeCredito());
                }
                if (opcao == "2")
                {
                    RealizarPedido.ProcessarOrder(new Boleto());
                }
                if (opcao == "3")
                {
                    RealizarPedido.ProcessarOrder(new Pix());
                }
            }

        }
    }
}
