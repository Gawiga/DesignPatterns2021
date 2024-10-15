using DesignPatterns2021.Behavioral.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExecutavel
{
    class State : IPadraoExecutavel
    {
        public void Execute()
        {
            var opcao = "";

            while (opcao != "9")
            {
                Console.WriteLine("Digite 9 para sair!");
                opcao = Console.ReadLine();

                var cliente = new Cliente("Jeremis do Sertão");

                cliente.Depositar(120.00);
                cliente.PagarJuros();
                cliente.Depositar(500.00);
                cliente.PagarJuros();
                cliente.Sacar(200.00);
                cliente.Depositar(9000.00);
                cliente.PagarJuros();
                cliente.Sacar(cliente.Balanco);
                cliente.Depositar(100);
                cliente.PagarJuros();
            }
        }
    }
}
