using DesignPatterns2021.Structural.Facade;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExecutavel
{
    class Facade : IPadrao
    {
        public void Execute()
        {
            // fachada
            HipotecaFachada hipotecaFachada = new HipotecaFachada();

            Cliente cliente = new Cliente("Antônio da Silva Jardim");
            bool elegivel = hipotecaFachada.clienteEhElegivelParaHipoteca(cliente, 12000);

            Console.WriteLine("\nCliente " + cliente.Nome + " foi " + (elegivel ? "Aprovado!" : "Reprovado"));
        }
    }
}
